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
        public Box() :
            this(1)
        {
        }

        public Box(int size) :
            this(size, size, size)
        {
        }

        public Box(int width, int length, int height)
        {
            Width = width;
            Length = length;
            Height = height;
        }

        public Box(Box box) :
            this(box.width, box.length, box.height)
        {
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Box[] boxes = new Box[5];
            //Box[] boxes =
            //{
            //    new Box(),
            //    new Box(1, 2, 3),
            //    new Box(3, 2, 1),
            //    new Box(),
            //    new Box(5),
            //    new Box(2)
            //};

            //boxes[2].Height = 10;
            //boxes[6] = new Box(100);

            List<Box> boxes = new List<Box>()
            {
                new Box(),
                new Box(1, 2, 3),
                new Box(3, 2, 1),
                new Box(),
                new Box(5),
                new Box(2)
            };

            boxes.Add(new Box(100));
            boxes.RemoveAt(4);
            boxes.Insert(0, new Box(50));

            boxes[0].Width = 20;

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
