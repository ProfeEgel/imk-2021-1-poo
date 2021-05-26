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
            var pendings = new List<PendingAppointment>();

            appointments.ForEach(a =>
                    pendings.Add(new PendingAppointment(
                        patients.Find(p => p.Id == a.PatientId),
                        days.Find(d => d.Id == a.DayId),
                        times.Find(t => t.Id == a.TimeId))));

            pendings.Sort((p1, p2) => p1.Patient.FullName.CompareTo(p2.Patient.FullName));

            return pendings;
        }

        public List<Day> GetDays()
        {
            List<Day> days = new List<Day>(this.days);
            days.Sort((d1, d2) => d1.Id.CompareTo(d2.Id));
            return days;
        }

        public List<PendingAppointment> GetPendingAppointmentsPerDay(Day day)
        {
            var pendings = new List<PendingAppointment>();

            appointments.FindAll(a => a.DayId == day.Id).ForEach(a =>
                    pendings.Add(new PendingAppointment(
                        patients.Find(p => p.Id == a.PatientId),
                        days.Find(d => d.Id == a.DayId),
                        times.Find(t => t.Id == a.TimeId))));

            pendings.Sort((p1, p2) => p1.Time.Id.CompareTo(p2.Time.Id));

            return pendings;
        }

        public bool ValidatePatientId(int id) =>
            patients.Exists(p => p.Id == id);

        public bool HasPendingAppointment(int id) =>
            appointments.Exists(a => a.PatientId == id);

        public List<Day> GetAvailableDays()
        {
            var days = new List<Day>(this.days);
            
            // remover días que no estén presentes en schedule
            days.RemoveAll(d => !schedules.Exists(s => s.DayId == d.Id));

            // remover días llenos
            days.RemoveAll(d =>
            {
                bool full = true;
                schedules.FindAll(s => s.DayId == d.Id).ForEach(s =>
                {
                    if (!appointments.Exists(a => a.DayId == s.DayId && a.TimeId == s.TimeId))
                    {
                        full = false;
                    }
                });
                return full;
            });

            return days;
        }

        public List<Time> GetAvailableTime(Day day)
        {
            List<Time> availableTimes = new List<Time>();

            schedules.FindAll(s => s.DayId == day.Id).ForEach(s => {
                if (!appointments.Exists(a => a.DayId == s.DayId && a.TimeId == s.TimeId))
                {
                    availableTimes.Add(times.Find(t => t.Id == s.TimeId));
                }
            });

            return availableTimes;
        }

        public void CreateAppointment(int patientId, Day selectedDay, Time selectedTime)
        {
            appointments.Add(new Appointment(patientId, selectedDay.Id, selectedTime.Id));

            EasyFile<Appointment>.SaveDataToFile("appointments.txt",
                                                 new[] { "PatientId", "DayId", "TimeId" },
                                                 appointments);
        }

        public void CancelAppointment(int patientId)
        {
            appointments.RemoveAll(a => a.PatientId == patientId);

            EasyFile<Appointment>.SaveDataToFile("appointments.txt",
                                                 new[] { "PatientId", "DayId", "TimeId" },
                                                 appointments);
        }

        //private Day DayCallback(string[] tokens)
        //{
        //    //"0|Lunes" => ["0", "Lunes"]
        //    return new Day(Convert.ToInt32(tokens[0]), tokens[1]);
        //}
    }
}
