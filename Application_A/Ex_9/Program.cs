namespace Ex_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Радиус: ");
            double r = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Объем шара: {3/4*(Math.PI*Math.Pow(r, 3))}");
            Console.WriteLine($"Площадь шара: {4*Math.Pow(r, 2)}");
        }
    }
}