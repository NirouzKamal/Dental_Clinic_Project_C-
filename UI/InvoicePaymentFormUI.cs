using System;
using System.Linq;
using System.Windows.Forms;
using DentalClinicProject.classes;
using DentalClinicProject.data;

namespace DentalClinicProject.UI
{
    public partial class InvoicePaymentFormUI : System.Windows.Forms.Form
    {
        private readonly string _caseId;

        public InvoicePaymentFormUI(string caseId = "")
        {
            _caseId = caseId;
            InitializeComponent();
            SetupLogic();
        }

        private void SetupLogic()
        {
            var clinicCase = DataStore.Cases.FirstOrDefault(c => c.CaseId == _caseId);

            this.Load += (s, e) =>
            {
                cmbMethod.Items.AddRange(new string[] { "نقدي", "بطاقة ائتمان", "حوالة مصرفية" });
                cmbMethod.SelectedIndex = 0;

                if (clinicCase != null)
                {
                    txtPatient.Text = clinicCase.PatientName;
                    txtTotal.Text = clinicCase.FinalPrice.ToString("F2");
                    txtPaid.Text = clinicCase.FinalPrice.ToString("F2"); // Default to full payment
                    UpdateRemaining();
                }
            };

            txtPaid.TextChanged += (s, e) => UpdateRemaining();
            txtPaid.KeyPress += AllowOnlyNumbers;

            btnConfirm.Click += BtnIssueInvoice_Click;
        }

        private void UpdateRemaining()
        {
            var clinicCase = DataStore.Cases.FirstOrDefault(c => c.CaseId == _caseId);
            if (clinicCase == null) return;

            decimal total = clinicCase.FinalPrice;
            decimal.TryParse(txtPaid.Text, out decimal paid);

            decimal remaining = total - paid;
            if (remaining < 0) remaining = 0;

            txtRemaining.Text = $"{remaining:F2}";
        }

        private void AllowOnlyNumbers(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                e.Handled = true;
        }

        private void BtnIssueInvoice_Click(object sender, EventArgs e)
        {
            var clinicCase = DataStore.Cases.FirstOrDefault(c => c.CaseId == _caseId);
            if (clinicCase == null) return;

            decimal total = clinicCase.FinalPrice;
            decimal.TryParse(txtPaid.Text, out decimal paid);

            if (paid < 0)
            {
                MessageBox.Show("المبلغ المدفوع غير صحيح", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var invoice = new Invoice
            {
                InvoiceId = DataStore.NextInvoiceId(),
                CaseId = clinicCase.CaseId,
                PatientId = clinicCase.PatientId,
                TotalAmount = total,
                IssuedDate = DateTime.Now,
                IsPaid = paid >= total
            };
            DataStore.Invoices.Add(invoice);

            if (paid > 0)
            {
                var payment = new Payment
                {
                    PaymentId = DataStore.NextPaymentId(),
                    InvoiceId = invoice.InvoiceId,
                    AmountPaid = paid,
                    PaymentDate = DateTime.Now
                };
                DataStore.Payments.Add(payment);
            }

            clinicCase.Status = CaseStatus.Completed;

            // Mock print receipt
            MessageBox.Show("تم إصدار الفاتورة وتأكيد الدفع بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
