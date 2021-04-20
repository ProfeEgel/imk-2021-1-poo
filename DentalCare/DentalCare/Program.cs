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
        delegate double Calculate3(int a, int b, int c);

        //static double Suma(int x, int y, int z)
        //{
        //    return x + y + z;
        //}

        //static double Promedio(int x, int y, int z)
        //{
        //    return (x + y + z) / 3.0;
        //}

        static void Main(string[] args)
        {
            //int a = 10, b = 5, c = 3;

            ////...
            //Calculate3 f = (x, y, z) => x + y + z;
            ////...
            //WriteLine($"Suma: {f(a, b, c)}");
            ////...
            //f = (x, y, z) => (x + y + z) / 3.0;
            ////...
            //WriteLine($"Promedio: {f(a, b, c)}");

            Agenda agenda = new Agenda();
        }
    }
}
