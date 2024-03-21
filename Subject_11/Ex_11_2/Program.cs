using System.Diagnostics.Metrics;
using System.IO;

namespace Ex_11_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cloth[] clothes = new Cloth[]
 {
            new Shirt("Хлопок", 2.5),
            new Pants("Джинсовая ткань", 3.0),
            new Shirt("Шелк", 1.8),
            new Pants("Полиэстер", 2.2),
            new Shirt("Шерсть", 2.0)
 };
            Console.WriteLine("Отчет о потреблении ткани для одежды:");
            foreach (Cloth cloth in clothes)
            {
                Console.WriteLine($"Материал: {cloth.GetMaterial()}");
                Console.WriteLine($"Область: {cloth.GetArea()} кв.м");
                Console.WriteLine($"Общий расход ткани: {cloth.CalculateTotalFabricConsumption()} кв.м");
                Console.WriteLine();
            }
        }
    }
}
