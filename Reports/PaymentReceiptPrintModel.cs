using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using DentalClinicProject.classes;

namespace DentalClinicProject.Reports
{
    public sealed class PaymentReceiptLineItem
    {
        public int LineNumber { get; set; }
        public string Treatment { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal LineTotal { get; set; }
    }

    /// <summary>
    /// Combined invoice for all services in one visit batch.
    /// Crystal: header table PaymentReceipt + detail table PaymentReceiptLine
    /// </summary>
    public sealed class PaymentReceiptPrintModel
    {
        public string ReceiptNumber { get; set; }
        public string PatientName { get; set; }
        public string FileNumber { get; set; }
        public string DoctorName { get; set; }
        public string ReceptionistName { get; set; }
        public string Signature { get; set; }
        public string PaymentMethod { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal PaidAmount { get; set; }
        public decimal RemainingAmount { get; set; }
        public string AmountInWords { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime PaymentDateTime { get; set; }
        public List<PaymentReceiptLineItem> Lines { get; set; } = new List<PaymentReceiptLineItem>();

        public static PaymentReceiptPrintModel FromVisitCases(
            IList<Case> visitCases,
            string receiptNumber,
            decimal paidAmount,
            decimal remainingAmount,
            string receptionistName,
            string paymentMethod,
            DateTime? paymentDateTime = null)
        {
            var cases = visitCases?.Where(c => c != null).ToList() ?? new List<Case>();
            var first = cases.FirstOrDefault();
            string preparer = receptionistName ?? "";
            DateTime paymentDt = paymentDateTime ?? DateTime.Now;
            DateTime createdDt = cases.Count > 0
                ? cases.Min(c => c.OpenedDate)
                : paymentDt;

            decimal gross = CaseVisitGrouping.SumGrossPrice(cases);
            decimal discount = CaseVisitGrouping.SumDiscount(cases);
            decimal net = CaseVisitGrouping.SumFinalPrice(cases);

            var lines = new List<PaymentReceiptLineItem>();
            int n = 1;
            foreach (var c in cases)
            {
                lines.Add(new PaymentReceiptLineItem
                {
                    LineNumber = n++,
                    Treatment = c.Treatment ?? "",
                    Quantity = c.ToothCount > 0 ? c.ToothCount : 1,
                    UnitPrice = c.Price,
                    LineTotal = c.FinalPrice
                });
            }

            return new PaymentReceiptPrintModel
            {
                ReceiptNumber = receiptNumber ?? "",
                PatientName = first?.PatientName ?? "",
                FileNumber = first?.PatientFileNumber ?? "",
                DoctorName = first?.DoctorName ?? "",
                ReceptionistName = preparer,
                Signature = preparer,
                PaymentMethod = paymentMethod ?? "",
                TotalPrice = gross,
                Discount = discount,
                TotalAmount = net,
                PaidAmount = paidAmount,
                RemainingAmount = remainingAmount < 0 ? 0 : remainingAmount,
                AmountInWords = AmountToArabicWords(net),
                CreatedDateTime = createdDt,
                PaymentDateTime = paymentDt,
                Lines = lines
            };
        }

        public DataSet ToDataSet()
        {
            var ds = new DataSet("DsPaymentReceipt");

            var header = new DataTable("PaymentReceipt");
            header.Columns.Add("ReceiptNumber", typeof(string));
            header.Columns.Add("PatientName", typeof(string));
            header.Columns.Add("FileNumber", typeof(string));
            header.Columns.Add("DoctorName", typeof(string));
            header.Columns.Add("ReceptionistName", typeof(string));
            header.Columns.Add("Signature", typeof(string));
            header.Columns.Add("PaymentMethod", typeof(string));
            header.Columns.Add("TotalPrice", typeof(decimal));
            header.Columns.Add("Discount", typeof(decimal));
            header.Columns.Add("TotalAmount", typeof(decimal));
            header.Columns.Add("PaidAmount", typeof(decimal));
            header.Columns.Add("RemainingAmount", typeof(decimal));
            header.Columns.Add("CreatedDate", typeof(string));
            header.Columns.Add("CreatedTime", typeof(string));
            header.Columns.Add("PaymentDate", typeof(string));
            header.Columns.Add("PaymentDateTime", typeof(string));
            header.Columns.Add("TotalPriceText", typeof(string));
            header.Columns.Add("DiscountText", typeof(string));
            header.Columns.Add("TotalAmountText", typeof(string));
            header.Columns.Add("PaidAmountText", typeof(string));
            header.Columns.Add("RemainingAmountText", typeof(string));
            header.Columns.Add("AmountInWords", typeof(string));

            header.Rows.Add(
                ReceiptNumber ?? "",
                PatientName ?? "",
                FileNumber ?? "",
                DoctorName ?? "",
                ReceptionistName ?? "",
                Signature ?? "",
                PaymentMethod ?? "",
                TotalPrice,
                Discount,
                TotalAmount,
                PaidAmount,
                RemainingAmount,
                CreatedDateTime.ToString("yyyy-MM-dd"),
                CreatedDateTime.ToString("HH:mm"),
                PaymentDateTime.ToString("yyyy-MM-dd"),
                PaymentDateTime.ToString("yyyy-MM-dd HH:mm"),
                TotalPrice.ToString("N2") + " د.ل",
                Discount.ToString("N2") + " د.ل",
                TotalAmount.ToString("N2") + " د.ل",
                PaidAmount.ToString("N2") + " د.ل",
                RemainingAmount.ToString("N2") + " د.ل",
                AmountInWords ?? "");

            var linesTable = new DataTable("PaymentReceiptLine");
            linesTable.Columns.Add("ReceiptNumber", typeof(string));
            linesTable.Columns.Add("LineNumber", typeof(int));
            linesTable.Columns.Add("Treatment", typeof(string));
            linesTable.Columns.Add("Quantity", typeof(int));
            linesTable.Columns.Add("UnitPrice", typeof(decimal));
            linesTable.Columns.Add("LineTotal", typeof(decimal));
            linesTable.Columns.Add("LineTotalText", typeof(string));

            foreach (var line in Lines)
            {
                linesTable.Rows.Add(
                    ReceiptNumber ?? "",
                    line.LineNumber,
                    line.Treatment ?? "",
                    line.Quantity,
                    line.UnitPrice,
                    line.LineTotal,
                    line.LineTotal.ToString("N2"));
            }

            ds.Tables.Add(header);
            ds.Tables.Add(linesTable);
            return ds;
        }

        /// <summary>Legacy single-table export for simple Crystal layouts.</summary>
        public DataTable ToDataTable() => ToDataSet().Tables["PaymentReceipt"];

        private static string AmountToArabicWords(decimal amount)
        {
            int whole = (int)Math.Floor(amount);
            if (whole <= 0)
                return "صفر دينار فقط لا غير";

            if (whole == 240)
                return "مائتان وأربعون ديناراً فقط لا غير";

            return $"{whole:N0} دينار فقط لا غير";
        }
    }
}
