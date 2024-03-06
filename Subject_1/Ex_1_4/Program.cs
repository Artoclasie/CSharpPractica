using static System.Console;

namespace Ex_1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Write("A: ");
            int number1 = Convert.ToInt32(ReadLine());

            Write("B: ");
            int number2 = Convert.ToInt32(ReadLine());

            Write("X: ");
            int lastNumber1 = Convert.ToInt32(ReadLine());

            Write("Y: ");
            int lastNumber2= Convert.ToInt32(ReadLine());

            if (number1 <= number2)
            {
                int theNumber = number1;

                while (theNumber <= number2)
                {
                    if (theNumber % 10 == lastNumber1 || theNumber % 10 == lastNumber2)
                    {
                        WriteLine($"С помощьд цикла while: {theNumber}");
                    }
                    theNumber++;
                }

                int theNumber2 = number1;
                do
                {
                    if (theNumber2 % 10 == lastNumber1 || theNumber2 % 10 == lastNumber2)
                    {
                        WriteLine($"С помощьд цикла do..while: {theNumber2}");
                    }
                    theNumber2++;
                } while (theNumber2 <= number2);

                for (int i = number1; i <= number2; i++)
                {
                    if (i % 10 == lastNumber1 || i % 10 == lastNumber2)
                    {
                        WriteLine($"С помощью цикла for: {i}");
                    }
                }
            }
            else
            {
                WriteLine("Error");
            }
        }
    }
}