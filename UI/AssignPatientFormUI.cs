using System;
using System.Linq;
using System.Windows.Forms;
using DentalClinicProject.classes;
using DentalClinicProject.data;

namespace DentalClinicProject.UI
{
    public partial class AssignPatientFormUI : System.Windows.Forms.Form
    {
        public AssignPatientFormUI()
        {
            InitializeComponent();
            SetupLogic();
        }

        private void SetupLogic()
        {
            this.Load += (s, e) =>
            {
                LoadPatients();
                LoadDoctors();
                LoadTimeSlots();
            };

            btnAssign.Click += BtnAssign_Click;
        }

        private void LoadPatients()
        {
            cmbPatient.DisplayMember = "DisplayText";
            cmbPatient.ValueMember = "PatientId";
            cmbPatient.DataSource = DataStore.Patients
                .Select(p => new
                {
                    p.PatientId,
                    DisplayText = $"{p.FileNumber} — {p.FullName}"
                })
                .ToList();
            cmbPatient.SelectedIndex = -1;
        }

        private void LoadDoctors()
        {
            cmbDoctor.DisplayMember = "FullName";
            cmbDoctor.ValueMember = "DoctorId";
            cmbDoctor.DataSource = DataStore.Doctors
                .Where(d => d.IsActive)
                .ToList();
            cmbDoctor.SelectedIndex = -1;
        }

        private void LoadTimeSlots()
        {
            cmbTime.Items.Clear();
            for (int hour = 8; hour <= 20; hour++)
            {
                cmbTime.Items.Add($"{hour:D2}:00");
                cmbTime.Items.Add($"{hour:D2}:30");
            }
        }

        private void BtnAssign_Click(object sender, EventArgs e)
        {
            // Validation
            if (cmbPatient.SelectedValue == null)
            {
                MessageBox.Show("الرجاء اختيار المريض", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmbDoctor.SelectedValue == null)
            {
                MessageBox.Show("الرجاء اختيار الطبيب", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmbTime.SelectedIndex == -1)
            {
                MessageBox.Show("الرجاء اختيار الوقت", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string patientId = cmbPatient.SelectedValue.ToString();
            string doctorId = cmbDoctor.SelectedValue.ToString();

            // Parse time
            string[] timeParts = cmbTime.SelectedItem.ToString().Split(':');
            int hour = int.Parse(timeParts[0]);
            int minute = int.Parse(timeParts[1]);
            TimeSpan startTime = new TimeSpan(hour, minute, 0);
            TimeSpan endTime = startTime.Add(TimeSpan.FromMinutes(30));

            // Check conflict
            if (DataStore.HasConflict(doctorId, dtpDate.Value.Date, startTime, endTime))
            {
                MessageBox.Show("يوجد تعارض في المواعيد! الرجاء اختيار وقت آخر.", "تعارض", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create appointment
            var appointment = new Appointment
            {
                AppointmentId = DataStore.NextAppointmentId(),
                PatientId = patientId,
                DoctorId = doctorId,
                AppointmentDate = dtpDate.Value.Date,
                StartTime = startTime,
                EndTime = endTime,
                Status = AppointmentStatus.Scheduled,
                Notes = txtNotes.Text.Trim()
            };
            DataStore.Appointments.Add(appointment);

            var patient = DataStore.Patients.FirstOrDefault(p => p.PatientId == patientId);
            var doctor = DataStore.Doctors.FirstOrDefault(d => d.DoctorId == doctorId);

            MessageBox.Show(
                $"✅ تم تعيين المريض بنجاح\n\n" +
                $"المريض: {patient?.FullName}\n" +
                $"الطبيب: {doctor?.FullName}\n" +
                $"التاريخ: {dtpDate.Value.Date:d}\n" +
                $"الوقت: {startTime:hh\\:mm}",
                "نجاح",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
