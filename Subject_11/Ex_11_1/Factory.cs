using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_11_1
{
    internal class Factory: Construction
    {
        private double weight;

        public Factory(string name, double weight) : base(name)
        {
            this.weight = weight;
        }

        public override void DisplayResults()
        {
            base.DisplayResults();
            double fabricUsage = 0.000002 * weight;
            Console.WriteLine($"Высота фундамента: {fabricUsage:F2} метров");
        }
    }
}
