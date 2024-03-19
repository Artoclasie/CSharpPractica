using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_10_1
{
    class Cat : Animal
    {
        private string breed;

        public Cat(string name, double height, string breed) : base(name, height)
        {
            this.breed = breed;
        }

        public string GetBreed()
        {
            return breed;
        }

        public new void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Порода: {breed}");
        }

        public new double Weight(int k)
        {
            return base.Weight(k) * 1000;
        }
    }
}
