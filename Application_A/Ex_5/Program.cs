using static System.Console;

namespace Ex_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Введите радиус основания цилиндра:");
            double r = Convert.ToDouble(Console.ReadLine());

            WriteLine("Введите высоту:");
            double h = Convert.ToDouble(Console.ReadLine());

            WriteLine($"Объем цилиндра = {Math.PI*Math.Pow(r,2)*h}");
            WriteLine($"Общая площадь поверхности = {2*(Math.PI*Math.Pow(r,2)+Math.PI*r*h)}");
        }
    }
}