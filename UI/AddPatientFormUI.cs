using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DentalClinicProject.classes;
using DentalClinicProject.data;

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
            btnBookAppointment.Visible = isNewPatient;

            this.Load += (s, e) =>
            {
                if (!isNewPatient)
                {
                    var p = DataStore.Patients.FirstOrDefault(x => x.PatientId == _patientId);
                    if (p != null)
                    {
                        lblTitle.Text = $"تعديل بيانات مريض - {p.FileNumber}";
                        txtName.Text = p.FullName;
                        txtPhone.Text = p.Phone;
                        cmbGender.Text = p.Gender;
                        txtAge.Text = p.Age > 0 ? p.Age.ToString() : "";
                        txtAddress.Text = p.Address;
                        btnSave.Text = "حفظ التعديلات";
                    }
                }
                else
                {
                    lblTitle.Text = $"إضافة مريض جديد - PAT-{DataStore.Patients.Count + 1001}";
                }
            };

            txtName.KeyPress += (s, e) =>
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
                {
                    if (!(e.KeyChar >= 0x0600 && e.KeyChar <= 0x06FF))
                    {
                        e.Handled = true;
                        errorProvider.SetError(txtName, "يجب إدخال حروف فقط");
                        return;
                    }
                }
                errorProvider.SetError(txtName, "");
            };

            txtPhone.KeyPress += (s, e) =>
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                    errorProvider.SetError(txtPhone, "يجب إدخال أرقام فقط");
                }
                else
                {
                    errorProvider.SetError(txtPhone, "");
                }
            };

            txtAge.KeyPress += (s, e) =>
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                    e.Handled = true;
            };

            btnSave.Click += (s, e) =>
            {
                if (!TrySavePatient(out _))
                    return;

                MessageBox.Show("تم الحفظ بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            };

            btnBookAppointment.Click += (s, e) =>
            {
                if (!TrySavePatient(out string savedPatientId))
                    return;

                MessageBox.Show("تم حفظ بيانات المريض بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                MessageBox.Show("الرجاء تصحيح الأخطاء في النموذج", "تنبيه",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!TryParseAge(txtAge.Text, out int age))
            {
                errorProvider.SetError(txtAge, "العمر يجب أن يكون رقماً بين 0 و 150");
                MessageBox.Show("الرجاء إدخال عمر صحيح (0–150)", "تنبيه",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(_patientId))
            {
                var p = new Patient
                {
                    PatientId = DataStore.NextPatientId(),
                    FileNumber = "PAT-" + (DataStore.Patients.Count + 1001),
                    FullName = txtName.Text.Trim(),
                    Phone = txtPhone.Text.Trim(),
                    Gender = cmbGender.Text,
                    Age = age,
                    Address = txtAddress.Text?.Trim() ?? ""
                };
                DataStore.Patients.Add(p);
                patientId = p.PatientId;
                _lastSavedPatientId = patientId;
            }
            else
            {
                var p = DataStore.Patients.FirstOrDefault(x => x.PatientId == _patientId);
                if (p == null)
                    return false;

                p.FullName = txtName.Text.Trim();
                p.Phone = txtPhone.Text.Trim();
                p.Gender = cmbGender.Text;
                p.Age = age;
                p.Address = txtAddress.Text?.Trim() ?? "";
                patientId = p.PatientId;
                _lastSavedPatientId = patientId;
            }

            return true;
        }

        private static bool TryParseAge(string text, out int age)
        {
            age = 0;
            if (string.IsNullOrWhiteSpace(text))
                return false;
            if (!int.TryParse(text.Trim(), out age))
                return false;
            return age >= 0 && age <= 150;
        }

        private bool ValidateForm()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtName.Text) || !new Regex(@"^[\p{L}\s]+$").IsMatch(txtName.Text))
            {
                errorProvider.SetError(txtName, "الاسم يجب أن يحتوي على حروف فقط");
                isValid = false;
            }
            else errorProvider.SetError(txtName, "");

            if (string.IsNullOrWhiteSpace(txtPhone.Text) || !new Regex(@"^\d+$").IsMatch(txtPhone.Text))
            {
                errorProvider.SetError(txtPhone, "رقم الهاتف يجب أن يحتوي على أرقام فقط");
                isValid = false;
            }
            else errorProvider.SetError(txtPhone, "");

            if (cmbGender.SelectedIndex == -1)
            {
                errorProvider.SetError(cmbGender, "الرجاء اختيار الجنس");
                isValid = false;
            }
            else errorProvider.SetError(cmbGender, "");

            if (!TryParseAge(txtAge.Text, out _))
            {
                errorProvider.SetError(txtAge, "أدخل عمراً صحيحاً (0–150)");
                isValid = false;
            }
            else errorProvider.SetError(txtAge, "");

            return isValid;
        }
    }
}
