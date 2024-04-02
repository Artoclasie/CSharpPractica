using System.Text;
using System.IO;
using System.Linq;

namespace Ex_16_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("f.txt");
            double[] components = lines.Select(double.Parse).ToArray();

            double max = components.Max();
            double min = components.Min();

            double sum = max + min;

            Console.WriteLine($"Сумма наибольшего и наименьшего значений компонент: {sum}");
        }
    }
}