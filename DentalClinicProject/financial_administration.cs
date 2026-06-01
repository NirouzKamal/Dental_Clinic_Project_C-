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
    public partial class financial_administration : Form
    {
        public financial_administration()
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
        private void financial_administration_Load(object sender, EventArgs e)
        {
            doctorNameCmb.Items.Clear();
            doctorNameCmb.Items.Add(" الكُل");
            doctorNameCmb.Items.Add(" د.عبد الحكيم أحمد");
            doctorNameCmb.Items.Add(" د.سلوى حسام");
            doctorNameCmb.Items.Add(" د.محمد حسن");
            doctorNameCmb.SelectedIndex = 0;
            MakePanelRounded(panel1, 80);
            MakePanelRounded(panel2, 80);   // لتغيير حجم الانحناء
            MakePanelRounded(panel3, 80);
            MakePanelRounded(panel4, 80);
            MakePanelRounded(panel5, 80);
            MakePanelRounded(panel6, 80);
            MakePanelRounded(panel7, 80);
            MakePanelRounded(panel8, 80);
            MakePanelRounded(panel9, 8);
            MakePanelRounded(panel11, 80);
            MakePanelRounded(panel12, 80);
            MakePanelRounded(panel13, 80);
            MakePanelRounded(panel14, 80);
            //MakePanelRounded(panel15, 12);
            MakePanelRounded(panel10, 80);
            SetRoundedButton(btnLogOut, 50);
            SetRoundedButton(shortcutsBtn, 50);
            searchCmb.Text = "ابحث برقم أو اسم المريض...";
            searchCmb.ForeColor = Color.Gray;
        }

        private void btnDashBaord_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboardForm adminDashboardForm = new AdminDashboardForm();
            adminDashboardForm.ShowDialog();
        }

        private void shortcutsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();    
            Shortcuts_Admin shortcuts_Admin = new Shortcuts_Admin();
            shortcuts_Admin.ShowDialog();
        }

        private void searchCmb_Click(object sender, EventArgs e)
        {
            if (searchCmb.SelectedIndex == 0)
            {
                searchCmb.DroppedDown = true;
            }
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

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void billsNot_Click(object sender, EventArgs e)
        {
            this.Hide();
            BillsNot billsNot=new BillsNot();
            billsNot.Show();
        }
    }
}
