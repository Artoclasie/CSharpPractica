using static System.Console;

namespace Srez_1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Write("El:");
            int amount = Convert.ToInt32(ReadLine());
            int[] mass = new int[amount];
            int count = 0;
            Random random = new Random();

            for (int i = 0; i < amount; i++)
            {
                mass[i]=random.Next(-2,3);
            }

            WriteLine("mass:");

            foreach(int item in mass)
            {
                Write($"{item} ");
            }

            for (int i = 0;i < mass.Length;i++)
            {
                if (mass[i] != 0)
                {
                    count++; 
                }
            }

            if (count == 0)
            {
                WriteLine("No");
            }
            else
            {
                WriteLine($"\nKol no 0 = {count}");
            }
        }
    }
}