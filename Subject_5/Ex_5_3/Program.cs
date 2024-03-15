using static System.Console;

namespace Ex_5_3
{
    internal class Program
    {
        static void Main()
        {
            Write("Введите размер матрицы N: ");
            int N = int.Parse(ReadLine());

            Write("Введите диапазон значений от: ");
            int a = int.Parse(ReadLine());

            Write("Введите диапазон значений до: ");
            int b = int.Parse(ReadLine());

            Write("Введите значение C: ");
            int C = int.Parse(ReadLine());

            int[,] matrix = new int[N, N];
            Random rand = new Random();

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrix[i, j] = rand.Next(a, b + 1);
                }
            }

            WriteLine("Исходная матрица:");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Write(matrix[i, j] + " ");
                }
                WriteLine();
            }

            int sumOfSquares = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (matrix[i, j] > C)
                    {
                        sumOfSquares += matrix[i, j] * matrix[i, j];
                    }
                }
            }
            WriteLine($"Сумма квадратов элементов, больших {C}: {sumOfSquares}");

            for (int i = 0; i < N; i++)
            {
                double sum = 0;
                for (int j = 0; j < N; j++)
                {
                    sum += matrix[i, j];
                }
                double average = sum / N;
                WriteLine($"Среднее арифметическое элементов строки {i}: {average}");
            }
        }
    }
}