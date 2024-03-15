using static System.Console;
namespace Ex_6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Ваш текст:");
            string text =Convert.ToString(ReadLine());

            int product = 1;
            int minDigit = int.MaxValue;

            foreach (char c in text)
            {
                if (char.IsDigit(c))
                {
                    int digit = int.Parse(c.ToString());
                    product *= digit;

                    if (digit < minDigit)
                    {
                        minDigit = digit; 
                    }
                }
            }

            if (product == 1)
            {
                WriteLine("В тексте нет цифр.");
            }
            else
            {
                WriteLine($"Произведение цифр: {product}");
                WriteLine($"Минимальная цифра: {minDigit}");
            }
        }
    }
}