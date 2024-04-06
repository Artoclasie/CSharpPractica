using ClassLibrary1;

namespace Ex_17_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClaTriangle triangle = new ClaTriangle();
            triangle.InputSides(3, 4, 5);

            if (triangle.CheckExistence())
            {
                Console.WriteLine("Периметр треугольника: " + triangle.CalculatePerimeter());
                Console.WriteLine("Площадь треугольника: " + triangle.CalculateArea());
                Console.WriteLine("Тип треугольника: " + triangle.DetermineType());
            }
            else
            {
                Console.WriteLine("Треугольник с такими сторонами не существует.");
            }

            Rectangle rectangle = new Rectangle();
            rectangle.InputSides(4, 5);
            Console.WriteLine("Периметр прямоугольника: " + rectangle.CalculatePerimeter());
            Console.WriteLine("Площадь прямоугольника: " + rectangle.CalculateArea());
        }
    }
}