using static System.Console;
namespace Ex_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Введите трехчзначное число:");
            int number = Convert.ToInt32(Console.ReadLine());
            int lastNumber = number % 100;
            int firstNumber = number / 100;
            string lastNumberStr = lastNumber.ToString();
            string firstNumberStr = firstNumber.ToString();
            WriteLine(lastNumberStr+firstNumberStr);
        }
    }
}