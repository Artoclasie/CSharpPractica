using static System.Console;
namespace Ex_1_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Write("Вещественное число: ");
            double realNumber = Convert.ToDouble(ReadLine());

            Write("Целое число: ");
            int wholeNumber = Convert.ToInt32(ReadLine());

            if (wholeNumber>0)
            {
                for (int i = 1; i <= wholeNumber; i++)
                {
                    double result = Math.Pow(realNumber, i);
                    Console.WriteLine($"{realNumber} в степени {i} равно {result}");
                }
            }
            if (-5<=realNumber && realNumber<=5 && 1<=wholeNumber && wholeNumber<=10)
            {
                for (int i = 1;i <= wholeNumber; i++)
                {
                    double result = Math.Pow(realNumber, i);
                    Console.WriteLine(result.ToString("F4"));
                }
            }

        }
    }
}