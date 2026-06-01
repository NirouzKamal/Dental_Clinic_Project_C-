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
    public partial class AdminDashboardForm : Form
    {
        public AdminDashboardForm()
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

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            doctorNameCmb.Items.Clear();
            doctorNameCmb.Items.Add(" الكُل");
            doctorNameCmb.Items.Add(" د.عبد الحكيم أحمد");
            doctorNameCmb.Items.Add(" د.سلوى حسام");
            doctorNameCmb.Items.Add(" د.محمد حسن");
            doctorNameCmb.SelectedIndex = 0;
            MakePanelRounded(panel1, 80);   
            MakePanelRounded(panel2, 80);   
            MakePanelRounded(panel3, 80);  
            MakePanelRounded(panel4, 80);
            MakePanelRounded(panel5, 150);
            MakePanelRounded(panel6, 80);   
            MakePanelRounded(panel7, 80);  
            MakePanelRounded(panel8, 80);  
            MakePanelRounded(panel9, 8);   
            MakePanelRounded(panel10, 80);   
            MakePanelRounded(panel11, 80);   
            MakePanelRounded(panel12, 80);  
            MakePanelRounded(panel13, 80);  
            SetRoundedButton(btnLogOut, 50);
            SetRoundedButton(btnDashBaord, 50);
            searchCmb.Text = "ابحث برقم أو اسم المريض...";
            searchCmb.ForeColor = Color.Gray;
            label5.Text = DateTime.Now.ToString("dddd ، dd MMMM yyyy", new System.Globalization.CultureInfo("ar-LY"));
            label7.Text = DateTime.Now.ToString("dd MMMM yyyy", new System.Globalization.CultureInfo("ar-LY"));
            todayAppointmentsDgv.Rows.Add("1797", "سارة محمد", "0921028423", "د.عبد الحكيم أحمد", "9:00", "صباحاً", "خلع", "مؤكد");
            todayAppointmentsDgv.Rows.Add("5675", "أحمد علي", "0922321669", "د.سلوى حسام", "10:30", "صباحاً", "كشف", "في الإنتظار");
            todayAppointmentsDgv.Rows.Add("7896", "نورة سالم", "0912958230", "د.محمد حسن", "5:00", "مساءاً", "مراجعة حشو", "ملغي");
        }

        private void searchCmb_Enter(object sender, EventArgs e)
        {
            if (searchCmb.Text == "ابحث برقم أو اسم المريض...")
            {
                searchCmb.Text = "";
                searchCmb.ForeColor = Color.Black;
            }
        }

        private void searchCmb_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchCmb.Text))
            {
                searchCmb.Text = "ابحث برقم أو اسم المريض...";
                searchCmb.ForeColor = Color.Gray;
            }
        }

        private void searchCmb_Click(object sender, EventArgs e)
        {
            if (searchCmb.SelectedIndex == 0)
            {
                searchCmb.DroppedDown = true;
            }
        }

        private void shortcutsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Shortcuts_Admin adminShortcutsForm = new Shortcuts_Admin();
            adminShortcutsForm.Show();
        }

        private void AddNewPatientbtn_Click(object sender, EventArgs e)
        {
            CaseCreation caseCreation = new CaseCreation();
            caseCreation.Show();
        }
    }
}
