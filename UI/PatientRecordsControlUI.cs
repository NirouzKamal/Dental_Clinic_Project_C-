using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using DentalClinicProject.classes;
using DentalClinicProject.data;
using DentalClinicProject.Data;

namespace DentalClinicProject.UI
{
    public partial class PatientRecordsControlUI : System.Windows.Forms.UserControl
    {
        public string PreSelectedPatientId { get; set; }

        public PatientRecordsControlUI()
        {
            InitializeComponent();
            SetupLogic();
        }

        private void SetupLogic()
        {
            this.Load += (s, e) =>
            {
                LoadPatientCombo();
                if (!string.IsNullOrEmpty(PreSelectedPatientId))
                {
                    cmbSelectPatient.SelectedValue = PreSelectedPatientId;
                }
                else
                {
                    LoadPatientRecords();
                }
            };

            cmbSelectPatient.SelectedIndexChanged += (s, e) => LoadPatientRecords(txtSearch.Text);

            txtSearch.TextChanged += (s, e) => LoadPatientRecords(txtSearch.Text);
            
            txtSearch.Enter += (s, e) => { if (txtSearch.Text == "ابحث بالاسم أو رقم الملف...") txtSearch.Text = ""; };
            txtSearch.Leave += (s, e) => { if (string.IsNullOrWhiteSpace(txtSearch.Text)) txtSearch.Text = "ابحث بالاسم أو رقم الملف..."; };

            dgvPatientRecords.SelectionChanged += DgvPatientRecords_SelectionChanged;

            btnEdit.Click += (s, e) => {
                if (dgvPatientRecords.CurrentRow != null)
                {
                    string caseNum = dgvPatientRecords.CurrentRow.Cells["colCaseNum"].Value?.ToString();
                    if (!string.IsNullOrEmpty(caseNum))
                    {
                        using (var editForm = new UI.EditPatientRecordFormUI(caseNum))
                        {
                            if (editForm.ShowDialog() == DialogResult.OK)
                                LoadPatientRecords(txtSearch.Text);
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

        private void LoadPatientCombo()
        {
            DataStore.LoadPatientsFromDatabase();
            var list = DataStore.Patients
                .Select(p => new { PatientId = p.PatientId, DisplayText = $"{p.FileNumber} — {p.FullName}" })
                .ToList();

            cmbSelectPatient.DisplayMember = "DisplayText";
            cmbSelectPatient.ValueMember = "PatientId";
            cmbSelectPatient.DataSource = list;
            cmbSelectPatient.SelectedIndex = -1; // Default to empty
        }

        private void DgvPatientRecords_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPatientRecords.CurrentRow != null)
            {
                string caseNum = dgvPatientRecords.CurrentRow.Cells["colCaseNum"].Value?.ToString();
                var c = DataStore.Cases.FirstOrDefault(x => x.CaseNumber == caseNum);
                if (c != null)
                {
                    decimal totalDebt = 0;
                    try
                    {
                        using (var conn = DbHelper.GetConnection())
                        {
                            string sql = @"
                                SELECT SUM(i.TotalAmount) - SUM(ISNULL(p.Amount, 0))
                                FROM dbo.Invoice i
                                LEFT JOIN (
                                    SELECT InvoiceId, SUM(Amount) AS Amount
                                    FROM dbo.Payments
                                    GROUP BY InvoiceId
                                ) p ON i.InvoiceId = p.InvoiceId
                                WHERE i.PatientId = @PatientId";
                            using (var cmd = new SqlCommand(sql, conn))
                            {
                                cmd.Parameters.AddWithValue("@PatientId", c.PatientId);
                                var res = cmd.ExecuteScalar();
                                if (res != DBNull.Value && res != null)
                                    totalDebt = Convert.ToDecimal(res);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error calculating patient outstanding debt: " + ex.Message);
                    }

                    if (totalDebt < 0) totalDebt = 0;
                    lblTotalDebt.Text = $"إجمالي ديون المريض ({c.PatientName}): {totalDebt:F2} د.ل";
                }
                else
                {
                    lblTotalDebt.Text = "إجمالي ديون المريض: 0.00 د.ل";
                }
            }
            else
            {
                lblTotalDebt.Text = "إجمالي ديون المريض: 0.00 د.ل";
            }
        }

        private void LoadPatientRecords(string searchTerm = "")
        {
            DataStore.LoadAllFromDatabase();
            dgvPatientRecords.Rows.Clear();

            if (cmbSelectPatient.SelectedValue == null)
            {
                lblTotalDebt.Text = "إجمالي ديون المريض: 0.00 د.ل";
                return; // Grid remains blank as requested if no patient is selected
            }

            string selectedPatientId = cmbSelectPatient.SelectedValue.ToString();
            var cases = DataStore.Cases.Where(c => c.PatientId == selectedPatientId);

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

        private void crystalOpenFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
