using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinicProject.classes
{
    internal class Payment
    {
        public int PaymentId { get; set; }
        public int InvoiceId { get; set; }
        public decimal AmountPaid { get; set; }
        public DateTime PaymentDate { get; set; } = DateTime.Now;
        public string Method { get; set; }         // "Cash" / "Card"

        // تتبع الدين
        public decimal Remaining => GetInvoiceTotal() - AmountPaid;

        // هنحسبها من الـ DataStore
        private decimal _invoiceTotal;
        public void SetInvoiceTotal(decimal total) => _invoiceTotal = total;
        private decimal GetInvoiceTotal() => _invoiceTotal;
    }
}
