namespace Ex_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Длина основания a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Длина основания b: ");
            double b = Convert.ToDouble(Console.ReadLine()); 

            Console.WriteLine("Высота: ");
            double h = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Площадь трапеции: {((a+b)/2)*h}");
        }
    }
}