using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DentalClinicProject.classes;
using DentalClinicProject.data;
using DentalClinicProject.Data;

namespace DentalClinicProject.UI
{
    public partial class AddPatientFormUI : System.Windows.Forms.Form
    {
        private readonly ErrorProvider errorProvider = new ErrorProvider();
        private readonly string _patientId;
        private string _lastSavedPatientId;

        public AddPatientFormUI(string patientId = null)
        {
            _patientId = patientId;
            InitializeComponent();
            SetupLogic();
        }

        private void SetupLogic()
        {
            bool isNewPatient = string.IsNullOrEmpty(_patientId);
            
            // إلغاء زر الحفظ وجعل زر حجز الموعد هو المتاح دائماً كما هو مطلوب
            btnBookAppointment.Visible = true;
            btnSave.Visible = false;

            this.Load += (s, e) =>
            {
                if (!isNewPatient)
                {
                    var p = DataStore.Patients.FirstOrDefault(x => x.PatientId == _patientId);
                    if (p != null)
                    {
                        lblTitle.Text = $"تعديل بيانات مريض - {p.PatientId}";
                        txtName.Text = p.FullName;
                        txtPhone.Text = p.Phone;
                        cmbGender.Text = p.Gender == "Female" ? "أنثى" : "ذكر";
                        txtAge.Text = p.Age > 0 ? p.Age.ToString() : "";
                        txtAddress.Text = p.Address;
                    }
                }
                else
                {
                    lblTitle.Text = "إضافة مريض جديد";
                }
            };

            // ── Validation: الاسم الكامل حروف فقط ─────────────────────────
            txtName.KeyPress += (s, e) =>
            {
                // قبول الحروف العربية والإنجليزية والمسافة ومفاتيح التحكم (مثل Backspace)
                if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
                {
                    e.Handled = true;
                    errorProvider.SetError(txtName, "الاسم يجب أن يحتوي على حروف فقط");
                }
                else
                {
                    errorProvider.SetError(txtName, "");
                }
            };

            // ── Validation: رقم الهاتف أرقام فقط و 10 أرقام ─────────────────
            txtPhone.KeyPress += (s, e) =>
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                    errorProvider.SetError(txtPhone, "يجب إدخال أرقام فقط");
                }
                else if (char.IsDigit(e.KeyChar) && txtPhone.Text.Length >= 10)
                {
                    e.Handled = true; // منع إدخال أكثر من 10 أرقام
                }
                else
                {
                    errorProvider.SetError(txtPhone, "");
                }
            };

            // ── Validation: العمر أرقام فقط ورقمين فقط ────────────────────
            txtAge.KeyPress += (s, e) =>
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
                else if (char.IsDigit(e.KeyChar) && txtAge.Text.Length >= 2)
                {
                    e.Handled = true; // منع إدخال أكثر من خانتين
                }
            };

            // ── حجز موعد (يقوم بحفظ المريض أولاً ثم فتح شاشة المواعيد معبأة تلقائياً)
            btnBookAppointment.Click += (s, e) =>
            {
                if (!TrySavePatient(out string savedPatientId))
                    return;

                MessageBox.Show("تم حفظ بيانات المريض بنجاح ✓", "تم الحفظ", 
                                MessageBoxButtons.OK, MessageBoxIcon.Information,
                                MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);

                using (var apptForm = new AddAppointmentFormUI(savedPatientId))
                {
                    apptForm.ShowDialog(this);
                }

                DialogResult = DialogResult.OK;
                Close();
            };
        }

        private bool TrySavePatient(out string patientId)
        {
            patientId = null;

            if (!ValidateForm())
            {
                MessageBox.Show("الرجاء تصحيح الأخطاء في النموذج.", "تنبيه",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning,
                                MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                return false;
            }

            int age = Convert.ToInt32(txtAge.Text.Trim());

            if (string.IsNullOrEmpty(_patientId))
            {
                // توليد ID عشوائي فريد للمريض على صيغة PAT_1234
                patientId = DataStore.GenerateUniqueRandomId("PAT", "dbo.Patients", "PatientId");

                var p = new Patient
                {
                    PatientId = patientId,
                    FileNumber = patientId,
                    FullName = txtName.Text.Trim(),
                    Phone = txtPhone.Text.Trim(),
                    Gender = cmbGender.Text == "أنثى" ? "Female" : "Male",
                    Age = age,
                    Address = txtAddress.Text?.Trim() ?? ""
                };

                // تقسيم الاسم لإدخاله في الأعمدة المنفصلة بالقاعدة
                string firstName, middleName, lastName;
                DataStore.SplitFullName(p.FullName, out firstName, out middleName, out lastName);

                const string sql = @"
                    INSERT INTO dbo.Patients
                        (PatientId, FirstName, MiddleName, LastName, Age, Gender, RegistrationDate, PatientPhone)
                    VALUES
                        (@PatientId, @FirstName, @MiddleName, @LastName, @Age, @Gender, @RegDate, @Phone)";

                try
                {
                    using (var conn = DbHelper.GetConnection())
                    using (var cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.Add(new SqlParameter("@PatientId", SqlDbType.NVarChar, 50) { Value = p.PatientId });
                        cmd.Parameters.Add(new SqlParameter("@FirstName", SqlDbType.NVarChar, 50) { Value = firstName });
                        cmd.Parameters.Add(new SqlParameter("@MiddleName", SqlDbType.NVarChar, 50) { Value = string.IsNullOrEmpty(middleName) ? (object)DBNull.Value : middleName });
                        cmd.Parameters.Add(new SqlParameter("@LastName", SqlDbType.NVarChar, 50) { Value = lastName });
                        cmd.Parameters.Add(new SqlParameter("@Age", SqlDbType.Int) { Value = p.Age });
                        cmd.Parameters.Add(new SqlParameter("@Gender", SqlDbType.NVarChar, 10) { Value = p.Gender });
                        cmd.Parameters.Add(new SqlParameter("@RegDate", SqlDbType.Date) { Value = DateTime.Today });
                        cmd.Parameters.Add(new SqlParameter("@Phone", SqlDbType.VarChar, 15) { Value = p.Phone });
                        cmd.ExecuteNonQuery();
                    }

                    // تحديث القائمة المحلية لتجنب تعارض الكود
                    DataStore.Patients.Add(p);
                    _lastSavedPatientId = patientId;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("حدث خطأ أثناء حفظ المريض في قاعدة البيانات:\n" + ex.Message, "خطأ",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error,
                                    MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                    return false;
                }
            }
            else
            {
                // تعديل مريض موجود مسبقاً
                patientId = _patientId;
                var p = DataStore.Patients.FirstOrDefault(x => x.PatientId == _patientId);
                if (p == null) return false;

                p.FullName = txtName.Text.Trim();
                p.Phone = txtPhone.Text.Trim();
                p.Gender = cmbGender.Text == "أنثى" ? "Female" : "Male";
                p.Age = age;
                p.Address = txtAddress.Text?.Trim() ?? "";

                string firstName, middleName, lastName;
                DataStore.SplitFullName(p.FullName, out firstName, out middleName, out lastName);

                const string sql = @"
                    UPDATE dbo.Patients
                    SET FirstName = @FirstName,
                        MiddleName = @MiddleName,
                        LastName = @LastName,
                        Age = @Age,
                        Gender = @Gender,
                        PatientPhone = @Phone
                    WHERE PatientId = @PatientId";

                try
                {
                    using (var conn = DbHelper.GetConnection())
                    using (var cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.Add(new SqlParameter("@FirstName", SqlDbType.NVarChar, 50) { Value = firstName });
                        cmd.Parameters.Add(new SqlParameter("@MiddleName", SqlDbType.NVarChar, 50) { Value = string.IsNullOrEmpty(middleName) ? (object)DBNull.Value : middleName });
                        cmd.Parameters.Add(new SqlParameter("@LastName", SqlDbType.NVarChar, 50) { Value = lastName });
                        cmd.Parameters.Add(new SqlParameter("@Age", SqlDbType.Int) { Value = p.Age });
                        cmd.Parameters.Add(new SqlParameter("@Gender", SqlDbType.NVarChar, 10) { Value = p.Gender });
                        cmd.Parameters.Add(new SqlParameter("@Phone", SqlDbType.VarChar, 15) { Value = p.Phone });
                        cmd.Parameters.Add(new SqlParameter("@PatientId", SqlDbType.NVarChar, 50) { Value = patientId });
                        cmd.ExecuteNonQuery();
                    }
                    _lastSavedPatientId = patientId;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("حدث خطأ أثناء تعديل بيانات المريض في قاعدة البيانات:\n" + ex.Message, "خطأ",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error,
                                    MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                    return false;
                }
            }

            return true;
        }

        private bool ValidateForm()
        {
            bool isValid = true;

            // الاسم حروف ومسافات فقط
            if (string.IsNullOrWhiteSpace(txtName.Text) || !new Regex(@"^[a-zA-Z\s\u0600-\u06FF]+$").IsMatch(txtName.Text))
            {
                errorProvider.SetError(txtName, "الاسم يجب أن يحتوي على حروف فقط");
                isValid = false;
            }
            else errorProvider.SetError(txtName, "");

            // رقم الهاتف 10 أرقام بالضبط
            if (string.IsNullOrWhiteSpace(txtPhone.Text) || txtPhone.Text.Length != 10 || !new Regex(@"^\d{10}$").IsMatch(txtPhone.Text))
            {
                errorProvider.SetError(txtPhone, "رقم الهاتف يجب أن يتكون من 10 أرقام بالضبط");
                isValid = false;
            }
            else errorProvider.SetError(txtPhone, "");

            // الجنس
            if (cmbGender.SelectedIndex == -1)
            {
                errorProvider.SetError(cmbGender, "الرجاء اختيار الجنس");
                isValid = false;
            }
            else errorProvider.SetError(cmbGender, "");

            // العمر خانتين فقط
            int ageVal;
            if (string.IsNullOrWhiteSpace(txtAge.Text) || txtAge.Text.Length > 2 || !int.TryParse(txtAge.Text, out ageVal) || ageVal <= 0)
            {
                errorProvider.SetError(txtAge, "العمر يجب أن يكون بين 1 و 99");
                isValid = false;
            }
            else errorProvider.SetError(txtAge, "");

            // التحقق من تفرد رقم الهاتف في قاعدة البيانات لتجنب الازدواجية
            if (isValid)
            {
                if (IsPatientPhoneExists(txtPhone.Text, _patientId))
                {
                    errorProvider.SetError(txtPhone, "رقم الهاتف مسجّل مسبقاً لمريض آخر");
                    isValid = false;
                }
            }

            return isValid;
        }

        private bool IsPatientPhoneExists(string phone, string excludePatientId = null)
        {
            if (string.IsNullOrWhiteSpace(phone)) return false;
            const string sql = @"
                SELECT COUNT(*) FROM dbo.Patients 
                WHERE PatientPhone = @Phone AND (@ExcludeId IS NULL OR PatientId != @ExcludeId)";
            try
            {
                using (var conn = DbHelper.GetConnection())
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@Phone", SqlDbType.VarChar, 15) { Value = phone.Trim() });
                    cmd.Parameters.Add(new SqlParameter("@ExcludeId", SqlDbType.NVarChar, 50) { Value = string.IsNullOrEmpty(excludePatientId) ? (object)DBNull.Value : excludePatientId });
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
