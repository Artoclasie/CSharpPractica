namespace Ex_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Радиус: ");
            double r = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Площадь круга: {Math.PI*Math.Pow(r,2)}");
        }
    }
}