using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinicProject.classes
{
    internal class DoctorWorkSchedule
    {

        public string ScheduleId { get; set; }
        public string DoctorId { get; set; }
        public DayOfWeek DayOfWeek { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public bool IsWorking { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
