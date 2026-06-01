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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetupGrid();      // 1. تجهيز الأعمدة
            LoadPatients();
        }
        private void SetupGrid()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // إضافة الأعمدة الأساسية
            dataGridView1.Columns.Add("colNum", "رقم الحالة");
            dataGridView1.Columns.Add("colDate", "التاريخ");
            dataGridView1.Columns.Add("colTreatment", "العلاج");
            dataGridView1.Columns.Add("colDoctor", "الطبيب");
            dataGridView1.Columns.Add("colPrice", "السعر");
            dataGridView1.Columns.Add("colPaid", "المدفوع");
            dataGridView1.Columns.Add("colRemain", "الباقي");
        }
        private void LoadPatients()
        {
            var patientList = DataStore.Patients.Select(p => new {
                PatientId = p.PatientId,
                DisplayText = p.FullName // هنا العرض بالاسم فقط للسهولة في البحث
            }).ToList();

            comboBox1.DataSource = patientList;
            comboBox1.DisplayMember = "DisplayText";
            comboBox1.ValueMember = "PatientId";

            // إعدادات الفلترة والبحث الذكي
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;

            comboBox1.SelectedIndex = -1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {// نتحقق إن المستخدم اختار مريض فعلاً مش مجرد يكتب
            if (comboBox1.SelectedIndex != -1 && comboBox1.SelectedValue is int patientId)
            {
                LoadCases(patientId);
            }
            else
            {
                // لو مسح الكلام أو الاختيار فاضي، نظف الجدول
                dataGridView1.Rows.Clear();
            }
        }
        private void LoadCases(int patientId)
        {
            dataGridView1.Rows.Clear();

            // جلب الحالات الخاصة بهذا المريض فقط
            var records = DataStore.Cases.Where(c => c.PatientId == patientId).ToList();

            foreach (var c in records)
            {
                decimal paid = GetPaidAmount(c.CaseId); // تأكد أنها تمرر الـ ID الخاص بكل سطر
                decimal total = c.FinalPrice; // سعر هذه الحالة فقط
                decimal remain = total - paid; // الباقي لهذه الحالة فقط

                dataGridView1.Rows.Add(
                    c.CaseNumber,
                    c.OpenedDate.ToShortDateString(),
                    c.Treatment,
                    c.DoctorName,
                    total.ToString("N2"),
                    paid.ToString("N2"),
                    remain.ToString("N2")
                );
            }
        }
        private decimal GetPaidAmount(int caseId)
        {
            // 1. ابحث عن الفاتورة المرتبطة بهذه الحالة فقط
            var inv = DataStore.Invoices.FirstOrDefault(i => i.CaseId == caseId);

            if (inv == null) return 0;

            // 2. اجمع الدفعات المرتبطة برقم هذه الفاتورة فقط
            return DataStore.Payments
                .Where(p => p.InvoiceId == inv.InvoiceId)
                .Sum(p => p.AmountPaid);
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            // إذا ضغط المستخدم على زر Enter
            if (e.KeyCode == Keys.Enter)
            {
                // نتحقق أن هناك مريض مختار فعلاً
                if (comboBox1.SelectedValue != null && comboBox1.SelectedValue is int patientId)
                {
                    LoadCases(patientId);
                    // لمنع صوت الـ "تنبيه" المزعج عند ضغط Enter
                    e.SuppressKeyPress = true;
                }
            }

        }
    }
}
