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
        // estado del objeto:
        //      combinación de los valores de sus variables internas
        private int width;
        private int length;
        private int height;

        public int Width
        {
            get => width;

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("value"); // generar excepción
                }

                width = value;
            }
        }

        public int Length
        {
            // public int get-Length()
            get => length;

            // public void set-Length(int value)
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("value"); // generar excepción
                }

                length = value;
            }
        }

        public int Height
        {
            get => height;

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("value"); // generar excepción
                }

                height = value;
            }
        }

        //public int GetLength()
        //{
        //    return length;
        //}

        //public void SetLength(int length)
        //{
        //    if (length <= 0)
        //    {
        //        throw new ArgumentException("l"); // generar excepción
        //    }

        //    this.length = length;
        //}

        public int Volume
        {
            get => width * length * height;
        }

        //public int CalculateVolume() => width * length * height;

        // empty constructor (default)
        // constructor sin parámetros
        public Box()
        {
            width = 1;
            length = 1;
            height = 1;
        }

        public Box(int size)
        {
            width = size;
            length = size;
            height = size;
        }

        public Box(int width, int length, int height)
        {
            this.width = width;
            this.length = length;
            this.height = height;
        }

        public Box(Box box)
        {
            width = box.width;
            length = box.length;
            height = box.height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Box[] boxes = new Box[5];
            Box[] boxes =
            {
                new Box(),
                new Box(1, 2, 3),
                new Box(3, 2, 1),
                new Box(),
                new Box(5),
                new Box(2)
            };

            foreach (Box box in boxes)
            {
                WriteLine($"\nVolumen = {box.Volume}");
                WriteLine($"->({box.Width},{box.Length},{box.Height})");
            }

            //for (int i = 0; i < boxes.Length; ++i)
            //{
            //    WriteLine($"\nVolumen = {boxes[i].Volume}");
            //    WriteLine($"->({boxes[i].Width},{boxes[i].Length},{boxes[i].Height})");
            //}
        }

        static void Main2(string[] args)
        {
            Box b1 = new Box(3, 2, 1);
            //b1.Width = 3; // el width de la caja a la que hace referencia b1
            //b1.Length = 2;
            //b1.Height = 1;

            Box b2 = new Box(b1) { Width = 6 };
            //b2.Width = 6;
            //b2.Length = b1.Length;
            //b2.Height = b1.Height;

            WriteLine($"\nVolumen = {b1.Volume}");
            WriteLine($"b1->({b1.Width},{b1.Length},{b1.Height})");

            WriteLine($"\nVolumen = {b2.Volume}");
            WriteLine($"b2->({b2.Width},{b2.Length},{b2.Height})");

            //b2.height = 2 * b1.height + 3 * b1.height;
            //b2.SetLength(2 * b1.GetLength() + 3 * b1.GetLength());

            //b2.Length += 2;
            //b2.Length = b2.Length + 2;
            //b2.SetLength(b2.GetLength() + 2);
        }
    }
}
