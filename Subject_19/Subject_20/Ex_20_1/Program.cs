using System.Threading.Tasks;
using static System.Console;

namespace Ex_20_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 134; 

            Task<int> task1 = new Task<int>(() => GetModifiedNumber(number));
            task1.Start();
            task1.Wait();
            WriteLine($"Результат с использованием объекта Task (конструктор): {task1.Result}");

            Task<int> task2 = Task<int>.Factory.StartNew(() => GetModifiedNumber(number));
            task2.Wait();
            WriteLine($"Результат с использованием объекта Task (фабричный метод): {task2.Result}");

            Task<int> task3 = Task.Run(() => GetModifiedNumber(number));
            task3.Wait();
            WriteLine($"Результат с использованием объекта Task (метод Run): {task3.Result}");
        }

        static int GetModifiedNumber(int number)
        {
            int firstDigit = number / 100; 
            int remainingDigits = number % 100;
            return remainingDigits * 10 + firstDigit; 
        }
    }
}