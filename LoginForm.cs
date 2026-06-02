using DentalClinicProject.Data;
using DentalClinicProject.data;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DentalClinicProject
{
    /// <summary>
    /// نموذج تسجيل الدخول — يعمل بطريقتين:
    ///
    ///   1) SQL Server (الوضع الأساسي):
    ///      إذا كانت قاعدة البيانات متاحة، يتحقق من المستخدم عبر ADO.NET
    ///      مع SqlParameter لمنع SQL Injection، ويتحقق من IsActive،
    ///      ويستخرج الدور من أول 3 حروف في UserId.
    ///
    ///   2) DataStore في الذاكرة (وضع احتياطي):
    ///      إذا فشل الاتصال بـ SQL Server (قاعدة البيانات غير جاهزة بعد)،
    ///      يرجع تلقائياً للمستخدمين المحفوظين في DataStore —
    ///      وهذا يتيح لـ "ريم" وبقية المستخدمين التجريبيين الدخول فوراً.
    /// </summary>
    public partial class LoginForm : Form
    {
        // هل الاتصال بـ SQL Server نجح أم اشتغلنا من الذاكرة؟
        private bool _usingFallback = false;

        public LoginForm()
        {
            InitializeComponent();
        }

        // ── Form Load ────────────────────────────────────────────────────
        private void LoginForm_Load(object sender, EventArgs e)
        {
            LoadUsernames();
            cmbUsername.Focus();
        }

        /// <summary>
        /// يحاول يجلب أسماء المستخدمين من SQL Server أولاً.
        /// إذا فشل الاتصال يرجع للـ DataStore في الذاكرة.
        /// </summary>
        private void LoadUsernames()
        {
            cmbUsername.Items.Clear();
            _usingFallback = false;

            // ── المحاولة الأولى: SQL Server ──────────────────────────────
            try
            {
                const string sql = "SELECT UserName FROM Users WHERE IsActive = 1 ORDER BY UserName";
                using (var conn = DbHelper.GetConnection())
                using (var cmd  = new System.Data.SqlClient.SqlCommand(sql, conn))
                using (var rdr  = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                        cmbUsername.Items.Add(rdr["UserName"].ToString());
                }

                // نجح — نستخدم SQL
                return;
            }
            catch
            {
                // SQL Server غير متاح — ننتقل للوضع الاحتياطي
                _usingFallback = true;
            }

            // ── الوضع الاحتياطي: DataStore في الذاكرة ───────────────────
            // يشمل "ريم" (Admin) و"نيروز" (Receptionist) و"د. أحمد علي" (Doctor)
            foreach (var user in DataStore.Users.Where(u => u.IsActive))
                cmbUsername.Items.Add(user.Username);
        }

        // ── Sign-In Button ───────────────────────────────────────────────
        private void btnSighnIN_Click(object sender, EventArgs e)
        {
            // ── 1. التحقق من الإدخال ─────────────────────────────────────
            string username = cmbUsername.Text?.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username))
            {
                ShowValidationHint(lblName, "* الرجاء اختيار اسم المستخدم");
                cmbUsername.Focus();
                return;
            }
            lblName.Visible = false;

            if (string.IsNullOrEmpty(password))
            {
                ShowValidationHint(lblPass, "* الرجاء إدخال كلمة المرور");
                txtPassword.Focus();
                return;
            }
            lblPass.Visible = false;

            Cursor             = Cursors.WaitCursor;
            btnSighnIN.Enabled = false;

            try
            {
                if (_usingFallback)
                    LoginWithDataStore(username, password);   // ② وضع احتياطي
                else
                    LoginWithSqlServer(username, password);   // ① SQL Server
            }
            finally
            {
                Cursor             = Cursors.Default;
                btnSighnIN.Enabled = true;
            }
        }

        // ────────────────────────────────────────────────────────────────
        //  ① تسجيل دخول عبر SQL Server
        // ────────────────────────────────────────────────────────────────
        private void LoginWithSqlServer(string username, string password)
        {
            LoginResult result = UserRepository.ValidateLogin(username, password);

            if (!result.IsSuccess)
            {
                MessageBox.Show(result.ErrorMessage, "تنبيه",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataStore.CurrentUser = result.User;
            NavigateToShell();
        }

        // ────────────────────────────────────────────────────────────────
        //  ② تسجيل دخول من الذاكرة (DataStore) — وضع احتياطي
        // ────────────────────────────────────────────────────────────────
        private void LoginWithDataStore(string username, string password)
        {
            // نشفر كلمة المرور بنفس طريقة DataStore.HashPassword
            string hashedInput = DataStore.HashPassword(password);

            var user = DataStore.Users
                .FirstOrDefault(u => u.Username == username
                                  && u.PasswordHash == hashedInput);

            if (user == null)
            {
                MessageBox.Show("اسم المستخدم أو كلمة المرور غير صحيحة.",
                                "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!user.IsActive)
            {
                MessageBox.Show("هذا الحساب موقوف. يرجى التواصل مع المسؤول.",
                                "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataStore.CurrentUser = user;
            NavigateToShell();
        }

        // ────────────────────────────────────────────────────────────────
        //  التنقل بعد نجاح تسجيل الدخول
        // ────────────────────────────────────────────────────────────────

        /// <summary>
        /// يُعيد DialogResult.OK إلى Program.cs الذي يفتح MainShellFormUI.
        /// الصدَفة الرئيسية تعرض القوائم حسب الدور تلقائياً (Admin / Doctor / Receptionist).
        /// </summary>
        private void NavigateToShell()
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // ────────────────────────────────────────────────────────────────
        //  مساعدات UI
        // ────────────────────────────────────────────────────────────────
        private static void ShowValidationHint(Label label, string message)
        {
            label.Text    = message;
            label.Visible = true;
        }
    }
}
