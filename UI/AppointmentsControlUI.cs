using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DentalClinicProject.classes;
using DentalClinicProject.data;

namespace DentalClinicProject.UI
{
    public partial class AppointmentsControlUI : System.Windows.Forms.UserControl
    {
        private DateTime startDate = DateTime.Today;
        private DateTime endDate;

        public AppointmentsControlUI()
        {
            endDate = startDate.AddMonths(6);
            InitializeComponent();
            
            // Add hidden ID column
            dgvAppointments.Columns.Add("colId", "ID");
            dgvAppointments.Columns["colId"].Visible = false;
            dgvAppointments.AllowUserToAddRows = false;
            dgvAppointments.AllowUserToDeleteRows = false;
            dgvAppointments.ReadOnly = false;
            dgvAppointments.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
            
            SetupLogic();
        }

        private void SetupLogic()
        {
            this.Load += (s, e) => LoadDoctors();
            cmbDoctor.SelectedIndexChanged += (s, e) => LoadAllAppointments();

            txtSearch.Enter += searchCmb_Enter;
            txtSearch.Leave += searchCmb_Leave;
            txtSearch.TextChanged += (s, e) => PerformSearch(); 

            btnAddAppointment.Click += AddNewPatientbtn_Click;
            btnDeleteAppointment.Click += NewBtn_Click;

            dgvAppointments.CellDoubleClick += dayAppointmentsDgv_CellDoubleClick;
            dgvAppointments.CellEndEdit += dayAppointmentsDgv_CellEndEdit;
        }

        private void LoadDoctors()
        {
            cmbDoctor.DataSource = null;
            cmbDoctor.DataSource = DataStore.Doctors;
            cmbDoctor.DisplayMember = "FullName";
            cmbDoctor.ValueMember = "DoctorId";
            cmbDoctor.SelectedIndex = -1; 
        }

        private void LoadAllAppointments()
        {
            if (cmbDoctor.SelectedItem == null) return;

            Doctor selectedDoctor = (Doctor)cmbDoctor.SelectedItem;
            dgvAppointments.Rows.Clear();

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

                dgvAppointments.Rows.Add(
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
        }

        private void PerformSearch()
        {
            string searchText = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchText) || searchText == "ابحث برقم أو اسم المريض...")
            {
                LoadAllAppointments();
                return;
            }

            if (cmbDoctor.SelectedItem == null) return;
            Doctor selectedDoctor = (Doctor)cmbDoctor.SelectedItem;

            dgvAppointments.Rows.Clear();

            var filteredAppointments = DataStore.Appointments
                .Where(a => a.DoctorId == selectedDoctor.DoctorId && a.Status != AppointmentStatus.Cancelled)
                .ToList();

            foreach (var apt in filteredAppointments)
            {
                var patient = DataStore.Patients.FirstOrDefault(p => p.PatientId == apt.PatientId);
                if (patient != null && (patient.FullName.Contains(searchText) || patient.FileNumber.Contains(searchText)))
                {
                    dgvAppointments.Rows.Add(
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

        private void AddNewPatientbtn_Click(object sender, EventArgs e)
        {
            var addForm = new UI.AddAppointmentFormUI();
            if (addForm.ShowDialog() == DialogResult.OK)
                LoadAllAppointments();
        }

        private void NewBtn_Click(object sender, EventArgs e) 
        {
            if (dgvAppointments.SelectedRows.Count > 0)
            {
                var selectedRow = dgvAppointments.SelectedRows[0];
                if (selectedRow.Cells[7].Value == null) return; 

                string appointmentId = selectedRow.Cells[7].Value.ToString();

                DialogResult result = MessageBox.Show("هل تريد حذف هذا الموعد نهائياً؟", "تأكيد الحذف",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    var appointment = DataStore.Appointments.FirstOrDefault(a => a.AppointmentId == appointmentId);
                    if (appointment != null)
                    {
                        DataStore.Appointments.Remove(appointment);
                        LoadAllAppointments();
                        MessageBox.Show("تم حذف الموعد بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("الرجاء اختيار صف من الجدول أولاً", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dayAppointmentsDgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string appointmentId = dgvAppointments.Rows[e.RowIndex].Cells[7].Value.ToString();
            string status = dgvAppointments.Rows[e.RowIndex].Cells[5].Value?.ToString();

            if (!string.IsNullOrEmpty(appointmentId) && status == "مؤكد")
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
                        MessageBox.Show("تم إلغاء الموعد بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void dayAppointmentsDgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string appointmentId = dgvAppointments.Rows[e.RowIndex].Cells[7].Value.ToString();
            var appointment = DataStore.Appointments.FirstOrDefault(a => a.AppointmentId == appointmentId);
            if (appointment == null) return;

            var patient = DataStore.Patients.FirstOrDefault(p => p.PatientId == appointment.PatientId);
            string newValue = dgvAppointments.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString() ?? "";
            bool isChanged = false;

            switch (e.ColumnIndex)
            {
                case 2: // Patient Name
                    if (patient != null && patient.FullName != newValue)
                    {
                        patient.FullName = newValue;
                        isChanged = true;
                    }
                    break;
                case 4: // Phone
                    if (patient != null && patient.Phone != newValue)
                    {
                        patient.Phone = newValue;
                        isChanged = true;
                    }
                    break;
                case 5: // Status
                    if (GetStatusText(appointment.Status) != newValue)
                    {
                        appointment.Status = ConvertStatusToEnum(newValue);
                        isChanged = true;
                    }
                    break;
                case 6: // Notes
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

        private void searchCmb_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "ابحث برقم أو اسم المريض...")
            {
                txtSearch.Text = "";
            }
        }

        private void searchCmb_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "ابحث برقم أو اسم المريض...";
            }
        }
    }
}
