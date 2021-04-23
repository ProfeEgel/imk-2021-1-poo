using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace DentalCare
{
    class Agenda
    {
        private List<Day> days;
        private List<Time> times;
        private List<Schedule> schedules;
        private List<Patient> patients;
        private List<Appointment> appointments;

        public Agenda()
        {
            days = EasyFile<Day>.LoadDataFromFile("days.txt",
                tokens => new Day(Convert.ToInt32(tokens[0]), tokens[1]));

            times = EasyFile<Time>.LoadDataFromFile("time.txt",
                tokens => new Time(Convert.ToInt32(tokens[0]), tokens[1]));

            schedules = EasyFile<Schedule>.LoadDataFromFile("schedule.txt",
                tokens => new Schedule(Convert.ToInt32(tokens[0]), Convert.ToInt32(tokens[1])));

            patients = EasyFile<Patient>.LoadDataFromFile("patients.txt",
                tokens => new Patient(Convert.ToInt32(tokens[0]), tokens[1], tokens[2]));

            appointments = EasyFile<Appointment>.LoadDataFromFile("appointments.txt",
                tokens => new Appointment(Convert.ToInt32(tokens[0]),
                                          Convert.ToInt32(tokens[1]),
                                          Convert.ToInt32(tokens[2])));
        }

        public List<PendingAppointment> GetPendingAppointments()
        {
            List<PendingAppointment> appointments = new List<PendingAppointment>();

            // TO BE REPLACED
            appointments.Add(new PendingAppointment(patients[0], days[0], times[0]));
            appointments.Add(new PendingAppointment(patients[1], days[1], times[1]));
            appointments.Add(new PendingAppointment(patients[2], days[2], times[2]));
            appointments.Add(new PendingAppointment(patients[3], days[3], times[3]));
            // TO BE REPLACED

            return appointments;
        }

        //private Day DayCallback(string[] tokens)
        //{
        //    //"0|Lunes" => ["0", "Lunes"]
        //    return new Day(Convert.ToInt32(tokens[0]), tokens[1]);
        //}
    }
}
