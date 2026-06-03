using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DentalClinicProject.classes;
using DentalClinicProject.data;

namespace DentalClinicProject.UI
{
    public partial class PatientRecordsControlUI : System.Windows.Forms.UserControl
    {
        public PatientRecordsControlUI()
        {
            InitializeComponent();
            SetupLogic();
        }

        private void SetupLogic()
        {
            this.Load += (s, e) => LoadPatientRecords();

            txtSearch.TextChanged += (s, e) => LoadPatientRecords(txtSearch.Text);
            
            txtSearch.Enter += (s, e) => { if (txtSearch.Text == "ابحث بالاسم أو رقم الملف...") txtSearch.Text = ""; };
            txtSearch.Leave += (s, e) => { if (string.IsNullOrWhiteSpace(txtSearch.Text)) txtSearch.Text = "ابحث بالاسم أو رقم الملف..."; };

            btnEdit.Click += (s, e) => {
                if (dgvPatientRecords.CurrentRow != null)
                {
                    string caseNum = dgvPatientRecords.CurrentRow.Cells["colCaseNum"].Value?.ToString();
                    var c = DataStore.Cases.FirstOrDefault(x => x.CaseNumber == caseNum);
                    if (c != null)
                    {
                        var patient = DataStore.Patients.FirstOrDefault(p => p.FileNumber == c.PatientFileNumber);
                        if (patient != null)
                        {
                            using (var editForm = new UI.AddPatientFormUI(patient.PatientId))
                            {
                                if (editForm.ShowDialog() == DialogResult.OK)
                                    LoadPatientRecords(txtSearch.Text);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("الرجاء اختيار سجل أولاً لتعديله", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            };
            btnPrint.Click += (s, e) => {
                if (dgvPatientRecords.CurrentRow != null)
                {
                    string caseNum = dgvPatientRecords.CurrentRow.Cells["colCaseNum"].Value?.ToString();
                    var c = DataStore.Cases.FirstOrDefault(x => x.CaseNumber == caseNum);
                    if (c != null)
                    {
                        var patient = DataStore.Patients.FirstOrDefault(p => p.FileNumber == c.PatientFileNumber);
                        if (patient != null)
                            classes.PrintManager.PrintPatientReport(patient.PatientId);
                    }
                }
                else
                {
                    MessageBox.Show("الرجاء اختيار سجل أولاً", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            };
        }

        private void LoadPatientRecords(string searchTerm = "")
        {
            DataStore.LoadAllFromDatabase();
            dgvPatientRecords.Rows.Clear();

            var cases = DataStore.Cases.AsEnumerable();

            if (!string.IsNullOrEmpty(searchTerm) && searchTerm != "ابحث بالاسم أو رقم الملف...")
            {
                cases = cases.Where(c => 
                    (c.PatientName != null && c.PatientName.Contains(searchTerm)) ||
                    (c.PatientFileNumber != null && c.PatientFileNumber.Contains(searchTerm)) ||
                    (c.CaseNumber != null && c.CaseNumber.Contains(searchTerm)));
            }

            // sort descending (newest first)
            cases = cases.OrderByDescending(c => c.OpenedDate);

            foreach (var c in cases)
            {
                // Calculate Paid and Remaining
                decimal paid = 0;
                var invoice = DataStore.Invoices.FirstOrDefault(i => i.CaseId == c.CaseId);
                if (invoice != null)
                {
                    paid = DataStore.Payments.Where(p => p.InvoiceId == invoice.InvoiceId).Sum(p => p.AmountPaid);
                }

                decimal remaining = c.FinalPrice - paid;

                dgvPatientRecords.Rows.Add(
                    c.CaseNumber,
                    c.OpenedDate.ToString("yyyy-MM-dd"),
                    c.Treatment,
                    c.DoctorName,
                    c.FinalPrice.ToString("F2"),
                    paid.ToString("F2"),
                    remaining.ToString("F2"),
                    c.Notes,
                    GetStatusText(c.Status)
                );
            }
        }

        private string GetStatusText(CaseStatus status)
        {
            switch (status)
            {
                case CaseStatus.Waiting: return "في الانتظار";
                case CaseStatus.InProgress: return "قيد العلاج";
                case CaseStatus.Completed: return "مكتمل";
                case CaseStatus.Cancelled: return "ملغي";
                default: return status.ToString();
            }
        }
    }
}
