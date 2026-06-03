using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DentalClinicProject.classes;
using DentalClinicProject.data;

namespace DentalClinicProject.UI
{
    public partial class PayrollManagementFormUI : System.Windows.Forms.Form
    {
        private class PayrollRowData
        {
            public User Employee { get; set; }
            public string RoleName { get; set; }
            public decimal BaseSalary { get; set; }
            public decimal Commission { get; set; }
            public decimal TotalPay { get; set; }
            public bool IsPaid { get; set; }
        }

        private List<PayrollRowData> _currentPayrollData = new List<PayrollRowData>();

        public PayrollManagementFormUI()
        {
            InitializeComponent();
            SetupLogic();
        }

        private void SetupLogic()
        {
            this.Load += (s, e) =>
            {
                // Populate Months
                for (int i = 1; i <= 12; i++)
                    cmbMonth.Items.Add(i.ToString("D2"));
                cmbMonth.SelectedItem = DateTime.Now.Month.ToString("D2");

                // Populate Years
                int currentYear = DateTime.Now.Year;
                for (int i = currentYear - 5; i <= currentYear + 5; i++)
                    cmbYear.Items.Add(i.ToString());
                cmbYear.SelectedItem = currentYear.ToString();

                CalculatePayroll();
            };

            btnCalculate.Click += (s, e) => CalculatePayroll();
            btnPaySelected.Click += BtnPaySelected_Click;
        }

        private void CalculatePayroll()
        {
            if (cmbMonth.SelectedItem == null || cmbYear.SelectedItem == null) return;

            int month = int.Parse(cmbMonth.SelectedItem.ToString());
            int year = int.Parse(cmbYear.SelectedItem.ToString());

            _currentPayrollData.Clear();

            var activeUsers = DataStore.Users.Where(u => u.IsActive).ToList();

            foreach (var user in activeUsers)
            {
                var roleName = user.Role == UserRole.Doctor ? "طبيب" : (user.Role == UserRole.Admin ? "مسؤول" : "استقبال");
                decimal baseSal = user.BaseSalary;
                decimal commissionEarned = 0;

                if (user.Role == UserRole.Doctor)
                {
                    var doctor = DataStore.Doctors.FirstOrDefault(d => d.FullName == "د. " + user.FullName || d.FullName == user.FullName || d.UserId == user.UserId);
                    if (doctor != null)
                    {
                        var docCases = DataStore.Cases.Where(c => 
                            c.DoctorId == doctor.DoctorId && 
                            c.Status == CaseStatus.Completed && 
                            c.OpenedDate.Month == month && 
                            c.OpenedDate.Year == year).ToList();

                        foreach (var c in docCases)
                        {
                            var invoice = DataStore.Invoices.FirstOrDefault(inv => inv.CaseId == c.CaseId);
                            if (invoice != null)
                            {
                                decimal paidAmount = DataStore.Payments.Where(p => p.InvoiceId == invoice.InvoiceId).Sum(p => p.AmountPaid);
                                commissionEarned += paidAmount * (doctor.CommissionPct / 100.0m);
                            }
                        }
                    }
                }

                decimal total = baseSal + commissionEarned;
                bool isPaid = DataStore.PayrollRecords.Any(pr => pr.UserId == user.UserId && pr.Month == month && pr.Year == year);

                _currentPayrollData.Add(new PayrollRowData
                {
                    Employee = user,
                    RoleName = roleName,
                    BaseSalary = baseSal,
                    Commission = commissionEarned,
                    TotalPay = total,
                    IsPaid = isPaid
                });
            }

            BindGrid();
        }

        private void BindGrid()
        {
            dgvPayroll.Rows.Clear();
            foreach (var data in _currentPayrollData)
            {
                var statusText = data.IsPaid ? "مصروف" : "غير مصروف";
                dgvPayroll.Rows.Add(
                    data.Employee.FullName ?? data.Employee.Username,
                    data.RoleName,
                    data.BaseSalary.ToString("F2"),
                    data.Commission.ToString("F2"),
                    data.TotalPay.ToString("F2"),
                    statusText
                );
            }
        }

        private void BtnPaySelected_Click(object sender, EventArgs e)
        {
            if (dgvPayroll.SelectedRows.Count == 0)
            {
                MessageBox.Show("الرجاء تحديد موظف من القائمة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedIndex = dgvPayroll.SelectedRows[0].Index;
            var data = _currentPayrollData[selectedIndex];

            if (data.IsPaid)
            {
                MessageBox.Show("تم صرف الراتب لهذا الموظف مسبقاً في هذا الشهر!", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (data.TotalPay <= 0)
            {
                MessageBox.Show("لا يوجد مستحقات لهذا الموظف في هذا الشهر", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int month = int.Parse(cmbMonth.SelectedItem.ToString());
            int year = int.Parse(cmbYear.SelectedItem.ToString());

            var confirm = MessageBox.Show($"هل أنت متأكد من صرف مستحقات بقيمة {data.TotalPay:F2} د.ل للموظف {data.Employee.FullName}؟", "تأكيد الصرف", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                var record = new PayrollRecord
                {
                    PayrollId = DataStore.NextPayrollId(),
                    UserId = data.Employee.UserId,
                    FullName = data.Employee.FullName ?? data.Employee.Username,
                    Role = data.RoleName,
                    Month = month,
                    Year = year,
                    BaseSalaryPaid = data.BaseSalary,
                    CommissionPaid = data.Commission,
                    Deductions = 0,
                    NetPay = data.TotalPay,
                    IssueDate = DateTime.Now
                };

                DataStore.PayrollRecords.Add(record);
                DataStore.SavePayrollToDatabase(record);
                MessageBox.Show("تم الصرف بنجاح وتم تسجيله كمصروف في حسابات العيادة.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CalculatePayroll(); // Refresh grid
            }
        }
    }
}
