using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace DentalCare
{
    class Program
    {
        static Agenda agenda;

        /*
        static void PrintPatient(Patient p)
        {
            WriteLine($"{p.Id} - {p.FullName}.");
        }
        */


        //static void MainLambda(string[] args)
        //{
        //    Agenda agenda = new Agenda();
        //    List<Patient> patients = agenda.patients;

        //    /*
        //    Patient pa = null;
        //    foreach (var p in patients)
        //    {
        //        if (p.FirstName == "Diego")
        //        {
        //            pa = p;
        //        }
        //    }
        //    */

        //    patients.Sort((p1, p2) => p1.Id.CompareTo(p2.Id));
        //    patients.FindAll(p => p.LastName[0] == 'S')
        //        .ForEach(p => WriteLine($"{p.Id} - {p.FullName}."));

        //    WriteLine();

        //    Patient pa = patients.Find(p => p.FirstName == "Diego");
        //    WriteLine($"ENCONTRADO: {pa.Id} - {pa.FullName}.");

        //    WriteLine();

        //    patients.ForEach(p => WriteLine($"{p.Id} - {p.FullName}."));

        //    int sum = 0;
        //    patients.ForEach(p => sum += p.Id);

        //    //patients.ForEach(PrintPatient);

        //    /*
        //    foreach (var p in patients)
        //    {
        //        WriteLine($"{p.Id} - {p.FullName}.");
        //    }
        //    */

        //    /*
        //    for (int i = 0; i < patients.Count; ++i)
        //    {
        //        WriteLine($"{patients[i].Id} - {patients[i].LastName}, {patients[i].FirstName}.");
        //    }
        //    */
        //}

        static void Main(string[] args)
        {
            agenda = new Agenda();

            int opcion = -1;
            do
            {
                Clear();
                WriteLine("****************************************");
                WriteLine("*     DENTALCARE (MENU PRINCIPAL)      *");
                WriteLine("****************************************");
                WriteLine();
                WriteLine("\t1. Consultas");
                WriteLine("\t2. Citas");
                WriteLine("\t0. Salir");
                WriteLine();
                Write("Elige una opción: ");

                opcion = Convert.ToInt32(ReadLine());
                switch (opcion)
                {
                    case 1:
                        SubmenuConsultas();
                        break;

                    case 2:
                        SubmenuCitas();
                        break;

                    case 0:
                        WriteLine("\n¡GRACIAS POR UTILIZAR EL PROGRAMA!");
                        break;

                    default:
                        WriteLine("\n¡OPCION NO VÁLIDA!");
                        ReadKey();
                        break;
                }
            }
            while (opcion != 0);
        }

        static void SubmenuConsultas()
        {
            int opcion = -1;
            do
            {
                Clear();
                WriteLine("****************************************");
                WriteLine("*    DENTALCARE (SUBMENU CONSULTAS)    *");
                WriteLine("****************************************");
                WriteLine();
                WriteLine("\t1. Citas por paciente");
                WriteLine("\t2. Citas por día");
                WriteLine("\t0. Volver");
                WriteLine();
                Write("Elige una opción: ");

                opcion = Convert.ToInt32(ReadLine());
                switch (opcion)
                {
                    case 1:
                        OpcionCitasPorPaciente();
                        break;

                    case 2:
                        OpcionCitasPorDia();
                        ReadKey();
                        break;

                    case 0:
                        break;

                    default:
                        WriteLine("\n¡OPCION NO VÁLIDA!");
                        ReadKey();
                        break;
                }
            }
            while (opcion != 0);
        }

        static void OpcionCitasPorPaciente()
        {
            Clear();
            WriteLine("****************************************");
            WriteLine("*      REPORTE (CITAS PENDIENTES)      *");
            WriteLine("****************************************");
            WriteLine();

            agenda.GetPendingAppointments()
                .ForEach(a => WriteLine($"{a.Patient.FullName}. {a.Day.Name} - {a.Time.Description}"));

            WriteLine();
            ReadKey();
        }

        static void OpcionCitasPorDia()
        {
            Clear();
            WriteLine("****************************************");
            WriteLine("*      REPORTE (CITAS PENDIENTES)      *");
            WriteLine("****************************************");
            WriteLine();

            agenda.GetDays().ForEach(d =>
            {
                WriteLine($"{d.Name}");
                var appointments = agenda.GetPendingAppointmentsPerDay(d);
                if (appointments.Count > 0)
                {
                    appointments.ForEach(a =>
                        WriteLine($"\t{a.Time.Description} - {a.Patient.FullName}."));
                }
                else
                {
                    WriteLine($"\tNo hay citas pendientes.");
                }
            });

            WriteLine();
            ReadKey();
        }

        static void SubmenuCitas()
        {
            int opcion = -1;
            do
            {
                Clear();
                WriteLine("****************************************");
                WriteLine("*      DENTALCARE (SUBMENU CITAS)      *");
                WriteLine("****************************************");
                WriteLine();
                WriteLine("\t1. Agendar");
                WriteLine("\t2. Cancelar");
                WriteLine("\t0. Volver");
                WriteLine();
                Write("Elige una opción: ");

                opcion = Convert.ToInt32(ReadLine());
                switch (opcion)
                {
                    case 1:
                        OpcionAgendar();
                        break;

                    case 2:
                        OpcionCancelar();
                        break;

                    case 0:
                        break;

                    default:
                        WriteLine("\n¡OPCION NO VÁLIDA!");
                        ReadKey();
                        break;
                }
            }
            while (opcion != 0);
        }

        static void OpcionAgendar()
        {
            Clear();
            WriteLine("****************************************");
            WriteLine("*            AGENDAR CITAS             *");
            WriteLine("****************************************");
            WriteLine();

            Write("Clave del paciente: ");
            int patientId = Convert.ToInt32(ReadLine());

            if (agenda.ValidatePatientId(patientId))
            {
                if (!agenda.HasPendingAppointment(patientId))
                {
                    List<Day> availableDays = agenda.GetAvailableDays();
                    if (availableDays.Count > 0)
                    {
                        WriteLine("\n*** Días disponibles ***");
                        for (int i = 0; i < availableDays.Count; ++i)
                        {
                            WriteLine($"{i} - {availableDays[i].Name}");
                        }

                        Write("\nElige un día: ");
                        int dayIndex = Convert.ToInt32(ReadLine());
                        Day selectedDay = availableDays[dayIndex];

                        List<Time> availableTimes = agenda.GetAvailableTime(selectedDay);
                        WriteLine("\n*** Horas disponibles ***");
                        for (int i = 0; i < availableTimes.Count; ++i)
                        {
                            WriteLine($"{i} - {availableTimes[i].Description}");

                            if (i == availableTimes.Count - 1)
                            {
                                WriteLine($"{i + 1} - Cancelar");
                            }
                        }

                        Write("\nElige una hora (o cancelar): ");
                        int timeIndex = Convert.ToInt32(ReadLine());
                        if (timeIndex < availableTimes.Count)
                        {
                            Time selectedTime = availableTimes[timeIndex];
                            agenda.CreateAppointment(patientId, selectedDay, selectedTime);

                            WriteLine("\n¡HORARIO ASIGNADO!");
                        }
                        else
                        {
                            WriteLine("\n¡HORARIO NO ASIGNADO!");
                        }
                    }
                    else
                    {
                        WriteLine("\n¡No hay días disponibles para citas!");
                    }
                }
                else
                {
                    WriteLine("\n¡Paciente ya posee una cita!");
                }
            }
            else
            {
                WriteLine("\n¡ID del paciente no es válido!");
            }

            WriteLine();
            ReadKey();
        }

        static void OpcionCancelar()
        {
            Clear();
            WriteLine("****************************************");
            WriteLine("*            CANCELAR CITAS            *");
            WriteLine("****************************************");
            WriteLine();

            Write("Clave del paciente: ");
            int patientId = Convert.ToInt32(ReadLine());

            if (agenda.ValidatePatientId(patientId))
            {
                if (agenda.HasPendingAppointment(patientId))
                {
                    Write("\n¿Confirma que desea borrar cita? [s/n]: ");
                    if (ReadLine().Trim().ToUpper()[0] == 'S')
                    {
                        agenda.CancelAppointment(patientId); // 406268, 899160

                        WriteLine("\n¡CITA CANCELADA!");
                    }
                    else
                    {
                        WriteLine("\n¡CITA NO CANCELADA!");
                    }
                }
                else
                {
                    WriteLine("\n¡Paciente no posee una cita!");
                }
            }
            else
            {
                WriteLine("\n¡ID del paciente no es válido!");
            }

            WriteLine();
            ReadKey();
        }

        //delegate double Calculate3(int a, int b, int c);

        //static double Suma(int x, int y, int z)
        //{
        //    return x + y + z;
        //}

        //static double Promedio(int x, int y, int z)
        //{
        //    return (x + y + z) / 3.0;
        //}

        //static void Main(string[] args)
        //{
        //    int a = 10, b = 5, c = 3;

        //    //...
        //    Calculate3 f = (x, y, z) => x + y + z;
        //    //...
        //    WriteLine($"Suma: {f(a, b, c)}");
        //    //...
        //    f = (x, y, z) => (x + y + z) / 3.0;
        //    //...
        //    WriteLine($"Promedio: {f(a, b, c)}");

        //    Agenda agenda = new Agenda();
        //}
    }
}
