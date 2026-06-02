using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using DentalClinicProject.classes;
using DentalClinicProject.data;
using DentalClinicProject.Data;

namespace DentalClinicProject.UI
{
    public partial class AddAppointmentFormUI : Form
    {
        private sealed class TimeSlotItem
        {
            public string Display { get; set; }
            public TimeSpan Value { get; set; }

            public override string ToString() => Display ?? "";
        }

        private sealed class ComboItem
        {
            public string Id { get; set; }
            public string Name { get; set; }

            public override string ToString() => Name ?? "";
        }

        private static readonly TimeSpan ShiftStart = new TimeSpan(10, 0, 0);
        private static readonly TimeSpan ShiftEnd = new TimeSpan(16, 0, 0);

        /// <summary>Mock pre-booked slots (UI simulation only).</summary>
        private static readonly HashSet<TimeSpan> MockBookedSlots = new HashSet<TimeSpan>
        {
            new TimeSpan(11, 0, 0),
            new TimeSpan(14, 0, 0)
        };

        private readonly string _preselectedPatientId;
        private bool _suppressDateChange;

        public AddAppointmentFormUI(string preselectedPatientId = null, Doctor doctor = null, DateTime? date = null, TimeSpan? time = null)
        {
            InitializeComponent();
            _preselectedPatientId = preselectedPatientId;
            SetupLogic(doctor, date, time);
        }

        private void SetupLogic(Doctor preselectedDoctor, DateTime? preselectedDate, TimeSpan? preselectedTime)
        {
            dtpDate.MinDate = DateTime.Today;
            dtpDate.Value = preselectedDate?.Date ?? DateTime.Today;

            cmbVisitType.Items.Clear();
            cmbVisitType.Items.AddRange(new object[] { "كشف", "مراجعة" });
            cmbVisitType.SelectedIndex = 0;

            ResetTimeSlotsCombo();

            Load += (s, e) =>
            {
                LoadPatientsCombo();
                LoadDoctorsCombo();

                if (preselectedDoctor != null)
                {
                    SelectComboById(cmbDoctor, preselectedDoctor.DoctorId);
                    cmbDoctor.Enabled = false;
                    lblTitle.Text = "إضافة موعد جديد — " + preselectedDoctor.FullName;
                }

                if (!string.IsNullOrEmpty(_preselectedPatientId))
                {
                    SelectComboById(cmbPatient, _preselectedPatientId);
                    var patient = GetPatientName(_preselectedPatientId);
                    if (!string.IsNullOrEmpty(patient))
                        lblTitle.Text = "حجز موعد — " + patient;
                }

                FetchAvailableSlots();

                if (preselectedTime.HasValue && cmbTimeSlots.Enabled)
                {
                    foreach (TimeSlotItem item in cmbTimeSlots.Items)
                    {
                        if (item.Value == preselectedTime.Value)
                        {
                            cmbTimeSlots.SelectedItem = item;
                            break;
                        }
                    }
                }
            };

            cmbDoctor.SelectedIndexChanged += CmbDoctor_SelectedIndexChanged;
            dtpDate.ValueChanged += DtpDate_ValueChanged;
            btnSave.Click += BtnSave_Click;
        }

        private void CmbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            FetchAvailableSlots();
        }

        private void DtpDate_ValueChanged(object sender, EventArgs e)
        {
            if (_suppressDateChange)
                return;
            FetchAvailableSlots();
        }

        /// <summary>
        /// Client-side slot generation (no database). Requires doctor + date.
        /// </summary>
        private void FetchAvailableSlots()
        {
            ResetTimeSlotsCombo();

            if (cmbDoctor.SelectedIndex < 0)
                return;

            DayOfWeek day = dtpDate.Value.DayOfWeek;
            if (day == DayOfWeek.Saturday || day == DayOfWeek.Sunday || day == DayOfWeek.Tuesday)
            {
                MessageBox.Show(
                    "الطبيب لا يعمل في هذا اليوم (السبت، الأحد، الثلاثاء).\r\nتم إعادة التاريخ إلى اليوم.",
                    "يوم عطلة",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);

                _suppressDateChange = true;
                dtpDate.Value = DateTime.Today;
                _suppressDateChange = false;
                return;
            }

            var freeSlots = GenerateShiftSlots()
                .Where(slot => !MockBookedSlots.Contains(slot.Value))
                .ToList();

            if (freeSlots.Count == 0)
            {
                MessageBox.Show(
                    "لا توجد أوقات متاحة في هذا اليوم.",
                    "لا توجد مواعيد",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                return;
            }

            cmbTimeSlots.DataSource = freeSlots;
            cmbTimeSlots.DisplayMember = nameof(TimeSlotItem.Display);
            cmbTimeSlots.ValueMember = nameof(TimeSlotItem.Value);
            cmbTimeSlots.Enabled = true;
            cmbTimeSlots.SelectedIndex = 0;
        }

        private static IEnumerable<TimeSlotItem> GenerateShiftSlots()
        {
            TimeSpan current = ShiftStart;
            while (current < ShiftEnd)
            {
                DateTime displayTime = DateTime.Today.Add(current);
                yield return new TimeSlotItem
                {
                    Display = displayTime.ToString("hh:mm tt", CultureInfo.InvariantCulture),
                    Value = current
                };
                current = current.Add(TimeSpan.FromHours(1));
            }
        }

        private void ResetTimeSlotsCombo()
        {
            cmbTimeSlots.DataSource = null;
            cmbTimeSlots.Items.Clear();
            cmbTimeSlots.Enabled = false;
            cmbTimeSlots.SelectedIndex = -1;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateBeforeSave())
                return;

            string patientName = (cmbPatient.SelectedItem as ComboItem)?.Name ?? cmbPatient.Text;
            string doctorName = (cmbDoctor.SelectedItem as ComboItem)?.Name ?? cmbDoctor.Text;
            string timeText = (cmbTimeSlots.SelectedItem as TimeSlotItem)?.Display ?? cmbTimeSlots.Text;
            string visitType = cmbVisitType.SelectedItem?.ToString() ?? "";

            MessageBox.Show(
                "تم التحقق من البيانات بنجاح.\r\n\r\n" +
                $"المريض: {patientName}\r\n" +
                $"الطبيب: {doctorName}\r\n" +
                $"التاريخ: {dtpDate.Value:yyyy-MM-dd}\r\n" +
                $"الوقت: {timeText}\r\n" +
                $"نوع الزيارة: {visitType}",
                "ملخص الموعد",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);

            PersistAppointmentIfPossible();

            DialogResult = DialogResult.OK;
            Close();
        }

        private bool ValidateBeforeSave()
        {
            if (cmbPatient.SelectedIndex < 0)
            {
                MessageBox.Show("الرجاء اختيار المريض.", "تنبيه",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                cmbPatient.Focus();
                return false;
            }

            if (cmbDoctor.SelectedIndex < 0)
            {
                MessageBox.Show("الرجاء اختيار الطبيب.", "تنبيه",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                cmbDoctor.Focus();
                return false;
            }

            if (cmbVisitType.SelectedIndex < 0)
            {
                MessageBox.Show("الرجاء اختيار نوع الزيارة.", "تنبيه",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                cmbVisitType.Focus();
                return false;
            }

            if (!cmbTimeSlots.Enabled || cmbTimeSlots.SelectedIndex < 0)
            {
                MessageBox.Show("الرجاء اختيار وقت متاح بعد تحديد الطبيب والتاريخ.", "تنبيه",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                return false;
            }

            return true;
        }

        /// <summary>Save to SQL Server database dbo.Appointments and synchronise local collection.</summary>
        private void PersistAppointmentIfPossible()
        {
            var patientItem = cmbPatient.SelectedItem as ComboItem;
            var doctorItem = cmbDoctor.SelectedItem as ComboItem;
            var slot = cmbTimeSlots.SelectedItem as TimeSlotItem;
            if (patientItem == null || doctorItem == null || slot == null)
                return;

            if (DataStore.HasConflict(doctorItem.Id, dtpDate.Value.Date, slot.Value, slot.Value.Add(TimeSpan.FromHours(1))))
                return;

            // Generate unique random ID for appointment (e.g. APT_4666)
            string appointmentId = DataStore.GenerateUniqueRandomId("APT", "dbo.Appointments", "AppointmentNumber");

            // Logged-in receptionist/admin UserId
            string userId = DataStore.CurrentUser?.UserId ?? "ADM_2026_001";

            const string sql = @"
                INSERT INTO dbo.Appointments
                    (AppointmentNumber, PatientId, DentistId, UserId, CaseNumber, AppointmentDate, AppointmentTime, Status)
                VALUES
                    (@AppId, @PatientId, @DentistId, @UserId, NULL, @Date, @Time, @Status)";

            try
            {
                using (var conn = DbHelper.GetConnection())
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@AppId", SqlDbType.NVarChar, 50) { Value = appointmentId });
                    cmd.Parameters.Add(new SqlParameter("@PatientId", SqlDbType.NVarChar, 50) { Value = patientItem.Id });
                    cmd.Parameters.Add(new SqlParameter("@DentistId", SqlDbType.NVarChar, 50) { Value = doctorItem.Id });
                    cmd.Parameters.Add(new SqlParameter("@UserId", SqlDbType.NVarChar, 50) { Value = userId });
                    cmd.Parameters.Add(new SqlParameter("@Date", SqlDbType.Date) { Value = dtpDate.Value.Date });
                    cmd.Parameters.Add(new SqlParameter("@Time", SqlDbType.Time) { Value = slot.Value });
                    cmd.Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 20) { Value = "Scheduled" });
                    cmd.ExecuteNonQuery();
                }

                // Add to cache
                DataStore.Appointments.Add(new Appointment
                {
                    AppointmentId = appointmentId,
                    PatientId = patientItem.Id,
                    DoctorId = doctorItem.Id,
                    AppointmentDate = dtpDate.Value.Date,
                    StartTime = slot.Value,
                    EndTime = slot.Value.Add(TimeSpan.FromHours(1)),
                    Status = AppointmentStatus.Scheduled,
                    Notes = cmbVisitType.SelectedItem?.ToString() ?? ""
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "حدث خطأ أثناء حفظ الموعد في قاعدة البيانات:\n" + ex.Message,
                    "خطأ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
            }
        }

        private void LoadPatientsCombo()
        {
            var items = DataStore.Patients
                .Where(p => p.IsActive)
                .Select(p => new ComboItem { Id = p.PatientId, Name = p.FullName })
                .ToList();

            BindCombo(cmbPatient, items);
        }

        private void LoadDoctorsCombo()
        {
            var items = DataStore.Doctors
                .Where(d => d.IsActive)
                .Select(d => new ComboItem { Id = d.DoctorId, Name = d.FullName })
                .ToList();

            BindCombo(cmbDoctor, items);
        }

        private static void BindCombo(ComboBox combo, List<ComboItem> items)
        {
            combo.DataSource = null;
            combo.DataSource = items;
            combo.DisplayMember = nameof(ComboItem.Name);
            combo.ValueMember = nameof(ComboItem.Id);
            combo.SelectedIndex = -1;
        }

        private static void SelectComboById(ComboBox combo, string id)
        {
            if (string.IsNullOrEmpty(id))
                return;
            for (int i = 0; i < combo.Items.Count; i++)
            {
                if (combo.Items[i] is ComboItem item && item.Id == id)
                {
                    combo.SelectedIndex = i;
                    return;
                }
            }
        }

        private static string GetPatientName(string patientId)
        {
            return DataStore.Patients.FirstOrDefault(p => p.PatientId == patientId)?.FullName ?? "";
        }
    }
}
