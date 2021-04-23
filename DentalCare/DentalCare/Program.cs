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
            List<PendingAppointment> appointments = agenda.GetPendingAppointments();

            Clear();
            WriteLine("****************************************");
            WriteLine("*      REPORTE (CITAS PENDIENTES)      *");
            WriteLine("****************************************");
            WriteLine();

            foreach (PendingAppointment a in appointments)
            {
                WriteLine($"{a.Patient.LastName}, {a.Patient.FirstName}. {a.Day.Name} - {a.Time.Description}");
            }

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
