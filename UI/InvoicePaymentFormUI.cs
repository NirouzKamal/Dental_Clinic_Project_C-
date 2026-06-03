using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DentalClinicProject.classes;
using DentalClinicProject.data;
using DentalClinicProject.Reports;

namespace DentalClinicProject.UI
{
    public partial class InvoicePaymentFormUI : System.Windows.Forms.Form
    {
        private readonly string _anchorCaseId;
        private List<Case> _visitCases = new List<Case>();

        public InvoicePaymentFormUI(string caseId = "")
        {
            _anchorCaseId = caseId;
            InitializeComponent();
            SetupLogic();
        }

        private void SetupLogic()
        {
            var anchor = DataStore.Cases.FirstOrDefault(c => c.CaseId == _anchorCaseId);
            if (anchor != null)
                _visitCases = CaseVisitGrouping.GetPendingVisitCases(anchor);

            this.Load += (s, e) =>
            {
                cmbMethod.Items.AddRange(new string[] { "نقدي", "بطاقة ائتمان", "حوالة مصرفية" });
                cmbMethod.SelectedIndex = 0;

                if (_visitCases.Count > 0)
                {
                    var first = _visitCases[0];
                    txtPatient.Text = first.PatientName;
                    decimal total = CaseVisitGrouping.SumFinalPrice(_visitCases);
                    txtTotal.Text = total.ToString("F2");
                    txtPaid.Text = total.ToString("F2");
                    UpdateRemaining();
                }
            };

            txtPaid.TextChanged += (s, e) => UpdateRemaining();
            txtPaid.KeyPress += AllowOnlyNumbers;
            btnConfirm.Click += BtnIssueInvoice_Click;
        }

        private void UpdateRemaining()
        {
            if (_visitCases.Count == 0) return;

            decimal total = CaseVisitGrouping.SumFinalPrice(_visitCases);
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

        private static string GetReceptionistName()
        {
            if (DataStore.CurrentUser == null)
                return "";
            return !string.IsNullOrWhiteSpace(DataStore.CurrentUser.FullName)
                ? DataStore.CurrentUser.FullName
                : DataStore.CurrentUser.Username ?? "";
        }

        private void BtnIssueInvoice_Click(object sender, EventArgs e)
        {
            if (_visitCases.Count == 0) return;

            var primary = _visitCases[0];
            decimal total = CaseVisitGrouping.SumFinalPrice(_visitCases);
            decimal.TryParse(txtPaid.Text, out decimal paid);

            if (paid < 0)
            {
                MessageBox.Show("المبلغ المدفوع غير صحيح", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (paid > total)
            {
                MessageBox.Show("المبلغ المدفوع أكبر من إجمالي الفاتورة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime paymentTime = DateTime.Now;
            string paymentMethod = cmbMethod.SelectedItem?.ToString() ?? cmbMethod.Text ?? "";
            decimal remaining = total - paid;
            if (remaining < 0) remaining = 0;

            string invoiceId = DataStore.NextInvoiceId();
            var invoice = new Invoice
            {
                InvoiceId = invoiceId,
                CaseId = primary.CaseId,
                PatientId = primary.PatientId,
                TotalAmount = total,
                IssuedDate = paymentTime,
                IsPaid = paid >= total
            };
            DataStore.Invoices.Add(invoice);
            DataStore.SaveInvoiceToDatabase(invoice);

            if (paid > 0)
            {
                var payment = new Payment
                {
                    PaymentId = DataStore.NextPaymentId(),
                    InvoiceId = invoice.InvoiceId,
                    AmountPaid = paid,
                    PaymentDate = paymentTime,
                    Method = paymentMethod
                };
                DataStore.Payments.Add(payment);
                DataStore.SavePaymentToDatabase(payment);
                DataStore.SaveInvoiceToDatabase(invoice);
            }

            foreach (var c in _visitCases)
            {
                c.Status = CaseStatus.Completed;
                c.ClosedAt = paymentTime;
                DataStore.SaveCaseToDatabase(c);
            }

            string receptionistName = GetReceptionistName();
            var printModel = PaymentReceiptPrintModel.FromVisitCases(
                _visitCases,
                invoiceId,
                paid,
                remaining,
                receptionistName,
                paymentMethod,
                paymentTime);

            CrystalReceiptPrinter.PrintPaymentReceipt(printModel, showPreview: true);

            MessageBox.Show(
                $"تم إصدار الفاتورة وتأكيد الدفع بنجاح!\n({_visitCases.Count} خدمة في إيصال واحد)",
                "نجاح",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
