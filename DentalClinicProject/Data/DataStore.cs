using DentalClinicProject.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalClinicProject.data
{
    internal class DataStore
    {
        // ====== Collections (بديل SQL) ======
        public static List<User> Users = new List<User>();
        public static List<Doctor> Doctors = new List<Doctor>();
        public static List<Patient> Patients = new List<Patient>();
        public static List<Appointment> Appointments = new List<Appointment>();
        public static List<Case> Cases = new List<Case>();
        public static List<Invoice> Invoices = new List<Invoice>();
        public static List<Payment> Payments = new List<Payment>();
        public static List<DoctorWorkSchedule> DoctorSchedules = new List<DoctorWorkSchedule>();

        // المستخدم الحالي بعد اللوجن
        public static User CurrentUser { get; set; }

        // ====== Auto-increment IDs ======
        private static int _userId = 1;
        private static int _doctorId = 1;
        private static int _patientId = 1;
        private static int _appointmentId = 1;
        private static int _caseId = 1;
        private static int _invoiceId = 1;
        private static int _paymentId = 1;
        private static int _scheduleId = 1;

        public static int NextUserId() => _userId++;
        public static int NextDoctorId() => _doctorId++;
        public static int NextPatientId() => _patientId++;
        public static string GeneratePatientFileNumber()
        {
            return "PAT-" + (_patientId + 1000);
        }

        public static int NextAppointmentId() => _appointmentId++;
        public static int NextCaseId() => _caseId++;
        public static int NextInvoiceId() => _invoiceId++;
        public static int NextPaymentId() => _paymentId++;
        public static int NextScheduleId() => _scheduleId++;

        // ====== Seed Data (بيانات تجريبية) ======
        public static void Initialize()
        {
        
        // Users
        Users.Add(new User
            {
                UserId = NextUserId(),
                Username = "ريم",
                PasswordHash = HashPassword("232132"),
                Role = UserRole.Admin
            });
            Users.Add(new User
            {
                UserId = NextUserId(),
                Username = "نيروز",
                PasswordHash = HashPassword("232210"),
                Role = UserRole.Receptionist
            });
            Users.Add(new User
            {
                UserId = NextUserId(),
                Username = "د. أحمد علي",
                PasswordHash = HashPassword("232130"),
                Role = UserRole.Doctor
            });

            // Doctor
            // ====== Doctors ======
            Doctors.Add(new Doctor { DoctorId = NextDoctorId(), UserId = 3, FullName = "د. أحمد علي", Specialty = "تقويم الأسنان", Phone = "0912345678", CommissionPct = 40, IsActive = true });
            Doctors.Add(new Doctor { DoctorId = NextDoctorId(), UserId = 4, FullName = "د. سلوى حسام", Specialty = "علاج أسنان عام", Phone = "0923456789", CommissionPct = 40, IsActive = true });
            Doctors.Add(new Doctor { DoctorId = NextDoctorId(), UserId = 5, FullName = "د. مصطفى حمزة", Specialty = "جراحة الفم", Phone = "0934567890", CommissionPct = 40, IsActive = true });


            // Patients
            Patients.Add(new Patient
            {
                PatientId = NextPatientId(),
                FullName = "فاطمة محمد",
                Phone = "0922222222",
                Age = 36,
                Gender = "Female",


            });
            // ====== Doctor Schedules ======
            DoctorSchedules.Clear();

            // د. أحمد علي (DoctorId = 1)
            // مواعيد الدوام: من 9 صباحاً إلى 4 مساءً
            DoctorSchedules.Add(new DoctorWorkSchedule
            {
                ScheduleId = NextScheduleId(),
                DoctorId = 1,
                DayOfWeek = DayOfWeek.Sunday,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                IsWorking = true
            });
            DoctorSchedules.Add(new DoctorWorkSchedule
            {
                ScheduleId = NextScheduleId(),
                DoctorId = 1,
                DayOfWeek = DayOfWeek.Tuesday,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                IsWorking = true
            });
            DoctorSchedules.Add(new DoctorWorkSchedule
            {
                ScheduleId = NextScheduleId(),
                DoctorId = 1,
                DayOfWeek = DayOfWeek.Thursday,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                IsWorking = true
            });

            // د. سلوى حسام (DoctorId = 2)
            // مواعيد الدوام: من 10 صباحاً إلى 6 مساءً
            DoctorSchedules.Add(new DoctorWorkSchedule
            {
                ScheduleId = NextScheduleId(),
                DoctorId = 2,
                DayOfWeek = DayOfWeek.Monday,
                StartTime = new TimeSpan(10, 0, 0),
                EndTime = new TimeSpan(18, 0, 0),
                IsWorking = true
            });
            DoctorSchedules.Add(new DoctorWorkSchedule
            {
                ScheduleId = NextScheduleId(),
                DoctorId = 2,
                DayOfWeek = DayOfWeek.Wednesday,
                StartTime = new TimeSpan(10, 0, 0),
                EndTime = new TimeSpan(18, 0, 0),
                IsWorking = true
            });

            // د. مصطفى حمزة (DoctorId = 3)
            // مواعيد الدوام: من 11 صباحاً إلى 5 مساءً
            DoctorSchedules.Add(new DoctorWorkSchedule
            {
                ScheduleId = NextScheduleId(),
                DoctorId = 3,
                DayOfWeek = DayOfWeek.Saturday,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(17, 0, 0),
                IsWorking = true
            });
            DoctorSchedules.Add(new DoctorWorkSchedule
            {
                ScheduleId = NextScheduleId(),
                DoctorId = 3,
                DayOfWeek = DayOfWeek.Wednesday,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(17, 0, 0),
                IsWorking = true
            });

            // ====== Appointments ======
            //Appointments.Clear();
            Appointments.Add(new Appointment
            {
                AppointmentId = NextAppointmentId(),
                PatientId = 1,
                DoctorId = 1,
                // لجعل الموعد يظهر دائماً في تاريخ اليوم عند تجربة البرنامج
                AppointmentDate = DateTime.Today,
                StartTime = new TimeSpan(10, 0, 0),
                EndTime = new TimeSpan(10, 30, 0),
                Status = AppointmentStatus.Scheduled,
                Notes = "مراجعة دورية"
            });
            Appointments.Add(new Appointment
            {
                AppointmentId = NextAppointmentId(),
                PatientId = 2,
                DoctorId = 1,
                AppointmentDate = DateTime.Today,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(11, 30, 0),
                Status = AppointmentStatus.Scheduled,
                Notes = "تنظيف لثة"
            });

            // ✅ ثانياً: بعد إضافة البيانات، نضبط الـ counters
            _caseId = Cases.Count > 0 ? Cases.Max(c => c.CaseId) : _caseId;
            _invoiceId = Invoices.Count > 0 ? Invoices.Max(i => i.InvoiceId) : _invoiceId;
            _paymentId = Payments.Count > 0 ? Payments.Max(p => p.PaymentId) : _paymentId;
            _appointmentId = Appointments.Count > 0 ? Appointments.Max(a => a.AppointmentId) : _appointmentId;
            _patientId = Patients.Count > 0 ? Patients.Max(p => p.PatientId) : _patientId;
            _userId = Users.Count > 0 ? Users.Max(u => u.UserId) : _userId;
            _doctorId = Doctors.Count > 0 ? Doctors.Max(d => d.DoctorId) : _doctorId;

        }

        // ====== Password Hashing (بسيط للبروتوتايب) ======
        public static string HashPassword(string password)
        {
            using (var sha = System.Security.Cryptography.SHA256.Create())
            {
                var bytes = sha.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }

        }

        // ====== منع تعارض المواعيد ======
        public static bool HasConflict(int doctorId, DateTime date,
                                       TimeSpan start, TimeSpan end,
                                       int excludeId = -1)
        {
            return Appointments.Any(a =>
                a.DoctorId == doctorId &&
                a.AppointmentDate.Date == date.Date &&
                a.AppointmentId != excludeId &&
                a.Status == AppointmentStatus.Scheduled &&
                a.StartTime < end && a.EndTime > start);
        }

        // ====== حساب دين المريض ======س
        public static decimal GetPatientDebt(int patientId)
        {
            var invoiceIds = Invoices
                .Where(i => i.PatientId == patientId)
                .Select(i => i.InvoiceId)
                .ToList();

            decimal totalBilled = Invoices
                .Where(i => i.PatientId == patientId)
                .Sum(i => i.TotalAmount);

            decimal totalPaid = Payments
                .Where(p => invoiceIds.Contains(p.InvoiceId))
                .Sum(p => p.AmountPaid);

            return totalBilled - totalPaid;
        }
        public void CheckDataStore()
        {
            MessageBox.Show($"عدد الحالات الكلي في DataStore: {DataStore.Cases.Count}");

            string allCases = "";
            foreach (var c in DataStore.Cases)
            {
                allCases += $"CaseId: {c.CaseId}, PatientId: {c.PatientId}, Treatment: {c.Treatment}\n";
            }
            MessageBox.Show(allCases);
        }
    }
}
