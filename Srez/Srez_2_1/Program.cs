using static System.Console;


namespace Srez_2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("строка:");
            string mess = ReadLine();

            if (string.IsNullOrEmpty(mess))
            {
                WriteLine("Error");
            }
            else
            {
                int countLower = 0;
                int countUpper = 0;

                for (int i = 0; i < mess.Length; i++)
                {
                    if (char.IsLower(mess[i]))
                    {
                        countLower++;
                    }
                }

                WriteLine($"Lower{countLower}");

                Console.WriteLine(mess);

                for (int i = 0;i < mess.Length; i++)
                {
                    if (char.IsUpper(mess[i]))
                    {
                        countUpper++;
                    }
                }
                Console.WriteLine($"Upper: {countUpper}");
            }
        }
    }
}