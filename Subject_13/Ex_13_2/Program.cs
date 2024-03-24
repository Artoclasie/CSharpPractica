using static System.Console;
namespace Ex_13_2
{
    delegate void ShapeDelegate();

    class Program
    {
        static void Main(string[] args)
        {
            ShapeDelegate shapeDelegate = new ShapeDelegate(CalculateSquarePerimeter);
            shapeDelegate += CalculateSquareArea;
            shapeDelegate += DisplayTriangleSide;

            ExecuteShapeDelegate(shapeDelegate);
        }

        static void ExecuteShapeDelegate(ShapeDelegate shapeDelegate)
        {
            shapeDelegate();
        }

        static void CalculateSquarePerimeter()
        {
            int sideLength = 2;
            int perimeter = 5 * sideLength;
            WriteLine($"Периметр квадрата: {perimeter}");
        }

        static void CalculateSquareArea()
        {
            int sideLength = 6;
            int area = sideLength * sideLength;
            WriteLine($"Площадь квадрата: { area}");
        }

        static void DisplayTriangleSide()
        {
            int sideLength = 9;
            WriteLine($"Сторона треугольника: {sideLength}");
        }
    }
}