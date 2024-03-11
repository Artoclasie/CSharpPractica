using System.Runtime.InteropServices;
using static System.Console;

namespace Ex_2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Write("a: ");
            double a = Convert.ToDouble(ReadLine());

            Write("b: ");
            double b = Convert.ToDouble(ReadLine());

            A classA = new A(a,b);

            double result1 = classA.OfQuotient(a,b);
            WriteLine($"Вычисление частного:{result1}");

            double result2 = classA.ValueExpressions(a, b);
            WriteLine($"Значение определенного выражения:{result2}");
        }
    }
}