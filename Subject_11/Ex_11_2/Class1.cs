using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_11_2
{
    abstract class Cloth
    {
        protected string material;
        protected double area;
        public Cloth(string material, double area)
        {
            this.material = material;
            this.area = area;
        }
        public string GetMaterial()
        {
            return material;
        }
        public double GetArea()
        {
            return area;
        }
        public abstract double CalculateTotalFabricConsumption();
    }
}
