using System;
using System.Linq;
using System.Windows.Forms;
using DentalClinicProject.classes;
using DentalClinicProject.data;

namespace DentalClinicProject.UI
{
    public partial class PendingInvoicesFormUI : System.Windows.Forms.Form
    {
        public PendingInvoicesFormUI()
        {
            InitializeComponent();
            SetupLogic();
        }

        private void SetupLogic()
        {
            this.Load += (s, e) => LoadPendingCases();

            txtSearch.TextChanged += (s, e) => LoadPendingCases(txtSearch.Text);
            txtSearch.Enter += (s, e) => { if (txtSearch.Text == "ابحث باسم المريض أو رقم الفاتورة...") txtSearch.Text = ""; };
            txtSearch.Leave += (s, e) => { if (string.IsNullOrWhiteSpace(txtSearch.Text)) txtSearch.Text = "ابحث باسم المريض أو رقم الفاتورة..."; };

            dgvInvoices.CellDoubleClick += DgvInvoices_CellDoubleClick;
            btnPay.Click += BtnPay_Click;
        }

        private void LoadPendingCases(string searchTerm = "")
        {
            dgvInvoices.Rows.Clear();

            var pendingCases = DataStore.Cases
                .Where(c => c.SentToReception == true && c.Status == CaseStatus.Waiting)
                .OrderBy(c => c.OpenedDate)
                .ToList();

            foreach (var c in pendingCases)
            {
                if (!string.IsNullOrEmpty(searchTerm) && searchTerm != "ابحث باسم المريض أو رقم الفاتورة...")
                {
                    if (!(c.PatientName != null && c.PatientName.Contains(searchTerm)) &&
                        !(c.PatientFileNumber != null && c.PatientFileNumber.Contains(searchTerm)))
                        continue;
                }

                // Grid columns: colInvNum, colDate, colPatient, colTotal, colPaid, colRemaining, colCaseId (hidden if we add it)
                // We'll add colCaseId dynamically if not present, or just store it in Tag
                var rowIndex = dgvInvoices.Rows.Add(
                    "غير مصدرة", // No invoice number yet
                    c.OpenedDate.ToString("yyyy/MM/dd hh:mm tt"),
                    c.PatientName ?? "",
                    c.FinalPrice.ToString("F2") + " د.ل",
                    "0.00 د.ل",
                    c.FinalPrice.ToString("F2") + " د.ل"
                );
                dgvInvoices.Rows[rowIndex].Tag = c.CaseId;
            }
        }

        private void PaySelectedInvoice()
        {
            if (dgvInvoices.SelectedRows.Count == 0) return;

            string caseId = dgvInvoices.SelectedRows[0].Tag?.ToString();
            if (string.IsNullOrEmpty(caseId)) return;

            var invoiceForm = new InvoicePaymentFormUI(caseId);
            if (invoiceForm.ShowDialog() == DialogResult.OK)
            {
                LoadPendingCases(); // Refresh list after payment
            }
        }

        private void DgvInvoices_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            PaySelectedInvoice();
        }

        private void BtnPay_Click(object sender, EventArgs e)
        {
            PaySelectedInvoice();
        }
    }
}
