using System;
using System.Linq;
using System.Windows.Forms;
using DentalClinicProject.classes;
using DentalClinicProject.Data;
using DentalClinicProject.data;

namespace DentalClinicProject.UI
{
    public partial class EditPatientRecordFormUI : System.Windows.Forms.Form
    {
        private readonly string _caseNumber;
        private Case _caseObj;

        private readonly string[] _treatmentList =
        {
            "كشف", "مراجعة", "حشو عادي", "حشوة تجميلية", "خلع عادي",
            "خلع جراحي", "تغليف سن (Zirconia/E-max)", "(علاج عصب (خلفي /طواحن",
            "علاج عصب امامي", "علاج لثة عميق", "تنظيف جير وتلميع", "فينير"
        };

        public EditPatientRecordFormUI(string caseNumber)
        {
            _caseNumber = caseNumber;
            InitializeComponent();
            SetupLogic();
        }

        private void SetupLogic()
        {
            this.Load += (s, e) =>
            {
                DataStore.LoadAllFromDatabase();
                _caseObj = DataStore.Cases.FirstOrDefault(c => c.CaseNumber == _caseNumber);

                if (_caseObj == null)
                {
                    MessageBox.Show("الحالة المحددة غير موجودة!", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                // Populate read-only fields
                txtCaseNumber.Text = _caseObj.CaseNumber;
                txtPatientName.Text = _caseObj.PatientName;
                txtFileNumber.Text = _caseObj.PatientFileNumber;
                txtDoctorName.Text = _caseObj.DoctorName;
                txtPrice.Text = _caseObj.FinalPrice.ToString("F2");

                // Calculate Paid and Remaining
                decimal paid = 0;
                var invoice = DataStore.Invoices.FirstOrDefault(i => i.CaseId == _caseObj.CaseId);
                if (invoice != null)
                {
                    paid = DataStore.Payments.Where(p => p.InvoiceId == invoice.InvoiceId).Sum(p => p.AmountPaid);
                }
                decimal remaining = _caseObj.FinalPrice - paid;

                txtPaid.Text = paid.ToString("F2");
                txtRemaining.Text = remaining.ToString("F2");

                // Populate editable fields
                dtpDate.Value = _caseObj.OpenedDate;

                cmbTreatment.Items.AddRange(_treatmentList);
                if (cmbTreatment.Items.Contains(_caseObj.Treatment))
                {
                    cmbTreatment.Text = _caseObj.Treatment;
                }
                else
                {
                    cmbTreatment.Items.Add(_caseObj.Treatment);
                    cmbTreatment.Text = _caseObj.Treatment;
                }

                cmbStatus.Items.AddRange(new object[] { "في الانتظار", "قيد العلاج", "مكتمل", "ملغي" });
                cmbStatus.Text = GetStatusArabicText(_caseObj.Status);
            };

            btnCancel.Click += (s, e) => this.Close();
            btnSave.Click += BtnSave_Click;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbTreatment.Text))
            {
                MessageBox.Show("الرجاء اختيار نوع العلاج", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _caseObj.OpenedDate = dtpDate.Value;
            _caseObj.Treatment = cmbTreatment.Text;
            _caseObj.Status = GetStatusFromArabicText(cmbStatus.Text);

            // If completed, set ClosedAt
            if (_caseObj.Status == CaseStatus.Completed)
            {
                _caseObj.ClosedAt = DateTime.Now;
                _caseObj.SentToReception = true;
            }
            else
            {
                _caseObj.ClosedAt = null;
                _caseObj.SentToReception = false;
            }

            try
            {
                DataStore.SaveCaseToDatabase(_caseObj);
                MessageBox.Show("تم حفظ التعديلات بنجاح ✓", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء الحفظ:\n" + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetStatusArabicText(CaseStatus status)
        {
            switch (status)
            {
                case CaseStatus.Waiting: return "في الانتظار";
                case CaseStatus.InProgress: return "قيد العلاج";
                case CaseStatus.Completed: return "مكتمل";
                case CaseStatus.Cancelled: return "ملغي";
                default: return "في الانتظار";
            }
        }

        private CaseStatus GetStatusFromArabicText(string text)
        {
            switch (text)
            {
                case "في الانتظار": return CaseStatus.Waiting;
                case "قيد العلاج": return CaseStatus.InProgress;
                case "مكتمل": return CaseStatus.Completed;
                case "ملغي": return CaseStatus.Cancelled;
                default: return CaseStatus.Waiting;
            }
        }
    }
}
