using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;
using DentalClinicProject.data;

namespace DentalClinicProject.classes
{
    public static class PrintManager
    {
        private static Font headerFont = new Font("Segoe UI", 16, FontStyle.Bold);
        private static Font subHeaderFont = new Font("Segoe UI", 12, FontStyle.Bold);
        private static Font normalFont = new Font("Segoe UI", 10, FontStyle.Regular);
        private static Font boldFont = new Font("Segoe UI", 10, FontStyle.Bold);

        private static StringFormat rtlFormat = new StringFormat
        {
            FormatFlags = StringFormatFlags.DirectionRightToLeft,
            Alignment = StringAlignment.Near,
            LineAlignment = StringAlignment.Center
        };

        private static StringFormat centerFormat = new StringFormat
        {
            Alignment = StringAlignment.Center,
            LineAlignment = StringAlignment.Center
        };
        
        private static StringFormat rtlCenterFormat = new StringFormat
        {
            FormatFlags = StringFormatFlags.DirectionRightToLeft,
            Alignment = StringAlignment.Center,
            LineAlignment = StringAlignment.Center
        };

        // --- Receipt Printing ---
        public static void PrintReceipt(Case clinicCase)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += (sender, e) => PrintReceiptPage(e, clinicCase);

            PrintPreviewDialog preview = new PrintPreviewDialog
            {
                Document = pd,
                Width = 600,
                Height = 800,
                ShowIcon = false,
                Text = "معاينة الإيصال"
            };
            preview.ShowDialog();
        }

        private static void PrintReceiptPage(PrintPageEventArgs e, Case clinicCase)
        {
            Graphics g = e.Graphics;
            int y = 20;
            int width = e.PageBounds.Width;
            int margin = 40;

            // Header
            g.DrawString("عيادة DentCare للأسنان", headerFont, Brushes.Black, new RectangleF(0, y, width, 40), centerFormat);
            y += 40;
            g.DrawString("إيصال دفع", subHeaderFont, Brushes.Black, new RectangleF(0, y, width, 30), centerFormat);
            y += 40;

            g.DrawLine(Pens.Black, margin, y, width - margin, y);
            y += 20;

            // Details
            string dateStr = $"التاريخ: {DateTime.Now.ToString("yyyy-MM-dd HH:mm")}";
            g.DrawString(dateStr, normalFont, Brushes.Black, new RectangleF(margin, y, width - (2 * margin), 25), rtlFormat);
            y += 30;

            g.DrawString($"رقم الملف: {clinicCase.PatientFileNumber}", normalFont, Brushes.Black, new RectangleF(margin, y, width - (2 * margin), 25), rtlFormat);
            y += 30;

            g.DrawString($"المريض: {clinicCase.PatientName}", boldFont, Brushes.Black, new RectangleF(margin, y, width - (2 * margin), 25), rtlFormat);
            y += 30;

            g.DrawString($"الطبيب المعالج: {clinicCase.DoctorName}", normalFont, Brushes.Black, new RectangleF(margin, y, width - (2 * margin), 25), rtlFormat);
            y += 40;

            g.DrawLine(Pens.Black, margin, y, width - margin, y);
            y += 20;

            g.DrawString($"العلاج/التشخيص: {clinicCase.Treatment}", normalFont, Brushes.Black, new RectangleF(margin, y, width - (2 * margin), 25), rtlFormat);
            y += 30;

            g.DrawLine(Pens.Black, margin, y, width - margin, y);
            y += 20;

            // Financials
            var invoice = DataStore.Invoices.FirstOrDefault(i => i.CaseId == clinicCase.CaseId);
            decimal total = clinicCase.FinalPrice;
            decimal paid = 0;
            if (invoice != null)
            {
                paid = DataStore.Payments.Where(p => p.InvoiceId == invoice.InvoiceId).Sum(p => p.AmountPaid);
            }
            decimal remaining = total - paid;

            g.DrawString($"الإجمالي: {total:F2} د.ل", boldFont, Brushes.Black, new RectangleF(margin, y, width - (2 * margin), 25), rtlFormat);
            y += 30;

            g.DrawString($"المدفوع: {paid:F2} د.ل", boldFont, Brushes.Black, new RectangleF(margin, y, width - (2 * margin), 25), rtlFormat);
            y += 30;

            g.DrawString($"المتبقي: {remaining:F2} د.ل", boldFont, Brushes.Red, new RectangleF(margin, y, width - (2 * margin), 25), rtlFormat);
            y += 50;

            g.DrawString("شكراً لزيارتكم! مع تمنياتنا بالشفاء العاجل.", normalFont, Brushes.Black, new RectangleF(0, y, width, 30), centerFormat);
        }

        // --- Patient Report Printing ---
        public static void PrintPatientReport(string patientId)
        {
            var patient = DataStore.Patients.FirstOrDefault(p => p.PatientId == patientId);
            if (patient == null)
            {
                MessageBox.Show("لم يتم العثور على المريض.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += (sender, e) => PrintPatientReportPage(e, patient);

            PrintPreviewDialog preview = new PrintPreviewDialog
            {
                Document = pd,
                Width = 800,
                Height = 1000,
                ShowIcon = false,
                Text = "معاينة التقرير"
            };
            preview.ShowDialog();
        }

        private static void PrintPatientReportPage(PrintPageEventArgs e, Patient patient)
        {
            Graphics g = e.Graphics;
            int y = 40;
            int width = e.PageBounds.Width;
            int margin = 50;

            // Header
            g.DrawString("عيادة DentCare للأسنان - تقرير المريض الشامل", headerFont, Brushes.Black, new RectangleF(0, y, width, 40), centerFormat);
            y += 50;
            g.DrawLine(Pens.Black, margin, y, width - margin, y);
            y += 20;

            // Patient Info
            g.DrawString($"اسم المريض: {patient.FullName}", boldFont, Brushes.Black, new RectangleF(margin, y, width - (2 * margin), 25), rtlFormat);
            y += 30;
            g.DrawString($"رقم الملف: {patient.FileNumber} | رقم الهاتف: {patient.Phone}", normalFont, Brushes.Black, new RectangleF(margin, y, width - (2 * margin), 25), rtlFormat);
            y += 40;

            g.DrawLine(Pens.Black, margin, y, width - margin, y);
            y += 30;

            g.DrawString("سجل الحالات والعلاجات:", subHeaderFont, Brushes.Black, new RectangleF(margin, y, width - (2 * margin), 30), rtlFormat);
            y += 40;

            // Draw Table Header
            int tableWidth = width - (2 * margin);
            var cases = DataStore.Cases.Where(c => c.PatientFileNumber == patient.FileNumber).OrderByDescending(c => c.OpenedDate).ToList();

            if (cases.Count == 0)
            {
                g.DrawString("لا يوجد سجل حالات لهذا المريض.", normalFont, Brushes.Gray, new RectangleF(margin, y, width - (2 * margin), 30), rtlCenterFormat);
                return;
            }

            int currentX = width - margin;
            int[] colWidths = { 100, 150, 100, 80, 80, 80, 80 }; // Date, Treatment, Doctor, Total, Paid, Remaining, Status

            string[] headers = { "التاريخ", "العلاج", "الطبيب", "الإجمالي", "المدفوع", "الباقي", "الحالة" };
            
            int tempX = currentX;
            for (int i = 0; i < headers.Length; i++)
            {
                tempX -= colWidths[i];
                g.DrawRectangle(Pens.Black, tempX, y, colWidths[i], 30);
                g.DrawString(headers[i], boldFont, Brushes.Black, new RectangleF(tempX, y, colWidths[i], 30), centerFormat);
            }
            y += 30;

            decimal grandTotal = 0, grandPaid = 0, grandRemaining = 0;

            foreach (var c in cases)
            {
                tempX = currentX;

                decimal total = c.FinalPrice;
                decimal paid = 0;
                var invoice = DataStore.Invoices.FirstOrDefault(inv => inv.CaseId == c.CaseId);
                if (invoice != null) paid = DataStore.Payments.Where(p => p.InvoiceId == invoice.InvoiceId).Sum(p => p.AmountPaid);
                decimal remaining = total - paid;

                grandTotal += total;
                grandPaid += paid;
                grandRemaining += remaining;

                string statusText = c.Status == CaseStatus.Completed ? "مكتمل" : "قيد العلاج";

                string[] rowData = { 
                    c.OpenedDate.ToString("yyyy-MM-dd"), 
                    c.Treatment, 
                    c.DoctorName, 
                    total.ToString("F2"), 
                    paid.ToString("F2"), 
                    remaining.ToString("F2"), 
                    statusText 
                };

                for (int i = 0; i < rowData.Length; i++)
                {
                    tempX -= colWidths[i];
                    g.DrawRectangle(Pens.Black, tempX, y, colWidths[i], 30);
                    g.DrawString(rowData[i], normalFont, Brushes.Black, new RectangleF(tempX, y, colWidths[i], 30), centerFormat);
                }
                y += 30;
            }

            y += 20;
            g.DrawString($"إجمالي تكلفة العلاجات: {grandTotal:F2} د.ل", boldFont, Brushes.Black, new RectangleF(margin, y, width - (2 * margin), 25), rtlFormat);
            y += 30;
            g.DrawString($"إجمالي المدفوع: {grandPaid:F2} د.ل", boldFont, Brushes.Black, new RectangleF(margin, y, width - (2 * margin), 25), rtlFormat);
            y += 30;
            g.DrawString($"إجمالي الديون المتبقية: {grandRemaining:F2} د.ل", boldFont, Brushes.Red, new RectangleF(margin, y, width - (2 * margin), 25), rtlFormat);
        }
    }
}
