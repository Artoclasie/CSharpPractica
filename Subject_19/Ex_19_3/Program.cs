namespace Ex_19_3
{
    internal class Program
    {
        // <summary>
        /// Этот метод считывает числа из файла "f.txt", находит наибольшее и наименьшее значение,
        /// затем вычисляет и выводит сумму этих значений.
        /// </summary>
        /// <param name="args">Аргументы командной строки.</param>
        static void Main(string[] args)
        {
            // Считываем строки из файла "f.txt" и преобразуем их в массив чисел
            string[] lines = File.ReadAllLines("f.txt");
            double[] components = lines.Select(double.Parse).ToArray();

            // Находим наибольшее и наименьшее значения в массиве
            double max = components.Max();
            double min = components.Min();

            // Вычисляем сумму наибольшего и наименьшего значений
            double sum = max + min;

            // Выводим результат
            Console.WriteLine($"Сумма наибольшего и наименьшего значений компонент: {sum}");
        }
    }
}