using static System.Console;
namespace Ex_9_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool stop = true;
            int row, column, rowToChange, columnToChange, rowSubMatrix, columnSubMatrix, rowToIndexSubmatrix, columnToIndexSubmatrix, rowIToIndex, columnJToIndex;

            Matrix matrix = null;
            while (stop)
            {
                WriteLine("Hello!\n 1.Создать матрицу.\n 2.Изменить матрицу.\n 3.Вывод всей матрицы.\n 4.Вывод подматрицы.\n 5.Вывод элмента по индексу.\n 6.Выход из программы");

                int number = Convert.ToInt32(ReadLine());
                switch (number)
                {
                    case 1:
                        WriteLine("Введите количество строк:");
                        row = Convert.ToInt32(ReadLine());
                        WriteLine("Введите количество столбцов:");
                        column =Convert.ToInt32(ReadLine());
                        matrix=Matrix.Generate(row, column);
                        WriteLine(matrix);
                        break;
                    case 2:
                        WriteLine("Введите новое количество строк:");
                        rowToChange= Convert.ToInt32(ReadLine());
                        WriteLine("Введите новое количество столбцов:");
                        columnToChange= Convert.ToInt32(ReadLine());
                        WriteLine("Измененная матрица:");
                        matrix?.Change(rowToChange, columnToChange);
                        WriteLine(matrix);
                        break;
                    case 3:
                        WriteLine(matrix);

                        break;
                    case 4:
                        WriteLine("Введите количество строк:");
                        rowSubMatrix= Convert.ToInt32(ReadLine());
                        WriteLine("Введите количество столбцов:");
                        columnSubMatrix= Convert.ToInt32(ReadLine());
                        WriteLine("Введите стартовый индекс в строке:");
                        rowToIndexSubmatrix= Convert.ToInt32(ReadLine());
                        WriteLine("Введите стартовый индекс в столбце:");
                        columnToIndexSubmatrix= Convert.ToInt32(ReadLine());

                        WriteLine("Исходная матрица :");
                        WriteLine(matrix);
                        WriteLine("Подматрица:");
                        try
                        {
                            var submatrix = matrix?.Submatrix(rowSubMatrix, columnSubMatrix, rowToIndexSubmatrix, columnToIndexSubmatrix);
                            WriteLine(submatrix);
                        }
                        catch (IndexOutOfRangeException ex)
                        {
                            WriteLine(ex.Message);
                        }
                        break;
                    case 5:
                        WriteLine("Введите индекс элемента по строке: ");
                        rowIToIndex= Convert.ToInt32(ReadLine()); ;
                        WriteLine("Введите индекс элемента по столбцу: ");
                        columnJToIndex= Convert.ToInt32(ReadLine()); ;
                        WriteLine($"Элемент по индексам [{rowIToIndex},{columnJToIndex}]:");
                        try
                        {
                            var item = matrix?[rowIToIndex, columnJToIndex];
                            WriteLine(item);
                        }
                        catch (IndexOutOfRangeException ex)
                        {

                            WriteLine(ex.Message);
                        }

                        break;
                    case 6:
                        stop=false;
                        break;
                }
            }
        }
    }
}
