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

namespace DentalClinicProject
{
    public partial class DashBoardForm : Form
    {

        public DashBoardForm()
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

        private void DashBoardForm_Load(object sender, EventArgs e)
        {
            RefreshPendingCount();
            doctorNameCmb.Items.Clear();
            doctorNameCmb.Items.Add(" الكُل");
            doctorNameCmb.Items.Add(" د.عبد الحكيم أحمد");
            doctorNameCmb.Items.Add(" د.سلوى حسام");
            doctorNameCmb.Items.Add(" د.محمد حسن");
            doctorNameCmb.SelectedIndex = 0;
            MakePanelRounded(panel3, 80);   
            MakePanelRounded(panel4, 80);
            MakePanelRounded(panel5, 150);
            MakePanelRounded(panel6, 80);   
            MakePanelRounded(panel7, 80);   
            MakePanelRounded(panel8, 80);   
            MakePanelRounded(panel9, 8);   
            MakePanelRounded(panel11, 80);   
            MakePanelRounded(panel12, 80);   
            MakePanelRounded(panel13, 80);  
            SetRoundedButton(btnLogOut, 50);
            SetRoundedButton(btnDashBaord, 50);
            searchCmb.Text = "ابحث برقم أو اسم المريض...";
            searchCmb.ForeColor = Color.Gray;
            label5.Text = DateTime.Now.ToString("dddd ، dd MMMM yyyy", new System.Globalization.CultureInfo("ar-LY"));
            label7.Text = DateTime.Now.ToString("dd MMMM yyyy", new System.Globalization.CultureInfo("ar-LY"));
            RefreshDashboard();
            LoadTodayAppointments();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            shortcutsForm  shortcutsForm = new shortcutsForm();
            shortcutsForm.Show();
        }

        private void comboBox1_Click_1(object sender, EventArgs e)
        {
            if (searchCmb.SelectedIndex == 0)
            {
                searchCmb.DroppedDown = true;
            }
        }

        private void comboBox1_Enter_1(object sender, EventArgs e)
        {
            if (searchCmb.Text == "ابحث برقم أو اسم المريض...")
            {
                searchCmb.Text = "";
                searchCmb.ForeColor = Color.Black;
            }
        }

        private void comboBox1_Leave_1(object sender, EventArgs e)
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

        private void AddNewPatientbtn_Click(object sender, EventArgs e)
        {
            CaseCreation caseCreation = new CaseCreation();
            caseCreation.Show();
            RefreshDashboard();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var frm = new CompletedCasesForm();
            frm.ShowDialog();
            RefreshPendingCount();
        }

        private void RefreshPendingCount()
        {
            int count = DataStore.Cases.Count(c => c.SentToReception);
            // غيري "btnCompletedCases" لاسم البوتن عندك
            btnCompletedCases.Text = $"حالات محولة من الطبيب ({count})";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void RefreshDashboard()
        {
            // مواعيد اليوم
            int todayAppointments =
                DataStore.Appointments
                .Count(a => a.AppointmentDate.Date == DateTime.Today);

            lblTodayAppointments.Text =
                todayAppointments.ToString();

            // حالات الانتظار
            int waitingCases =
                DataStore.Cases
                .Count(c => c.Status == CaseStatus.Waiting);

            lblWaitingCases.Text =
                waitingCases.ToString();

            // الحالات المكتملة
            int completedCases =
                DataStore.Cases
                .Count(c => c.Status == CaseStatus.Completed);

            lblCompletedCases.Text =
                completedCases.ToString();
        }
        public void LoadTodayAppointments()
        {
            // مسح الصفوف القديمة
            todayAppointmentsDgv.Rows.Clear();

            // جلب مواعيد اليوم من DataStore
            var todayAppointments = DataStore.Appointments
                .Where(a => a.AppointmentDate.Date == DateTime.Today &&
                            a.Status != AppointmentStatus.Cancelled)
                .OrderBy(a => a.StartTime)
                .ToList();

            foreach (var apt in todayAppointments)
            {
                // جلب بيانات المريض
                var patient = DataStore.Patients.FirstOrDefault(p => p.PatientId == apt.PatientId);
                // جلب بيانات الدكتور
                var doctor = DataStore.Doctors.FirstOrDefault(d => d.DoctorId == apt.DoctorId);

                // تحديد الفترة (صباحاً / مساءاً)
                string period = apt.StartTime.Hours < 12 ? "صباحاً" : "مساءاً";

                todayAppointmentsDgv.Rows.Add(
                    patient?.FileNumber ?? "",
                    patient?.FullName ?? "غير معروف",
                    patient?.Phone ?? "",
                    doctor?.FullName ?? "غير معروف",
                    apt.StartTime.ToString(@"hh\:mm"),
                    period,
                    apt.Notes ?? "",
                    GetAppointmentStatusText(apt.Status)
                );
            }
        }

        private string GetAppointmentStatusText(AppointmentStatus status)
        {
            switch (status)
            {
                case AppointmentStatus.Scheduled: return "مؤكد";
                case AppointmentStatus.Completed: return "مكتمل";
                case AppointmentStatus.Cancelled: return "ملغي";
                default: return "معلق";
            }
        }
    }
}
