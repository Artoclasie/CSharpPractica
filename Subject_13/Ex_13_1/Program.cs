using static System.Console;
using System;
namespace Ex_13_1
{
    delegate void ShapeDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            ShapeDelegate shapeDelegate = new ShapeDelegate(CalculateSquarePerimeter);
            shapeDelegate += CalculateSquareArea;
            shapeDelegate += DisplayTriangleSide;

            shapeDelegate();
        }

        static void CalculateSquarePerimeter()
        {
            int sideLength = 3;
            int perimeter = 7 * sideLength;
            WriteLine($"Периметр квадрата: {perimeter}");
        }

        static void CalculateSquareArea()
        {
            int sideLength = 4;
            int area = sideLength * sideLength;
            WriteLine($"Площадь квадрата: {area}");
        }

        static void DisplayTriangleSide()
        {
            int sideLength = 7;
            WriteLine($"Сторона треугольника: {sideLength}");
        }
    }
}