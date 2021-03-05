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
            else if ((a==0) && (b!=0)) // (b!=0) no es necesario
            {
                WriteLine("\n¡Es una ecuación lineal!");

                double x = -c / (double)b; // explicit conversión - casting
                WriteLine($"La solución es: x = {x}");
            }
        }
    }
}
