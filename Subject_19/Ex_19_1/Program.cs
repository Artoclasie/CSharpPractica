using static System.Console;

namespace Ex_19_1
{
    internal class Program
    {
        /// <summary>
        /// Функция, возрощающая наибольшее значение.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static double max(double a, double b)
        {
            return (a>b) ? a : b;
        }

        /// <summary>
        /// Функция, возвращающая результат выражения.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static double F(double x)
        {
            return Math.Pow(x, 3) - Math.Sin(x);
        }

        static void Main(string[] args)
        {
            Write("a= ");
            double a = Convert.ToDouble(ReadLine());

            Write("b= ");
            double b = Convert.ToDouble(ReadLine());

            double valueAtA = F(a);
            double valueAtB = F(b);

            double maxResult = max(valueAtA, valueAtB);
            WriteLine($"Максимальное значение: {maxResult}"); ;
        }
    }
}