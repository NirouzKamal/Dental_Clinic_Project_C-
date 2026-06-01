using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalClinicProject
{
    public partial class Shortcuts_Admin : Form
    {
        public Shortcuts_Admin()
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
        
        private void appointmentMngBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AppointmentForm appointmentForm = new AppointmentForm();
            appointmentForm.Show();
        }

        private void btnDashBaord_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboardForm adminDashboardForm = new AdminDashboardForm();
            adminDashboardForm.Show();
        }

        private void patientRecordBtn_Click(object sender, EventArgs e)
        {
            PatientRecordForm patientRecordForm = new PatientRecordForm();
            patientRecordForm.ShowDialog();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
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

        private void Shortcuts_Admin_Load(object sender, EventArgs e)
        {
            MakePanelRounded(panel1, 80);   // حجم الإنحناء
            MakePanelRounded(panel3, 80);
            MakePanelRounded(panel4, 80);
            MakePanelRounded(panel5, 80);
            MakePanelRounded(panel6, 80);
            MakePanelRounded(panel7, 80);
            MakePanelRounded(panel8, 80);
            MakePanelRounded(panel9, 8);
            MakePanelRounded(panel10, 80);
            MakePanelRounded(panel11, 80);
            MakePanelRounded(panel12, 80);
            //MakePanelRounded(panel13, 80);
            //MakePanelRounded(panel14, 80);
            //MakePanelRounded(panel15, 80);
            //MakePanelRounded(panel16, 80);
            MakePanelRounded(panel17, 80);   
            MakePanelRounded(panel18, 80);   
            SetRoundedButton(btnLogOut, 50);
            SetRoundedButton(shortcutsBtn, 50);
            label5.Text = DateTime.Now.ToString("dddd ، dd MMMM yyyy", new System.Globalization.CultureInfo("ar-LY"));
            //label7.Text = DateTime.Now.ToString("dd MMMM yyyy", new System.Globalization.CultureInfo("ar-LY"));
        }

        private void incomeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            financial_administration financial_Administration=new financial_administration();
            financial_Administration.Show();
        }
    }
}
