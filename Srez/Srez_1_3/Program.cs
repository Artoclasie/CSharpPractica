using static System.Console; 

namespace Srez_1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Write("El:");
            int amount = Convert.ToInt32(ReadLine());
            int summa = 0;
            int[] mass = new int[amount]; 

            Random random = new Random();

            for (int i = 0; i < amount; i++)
            {
                mass[i]= random.Next(2,10);
            }

            WriteLine("mass:");
             foreach (int item in mass)
            {
                Write($"{item} ");
            }

             for (int i = 0;i < amount; i++)
            {
                if (mass[i] % 2 == 0)
                {
                    summa += mass[i];
                }
            }

            if (summa == 0)
            {
                WriteLine("No");
            }
            else
            {
                WriteLine($"\nsumma = {summa}");
            }
        }
    }
}