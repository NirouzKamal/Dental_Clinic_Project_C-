using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DentalClinicProject.classes;
using DentalClinicProject.data;

namespace DentalClinicProject.UI
{
    public partial class DashboardControlUI : System.Windows.Forms.UserControl
    {
        public DashboardControlUI()
        {
            InitializeComponent();
            SetupLogic();
        }

        private void SetupLogic()
        {
            // Role-based visibility
            if (DataStore.CurrentUser != null)
            {
                switch (DataStore.CurrentUser.Role)
                {
                    case UserRole.Receptionist:
                        btnAssignPatient.Visible = true;
                        btnPendingInvoices.Visible = true;
                        btnMyPatients.Visible = false;
                        break;
                    case UserRole.Doctor:
                        btnAssignPatient.Visible = false;
                        btnPendingInvoices.Visible = false;
                        btnMyPatients.Visible = true;
                        break;
                    case UserRole.Admin:
                        btnAssignPatient.Visible = true;
                        btnPendingInvoices.Visible = true;
                        btnMyPatients.Visible = true;
                        break;
                }
            }

            this.Load += (s, e) => {
                LoadDoctors();
                LoadTodayAppointments();
            };

            cmbDoctor.SelectedIndexChanged += (s, e) => LoadTodayAppointments();

            btnAssignPatient.Click += (s, e) => {
                new UI.AssignPatientFormUI().ShowDialog();
                LoadTodayAppointments(); // refresh after assigning
            };

            btnPendingInvoices.Click += (s, e) => {
                new UI.PendingInvoicesFormUI().ShowDialog();
                LoadTodayAppointments(); // refresh 
            };

            btnMyPatients.Click += (s, e) => {
                // For Admin, let them pick which doctor's patients to view
                string doctorId = "";
                if (DataStore.CurrentUser.Role == UserRole.Admin)
                {
                    if (cmbDoctor.SelectedItem is Doctor selectedDoc && !string.IsNullOrEmpty(selectedDoc.DoctorId))
                        doctorId = selectedDoc.DoctorId;
                    else if (DataStore.Doctors.Count > 0)
                        doctorId = DataStore.Doctors.First().DoctorId;
                }
                else
                {
                    var doc = DataStore.Doctors.FirstOrDefault(d => d.UserId == DataStore.CurrentUser.UserId);
                    doctorId = doc?.DoctorId ?? "";
                }

                if (!string.IsNullOrEmpty(doctorId))
                {
                    new UI.MyPatientsFormUI(doctorId).ShowDialog();
                    LoadTodayAppointments();
                }
                else
                {
                    MessageBox.Show("لم يتم العثور على طبيب", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            };
        }

        private void LoadDoctors()
        {
            cmbDoctor.DataSource = null;
            var doctors = DataStore.Doctors.ToList();
            doctors.Insert(0, new Doctor { DoctorId = "", FullName = "الكل" }); // "All" option
            cmbDoctor.DataSource = doctors;
            cmbDoctor.DisplayMember = "FullName";
            cmbDoctor.ValueMember = "DoctorId";
            cmbDoctor.SelectedIndex = 0;
        }

        private void LoadTodayAppointments()
        {
            DataStore.LoadAllFromDatabase();
            dgvTodayAppointments.Rows.Clear();

            string selectedDoctorId = "";
            if (cmbDoctor.SelectedItem is Doctor doc)
            {
                selectedDoctorId = doc.DoctorId;
            }

            var todayAppointments = DataStore.Appointments
                .Where(a => a.AppointmentDate.Date == DateTime.Today)
                .ToList();

            if (!string.IsNullOrEmpty(selectedDoctorId))
            {
                todayAppointments = todayAppointments.Where(a => a.DoctorId == selectedDoctorId).ToList();
            }

            foreach (var appt in todayAppointments)
            {
                var patient = DataStore.Patients.FirstOrDefault(p => p.PatientId == appt.PatientId);
                var doctor = DataStore.Doctors.FirstOrDefault(d => d.DoctorId == appt.DoctorId);

                string period = appt.StartTime.Hours >= 12 ? "مساءً" : "صباحاً";
                string statusText = GetStatusText(appt.Status);

                dgvTodayAppointments.Rows.Add(
                    patient?.FileNumber ?? "",
                    patient?.FullName ?? "غير معروف",
                    patient?.Phone ?? "",
                    doctor?.FullName ?? "",
                    appt.StartTime.ToString(@"hh\:mm"),
                    period,
                    statusText
                );
            }

            CalculateKPIs(todayAppointments);
        }

        private void CalculateKPIs(List<Appointment> todayAppointments)
        {
            int total = todayAppointments.Count;
            int waiting = todayAppointments.Count(a => a.Status == AppointmentStatus.Scheduled);
            int completed = todayAppointments.Count(a => a.Status == AppointmentStatus.Completed);

            lblTotalAppointmentsValue.Text = total.ToString();
            lblWaitingCasesValue.Text = waiting.ToString();
            lblCompletedCasesValue.Text = completed.ToString();
        }

        private string GetStatusText(AppointmentStatus status)
        {
            switch (status)
            {
                case AppointmentStatus.Scheduled: return "معلق"; 
                case AppointmentStatus.Completed: return "مكتمل";
                case AppointmentStatus.Cancelled: return "ملغي";
                default: return "معلق";
            }
        }

        private void btnPendingInvoices_Click(object sender, EventArgs e)
        {

        }
    }
}
