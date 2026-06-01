using DentalClinicProject.data;
using DentalClinicProject.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace DentalClinicProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            cmbUsername.Items.Clear();
            foreach (var user in DataStore.Users)
            {
                cmbUsername.Items.Add(user.Username);
            }
        }

        private void btnSighnIN_Click(object sender, EventArgs e)
        {
            string username = cmbUsername.SelectedItem?.ToString();
            string password = txtPassword.Text;
            // 1. نقوم بتشفير كلمة المرور التي أدخلها المستخدم حالياً
            string hashedPasswordInput = DataStore.HashPassword(password);


   

            var user = DataStore.Users
                .FirstOrDefault(u => u.Username == username && u.PasswordHash == hashedPasswordInput);

            if (user != null)
            {
                DataStore.CurrentUser = user;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("اسم المستخدم أو كلمة المرور غير صحيحة");
            }
            //// تأكد أن SelectedItem ليس null
            //if (cmbUsername.SelectedItem == null)
            //{
            //    MessageBox.Show("الرجاء اختيار اسم المستخدم", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //string username = cmbUsername.SelectedItem.ToString().Trim();  // ✅ Trim() يزيل المسافات الزائدة
            //string password = txtPassword.Text.Trim();

            //// ✅ الآن قارن بدون مسافات
            //if (username == "نيروز حشاد" && password == "232210")
            //{
            //    MessageBox.Show("تم تسجيل الدخول بنجاح", "Success", MessageBoxButtons.OK);
            //    DashBoardForm dashForm = new DashBoardForm();
            //    this.Hide();
            //    dashForm.Show();

            //}
            //else if (username == "د.أروى المسلاتي" && password == "232130")  // ✅ أيضاً بدون مسافة
            //{
            //    MessageBox.Show("تم تسجيل الدخول بنجاح", "Success", MessageBoxButtons.OK);
            //    DoctorDashboard doctorDashboard = new DoctorDashboard();
            //    this.Hide();
            //    doctorDashboard.Show();
            //}else if (username == "أدمن.ريم الطبيب" && password == "232132")  // ✅ أيضاً بدون مسافة
            //{
            //    MessageBox.Show("تم تسجيل الدخول بنجاح", "Success", MessageBoxButtons.OK);
            //    AdminDashboardForm adminDashbaordForm = new AdminDashboardForm();
            //    this.Hide();
            //    adminDashbaordForm.Show();
            //}
            //else
            //{
            //    MessageBox.Show("اسم المستخدم أو كلمة المرور غير صحيحة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}
