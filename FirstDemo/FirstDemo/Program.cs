using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace FirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool option = false;

            do
            {
                Clear();
                WriteLine("***********************************************");
                WriteLine("Este programa resuelve la ecuación ax^2+bx+c=0");
                WriteLine("***********************************************");
                WriteLine("\nIntroduce los valores");

                Write("a: ");
                int a = Convert.ToInt32(ReadLine());
                Write("b: ");
                int b = Convert.ToInt32(ReadLine());
                Write("c: ");
                int c = Convert.ToInt32(ReadLine());

                if ((a == 0) && (b == 0))
                {
                    WriteLine("\n¡No es una ecuación válida!");
                }
                else if ((a == 0) && (b != 0)) // (b!=0) no es necesario
                {
                    WriteLine("\n¡Es una ecuación lineal!");

                    double x = -c / (double)b; // explicit conversión - casting
                    WriteLine($"La solución es: x = {x}");
                }
                else // if (a != 0)
                {
                    double D = b * b - 4 * a * c;
                    if (D == 0)
                    {
                        double x = -b / (2.0 * a);

                        WriteLine("\n¡Raíces reales e iguales!");
                        WriteLine($"x1 = x2 = {x}");
                    }
                    else if (D > 0)
                    {
                        double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                        double x2 = (-b - Math.Sqrt(D)) / (2 * a);

                        WriteLine("\n¡Raíces reales y diferentes!");
                        WriteLine($"x1 = {x1}");
                        WriteLine($"x2 = {x2}");
                    }
                    else // if (D < 0)
                    {
                        double real = -b / (2.0 * a);
                        double imag = Math.Sqrt(-D) / (2.0 * a);

                        WriteLine("\n¡Raíces complejas conjugadas!");
                        WriteLine($"x1 = {real:f4} + j {imag:f4}");
                        WriteLine($"x2 = {real:f4} - j {imag:f4}");
                    }
                }

                Write("\n¿Deseas solucionar otra ecuación? [s/n]: ");
                option = ReadLine().Trim().ToUpper()[0] == 'S';
            } while (option);

            WriteLine("\n¡Gracias por utilizar el programa!");
        }
    }
}
