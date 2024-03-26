using static System.Console;

namespace Ex_15_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> myDictionary = new MyDictionary<string, int>();
            myDictionary.Add("Сижу за решеткой в темнице сырой", 1);
            myDictionary.Add("Вскормленный в неволе орел молодой", 2);
            myDictionary.Add("Мой грустный товарищ махая крылом", 3);

            WriteLine($"Значение элемента:{myDictionary["Вскормленный в неволе орел молодой"]}");
            WriteLine($"Количество:{myDictionary.Count}");

            ReadLine();
        }
    }
}