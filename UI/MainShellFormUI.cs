using System;
using System.Drawing;
using System.Windows.Forms;
using DentalClinicProject.classes;
using DentalClinicProject.data;
using DentalClinicProject.Data;

namespace DentalClinicProject.UI
{
    public partial class MainShellFormUI : System.Windows.Forms.Form
    {
        private Button currentActiveButton;

        /// <summary>Set on logout so Program can show LoginForm again.</summary>
        public bool LogoutRequested { get; private set; }

        public MainShellFormUI()
        {
            InitializeComponent();
            
            // Attach event handlers
            this.Load += MainShellFormUI_Load;
            
            btnDashboard.Click += NavButton_Click;
            btnAppointments.Click += NavButton_Click;
            btnRecords.Click += NavButton_Click;
            btnRevenues.Click += NavButton_Click;
            btnStaff.Click += NavButton_Click;
            btnPayroll.Click += BtnPayroll_Click;
            btnDebts.Click += BtnDebts_Click;
            btnAddPatient.Click += BtnAddPatient_Click;
            btnLogout.Click += BtnLogout_Click;
        }

        private void MainShellFormUI_Load(object sender, EventArgs e)
        {
            ApplyRoleBasedMenuVisibility();

            if (DataStore.CurrentUser != null && DataStore.CurrentUser.Role == UserRole.Doctor)
                lblUserInfo.Text = $"مرحباً: د. {DataStore.CurrentUser.FullName ?? DataStore.CurrentUser.Username}";
            else if (DataStore.CurrentUser != null)
                lblUserInfo.Text = $"مرحباً: {DataStore.CurrentUser.FullName ?? DataStore.CurrentUser.Username}";

            // Update Date
            lblDate.Text = DateTime.Now.ToString("dddd ، dd MMMM yyyy", new System.Globalization.CultureInfo("ar-LY"));

            btnDashboard.PerformClick();
        }

        private void NavButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            SetActiveButton(clickedButton);

            panelMainContent.Controls.Clear();

            // Note: In later phases, we will replace the original controls with the UI versions
            // Currently using the original controls to ensure things still build/work during phase 1
            if (clickedButton == btnDashboard)
            {
                if (DataStore.CurrentUser != null && DataStore.CurrentUser.Role == UserRole.Doctor)
                    LoadControl(new DoctorDashboardControlUI(DataStore.CurrentUser.UserId));
                else
                    LoadControl(new DashboardControlUI());
            }
            else if (clickedButton == btnAppointments)
                LoadControl(new AppointmentsControlUI());
            else if (clickedButton == btnRecords)
                LoadControl(new PatientRecordsControlUI());
            else if (clickedButton == btnRevenues)
            {
                if (DataStore.CurrentUser != null && DataStore.CurrentUser.Role == UserRole.Receptionist)
                    LoadControl(new DailyRevenueControl());
                else
                    LoadControl(new RevenuesControlUI());
            }
            else if (clickedButton == btnStaff)
                LoadControl(new StaffManagementControlUI());
        }

        private void ApplyRoleBasedMenuVisibility()
        {
            bool isAdmin = DataStore.CurrentUser?.Role == UserRole.Admin;
            bool isReceptionist = DataStore.CurrentUser?.Role == UserRole.Receptionist;
            bool isDoctor = DataStore.CurrentUser?.Role == UserRole.Doctor;

            btnStaff.Visible = isAdmin;
            btnPayroll.Visible = isAdmin;
            btnRevenues.Visible = isAdmin || isReceptionist;
            btnDebts.Visible = isAdmin;
            btnAddPatient.Visible = isAdmin || isReceptionist;

            if (isReceptionist)
                btnRevenues.Text = "إغلاق إيرادات اليوم";

            if (isDoctor)
            {
                btnStaff.Visible = false;
                btnPayroll.Visible = false;
                btnRevenues.Visible = false;
                btnDebts.Visible = false;
                btnAddPatient.Visible = false;
            }
        }

        private void BtnPayroll_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnPayroll);
            new PayrollManagementFormUI().ShowDialog();
        }

        private void BtnDebts_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnDebts);
            new DebtsManagementForm().ShowDialog();
        }

        private void BtnAddPatient_Click(object sender, EventArgs e)
        {
            using (var form = new AddPatientFormUI())
            {
                form.ShowDialog(this);
            }
        }

        private void LoadControl(UserControl control)
        {
            panelMainContent.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelMainContent.Controls.Add(control);
        }

        private void SetActiveButton(Button btn)
        {
            if (currentActiveButton != null)
            {
                currentActiveButton.ForeColor = Color.FromArgb(108, 117, 125); // ThemeManager.TextMuted
                currentActiveButton.BackColor = Color.White; // ThemeManager.BackgroundColor
            }

            currentActiveButton = btn;
            currentActiveButton.ForeColor = Color.FromArgb(0, 75, 155); // ThemeManager.PrimaryColor
            currentActiveButton.BackColor = ColorTranslator.FromHtml("#F8F9FA");
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
                "هل أنت متأكد من أنك تريد تسجيل الخروج؟",
                "Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
                return;

            DataStore.CurrentUser = null;
            session.CurrentUser = null;
            LogoutRequested = true;
            Close();
        }
    }
}
