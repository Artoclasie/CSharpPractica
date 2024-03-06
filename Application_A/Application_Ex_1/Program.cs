using static System.Console; 
namespace Application_Ex_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Введите первое вещественное число:");
            double number1 = Convert.ToDouble(Console.ReadLine());

            WriteLine("Введите второе вещественное число:");
            double number2 = Convert.ToDouble(Console.ReadLine());

            double result = number1 * number2;

            WriteLine($"{number1}*{number2}={result:F1}");
        }
    }
}