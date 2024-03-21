using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_11_2
{
    class Shirt : Cloth
    {
        public Shirt(string material, double area) : base(material, area) { }
        public override double CalculateTotalFabricConsumption()
        {
            return area * 1.5;
        }
    }
}
