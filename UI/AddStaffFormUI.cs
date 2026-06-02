using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DentalClinicProject;
using DentalClinicProject.classes;
using DentalClinicProject.data;

namespace DentalClinicProject.UI
{
    public partial class AddStaffFormUI : System.Windows.Forms.Form
    {
        private class DayScheduleRow
        {
            public DayOfWeek Day { get; set; }
            public CheckBox ChkIsWorking { get; set; }
            public ComboBox CmbShift { get; set; }
        }
        private List<DayScheduleRow> scheduleRows = new List<DayScheduleRow>();

        public AddStaffFormUI()
        {
            InitializeComponent();
            SetupSchedulePanel();
            SetupLogic();
        }

        private void SetupSchedulePanel()
        {
            var lblTitle = new Label { Text = "أوقات الدوام (للطبيب)", Font = UiFont.Bold, AutoSize = true, Dock = DockStyle.Top, Padding = new Padding(0,0,0,10) };
            
            var tlpSchedule = new TableLayoutPanel { Dock = DockStyle.Top, AutoSize = true, RowCount = 7, ColumnCount = 3 };
            tlpSchedule.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100));
            tlpSchedule.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70));
            tlpSchedule.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));

            string[] dayNames = { "الأحد", "الإثنين", "الثلاثاء", "الأربعاء", "الخميس", "الجمعة", "السبت" };
            DayOfWeek[] days = { DayOfWeek.Sunday, DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Wednesday, DayOfWeek.Thursday, DayOfWeek.Friday, DayOfWeek.Saturday };
            string[] shifts = { "دوام كامل (9 ص - 9 م)", "صباحي (9 ص - 3 م)", "مسائي (3 م - 9 م)" };

            for (int i = 0; i < 7; i++)
            {
                tlpSchedule.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));
                
                var chk = new CheckBox { Text = dayNames[i], Font = UiFont.Regular, Dock = DockStyle.Fill };
                var lblShift = new Label { Text = "الوردية:", TextAlign = System.Drawing.ContentAlignment.MiddleCenter, Font = UiFont.Regular, Dock = DockStyle.Fill };
                var cmbShift = new ComboBox { DropDownStyle = ComboBoxStyle.DropDownList, Font = UiFont.Regular, Dock = DockStyle.Fill, Enabled = false };
                cmbShift.Items.AddRange(shifts);
                cmbShift.SelectedIndex = 0;

                chk.CheckedChanged += (s, e) => {
                    cmbShift.Enabled = chk.Checked;
                };

                tlpSchedule.Controls.Add(chk, 0, i);
                tlpSchedule.Controls.Add(lblShift, 1, i);
                tlpSchedule.Controls.Add(cmbShift, 2, i);

                scheduleRows.Add(new DayScheduleRow { Day = days[i], ChkIsWorking = chk, CmbShift = cmbShift });
            }

            panelSchedule.Controls.Add(tlpSchedule);
            panelSchedule.Controls.Add(lblTitle);
        }

        private void SetupLogic()
        {
            this.Load += (s, e) => {
                cmbRole.Items.AddRange(new string[] { "مدير نظام", "طبيب", "استقبال" });
                cmbRole.SelectedIndex = 2; // Default to receptionist
            };

            cmbRole.SelectedIndexChanged += (s, e) => {
                bool isDoctor = cmbRole.Text == "طبيب";
                
                txtSalary.Enabled = !isDoctor;
                if (isDoctor) txtSalary.Text = "0";

                txtCommission.Enabled = isDoctor;
                if (!isDoctor) txtCommission.Text = "0";

                panelSchedule.Visible = isDoctor;
            };

            btnSave.Click += (s, e) => {
                if (string.IsNullOrWhiteSpace(txtFullName.Text) || string.IsNullOrWhiteSpace(txtUsername.Text) || cmbRole.SelectedIndex == -1)
                {
                    MessageBox.Show("الرجاء إدخال الاسم واسم المستخدم واختيار الصلاحية", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                UserRole role = UserRole.Receptionist;
                if (cmbRole.Text == "مدير نظام") role = UserRole.Admin;
                else if (cmbRole.Text == "طبيب") role = UserRole.Doctor;

                decimal baseSal = 0;
                decimal.TryParse(txtSalary.Text, out baseSal);

                decimal comm = 0;
                decimal.TryParse(txtCommission.Text, out comm);

                string newId = "U" + (DataStore.Users.Count + 1).ToString();

                var newUser = new User
                {
                    UserId = newId,
                    Username = txtUsername.Text.Trim(),
                    PasswordHash = txtPassword.Text, // Real app should hash this!
                    FullName = txtFullName.Text.Trim(),
                    Phone = txtPhone.Text.Trim(),
                    Role = role,
                    BaseSalary = baseSal
                };
                DataStore.Users.Add(newUser);

                if (role == UserRole.Doctor)
                {
                    string docId = "D" + (DataStore.Doctors.Count + 1).ToString();
                    DataStore.Doctors.Add(new Doctor
                    {
                        DoctorId = docId,
                        FullName = "د. " + newUser.FullName,
                        Specialty = "عام",
                        Phone = newUser.Phone,
                        CommissionPct = comm
                    });

                    foreach (var row in scheduleRows)
                    {
                        if (row.ChkIsWorking.Checked)
                        {
                            TimeSpan start = new TimeSpan(9, 0, 0);
                            TimeSpan end = new TimeSpan(21, 0, 0);
                            
                            if (row.CmbShift.SelectedIndex == 1) // صباحي
                            {
                                end = new TimeSpan(15, 0, 0);
                            }
                            else if (row.CmbShift.SelectedIndex == 2) // مسائي
                            {
                                start = new TimeSpan(15, 0, 0);
                            }

                            DataStore.DoctorSchedules.Add(new DoctorWorkSchedule
                            {
                                ScheduleId = DataStore.NextScheduleId(),
                                DoctorId = docId,
                                DayOfWeek = row.Day,
                                StartTime = start,
                                EndTime = end,
                                IsWorking = true
                            });
                        }
                    }
                }

                MessageBox.Show("تمت إضافة الموظف بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            };
        }
    }
}
