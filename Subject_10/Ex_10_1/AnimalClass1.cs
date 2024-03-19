using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_10_1
{
    class Animal
    {
        private string name;
        private double height;

        public Animal(string name, double height)
        {
            this.name = name;
            this.height = height;
        }

        public string GetName()
        {
            return name;
        }

        public double GetHeight()
        {
            return height;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Кличка: {name}");
            Console.WriteLine($"Рост: {height} м");
        }

        public double Weight(int k)
        {
            return k * Math.Pow(height, 3);
        }
    }
}
