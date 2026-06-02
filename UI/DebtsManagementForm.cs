using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DentalClinicProject.classes;
using DentalClinicProject.data;

namespace DentalClinicProject.UI
{
    /// <summary>
    /// Standalone dialog for managing outstanding invoice balances (opened from dashboard/reception).
    /// </summary>
    public partial class DebtsManagementForm : Form
    {
        private sealed class DebtRowTag
        {
            public string InvoiceId { get; set; }
            public string CaseId { get; set; }
            public decimal Remaining { get; set; }
        }

        public DebtsManagementForm()
        {
            InitializeComponent();
            SetupLogic();
        }

        private void SetupLogic()
        {
            Load += (s, e) => LoadDebts();

            btnClose.Click += (s, e) => Close();
            btnRefresh.Click += (s, e) => LoadDebts();
            btnRegisterPayment.Click += BtnRegisterPayment_Click;
            dgvDebts.CellDoubleClick += (s, e) =>
            {
                if (e.RowIndex >= 0)
                    BtnRegisterPayment_Click(s, e);
            };
        }

        private void LoadDebts()
        {
            dgvDebts.Rows.Clear();
            int indebtedCount = 0;
            decimal totalDebt = 0;

            foreach (var entry in GetIndebtedInvoices())
            {
                indebtedCount++;
                totalDebt += entry.Remaining;

                int rowIndex = dgvDebts.Rows.Add(
                    entry.SessionNumber,
                    entry.PatientName,
                    entry.DoctorName,
                    $"{entry.Total:N2}",
                    $"{entry.Paid:N2}",
                    $"{entry.Remaining:N2}");

                dgvDebts.Rows[rowIndex].Tag = new DebtRowTag
                {
                    InvoiceId = entry.InvoiceId,
                    CaseId = entry.CaseId,
                    Remaining = entry.Remaining
                };
            }

            lblSummary.Text =
                $"عدد الحالات المدينة: {indebtedCount} | إجمالي الديون: {totalDebt:N2} د.ل";
        }

        private static IEnumerable<DebtGridEntry> GetIndebtedInvoices()
        {
            foreach (var invoice in DataStore.Invoices.OrderByDescending(i => i.IssuedDate))
            {
                decimal paid = DataStore.Payments
                    .Where(p => p.InvoiceId == invoice.InvoiceId)
                    .Sum(p => p.AmountPaid);

                decimal remaining = invoice.TotalAmount - paid;
                if (remaining <= 0)
                    continue;

                var clinicCase = DataStore.Cases.FirstOrDefault(c => c.CaseId == invoice.CaseId);
                string sessionNumber = clinicCase?.CaseNumber;
                if (string.IsNullOrWhiteSpace(sessionNumber))
                    sessionNumber = clinicCase?.CaseId ?? invoice.InvoiceId;

                yield return new DebtGridEntry
                {
                    InvoiceId = invoice.InvoiceId,
                    CaseId = invoice.CaseId,
                    SessionNumber = sessionNumber,
                    PatientName = clinicCase?.PatientName ?? "",
                    DoctorName = clinicCase?.DoctorName ?? "",
                    Total = invoice.TotalAmount,
                    Paid = paid,
                    Remaining = remaining
                };
            }
        }

        private void BtnRegisterPayment_Click(object sender, EventArgs e)
        {
            if (dgvDebts.SelectedRows.Count == 0)
            {
                MessageBox.Show("الرجاء اختيار حالة من الجدول", "تنبيه",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var tag = dgvDebts.SelectedRows[0].Tag as DebtRowTag;
            if (tag == null || string.IsNullOrEmpty(tag.InvoiceId))
                return;

            var invoice = DataStore.Invoices.FirstOrDefault(i => i.InvoiceId == tag.InvoiceId);
            if (invoice == null)
                return;

            using (var paymentDialog = new DebtPaymentDialog(tag.Remaining))
            {
                if (paymentDialog.ShowDialog(this) != DialogResult.OK)
                    return;

                decimal amount = paymentDialog.PaymentAmount;
                if (amount <= 0)
                {
                    MessageBox.Show("المبلغ غير صحيح", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (amount > tag.Remaining)
                {
                    MessageBox.Show("المبلغ أكبر من المتبقي على الفاتورة", "خطأ",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataStore.Payments.Add(new Payment
                {
                    PaymentId = DataStore.NextPaymentId(),
                    InvoiceId = invoice.InvoiceId,
                    AmountPaid = amount,
                    PaymentDate = DateTime.Now,
                    Method = paymentDialog.PaymentMethod
                });

                decimal totalPaid = DataStore.Payments
                    .Where(p => p.InvoiceId == invoice.InvoiceId)
                    .Sum(p => p.AmountPaid);

                invoice.IsPaid = totalPaid >= invoice.TotalAmount;

                MessageBox.Show("تم تسجيل الدفعة بنجاح", "نجاح",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadDebts();
            }
        }

        private sealed class DebtGridEntry
        {
            public string InvoiceId { get; set; }
            public string CaseId { get; set; }
            public string SessionNumber { get; set; }
            public string PatientName { get; set; }
            public string DoctorName { get; set; }
            public decimal Total { get; set; }
            public decimal Paid { get; set; }
            public decimal Remaining { get; set; }
        }

        /// <summary>Small modal dialog for partial debt payments.</summary>
        private sealed class DebtPaymentDialog : Form
        {
            private readonly TextBox _txtAmount;
            private readonly ComboBox _cmbMethod;

            public decimal PaymentAmount { get; private set; }
            public string PaymentMethod => _cmbMethod.SelectedItem?.ToString() ?? "نقدي";

            public DebtPaymentDialog(decimal maxAmount)
            {
                Text = "تسجيل دفعة";
                FormBorderStyle = FormBorderStyle.FixedDialog;
                MaximizeBox = false;
                MinimizeBox = false;
                StartPosition = FormStartPosition.CenterParent;
                RightToLeft = RightToLeft.Yes;
                RightToLeftLayout = true;
                ClientSize = new Size(420, 220);
                Font = UiFont.Regular;

                var lblAmount = new Label
                {
                    Text = $"المبلغ (الحد الأقصى {maxAmount:N2} د.ل):",
                    AutoSize = true,
                    Location = new Point(24, 24)
                };

                _txtAmount = new TextBox
                {
                    Text = maxAmount.ToString("F2"),
                    Location = new Point(24, 52),
                    Width = 360,
                    TextAlign = HorizontalAlignment.Right
                };

                var lblMethod = new Label
                {
                    Text = "طريقة الدفع:",
                    AutoSize = true,
                    Location = new Point(24, 92)
                };

                _cmbMethod = new ComboBox
                {
                    DropDownStyle = ComboBoxStyle.DropDownList,
                    Location = new Point(24, 118),
                    Width = 360
                };
                _cmbMethod.Items.AddRange(new object[] { "نقدي", "بطاقة ائتمان", "حوالة مصرفية" });
                _cmbMethod.SelectedIndex = 0;

                var btnOk = new Button
                {
                    Text = "تأكيد",
                    DialogResult = DialogResult.OK,
                    BackColor = Color.FromArgb(62, 125, 83),
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Location = new Point(24, 160),
                    Size = new Size(120, 36)
                };
                btnOk.FlatAppearance.BorderSize = 0;

                var btnCancel = new Button
                {
                    Text = "إلغاء",
                    DialogResult = DialogResult.Cancel,
                    Location = new Point(160, 160),
                    Size = new Size(120, 36)
                };

                btnOk.Click += (s, e) =>
                {
                    if (!decimal.TryParse(_txtAmount.Text, out decimal amount) || amount <= 0)
                    {
                        MessageBox.Show("أدخل مبلغاً صحيحاً", "تنبيه",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        DialogResult = DialogResult.None;
                        return;
                    }
                    PaymentAmount = amount;
                };

                Controls.AddRange(new Control[]
                {
                    lblAmount, _txtAmount, lblMethod, _cmbMethod, btnOk, btnCancel
                });

                AcceptButton = btnOk;
                CancelButton = btnCancel;

                UiFont.ApplyTo(this);
            }
        }
    }
}
