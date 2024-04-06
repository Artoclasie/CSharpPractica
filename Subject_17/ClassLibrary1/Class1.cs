using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ClaTriangle
    {
        private double sideA, sideB, sideC;

        public void InputSides(double a, double b, double c)
        {
            sideA = a;
            sideB = b;
            sideC = c;
        }

        public bool CheckExistence()
        {
            return sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA;
        }

        public double CalculatePerimeter()
        {
            return sideA + sideB + sideC;
        }

        public double CalculateArea()
        {
            double s = CalculatePerimeter() / 2;
            return Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
        }

        public string DetermineType()
        {
            if (sideA == sideB && sideB == sideC)
                return "Равносторонний";
            else if (sideA == sideB || sideA == sideC || sideB == sideC)
                return "Равнобедренный";
            else
                return "Разносторонний";
        }
    }

    public class Rectangle
    {
        private double length;
        private double width;

        public void InputSides(double l, double w)
        {
            length = l;
            width = w;
        }

        public double CalculatePerimeter()
        {
            return 2 * (length + width);
        }

        public double CalculateArea()
        {
            return length * width;
        }
    }
}
