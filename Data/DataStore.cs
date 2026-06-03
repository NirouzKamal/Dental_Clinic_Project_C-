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
            LoadUsersFromDatabase();
            LoadDoctorsFromDatabase();
            LoadPatientsFromDatabase();
            LoadAppointmentsFromDatabase();
            LoadCasesFromDatabase();
            LoadInvoicesFromDatabase();
            LoadPaymentsFromDatabase();
            LoadPayrollFromDatabase();
        }

        public static void LoadUsersFromDatabase()
        {
            const string sql = "SELECT UserId, FullName, UserName, PasswordHash, IsActive, Phone FROM dbo.Users";
            try
            {
                using (var conn = DbHelper.GetConnection())
                using (var cmd = new SqlCommand(sql, conn))
                using (var rdr = cmd.ExecuteReader())
                {
                    Users.Clear();
                    while (rdr.Read())
                    {
                        string uid = rdr["UserId"].ToString();
                        string fullname = rdr["FullName"].ToString();
                        string username = rdr["UserName"].ToString();
                        string pass = rdr["PasswordHash"].ToString();
                        bool active = Convert.ToBoolean(rdr["IsActive"]);
                        string phone = rdr["Phone"] == DBNull.Value ? "" : rdr["Phone"].ToString();

                        string roleCode = uid.Length >= 3 ? uid.Substring(0, 3).ToUpperInvariant() : "";
                        UserRole role = UserRole.Receptionist;
                        if (roleCode == "ADM") role = UserRole.Admin;
                        else if (roleCode == "DOC") role = UserRole.Doctor;

                        Users.Add(new User
                        {
                            UserId = uid,
                            FullName = fullname,
                            Username = username,
                            PasswordHash = pass,
                            IsActive = active,
                            Phone = phone,
                            Role = role
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading users: " + ex.Message);
            }
        }

        public static void LoadCasesFromDatabase()
        {
            const string sql = @"
                SELECT 
                    c.CaseNumber, 
                    c.PatientId, 
                    c.UserId,
                    c.DentistId, 
                    c.VisitType, 
                    c.Status, 
                    c.SentToReception, 
                    c.OpenedAt, 
                    c.ClosedAt,
                    ci.ToothNumber,
                    ci.Discount,
                    s.ServiceName,
                    s.ServicePrice
                FROM dbo.Cases c
                LEFT JOIN dbo.CaseItems ci ON c.CaseNumber = ci.CaseNumber
                LEFT JOIN dbo.Service s ON ci.ServiceCode = s.ServiceCode";
            try
            {
                using (var conn = DbHelper.GetConnection())
                {
                    EnsureServicesSeeded(conn);

                    using (var cmd = new SqlCommand(sql, conn))
                    using (var rdr = cmd.ExecuteReader())
                    {
                        Cases.Clear();
                        while (rdr.Read())
                        {
                            string caseNum = rdr["CaseNumber"].ToString();
                            string patientId = rdr["PatientId"].ToString();
                            string dentistId = rdr["DentistId"].ToString();
                            string visitType = rdr["VisitType"].ToString();
                            string statusStr = rdr["Status"].ToString();
                            bool sentToRec = Convert.ToBoolean(rdr["SentToReception"]);
                            DateTime openedAt = Convert.ToDateTime(rdr["OpenedAt"]);
                            DateTime? closedAt = rdr["ClosedAt"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(rdr["ClosedAt"]);

                            var pat = Patients.FirstOrDefault(p => p.PatientId == patientId);
                            var doc = Doctors.FirstOrDefault(d => d.DoctorId == dentistId);

                            string treatment = visitType;
                            decimal price = 0;
                            decimal discount = 0;
                            int toothCount = 1;

                            if (rdr["ServiceName"] != DBNull.Value)
                            {
                                treatment = rdr["ServiceName"].ToString();
                                price = Convert.ToDecimal(rdr["ServicePrice"]);
                                discount = Convert.ToDecimal(rdr["Discount"]);
                                toothCount = Convert.ToInt32(rdr["ToothNumber"]);
                            }
                            else
                            {
                                price = ClinicServicePricing.GetPrice(visitType);
                            }

                            CaseStatus statusEnum = CaseStatus.Waiting;
                            if (Enum.TryParse<CaseStatus>(statusStr, true, out var parsedStatus))
                            {
                                statusEnum = parsedStatus;
                            }
                            else
                            {
                                if (statusStr == "Completed" || statusStr == "مكتمل") statusEnum = CaseStatus.Completed;
                                else if (statusStr == "Cancelled" || statusStr == "ملغي") statusEnum = CaseStatus.Cancelled;
                            }

                            Cases.Add(new Case
                            {
                                CaseId = caseNum, // Map CaseId to CaseNumber
                                CaseNumber = caseNum,
                                PatientId = patientId,
                                PatientFileNumber = pat?.FileNumber ?? "",
                                PatientName = pat?.FullName ?? "",
                                DoctorId = dentistId,
                                DoctorName = doc?.FullName ?? "",
                                Treatment = treatment,
                                ToothCount = toothCount,
                                Price = price,
                                Discount = discount,
                                Status = statusEnum,
                                OpenedDate = openedAt,
                                Date = openedAt.Date,
                                ClosedAt = closedAt,
                                SentToReception = sentToRec,
                                VisitBatchId = ""
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading cases: " + ex.Message);
            }
        }

        public static void LoadInvoicesFromDatabase()
        {
            const string sql = "SELECT InvoiceId, CaseNumber, PatientId, TotalAmount, IssuedDate = InvoiceDate, Status FROM dbo.Invoice";
            try
            {
                using (var conn = DbHelper.GetConnection())
                using (var cmd = new SqlCommand(sql, conn))
                using (var rdr = cmd.ExecuteReader())
                {
                    Invoices.Clear();
                    while (rdr.Read())
                    {
                        string invId = rdr["InvoiceId"].ToString();
                        string caseNum = rdr["CaseNumber"].ToString();
                        string patId = rdr["PatientId"].ToString();
                        decimal total = Convert.ToDecimal(rdr["TotalAmount"]);
                        DateTime issued = Convert.ToDateTime(rdr["IssuedDate"]);
                        string status = rdr["Status"].ToString();
                        bool isPaid = status == "Paid" || status == "مكتمل";

                        var c = Cases.FirstOrDefault(x => x.CaseNumber == caseNum);
                        var doc = Doctors.FirstOrDefault(d => d.DoctorId == c?.DoctorId);
                        decimal pct = doc != null ? doc.CommissionPct : 40;
                        decimal docShare = total * (pct / 100);

                        Invoices.Add(new Invoice
                        {
                            InvoiceId = invId,
                            CaseId = caseNum,
                            PatientId = patId,
                            TotalAmount = total,
                            DoctorShare = docShare,
                            ClinicRevenue = total - docShare,
                            IssuedDate = issued,
                            IsPaid = isPaid
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading invoices: " + ex.Message);
            }
        }

        public static void LoadPaymentsFromDatabase()
        {
            const string sql = "SELECT PaymentId, InvoiceId, PaymentDate, PaymentMethod, Amount FROM dbo.Payments";
            try
            {
                using (var conn = DbHelper.GetConnection())
                using (var cmd = new SqlCommand(sql, conn))
                using (var rdr = cmd.ExecuteReader())
                {
                    Payments.Clear();
                    while (rdr.Read())
                    {
                        string payId = rdr["PaymentId"].ToString();
                        string invId = rdr["InvoiceId"].ToString();
                        DateTime date = Convert.ToDateTime(rdr["PaymentDate"]);
                        string method = rdr["PaymentMethod"]?.ToString() ?? "نقدي";
                        decimal amount = Convert.ToDecimal(rdr["Amount"]);

                        var p = new Payment
                        {
                            PaymentId = payId,
                            InvoiceId = invId,
                            AmountPaid = amount,
                            PaymentDate = date,
                            Method = method
                        };

                        var inv = Invoices.FirstOrDefault(i => i.InvoiceId == invId);
                        if (inv != null) p.SetInvoiceTotal(inv.TotalAmount);

                        Payments.Add(p);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading payments: " + ex.Message);
            }
        }

        public static void LoadPayrollFromDatabase()
        {
            const string sql = "SELECT SalaryId, UserId, BaseSalary, TotalSalary, SalaryMonth, SalaryYear, PaidDate FROM dbo.Salary WHERE PaymentStatus = 'Paid'";
            try
            {
                using (var conn = DbHelper.GetConnection())
                using (var cmd = new SqlCommand(sql, conn))
                using (var rdr = cmd.ExecuteReader())
                {
                    PayrollRecords.Clear();
                    while (rdr.Read())
                    {
                        string salaryId = rdr["SalaryId"].ToString();
                        string userId = rdr["UserId"].ToString();
                        decimal baseSal = Convert.ToDecimal(rdr["BaseSalary"]);
                        decimal totalSal = Convert.ToDecimal(rdr["TotalSalary"]);
                        int month = Convert.ToInt32(rdr["SalaryMonth"]);
                        int year = Convert.ToInt32(rdr["SalaryYear"]);
                        DateTime paidDate = rdr["PaidDate"] == DBNull.Value ? DateTime.Now : Convert.ToDateTime(rdr["PaidDate"]);

                        var user = Users.FirstOrDefault(u => u.UserId == userId);
                        string fullName = user?.FullName ?? user?.Username ?? "";
                        string role = user?.Role == UserRole.Doctor ? "طبيب" : (user?.Role == UserRole.Admin ? "مسؤول" : "استقبال");

                        PayrollRecords.Add(new PayrollRecord
                        {
                            PayrollId = salaryId,
                            UserId = userId,
                            FullName = fullName,
                            Role = role,
                            Month = month,
                            Year = year,
                            BaseSalaryPaid = baseSal,
                            CommissionPaid = totalSal - baseSal,
                            Deductions = 0,
                            NetPay = totalSal,
                            IssueDate = paidDate
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading payroll: " + ex.Message);
            }
        }

        public static void EnsureServicesSeeded(SqlConnection conn)
        {
            const string checkSql = "SELECT COUNT(*) FROM dbo.Service";
            using (var cmd = new SqlCommand(checkSql, conn))
            {
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count > 0) return;
            }

            const string insertSql = @"
                INSERT INTO dbo.Service (ServiceCode, ServiceName, ServicePrice)
                VALUES (@Code, @Name, @Price)";

            var services = new Dictionary<string, decimal>
            {
                { "كشف", 40m },
                { "مراجعة", 0m },
                { "حشو عادي", 120m },
                { "حشوة تجميلية", 150m },
                { "خلع عادي", 100m },
                { "خلع جراحي", 450m },
                { "تغليف سن (Zirconia/E-max)", 600m },
                { "(علاج عصب (خلفي /طواحن", 750m },
                { "علاج عصب امامي", 500m },
                { "فينير", 1200m },
                { "علاج لثة عميق", 400m },
                { "تنظيف جير وتلميع", 190m }
            };

            foreach (var kvp in services)
            {
                using (var cmd = new SqlCommand(insertSql, conn))
                {
                    cmd.Parameters.AddWithValue("@Code", kvp.Key);
                    cmd.Parameters.AddWithValue("@Name", kvp.Key);
                    cmd.Parameters.AddWithValue("@Price", kvp.Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void SaveCaseToDatabase(Case c)
        {
            if (c == null) return;

            string selectSql = "SELECT COUNT(*) FROM dbo.Cases WHERE CaseNumber = @CaseNumber";
            string insertCaseSql = @"
                INSERT INTO dbo.Cases (CaseNumber, PatientId, UserId, DentistId, VisitType, Status, SentToReception, OpenedAt, ClosedAt)
                VALUES (@CaseNumber, @PatientId, @UserId, @DentistId, @VisitType, @Status, @SentToReception, @OpenedAt, @ClosedAt)";
            string updateCaseSql = @"
                UPDATE dbo.Cases
                SET Status = @Status, SentToReception = @SentToReception, ClosedAt = @ClosedAt,
                    OpenedAt = @OpenedAt, VisitType = @VisitType
                WHERE CaseNumber = @CaseNumber";

            try
            {
                using (var conn = DbHelper.GetConnection())
                {
                    EnsureServicesSeeded(conn);

                    int count = 0;
                    using (var cmd = new SqlCommand(selectSql, conn))
                    {
                        cmd.Parameters.AddWithValue("@CaseNumber", c.CaseNumber);
                        count = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    string currentUserId = CurrentUser?.UserId ?? "ADM_2026_001";

                    if (count == 0)
                    {
                        using (var cmd = new SqlCommand(insertCaseSql, conn))
                        {
                            cmd.Parameters.AddWithValue("@CaseNumber", c.CaseNumber);
                            cmd.Parameters.AddWithValue("@PatientId", c.PatientId);
                            cmd.Parameters.AddWithValue("@UserId", currentUserId);
                            cmd.Parameters.AddWithValue("@DentistId", c.DoctorId);
                            cmd.Parameters.AddWithValue("@VisitType", c.Treatment ?? "");
                            cmd.Parameters.AddWithValue("@Status", c.Status.ToString());
                            cmd.Parameters.AddWithValue("@SentToReception", c.SentToReception);
                            cmd.Parameters.AddWithValue("@OpenedAt", c.OpenedDate);
                            cmd.Parameters.AddWithValue("@ClosedAt", (object)c.ClosedAt ?? DBNull.Value);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        using (var cmd = new SqlCommand(updateCaseSql, conn))
                        {
                            cmd.Parameters.AddWithValue("@CaseNumber", c.CaseNumber);
                            cmd.Parameters.AddWithValue("@Status", c.Status.ToString());
                            cmd.Parameters.AddWithValue("@SentToReception", c.SentToReception);
                            cmd.Parameters.AddWithValue("@ClosedAt", (object)c.ClosedAt ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@OpenedAt", c.OpenedDate);
                            cmd.Parameters.AddWithValue("@VisitType", c.Treatment ?? "");
                            cmd.ExecuteNonQuery();
                        }
                    }

                    if (!string.IsNullOrEmpty(c.Treatment))
                    {
                        string serviceSql = "SELECT COUNT(*) FROM dbo.Service WHERE ServiceCode = @Code";
                        bool serviceExists = false;
                        using (var cmd = new SqlCommand(serviceSql, conn))
                        {
                            cmd.Parameters.AddWithValue("@Code", c.Treatment);
                            serviceExists = Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                        }

                        if (!serviceExists)
                        {
                            string insertService = "INSERT INTO dbo.Service (ServiceCode, ServiceName, ServicePrice) VALUES (@Code, @Name, @Price)";
                            using (var cmd = new SqlCommand(insertService, conn))
                            {
                                cmd.Parameters.AddWithValue("@Code", c.Treatment);
                                cmd.Parameters.AddWithValue("@Name", c.Treatment);
                                cmd.Parameters.AddWithValue("@Price", c.Price);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        string deleteItemSql = "DELETE FROM dbo.CaseItems WHERE CaseNumber = @CaseNumber AND ServiceCode = @Code";
                        using (var cmd = new SqlCommand(deleteItemSql, conn))
                        {
                            cmd.Parameters.AddWithValue("@CaseNumber", c.CaseNumber);
                            cmd.Parameters.AddWithValue("@Code", c.Treatment);
                            cmd.ExecuteNonQuery();
                        }

                        string insertItemSql = @"
                            INSERT INTO dbo.CaseItems (ToothNumber, CaseNumber, ServiceCode, Discount, AddedAt)
                            VALUES (@ToothNumber, @CaseNumber, @ServiceCode, @Discount, @AddedAt)";
                        using (var cmd = new SqlCommand(insertItemSql, conn))
                        {
                            cmd.Parameters.AddWithValue("@ToothNumber", c.ToothCount < 1 ? 1 : c.ToothCount);
                            cmd.Parameters.AddWithValue("@CaseNumber", c.CaseNumber);
                            cmd.Parameters.AddWithValue("@ServiceCode", c.Treatment);
                            cmd.Parameters.AddWithValue("@Discount", c.Discount);
                            cmd.Parameters.AddWithValue("@AddedAt", c.OpenedDate);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving case: " + ex.Message);
            }
        }

        public static void SaveInvoiceToDatabase(Invoice inv)
        {
            if (inv == null) return;

            string selectSql = "SELECT COUNT(*) FROM dbo.Invoice WHERE InvoiceId = @InvoiceId";
            string insertSql = @"
                INSERT INTO dbo.Invoice (InvoiceId, CaseNumber, PatientId, UserId, InvoiceDate, TotalAmount, DiscountAmount, Status)
                VALUES (@InvoiceId, @CaseNumber, @PatientId, @UserId, @InvoiceDate, @TotalAmount, @DiscountAmount, @Status)";
            string updateSql = @"
                UPDATE dbo.Invoice
                SET TotalAmount = @TotalAmount, Status = @Status
                WHERE InvoiceId = @InvoiceId";

            try
            {
                using (var conn = DbHelper.GetConnection())
                {
                    int count = 0;
                    using (var cmd = new SqlCommand(selectSql, conn))
                    {
                        cmd.Parameters.AddWithValue("@InvoiceId", inv.InvoiceId);
                        count = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    string currentUserId = CurrentUser?.UserId ?? "ADM_2026_001";
                    string statusStr = inv.IsPaid ? "Paid" : "Unpaid";

                    if (count == 0)
                    {
                        using (var cmd = new SqlCommand(insertSql, conn))
                        {
                            cmd.Parameters.AddWithValue("@InvoiceId", inv.InvoiceId);
                            cmd.Parameters.AddWithValue("@CaseNumber", inv.CaseId);
                            cmd.Parameters.AddWithValue("@PatientId", inv.PatientId);
                            cmd.Parameters.AddWithValue("@UserId", currentUserId);
                            cmd.Parameters.AddWithValue("@InvoiceDate", inv.IssuedDate);
                            cmd.Parameters.AddWithValue("@TotalAmount", inv.TotalAmount);
                            cmd.Parameters.AddWithValue("@DiscountAmount", 0m);
                            cmd.Parameters.AddWithValue("@Status", statusStr);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        using (var cmd = new SqlCommand(updateSql, conn))
                        {
                            cmd.Parameters.AddWithValue("@InvoiceId", inv.InvoiceId);
                            cmd.Parameters.AddWithValue("@TotalAmount", inv.TotalAmount);
                            cmd.Parameters.AddWithValue("@Status", statusStr);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving invoice: " + ex.Message);
            }
        }

        public static void SavePaymentToDatabase(Payment p)
        {
            if (p == null) return;

            string insertSql = @"
                INSERT INTO dbo.Payments (PaymentId, InvoiceId, UserId, PaymentDate, PaymentMethod, Amount)
                VALUES (@PaymentId, @InvoiceId, @UserId, @PaymentDate, @PaymentMethod, @Amount)";

            try
            {
                using (var conn = DbHelper.GetConnection())
                {
                    string currentUserId = CurrentUser?.UserId ?? "ADM_2026_001";

                    using (var cmd = new SqlCommand(insertSql, conn))
                    {
                        cmd.Parameters.AddWithValue("@PaymentId", p.PaymentId);
                        cmd.Parameters.AddWithValue("@InvoiceId", p.InvoiceId);
                        cmd.Parameters.AddWithValue("@UserId", currentUserId);
                        cmd.Parameters.AddWithValue("@PaymentDate", p.PaymentDate);
                        cmd.Parameters.AddWithValue("@PaymentMethod", p.Method ?? "نقدي");
                        cmd.Parameters.AddWithValue("@Amount", p.AmountPaid);
                        cmd.ExecuteNonQuery();
                    }

                    decimal totalPaid = 0;
                    string sumSql = "SELECT SUM(Amount) FROM dbo.Payments WHERE InvoiceId = @InvoiceId";
                    using (var cmd = new SqlCommand(sumSql, conn))
                    {
                        cmd.Parameters.AddWithValue("@InvoiceId", p.InvoiceId);
                        var res = cmd.ExecuteScalar();
                        if (res != DBNull.Value && res != null)
                            totalPaid = Convert.ToDecimal(res);
                    }

                    decimal totalAmount = 0;
                    string totalSql = "SELECT TotalAmount FROM dbo.Invoice WHERE InvoiceId = @InvoiceId";
                    using (var cmd = new SqlCommand(totalSql, conn))
                    {
                        cmd.Parameters.AddWithValue("@InvoiceId", p.InvoiceId);
                        var res = cmd.ExecuteScalar();
                        if (res != DBNull.Value && res != null)
                            totalAmount = Convert.ToDecimal(res);
                    }

                    if (totalPaid >= totalAmount)
                    {
                        string updateInvoiceSql = "UPDATE dbo.Invoice SET Status = 'Paid' WHERE InvoiceId = @InvoiceId";
                        using (var cmd = new SqlCommand(updateInvoiceSql, conn))
                        {
                            cmd.Parameters.AddWithValue("@InvoiceId", p.InvoiceId);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving payment: " + ex.Message);
            }
        }

        public static void SavePayrollToDatabase(PayrollRecord pr)
        {
            if (pr == null) return;

            string insertSql = @"
                INSERT INTO dbo.Salary (SalaryId, UserId, DentistId, BaseSalary, CommissionPercentage, TotalSalary, SalaryMonth, SalaryYear, PaymentStatus, PaidDate)
                VALUES (@SalaryId, @UserId, @DentistId, @BaseSalary, @CommissionPercentage, @TotalSalary, @SalaryMonth, @SalaryYear, @PaymentStatus, @PaidDate)";

            try
            {
                using (var conn = DbHelper.GetConnection())
                {
                    string dentistId = null;
                    decimal commissionPct = 0;
                    var doc = Doctors.FirstOrDefault(d => d.UserId == pr.UserId);
                    if (doc != null)
                    {
                        dentistId = doc.DoctorId;
                        commissionPct = doc.CommissionPct;
                    }

                    using (var cmd = new SqlCommand(insertSql, conn))
                    {
                        cmd.Parameters.AddWithValue("@SalaryId", pr.PayrollId);
                        cmd.Parameters.AddWithValue("@UserId", pr.UserId);
                        cmd.Parameters.AddWithValue("@DentistId", (object)dentistId ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@BaseSalary", pr.BaseSalaryPaid);
                        cmd.Parameters.AddWithValue("@CommissionPercentage", commissionPct);
                        cmd.Parameters.AddWithValue("@TotalSalary", pr.NetPay);
                        cmd.Parameters.AddWithValue("@SalaryMonth", (byte)pr.Month);
                        cmd.Parameters.AddWithValue("@SalaryYear", (short)pr.Year);
                        cmd.Parameters.AddWithValue("@PaymentStatus", "Paid");
                        cmd.Parameters.AddWithValue("@PaidDate", pr.IssueDate);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving payroll: " + ex.Message);
            }
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
            const string sql = "SELECT PatientId, FirstName, MiddleName, LastName, Age, Gender, PatientPhone, Address FROM dbo.Patients";
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
                        string address = rdr["Address"] == DBNull.Value ? "" : rdr["Address"].ToString();

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
                            Address = address
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
