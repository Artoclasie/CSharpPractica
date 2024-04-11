using static System.Console;

namespace Ex_20_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 57; 

            Task<int> task1 = Task.Run(() => GetSumOfDigits(number));

            Task task2 = task1.ContinueWith((previousTask) =>
            {
                int sum = previousTask.Result;
                WriteLine($"Сумма цифр числа {number} равна {sum}");
            });

            task2.Wait(); 
        }

        static int GetSumOfDigits(int number)
        {
            int tens = number / 10; 
            int ones = number % 10;
            return tens + ones; 
        }
    }
}