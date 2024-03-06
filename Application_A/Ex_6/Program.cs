namespace Ex_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Длина основания: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Высота: ");
            double h = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Площадь треугольника: {(1/2)*a*h}");
        }
    }
}