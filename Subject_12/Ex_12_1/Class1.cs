using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_12_1
{
    delegate double CalcFigure(double radius);

    class Class1
    {
        public double Get_Length(double radius)
        {
            return 2 * Math.PI * radius;
        }

        public double Get_Area(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public double Get_Volume(double radius)
        {
            return 4.0 / 3.0 * Math.PI * Math.Pow(radius, 3);
        }
    }
}