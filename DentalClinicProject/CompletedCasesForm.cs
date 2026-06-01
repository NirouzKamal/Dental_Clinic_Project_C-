using DentalClinicProject.data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalClinicProject
{
    public partial class CompletedCasesForm : Form
    {
        public CompletedCasesForm()
        {
            InitializeComponent();
        }

        private void CompletedCasesForm_Load(object sender, EventArgs e)
        {
            SetupGrid();
            LoadCompletedCases();
        }
        private void SetupGrid()
        {
            dgvCases.Columns.Clear();
            dgvCases.AutoGenerateColumns = false;
            dgvCases.ReadOnly = true;
            dgvCases.AllowUserToAddRows = false;
            dgvCases.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCases.RowHeadersVisible = false;
            dgvCases.BackgroundColor = Color.White;
            dgvCases.BorderStyle = BorderStyle.None;
            dgvCases.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCases.RowTemplate.Height = 38;

            // تنسيق الهيدر
            dgvCases.EnableHeadersVisualStyles = false;
            dgvCases.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);
            dgvCases.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvCases.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvCases.ColumnHeadersHeight = 42;
            dgvCases.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 250, 255);
            dgvCases.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // الأعمدة

            dgvCases.Columns.Clear();
            dgvCases.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // توزيع الأوزان (FillWeight) بحيث المجموع يكون 100
            dgvCases.Columns.Add(new DataGridViewTextBoxColumn { Name = "colFileNum", HeaderText = "رقم الملف", FillWeight = 10 });
            dgvCases.Columns.Add(new DataGridViewTextBoxColumn { Name = "colPatient", HeaderText = "المريض", FillWeight = 20 });
            dgvCases.Columns.Add(new DataGridViewTextBoxColumn { Name = "colDoctor", HeaderText = "الطبيب", FillWeight = 15 });
            dgvCases.Columns.Add(new DataGridViewTextBoxColumn { Name = "colTreatment", HeaderText = "العلاج", FillWeight = 15 });
            dgvCases.Columns.Add(new DataGridViewTextBoxColumn { Name = "colTotal", HeaderText = "الإجمالي", FillWeight = 10 });
            dgvCases.Columns.Add(new DataGridViewTextBoxColumn { Name = "colPaid", HeaderText = "المدفوع", FillWeight = 10 });
            dgvCases.Columns.Add(new DataGridViewTextBoxColumn { Name = "colRemain", HeaderText = "المتبقي", FillWeight = 10 });
            dgvCases.Columns.Add(new DataGridViewTextBoxColumn { Name = "colStatus", HeaderText = "الحالة", FillWeight = 10 });
            if (dgvCases.Columns.Contains("colCaseNum"))
                dgvCases.Columns["colCaseNum"].Visible = false;
            // تلوين عمود "المتبقي" (العمود رقم 6)
            dgvCases.CellFormatting += (s, e) =>
            {
                if (dgvCases.Columns[e.ColumnIndex].Name == "colRemain" && e.Value != null)
                {
                    if (decimal.TryParse(e.Value.ToString(), out decimal v))
                    {
                        e.CellStyle.ForeColor = v > 0 ? Color.Red : Color.Green;
                        e.CellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                    }
                }
            };

            // double click → فورم الدفع
            dgvCases.CellDoubleClick += DgvCases_CellDoubleClick;
            
        }
        public void LoadCompletedCases()
        {
            dgvCases.Rows.Clear();

            // 1. التعديل المنطقي: جلب كل الحالات التي علمها الدكتور كـ "مرسلة للاستقبال"
            // بغض النظر عن الطبيب، لأن موظف الاستقبال يحتاج رؤية الكل.
            var cases = DataStore.Cases
                .Where(c => c.SentToReception == true)
                .OrderByDescending(c => c.ClosedAt) // ترتيب حسب وقت الانتهاء الأحدث
                .ToList();

            foreach (var c in cases)
            {
                // 2. حساب المبالغ المالية للحالة
                decimal paid = GetPaid(c.CaseId);
                decimal remaining = c.FinalPrice - paid;

                // 3. إضافة الصف بالترتيب الصحيح المطابق للأعمدة (SetupGrid)
                int row = dgvCases.Rows.Add(
                    c.PatientFileNumber,          // عمود رقم الملف
                    c.PatientName,                // عمود المريض
                    c.DoctorName,                


                    c.Treatment,                  // عمود العلاج
                    c.FinalPrice.ToString("N2"),  // عمود الإجمالي
                    paid.ToString("N2"),          // عمود المدفوع
                    remaining.ToString("N2"),     // عمود المتبقي
                    c.Status.ToString()           // عمود الحالة
                );

                // 4. تخزين الـ ID في الـ Tag لاستخدامه عند النقر المزدوج (مهم جداً)
                dgvCases.Rows[row].Tag = c.CaseId;

                // لو مسدد بالكامل → لون الصف أخضر فاتح
                if (remaining <= 0)
                {
                    dgvCases.Rows[row].DefaultCellStyle.BackColor = Color.FromArgb(220, 255, 220);
                }
            }
        }
        private void DgvCases_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int caseId = (int)dgvCases.Rows[e.RowIndex].Tag;
            var selectedCase = DataStore.Cases.FirstOrDefault(c => c.CaseId == caseId);
            if (selectedCase == null) return;

            // ← غيرنا من CaseCreation إلى PaymentForm
            var payForm =
            new CaseCreation(selectedCase, CaseFormMode.Payment);
            payForm.ShowDialog();

            LoadCompletedCases(); // حدث الجدول بعد الدفع
        }
        private decimal GetPaid(int caseId)
        {
            var inv = DataStore.Invoices.FirstOrDefault(i => i.CaseId == caseId);
            if (inv == null) return 0;
            return DataStore.Payments
                .Where(p => p.InvoiceId == inv.InvoiceId)
                .Sum(p => p.AmountPaid);
        }

        private void btnClose_Click(object sender, EventArgs e) => this.Close();

        private void dgvCases_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
