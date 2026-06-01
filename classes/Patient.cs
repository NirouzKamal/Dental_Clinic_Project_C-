using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinicProject.classes
{
    public class Patient
    {
        public string PatientId { get; set; }
        public string FileNumber { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public bool IsActive { get; set; } = true;
        public string Gender { get; set; }        // "Male" / "Female"
        public string MedicalHistory { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
