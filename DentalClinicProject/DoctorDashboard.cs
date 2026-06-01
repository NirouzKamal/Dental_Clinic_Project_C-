using DentalClinicProject.classes;
using DentalClinicProject.data;
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
//using System.Linq;

namespace DentalClinicProject
{
    public partial class DoctorDashboard : Form
    {
        private Doctor currentDoctor;
        public DoctorDashboard()
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
        private void DoctorDashboard_Load(object sender, EventArgs e)
        {
            
            MakePanelRounded(panel1, 80);
            MakePanelRounded(panel3, 80);
            //MakePanelRounded(panel4, 80);
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
            //searchCmb.Text = "ابحث برقم أو اسم المريض...";
            //searchCmb.ForeColor = Color.Gray;
            label5.Text = DateTime.Now.ToString("dddd ، dd MMMM yyyy", new System.Globalization.CultureInfo("ar-LY"));
            //label7.Text = DateTime.Now.ToString("dd MMMM yyyy", new System.Globalization.CultureInfo("ar-LY"));
            LoadDoctorData();
            //MessageBox.Show(DataStore.CurrentUser.Username);
        }

        private void shortcutsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            shortcutsForm shortcutsForm = new shortcutsForm();
            shortcutsForm.Show();
        }

        //private void searchCmb_Click(object sender, EventArgs e)
        //{
        //    if (searchCmb.SelectedIndex == 0)
        //    {
        //        searchCmb.DroppedDown = true;
        //    }
        //}

        //private void searchCmb_Enter(object sender, EventArgs e)
        //{
        //    if (searchCmb.Text == "ابحث برقم أو اسم المريض...")
        //    {
        //        searchCmb.Text = "";
        //        searchCmb.ForeColor = Color.Black;
        //    }
        //}

     

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

        public void RefreshData()
        {
            LoadDoctorData();  // إعادة تحميل بيانات الطبيب والإحصائيات
        }


        private void LoadDoctorData()
        {
            // الطبيب الحالي من اليوزر الحالي
            currentDoctor = DataStore.Doctors
                .FirstOrDefault(d => d.UserId == DataStore.CurrentUser.UserId);

            if (currentDoctor == null)
            {
                MessageBox.Show("لم يتم العثور على بيانات الطبيب");
                return;
            }

            LoadDashboardStatistics();
            
        }

        private void LoadDashboardStatistics()
        {
            var doctorCases = DataStore.Cases
                .Where(c => c.DoctorId == currentDoctor.DoctorId)
                .ToList();

            // ===== حالات الانتظار =====
            int waitingCases = doctorCases
                .Count(c => c.Status == CaseStatus.Waiting);

            lblWaitingCases.Text = waitingCases.ToString();

            // ===== الحالات المكتملة =====
            int completedCases = doctorCases
                .Count(c => c.Status == CaseStatus.Completed);

            lblCompletedCases.Text = completedCases.ToString();

            // ===== مواعيد اليوم =====
            int todayCases = doctorCases
                .Count(c => c.OpenedDate.Date == DateTime.Today);

            lblTodayAppointments.Text = todayCases.ToString();

            // ===== الإيراد =====
            decimal revenue = doctorCases
                .Where(c => c.Status == CaseStatus.Completed)
                .Sum(c => c.FinalPrice);

            lblRevenue.Text = revenue.ToString("0") + " LYD";

            // ===== النوتيفيكشن =====
            int newCases = doctorCases
                .Count(c => c.Status == CaseStatus.Waiting &&
                            c.OpenedDate.Date == DateTime.Today);

            if (newCases > 0)
            {
                lblNotification.Text =
                    $"يوجد {newCases} حالات محولة من الاستقبال";
            }
            else
            {
                lblNotification.Text =
                    "لا توجد حالات محولة من الاستقبال";
            }
        }
        

        private void todayAppointement_Click(object sender, EventArgs e)
        {
            todayAppointmentsForm frm =
                                       new todayAppointmentsForm(currentDoctor);

            frm.ShowDialog();

            // بعد ما يسكر الفورم يحدث الإحصائيات
            LoadDashboardStatistics();
          
        }

        private void lblNotification_Click(object sender, EventArgs e)
        {

        }
    }
}
