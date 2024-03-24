using System.Threading;
using static System.Console;

namespace Ex_14_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Введите число A:");
            int A = int.Parse(ReadLine());

            WriteLine("Введите число N:");
            int N = int.Parse(ReadLine());

            Thread thread1 = new Thread(() => Method1(A, N));
            Thread thread2 = new Thread(() => Method2(A, N));

            thread1.Start();
            thread2.Start();
        }

        static void Method1(int A, int N)
        {
            long result = 0;
            for (int i = 1; i <= N; i++)
            {
                result += A + i;
                WriteLine($"Method1: Промежуточный результат на шаге {i}: {result}");
                Thread.Sleep(1000); 
            }
            WriteLine($"Method1: Итоговый результат: {result}");
        }

        static void Method2(int A, int N)
        {
            long result = 1;
            for (int i = 1; i <= N; i++)
            {
                result *= A * i;
                WriteLine($"Method2: Промежуточный результат на шаге {i}: {result}");
                Thread.Sleep(1000); 
            }
            WriteLine($"Method2: Итоговый результат: {result}");
        }
    }
}