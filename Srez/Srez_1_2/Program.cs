using static System.Console;

namespace Srez_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Write("El:");

            int amount = Convert.ToInt32(ReadLine());
            int[] mass = new int[amount];
            Random random = new Random();

            int count=0;

            for (int i = 0; i < amount; i++)
            {
                mass[i] = random.Next(-5, 15);
            }

            for (int i = 0;i < amount; i++)
            {
                if (mass[i] > 0 & mass[i] < 10)
                {
                    count++;
                }
            }

            if (count == 0)
            {
                WriteLine("Элементы не найдены ");
            }
            else 
            {
                WriteLine($"Kol: {count}");
            }

            WriteLine("mass:");

            foreach (int item in mass) // 1 способ ввода 
            {
                Write($"{item} ");
            }

            WriteLine($"\n{string.Join(" ", mass)}"); // 2 способ ввода, для двумерных и более массивов не подойдет, но очень удобен
        }
    }
}