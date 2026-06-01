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
            btnPayroll.Click += NavButton_Click;
            btnLogout.Click += BtnLogout_Click;
        }

        private void MainShellFormUI_Load(object sender, EventArgs e)
        {
            if (DataStore.CurrentUser != null && DataStore.CurrentUser.Role == UserRole.Doctor)
            {
                btnStaff.Visible = false;
                btnPayroll.Visible = false;
                btnRevenues.Visible = false;
                lblUserInfo.Text = $"مرحباً: د. {DataStore.CurrentUser.FullName ?? DataStore.CurrentUser.Username}";
            }
            else if (DataStore.CurrentUser != null && DataStore.CurrentUser.Role == UserRole.Receptionist)
            {
                btnStaff.Visible = false;
                btnPayroll.Visible = false;
                lblUserInfo.Text = $"مرحباً: {DataStore.CurrentUser.FullName ?? DataStore.CurrentUser.Username}";
            }
            else if (DataStore.CurrentUser != null)
            {
                lblUserInfo.Text = $"مرحباً: {DataStore.CurrentUser.FullName ?? DataStore.CurrentUser.Username}";
            }

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
                LoadControl(new RevenuesControlUI());
            else if (clickedButton == btnStaff)
                LoadControl(new StaffManagementControlUI());
            else if (clickedButton == btnPayroll)
            {
                new PayrollManagementFormUI().ShowDialog();
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
