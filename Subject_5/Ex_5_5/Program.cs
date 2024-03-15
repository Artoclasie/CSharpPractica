namespace Ex_5_5
{
    internal class Program
    {
        static double Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }
        static double CalculateFunction(int n)
        {
            double numerator = Factorial(n - 3);
            double denominator = Factorial(n);
            return numerator / denominator;
        }
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Введите значение n: ");
            int n = int.Parse(Console.ReadLine());
            double result = CalculateFunction(n);
            Console.WriteLine($"Результат вычисления функции f({n}) = {(n - 3)}!/{n}! равен {result}");
        }
    }
}