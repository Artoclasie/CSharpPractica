using static System.Console;
namespace Subject_3
{
    internal class Program
    {
        static double max(double a, double b)
        {
            return (a>b) ? a: b;
        }
        public static double F(double x)
        {
            return Math.Pow(x, 3) - Math.Sin(x);
        }

        static void Main(string[] args)
        {
            Write("a= ");
            double a = Convert.ToDouble(ReadLine());

            Write("b= ");
            double b = Convert.ToDouble(ReadLine());

            double valueAtA = F(a);  
            double valueAtB = F(b);

            double maxResult = max(valueAtA, valueAtB);
            WriteLine($"Максимальное значение: {maxResult}"); ;
        }
    }
}