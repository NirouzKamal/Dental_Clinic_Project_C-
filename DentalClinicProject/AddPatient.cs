using DentalClinicProject.classes;
using DentalClinicProject.data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Text.RegularExpressions;

namespace DentalClinicProject
{
    public partial class AddPatient : Form
    {
        private ErrorProvider errorProvider1 = new ErrorProvider();
        public AddPatient()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void MakePanelRounded(Panel panel, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddArc(new Rectangle(panel.Width - radius, 0, radius, radius), 270, 90);
            path.AddArc(new Rectangle(panel.Width - radius, panel.Height - radius, radius, radius), 0, 90);
            path.AddArc(new Rectangle(0, panel.Height - radius, radius, radius), 90, 90);
            path.CloseFigure();
            panel.Region = new Region(path);
        }
        private void SetRoundedButton(Button btn, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            path.StartFigure();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(btn.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(btn.Width - radius, btn.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, btn.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            btn.Region = new Region(path);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddPatient_Load(object sender, EventArgs e)
        {
            cmbGender.Items.Add("ذكر");
            cmbGender.Items.Add("انتى");
            MakePanelRounded(panel2, 80);
            MakePanelRounded(panel1, 80);

            SetRoundedButton(NewBtn, 30);
            SetRoundedButton(saveAndCloseBtn, 30);

            label4.Text = DateTime.Now.ToString(
                "dddd ، dd MMMM yyyy",
                new System.Globalization.CultureInfo("ar-LY"));

            GenerateFileNumber();
            cmbGender.Items.Add("ذكر");
            cmbGender.Items.Add("أنثى");

            MakePanelRounded(panel2, 80);
            MakePanelRounded(panel1, 80);

            SetRoundedButton(NewBtn, 30);
            SetRoundedButton(saveAndCloseBtn, 30);

            label4.Text = DateTime.Now.ToString(
                "dddd ، dd MMMM yyyy",
                new System.Globalization.CultureInfo("ar-LY"));

            GenerateFileNumber();

            // ✅ ربط أحداث الـ KeyPress للتحقق المباشر
            fullNameTxt.KeyPress += fullNameTxt_KeyPress;
            NumPhoneTxt.KeyPress += NumPhoneTxt_KeyPress;

        }
        private void GenerateFileNumber()

        {
            TextFileNum.Text = "PAT-" + (DataStore.Patients.Count + 1001);
        }

        private void saveAndCloseBtn_Click(object sender, EventArgs e)
        {
            // ✅ التحقق من صحة البيانات قبل الحفظ
            if (!ValidateForm())
            {
                MessageBox.Show("الرجاء تصحيح الأخطاء في النموذج", "تنبيه",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Patient p = new Patient();
            p.PatientId = DataStore.NextPatientId();
            p.FileNumber = TextFileNum.Text;
            p.FullName = fullNameTxt.Text;
            p.Phone = NumPhoneTxt.Text;
            p.Gender = cmbGender.Text;
            p.Age = int.Parse(Age.Text);

            DataStore.Patients.Add(p);

            MessageBox.Show("تمت الإضافة بنجاح", "تم",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();
            DashBoardForm dashBoardForm = new DashBoardForm();
            dashBoardForm.Show();
           
           
        }


        private bool IsValidName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return false;

            // يسمح بالحروف العربية والإنجليزية والمسافات
            Regex regex = new Regex(@"^[\p{L}\s]+$");
            return regex.IsMatch(name);
        }

        // ✅ دالة للتحقق من أن النص يحتوي على أرقام فقط
        private bool IsValidPhone(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone))
                return false;

            // يسمح بالأرقام فقط
            Regex regex = new Regex(@"^\d+$");
            return regex.IsMatch(phone);
        }
        private void NumPhoneTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            // يسمح فقط بالأرقام وحذف الخلفية (Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(NumPhoneTxt, "يجب إدخال أرقام فقط");
            }
            else
            {
                errorProvider1.SetError(NumPhoneTxt, "");
            }
        }
        private void fullNameTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            // يسمح بالحروف العربية والإنجليزية والمسافات وحذف الخلفية
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                // التحقق إذا كان الحرف عربياً (مجال Unicode للعربية)
                if (!(e.KeyChar >= 0x0600 && e.KeyChar <= 0x06FF))
                {
                    e.Handled = true;
                    errorProvider1.SetError(fullNameTxt, "يجب إدخال حروف فقط");
                    return;
                }
            }
            errorProvider1.SetError(fullNameTxt, "");
        }
        private bool ValidateForm()
        {
            bool isValid = true;

            // التحقق من الاسم
            if (!IsValidName(fullNameTxt.Text))
            {
                errorProvider1.SetError(fullNameTxt, "الاسم يجب أن يحتوي على حروف فقط");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(fullNameTxt, "");
            }

            // التحقق من رقم الهاتف
            if (!IsValidPhone(NumPhoneTxt.Text))
            {
                errorProvider1.SetError(NumPhoneTxt, "رقم الهاتف يجب أن يحتوي على أرقام فقط");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(NumPhoneTxt, "");
            }

            // التحقق من عدم ترك الحقول فارغة
            if (string.IsNullOrWhiteSpace(fullNameTxt.Text))
            {
                errorProvider1.SetError(fullNameTxt, "الاسم مطلوب");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(NumPhoneTxt.Text))
            {
                errorProvider1.SetError(NumPhoneTxt, "رقم الهاتف مطلوب");
                isValid = false;
            }

            // التحقق من اختيار الجنس
            if (cmbGender.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbGender, "الرجاء اختيار الجنس");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(cmbGender, "");
            }

            return isValid;
        }
    }
}

