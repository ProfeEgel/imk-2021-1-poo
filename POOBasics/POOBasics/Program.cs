using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

// Conceptos importantes => (1) Clases y (2) Objetos

namespace POOBasics
{
    class Box
    {
        public int width;
        public int length;
        public int height;

        public static int CalculateVolume(Box box)
        {
            return box.width * box.length * box.height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Box b1 = new Box();
            b1.width = 3; // el width de la caja a la que hace referencia b1
            b1.length = 2;
            b1.height = 1;

            Box b2 = new Box();
            b2.width = 6;
            b2.length = b1.length;
            b2.height = b1.height;

            int volume = Box.CalculateVolume(b1);
            WriteLine($"\nVolumen = {volume}");
            WriteLine($"b1->({b1.width},{b1.length},{b1.height})");

            volume = Box.CalculateVolume(b2);
            WriteLine($"\nVolumen = {volume}");
            WriteLine($"b2->({b2.width},{b2.length},{b2.height})");
        }
    }
}
