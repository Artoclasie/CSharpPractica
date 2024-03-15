using static System.Console;
namespace Ex_4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Write( "a1=");
                double a1 = Convert.ToDouble(ReadLine());
                double P1, S1;
                TrianglePS(a1, out P1, out S1);
                WriteLine("Периметр первого треугольника: " + P1);
                WriteLine("Площадь первого треугольника: " + S1);

                Write("a2=");
                double a2 = Convert.ToDouble(ReadLine());
                double P2, S2;
                TrianglePS(a2, out P2, out S2);
                WriteLine("Периметр второго треугольника: " + P2);
                WriteLine("Площадь второго треугольника: " + S2);

                Write("a3=");
                double a3 = Convert.ToDouble(ReadLine());
                double P3, S3;
                TrianglePS(a3, out P3, out S3);
                WriteLine("Периметр третьего треугольника: " + P3);
                WriteLine("Площадь третьего треугольника: " + S3);
            }
            catch (DivideByZeroException ex)
            {
                WriteLine("Ошибка: деление на ноль");
            }
            catch (FormatException ex)
            {
                WriteLine("Ошибка формата ввода");
            }
            catch (Exception ex)
            {
                WriteLine("Произошла ошибка: " + ex.Message);
            }
        }

        static void TrianglePS(double a, out double P, out double S)
        {
            if (a <= 0)
            {
                throw new ArgumentException("Сторона треугольника должна быть положительным числом");
            }
            P = 3 * a;
            S = Math.Pow(a,2) * Math.Sqrt(3) / 4;
        }
    }
}
  