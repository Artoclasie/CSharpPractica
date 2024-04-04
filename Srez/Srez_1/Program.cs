using System.Linq.Expressions;
using static System.Console;

namespace Srez_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Write("El :");

            int amountOfElements = Convert.ToInt32(ReadLine());

            int[] mass = new int [amountOfElements];

            Random random = new Random();

            for (int i = 0; i < amountOfElements; i++)
            {
                mass[i] = random.Next(-10,10);
            }

            WriteLine("mass:");

            for (int i = 0;i < mass.Length;i++)
            {
                Write($"{ mass[i]} ");
            }

            for (int i = 0; )
        }
    }
}