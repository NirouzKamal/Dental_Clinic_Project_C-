using DentalClinicProject.classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DentalClinicProject.Data;

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

        // ====== Auto-increment IDs ======
        private static int _patientFileCounter = 1;

        public static string NextUserId() => $"USR_{Guid.NewGuid().ToString().Substring(0, 8).ToUpper()}";
        public static string NextDoctorId() => $"DOC_{Guid.NewGuid().ToString().Substring(0, 8).ToUpper()}";
        public static string NextPatientId() => $"PAT_{Guid.NewGuid().ToString().Substring(0, 8).ToUpper()}";
        public static string GeneratePatientFileNumber()
        {
            return "PAT-" + (_patientFileCounter++ + 1000);
        }

        public static string NextAppointmentId() => $"APT_{Guid.NewGuid().ToString().Substring(0, 8).ToUpper()}";
        public static string NextCaseId() => $"CAS_{Guid.NewGuid().ToString().Substring(0, 8).ToUpper()}";
        public static string NextInvoiceId() => $"INV_{Guid.NewGuid().ToString().Substring(0, 8).ToUpper()}";
        public static string NextPaymentId() => $"PAY_{Guid.NewGuid().ToString().Substring(0, 8).ToUpper()}";
        public static string NextScheduleId() => $"SCH_{Guid.NewGuid().ToString().Substring(0, 8).ToUpper()}";
        public static string NextPayrollId() => $"PRL_{Guid.NewGuid().ToString().Substring(0, 8).ToUpper()}";

        // ====== Seed Data (بيانات تجريبية) ======
        public static void Initialize()
        {
            // IDs
            string adminId = "ADM_2026_001";
            string recId = "REC_2026_001";
            string docUser1Id = "DOC_2026_001";

            // ====== Users ======
            Users.Add(new User
            {
                UserId       = adminId,
                Username     = "ريم",
                FullName     = "ريم سعيد الطبيب",
                PasswordHash = HashPassword("232132"),
                Role         = UserRole.Admin,
                IsActive     = true
            });
            Users.Add(new User
            {
                UserId       = recId,
                Username     = "نيروز",
                FullName     = "نيروز كمال حشاد",
                PasswordHash = HashPassword("232210"),
                Role         = UserRole.Receptionist,
                IsActive     = true
            });
            Users.Add(new User
            {
                UserId       = docUser1Id,
                Username     = "د. أحمد علي",
                FullName     = "أحمد علي",
                PasswordHash = HashPassword("232130"),
                Role         = UserRole.Doctor,
                IsActive     = true
            });

            // ====== Doctors ======
            Doctors.Add(new Doctor { DoctorId = "DOC_2026_001", UserId = docUser1Id, FullName = "أحمد علي", Specialty = "طبيب أسنان عام", Phone = "0915543624", CommissionPct = 40, IsActive = true });

            // Patients
            Patients.Add(new Patient
            {
                PatientId = "PAT_1001",
                FileNumber = "PAT_1001",
                FullName = "فاطمة محمد",
                Phone = "0922222222",
                Age = 36,
                Gender = "Female",
            });
            Patients.Add(new Patient
            {
                PatientId = "PAT_1002",
                FileNumber = "PAT_1002",
                FullName = "علي محمود",
                Phone = "0933333333",
                Age = 41,
                Gender = "Male"
            });

            // Load all lists from database (overwrites in-memory lists if connection is online)
            LoadAllFromDatabase();
        }

        // ====== Password Hashing ======
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

        // ====== حساب دين المريض ======
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

        // ====== ID Generation logic based on Prefix and random numbers ======
        public static string GenerateUniqueRandomId(string prefix, string tableName, string columnName)
        {
            var rand = new Random();
            while (true)
            {
                int num = rand.Next(1000, 99999);
                string candidate = $"{prefix}_{num}";

                string sql = $"SELECT COUNT(*) FROM {tableName} WHERE {columnName} = @Candidate";
                try
                {
                    using (var conn = DbHelper.GetConnection())
                    using (var cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.Add(new SqlParameter("@Candidate", candidate));
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        if (count == 0) return candidate;
                    }
                }
                catch
                {
                    return candidate;
                }
            }
        }

        // ====== Name Splitting logic ======
        public static void SplitFullName(string fullName, out string firstName, out string middleName, out string lastName)
        {
            var parts = fullName.Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length == 0)
            {
                firstName = "مريض";
                middleName = "";
                lastName = "جديد";
            }
            else if (parts.Length == 1)
            {
                firstName = parts[0];
                middleName = "";
                lastName = parts[0];
            }
            else if (parts.Length == 2)
            {
                firstName = parts[0];
                middleName = "";
                lastName = parts[1];
            }
            else
            {
                firstName = parts[0];
                middleName = string.Join(" ", parts.Skip(1).Take(parts.Length - 2));
                lastName = parts[parts.Length - 1];
            }
        }

        // ====== Database Load Helpers ======
        public static void LoadAllFromDatabase()
        {
            LoadDoctorsFromDatabase();
            LoadPatientsFromDatabase();
            LoadAppointmentsFromDatabase();
        }

        public static void LoadDoctorsFromDatabase()
        {
            const string sql = @"
                SELECT d.DentistId, d.UserId, u.FullName, d.Speciality, u.Phone, d.DoctorPercentage, u.IsActive
                FROM dbo.Dentist d
                INNER JOIN dbo.Users u ON d.UserId = u.UserId";
            try
            {
                using (var conn = DbHelper.GetConnection())
                using (var cmd = new SqlCommand(sql, conn))
                using (var rdr = cmd.ExecuteReader())
                {
                    Doctors.Clear();
                    while (rdr.Read())
                    {
                        Doctors.Add(new Doctor
                        {
                            DoctorId = rdr["DentistId"].ToString(),
                            UserId = rdr["UserId"].ToString(),
                            FullName = rdr["FullName"].ToString(),
                            Specialty = rdr["Speciality"]?.ToString() ?? "",
                            Phone = rdr["Phone"]?.ToString() ?? "",
                            CommissionPct = Convert.ToDecimal(rdr["DoctorPercentage"]),
                            IsActive = Convert.ToBoolean(rdr["IsActive"])
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading doctors: " + ex.Message);
            }
        }

        public static void LoadPatientsFromDatabase()
        {
            const string sql = "SELECT PatientId, FirstName, MiddleName, LastName, Age, Gender, PatientPhone FROM dbo.Patients";
            try
            {
                using (var conn = DbHelper.GetConnection())
                using (var cmd = new SqlCommand(sql, conn))
                using (var rdr = cmd.ExecuteReader())
                {
                    Patients.Clear();
                    while (rdr.Read())
                    {
                        string pid = rdr["PatientId"].ToString();
                        string fname = rdr["FirstName"].ToString();
                        string mname = rdr["MiddleName"]?.ToString() ?? "";
                        string lname = rdr["LastName"].ToString();
                        string phone = rdr["PatientPhone"].ToString();
                        int age = Convert.ToInt32(rdr["Age"]);
                        string gender = rdr["Gender"].ToString();

                        string fullName = string.IsNullOrWhiteSpace(mname)
                            ? $"{fname} {lname}"
                            : $"{fname} {mname} {lname}";

                        Patients.Add(new Patient
                        {
                            PatientId = pid,
                            FileNumber = pid,
                            FullName = fullName,
                            Phone = phone,
                            Age = age,
                            Gender = gender,
                            Address = ""
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading patients: " + ex.Message);
            }
        }

        public static void LoadAppointmentsFromDatabase()
        {
            const string sql = "SELECT AppointmentNumber, PatientId, DentistId, AppointmentDate, AppointmentTime, Status FROM dbo.Appointments";
            try
            {
                using (var conn = DbHelper.GetConnection())
                using (var cmd = new SqlCommand(sql, conn))
                using (var rdr = cmd.ExecuteReader())
                {
                    Appointments.Clear();
                    while (rdr.Read())
                    {
                        string aid = rdr["AppointmentNumber"].ToString();
                        string pid = rdr["PatientId"].ToString();
                        string did = rdr["DentistId"].ToString();
                        DateTime date = Convert.ToDateTime(rdr["AppointmentDate"]);
                        TimeSpan time = (TimeSpan)rdr["AppointmentTime"];
                        string statusStr = rdr["Status"].ToString();

                        AppointmentStatus statusEnum = AppointmentStatus.Scheduled;
                        if (statusStr == "Completed" || statusStr == "مكتمل") statusEnum = AppointmentStatus.Completed;
                        else if (statusStr == "Cancelled" || statusStr == "ملغي") statusEnum = AppointmentStatus.Cancelled;

                        Appointments.Add(new Appointment
                        {
                            AppointmentId = aid,
                            PatientId = pid,
                            DoctorId = did,
                            AppointmentDate = date,
                            StartTime = time,
                            EndTime = time.Add(TimeSpan.FromHours(1)),
                            Status = statusEnum,
                            Notes = ""
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading appointments: " + ex.Message);
            }
        }
    }
}
