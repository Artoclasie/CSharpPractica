namespace Ex_12_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalcFigure CF;

            Class1 class1 = new Class1();

            CF = class1.Get_Length;
            double circumference = CF(3);
            Console.WriteLine($"Длина окружности: {circumference:N4}");

            CF =  class1.Get_Area;
            double area = CF(9);
            Console.WriteLine($"Площадь круга: {area:N4}");

            CF = class1.Get_Volume;
            double volume = CF(4);
            Console.WriteLine($"Объем шара: {volume:N4}");
        }
    }
}