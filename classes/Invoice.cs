using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinicProject.classes
{
    internal class Invoice
    {
        public string InvoiceId { get; set; }
        public string CaseId { get; set; }           // فاتورة واحدة لكل حالة
        public string PatientId { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal DoctorShare { get; set; }   // TotalAmount × CommissionPct%
        public decimal ClinicRevenue { get; set; } // TotalAmount - DoctorShare
        public DateTime IssuedDate { get; set; } = DateTime.Now;
        public bool IsPaid { get; set; }
    }
}
