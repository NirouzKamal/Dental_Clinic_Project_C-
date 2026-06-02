using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;
using DentalClinicProject.data;
using DentalClinicProject.Reports;

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

        // --- Kashf receipt (fallback when Crystal is unavailable) ---
        public static void PrintKashfReceipt(KashfReceiptPrintModel model, bool showPreview = true)
        {
            if (model == null) return;

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += (sender, e) => PrintKashfReceiptPage(e, model);

            if (!showPreview)
            {
                pd.Print();
                return;
            }

            using (var preview = new PrintPreviewDialog
            {
                Document = pd,
                Width = 600,
                Height = 800,
                ShowIcon = false,
                Text = "معاينة إيصال الكشف"
            })
            {
                preview.ShowDialog();
            }
        }

        private static void PrintKashfReceiptPage(PrintPageEventArgs e, KashfReceiptPrintModel model)
        {
            Graphics g = e.Graphics;
            int y = 20;
            int width = e.PageBounds.Width;
            int margin = 40;

            g.DrawString("عيادة DentCare للأسنان", headerFont, Brushes.Black, new RectangleF(0, y, width, 40), centerFormat);
            y += 40;
            g.DrawString("إيصال كشف", subHeaderFont, Brushes.Black, new RectangleF(0, y, width, 30), centerFormat);
            y += 40;
            g.DrawLine(Pens.Black, margin, y, width - margin, y);
            y += 20;

            g.DrawString($"التاريخ والوقت: {model.VisitDateTime:yyyy-MM-dd HH:mm}", normalFont, Brushes.Black, new RectangleF(margin, y, width - (2 * margin), 25), rtlFormat);
            y += 28;
            g.DrawString($"رقم الملف: {model.FileNumber}", normalFont, Brushes.Black, new RectangleF(margin, y, width - (2 * margin), 25), rtlFormat);
            y += 28;
            g.DrawString($"المريض: {model.PatientName}", boldFont, Brushes.Black, new RectangleF(margin, y, width - (2 * margin), 25), rtlFormat);
            y += 28;
            g.DrawString($"الطبيب: {model.DoctorName}", normalFont, Brushes.Black, new RectangleF(margin, y, width - (2 * margin), 25), rtlFormat);
            y += 28;
            g.DrawString($"نوع الزيارة: {model.VisitType}", normalFont, Brushes.Black, new RectangleF(margin, y, width - (2 * margin), 25), rtlFormat);
            y += 36;
            g.DrawLine(Pens.Black, margin, y, width - margin, y);
            y += 20;

            g.DrawString($"السعر: {model.Price:N2} د.ل", boldFont, Brushes.Black, new RectangleF(margin, y, width - (2 * margin), 25), rtlFormat);
            y += 28;
            g.DrawString($"المدفوع: {model.PaidAmount:N2} د.ل", boldFont, Brushes.Black, new RectangleF(margin, y, width - (2 * margin), 25), rtlFormat);
            y += 40;

            g.DrawString("شكراً لزيارتكم", normalFont, Brushes.Black, new RectangleF(0, y, width, 30), centerFormat);
        }

        public static void PrintPaymentReceipt(PaymentReceiptPrintModel model, bool showPreview = true)
        {
            if (model == null) return;

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += (sender, e) => PrintPaymentReceiptPage(e, model);

            if (!showPreview)
            {
                pd.Print();
                return;
            }

            using (var preview = new PrintPreviewDialog
            {
                Document = pd,
                Width = 600,
                Height = 800,
                ShowIcon = false,
                Text = "معاينة إيصال الدفع"
            })
            {
                preview.ShowDialog();
            }
        }

        private static void PrintPaymentReceiptPage(PrintPageEventArgs e, PaymentReceiptPrintModel model)
        {
            Graphics g = e.Graphics;
            int width = e.PageBounds.Width;
            int margin = 50;
            int contentWidth = width - (2 * margin);
            int y = 30;
            var linePen = Pens.Black;

            // --- Header (no logo) ---
            g.DrawString("عيادة DentCare للأسنان", headerFont, Brushes.Black, new RectangleF(0, y, width, 36), centerFormat);
            y += 32;
            g.DrawString("Dental Clinic — Payment Invoice", normalFont, Brushes.Gray, new RectangleF(0, y, width, 22), centerFormat);
            y += 36;
            g.DrawLine(linePen, margin, y, width - margin, y);
            y += 18;

            // --- Patient block (right side labels like reference invoice) ---
            DrawLabelValue(g, "رقم الإيصال:", model.ReceiptNumber, margin, ref y, contentWidth, boldFont);
            DrawLabelValue(g, "رقم الملف:", model.FileNumber, margin, ref y, contentWidth, normalFont);
            DrawLabelValue(g, "اسم الحالة:", model.PatientName, margin, ref y, contentWidth, boldFont);
            DrawLabelValue(g, "اسم الطبيب:", model.DoctorName, margin, ref y, contentWidth, normalFont);
            y += 10;

            // --- Services table ---
            int tableRight = width - margin;
            int[] colW = { 70, 200, 60, 90 }; // البند | العلاج | العدد | القيمة (RTL)
            int tableLeft = tableRight - colW[0] - colW[1] - colW[2] - colW[3];
            int rowH = 28;

            string[] headers = { "البند", "العلاج", "العدد", "القيمة" };
            int hx = tableRight;
            g.DrawLine(linePen, tableLeft, y, tableRight, y);
            y += 4;
            for (int i = 0; i < headers.Length; i++)
            {
                hx -= colW[i];
                g.DrawString(headers[i], boldFont, Brushes.Black, new RectangleF(hx, y, colW[i], rowH), centerFormat);
            }
            y += rowH;
            g.DrawLine(linePen, tableLeft, y, tableRight, y);
            g.DrawLine(linePen, tableLeft, y - rowH - 4, tableLeft, y);
            g.DrawLine(linePen, tableRight, y - rowH - 4, tableRight, y);
            y += 4;

            if (model.Lines != null && model.Lines.Count > 0)
            {
                foreach (var line in model.Lines)
                {
                    int rx = tableRight;
                    string[] cells =
                    {
                        line.LineNumber.ToString(),
                        line.Treatment ?? "",
                        line.Quantity.ToString(),
                        line.LineTotal.ToString("N2")
                    };
                    for (int i = 0; i < cells.Length; i++)
                    {
                        rx -= colW[i];
                        g.DrawString(cells[i], normalFont, Brushes.Black, new RectangleF(rx, y, colW[i], rowH), centerFormat);
                        g.DrawLine(linePen, rx, y, rx, y + rowH);
                    }
                    g.DrawLine(linePen, tableLeft, y + rowH, tableRight, y + rowH);
                    y += rowH;
                }
            }
            else
            {
                int rx = tableRight - colW[0] - colW[1] - colW[2] - colW[3];
                g.DrawString("1", normalFont, Brushes.Black, new RectangleF(tableRight - colW[0], y, colW[0], rowH), centerFormat);
                g.DrawString("-", normalFont, Brushes.Black, new RectangleF(rx + colW[1] + colW[2], y, colW[1], rowH), centerFormat);
                y += rowH;
                g.DrawLine(linePen, tableLeft, y, tableRight, y);
            }

            y += 16;
            g.DrawLine(linePen, margin, y, width - margin, y);
            y += 20;

            // --- Totals (right block like reference) ---
            int totalsX = width - margin - 280;
            DrawTotalRow(g, "الإجمالي العام", model.TotalPrice, totalsX, ref y, contentWidth);
            DrawTotalRow(g, "التخفيض", model.Discount, totalsX, ref y, contentWidth);
            DrawTotalRow(g, "قيمة الإيصال", model.TotalAmount, totalsX, ref y, contentWidth, boldFont);
            DrawTotalRow(g, "المدفوع", model.PaidAmount, totalsX, ref y, contentWidth, boldFont);
            DrawTotalRow(g, "المتبقي", model.RemainingAmount, totalsX, ref y, contentWidth, boldFont, Brushes.DarkRed);

            y += 8;
            g.DrawString("القيمة بالحروف: " + (model.AmountInWords ?? ""), normalFont, Brushes.Black,
                new RectangleF(margin, y, contentWidth, 40), rtlFormat);
            y += 44;

            // --- Footer: preparer + signature (left area in reference) ---
            g.DrawString($"مُعد الإيصال: {model.ReceptionistName}", normalFont, Brushes.Black,
                new RectangleF(margin, y, contentWidth / 2, 25), rtlFormat);
            y += 36;
            g.DrawString("التوقيع:", normalFont, Brushes.Black, new RectangleF(margin, y, 80, 25), rtlFormat);
            g.DrawLine(linePen, margin + 70, y + 18, margin + 320, y + 18);
            if (!string.IsNullOrWhiteSpace(model.Signature))
                g.DrawString(model.Signature, normalFont, Brushes.DarkBlue, new RectangleF(margin + 75, y, 240, 25), rtlFormat);

            y += 50;
            g.DrawString($"طريقة الدفع: {model.PaymentMethod}", normalFont, Brushes.Black,
                new RectangleF(margin, y, contentWidth, 22), rtlFormat);
            y += 24;
            g.DrawString($"تاريخ الإنشاء: {model.CreatedDateTime:yyyy-MM-dd}    وقت الإنشاء: {model.CreatedDateTime:HH:mm}",
                normalFont, Brushes.Gray, new RectangleF(margin, y, contentWidth, 22), rtlFormat);
            y += 22;
            g.DrawString(model.PaymentDateTime.ToString("dddd, dd MMMM yyyy", new System.Globalization.CultureInfo("ar-LY")),
                normalFont, Brushes.Gray, new RectangleF(margin, y, contentWidth, 22), rtlFormat);
        }

        private static void DrawLabelValue(Graphics g, string label, string value, int margin, ref int y, int contentWidth, Font valueFont)
        {
            g.DrawString(label, boldFont, Brushes.Black, new RectangleF(margin, y, 120, 24), rtlFormat);
            float vx = margin + contentWidth - 280;
            g.DrawLine(new Pen(Color.Gray) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dot },
                vx, y + 20, margin + contentWidth, y + 20);
            g.DrawString(value ?? "", valueFont, Brushes.Black, new RectangleF(vx, y, 280, 24), rtlFormat);
            y += 30;
        }

        private static void DrawTotalRow(Graphics g, string label, decimal amount, int x, ref int y, int width,
            Font font = null, Brush brush = null)
        {
            font = font ?? normalFont;
            brush = brush ?? Brushes.Black;
            g.DrawString(label, font, brush, new RectangleF(x, y, 140, 24), rtlFormat);
            g.DrawString(amount.ToString("N2"), font, brush, new RectangleF(x + width - 280, y, 120, 24), rtlFormat);
            y += 28;
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
