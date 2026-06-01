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
        private ErrorProvider errorProvider = new ErrorProvider();

        private string _patientId;

        public AddPatientFormUI(string patientId = null)
        {
            _patientId = patientId;
            InitializeComponent();
            SetupLogic();
        }

        private void SetupLogic()
        {
            this.Load += (s, e) => {
                if (!string.IsNullOrEmpty(_patientId))
                {
                    var p = DataStore.Patients.FirstOrDefault(x => x.PatientId == _patientId);
                    if (p != null)
                    {
                        lblTitle.Text = $"تعديل بيانات مريض - {p.FileNumber}";
                        txtName.Text = p.FullName;
                        txtPhone.Text = p.Phone;
                        cmbGender.Text = p.Gender;
                        txtAge.Text = p.Age.ToString();
                        txtAddress.Text = p.Address;
                        btnSave.Text = "حفظ التعديلات";
                    }
                }
                else
                {
                    lblTitle.Text = $"إضافة مريض جديد - PAT-{DataStore.Patients.Count + 1001}";
                }
            };

            txtName.KeyPress += (s, e) => {
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

            txtPhone.KeyPress += (s, e) => {
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

            txtAge.KeyPress += (s, e) => {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            };

            btnSave.Click += (s, e) => {
                if (!ValidateForm())
                {
                    MessageBox.Show("الرجاء تصحيح الأخطاء في النموذج", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(_patientId))
                {
                    Patient p = new Patient();
                    p.PatientId = DataStore.NextPatientId();
                    p.FileNumber = "PAT-" + (DataStore.Patients.Count + 1001);
                    p.FullName = txtName.Text;
                    p.Phone = txtPhone.Text;
                    p.Gender = cmbGender.Text;
                    p.Age = int.Parse(txtAge.Text);
                    p.Address = txtAddress.Text;
                    DataStore.Patients.Add(p);
                }
                else
                {
                    Patient p = DataStore.Patients.FirstOrDefault(x => x.PatientId == _patientId);
                    if (p != null)
                    {
                        p.FullName = txtName.Text;
                        p.Phone = txtPhone.Text;
                        p.Gender = cmbGender.Text;
                        p.Age = int.Parse(txtAge.Text);
                        p.Address = txtAddress.Text;
                    }
                }

                MessageBox.Show("تم الحفظ بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            };
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

            if (string.IsNullOrWhiteSpace(txtAge.Text))
            {
                errorProvider.SetError(txtAge, "العمر مطلوب");
                isValid = false;
            }
            else errorProvider.SetError(txtAge, "");

            return isValid;
        }
    }
}
