using static System.Console;
using ClassLibrary2;

namespace Ex_17_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chair chair = new Chair("Дерево", "Коричневый", 90, 50, 50, 4);
            WriteLine("Информация о стуле:");
            chair.DisplayInfo();
            WriteLine();

            Table table = new Table("Стекло", "Прозрачный", 75, 120, 80, 6);
            WriteLine("Информация о столе:");
            table.DisplayInfo();
        }
    }
}