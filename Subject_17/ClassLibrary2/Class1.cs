using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Furniture
    {
        public string Material { get; set; }
        public string Color { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }

        public Furniture(string material, string color, double height, double width, double length)
        {
            Material = material;
            Color = color;
            Height = height;
            Width = width;
            Length = length;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine("Материал: " + Material);
            Console.WriteLine("Цвет: " + Color);
            Console.WriteLine("Высота: " + Height + " см");
            Console.WriteLine("Ширина: " + Width + " см");
            Console.WriteLine("Длина: " + Length + " см");
        }
    }

    public class Chair : Furniture
    {
        public int Legs { get; set; }

        public Chair(string material, string color, double height, double width, double length, int legs)
            : base(material, color, height, width, length)
        {
            Legs = legs;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Количество ножек: " + Legs);
        }
    }

    public class Table : Furniture
    {
        public int NumberOfSeats { get; set; }

        public Table(string material, string color, double height, double width, double length, int seats)
            : base(material, color, height, width, length)
        {
            NumberOfSeats = seats;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Количество мест: " + NumberOfSeats);
        }
    }
}

