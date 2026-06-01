using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinicProject.classes
{
    internal class Patient
    {
        public int PatientId { get; set; }
        public string FileNumber { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }
        public bool IsActive { get; set; } = true;
        public string Gender { get; set; }        // "Male" / "Female"
        public string MedicalHistory { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
