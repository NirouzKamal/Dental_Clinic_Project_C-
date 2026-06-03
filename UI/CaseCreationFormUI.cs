using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DentalClinicProject;
using DentalClinicProject.classes;
using DentalClinicProject.data;

namespace DentalClinicProject.UI
{
    public partial class CaseCreationFormUI : System.Windows.Forms.Form
    {
        private Case _currentCase;
        private CaseFormMode _currentMode = CaseFormMode.Create;
        private Invoice _invoice;

        private readonly string[] _treatmentList =
        {
            "كشف", "مراجعة", "حشو عادي", "حشوة تجميلية", "خلع عادي", "خلع جراحي",
            "تغليف سن (Zirconia/E-max)", "(علاج عصب (خلفي /طواحن", "علاج عصب امامي",
            "علاج لثة عميق", "تنظيف جير وتلميع", "فينير"
        };

        private Dictionary<string, decimal> treatmentPrices = new Dictionary<string, decimal>()
        {
            {"كشف", 40}, {"مراجعة", 0}, {"حشو عادي", 120}, {"حشوة تجميلية", 150},
            {"خلع عادي", 100}, {"خلع جراحي", 450}, {"تغليف سن (Zirconia/E-max)", 600},
            {"علاج عصب امامي", 500}, {"(علاج عصب (خلفي /طواحن", 750}, {"فينير", 1200},
            {"علاج لثة عميق", 400}, {"تنظيف جير وتلميع", 190}
        };

        public CaseCreationFormUI(Case selectedCase = null, CaseFormMode mode = CaseFormMode.Create)
        {
            InitializeComponent();
            _currentCase = selectedCase;
            _currentMode = mode;
            SetupLogic();
        }

        private void SetupLogic()
        {
            this.Load += (s, e) =>
            {
                LoadPatients();
                LoadDoctors();
                
                cmbService.Items.AddRange(_treatmentList);

                if (_currentMode != CaseFormMode.Create)
                {
                    LoadCaseData();
                    SetupFormMode();
                }
                
                if (_currentMode == CaseFormMode.Payment)
                {
                    LoadPaymentData();
                }
            };

            cmbService.SelectedIndexChanged += CmbService_SelectedIndexChanged;
            txtTotal.KeyPress += AllowOnlyNumbers;
            txtPaid.KeyPress += AllowOnlyNumbers;
            btnSave.Click += BtnSave_Click;

            cmbPatient.SelectedIndexChanged += (s, e) =>
            {
                if (_currentMode == CaseFormMode.Create)
                {
                    if (cmbPatient.SelectedValue != null)
                    {
                        string patientId = cmbPatient.SelectedValue.ToString();
                        DataStore.LoadAppointmentsFromDatabase();
                        var todayAppt = DataStore.Appointments.FirstOrDefault(a => a.PatientId == patientId && a.AppointmentDate.Date == DateTime.Today);
                        if (todayAppt != null)
                        {
                            cmbDoctor.SelectedValue = todayAppt.DoctorId;
                            cmbDoctor.Enabled = false;
                        }
                        else
                        {
                            cmbDoctor.SelectedIndex = -1;
                            cmbDoctor.Enabled = true;
                        }
                    }
                    else
                    {
                        cmbDoctor.SelectedIndex = -1;
                        cmbDoctor.Enabled = true;
                    }
                }
            };
        }

        private void LoadPatients()
        {
            DataStore.LoadPatientsFromDatabase();
            if (_currentMode == CaseFormMode.Create)
            {
                DataStore.LoadAppointmentsFromDatabase();
                var todayPatientIds = DataStore.Appointments
                    .Where(a => a.AppointmentDate.Date == DateTime.Today)
                    .Select(a => a.PatientId)
                    .Distinct()
                    .ToList();
                
                var todayPatients = DataStore.Patients
                    .Where(p => todayPatientIds.Contains(p.PatientId))
                    .Select(p => new { p.PatientId, DisplayText = $"{p.FileNumber} — {p.FullName}" })
                    .ToList();

                cmbPatient.DisplayMember = "DisplayText";
                cmbPatient.ValueMember = "PatientId";
                cmbPatient.DataSource = todayPatients;
            }
            else
            {
                cmbPatient.DisplayMember = "DisplayText";
                cmbPatient.ValueMember = "PatientId";
                cmbPatient.DataSource = DataStore.Patients
                    .Select(p => new { p.PatientId, DisplayText = $"{p.FileNumber} — {p.FullName}" }).ToList();
            }
            cmbPatient.SelectedIndex = -1;
        }

        private void LoadDoctors()
        {
            DataStore.LoadDoctorsFromDatabase();
            cmbDoctor.DisplayMember = "FullName";
            cmbDoctor.ValueMember = "DoctorId";
            cmbDoctor.DataSource = DataStore.Doctors.Where(d => d.IsActive).ToList();
            cmbDoctor.SelectedIndex = -1;
        }

        private void CmbService_SelectedIndexChanged(object sender, EventArgs e)
        {
            string service = cmbService.Text;
            if (treatmentPrices.ContainsKey(service))
            {
                txtTotal.Text = treatmentPrices[service].ToString();
            }

            if (service == "مراجعة")
            {
                txtTotal.Text = "0";
                txtPaid.Text = "0";
                txtPaid.Enabled = false;
            }
            else
            {
                txtPaid.Enabled = true;
            }
        }

        private void AllowOnlyNumbers(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                e.Handled = true;
        }

        private void LoadCaseData()
        {
            if (_currentCase == null) return;

            cmbPatient.SelectedValue = _currentCase.PatientId;
            cmbDoctor.SelectedValue = _currentCase.DoctorId;
            cmbService.Text = _currentCase.Treatment;
            txtTotal.Text = _currentCase.Price.ToString();
            txtNotes.Text = _currentCase.Notes;

            cmbPatient.Enabled = false;
            cmbDoctor.Enabled = false;
        }

        private void SetupFormMode()
        {
            if (_currentMode == CaseFormMode.DoctorEdit)
            {
                cmbPatient.Enabled = false;
                cmbDoctor.Enabled = false;
                txtPaid.Visible = false;
                lblPaid.Visible = false;
                btnSave.Text = "إنهاء الحالة";
            }
            else if (_currentMode == CaseFormMode.Payment)
            {
                cmbPatient.Enabled = false;
                cmbDoctor.Enabled = false;
                cmbService.Enabled = false;
                txtTotal.ReadOnly = true;
                txtPaid.Enabled = true;
                txtPaid.ReadOnly = false;
                btnSave.Text = "تأكيد الدفع";
            }
        }

        private decimal GetTotalPaid()
        {
            if (_invoice == null) return 0;
            return DataStore.Payments.Where(p => p.InvoiceId == _invoice.InvoiceId).Sum(p => p.AmountPaid);
        }

        private void LoadPaymentData()
        {
            if (_currentCase == null) return;
            _invoice = DataStore.Invoices.FirstOrDefault(i => i.CaseId == _currentCase.CaseId);
            if (_invoice == null) return;

            decimal paid = GetTotalPaid();
            decimal remaining = _currentCase.FinalPrice - paid;

            txtPaid.Text = remaining.ToString("F2");
            if (remaining <= 0)
            {
                btnSave.Enabled = false;
                btnSave.Text = "مسدد";
                txtPaid.ReadOnly = true;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (_currentMode == CaseFormMode.Payment)
            {
                SavePayment();
                return;
            }

            if (cmbPatient.SelectedValue == null || cmbDoctor.SelectedValue == null || cmbService.SelectedIndex == -1)
            {
                MessageBox.Show("الرجاء إكمال البيانات الأساسية", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal.TryParse(txtTotal.Text, out decimal price);
            if (price <= 0 && cmbService.Text != "مراجعة")
            {
                MessageBox.Show("الرجاء إدخال سعر صحيح", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string patientId = cmbPatient.SelectedValue.ToString();
            string doctorId = cmbDoctor.SelectedValue.ToString();
            var patient = DataStore.Patients.FirstOrDefault(p => p.PatientId == patientId);
            var doctor = DataStore.Doctors.FirstOrDefault(d => d.DoctorId == doctorId);

            if (_currentMode == CaseFormMode.DoctorEdit)
            {
                if (_currentCase == null) return;
                
                // End old case
                _currentCase.Status = CaseStatus.Completed;
                _currentCase.SentToReception = true;
                _currentCase.ClosedAt = DateTime.Now;
                DataStore.SaveCaseToDatabase(_currentCase);

                // Create new treatment case
                var treatmentCase = new Case
                {
                    CaseId = DataStore.NextCaseId(),
                    CaseNumber = "T-" + DateTime.Now.Ticks.ToString().Substring(10),
                    PatientId = _currentCase.PatientId,
                    PatientName = _currentCase.PatientName,
                    DoctorId = _currentCase.DoctorId,
                    DoctorName = _currentCase.DoctorName,
                    Treatment = cmbService.Text,
                    Price = price,
                    Status = CaseStatus.Completed,
                    OpenedDate = DateTime.Now,
                    SentToReception = true
                };
                DataStore.Cases.Add(treatmentCase);
                DataStore.SaveCaseToDatabase(treatmentCase);

                var newInvoice = new Invoice
                {
                    InvoiceId = DataStore.NextInvoiceId(),
                    CaseId = treatmentCase.CaseId,
                    PatientId = treatmentCase.PatientId,
                    TotalAmount = treatmentCase.FinalPrice,
                    IssuedDate = DateTime.Now
                };
                DataStore.Invoices.Add(newInvoice);
                DataStore.SaveInvoiceToDatabase(newInvoice);

                MessageBox.Show("تم تسجيل العلاج بنجاح", "نجاح");
                this.DialogResult = DialogResult.OK;
                this.Close();
                return;
            }

            // Create new case
            var newCase = new Case
            {
                CaseId = DataStore.NextCaseId(),
                CaseNumber = $"CASE-{DateTime.Now.Year}-{DataStore.Cases.Count + 1001}",
                PatientId = patientId,
                PatientFileNumber = patient?.FileNumber ?? "",
                PatientName = patient?.FullName ?? "",
                DoctorId = doctorId,
                DoctorName = doctor?.FullName ?? "",
                Treatment = cmbService.Text,
                Price = price,
                Notes = txtNotes.Text.Trim(),
                Status = CaseStatus.Waiting,
                OpenedDate = DateTime.Now,
                SentToReception = false
            };
            DataStore.Cases.Add(newCase);
            DataStore.SaveCaseToDatabase(newCase);

            var invoice = new Invoice
            {
                InvoiceId = DataStore.NextInvoiceId(),
                CaseId = newCase.CaseId,
                PatientId = patientId,
                TotalAmount = price,
                IssuedDate = DateTime.Now,
                IsPaid = false
            };
            DataStore.Invoices.Add(invoice);
            DataStore.SaveInvoiceToDatabase(invoice);

            decimal.TryParse(txtPaid.Text, out decimal paidAmount);
            if (paidAmount > 0)
            {
                var payment = new Payment
                {
                    PaymentId = DataStore.NextPaymentId(),
                    InvoiceId = invoice.InvoiceId,
                    AmountPaid = paidAmount,
                    PaymentDate = DateTime.Now
                };
                DataStore.Payments.Add(payment);
                if (paidAmount >= invoice.TotalAmount) invoice.IsPaid = true;
                
                DataStore.SavePaymentToDatabase(payment);
                DataStore.SaveInvoiceToDatabase(invoice);
            }

            MessageBox.Show("تم إنشاء الحالة بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void SavePayment()
        {
            if (_invoice == null) return;
            decimal.TryParse(txtPaid.Text, out decimal amount);
            
            if (amount <= 0 && _currentCase?.Treatment != "مراجعة")
            {
                MessageBox.Show("أدخل مبلغاً صحيحاً", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var payment = new Payment
            {
                PaymentId = DataStore.NextPaymentId(),
                InvoiceId = _invoice.InvoiceId,
                AmountPaid = amount,
                PaymentDate = DateTime.Now
            };
            DataStore.Payments.Add(payment);
            DataStore.SavePaymentToDatabase(payment);

            _invoice.IsPaid = GetTotalPaid() >= _invoice.TotalAmount;
            DataStore.SaveInvoiceToDatabase(_invoice);

            MessageBox.Show("تم تسجيل الدفعة بنجاح", "تم الدفع", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
