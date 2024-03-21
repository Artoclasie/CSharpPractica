using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_11_1
{
    internal class Office: Construction
    {
        private int numberOfFloors;
        public Office(string name, int numberOfFloors) : base(name)
        {
            this.numberOfFloors= numberOfFloors;
        }

        public override void DisplayResults()
        {
            base.DisplayResults();
            double foundationHeight = 0.05 * numberOfFloors;
            Console.WriteLine($"Высота фундамента: {foundationHeight:F2} метров");
        }
    }
}
