using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DentalClinicProject.classes;
using DentalClinicProject.data;

namespace DentalClinicProject.UI
{
    public partial class DoctorServiceFormUI : System.Windows.Forms.Form
    {
        private readonly string _patientId;
        private readonly string _doctorId;
        private readonly string _appointmentId;
        private decimal _grandTotal = 0;

        private readonly string[] _treatmentList =
        {
            "كشف", "مراجعة", "حشو عادي", "حشوة تجميلية", "خلع عادي",
            "خلع جراحي", "تغليف سن (Zirconia/E-max)", "(علاج عصب (خلفي /طواحن",
            "علاج عصب امامي", "علاج لثة عميق", "تنظيف جير وتلميع", "فينير"
        };

        private Dictionary<string, decimal> treatmentPrices = new Dictionary<string, decimal>()
        {
            {"كشف", 40}, {"مراجعة", 0}, {"حشو عادي", 120}, {"حشوة تجميلية", 150},
            {"خلع عادي", 100}, {"خلع جراحي", 450}, {"تغليف سن (Zirconia/E-max)", 600},
            {"علاج عصب امامي", 500}, {"(علاج عصب (خلفي /طواحن", 750}, {"فينير", 1200},
            {"علاج لثة عميق", 400}, {"تنظيف جير وتلميع", 190}
        };

        public DoctorServiceFormUI(string patientId = "", string doctorId = "", string appointmentId = null)
        {
            _patientId = patientId;
            _doctorId = doctorId;
            _appointmentId = appointmentId;
            InitializeComponent();
            SetupLogic();
        }

        private void SetupLogic()
        {
            this.Load += (s, e) =>
            {
                var patient = DataStore.Patients.FirstOrDefault(p => p.PatientId == _patientId);
                if (patient != null)
                {
                    txtPatientName.Text = patient.FullName;
                    txtFileNumber.Text = patient.FileNumber;
                }

                cmbServiceName.Items.AddRange(_treatmentList);
                
                if (!string.IsNullOrEmpty(_appointmentId))
                {
                    var appt = DataStore.Appointments.FirstOrDefault(a => a.AppointmentId == _appointmentId);
                    if (appt != null)
                    {
                        cmbApptStatus.Text = appt.Status == AppointmentStatus.Completed ? "مكتمل" : "قيد الانتظار";
                    }
                }
            };

            cmbServiceName.SelectedIndexChanged += CmbServiceName_SelectedIndexChanged;
            txtPrice.TextChanged += CalculateFinalPrice;
            txtDiscount.TextChanged += CalculateFinalPrice;
            txtPrice.KeyPress += AllowOnlyNumbers;
            txtDiscount.KeyPress += AllowOnlyNumbers;
            txtToothNumber.KeyPress += AllowOnlyNumbers;
            chkDiscount.CheckedChanged += ChkDiscount_CheckedChanged;
            
            btnAddService.Click += BtnAddService_Click;
            btnSave.Click += BtnSave_Click;
            
            dgvServices.RowsRemoved += (s, e) => UpdateGrandTotal();
        }

        private void ChkDiscount_CheckedChanged(object sender, EventArgs e)
        {
            txtDiscount.Enabled = chkDiscount.Checked;
            if (!chkDiscount.Checked)
                txtDiscount.Text = "0";
            CalculateFinalPrice(sender, e);
        }

        private void CmbServiceName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string service = cmbServiceName.Text;
            if (treatmentPrices.ContainsKey(service))
            {
                txtPrice.Text = treatmentPrices[service].ToString();
            }
            if (service == "مراجعة")
            {
                txtPrice.Text = "0";
                txtPrice.ReadOnly = true;
            }
            else
            {
                txtPrice.ReadOnly = false;
            }
            CalculateFinalPrice(sender, e);
        }

        private void CalculateFinalPrice(object sender, EventArgs e)
        {
            decimal.TryParse(txtPrice.Text, out decimal price);
            decimal discount = 0;
            if (chkDiscount.Checked)
            {
                decimal.TryParse(txtDiscount.Text, out discount);
            }
            decimal finalPrice = price - discount;
            if (finalPrice < 0) finalPrice = 0;
            lblFinalPriceValue.Text = $"{finalPrice:F2} د.ل";
        }

        private static int ParseToothNumber(string text)
        {
            if (!int.TryParse(text?.Trim(), out int tooth) || tooth < 1)
                return 1;
            if (tooth > 32)
                return 32;
            return tooth;
        }

        private void AllowOnlyNumbers(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                e.Handled = true;
        }

        private void UpdateGrandTotal()
        {
            _grandTotal = 0;
            foreach (DataGridViewRow row in dgvServices.Rows)
            {
                if (row.Cells["colFinalPrice"].Value != null)
                {
                    decimal.TryParse(row.Cells["colFinalPrice"].Value.ToString(), out decimal rowFinal);
                    _grandTotal += rowFinal;
                }
            }
            lblGrandTotal.Text = $"الإجمالي: {_grandTotal:F2} د.ل";
        }

        private void BtnAddService_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbServiceName.Text))
            {
                MessageBox.Show("الرجاء اختيار نوع الخدمة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            decimal.TryParse(txtPrice.Text, out decimal price);
            decimal discount = 0;
            if (chkDiscount.Checked)
            {
                decimal.TryParse(txtDiscount.Text, out discount);
            }
            
            if (price <= 0 && cmbServiceName.Text != "مراجعة")
            {
                MessageBox.Show("الرجاء إدخال سعر صحيح", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal finalPrice = price - discount;
            if (finalPrice < 0) finalPrice = 0;

            int toothNumber = ParseToothNumber(txtToothNumber.Text);

            dgvServices.Rows.Add(
                cmbServiceName.Text,
                toothNumber.ToString(),
                $"{price:F2}",
                $"{discount:F2}",
                $"{finalPrice:F2}");
            UpdateGrandTotal();

            cmbServiceName.SelectedIndex = -1;
            txtPrice.Text = "0";
            txtToothNumber.Text = "1";
            chkDiscount.Checked = false;
            txtDiscount.Text = "0";
            lblFinalPriceValue.Text = "0.00 د.ل";
            cmbServiceName.Focus();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (dgvServices.Rows.Count == 0)
            {
                MessageBox.Show("لم يتم إضافة أي خدمات!", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var patient = DataStore.Patients.FirstOrDefault(p => p.PatientId == _patientId);
            var doctor = DataStore.Doctors.FirstOrDefault(d => d.DoctorId == _doctorId);

            foreach (DataGridViewRow row in dgvServices.Rows)
            {
                string serviceType = row.Cells["colName"].Value.ToString();
                decimal.TryParse(row.Cells["colPrice"].Value.ToString(), out decimal price);
                decimal.TryParse(row.Cells["colDiscount"].Value.ToString(), out decimal discount);
                decimal.TryParse(row.Cells["colFinalPrice"].Value.ToString(), out decimal finalPrice);
                int toothCount = 1;
                if (row.Cells["colToothNumber"].Value != null)
                    int.TryParse(row.Cells["colToothNumber"].Value.ToString(), out toothCount);
                if (toothCount < 1) toothCount = 1;
                if (toothCount > 32) toothCount = 32;

                var newCase = new Case
                {
                    CaseId = DataStore.NextCaseId(),
                    CaseNumber = $"CASE-{DateTime.Now.Year}-{DataStore.Cases.Count + 1001}",
                    PatientId = _patientId,
                    PatientFileNumber = patient?.FileNumber ?? "",
                    PatientName = patient?.FullName ?? "",
                    DoctorId = _doctorId,
                    DoctorName = doctor?.FullName ?? "",
                    Treatment = serviceType,
                    ToothCount = toothCount,
                    Price = price,
                    Discount = discount,
                    Notes = "تم إضافتها من قبل الطبيب",
                    Status = CaseStatus.Waiting,
                    OpenedDate = DateTime.Now,
                    SentToReception = true
                };
                DataStore.Cases.Add(newCase);
            }

            if (!string.IsNullOrEmpty(_appointmentId))
            {
                var appt = DataStore.Appointments.FirstOrDefault(a => a.AppointmentId == _appointmentId);
                if (appt != null)
                {
                    if (cmbApptStatus.Text == "مكتمل")
                        appt.Status = AppointmentStatus.Completed;
                }
            }

            MessageBox.Show($"تم إرسال {_grandTotal:F2} د.ل إلى الاستقبال بنجاح وإصدار الفاتورة", "تمت العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
