using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DentalClinicProject.classes;
using DentalClinicProject.data;
using DentalClinicProject.Reports;

namespace DentalClinicProject.UI
{
    public partial class AssignPatientFormUI : System.Windows.Forms.Form
    {
        private const string VisitKashf = "كشف";
        private const string VisitMoraja = "مراجعة";

        private List<Patient> _allPatients = new List<Patient>();
        private bool _suppressPatientSearch;

        private sealed class PatientComboItem
        {
            public string PatientId { get; set; }
            public string DisplayText { get; set; }

            public override string ToString() => DisplayText ?? "";
        }

        public AssignPatientFormUI()
        {
            InitializeComponent();
            SetupLogic();
        }

        private void SetupLogic()
        {
            this.Load += (s, e) =>
            {
                LoadPatients();
                LoadDoctors();
                LoadVisitTypes();
                ApplyVisitTypeUi();
            };

            cmbPatient.TextUpdate += CmbPatient_TextUpdate;
            cmbPatient.SelectedIndexChanged += CmbPatient_SelectedIndexChanged;
            cmbPatient.SelectionChangeCommitted += CmbPatient_SelectionChangeCommitted;
            cmbPatient.Leave += CmbPatient_Leave;
            cmbVisitType.SelectedIndexChanged += (s, e) => ApplyVisitTypeUi();
            txtPrice.KeyPress += AllowDecimalInput;
            txtPaid.KeyPress += AllowDecimalInput;
            btnSave.Click += BtnSave_Click;
            btnPatientRecords.Click += BtnPatientRecords_Click;
        }

        private void LoadPatients()
        {
            _allPatients = DataStore.Patients.ToList();
            ClearPatientComboItems();
        }

        private void ClearPatientComboItems()
        {
            _suppressPatientSearch = true;
            try
            {
                cmbPatient.BeginUpdate();
                cmbPatient.Items.Clear();
                cmbPatient.Text = "";
                cmbPatient.SelectedIndex = -1;
            }
            finally
            {
                cmbPatient.EndUpdate();
                _suppressPatientSearch = false;
            }
        }

        private void LoadDoctors()
        {
            cmbDoctor.DisplayMember = "FullName";
            cmbDoctor.ValueMember = "DoctorId";
            cmbDoctor.DataSource = DataStore.Doctors
                .Where(d => d.IsActive)
                .ToList();
            cmbDoctor.SelectedIndex = -1;
        }

        private void LoadVisitTypes()
        {
            cmbVisitType.Items.Clear();
            cmbVisitType.Items.AddRange(new object[] { VisitKashf, VisitMoraja });
            cmbVisitType.SelectedIndex = -1;
        }

        private void RefreshPatientCombo(string filter)
        {
            string term = (filter ?? "").Trim();
            string preserveText = cmbPatient.Text ?? "";
            int preserveStart = cmbPatient.SelectionStart;
            int preserveLength = cmbPatient.SelectionLength;

            _suppressPatientSearch = true;
            try
            {
                cmbPatient.BeginUpdate();
                cmbPatient.Items.Clear();

                if (string.IsNullOrEmpty(term))
                    return;

                var matches = _allPatients
                    .Where(p =>
                        (p.FullName != null && p.FullName.IndexOf(term, StringComparison.OrdinalIgnoreCase) >= 0)
                        || (p.FileNumber != null && p.FileNumber.IndexOf(term, StringComparison.OrdinalIgnoreCase) >= 0))
                    .Take(50)
                    .Select(p => new PatientComboItem
                    {
                        PatientId = p.PatientId,
                        DisplayText = $"{p.FileNumber} — {p.FullName}"
                    })
                    .ToList();

                foreach (var item in matches)
                    cmbPatient.Items.Add(item);

                cmbPatient.Text = preserveText;
                cmbPatient.SelectionStart = Math.Min(preserveStart, cmbPatient.Text.Length);
                cmbPatient.SelectionLength = preserveLength;

                if (matches.Count > 0 && !cmbPatient.DroppedDown)
                    cmbPatient.DroppedDown = true;
            }
            finally
            {
                cmbPatient.EndUpdate();
                _suppressPatientSearch = false;
            }
        }

        private void CmbPatient_TextUpdate(object sender, EventArgs e)
        {
            if (_suppressPatientSearch || cmbPatient.IsDisposed)
                return;

            string typed = cmbPatient.Text ?? "";
            BeginInvoke(new Action(() =>
            {
                if (_suppressPatientSearch || cmbPatient.IsDisposed)
                    return;
                if (!string.Equals(cmbPatient.Text, typed, StringComparison.Ordinal))
                    return;
                RefreshPatientCombo(typed);
            }));
        }

        private Patient GetPatientFromComboSelection()
        {
            if (cmbPatient.SelectedItem is PatientComboItem selected)
                return _allPatients.FirstOrDefault(p => p.PatientId == selected.PatientId);
            return null;
        }

        private void CmbPatient_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ApplySelectedPatient();
        }

        private void CmbPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPatient.DroppedDown)
                return;
            ApplySelectedPatient();
        }

        private void CmbPatient_Leave(object sender, EventArgs e)
        {
            TryMatchPatientFromTypedText();
        }

        private void TryMatchPatientFromTypedText()
        {
            var fromSelection = GetPatientFromComboSelection();
            if (fromSelection != null)
            {
                ApplyPatientDetails(fromSelection);
                return;
            }

            string text = (cmbPatient.Text ?? "").Trim();
            if (string.IsNullOrEmpty(text))
            {
                ClearPatientFields();
                return;
            }

            var patient = _allPatients.FirstOrDefault(p =>
                string.Equals(p.FullName, text, StringComparison.OrdinalIgnoreCase)
                || string.Equals(p.FileNumber, text, StringComparison.OrdinalIgnoreCase)
                || text.Equals($"{p.FileNumber} — {p.FullName}", StringComparison.OrdinalIgnoreCase));

            if (patient != null)
                ApplyPatientDetails(patient);
        }

        private void ApplySelectedPatient()
        {
            var patient = GetPatientFromComboSelection();
            if (patient == null)
            {
                ClearPatientFields();
                return;
            }

            ApplyPatientDetails(patient);
        }

        private void ApplyPatientDetails(Patient patient)
        {
            if (patient == null)
            {
                ClearPatientFields();
                return;
            }

            _suppressPatientSearch = true;
            try
            {
                cmbPatient.Text = patient.FullName ?? "";
                txtFileNumber.Text = patient.FileNumber ?? "";
                txtTotalDebt.Text = $"{GetPatientTotalDebt(patient.PatientId):F2} د.ل";
            }
            finally
            {
                _suppressPatientSearch = false;
            }
        }

        private void ClearPatientFields()
        {
            txtFileNumber.Text = "";
            txtTotalDebt.Text = "0.00 د.ل";
        }

        private static decimal GetPatientTotalDebt(string patientId)
        {
            var patientInvoices = DataStore.Invoices.Where(i => i.PatientId == patientId).ToList();
            decimal totalDebt = 0;
            foreach (var inv in patientInvoices)
            {
                decimal paidForThisInv = DataStore.Payments
                    .Where(p => p.InvoiceId == inv.InvoiceId)
                    .Sum(p => p.AmountPaid);
                totalDebt += inv.TotalAmount - paidForThisInv;
            }
            return totalDebt < 0 ? 0 : totalDebt;
        }

        private void ApplyVisitTypeUi()
        {
            bool isFollowUp = cmbVisitType.Text == VisitMoraja;
            bool showPrice = !isFollowUp && cmbVisitType.SelectedIndex >= 0;

            lblPrice.Visible = showPrice;
            txtPrice.Visible = showPrice;
            lblPaid.Visible = showPrice;
            txtPaid.Visible = showPrice;

            if (cmbVisitType.SelectedIndex < 0)
            {
                btnSave.Text = "إنشاء الحالة";
                return;
            }

            btnSave.Text = isFollowUp ? "إنشاء الحالة" : "طباعة إيصال الكشف";

            if (isFollowUp)
            {
                txtPrice.Text = "0";
                txtPaid.Text = "0";
                txtPrice.ReadOnly = true;
                txtPaid.ReadOnly = true;
            }
            else
            {
                txtPrice.Text = ClinicServicePricing.GetPrice(VisitKashf).ToString("0.##");
                txtPrice.ReadOnly = true;
                txtPaid.ReadOnly = false;
                if (string.IsNullOrWhiteSpace(txtPaid.Text))
                    txtPaid.Text = "0";
            }
        }

        private static void AllowDecimalInput(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;
            if (char.IsDigit(e.KeyChar))
                return;
            if (e.KeyChar == '.' && sender is TextBox box && box.Text.IndexOf('.') < 0)
                return;
            e.Handled = true;
        }

        private static decimal ParseDecimal(string text)
        {
            decimal.TryParse(text, out decimal result);
            return result;
        }

        private Patient ResolveSelectedPatient()
        {
            var patient = GetPatientFromComboSelection();
            if (patient != null)
                return patient;

            TryMatchPatientFromTypedText();
            return GetPatientFromComboSelection()
                ?? _allPatients.FirstOrDefault(p =>
                    string.Equals(p.FullName, (cmbPatient.Text ?? "").Trim(), StringComparison.OrdinalIgnoreCase));
        }

        private void BtnPatientRecords_Click(object sender, EventArgs e)
        {
            using (var frm = new Form
            {
                Text = "سجل المريض",
                Size = new Size(1100, 650),
                StartPosition = FormStartPosition.CenterParent,
                RightToLeft = RightToLeft.Yes,
                RightToLeftLayout = true,
                BackColor = Color.White
            })
            {
                frm.Controls.Add(new PatientRecordsControlUI { Dock = DockStyle.Fill });
                frm.ShowDialog(this);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var patient = ResolveSelectedPatient();
            if (patient == null)
            {
                MessageBox.Show("الرجاء اختيار أو كتابة اسم مريض صحيح", "تنبيه",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbPatient.Focus();
                return;
            }
            if (cmbDoctor.SelectedValue == null)
            {
                MessageBox.Show("الرجاء اختيار الطبيب", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbDoctor.Focus();
                return;
            }
            if (cmbVisitType.SelectedIndex == -1)
            {
                MessageBox.Show("الرجاء اختيار نوع الزيارة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbVisitType.Focus();
                return;
            }

            string patientId = patient.PatientId;
            string doctorId = cmbDoctor.SelectedValue.ToString();
            var doctor = DataStore.Doctors.FirstOrDefault(d => d.DoctorId == doctorId);

            string visitType = cmbVisitType.Text;
            decimal price = visitType == VisitMoraja ? 0 : ParseDecimal(txtPrice.Text);
            decimal paidAmount = visitType == VisitMoraja ? 0 : ParseDecimal(txtPaid.Text);

            if (price <= 0 && visitType != VisitMoraja)
            {
                MessageBox.Show("الرجاء التحقق من سعر الكشف", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime visitDateTime = DateTime.Now;

            var newCase = new Case
            {
                CaseId = DataStore.NextCaseId(),
                CaseNumber = patient.FileNumber ?? "",
                PatientId = patientId,
                PatientFileNumber = patient.FileNumber ?? "",
                PatientName = patient.FullName ?? "",
                DoctorId = doctorId,
                DoctorName = doctor?.FullName ?? "",
                Treatment = visitType,
                Price = price,
                Discount = 0,
                Notes = "",
                Status = CaseStatus.Waiting,
                OpenedDate = visitDateTime,
                Date = visitDateTime.Date,
                SentToReception = false
            };
            DataStore.Cases.Add(newCase);

            var invoice = new Invoice
            {
                InvoiceId = DataStore.NextInvoiceId(),
                CaseId = newCase.CaseId,
                PatientId = patientId,
                TotalAmount = price,
                IssuedDate = visitDateTime,
                IsPaid = false
            };
            DataStore.Invoices.Add(invoice);

            if (paidAmount > 0)
            {
                DataStore.Payments.Add(new Payment
                {
                    PaymentId = DataStore.NextPaymentId(),
                    InvoiceId = invoice.InvoiceId,
                    AmountPaid = paidAmount,
                    PaymentDate = visitDateTime
                });
                if (paidAmount >= invoice.TotalAmount)
                    invoice.IsPaid = true;
            }

            if (visitType == VisitKashf)
            {
                var printModel = KashfReceiptPrintModel.FromCase(newCase, paidAmount, visitDateTime);
                CrystalReceiptPrinter.PrintKashfReceiptIfApplicable(printModel, showPreview: true);
                MessageBox.Show(
                    "تم حفظ حالة الكشف وإرسال الإيصال للطباعة.",
                    "طباعة إيصال الكشف",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                    $"تم إنشاء الحالة بنجاح\n\n" +
                    $"المريض: {newCase.PatientName}\n" +
                    $"نوع الزيارة: {visitType}",
                    "نجاح",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void AssignPatientFormUI_Load(object sender, EventArgs e)
        {

        }

        private void panelSide_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
