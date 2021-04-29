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
                switch(opcion)
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
                        WriteLine("\n¡OPCION NO IMPLEMENTADA!");
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
                    case 2:
                        WriteLine("\n¡OPCION NO IMPLEMENTADA!");
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
