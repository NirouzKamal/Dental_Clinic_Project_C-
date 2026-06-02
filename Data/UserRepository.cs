using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace DentalClinicProject.Data
{
    /// <summary>
    /// Handles all database operations related to the Users table.
    /// Connects to SQL Server via ADO.NET and uses SqlParameter on every
    /// query to prevent SQL Injection attacks.
    /// </summary>
    public static class UserRepository
    {
        // ────────────────────────────────────────────────────────────────
        //  Public API
        // ────────────────────────────────────────────────────────────────

        /// <summary>
        /// Validates a login attempt against the SQL Server Users table.
        /// </summary>
        /// <param name="username">Plain-text username entered by the user.</param>
        /// <param name="plainPassword">Plain-text password entered by the user.</param>
        /// <returns>
        ///   A populated <see cref="LoginResult"/> on success;
        ///   a <see cref="LoginResult"/> with <c>IsSuccess = false</c> and an
        ///   appropriate <c>ErrorMessage</c> on failure.
        /// </returns>
        public static LoginResult ValidateLogin(string username, string plainPassword)
        {
            // 1. Hash the password the same way it was stored in the DB
            string hashedPassword = HashPassword(plainPassword);

            // ── SQL Query ────────────────────────────────────────────────
            // We select every column we need in one round-trip.
            // UserName is matched case-insensitively (SQL Server default
            // collation); IsActive is checked server-side for efficiency.
            // SqlParameter prevents any SQL Injection attack.
            const string sql = @"
                SELECT
                    UserId,
                    FullName,
                    UserName,
                    PasswordHash,
                    IsActive
                FROM Users
                WHERE UserName = @UserName";
            // ─────────────────────────────────────────────────────────────

            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    // ── SqlParameter — NO string concatenation ───────────
                    cmd.Parameters.Add(new SqlParameter("@UserName", SqlDbType.NVarChar, 50)
                    {
                        Value = username.Trim()
                    });
                    // ─────────────────────────────────────────────────────

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            // Username does not exist in the database
                            return LoginResult.Fail("اسم المستخدم أو كلمة المرور غير صحيحة.");
                        }

                        // ── Read columns ─────────────────────────────────
                        string dbUserId       = reader["UserId"].ToString();
                        string dbFullName     = reader["FullName"].ToString();
                        string dbPasswordHash = reader["PasswordHash"].ToString();
                        bool   dbIsActive     = Convert.ToBoolean(reader["IsActive"]);
                        // ─────────────────────────────────────────────────

                        // 2. Check IsActive BEFORE checking password
                        //    so a deactivated account never reveals whether
                        //    the password was correct.
                        if (!dbIsActive)
                        {
                            return LoginResult.Fail(
                                "هذا الحساب موقوف. يرجى التواصل مع المسؤول.");
                        }

                        // 3. Compare hashed passwords
                        if (!string.Equals(dbPasswordHash, hashedPassword,
                                           StringComparison.Ordinal))
                        {
                            return LoginResult.Fail("اسم المستخدم أو كلمة المرور غير صحيحة.");
                        }

                        // 4. Extract role from the first 3 characters of UserId
                        //    Format: [ROLE]_[YEAR]_[SEQ]  →  e.g. ADM_2026_001
                        string roleCode = dbUserId.Length >= 3
                            ? dbUserId.Substring(0, 3).ToUpperInvariant()
                            : string.Empty;

                        UserRole role = MapRoleCode(roleCode);

                        // 5. Build and return the authenticated User object
                        var user = new User
                        {
                            UserId       = dbUserId,
                            FullName     = dbFullName,
                            Username     = dbUserId, // keep consistent with existing model
                            PasswordHash = dbPasswordHash,
                            IsActive     = dbIsActive,
                            Role         = role
                        };

                        return LoginResult.Success(user);
                    }
                }
            }
            catch (SqlException ex)
            {
                // Surface a friendly message; log the technical detail to
                // the Output window for the developer.
                System.Diagnostics.Debug.WriteLine($"[UserRepository] SQL error: {ex}");
                return LoginResult.Fail(
                    "تعذّر الاتصال بقاعدة البيانات.\n" +
                    "يرجى التحقق من إعدادات الخادم والمحاولة مجدداً.");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"[UserRepository] Unexpected error: {ex}");
                return LoginResult.Fail("حدث خطأ غير متوقع. يرجى التواصل مع المسؤول.");
            }
        }

        // ────────────────────────────────────────────────────────────────
        //  Helpers
        // ────────────────────────────────────────────────────────────────

        /// <summary>
        /// SHA-256 hash with Base64 encoding — must match how passwords
        /// were originally stored in the database.
        /// </summary>
        public static string HashPassword(string plainText)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(plainText));
                return Convert.ToBase64String(bytes);
            }
        }

        /// <summary>
        /// Maps the 3-character role prefix extracted from UserId to the
        /// application's <see cref="UserRole"/> enum.
        /// </summary>
        private static UserRole MapRoleCode(string code)
        {
            switch (code)
            {
                case "ADM": return UserRole.Admin;
                case "DOC": return UserRole.Doctor;
                case "REC": return UserRole.Receptionist;
                default:
                    // Unknown prefix — default to Receptionist (least privilege)
                    System.Diagnostics.Debug.WriteLine(
                        $"[UserRepository] Unknown role code '{code}'. Defaulting to Receptionist.");
                    return UserRole.Receptionist;
            }
        }
    }

    // ────────────────────────────────────────────────────────────────────
    //  Result object (simple value type — no exceptions thrown to callers)
    // ────────────────────────────────────────────────────────────────────

    /// <summary>
    /// Encapsulates the outcome of a login validation call.
    /// </summary>
    public sealed class LoginResult
    {
        public bool   IsSuccess    { get; private set; }
        public string ErrorMessage { get; private set; }
        public User   User         { get; private set; }

        private LoginResult() { }

        public static LoginResult Success(User user)
            => new LoginResult { IsSuccess = true, User = user };

        public static LoginResult Fail(string message)
            => new LoginResult { IsSuccess = false, ErrorMessage = message };
    }
}
