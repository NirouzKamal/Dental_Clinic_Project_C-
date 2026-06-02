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

            foreach (var group in CaseVisitGrouping.GetPendingVisitGroups())
            {
                var first = group.First();
                string patientName = first.PatientName ?? "";
                string fileNum = first.PatientFileNumber ?? "";

                if (!string.IsNullOrEmpty(searchTerm) && searchTerm != "ابحث باسم المريض أو رقم الفاتورة...")
                {
                    if (!patientName.Contains(searchTerm) && !fileNum.Contains(searchTerm))
                        continue;
                }

                decimal total = CaseVisitGrouping.SumFinalPrice(group);
                string servicesSummary = string.Join("، ", group.Select(c => c.Treatment).Take(3));
                if (group.Count > 3)
                    servicesSummary += $" (+{group.Count - 3})";

                int rowIndex = dgvInvoices.Rows.Add(
                    "غير مصدرة",
                    first.OpenedDate.ToString("yyyy/MM/dd hh:mm tt"),
                    patientName,
                    $"{total:F2} د.ل ({group.Count} خدمة)",
                    "0.00 د.ل",
                    $"{total:F2} د.ل"
                );
                dgvInvoices.Rows[rowIndex].Tag = first.CaseId;
                dgvInvoices.Rows[rowIndex].Cells[2].ToolTipText = servicesSummary;
            }
        }

        private void PaySelectedInvoice()
        {
            if (dgvInvoices.SelectedRows.Count == 0) return;

            string caseId = dgvInvoices.SelectedRows[0].Tag?.ToString();
            if (string.IsNullOrEmpty(caseId)) return;

            var invoiceForm = new InvoicePaymentFormUI(caseId);
            if (invoiceForm.ShowDialog() == DialogResult.OK)
                LoadPendingCases();
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
