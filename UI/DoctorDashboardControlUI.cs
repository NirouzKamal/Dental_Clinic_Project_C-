using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DentalClinicProject.classes;
using DentalClinicProject.data;

namespace DentalClinicProject.UI
{
    public partial class DoctorDashboardControlUI : System.Windows.Forms.UserControl
    {
        private string _doctorId;

        public DoctorDashboardControlUI(string doctorId)
        {
            _doctorId = doctorId;
            InitializeComponent();
            SetupLogic();
        }

        private void SetupLogic()
        {
            this.Load += (s, e) => LoadQueue();

            txtSearch.TextChanged += (s, e) => LoadQueue(txtSearch.Text);
            
            txtSearch.Enter += (s, e) => { if (txtSearch.Text == "ابحث عن حالة...") txtSearch.Text = ""; };
            txtSearch.Leave += (s, e) => { if (string.IsNullOrWhiteSpace(txtSearch.Text)) txtSearch.Text = "ابحث عن حالة..."; };

            btnMyPatients.Click += (s, e) => {
                new UI.MyPatientsFormUI(_doctorId).ShowDialog();
                LoadQueue(); // refresh after returning
            };
        }

        private void LoadQueue(string searchTerm = "")
        {
            dgvDoctorQueue.Rows.Clear();

            var todayAppointments = DataStore.Appointments
                .Where(a => a.DoctorId == _doctorId && a.AppointmentDate.Date == DateTime.Today)
                .OrderBy(a => a.StartTime)
                .ToList();

            int waitingCount = 0;

            foreach (var appt in todayAppointments)
            {
                var patient = DataStore.Patients.FirstOrDefault(p => p.PatientId == appt.PatientId);
                if (patient == null) continue;

                if (!string.IsNullOrEmpty(searchTerm) && searchTerm != "ابحث عن حالة...")
                {
                    if (!patient.FullName.Contains(searchTerm) && !patient.FileNumber.Contains(searchTerm))
                        continue;
                }

                string statusText = "مؤكد";
                if (appt.Status == AppointmentStatus.Completed) statusText = "مكتمل";
                else if (appt.Status == AppointmentStatus.Cancelled) statusText = "ملغي";

                if (appt.Status == AppointmentStatus.Scheduled) waitingCount++;

                dgvDoctorQueue.Rows.Add(
                    patient.FileNumber,
                    patient.FullName,
                    appt.StartTime.ToString(@"hh\:mm"),
                    appt.Notes,
                    statusText
                );
            }

            lblTotalTodayValue.Text = todayAppointments.Count.ToString();
            lblWaitingValue.Text = waitingCount.ToString();
        }
    }
}
