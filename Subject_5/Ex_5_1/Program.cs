namespace Ex_5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Введите количество элементов массива: ");
            int n = int.Parse(Console.ReadLine());
            double[] numbers = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введите {i + 1}-й элемент массива: ");
                numbers[i] = double.Parse(Console.ReadLine());
            }
            double sum = 0;
            foreach (double num in numbers)
            {
                sum += num;
            }
            double average = sum / n;
            Console.WriteLine("Среднее арифметическое массива: " + average);
        }
    }
}