namespace Ex_1_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите натуральное число: ");
            int number = int.Parse(Console.ReadLine());

            int maxNumber = int.MinValue;
            int minNumber = int.MaxValue;

            while (number > 0)
            {
                int digit = number % 10;
                maxNumber = Math.Max(maxNumber, digit);
                minNumber = Math.Min(minNumber, digit);
                number /= 10;
            }

            Console.WriteLine($"Максимальная цифра: {maxNumber}");
            Console.WriteLine($"Минимальная цифра: {minNumber}");

        }
    }
}