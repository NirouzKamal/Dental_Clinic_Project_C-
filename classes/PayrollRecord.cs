using System;

namespace DentalClinicProject.classes
{
    public class PayrollRecord
    {
        public string PayrollId { get; set; }
        public string UserId { get; set; }
        public string FullName { get; set; } // for easy display
        public string Role { get; set; } // Admin, Receptionist, or Doctor
        public int Month { get; set; }
        public int Year { get; set; }
        
        public decimal BaseSalaryPaid { get; set; }
        public decimal CommissionPaid { get; set; }
        public decimal Deductions { get; set; }
        public decimal NetPay { get; set; }
        
        public DateTime IssueDate { get; set; }
    }
}
