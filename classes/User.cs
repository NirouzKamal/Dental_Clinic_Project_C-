using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinicProject
{
    public enum UserRole { Admin, Receptionist, Doctor }
    public class User
    {
        public string UserId { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public UserRole Role { get; set; }
        public decimal BaseSalary { get; set; } = 0;
        public bool IsActive { get; set; } = true;

        public override string ToString()
        {
            return FullName ?? Username;
        }
    }
}
