using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;
using DentalClinicProject.classes;
using DentalClinicProject.data;

namespace DentalClinicProject.UI
{
    public partial class DailyRevenueControl : UserControl
    {
        private sealed class DailyRevenueRow
        {
            public string CaseNumber { get; set; }
            public string PatientName { get; set; }
            public string DoctorName { get; set; }
            public string Treatment { get; set; }
            public decimal FinalPrice { get; set; }
            public decimal CommissionPct { get; set; }
            public decimal DoctorShare { get; set; }
            public decimal ClinicShare { get; set; }
        }

        private readonly List<DailyRevenueRow> _reportRows = new List<DailyRevenueRow>();
        private decimal _totalRevenue;
        private decimal _totalDoctorShares;
        private decimal _totalClinicProfit;
        private int _printRowIndex;

        private static readonly Font PrintHeaderFont = new Font("Segoe UI", 16f, FontStyle.Bold);
        private static readonly Font PrintSubHeaderFont = new Font("Segoe UI", 12f, FontStyle.Bold);
        private static readonly Font PrintNormalFont = new Font("Segoe UI", 9f, FontStyle.Regular);
        private static readonly Font PrintBoldFont = new Font("Segoe UI", 9f, FontStyle.Bold);

        public DailyRevenueControl()
        {
            InitializeComponent();
            SetupLogic();
        }

        private void SetupLogic()
        {
            //dtpReportDate.Value = DateTime.Today;

            StyleSummaryCard(panelCardCases);
            StyleSummaryCard(panelCardRevenue);

            SetupGridColumns();
            StyleDataGrid();
            StyleActionButton(btnPrintFooter, false);
            StyleActionButton(btnConfirmClosure, true);

            ThemeManager.ApplyThemeToControls(Controls);

            Load += (s, e) => LoadReport();
            //dtpReportDate.ValueChanged += (s, e) => LoadReport();
            btnPrintFooter.Click += (s, e) => PrintReport();
            btnConfirmClosure.Click += BtnConfirmClosure_Click;
        }

        private void StyleSummaryCard(Panel card)
        {
            card.Paint += (s, e) =>
            {
                var rect = card.ClientRectangle;
                rect.Width -= 1;
                rect.Height -= 1;
                using (var pen = new Pen(ThemeManager.BorderLight))
                    e.Graphics.DrawRectangle(pen, rect);
            };
        }

        private void StyleActionButton(Button btn, bool primary)
        {
            ThemeManager.StyleButton(btn, primary);
            var normalBack = btn.BackColor;
            var normalFore = btn.ForeColor;
            btn.MouseEnter += (s, e) =>
            {
                btn.BackColor = primary
                    ? Color.FromArgb(0, 95, 185)
                    : Color.FromArgb(206, 212, 218);
            };
            btn.MouseLeave += (s, e) =>
            {
                btn.BackColor = normalBack;
                btn.ForeColor = normalFore;
            };
        }

        private void StyleDataGrid()
        {
            ThemeManager.StyleDataGridView(dgvDailyCases);
            dgvDailyCases.ColumnHeadersDefaultCellStyle.BackColor = ThemeManager.PrimaryColor;
            dgvDailyCases.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvDailyCases.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 250);
            dgvDailyCases.DefaultCellStyle.SelectionBackColor = Color.FromArgb(220, 235, 250);
            dgvDailyCases.DefaultCellStyle.SelectionForeColor = ThemeManager.TextDark;
        }

        private void SetupGridColumns()
        {
            dgvDailyCases.Columns.Clear();
            dgvDailyCases.Columns.Add("colCaseNumber", "رقم الحالة");
            dgvDailyCases.Columns.Add("colPatient", "اسم الحالة");
            dgvDailyCases.Columns.Add("colDoctor", "الطبيب المعالج");
            dgvDailyCases.Columns.Add("colTreatment", "الخدمات المقدمة");
            dgvDailyCases.Columns.Add("colAmount", "المبلغ (د.ل)");
        }

        private void LoadReport()
        {
            //DateTime selectedDate = dtpReportDate.Value.Date;
            _reportRows.Clear();

            var completedCases = DataStore.Cases
                //.Where(c => c.Status == CaseStatus.Completed && c.OpenedDate.Date == selectedDate)
                .OrderBy(c => c.OpenedDate)
                .ToList();

            foreach (var c in completedCases)
            {
                var doctor = DataStore.Doctors.FirstOrDefault(d => d.DoctorId == c.DoctorId);
                decimal commissionPct = doctor?.CommissionPct ?? 0m;
                decimal finalPrice = c.FinalPrice;
                decimal doctorShare = Math.Round(finalPrice * commissionPct / 100m, 2);
                decimal clinicShare = finalPrice - doctorShare;

                _reportRows.Add(new DailyRevenueRow
                {
                    CaseNumber = c.CaseNumber ?? "",
                    PatientName = c.PatientName ?? "",
                    DoctorName = c.DoctorName ?? "",
                    Treatment = c.Treatment ?? "",
                    FinalPrice = finalPrice,
                    CommissionPct = commissionPct,
                    DoctorShare = doctorShare,
                    ClinicShare = clinicShare
                });
            }

            dgvDailyCases.Rows.Clear();
            foreach (var row in _reportRows)
            {
                dgvDailyCases.Rows.Add(
                    row.CaseNumber,
                    row.PatientName,
                    row.DoctorName,
                    row.Treatment,
                    FormatCurrency(row.FinalPrice));
            }

            _totalRevenue = _reportRows.Sum(r => r.FinalPrice);
            _totalDoctorShares = _reportRows.Sum(r => r.DoctorShare);
            _totalClinicProfit = _reportRows.Sum(r => r.ClinicShare);

            UpdateSummaryUi();
            //UpdateClosureButtonState(selectedDate);
        }

        private void UpdateSummaryUi()
        {
            lblTotalCasesValue.Text = _reportRows.Count.ToString();
            lblTotalRevenueValue.Text = FormatCurrency(_totalRevenue);

            lblFooterTotalRevenue.Text = $"📈 إجمالي الإيرادات: {FormatCurrency(_totalRevenue)}";
            lblFooterDoctorShares.Text = $"👨‍⚕️ إجمالي مستحقات الأطباء: {FormatCurrency(_totalDoctorShares)}";
        }

        private void UpdateClosureButtonState(DateTime selectedDate)
        {
            bool alreadyClosed = DataStore.DailyRevenueClosedDates.Contains(selectedDate);
            btnConfirmClosure.Enabled = !alreadyClosed;
            btnConfirmClosure.Text = alreadyClosed
                ? "✅ تم إغلاق هذا اليوم"
                : "✅ تأكيد إغلاق اليوم";
        }

        private void BtnConfirmClosure_Click(object sender, EventArgs e)
        {
            //DateTime selectedDate = dtpReportDate.Value.Date;

            //if (DataStore.DailyRevenueClosedDates.Contains(selectedDate))
            //{
            //    MessageBox.Show(
            //        "تم إغلاق إيرادات هذا اليوم مسبقاً.",
            //        "تنبيه",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Information);
            //    return;
            //}

            if (_reportRows.Count == 0)
            {
                var emptyConfirm = MessageBox.Show(
                    "لا توجد حالات مكتملة في هذا التاريخ. هل تريد تأكيد الإغلاق على أي حال؟",
                    "تأكيد",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (emptyConfirm != DialogResult.Yes)
                    return;
            }
            else
            {
                var confirm = MessageBox.Show(
                    //$"تأكيد إغلاق إيرادات يوم {selectedDate:yyyy/MM/dd}؟\n\n" +
                    $"عدد الحالات: {_reportRows.Count}\n" +
                    $"إجمالي الإيرادات: {FormatCurrency(_totalRevenue)}",
                    "تأكيد إغلاق اليوم",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (confirm != DialogResult.Yes)
                    return;
            }

            //DataStore.DailyRevenueClosedDates.Add(selectedDate);
            //UpdateClosureButtonState(selectedDate);

            MessageBox.Show(
                "تم إغلاق إيرادات اليوم بنجاح",
                "تم",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        public void PrintReport()
        {
            if (_reportRows.Count == 0)
            {
                MessageBox.Show(
                    "لا توجد بيانات للطباعة في التاريخ المحدد.",
                    "طباعة",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            _printRowIndex = 0;

            using (var pd = new PrintDocument())
            {
                pd.DocumentName = "تقرير إيرادات اليوم";
                pd.PrintPage += PrintDocument_PrintPage;

                using (var preview = new PrintPreviewDialog
                {
                    Document = pd,
                    Width = 900,
                    Height = 700,
                    ShowIcon = false,
                    Text = "معاينة تقرير إيرادات اليوم"
                })
                {
                    preview.ShowDialog();
                }
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            int margin = 40;
            int y = margin;
            int pageWidth = e.MarginBounds.Width;
            int left = e.MarginBounds.Left;
            int right = e.MarginBounds.Right;
            //DateTime reportDate = dtpReportDate.Value.Date;
            string preparer = GetPreparerName();

            var centerFormat = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            var rtlFormat = new StringFormat
            {
                FormatFlags = StringFormatFlags.DirectionRightToLeft,
                Alignment = StringAlignment.Near,
                LineAlignment = StringAlignment.Center
            };

            if (_printRowIndex == 0)
            {
                g.DrawString("عيادة DentCare للأسنان", PrintHeaderFont, Brushes.Black,
                    new RectangleF(left, y, pageWidth, 36), centerFormat);
                y += 36;
                //g.DrawString($"تقرير إيرادات اليوم — {reportDate:yyyy/MM/dd}", PrintSubHeaderFont, Brushes.Black,
                //    new RectangleF(left, y, pageWidth, 28), centerFormat);
                //y += 36;
                //g.DrawLine(Pens.Black, left, y, right, y);
                //y += 16;

                string[] headers =
                {
                    "رقم الحالة", "اسم الحالة", "الطبيب", "الخدمة", "المبلغ"
                };
                int colWidth = pageWidth / headers.Length;
                for (int i = 0; i < headers.Length; i++)
                {
                    var rect = new Rectangle(left + (i * colWidth), y, colWidth, 24);
                    using (var brush = new SolidBrush(ThemeManager.PrimaryColor))
                        g.FillRectangle(brush, rect);
                    g.DrawString(headers[i], PrintBoldFont, Brushes.White, rect, centerFormat);
                }
                y += 28;
            }

            int rowHeight = 22;
            int maxRowsPerPage = Math.Max(1, (e.MarginBounds.Bottom - y - 120) / rowHeight);

            for (int i = 0; i < maxRowsPerPage && _printRowIndex < _reportRows.Count; i++, _printRowIndex++)
            {
                var row = _reportRows[_printRowIndex];
                string[] cells =
                {
                    row.CaseNumber,
                    row.PatientName,
                    row.DoctorName,
                    row.Treatment,
                    row.FinalPrice.ToString("F2")
                };

                int colWidth = pageWidth / cells.Length;
                if (_printRowIndex % 2 == 1)
                {
                    using (var altBrush = new SolidBrush(Color.FromArgb(248, 249, 250)))
                        g.FillRectangle(altBrush, left, y, pageWidth, rowHeight);
                }

                for (int c = 0; c < cells.Length; c++)
                {
                    var rect = new Rectangle(left + (c * colWidth), y, colWidth, rowHeight);
                    g.DrawString(cells[c], PrintNormalFont, Brushes.Black, rect, centerFormat);
                }
                y += rowHeight;
            }

            if (_printRowIndex < _reportRows.Count)
            {
                e.HasMorePages = true;
                return;
            }

            e.HasMorePages = false;
            y += 12;
            g.DrawLine(Pens.Black, left, y, right, y);
            y += 16;

            g.DrawString($"إجمالي الإيرادات: {FormatCurrency(_totalRevenue)}", PrintBoldFont, Brushes.Black,
                new RectangleF(left, y, pageWidth, 22), rtlFormat);
            y += 24;
            g.DrawString($"إجمالي مستحقات الأطباء: {FormatCurrency(_totalDoctorShares)}", PrintBoldFont, Brushes.Black,
                new RectangleF(left, y, pageWidth, 22), rtlFormat);
            y += 40;

            g.DrawString($"مُعد التقرير: {preparer}", PrintNormalFont, Brushes.Black,
                new RectangleF(left, y, pageWidth, 22), rtlFormat);
            y += 24;
            g.DrawString("ختم العيادة: _________________________", PrintNormalFont, Brushes.Black,
                new RectangleF(left, y, pageWidth, 22), rtlFormat);
        }

        private static string GetPreparerName()
        {
            if (DataStore.CurrentUser == null)
                return "موظف الاستقبال";
            return DataStore.CurrentUser.FullName
                   ?? DataStore.CurrentUser.Username
                   ?? "موظف الاستقبال";
        }

        private static string FormatCurrency(decimal value) => $"{value:F2} د.ل";

        private void dtpReportDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
