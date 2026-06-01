using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DentalClinicProject.classes;
using DentalClinicProject.data;

namespace DentalClinicProject.UI
{
    public partial class RevenuesControlUI : System.Windows.Forms.UserControl
    {
        public RevenuesControlUI()
        {
            InitializeComponent();
            SetupLogic();
        }

        private void SetupLogic()
        {
            dtpFrom.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpTo.Value = DateTime.Now.Date.AddDays(1).AddTicks(-1);

            this.Load += (s, e) => {
                LoadDoctors();
                CalculateFinancials();
            };

            dtpFrom.ValueChanged += (s, e) => CalculateFinancials();
            dtpTo.ValueChanged += (s, e) => CalculateFinancials();
            cmbDoctor.SelectedIndexChanged += (s, e) => CalculateFinancials();
            txtSearch.TextChanged += (s, e) => CalculateFinancials();
            
            rdoIncome.CheckedChanged += (s, e) => CalculateFinancials();
            rdoExpenses.CheckedChanged += (s, e) => CalculateFinancials();

            txtSearch.Enter += (s, e) => { if (txtSearch.Text == "ابحث بالرقم أو الاسم...") txtSearch.Text = ""; };
            txtSearch.Leave += (s, e) => { if (string.IsNullOrWhiteSpace(txtSearch.Text)) txtSearch.Text = "ابحث بالرقم أو الاسم..."; };
        }

        private void LoadDoctors()
        {
            cmbDoctor.DataSource = null;
            var doctors = DataStore.Doctors.ToList();
            doctors.Insert(0, new Doctor { DoctorId = "", FullName = "الكل" });
            cmbDoctor.DataSource = doctors;
            cmbDoctor.DisplayMember = "FullName";
            cmbDoctor.ValueMember = "DoctorId";
            cmbDoctor.SelectedIndex = 0;
        }

        private void SetupGridColumns()
        {
            dgvRevenues.Columns.Clear();
            if (rdoIncome.Checked)
            {
                dgvRevenues.Columns.Add("colFileNum", "رقم الملف");
                dgvRevenues.Columns.Add("colPatientName", "اسم الحالة");
                dgvRevenues.Columns.Add("colDoctor", "اسم الطبيب");
                dgvRevenues.Columns.Add("colTreatment", "العلاج");
                dgvRevenues.Columns.Add("colPaid", "المدفوع");
            }
            else
            {
                dgvRevenues.Columns.Add("colStaffName", "الموظف");
                dgvRevenues.Columns.Add("colRole", "الدور");
                dgvRevenues.Columns.Add("colMonthYear", "عن شهر");
                dgvRevenues.Columns.Add("colBase", "الأساسي");
                dgvRevenues.Columns.Add("colCommission", "العمولة");
                dgvRevenues.Columns.Add("colTotal", "الإجمالي المصروف");
                dgvRevenues.Columns.Add("colIssueDate", "تاريخ الصرف");
            }
        }

        private void CalculateFinancials()
        {
            SetupGridColumns();
            dgvRevenues.Rows.Clear();

            DateTime start = dtpFrom.Value.Date;
            DateTime end = dtpTo.Value.Date.AddDays(1).AddTicks(-1);
            string search = txtSearch.Text == "ابحث بالرقم أو الاسم..." ? "" : txtSearch.Text.Trim();
            string selectedDoctorId = cmbDoctor.SelectedItem is Doctor d ? d.DoctorId : "";

            decimal totalIncome = 0;
            decimal totalExpenses = 0;
            decimal totalPendingDues = 0;

            // 1. Calculate Income & Pending Dues
            var cases = DataStore.Cases.Where(c => c.OpenedDate >= start && c.OpenedDate <= end).ToList();
            if (!string.IsNullOrEmpty(selectedDoctorId)) cases = cases.Where(c => c.DoctorId == selectedDoctorId).ToList();

            foreach (var c in cases)
            {
                var invoice = DataStore.Invoices.FirstOrDefault(i => i.CaseId == c.CaseId);
                decimal paidForCase = 0;

                if (invoice != null)
                {
                    paidForCase = DataStore.Payments.Where(p => p.InvoiceId == invoice.InvoiceId).Sum(p => p.AmountPaid);
                }

                totalIncome += paidForCase;

                // Pending Dues
                var doc = DataStore.Doctors.FirstOrDefault(docItem => docItem.DoctorId == c.DoctorId);
                if (doc != null && c.Status == CaseStatus.Completed)
                {
                    totalPendingDues += paidForCase * doc.CommissionPct;
                }

                // Add to Income grid
                if (rdoIncome.Checked)
                {
                    if (string.IsNullOrEmpty(search) || 
                        (c.PatientName != null && c.PatientName.Contains(search)) || 
                        (c.PatientFileNumber != null && c.PatientFileNumber.Contains(search)))
                    {
                        dgvRevenues.Rows.Add(c.PatientFileNumber, c.PatientName, c.DoctorName, c.Treatment, paidForCase.ToString("F2"));
                    }
                }
            }

            // 2. Calculate Expenses
            var payrolls = DataStore.PayrollRecords.Where(pr => pr.IssueDate >= start && pr.IssueDate <= end).ToList();
            
            if (!string.IsNullOrEmpty(selectedDoctorId)) 
                payrolls = payrolls.Where(pr => pr.UserId == selectedDoctorId).ToList();

            foreach (var pr in payrolls)
            {
                totalExpenses += pr.NetPay;

                if (rdoExpenses.Checked)
                {
                    if (string.IsNullOrEmpty(search) || (pr.FullName != null && pr.FullName.Contains(search)))
                    {
                        dgvRevenues.Rows.Add(
                            pr.FullName, 
                            pr.Role, 
                            $"{pr.Month}/{pr.Year}", 
                            pr.BaseSalaryPaid.ToString("F2"), 
                            pr.CommissionPaid.ToString("F2"), 
                            pr.NetPay.ToString("F2"),
                            pr.IssueDate.ToString("yyyy/MM/dd")
                        );
                    }
                }
            }

            // Update KPIs
            lblTotalIncomeValue.Text = totalIncome.ToString("F2") + " د.ل";
            lblTotalExpensesValue.Text = totalExpenses.ToString("F2") + " د.ل";
            
            decimal netProfit = totalIncome - totalExpenses;
            lblNetProfitValue.Text = netProfit.ToString("F2") + " د.ل";
            lblNetProfitValue.ForeColor = netProfit >= 0 ? Color.FromArgb(40, 167, 69) : Color.FromArgb(220, 53, 69); // Success / Danger color

            lblPendingDuesValue.Text = totalPendingDues.ToString("F2") + " د.ل";
        }
    }
}
