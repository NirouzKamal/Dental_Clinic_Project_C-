using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinicProject.classes
{
    public class Doctor
    {
        public string DoctorId { get; set; }
        public string UserId { get; set; }          // ربط بـ User
        public string FullName { get; set; }
        public string Specialty { get; set; }
        public string Phone { get; set; }
        public decimal CommissionPct { get; set; } // % راتب الطبيب
        public bool IsActive { get; set; } = true;
    }
}
