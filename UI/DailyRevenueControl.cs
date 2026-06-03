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
        private static DateTime? _lastClosedDate = null;

        public DailyRevenueControl()
        {
            InitializeComponent();
            SetupLogic();
        }

        private void SetupLogic()
        {
            // Apply styling
            ThemeManager.StyleDataGridView(dgvCases);
            ThemeManager.StyleButton(btnPrintReport, isPrimary: false);
            ThemeManager.StyleButton(btnConfirmClosure, isPrimary: true);

            this.Load += DailyRevenueControl_Load;
            btnPrintReport.Click += btnPrintReport_Click;
            btnConfirmClosure.Click += btnConfirmClosure_Click;
        }

        private void DailyRevenueControl_Load(object sender, EventArgs e)
        {
            LoadDailyRevenueData();
        }

        private bool IsAlreadyClosed()
        {
            return _lastClosedDate.HasValue && _lastClosedDate.Value.Date == DateTime.Today;
        }

        private void LoadDailyRevenueData()
        {
            // Filter completed cases from DataStore that are opened today
            var todayCompletedCases = DataStore.Cases
                .Where(c => c.Status == CaseStatus.Completed && c.OpenedDate.Date == DateTime.Today)
                .ToList();

            dgvCases.Rows.Clear();

            decimal totalRevenue = 0;
            decimal totalDoctorShares = 0;

            foreach (var c in todayCompletedCases)
            {
                // Find doctor commission percentage
                var doctor = DataStore.Doctors.FirstOrDefault(d => d.DoctorId == c.DoctorId);
                decimal commissionPct = doctor != null ? doctor.CommissionPct : 40;
                decimal doctorShare = c.FinalPrice * (commissionPct / 100);

                totalRevenue += c.FinalPrice;
                totalDoctorShares += doctorShare;

                dgvCases.Rows.Add(
                    c.CaseNumber ?? "",
                    c.PatientName ?? "",
                    c.DoctorName ?? "",
                    c.Treatment ?? "",
                    $"{c.FinalPrice:F2} د.ل"
                );
            }

            // Update summary cards
            lblCasesValue.Text = todayCompletedCases.Count.ToString();
            lblRevenueValue.Text = $"{totalRevenue:F2} د.ل";

            // Update footer
            lblFooterRevenue.Text = $"📈 إجمالي الإيرادات: {totalRevenue:F2} د.ل";
            lblFooterDoctorShare.Text = $"👨‍⚕️ إجمالي مستحقات الأطباء: {totalDoctorShares:F2} د.ل";

            // Handle confirm closure button state
            if (IsAlreadyClosed())
            {
                btnConfirmClosure.Enabled = false;
                btnConfirmClosure.Text = "✅ تم إغلاق اليوم";
                btnConfirmClosure.BackColor = Color.Gray;
            }
            else
            {
                btnConfirmClosure.Enabled = true;
                btnConfirmClosure.Text = "✅ تأكيد إغلاق اليوم";
                btnConfirmClosure.BackColor = Color.FromArgb(40, 167, 69);
            }
        }

        private void btnConfirmClosure_Click(object sender, EventArgs e)
        {
            if (IsAlreadyClosed())
            {
                MessageBox.Show(
                    "تم إغلاق إيرادات اليوم بالفعل سابقاً.",
                    "تنبيه",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                return;
            }

            var confirm = MessageBox.Show(
                "هل أنت متأكد من تأكيد إغلاق إيرادات اليوم؟",
                "تأكيد إغلاق اليوم",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2,
                MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);

            if (confirm == DialogResult.Yes)
            {
                _lastClosedDate = DateTime.Today;

                MessageBox.Show(
                    "تم إغلاق إيرادات اليوم بنجاح",
                    "نجاح",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);

                LoadDailyRevenueData();
            }
        }

        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            PrintReport();
        }

        private void PrintReport()
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += (sender, e) => PrintReportPage(e);

            using (var preview = new PrintPreviewDialog
            {
                Document = pd,
                Width = 800,
                Height = 1000,
                ShowIcon = false,
                Text = "معاينة تقرير إيرادات اليوم"
            })
            {
                preview.ShowDialog(this);
            }
        }

        private void PrintReportPage(PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            int y = 40;
            int width = e.PageBounds.Width;
            int margin = 50;

            Font prHeaderFont = new Font("Segoe UI", 16, FontStyle.Bold);
            Font prSubHeaderFont = new Font("Segoe UI", 12, FontStyle.Bold);
            Font prBoldFont = new Font("Segoe UI", 10, FontStyle.Bold);
            Font prNormalFont = new Font("Segoe UI", 10, FontStyle.Regular);

            StringFormat prCenterFormat = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            StringFormat prRtlFormat = new StringFormat
            {
                FormatFlags = StringFormatFlags.DirectionRightToLeft,
                Alignment = StringAlignment.Near,
                LineAlignment = StringAlignment.Center
            };

            // Header
            g.DrawString("عيادة DentCare للأسنان", prHeaderFont, Brushes.Black, new RectangleF(0, y, width, 40), prCenterFormat);
            y += 45;
            g.DrawString("تقرير إغلاق إيرادات اليوم", prSubHeaderFont, Brushes.Black, new RectangleF(0, y, width, 30), prCenterFormat);
            y += 35;

            string dateStr = $"التاريخ: {DateTime.Today.ToString("yyyy-MM-dd")}";
            g.DrawString(dateStr, prNormalFont, Brushes.Black, new RectangleF(margin, y, width - (2 * margin), 25), prRtlFormat);
            y += 35;

            g.DrawLine(Pens.Black, margin, y, width - margin, y);
            y += 20;

            // Load today's completed cases
            var todayCompletedCases = DataStore.Cases
                .Where(c => c.Status == CaseStatus.Completed && c.OpenedDate.Date == DateTime.Today)
                .ToList();

            if (todayCompletedCases.Count == 0)
            {
                g.DrawString("لا توجد حالات مكتملة اليوم.", prNormalFont, Brushes.Gray, new RectangleF(0, y, width, 40), prCenterFormat);
                return;
            }

            // Draw Table Header
            int tableRight = width - margin;
            int[] colWidths = { 90, 160, 140, 160, 150 }; // رقم الحالة | اسم الحالة | الطبيب المعالج | الخدمات المقدمة | المبلغ (د.ل)
            int totalTableWidth = colWidths.Sum();
            int tableLeft = tableRight - totalTableWidth;
            int rowHeight = 30;

            string[] headers = { "رقم الحالة", "اسم الحالة", "الطبيب المعالج", "الخدمات المقدمة", "المبلغ (د.ل)" };

            int tempX = tableRight;
            for (int i = 0; i < headers.Length; i++)
            {
                tempX -= colWidths[i];
                g.DrawRectangle(Pens.Black, tempX, y, colWidths[i], rowHeight);
                g.DrawString(headers[i], prBoldFont, Brushes.Black, new RectangleF(tempX, y, colWidths[i], rowHeight), prCenterFormat);
            }
            y += rowHeight;

            decimal totalRevenue = 0;
            decimal totalDoctorShares = 0;

            foreach (var c in todayCompletedCases)
            {
                var doctor = DataStore.Doctors.FirstOrDefault(d => d.DoctorId == c.DoctorId);
                decimal commissionPct = doctor != null ? doctor.CommissionPct : 40;
                decimal doctorShare = c.FinalPrice * (commissionPct / 100);

                totalRevenue += c.FinalPrice;
                totalDoctorShares += doctorShare;

                string[] rowData = {
                    c.CaseNumber ?? "",
                    c.PatientName ?? "",
                    c.DoctorName ?? "",
                    c.Treatment ?? "",
                    $"{c.FinalPrice:F2} د.ل"
                };

                tempX = tableRight;
                for (int i = 0; i < rowData.Length; i++)
                {
                    tempX -= colWidths[i];
                    g.DrawRectangle(Pens.Black, tempX, y, colWidths[i], rowHeight);
                    g.DrawString(rowData[i], prNormalFont, Brushes.Black, new RectangleF(tempX, y, colWidths[i], rowHeight), prCenterFormat);
                }
                y += rowHeight;
            }

            y += 30;
            g.DrawLine(Pens.Black, margin, y, width - margin, y);
            y += 20;

            // Totals
            g.DrawString($"📈 إجمالي الإيرادات: {totalRevenue:F2} د.ل", prBoldFont, Brushes.Black, new RectangleF(margin, y, width - (2 * margin), 25), prRtlFormat);
            y += 30;
            g.DrawString($"👨‍⚕️ إجمالي مستحقات الأطباء: {totalDoctorShares:F2} د.ل", prBoldFont, Brushes.Black, new RectangleF(margin, y, width - (2 * margin), 25), prRtlFormat);
            y += 50;

            g.DrawLine(Pens.Black, margin, y, width - margin, y);
            y += 30;

            // Signatures
            string receptionistName = DataStore.CurrentUser?.FullName ?? DataStore.CurrentUser?.Username ?? "موظف الاستقبال";
            g.DrawString($"مُعد التقرير: {receptionistName}", prNormalFont, Brushes.Black, new RectangleF(margin, y, (width - (2 * margin)) / 2, 25), prRtlFormat);

            // Stamp on the left side
            StringFormat ltrFormat = new StringFormat
            {
                Alignment = StringAlignment.Near,
                LineAlignment = StringAlignment.Center
            };
            g.DrawString("ختم العيادة:", prNormalFont, Brushes.Black, new RectangleF(margin, y, (width - (2 * margin)) / 2, 25), ltrFormat);

            // Cleanup fonts
            prHeaderFont.Dispose();
            prSubHeaderFont.Dispose();
            prBoldFont.Dispose();
            prNormalFont.Dispose();
            prCenterFormat.Dispose();
            prRtlFormat.Dispose();
            ltrFormat.Dispose();
        }
    }
}
