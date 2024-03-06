using static System.Console;
namespace Ex_1_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("M: 10");
            int m = 10;

            double h = (0 - Math.PI/4)/m;

            for (int i = 0; i <= m; i++)
            {
                double x = i + h;
                WriteLine($"F(x) = {Math.Tan(x)}");
            }
        }
    }
}