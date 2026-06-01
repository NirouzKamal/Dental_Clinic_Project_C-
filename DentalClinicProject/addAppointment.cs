using DentalClinicProject.classes;
using DentalClinicProject.data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DentalClinicProject
{
    public partial class addAppointment : Form
    {
        private Doctor selectedDoctor;
        private int currentMonth, currentYear;
        private TimeSpan selectedTime = TimeSpan.Zero;
        private Button lastClickedButton = null;
        private DateTime? selectedFullDate = null;

        public addAppointment(Doctor doctor, DateTime date, TimeSpan time)
        {
            InitializeComponent();
            selectedDoctor = doctor;
            // عرض اسم الدكتور في الواجهة عند البدء
            this.Text = "إضافة موعد جديد لـ " + selectedDoctor?.FullName;

        }

        private void addAppointment_Load(object sender, EventArgs e)
        {
            // 1. تعبئة بيانات المرضى
            LoadPatients();

            // 2. إعداد التقويم
            currentMonth = DateTime.Now.Month;
            currentYear = DateTime.Now.Year;
            CreateCalendar(currentMonth, currentYear);

            // 3. عرض اسم الدكتور في التيكست بوكس (إذا وجد)
            doctorNameTxt.Text = selectedDoctor?.FullName;
            GenerateTimeButtons(); // سيؤدي هذا لإخفاء الأزرار العشرة لأن التاريخ لم يُختر بعد
        }

        private void LoadPatients()
        {
            comboBox1.DataSource = DataStore.Patients.ToList();
            comboBox1.DisplayMember = "FullName";
            comboBox1.ValueMember = "PatientId";
            comboBox1.SelectedIndex = -1;

            comboBox1.SelectedIndexChanged += (s, ev) => {
                if (comboBox1.SelectedItem is Patient p)
                {
                    textBox1.Text = p.FileNumber;
                    NumPhoneTxt.Text = p.Phone;
                }
            };
        }

        private void CreateCalendar(int month, int year)
        {
            tableLayoutPanel2.Controls.Clear();
            lblMonthAndYear.Text = new DateTime(year, month, 1).ToString("MMMM yyyy", new System.Globalization.CultureInfo("ar-LY"));

            DateTime startOfMonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);

            // تعديل حساب يوم البداية ليتوافق مع ترتيب (السبت = 0) في جدولك
            // DayOfWeek: Sunday=0, Monday=1 ... Saturday=6
            // لتحويل السبت ليكون رقم 0:
            int startDay = ((int)startOfMonth.DayOfWeek + 1) % 7;

            var workingDays = DataStore.DoctorSchedules
                .Where(s => s.DoctorId == selectedDoctor.DoctorId && s.IsWorking)
                .Select(s => s.DayOfWeek).ToList();

            int column = startDay;
            int row = 0;

            for (int i = 1; i <= days; i++)
            {
                DateTime dateIter = new DateTime(year, month, i);
                Label lbl = new Label();
                lbl.Text = i.ToString();
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                lbl.Dock = DockStyle.Fill;
                lbl.Cursor = Cursors.Hand;
                lbl.Font = new Font("Tahoma", 10, FontStyle.Bold); // تأكد من حجم خط مناسب
                lbl.Margin = new Padding(1);

                // التلوين
                if (selectedFullDate.HasValue && selectedFullDate.Value.Date == dateIter.Date)
                {
                    lbl.BackColor = Color.Cyan;
                }
                else if (workingDays.Contains(dateIter.DayOfWeek))
                {
                    lbl.BackColor = Color.LightSkyBlue;
                }
                else
                {
                    lbl.BackColor = Color.White;
                }

                lbl.Click += (s, ev) => {
                    if (!workingDays.Contains(dateIter.DayOfWeek))
                    {
                        MessageBox.Show("الدكتور لا يعمل في هذا اليوم");
                        return;
                    }
                    selectedFullDate = dateIter;
                    CreateCalendar(currentMonth, currentYear);
                    GenerateTimeButtons();
                };

                // إضافة الـ Label للجدول
                tableLayoutPanel2.Controls.Add(lbl, column, row);

                column++;
                if (column > 6)
                {
                    column = 0;
                    row++;
                }
            }
        }

        private void GenerateTimeButtons()
        {
            // 1. مصفوفة تضم الأزرار التي صممتها يدوياً في الواجهة بالترتيب
            Button[] manualButtons = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10 };

            // 2. إخفاء جميع الأزرار في البداية لتنظيف الواجهة
            foreach (var btn in manualButtons)
            {
                btn.Visible = false;
                btn.BackColor = Color.White; // إعادة اللون الافتراضي
            }

            if (!selectedFullDate.HasValue) return;

            // 3. جلب جدول دوام الدكتور لهذا اليوم
            var schedule = DataStore.DoctorSchedules.FirstOrDefault(s =>
                s.DoctorId == selectedDoctor.DoctorId &&
                s.DayOfWeek == selectedFullDate.Value.DayOfWeek && s.IsWorking);

            TimeSpan start = schedule?.StartTime ?? new TimeSpan(9, 0, 0);
            TimeSpan end = schedule?.EndTime ?? new TimeSpan(17, 0, 0);

            int buttonIndex = 0;

            // 4. تعبئة الأزرار اليدوية بالمواعيد المتاحة
            while (start < end && buttonIndex < manualButtons.Length)
            {
                Button currentBtn = manualButtons[buttonIndex];

                currentBtn.Text = DateTime.Today.Add(start).ToString("hh:mm tt");
                currentBtn.Tag = start;
                currentBtn.Visible = true; // إظهار الزر لأنه يحتوي على موعد

                // فحص التعارض (هل الساعة محجوزة؟)
                bool isBooked = DataStore.HasConflict(selectedDoctor.DoctorId, selectedFullDate.Value, start, start.Add(TimeSpan.FromHours(1)));

                if (isBooked)
                {
                    currentBtn.Enabled = false;
                    currentBtn.BackColor = Color.LightGray;
                }
                else
                {
                    currentBtn.Enabled = true;
                    // ربط حدث النقر برمجياً للتأكد من عمله
                    currentBtn.Click -= ManualTimeButton_Click; // حذف الحدث القديم لتجنب التكرار
                    currentBtn.Click += ManualTimeButton_Click;
                }

                start = start.Add(TimeSpan.FromHours(1)); // إضافة ساعة
                buttonIndex++;
            }
        }

        private void ManualTimeButton_Click(object sender, EventArgs e)
        {
            Button clickedBtn = (Button)sender;

            if (lastClickedButton != null) lastClickedButton.BackColor = Color.White;

            clickedBtn.BackColor = Color.Cyan;
            selectedTime = (TimeSpan)clickedBtn.Tag;
            lastClickedButton = clickedBtn;
        }


        private void NewBtn_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            currentMonth++;
            if (currentMonth > 12) { currentMonth = 1; currentYear++; }
            CreateCalendar(currentMonth, currentYear);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            currentMonth--;
            if (currentMonth < 1) { currentMonth = 12; currentYear--; }
            CreateCalendar(currentMonth, currentYear);
        }

        
        private void saveAndCloseBtn_Click(object sender, EventArgs e)
        {
            if (!selectedFullDate.HasValue || selectedTime == TimeSpan.Zero || comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("الرجاء اختيار المريض، التاريخ، والوقت");
                return;
            }

            Appointment newApt = new Appointment
            {
                AppointmentId = DataStore.NextAppointmentId(),
                PatientId = (int)comboBox1.SelectedValue,
                DoctorId = selectedDoctor.DoctorId,
                AppointmentDate = selectedFullDate.Value.Date,
                StartTime = selectedTime,
                EndTime = selectedTime.Add(TimeSpan.FromHours(1)),
                Status = AppointmentStatus.Scheduled,
                Notes = noteTxt.Text
            };

            DataStore.Appointments.Add(newApt);
            MessageBox.Show("تم حفظ الموعد بنجاح");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}