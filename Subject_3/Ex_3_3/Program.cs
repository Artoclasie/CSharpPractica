using static System.Console;
using System.Data.Common;

namespace Ex_3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int row, column, rowNumber;

            Write("Введите количество строк:");
            row = Convert.ToInt32(ReadLine());

            Write("Введите количество столбцов:");
            column =Convert.ToInt32(ReadLine());

            Matrix matrix = new Matrix(row, column);

            matrix=Matrix.Generate(row, column);

            WriteLine("Созданная матрица:");
            WriteLine(matrix);

            WriteLine("Введите строку");
            rowNumber = Convert.ToInt32(ReadLine());

            WriteLine("Измененная матрица:");
            matrix?.MatrixChange(rowNumber);
            WriteLine(matrix);

        }
    }
}