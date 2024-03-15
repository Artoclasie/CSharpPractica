using static System.Console;
namespace Ex_3_2
{
    internal class Program
    {
        static double F (double x)
        {
            if (Math.Abs(x) <= 0.1)
            {
                return Math.Pow(x, 3) - 0.1;
            }
            else if (x > 0.1 && x <= 0.2)
            {
                return 0.2 * x - 0.1;
            }
            else
            {
                return Math.Pow(x, 3) + 0.1;
            }
        }
        static void Main(string[] args)
        {
            Write("a=");
            double a= Convert.ToDouble(ReadLine());
            Write("b=");
            double b = Convert.ToDouble(ReadLine());
            Write("h=");
            double h = Convert.ToDouble(ReadLine());

            for (double x = a; x <= b; x += h)
            {
                double y = F(x);
                WriteLine("f({0:f2})={1:f4}", x, F(x));
            }   
        }   
    }
}