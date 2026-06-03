using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using DentalClinicProject.Data;
using DentalClinicProject.data;

namespace DentalClinicProject.UI
{
    public partial class AddStaffFormUI : System.Windows.Forms.Form
    {
        // ── صف واحد في جدول الدوام ───────────────────────────────────────
        private class ScheduleRow
        {
            public string   DayAr     { get; set; }
            public string   DayEn     { get; set; }
            public CheckBox Chk       { get; set; }
            public ComboBox CmbPeriod { get; set; }  // صباحية / مسائية
        }

        private readonly List<ScheduleRow> _scheduleRows = new List<ScheduleRow>();

        // ── التخصصات ─────────────────────────────────────────────────────
        private static readonly string[] DentalSpecialties =
        {
            "طبيب أسنان عام",
            "أخصائي تقويم الأسنان",
            "أخصائي أمراض اللثة",
            "أخصائي علاج جذور الأسنان",
            "أخصائي الأسنان التعويضية",
            "جراح الفم والفكين",
            "أخصائي طب أسنان الأطفال",
            "أخصائي تشخيص الفم"
        };

        private static readonly string[] ClinicRooms =
        {
            "عيادة 201", "عيادة 202", "عيادة 203", "عيادة 204", "عيادة 205", "عيادة 206"
        };

        public AddStaffFormUI()
        {
            InitializeComponent();
            BuildScheduleRows();
            WireEvents();
        }

        // ════════════════════════════════════════════════════════════════
        //  بناء جدول الدوام الأسبوعي
        // ════════════════════════════════════════════════════════════════
        private void BuildScheduleRows()
        {
            var days = new[]
            {
                new { Ar = "الأحد",    En = "Sunday"    },
                new { Ar = "الإثنين",  En = "Monday"    },
                new { Ar = "الثلاثاء", En = "Tuesday"   },
                new { Ar = "الأربعاء", En = "Wednesday" },
                new { Ar = "الخميس",  En = "Thursday"  },
                new { Ar = "الجمعة",  En = "Friday"    },
                new { Ar = "السبت",   En = "Saturday"  },
            };

            // ── عنوان الأعمدة ─────────────────────────────────────────
            var header = new TableLayoutPanel
            {
                Dock        = DockStyle.Top,
                ColumnCount = 3,
                Height      = 30,
                RightToLeft = RightToLeft.Yes
            };
            header.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110));
            header.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180));
            header.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            header.Controls.Add(MakeHeaderLabel("اليوم"),               0, 0);
            header.Controls.Add(MakeHeaderLabel("الفترة"),              1, 0);

            // ── صفوف الأيام ──────────────────────────────────────────
            var tlp = new TableLayoutPanel
            {
                Dock        = DockStyle.Fill,
                ColumnCount = 3,
                RowCount    = days.Length,
                RightToLeft = RightToLeft.Yes
            };
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110));
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180));
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));

            for (int i = 0; i < days.Length; i++)
            {
                tlp.RowStyles.Add(new RowStyle(SizeType.Absolute, 34));

                var chk = new CheckBox
                {
                    Text      = days[i].Ar,
                    Font      = new Font("Segoe UI", 9.5f),
                    Dock      = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleRight
                };

                var cmbPeriod = new ComboBox
                {
                    DropDownStyle = ComboBoxStyle.DropDownList,
                    Font          = new Font("Segoe UI", 9.5f),
                    Dock          = DockStyle.Fill,
                    Enabled       = false,
                    Margin        = new Padding(0, 2, 4, 2)
                };
                cmbPeriod.Items.Add("صباحية  (09:00 - 15:00)");
                cmbPeriod.Items.Add("مسائية  (15:00 - 21:00)");
                cmbPeriod.SelectedIndex = 0;

                chk.CheckedChanged += (s, e) => cmbPeriod.Enabled = chk.Checked;

                tlp.Controls.Add(chk,       0, i);
                tlp.Controls.Add(cmbPeriod, 1, i);
                tlp.Controls.Add(new Label { Dock = DockStyle.Fill }, 2, i);

                _scheduleRows.Add(new ScheduleRow
                {
                    DayAr     = days[i].Ar,
                    DayEn     = days[i].En,
                    Chk       = chk,
                    CmbPeriod = cmbPeriod
                });
            }

            panelScheduleContent.Controls.Add(tlp);
            panelScheduleContent.Controls.Add(header);
        }

        private static Label MakeHeaderLabel(string text) => new Label
        {
            Text      = text,
            Font      = new Font("Segoe UI", 9f, FontStyle.Bold),
            Dock      = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleCenter,
            ForeColor = Color.FromArgb(0, 75, 155),
            BackColor = Color.FromArgb(235, 241, 251)
        };

        // ════════════════════════════════════════════════════════════════
        //  ربط الأحداث
        // ════════════════════════════════════════════════════════════════
        private void WireEvents()
        {
            this.Load += OnLoad;
            cmbRole.SelectedIndexChanged += OnRoleChanged;
            btnSave.Click   += OnSave;
            btnCancel.Click += (s, e) => { DialogResult = DialogResult.Cancel; Close(); };

            // ── Validation: الهاتف 10 أرقام فقط ─────────────────────────
            txtPhone.KeyPress += (s, e) =>
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                    e.Handled = true;
                if (char.IsDigit(e.KeyChar) && txtPhone.Text.Length >= 10)
                    e.Handled = true;
            };
            txtPhone.Leave += (s, e) =>
            {
                if (!string.IsNullOrWhiteSpace(txtPhone.Text) && txtPhone.Text.Length != 10)
                {
                    lblPhoneError.Visible = true;
                    txtPhone.BackColor    = Color.FromArgb(255, 235, 235);
                }
                else
                {
                    lblPhoneError.Visible = false;
                    txtPhone.BackColor    = SystemColors.Window;
                }
            };

            // ── Validation: سنوات الخبرة أرقام فقط ──────────────────────
            txtExperience.KeyPress += (s, e) =>
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                    e.Handled = true;
            };

            // ── Validation: نسبة الطبيب ≤ 100 ───────────────────────────
            txtPercentage.KeyPress += (s, e) =>
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
                    e.Handled = true;
            };
            txtPercentage.Leave += (s, e) =>
            {
                decimal val;
                if (decimal.TryParse(txtPercentage.Text, out val) && val > 100)
                {
                    lblPercentageError.Visible = true;
                    txtPercentage.BackColor    = Color.FromArgb(255, 235, 235);
                }
                else
                {
                    lblPercentageError.Visible = false;
                    txtPercentage.BackColor    = SystemColors.Window;
                }
            };
        }

        private void OnLoad(object sender, EventArgs e)
        {
            // ── الأدوار ──────────────────────────────────────────────────
            cmbRole.Items.AddRange(new object[] { "مدير نظام", "استقبال", "طبيب" });
            cmbRole.SelectedIndex = 1;

            // ── الجنس ───────────────────────────────────────────────────
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.SelectedIndex = 0;

            // ── تاريخ التعيين = اليوم ────────────────────────────────────
            lblHireDateValue.Text = GetTodayDate();

            // ── التخصصات ────────────────────────────────────────────────
            cmbSpeciality.Items.AddRange(DentalSpecialties);
            cmbSpeciality.SelectedIndex = 0;

            // ── أرقام الغرف ─────────────────────────────────────────────
            cmbRoom.Items.AddRange(ClinicRooms);
            cmbRoom.SelectedIndex = 0;

            // إخفاء حقول الطبيب
            panelDoctorFields.Visible = false;
            panelScheduleArea.Visible = false;
        }

        /// <summary>يعيد تاريخ اليوم بصيغة عربية مناسبة.</summary>
        private static string GetTodayDate()
        {
            return DateTime.Today.ToString("yyyy/MM/dd");
        }

        private void OnRoleChanged(object sender, EventArgs e)
        {
            bool isDoctor = cmbRole.Text == "طبيب";
            panelDoctorFields.Visible = isDoctor;
            panelScheduleArea.Visible = isDoctor;
            this.Height = isDoctor ? 730 : 480;
        }

        // ════════════════════════════════════════════════════════════════
        //  الحفظ في قاعدة البيانات
        // ════════════════════════════════════════════════════════════════
        private void OnSave(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            Cursor          = Cursors.WaitCursor;
            btnSave.Enabled = false;

            try
            {
                using (var conn = DbHelper.GetConnection())
                {
                    string prefix = cmbRole.Text == "مدير نظام" ? "ADM"
                                  : cmbRole.Text == "طبيب"      ? "DOC"
                                  :                               "REC";
                    string userId   = GenerateUserId(conn, prefix);
                    string passHash = HashPassword(txtPassword.Text);

                    // ── إدخال المستخدم ───────────────────────────────────
                    const string sqlUser = @"
                        INSERT INTO dbo.Users
                            (UserId, FullName, UserName, PasswordHash, IsActive, Phone, Gender, HireDate)
                        VALUES
                            (@UserId, @FullName, @UserName, @PasswordHash, 1,
                             @Phone, @Gender, @HireDate)";

                    using (var cmd = new SqlCommand(sqlUser, conn))
                    {
                        cmd.Parameters.Add(new SqlParameter("@UserId",       SqlDbType.NVarChar, 50)  { Value = userId });
                        cmd.Parameters.Add(new SqlParameter("@FullName",     SqlDbType.NVarChar, 100) { Value = txtFullName.Text.Trim() });
                        cmd.Parameters.Add(new SqlParameter("@UserName",     SqlDbType.NVarChar, 50)  { Value = txtUsername.Text.Trim() });
                        cmd.Parameters.Add(new SqlParameter("@PasswordHash", SqlDbType.NVarChar, 255) { Value = passHash });
                        cmd.Parameters.Add(new SqlParameter("@Phone",        SqlDbType.NVarChar, 20)  { Value = string.IsNullOrWhiteSpace(txtPhone.Text) ? (object)DBNull.Value : txtPhone.Text.Trim() });
                        cmd.Parameters.Add(new SqlParameter("@Gender",       SqlDbType.NVarChar, 10)  { Value = cmbGender.Text });
                        cmd.Parameters.Add(new SqlParameter("@HireDate",     SqlDbType.DateTime)      { Value = DateTime.Today });
                        cmd.ExecuteNonQuery();
                    }

                    // ── إذا طبيب: Dentist + DentistSchedule ─────────────
                    if (cmbRole.Text == "طبيب")
                    {
                        // توليد ID عشوائي فريد للطبيب DOC_1234
                        string dentistId = DataStore.GenerateUniqueRandomId("DOC", "dbo.Dentist", "DentistId");

                        const string sqlDentist = @"
                            INSERT INTO dbo.Dentist
                                (DentistId, UserId, Speciality, RoomNumber, DoctorPercentage, LicenseNumber, YearsExperience)
                            VALUES
                                (@DentistId, @UserId, @Speciality, @RoomNumber, @Percentage, @License, @Experience)";

                        using (var cmd = new SqlCommand(sqlDentist, conn))
                        {
                            cmd.Parameters.Add(new SqlParameter("@DentistId",  SqlDbType.NVarChar, 50)  { Value = dentistId });
                            cmd.Parameters.Add(new SqlParameter("@UserId",     SqlDbType.NVarChar, 50)  { Value = userId });
                            cmd.Parameters.Add(new SqlParameter("@Speciality", SqlDbType.NVarChar, 100) { Value = cmbSpeciality.Text });
                            cmd.Parameters.Add(new SqlParameter("@RoomNumber", SqlDbType.NVarChar, 20)  { Value = cmbRoom.Text });

                            decimal pct = 0;
                            decimal.TryParse(txtPercentage.Text, out pct);
                            cmd.Parameters.Add(new SqlParameter("@Percentage", SqlDbType.Decimal) { Value = pct, Precision = 5, Scale = 2 });

                            cmd.Parameters.Add(new SqlParameter("@License",    SqlDbType.NVarChar, 50) { Value = string.IsNullOrWhiteSpace(txtLicense.Text) ? (object)DBNull.Value : txtLicense.Text.Trim() });

                            int yrs = 0;
                            int.TryParse(txtExperience.Text, out yrs);
                            cmd.Parameters.Add(new SqlParameter("@Experience", SqlDbType.Int) { Value = yrs > 0 ? (object)yrs : DBNull.Value });

                            cmd.ExecuteNonQuery();
                        }

                        // ── الجدول الزمني ─────────────────────────────────
                        const string sqlSched = @"
                            INSERT INTO dbo.DentistSchedule (DentistId, DayOfWeek, StartTime, EndTime)
                            VALUES (@DentistId, @Day, @Start, @End)";

                        foreach (var row in _scheduleRows)
                        {
                            if (!row.Chk.Checked) continue;

                            // صباحية: 09:00 → 15:00  |  مسائية: 15:00 → 21:00
                            TimeSpan start, end;
                            if (row.CmbPeriod.SelectedIndex == 0)
                            { start = new TimeSpan(9,  0, 0); end = new TimeSpan(15, 0, 0); }
                            else
                            { start = new TimeSpan(15, 0, 0); end = new TimeSpan(21, 0, 0); }

                            using (var cmd = new SqlCommand(sqlSched, conn))
                            {
                                cmd.Parameters.Add(new SqlParameter("@DentistId", SqlDbType.NVarChar, 50) { Value = dentistId });
                                cmd.Parameters.Add(new SqlParameter("@Day",       SqlDbType.VarChar, 20) { Value = row.DayEn });
                                cmd.Parameters.Add(new SqlParameter("@Start",     SqlDbType.Time)        { Value = start });
                                cmd.Parameters.Add(new SqlParameter("@End",       SqlDbType.Time)        { Value = end });
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                }

                MessageBox.Show(
                    "تمت إضافة الموظف بنجاح! ✓",
                    "تم الحفظ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (SqlException ex) when (ex.Number == 2627 || ex.Number == 2601)
            {
                string msg = "اسم المستخدم أو رقم الهاتف مسجّل مسبقاً، يرجى التحقق من البيانات.";
                if (ex.Message.Contains("UserName") || ex.Message.Contains("UserName"))
                    msg = "اسم المستخدم مسجّل مسبقاً، يرجى اختيار اسم آخر.";
                else if (ex.Message.Contains("Phone") || ex.Message.Contains("Phone"))
                    msg = "رقم الهاتف مسجّل مسبقاً، يرجى استخدام رقم آخر.";

                MessageBox.Show(
                    msg,
                    "خطأ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "حدث خطأ أثناء الحفظ:\n" + ex.Message,
                    "خطأ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
            }
            finally
            {
                Cursor          = Cursors.Default;
                btnSave.Enabled = true;
            }
        }

        // ════════════════════════════════════════════════════════════════
        //  التحقق من صحة المدخلات
        // ════════════════════════════════════════════════════════════════
        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            { ShowError("الاسم الكامل مطلوب."); return false; }

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            { ShowError("اسم المستخدم مطلوب."); return false; }

            // التحقق من تكرار اسم المستخدم في قاعدة البيانات
            if (IsUsernameExists(txtUsername.Text))
            { ShowError("اسم المستخدم مسجّل مسبقاً، يرجى اختيار اسم آخر."); txtUsername.Focus(); return false; }

            if (string.IsNullOrWhiteSpace(txtPassword.Text) || txtPassword.Text.Length < 4)
            { ShowError("كلمة المرور يجب أن تكون 4 أحرف على الأقل."); return false; }

            if (cmbRole.SelectedIndex == -1)
            { ShowError("يرجى اختيار الدور الوظيفي."); return false; }

            // ── الهاتف: 10 أرقام بالضبط إذا أُدخل ───────────────────────
            if (!string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                if (txtPhone.Text.Length != 10)
                { ShowError("رقم الهاتف يجب أن يتكون من 10 أرقام بالضبط."); txtPhone.Focus(); return false; }

                // التحقق من تكرار رقم الهاتف في قاعدة البيانات
                if (IsPhoneExists(txtPhone.Text))
                { ShowError("رقم الهاتف مسجّل مسبقاً، يرجى استخدام رقم آخر."); txtPhone.Focus(); return false; }
            }

            if (cmbRole.Text == "طبيب")
            {
                if (cmbSpeciality.SelectedIndex == -1)
                { ShowError("يرجى اختيار تخصص الطبيب."); return false; }

                decimal pct;
                if (decimal.TryParse(txtPercentage.Text, out pct) && pct > 100)
                { ShowError("نسبة الطبيب لا يمكن أن تتجاوز 100%."); txtPercentage.Focus(); return false; }

                int yrs;
                if (!string.IsNullOrWhiteSpace(txtExperience.Text) && !int.TryParse(txtExperience.Text, out yrs))
                { ShowError("سنوات الخبرة يجب أن تكون رقماً صحيحاً."); txtExperience.Focus(); return false; }

                bool anyDaySelected = false;
                foreach (var r in _scheduleRows)
                    if (r.Chk.Checked) { anyDaySelected = true; break; }

                if (!anyDaySelected)
                { ShowError("يرجى اختيار يوم عمل واحد على الأقل للطبيب."); return false; }

                // ── التحقق من تعارض حجز الغرفة مع أطباء آخرين ──
                foreach (var r in _scheduleRows)
                {
                    if (r.Chk.Checked)
                    {
                        TimeSpan start = r.CmbPeriod.SelectedIndex == 0 ? new TimeSpan(9, 0, 0) : new TimeSpan(15, 0, 0);
                        if (IsRoomConflict(cmbRoom.Text, r.DayEn, start))
                        {
                            ShowError($"غرفة العيادة ({cmbRoom.Text}) محجوزة بالفعل من قبل طبيب آخر يوم ({r.DayAr}) في الفترة المحددة.");
                            return false;
                        }
                    }
                }
            }

            return true;
        }

        private static void ShowError(string msg)
            => MessageBox.Show(msg, "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                               MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);

        private bool IsRoomConflict(string roomNumber, string dayEn, TimeSpan startTime)
        {
            const string sql = @"
                SELECT COUNT(*)
                FROM dbo.Dentist d
                INNER JOIN dbo.DentistSchedule ds ON d.DentistId = ds.DentistId
                WHERE d.RoomNumber = @RoomNumber
                  AND ds.DayOfWeek = @Day
                  AND ds.StartTime = @Start";
            try
            {
                using (var conn = DbHelper.GetConnection())
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@RoomNumber", SqlDbType.NVarChar, 20) { Value = roomNumber });
                    cmd.Parameters.Add(new SqlParameter("@Day", SqlDbType.VarChar, 20) { Value = dayEn });
                    cmd.Parameters.Add(new SqlParameter("@Start", SqlDbType.Time) { Value = startTime });

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
            catch
            {
                return false;
            }
        }

        // ════════════════════════════════════════════════════════════════
        //  التحقق من التكرار في قاعدة البيانات
        // ════════════════════════════════════════════════════════════════
        private bool IsUsernameExists(string username)
        {
            const string sql = "SELECT COUNT(*) FROM dbo.Users WHERE UserName = @UserName";
            try
            {
                using (var conn = DbHelper.GetConnection())
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@UserName", SqlDbType.NVarChar, 50) { Value = username.Trim() });
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
            catch
            {
                return false;
            }
        }

        private bool IsPhoneExists(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone)) return false;
            const string sql = "SELECT COUNT(*) FROM dbo.Users WHERE Phone = @Phone";
            try
            {
                using (var conn = DbHelper.GetConnection())
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@Phone", SqlDbType.NVarChar, 20) { Value = phone.Trim() });
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
            catch
            {
                return false;
            }
        }

        // ════════════════════════════════════════════════════════════════
        //  توليد UserId
        // ════════════════════════════════════════════════════════════════
        private static string GenerateUserId(SqlConnection conn, string prefix)
        {
            string year    = DateTime.Now.Year.ToString();
            string pattern = prefix + "_" + year + "_%";

            const string sql = @"
                SELECT MAX(CAST(SUBSTRING(UserId, LEN(@Prefix) + LEN(@Year) + 3, 10) AS INT))
                FROM dbo.Users
                WHERE UserId LIKE @Pattern";

            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add(new SqlParameter("@Prefix",  prefix));
                cmd.Parameters.Add(new SqlParameter("@Year",    year));
                cmd.Parameters.Add(new SqlParameter("@Pattern", pattern));

                var result = cmd.ExecuteScalar();
                int seq = (result == DBNull.Value || result == null) ? 0 : Convert.ToInt32(result);
                return string.Format("{0}_{1}_{2:D3}", prefix, year, seq + 1);
            }
        }

        private static string HashPassword(string plain)
        {
            using (var sha = SHA256.Create())
                return Convert.ToBase64String(sha.ComputeHash(Encoding.UTF8.GetBytes(plain)));
        }
    }
}
