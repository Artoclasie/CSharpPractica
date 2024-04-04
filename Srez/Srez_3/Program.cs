using System.Linq.Expressions;
using static System.Console;
namespace Srez_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Hello, World!");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] mass = new int[n];
            //Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                mass[i] = Random.Shared.Next(-5, 5); // тот же рандом
            }

            string.Join(" ", mass);
            int min = mass.Min();

            int indexFirstMin = Array.IndexOf(mass, min);

            // 1

            int temp = mass[0];
            mass[0] = mass[indexFirstMin];
            mass[indexFirstMin] = temp;

            // 2 в новых версиях только 

            (mass[0], mass[indexFirstMin]) = (mass[indexFirstMin], mass[0]);

            WriteLine(indexFirstMin);

            string.Join (" ", mass);
        }
    }
}