using DentalClinicProject.classes;
using DentalClinicProject.data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalClinicProject
{
    public enum CaseFormMode
    {
        Create,
        DoctorEdit,
        Payment,
        NewCase
    }
    public partial class CaseCreation : Form
    {
        private Case currentCase;
        private CaseFormMode currentMode = CaseFormMode.Create;
        private Invoice _invoice;

        public CaseCreation()
        {
            InitializeComponent();
            currentMode = CaseFormMode.Create;
        }

        public CaseCreation(Case selectedCase, CaseFormMode mode)
        {
            InitializeComponent();
            currentCase = selectedCase;
            currentMode = mode;
        }
        // ─── قائمة التشخيصات الثابتة (عدّليها حسب العيادة) ───────────────



        // ─── قائمة العلاجات / أنواع الحالات (عدّليها حسب العيادة) ──────────

        private readonly string[] _treatmentList =
       {
            "كشف",
            "مراجعة",
            "حشو عادي",
             "حشوة تجميلية",
            "خلع عادي",
            "خلع جراحي",
            "تغليف سن (Zirconia/E-max)",
            "(علاج عصب (خلفي /طواحن",
            "علاج عصب امامي",
            "علاج لثة عميق",
            "تنظيف جير وتلميع",
            "فينير",


        };
        private Dictionary<string, decimal> treatmentPrices =
          new Dictionary<string, decimal>()
      {
    {"كشف",40},
    {"مراجعة",0},
    {"حشو عادي",120},      
    {"حشوة تجميلية",150 },
    {"خلع عادي",100},
    {"خلع جراحي",450},
    {"تغليف سن (Zirconia/E-max)",600},
    {"علاج عصب امامي",500},
    {"(علاج عصب (خلفي /طواحن",750},
    {"فينير",1200},
    {"علاج لثة عميق",400},
    {"تنظيف جير وتلميع",190},

      };


        // ══════════════════════════════════════════════════════════════════
        //  LOAD
        // ══════════════════════════════════════════════════════════════════
        private void CaseCreation_Load(object sender, EventArgs e)
        {

            // ── تنسيق الأشكال ──────────────────────────────────────────
            MakePanelRounded(panel3, 50);
            MakePanelRounded(panel2, 80);
            MakePanelRounded(panel6, 50);
            MakePanelRounded(panel7, 15);
            //MakePanelRounded(panel8, 15);
            MakePanelRounded(panel1, 8);
            SetRoundedButton(patientRecordBtn, 50);
            SetRoundedButton(saveAndCloseBtn, 50);
            SetRoundedButton(printBtn, 50);

            // ── التاريخ ────────────────────────────────────────────────
            label14.Text = DateTime.Now.ToString(
                "dddd ، dd MMMM yyyy",
                new System.Globalization.CultureInfo("ar-LY"));

            // ── رقم الحالة التلقائي ────────────────────────────────────
            GenerateCaseNumber();

            // ── تحميل المرضى في الكومبو ───────────────────────────────
            LoadPatients();

            // ── تحميل الأطباء في الكومبو ──────────────────────────────
            LoadDoctors();


            // ── تحميل التشخيصات ───────────────────────────────────────
            cmbTreatment.Items.Clear();
            cmbTreatment.Items.AddRange(_treatmentList);

            //--------------------------------------------------------------
            if (currentMode != CaseFormMode.Create)
            {
                LoadCaseData();
                SetupFormMode();
            }
            if (currentMode == CaseFormMode.Payment)
            {
                LoadPaymentData();
            }

            // ربط أحداث التغيير
            //txtAmountPaid.TextChanged += (s, e) => UpdateRemainingLabel();


            // ── قيم افتراضية ──────────────────────────────────────────
            numToothCount.Minimum = 1;
            numToothCount.Maximum = 32;
            numToothCount.Value = 1;

           
            UpdateFinalPrice();
            txtPrice.TextChanged += txtPrice_TextChanged;
            txtDiscount.TextChanged += txtDiscount_TextChanged;
            // ── تعبئة كومبو نوع الدفع ──────────────────────────────────────────
            cmbPaymentType.Items.Clear();
            cmbPaymentType.Items.Add("دفع كامل");
            cmbPaymentType.Items.Add("دفعة من الحساب");

            cmbTreatment.SelectedIndexChanged +=
             cmbTreatment_SelectedIndexChanged;

            cmbPaymentType.SelectedIndexChanged +=
    CmbPaymentType_Changed;


        }

        // ══════════════════════════════════════════════════════════════════
        //  HELPERS — تحميل البيانات
        // ══════════════════════════════════════════════════════════════════

        /// <summary>رقم الحالة بصيغة CASE-YYYY-XXXX</summary>
        private void GenerateCaseNumber()
        {
            int next = DataStore.Cases.Count + 1001;
            txtCaseNumber.Text = $"CASE-{DateTime.Now.Year}-{next}";
            txtCaseNumber.ReadOnly = true;
        }

        /// <summary>تحميل المرضى: يعرض الاسم ويحفظ الـ Patient كـ Tag</summary>
        private void LoadPatients()
        {
            cmbPatient.DisplayMember = "DisplayText";
            cmbPatient.ValueMember = "PatientId";
            cmbPatient.DataSource = DataStore.Patients
                .Select(p => new
                {
                    p.PatientId,
                    DisplayText = $"{p.FileNumber} — {p.FullName}"
                })
                .ToList();
            cmbPatient.SelectedIndex = -1;
        }

        /// <summary>تحميل الأطباء النشطين فقط</summary>
        private void LoadDoctors()
        {
            cmbDoctor.DisplayMember = "FullName";
            cmbDoctor.ValueMember = "DoctorId";
            cmbDoctor.DataSource = DataStore.Doctors
                .Where(d => d.IsActive)
                .ToList();
            cmbDoctor.SelectedIndex = -1;
        }

        // ══════════════════════════════════════════════════════════════════
        //  EVENTS — الكومبو والحقول
        // ══════════════════════════════════════════════════════════════════

        /// <summary>عند اختيار مريض: أظهر رقم ملفه في الـ label</summary>
        private void cmbPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPatient.SelectedValue == null) return;

            int selectedId = (int)cmbPatient.SelectedValue;
            var patient = DataStore.Patients.FirstOrDefault(p => p.PatientId == selectedId);

            if (patient != null)
            {
                // أظهر رقم الملف في الـ label أو TextBox المخصص
                txtFileNumber.Text = patient.FileNumber;
                txtFileNumber.ReadOnly = true;
                // تحديث ليبل الديون (الذي يظهر في الصورة بـ 150.00 د.ل)
                decimal previousDebt = GetPatientTotalDebt(selectedId);
                lblTotalDebt.Text = $"د.ل {previousDebt:F2}";
            }
        }

        /// <summary>حساب السعر النهائي عند تغيير السعر أو التخفيض</summary>
        private void txtPrice_TextChanged(object sender, EventArgs e) => UpdateFinalPrice();
        private void txtDiscount_TextChanged(object sender, EventArgs e) => UpdateFinalPrice();

        private void UpdateFinalPrice()
        {
            decimal price = ParseDecimal(txtPrice.Text);
            decimal discount = ParseDecimal(txtDiscount.Text);

            decimal final = price - discount;

            if (final < 0)
                final = 0;

            lblFinalPrice.Text = final.ToString("0.00") + " د.ل";

            lblFinalPrice.ForeColor = Color.FromArgb(15, 110, 86);

        }

        private decimal ParseDecimal(string text)
        {
            decimal.TryParse(text, out decimal result);
            return result;
        }

        // ══════════════════════════════════════════════════════════════════
        //  SAVE — حفظ الحالة
        // ══════════════════════════════════════════════════════════════════
        // في CaseCreation.cs، تعديل دالة saveAndCloseBtn_Click

        private void saveAndCloseBtn_Click(object sender, EventArgs e)
        {
            // ── التحقق من الحقول الإلزامية ────────────────────────────
            if (cmbPatient.SelectedValue == null)
            {
                ShowError("الرجاء اختيار المريض");
                cmbPatient.Focus();
                return;
            }
            if (cmbDoctor.SelectedValue == null)
            {
                ShowError("الرجاء اختيار الطبيب");
                cmbDoctor.Focus();
                return;
            }
            if (cmbTreatment.SelectedIndex == -1)
            {
                ShowError("الرجاء اختيار نوع الحالة / العلاج");
                cmbTreatment.Focus();
                return;
            }

            decimal price = ParseDecimal(txtPrice.Text);
            decimal discount = ParseDecimal(txtDiscount.Text);

            if (price <= 0 && cmbTreatment.Text != "مراجعة")
            {
                ShowError("الرجاء إدخال سعر صحيح");
                txtPrice.Focus();
                return;
            }
            if (discount > price)
            {
                ShowError("التخفيض لا يمكن أن يتجاوز السعر");
                txtDiscount.Focus();
                return;
            }

            // ── جلب بيانات المريض والطبيب ─────────────────────────────
            int patientId = Convert.ToInt32(cmbPatient.SelectedValue);
            int doctorId = Convert.ToInt32(cmbDoctor.SelectedValue);

            var patient = DataStore.Patients.FirstOrDefault(p => p.PatientId == patientId);
            var doctor = DataStore.Doctors.FirstOrDefault(d => d.DoctorId == doctorId);

            // ── وضع الدكتور: تحديث الحالة الموجودة ──────────────────────
            // ── وضع الدكتور: إغلاق الكشف وفتح حالة علاج جديدة ──────────────────────
            if (currentMode == CaseFormMode.DoctorEdit)
            {
                if (currentCase == null) { ShowError("لا توجد حالة"); return; }

                // 1. إغلاق حالة الكشف القديمة (الـ 40 جنيه) كما هي
                currentCase.Status = CaseStatus.Completed;
                currentCase.SentToReception = true;
                currentCase.ClosedAt = DateTime.Now;

                // 2. إنشاء حالة "علاج" جديدة تماماً (الـ 100 جنيه) عشان تطلع في سطر جديد
                var treatmentCase = new Case
                {
                    CaseId = DataStore.NextCaseId(),
                    CaseNumber = "T-" + DateTime.Now.Ticks.ToString().Substring(10), // رقم مميز
                    PatientId = currentCase.PatientId,
                    PatientName = currentCase.PatientName,
                    DoctorId = currentCase.DoctorId,
                    DoctorName = currentCase.DoctorName,
                    Treatment = cmbTreatment.Text, // العلاج الجديد (مثلاً علاج عصب)
                    Price = ParseDecimal(txtPrice.Text), // السعر الجديد (100)
                    Discount = ParseDecimal(txtDiscount.Text),
                    Status = CaseStatus.Completed,
                    OpenedDate = DateTime.Now,
                    SentToReception = true
                };
                DataStore.Cases.Add(treatmentCase);

                // 3. إنشاء فاتورة جديدة منفصلة للحالة الجديدة
                var newInvoice = new Invoice
                {
                    InvoiceId = DataStore.NextInvoiceId(),
                    CaseId = treatmentCase.CaseId,
                    PatientId = treatmentCase.PatientId,
                    TotalAmount = treatmentCase.FinalPrice,
                    IssuedDate = DateTime.Now
                };
                DataStore.Invoices.Add(newInvoice);

                MessageBox.Show("تم تسجيل العلاج كحالة منفصلة بنجاح", "تم");
                this.DialogResult = DialogResult.OK;
                this.Close();
                return;
            }

            // ── وضع الدفع ──────────────────────────────────────────────
            if (currentMode == CaseFormMode.Payment)
            {
                SavePayment();
                return;
            }

            // ── وضع إنشاء حالة جديدة ────────────────────────────────────
            // التأكد من عدم وجود حالة مكررة للمريض بنفس اليوم والعلاج (اختياري)
            var newCase = new Case
            {
                CaseId = DataStore.NextCaseId(),
                CaseNumber = txtCaseNumber.Text,
                PatientId = patientId,
                PatientFileNumber = patient?.FileNumber ?? "",
                PatientName = patient?.FullName ?? "",
                DoctorId = doctorId,
                DoctorName = doctor?.FullName ?? "",
                Treatment = cmbTreatment.Text,
                ToothCount = (int)numToothCount.Value,
                Price = price,
                Discount = discount,
                Notes = txtNotes.Text.Trim(),
                Status = CaseStatus.Waiting,
                OpenedDate = DateTime.Now,
                SentToReception = false,   // الحالة الجديدة لم ترسل للاستقبال بعد
                ClosedAt = null
            };

            // ── إضافة للـ DataStore ───────────────────────────────────
            DataStore.Cases.Add(newCase);

            // إنشاء الفاتورة
            var invoice = new Invoice
            {
                InvoiceId = DataStore.NextInvoiceId(),
                CaseId = newCase.CaseId,
                PatientId = patientId,
                TotalAmount = price - discount,
                IssuedDate = DateTime.Now,
                IsPaid = false
            };

            DataStore.Invoices.Add(invoice);

            // تسجيل الدفع إذا كان هناك مبلغ مدفوع
            decimal paidAmount = ParseDecimal(txtAmount.Text);

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

                if (paidAmount >= invoice.TotalAmount)
                {
                    invoice.IsPaid = true;
                }
            }

            MessageBox.Show(
                $"✅ تم إنشاء الحالة بنجاح\n\n" +
                $"رقم الحالة: {newCase.CaseNumber}\n" +
                $"المريض: {newCase.PatientName}\n" +
                $"الطبيب: {newCase.DoctorName}\n" +
                $"السعر النهائي: {newCase.FinalPrice:F2} د.ل",
                "تم الحفظ",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        // ══════════════════════════════════════════════════════════════════
        //  PRINT BUTTON (قابل للتوسعة لاحقاً)
        // ══════════════════════════════════════════════════════════════════
        private void printBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ميزة الطباعة قيد التطوير", "قريباً",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ══════════════════════════════════════════════════════════════════
        //  PATIENT RECORD BUTTON — فتح سجل المريض
        // ══════════════════════════════════════════════════════════════════
        private void patientRecordBtn_Click(object sender, EventArgs e)
        {
            if (cmbPatient.SelectedValue == null)
            {
                ShowError("اختر مريضاً أولاً لعرض سجله");
                return;
            }

            int patientId = (int)cmbPatient.SelectedValue;
            // افتح فورم سجل المريض ومرر له الـ ID
            // var form = new PatientRecordForm(patientId);
            // form.Show();
            MessageBox.Show($"سجل المريض رقم {patientId} — قيد التطوير",
                "سجل المريض", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ══════════════════════════════════════════════════════════════════
        //  SHAPE HELPERS
        // ══════════════════════════════════════════════════════════════════
        private void MakePanelRounded(Panel panel, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddArc(new Rectangle(panel.Width - radius, 0, radius, radius), 270, 90);
            path.AddArc(new Rectangle(panel.Width - radius, panel.Height - radius, radius, radius), 0, 90);
            path.AddArc(new Rectangle(0, panel.Height - radius, radius, radius), 90, 90);
            path.CloseFigure();
            panel.Region = new Region(path);
        }

        private void SetRoundedButton(Button btn, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(btn.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(btn.Width - radius, btn.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, btn.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            btn.Region = new Region(path);
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, "تنبيه",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // ── أحداث Paint فارغة (للتوافق مع Designer) ─────────────────────
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }

        private void numToothCount_ValueChanged(object sender, EventArgs e)
        {

        }
        private void LoadCaseData()
        {
            if (currentCase == null) return;

            txtCaseNumber.Text = currentCase.CaseNumber;

            cmbPatient.SelectedValue = currentCase.PatientId;

            cmbDoctor.SelectedValue = currentCase.DoctorId;

            cmbTreatment.Text = currentCase.Treatment;

            numToothCount.Value = currentCase.ToothCount;

            txtPrice.Text = currentCase.Price.ToString();

            txtDiscount.Text = currentCase.Discount.ToString();

            txtNotes.Text = currentCase.Notes;

            lblFinalPrice.Text =
                currentCase.FinalPrice.ToString("0.00") + " د.ل";

            // الطبيب ما يغيرش المريض والطبيب
            cmbPatient.Enabled = false;
            cmbDoctor.Enabled = false;
        }


        private void SetupFormMode()
        {
            // ===== وضع الدكتور =====
            if (currentMode == CaseFormMode.DoctorEdit)
            {
                cmbPatient.Enabled = false;
                cmbDoctor.Enabled = false;

                cmbPaymentType.Visible = false;
                txtAmount.Visible = false;
                //cmbMethod.Visible = false;

                saveAndCloseBtn.Text = "إنهاء الحالة";
            }

            // ===== وضع الدفع =====
            else if (currentMode == CaseFormMode.Payment)
            {
                cmbPatient.Enabled = false;
                cmbDoctor.Enabled = false;
                cmbTreatment.Enabled = false;
                txtAmount.Enabled = true;
                txtAmount.ReadOnly = false;

                txtPrice.ReadOnly = true;
                txtDiscount.ReadOnly = false;

                cmbPaymentType.Visible = true;
                txtAmount.Visible = true;
                //cmbMethod.Visible = true;

                saveAndCloseBtn.Text = "تأكيد الدفع";
            }
        }
        private decimal GetTotalPaid()
        {
            if (_invoice == null) return 0;
            return DataStore.Payments
                .Where(p => p.InvoiceId == _invoice.InvoiceId)
                .Sum(p => p.AmountPaid);
        
        }
        private void CmbPaymentType_Changed(object sender, EventArgs e)
        {
            if (currentCase == null) return;

            decimal remaining = currentCase.FinalPrice - GetTotalPaid();

            if (cmbPaymentType.SelectedIndex == 0) // دفع كامل
            {
                txtAmount.Text = remaining.ToString("F2");
                txtAmount.ReadOnly = true;
                txtAmount.BackColor = Color.FromArgb(235, 245, 255);
            }
            else // جزء من الحساب
            {
                txtAmount.Text = "";
                txtAmount.ReadOnly = false;
                txtAmount.BackColor = Color.White;
                txtAmount.Focus();
            }
        }
        private void SavePayment()
        {
            {
                if (_invoice == null)
                {
                    MessageBox.Show("لا توجد فاتورة لهذه الحالة!", "خطأ",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // تحقق من المبلغ
                string treatment = currentCase?.Treatment ?? "";

                if (!decimal.TryParse(txtAmount.Text, out decimal amount) || (amount <= 0 && treatment != "مراجعة"))
                {
                    MessageBox.Show("أدخل مبلغاً صحيحاً", "تنبيه",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAmount.Focus();
                    return;
                }

                decimal discount = ParseDecimal(txtDiscount.Text);
                decimal netAmount = amount - discount;

                // يسمح بالصافي 0 فقط إذا كانت مراجعة، وإلا يرفض القيم السالبة أو الصفرية
                if (netAmount < 0 || (netAmount == 0 && treatment != "مراجعة"))
                {
                    MessageBox.Show("المبلغ بعد التخفيض يجب أن يكون أكبر من صفر", "تنبيه",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal remaining = currentCase.FinalPrice - GetTotalPaid();

                if (netAmount > remaining)
                {
                    MessageBox.Show(
                        $"المبلغ ({netAmount:F2}) أكبر من الباقي ({remaining:F2} د.ل)",
                        "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // تأكيد
                // إذا كانت مراجعة وسعرها 0، احفظيها فوراً وأغلقي
                if (treatment == "مراجعة" && netAmount == 0)
                {
                    var paymentZero = new Payment
                    {
                        PaymentId = DataStore.NextPaymentId(),
                        InvoiceId = _invoice.InvoiceId,
                        AmountPaid = 0,
                        PaymentDate = DateTime.Now
                    };
                    DataStore.Payments.Add(paymentZero);
                    MessageBox.Show("تم تسجيل المراجعة المجانية بنجاح");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    return;
                }
                var confirm = MessageBox.Show(
                    $"نوع الدفع : {cmbPaymentType.Text}\n" +
                    $"المبلغ    : {amount:F2} د.ل\n" +
                    $"التخفيض  : {discount:F2} د.ل\n" +
                    $"الصافي   : {netAmount:F2} د.ل\n" +
                    //$"الطريقة  : {cmbMethod.Text}\n\n" +
                    "تأكيد الدفع؟",
                    "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm != DialogResult.Yes) return;

                // ── حفظ في DataStore.Payments ──
                var payment = new Payment
                {
                    PaymentId = DataStore.NextPaymentId(),
                    InvoiceId = _invoice.InvoiceId,
                    AmountPaid = netAmount,
                    PaymentDate = DateTime.Now,
                    //Method = cmbMethod.Text
                };
                DataStore.Payments.Add(payment);

                // ── حساب نصيب الطبيب والعيادة ──
                decimal newPaid = GetTotalPaid();
                decimal newRemaining = currentCase.FinalPrice - newPaid;
                var doctor = DataStore.Doctors
                                        .FirstOrDefault(d => d.DoctorId == currentCase.DoctorId);
                decimal commission = doctor?.CommissionPct ?? 0;
                decimal doctorShare = newPaid * (commission / 100);
                decimal clinicShare = newPaid - doctorShare;

                MessageBox.Show(
                    $"✅ تم تسجيل الدفعة\n\n" +
                    $"المدفوع الآن : {newPaid:F2} د.ل\n" +
                    $"الباقي       : {newRemaining:F2} د.ل\n" +
                    $"──────────────────\n" ,
                    "تم الدفع", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }


        private void LoadPaymentData()
        {
            if (currentCase == null) return;

            _invoice = DataStore.Invoices
                .FirstOrDefault(i => i.CaseId == currentCase.CaseId);

            if (_invoice == null)
            {
                MessageBox.Show("لا توجد فاتورة لهذه الحالة");
                return;
            }

            decimal paid = GetTotalPaid();
            decimal remaining = currentCase.FinalPrice - paid;

            txtAmount.Text = remaining.ToString("F2");
            lblFinalPrice.Text = remaining.ToString("F2") + " د.ل";

            // لو مسدد بالكامل
            if (remaining <= 0)
            {
                saveAndCloseBtn.Enabled = false;
                saveAndCloseBtn.Text = "✅ مسدد";
                txtAmount.ReadOnly = true;
            }
        }
        private void patientRecordBtn_Click_1(object sender, EventArgs e)
        {
            Form1 patientRecordForm = new Form1();
            patientRecordForm.ShowDialog(); 

        }

        private void cmbPaymentType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbTreatment_SelectedIndexChanged(object sender, EventArgs e)
        {
            string treatment = cmbTreatment.Text;

            // تعبئة السعر تلقائي
            if (treatmentPrices.ContainsKey(treatment))
            {
                txtPrice.Text =
                    treatmentPrices[treatment].ToString();
            }

            // المراجعة مجانية
            if (treatment == "مراجعة")
            {
                txtPrice.Text = "0";

                cmbPaymentType.Enabled = false;
                cmbPaymentType.Text = "";
            }
            else
            {
                cmbPaymentType.Enabled = true;
            }

        }
        private decimal GetPatientTotalDebt(int patientId)
        {
            // جلب كل فواتير المريض
            var patientInvoices = DataStore.Invoices.Where(i => i.PatientId == patientId).ToList();
            decimal totalDebt = 0;

            foreach (var inv in patientInvoices)
            {
                // حساب المدفوع لكل فاتورة
                decimal paidForThisInv = DataStore.Payments
                    .Where(p => p.InvoiceId == inv.InvoiceId)
                    .Sum(p => p.AmountPaid);

                // الديون هي الإجمالي - المدفوع
                totalDebt += (inv.TotalAmount - paidForThisInv);
            }
            return totalDebt;
        }
        // أضيفي هذا الحدث في Load أو في المصمم لخانة المبلغ المدفوع
       

        private void CalculateRemaining()
        {
            decimal totalPrice = ParseDecimal(txtPrice.Text); // السعر الحالي
            decimal discount = ParseDecimal(txtDiscount.Text); // التخفيض
            decimal amountPaidNow = ParseDecimal(txtAmount.Text); // المدفوع الآن

            decimal finalPrice = totalPrice - discount;
            decimal remaining = finalPrice - amountPaidNow;

            // تحديث الليبلات في الواجهة
            lblFinalPrice.Text = finalPrice.ToString("F2") + " د.ل";
            lblRemainingAmount.Text = remaining.ToString("F2") + " د.ل"; // ليبل المبلغ المتبقي
        }
        // أضيفي هذه الدالة في أي مكان فارغ داخل الكلاس
        private void UpdateRemainingLabel()
        {
            decimal price = ParseDecimal(txtPrice.Text);
            decimal discount = ParseDecimal(txtDiscount.Text);
            decimal paidNow = ParseDecimal(txtAmount.Text);

            decimal remaining = (price - discount) - paidNow;

            // افترضي أن اسم الليبل عندك lblRemaining (تأكدي من الاسم في الـ Designer)
            if (lblRemainingAmount != null)
            {
                lblRemainingAmount.Text = remaining.ToString("F2") + " د.ل";
                lblRemainingAmount.ForeColor = remaining <= 0 ? Color.Green : Color.Red;
            }
        }
        //private void ConfigureFormByMode()
        //{
        //    if (currentMode == CaseFormMode.DoctorEdit)
        //    {
        //        // الطبيب يعدل العلاج فقط
        //        cmbPatient.Enabled = false;
        //        cmbDoctor.Enabled = false;
        //        txtPrice.ReadOnly = true;
        //        txtDiscount.ReadOnly = true;
        //        this.Text = "تفاصيل الحالة — الطبيب";
        //    }
        //    else if (currentMode == CaseFormMode.Payment)
        //    {
        //        // الريسبشن تشوف + تدفع فقط
        //        cmbPatient.Enabled = false;
        //        cmbDoctor.Enabled = false;
        //        cmbTreatment.Enabled = false;
        //        numToothCount.Enabled = false;
        //        txtPrice.ReadOnly = true;
        //        txtDiscount.ReadOnly = true;
        //        txtNotes.ReadOnly = true;
        //        saveAndCloseBtn.Text = "تسجيل الدفع";
        //        this.Text = "تسجيل الدفع";
        //        LoadPaymentPanel();   // ← نضيف بانيل الدفع
        //    }
        //}
    }
    }
