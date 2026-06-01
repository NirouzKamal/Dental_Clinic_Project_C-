using System;
using System.Linq;
using System.Windows.Forms;
using DentalClinicProject.classes;
using DentalClinicProject.data;

namespace DentalClinicProject.UI
{
    public partial class AddAppointmentFormUI : System.Windows.Forms.Form
    {
        private Doctor selectedDoctor;
        private DateTime? selectedDate;
        private TimeSpan? selectedTime;

        public AddAppointmentFormUI(Doctor doctor = null, DateTime? date = null, TimeSpan? time = null)
        {
            InitializeComponent();
            selectedDoctor = doctor;
            selectedDate = date;
            selectedTime = time;
            SetupLogic();
        }

        private void SetupLogic()
        {
            this.Load += (s, e) => {
                LoadPatients();
                LoadDoctors();
                
                if (selectedDate.HasValue) dtpDate.Value = selectedDate.Value;
                
                if (selectedDoctor != null)
                {
                    cmbDoctor.SelectedValue = selectedDoctor.DoctorId;
                    this.Text = "إضافة موعد جديد لـ " + selectedDoctor.FullName;
                    cmbDoctor.Enabled = false; // Lock doctor if pre-selected
                }

                LoadAvailableTimes();
            };

            dtpDate.ValueChanged += (s, e) => {
                LoadDoctors();
                LoadAvailableTimes();
            };
            cmbDoctor.SelectedIndexChanged += (s, e) => LoadAvailableTimes();

            btnSave.Click += (s, e) => {
                if (cmbPatient.SelectedIndex == -1 || cmbDoctor.SelectedIndex == -1 || cmbTime.SelectedIndex == -1)
                {
                    MessageBox.Show("الرجاء اختيار المريض، الطبيب، والوقت", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var docId = cmbDoctor.SelectedValue.ToString();
                var date = dtpDate.Value.Date;
                var time = (TimeSpan)cmbTime.SelectedValue;

                // Check for conflicts
                if (DataStore.HasConflict(docId, date, time, time.Add(TimeSpan.FromHours(1))))
                {
                    MessageBox.Show("هذا الموعد محجوز مسبقاً", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Appointment newApt = new Appointment
                {
                    AppointmentId = DataStore.NextAppointmentId(),
                    PatientId = cmbPatient.SelectedValue.ToString(),
                    DoctorId = docId,
                    AppointmentDate = date,
                    StartTime = time,
                    EndTime = time.Add(TimeSpan.FromHours(1)),
                    Status = AppointmentStatus.Scheduled,
                    Notes = txtNotes.Text
                };

                DataStore.Appointments.Add(newApt);
                MessageBox.Show("تم حفظ الموعد بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            };
        }

        private void LoadPatients()
        {
            cmbPatient.DataSource = DataStore.Patients.ToList();
            cmbPatient.DisplayMember = "FullName";
            cmbPatient.ValueMember = "PatientId";
            cmbPatient.SelectedIndex = -1;
        }

        private void LoadDoctors()
        {
            var selectedDay = dtpDate.Value.DayOfWeek;
            
            // Get IDs of doctors who work on this day
            var availableDoctorIds = DataStore.DoctorSchedules
                .Where(s => s.DayOfWeek == selectedDay && s.IsWorking)
                .Select(s => s.DoctorId)
                .Distinct()
                .ToList();

            // Find those doctors
            var availableDocs = DataStore.Doctors
                .Where(d => availableDoctorIds.Contains(d.DoctorId))
                .ToList();

            // Preserve current selection if possible, otherwise clear
            string currentSelected = cmbDoctor.SelectedValue?.ToString();

            cmbDoctor.DataSource = availableDocs;
            cmbDoctor.DisplayMember = "FullName";
            cmbDoctor.ValueMember = "DoctorId";

            if (currentSelected != null && availableDocs.Any(d => d.DoctorId == currentSelected))
                cmbDoctor.SelectedValue = currentSelected;
            else
                cmbDoctor.SelectedIndex = -1;
        }

        private void LoadAvailableTimes()
        {
            cmbTime.DataSource = null;
            if (cmbDoctor.SelectedItem is Doctor doc)
            {
                var date = dtpDate.Value.Date;
                var schedule = DataStore.DoctorSchedules.FirstOrDefault(s =>
                    s.DoctorId == doc.DoctorId &&
                    s.DayOfWeek == date.DayOfWeek && s.IsWorking);

                if (schedule == null)
                {
                    cmbTime.Enabled = false;
                    return;
                }

                cmbTime.Enabled = true;
                TimeSpan start = schedule.StartTime;
                TimeSpan end = schedule.EndTime;

                var times = new System.Collections.Generic.List<dynamic>();

                while (start < end)
                {
                    bool isBooked = DataStore.HasConflict(doc.DoctorId, date, start, start.Add(TimeSpan.FromHours(1)));
                    if (!isBooked)
                    {
                        times.Add(new { Text = DateTime.Today.Add(start).ToString("hh:mm tt"), Value = start });
                    }
                    start = start.Add(TimeSpan.FromHours(1));
                }

                cmbTime.DataSource = times;
                cmbTime.DisplayMember = "Text";
                cmbTime.ValueMember = "Value";

                if (selectedTime.HasValue && times.Any(t => t.Value == selectedTime.Value))
                {
                    cmbTime.SelectedValue = selectedTime.Value;
                }
            }
        }
    }
}
