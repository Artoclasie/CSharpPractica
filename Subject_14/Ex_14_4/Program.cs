using System;
using System.Threading;
using static System.Console;

namespace Ex_14_4
{
    internal class Program
    {
        static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        static void Main()
        {
            WriteLine("Введите количество потоков:");
            int numThreads = int.Parse(ReadLine());

            Thread[] threads = new Thread[numThreads];
            long[] partialSums = new long[numThreads];

            for (int i = 0; i < numThreads; i++)
            {
                int threadIndex = i;
                threads[i] = new Thread(() => partialSums[threadIndex] = CalculatePartialSum(threadIndex));
                threads[i].Start();
            }

            foreach (var thread in threads)
            {
                thread.Join();
            }

            long totalSum = 0;
            foreach (var sum in partialSums)
            {
                totalSum += sum;
            }

            WriteLine($"Общая сумма четных чисел: {totalSum}");
        }

        static long CalculatePartialSum(int threadIndex)
        {
            long partialSum = 0;
            for (int i = threadIndex; i < numbers.Length; i += threadIndex + 1)
            {
                if (numbers[i] % 2 == 0)
                {
                    partialSum += numbers[i];
                }
            }
            WriteLine($"Поток {threadIndex}: Частичная сумма четных чисел: {partialSum}");
            return partialSum;
        }
    }
}