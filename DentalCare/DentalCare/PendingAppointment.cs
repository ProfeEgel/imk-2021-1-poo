using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalCare
{
    class PendingAppointment
    {
        public Patient Patient { get; }
        public Day Day { get; }
        public Time Time { get; }

        public PendingAppointment(Patient patient, Day day, Time time)
        {
            Patient = patient;
            Day = day;
            Time = time;
        }
    }
}
