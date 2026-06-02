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
        public static List<PayrollRecord> PayrollRecords = new List<PayrollRecord>();

        // المستخدم الحالي بعد اللوجن
        public static User CurrentUser { get; set; }

        /// <summary>تواريخ تم فيها تأكيد إغلاق إيرادات اليوم (جلسة التشغيل الحالية).</summary>
        public static HashSet<DateTime> DailyRevenueClosedDates = new HashSet<DateTime>();

        // ====== Auto-increment IDs ======
        private static int _patientFileCounter = 1;

        public static string NextUserId() => $"USR-{Guid.NewGuid().ToString().Substring(0, 8).ToUpper()}";
        public static string NextDoctorId() => $"DOC-{Guid.NewGuid().ToString().Substring(0, 8).ToUpper()}";
        public static string NextPatientId() => $"PAT-{Guid.NewGuid().ToString().Substring(0, 8).ToUpper()}";
        public static string GeneratePatientFileNumber()
        {
            return "PAT-" + (_patientFileCounter++ + 1000);
        }

        public static string NextAppointmentId() => $"APT-{Guid.NewGuid().ToString().Substring(0, 8).ToUpper()}";
        public static string NextCaseId() => $"CAS-{Guid.NewGuid().ToString().Substring(0, 8).ToUpper()}";
        public static string NextInvoiceId() => $"INV-{Guid.NewGuid().ToString().Substring(0, 8).ToUpper()}";
        public static string NextPaymentId() => $"PAY-{Guid.NewGuid().ToString().Substring(0, 8).ToUpper()}";
        public static string NextScheduleId() => $"SCH-{Guid.NewGuid().ToString().Substring(0, 8).ToUpper()}";
        public static string NextPayrollId() => $"PRL-{Guid.NewGuid().ToString().Substring(0, 8).ToUpper()}";

        // ====== Seed Data (بيانات تجريبية) ======
        public static void Initialize()
        {
            // IDs
            string adminId = NextUserId();
            string recId = NextUserId();
            string docUser1Id = NextUserId();
            string docUser2Id = NextUserId();
            string docUser3Id = NextUserId();

            string doc1Id = NextDoctorId();
            string doc2Id = NextDoctorId();
            string doc3Id = NextDoctorId();

            string pat1Id = NextPatientId();
            string pat2Id = NextPatientId();

            // Users
            Users.Add(new User
            {
                UserId = adminId,
                Username = "ريم",
                PasswordHash = HashPassword("232132"),
                Role = UserRole.Admin
            });
            Users.Add(new User
            {
                UserId = recId,
                Username = "نيروز",
                PasswordHash = HashPassword("232210"),
                Role = UserRole.Receptionist
            });
            Users.Add(new User
            {
                UserId = docUser1Id,
                Username = "د. أحمد علي",
                PasswordHash = HashPassword("232130"),
                Role = UserRole.Doctor
            });

            // ====== Doctors ======
            Doctors.Add(new Doctor { DoctorId = doc1Id, UserId = docUser1Id, FullName = "د. أحمد علي", Specialty = "تقويم الأسنان", Phone = "0912345678", CommissionPct = 40, IsActive = true });
            Doctors.Add(new Doctor { DoctorId = doc2Id, UserId = docUser2Id, FullName = "د. سلوى حسام", Specialty = "علاج أسنان عام", Phone = "0923456789", CommissionPct = 40, IsActive = true });
            Doctors.Add(new Doctor { DoctorId = doc3Id, UserId = docUser3Id, FullName = "د. مصطفى حمزة", Specialty = "جراحة الفم", Phone = "0934567890", CommissionPct = 40, IsActive = true });


            // Patients
            Patients.Add(new Patient
            {
                PatientId = pat1Id,
                FullName = "فاطمة محمد",
                Phone = "0922222222",
                Age = 36,
                Gender = "Female",
            });
            Patients.Add(new Patient
            {
                PatientId = pat2Id,
                FullName = "علي محمود",
                Phone = "0933333333",
                Age = 41,
                Gender = "Male"
            });

            // ====== Doctor Schedules ======
            DoctorSchedules.Clear();

            // د. أحمد علي
            DoctorSchedules.Add(new DoctorWorkSchedule
            {
                ScheduleId = NextScheduleId(),
                DoctorId = doc1Id,
                DayOfWeek = DayOfWeek.Sunday,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                IsWorking = true
            });
            DoctorSchedules.Add(new DoctorWorkSchedule
            {
                ScheduleId = NextScheduleId(),
                DoctorId = doc1Id,
                DayOfWeek = DayOfWeek.Tuesday,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                IsWorking = true
            });
            DoctorSchedules.Add(new DoctorWorkSchedule
            {
                ScheduleId = NextScheduleId(),
                DoctorId = doc1Id,
                DayOfWeek = DayOfWeek.Thursday,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                IsWorking = true
            });

            // د. سلوى حسام
            DoctorSchedules.Add(new DoctorWorkSchedule
            {
                ScheduleId = NextScheduleId(),
                DoctorId = doc2Id,
                DayOfWeek = DayOfWeek.Monday,
                StartTime = new TimeSpan(10, 0, 0),
                EndTime = new TimeSpan(18, 0, 0),
                IsWorking = true
            });
            DoctorSchedules.Add(new DoctorWorkSchedule
            {
                ScheduleId = NextScheduleId(),
                DoctorId = doc2Id,
                DayOfWeek = DayOfWeek.Wednesday,
                StartTime = new TimeSpan(10, 0, 0),
                EndTime = new TimeSpan(18, 0, 0),
                IsWorking = true
            });

            // د. مصطفى حمزة
            DoctorSchedules.Add(new DoctorWorkSchedule
            {
                ScheduleId = NextScheduleId(),
                DoctorId = doc3Id,
                DayOfWeek = DayOfWeek.Saturday,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(17, 0, 0),
                IsWorking = true
            });
            DoctorSchedules.Add(new DoctorWorkSchedule
            {
                ScheduleId = NextScheduleId(),
                DoctorId = doc3Id,
                DayOfWeek = DayOfWeek.Wednesday,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(17, 0, 0),
                IsWorking = true
            });

            // ====== Appointments ======
            Appointments.Add(new Appointment
            {
                AppointmentId = NextAppointmentId(),
                PatientId = pat1Id,
                DoctorId = doc1Id,
                AppointmentDate = DateTime.Today,
                StartTime = new TimeSpan(10, 0, 0),
                EndTime = new TimeSpan(10, 30, 0),
                Status = AppointmentStatus.Scheduled,
                Notes = "مراجعة دورية"
            });
            Appointments.Add(new Appointment
            {
                AppointmentId = NextAppointmentId(),
                PatientId = pat2Id,
                DoctorId = doc1Id,
                AppointmentDate = DateTime.Today,
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(11, 30, 0),
                Status = AppointmentStatus.Scheduled,
                Notes = "تنظيف لثة"
            });
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
        public static bool HasConflict(string doctorId, DateTime date,
                                       TimeSpan start, TimeSpan end,
                                       string excludeId = null)
        {
            return Appointments.Any(a =>
                a.DoctorId == doctorId &&
                a.AppointmentDate.Date == date.Date &&
                a.AppointmentId != excludeId &&
                a.Status == AppointmentStatus.Scheduled &&
                a.StartTime < end && a.EndTime > start);
        }

        // ====== حساب دين المريض ======س
        public static decimal GetPatientDebt(string patientId)
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
