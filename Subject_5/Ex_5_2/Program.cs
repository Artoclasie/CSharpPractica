using static System.Console;
using System;

namespace Ex_5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Write("Введите число количество элемента: ");
            int n = Convert.ToInt32(ReadLine());

            double[] arr = new double[n];

            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                arr[i] = random.Next(-10, 10) + random.NextDouble();
            }
            WriteLine("Массив:");
            for (int i = 0; i < arr.Length; i++)
            {
                Write($"{arr[i]:N2} ");
            }

            for (int i = 0; i < n; i++)
            {
                if (arr[i] < 0)
                {
                    arr[i] += 0.5;
                }
            }

            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += arr[i];
            }
            double average = sum / n;
            WriteLine($"\nСреднее арифметическое:{average:N2}");

            for (int i = 0; i < n; i++)
            {
                if (arr[i] > 0 && arr[i] < average)
                {
                    arr[i] = 0.1;
                }
            }

            WriteLine("Преобразованный массив:");
            foreach (double num in arr)
            {
                Write($"{num:N2} ");
            }

            Array.Sort(arr);

            WriteLine($"\nОтсортированный массив:");
            foreach (double element in arr)
            {
                Write($"{element:N2} ");
            }

            WriteLine();
          
            Write("Введите число k для бинарного поиска: ");
            double k = Convert.ToDouble(ReadLine());

            int index = Array.BinarySearch(arr, k);
            if (index < 0)
            {
                WriteLine("Элемент не найден");
            }
            else
            {
                WriteLine("Элемент найден на позиции " + index);
            }
        }
    }
}