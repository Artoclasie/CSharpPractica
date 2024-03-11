using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ex_2_1
{
    public class A
    {
       private double a;
       private double b;

        public double NumberA { get; set; }
        public double NumberB { get; set; }

        public  A(double a, double b) 
        {
            NumberA = a;
            NumberB = b;
        }

        public double OfQuotient(double a, double b)
        {
            double result1 = a/b;
            return result1;
        }

        public double ValueExpressions(double a, double b)
        {
            double result2 = Math.Pow(a+b, 0.33);
            return result2;
        }
    }
}
