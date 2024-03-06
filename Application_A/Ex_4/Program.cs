using static System.Console;

namespace Ex_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Введите три стороны треугольника:");

            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());

            double perimeter = a + b + c;

            WriteLine($"Периметр: {perimeter}");

            double semiperimeter = perimeter/2;
            double square = Math.Sqrt(semiperimeter* (semiperimeter-a)*(semiperimeter-b)*(semiperimeter-c));

            WriteLine($"Площадь: {square}");
        }
    }
}