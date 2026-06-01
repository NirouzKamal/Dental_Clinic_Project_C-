using DentalClinicProject.classes;
using DentalClinicProject.data;
using DentalClinicProject.Data;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace DentalClinicProject
{
    public partial class AppointmentForm : Form
    {
        private DateTime startDate = DateTime.Today;
        private DateTime endDate;

        public AppointmentForm()
        {
            InitializeComponent();
            endDate = startDate.AddMonths(6);
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

        private void AppointmentForm_Load(object sender, EventArgs e)
        {
            // تحميل الأطباء من DataStore
            LoadDoctors();

            // إعداد الجدول
            SetupDataGridView();

            // التاريخ
            label7.Text = startDate.ToString("dd MMMM yyyy", new System.Globalization.CultureInfo("ar-LY"));
            label5.Text = DateTime.Now.ToString("dddd ، dd MMMM yyyy", new System.Globalization.CultureInfo("ar-LY"));

            // تنسيق الواجهة
            MakePanelRounded(panel2, 80);
            MakePanelRounded(panel3, 80);
            MakePanelRounded(panel4, 80);
            MakePanelRounded(panel5, 150);
            MakePanelRounded(panel10, 12);
            SetRoundedButton(btnLogOut, 50);
            SetRoundedButton(shortcutsBtn, 50);

            // البحث
            searchCmb.Text = "ابحث برقم أو اسم المريض...";
            searchCmb.ForeColor = Color.Gray;

            // ربط الأحداث
            doctorNameCmb.SelectedIndexChanged += doctorNameCmb_SelectedIndexChanged;
            dayAppointmentsDgv.CellEndEdit += dayAppointmentsDgv_CellEndEdit;
            dayAppointmentsDgv.CellDoubleClick += dayAppointmentsDgv_CellDoubleClick;

            // تحميل المواعيد
            LoadAllAppointments();
        }

        private void LoadDoctors()
        {
            doctorNameCmb.DataSource = null;
            doctorNameCmb.DataSource = DataStore.Doctors;
            doctorNameCmb.DisplayMember = "FullName";
            doctorNameCmb.ValueMember = "DoctorId";
            doctorNameCmb.SelectedIndex = -1;
        }

        private void SetupDataGridView()
        {
            dayAppointmentsDgv.Rows.Clear();
            dayAppointmentsDgv.AllowUserToAddRows = false;
            dayAppointmentsDgv.AllowUserToDeleteRows = false;
            dayAppointmentsDgv.ReadOnly = false;
            dayAppointmentsDgv.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
        }

        private void LoadAllAppointments()
        {
            if (doctorNameCmb.SelectedItem == null) return;

            Doctor selectedDoctor = (Doctor)doctorNameCmb.SelectedItem;
            dayAppointmentsDgv.Rows.Clear();

            var appointments = DataStore.Appointments
                .Where(a => a.DoctorId == selectedDoctor.DoctorId &&
                            a.AppointmentDate.Date >= startDate.Date &&
                            a.AppointmentDate.Date <= endDate.Date &&
                            a.Status != AppointmentStatus.Cancelled)
                .OrderBy(a => a.AppointmentDate)
                .ThenBy(a => a.StartTime)
                .ToList();

            foreach (var appointment in appointments)
            {
                var patient = DataStore.Patients.FirstOrDefault(p => p.PatientId == appointment.PatientId);

                dayAppointmentsDgv.Rows.Add(
                    appointment.AppointmentDate.ToString("dd/MM/yyyy"),
                    $"{appointment.StartTime:hh\\:mm} - {appointment.EndTime:hh\\:mm}",
                    patient?.FullName ?? "غير معروف",
                    patient?.FileNumber ?? "",
                    patient?.Phone ?? "",
                    GetStatusText(appointment.Status),
                    appointment.Notes ?? "",
                    appointment.AppointmentId
                );
            }

            foreach (DataGridViewRow row in dayAppointmentsDgv.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.White;
                row.DefaultCellStyle.ForeColor = Color.Black;
            }
        }

        private string GetStatusText(AppointmentStatus status)
        {
            switch (status)
            {
                case AppointmentStatus.Scheduled: return "مؤكد";
                case AppointmentStatus.Completed: return "مكتمل";
                case AppointmentStatus.Cancelled: return "ملغي";
                default: return "معلق";
            }
        }

        private AppointmentStatus ConvertStatusToEnum(string statusText)
        {
            switch (statusText)
            {
                case "مؤكد": return AppointmentStatus.Scheduled;
                case "مكتمل": return AppointmentStatus.Completed;
                case "ملغي": return AppointmentStatus.Cancelled;
                default: return AppointmentStatus.Scheduled;
            }
        }

        private void doctorNameCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAllAppointments();
        }

        private void AddNewPatientbtn_Click(object sender, EventArgs e)
        {
            if (doctorNameCmb.SelectedItem == null)
            {
                MessageBox.Show("الرجاء اختيار الطبيب أولاً", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Doctor selectedDoctor = (Doctor)doctorNameCmb.SelectedItem;
            addAppointment addForm = new addAppointment(selectedDoctor, DateTime.Today, new TimeSpan(9, 0, 0));
            addForm.ShowDialog();
            LoadAllAppointments();
            RefreshAllDashboards();
        }

        private void RefreshAllDashboards()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is DashBoardForm dashboard)
                {
                    dashboard.LoadTodayAppointments();
                }
                else if (form is DoctorDashboard doctorDashboard)
                {
                    doctorDashboard.RefreshData();
                }
            }
        }

        private void PerformSearch()
        {
            string searchText = searchCmb.Text.Trim();

            if (string.IsNullOrEmpty(searchText) || searchText == "ابحث برقم أو اسم المريض...")
            {
                LoadAllAppointments();
                return;
            }

            if (doctorNameCmb.SelectedItem == null) return;
            Doctor selectedDoctor = (Doctor)doctorNameCmb.SelectedItem;

            dayAppointmentsDgv.Rows.Clear();

            var filteredAppointments = DataStore.Appointments
                .Where(a => a.DoctorId == selectedDoctor.DoctorId && a.Status != AppointmentStatus.Cancelled)
                .ToList();

            foreach (var apt in filteredAppointments)
            {
                var patient = DataStore.Patients.FirstOrDefault(p => p.PatientId == apt.PatientId);
                if (patient != null && (patient.FullName.Contains(searchText) || patient.FileNumber.Contains(searchText)))
                {
                    dayAppointmentsDgv.Rows.Add(
                        apt.AppointmentDate.ToString("dd/MM/yyyy"),
                        $"{apt.StartTime:hh\\:mm} - {apt.EndTime:hh\\:mm}",
                        patient.FullName,
                        patient.FileNumber,
                        patient.Phone,
                        GetStatusText(apt.Status),
                        apt.Notes ?? "",
                        apt.AppointmentId
                    );
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e) => PerformSearch();
        private void pictureBox4_Click(object sender, EventArgs e) => PerformSearch();

        private void dayAppointmentsDgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int appointmentId = Convert.ToInt32(dayAppointmentsDgv.Rows[e.RowIndex].Cells[7].Value);
            string status = dayAppointmentsDgv.Rows[e.RowIndex].Cells[5].Value?.ToString();

            if (appointmentId != -1 && status == "مؤكد")
            {
                DialogResult result = MessageBox.Show("هل تريد إلغاء هذا الموعد؟", "تأكيد الإلغاء",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    var appointment = DataStore.Appointments.FirstOrDefault(a => a.AppointmentId == appointmentId);
                    if (appointment != null)
                    {
                        appointment.Status = AppointmentStatus.Cancelled;
                        LoadAllAppointments();
                        RefreshAllDashboards();
                        MessageBox.Show("تم إلغاء الموعد بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void dayAppointmentsDgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int appointmentId = Convert.ToInt32(dayAppointmentsDgv.Rows[e.RowIndex].Cells[7].Value);
            var appointment = DataStore.Appointments.FirstOrDefault(a => a.AppointmentId == appointmentId);
            if (appointment == null) return;

            var patient = DataStore.Patients.FirstOrDefault(p => p.PatientId == appointment.PatientId);
            string newValue = dayAppointmentsDgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString() ?? "";
            bool isChanged = false;

            switch (e.ColumnIndex)
            {
                case 2:
                    if (patient != null && patient.FullName != newValue)
                    {
                        patient.FullName = newValue;
                        isChanged = true;
                    }
                    break;
                case 4:
                    if (patient != null && patient.Phone != newValue)
                    {
                        patient.Phone = newValue;
                        isChanged = true;
                    }
                    break;
                case 5:
                    if (GetStatusText(appointment.Status) != newValue)
                    {
                        appointment.Status = ConvertStatusToEnum(newValue);
                        isChanged = true;
                    }
                    break;
                case 6:
                    if ((appointment.Notes ?? "") != newValue)
                    {
                        appointment.Notes = newValue;
                        isChanged = true;
                    }
                    break;
            }

            if (isChanged)
            {
                MessageBox.Show("تم تعديل وحفظ البيانات بنجاح", "تحديث", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshAllDashboards();
            }
        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            if (dayAppointmentsDgv.SelectedRows.Count > 0)
            {
                var selectedRow = dayAppointmentsDgv.SelectedRows[0];
                if (selectedRow.Cells[7].Value == null) return;

                int appointmentId = Convert.ToInt32(selectedRow.Cells[7].Value);

                DialogResult result = MessageBox.Show("هل تريد حذف هذا الموعد نهائياً؟", "تأكيد الحذف",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    var appointment = DataStore.Appointments.FirstOrDefault(a => a.AppointmentId == appointmentId);
                    if (appointment != null)
                    {
                        DataStore.Appointments.Remove(appointment);
                        LoadAllAppointments();
                        RefreshAllDashboards();
                        MessageBox.Show("تم حذف الموعد بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("الرجاء اختيار صف من الجدول أولاً", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void shortcutsBtn_Click(object sender, EventArgs e)
        {
            if (DataStore.CurrentUser.Role == UserRole.Admin)
            {
                Shortcuts_Admin frm = new Shortcuts_Admin();
                frm.Show();
            }
            else
            {
                shortcutsForm frm = new shortcutsForm();
                frm.Show();
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("هل أنت متأكد من أنك تريد تسجيل الخروج؟", "تأكيد", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
        }

        private void btnDashBaord_Click(object sender, EventArgs e)
        {
            Form frm;
            if (DataStore.CurrentUser.Role == UserRole.Admin)
                frm = new AdminDashboardForm();
            else if (DataStore.CurrentUser.Role == UserRole.Doctor)
                frm = new DoctorDashboard();
            else
                frm = new DashBoardForm();

            frm.Show();
            this.Hide();
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
    }
}