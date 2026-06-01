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

            txtSearch.TextChanged += (s, e) => LoadPatients(txtSearch.Text);
            txtSearch.Enter += (s, e) => { if (txtSearch.Text == "ابحث عن مريض...") txtSearch.Text = ""; };
            txtSearch.Leave += (s, e) => { if (string.IsNullOrWhiteSpace(txtSearch.Text)) txtSearch.Text = "ابحث عن مريض..."; };

            dgvPatients.CellDoubleClick += DgvPatients_CellDoubleClick;
        }

        private void LoadPatients(string searchTerm = "")
        {
            dgvPatients.Rows.Clear();

            var doctorAppointments = DataStore.Appointments
                .Where(a => a.DoctorId == _doctorId && a.Status == AppointmentStatus.Scheduled)
                .OrderByDescending(a => a.AppointmentDate)
                .ThenBy(a => a.StartTime)
                .ToList();

            foreach (var appt in doctorAppointments)
            {
                var patient = DataStore.Patients.FirstOrDefault(p => p.PatientId == appt.PatientId);
                if (patient == null) continue;

                if (!string.IsNullOrEmpty(searchTerm) && searchTerm != "ابحث عن مريض...")
                {
                    if (!patient.FullName.Contains(searchTerm) &&
                        !(patient.FileNumber != null && patient.FileNumber.Contains(searchTerm)) &&
                        !(patient.Phone != null && patient.Phone.Contains(searchTerm)))
                        continue;
                }

                string statusText;
                switch (appt.Status)
                {
                    case AppointmentStatus.Completed: statusText = "مكتمل"; break;
                    case AppointmentStatus.Cancelled: statusText = "ملغي"; break;
                    default: statusText = "مؤكد"; break;
                }

                // Grid columns: colPatient, colDate, colTime, colStatus
                var rowIndex = dgvPatients.Rows.Add(
                    patient.FullName ?? "غير معروف",
                    appt.AppointmentDate.ToString("yyyy/MM/dd"),
                    appt.StartTime.ToString(@"hh\:mm"),
                    statusText
                );
                dgvPatients.Rows[rowIndex].Tag = new { PatientId = patient.PatientId, AppointmentId = appt.AppointmentId };
            }
        }

        private void DgvPatients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var tag = dgvPatients.Rows[e.RowIndex].Tag as dynamic;
            if (tag == null) return;

            string patientId = tag.PatientId;
            string appointmentId = tag.AppointmentId;

            if (string.IsNullOrEmpty(patientId)) return;

            var serviceForm = new DoctorServiceFormUI(patientId, _doctorId, appointmentId);
            if (serviceForm.ShowDialog() == DialogResult.OK)
            {
                LoadPatients(); // Refresh after service is recorded
            }
        }
    }
}
