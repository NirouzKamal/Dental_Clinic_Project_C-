using DentalClinicProject.data;
using DentalClinicProject.Data;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DentalClinicProject
{
    public partial class shortcutsForm : Form
    {
        public shortcutsForm()
        {
            InitializeComponent();
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
        private void shortcutsForm_Load(object sender, EventArgs e)
        {
            MakePanelRounded(panel1, 80);
            MakePanelRounded(panel3, 80);   
            MakePanelRounded(panel4, 80);  
            MakePanelRounded(panel5, 80);   
            MakePanelRounded(panel6, 80);  
            MakePanelRounded(panel7, 80);   
            MakePanelRounded(panel8, 80);
            //MakePanelRounded(panel9, 8);
            //MakePanelRounded(panel10, 80);   
            MakePanelRounded(panel11, 80);
            //MakePanelRounded(panel12, 80);   
            //MakePanelRounded(panel15, 80);   
            //MakePanelRounded(panel16, 80);   
            //MakePanelRounded(panel17, 80);
            //MakePanelRounded(panel18, 80);
            SetRoundedButton(btnLogOut, 50);
            SetRoundedButton(shortcutsBtn, 50);
            label5.Text = DateTime.Now.ToString("dddd ، dd MMMM yyyy", new System.Globalization.CultureInfo("ar-LY"));
            //label7.Text = DateTime.Now.ToString("dd MMMM yyyy", new System.Globalization.CultureInfo("ar-LY"));
        }

        private void appointmentMngBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AppointmentForm appointmentForm = new AppointmentForm();
            appointmentForm.Show();
        }

        private void btnDashBaord_Click(object sender, EventArgs e)
        {  // ✅ التحقق من وجود مستخدم مسجل الدخول
            if (DataStore.CurrentUser == null)
            {
                MessageBox.Show("الرجاء تسجيل الدخول أولاً", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ✅ فتح الفورم المناسب حسب دور المستخدم
            if (DataStore.CurrentUser.Role == UserRole.Doctor)
            {
                DoctorDashboard frm = new DoctorDashboard();
                frm.Show();
                this.Hide();
            }
            else if (DataStore.CurrentUser.Role == UserRole.Receptionist)
            {
                DashBoardForm frm = new DashBoardForm();
                frm.Show();
                this.Hide();
            }
            else if (DataStore.CurrentUser.Role == UserRole.Admin)
            {
                AdminDashboardForm frm = new AdminDashboardForm();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("دور المستخدم غير معروف", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            }

        private void patientRecordBtn_Click(object sender, EventArgs e)
        {
            Form1 patientRecordForm = new Form1();
            patientRecordForm.ShowDialog();
        }
        private void AddPatientBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddPatient addPatient = new AddPatient();
            addPatient.Show();

        }

        private void btnLogOut_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("هل أنت متأكد من أنك تريد تسجيل الخروج", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                //MessageBox.Show("تم تسجيل الخروج بنجاح", "Success", MessageBoxButtons.OK);
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }
    }
}
