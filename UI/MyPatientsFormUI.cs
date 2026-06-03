using System;
using System.Linq;
using System.Windows.Forms;
using DentalClinicProject.classes;
using DentalClinicProject.data;

namespace DentalClinicProject.UI
{
    public partial class MyPatientsFormUI : System.Windows.Forms.Form
    {
        private readonly string _doctorId;

        public MyPatientsFormUI(string doctorId = "")
        {
            _doctorId = doctorId;
            InitializeComponent();
            SetupLogic();
        }

        private void SetupLogic()
        {
            this.Load += (s, e) => LoadPatients();

            //txtSearch.TextChanged += (s, e) => LoadPatients(txtSearch.Text);
            //txtSearch.Enter += (s, e) => { if (txtSearch.Text == "ابحث عن مريض...") txtSearch.Text = ""; };
            //txtSearch.Leave += (s, e) => { if (string.IsNullOrWhiteSpace(txtSearch.Text)) txtSearch.Text = "ابحث عن مريض..."; };

            dgvPatients.CellDoubleClick += DgvPatients_CellDoubleClick;
        }

        private void LoadPatients(string searchTerm = "")
        {
            DataStore.LoadAllFromDatabase();
            dgvPatients.Rows.Clear();

            var cases = DataStore.Cases
                .Where(c => c.DoctorId == _doctorId && c.Status == CaseStatus.Waiting && c.SentToReception == false);

            if (!string.IsNullOrEmpty(searchTerm) && searchTerm != "ابحث عن مريض...")
            {
                cases = cases.Where(c => 
                    (c.PatientName != null && c.PatientName.Contains(searchTerm)) ||
                    (c.PatientFileNumber != null && c.PatientFileNumber.Contains(searchTerm)) ||
                    (c.CaseNumber != null && c.CaseNumber.Contains(searchTerm))
                );
            }

            var sortedCases = cases.OrderByDescending(c => c.OpenedDate).ToList();

            foreach (var c in sortedCases)
            {
                string statusText = "في الانتظار";

                var rowIndex = dgvPatients.Rows.Add(
                    c.PatientFileNumber ?? "",
                    c.PatientName ?? "غير معروف",
                    c.Treatment ?? "",
                    statusText
                );
                dgvPatients.Rows[rowIndex].Tag = new { PatientId = c.PatientId, CaseId = c.CaseId };
            }
        }

        private void DgvPatients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var tag = dgvPatients.Rows[e.RowIndex].Tag as dynamic;
            if (tag == null) return;

            string patientId = tag.PatientId;
            string caseId = tag.CaseId;

            if (string.IsNullOrEmpty(patientId)) return;

            var serviceForm = new DoctorServiceFormUI(patientId, _doctorId, appointmentId: null, referralCaseId: caseId);
            if (serviceForm.ShowDialog() == DialogResult.OK)
            {
                LoadPatients(); // Refresh after service is recorded
            }
        }

        private void MyPatientsFormUI_Load(object sender, EventArgs e)
        {

        }
    }
}
