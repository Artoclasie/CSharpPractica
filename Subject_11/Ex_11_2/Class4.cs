using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_11_2
{
    class Pants : Cloth
    {
        public Pants(string material, double area) : base(material, area) { }

        public override double CalculateTotalFabricConsumption()
        {
            return area * 2;
        }
    }
}
