using System;
using System.Data;

namespace DentalClinicProject.Reports
{
    /// <summary>
    /// Single-row payload for KashfReceipt.rpt (Crystal Reports).
    /// Table name in the report must be: KashfReceipt
    /// </summary>
    public sealed class KashfReceiptPrintModel
    {
        public string PatientName { get; set; }
        public string FileNumber { get; set; }
        public string DoctorName { get; set; }
        public string VisitType { get; set; }
        public decimal Price { get; set; }
        public decimal PaidAmount { get; set; }
        public DateTime VisitDateTime { get; set; }

        public static KashfReceiptPrintModel FromCase(
            classes.Case clinicCase,
            decimal paidAmount,
            DateTime? visitDateTime = null)
        {
            DateTime dt = visitDateTime ?? clinicCase.OpenedDate;
            return new KashfReceiptPrintModel
            {
                PatientName = clinicCase.PatientName ?? "",
                FileNumber = clinicCase.PatientFileNumber ?? "",
                DoctorName = clinicCase.DoctorName ?? "",
                VisitType = clinicCase.Treatment ?? "",
                Price = clinicCase.Price,
                PaidAmount = paidAmount,
                VisitDateTime = dt
            };
        }

        public DataTable ToDataTable()
        {
            var table = new DataTable("KashfReceipt");
            table.Columns.Add("PatientName", typeof(string));
            table.Columns.Add("FileNumber", typeof(string));
            table.Columns.Add("DoctorName", typeof(string));
            table.Columns.Add("VisitType", typeof(string));
            table.Columns.Add("Price", typeof(decimal));
            table.Columns.Add("PaidAmount", typeof(decimal));
            table.Columns.Add("VisitDate", typeof(string));
            table.Columns.Add("VisitDateTime", typeof(string));
            table.Columns.Add("PriceText", typeof(string));
            table.Columns.Add("PaidAmountText", typeof(string));

            table.Rows.Add(
                PatientName ?? "",
                FileNumber ?? "",
                DoctorName ?? "",
                VisitType ?? "",
                Price,
                PaidAmount,
                VisitDateTime.ToString("yyyy-MM-dd"),
                VisitDateTime.ToString("yyyy-MM-dd HH:mm"),
                Price.ToString("N2") + " د.ل",
                PaidAmount.ToString("N2") + " د.ل");

            return table;
        }
    }
}
