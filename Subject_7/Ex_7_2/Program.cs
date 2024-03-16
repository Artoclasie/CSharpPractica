using static System.Console;
using System.Text.RegularExpressions;

namespace Ex_7_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string quantity = string.Empty;
            WriteLine("Введите текст:");
            string text = ReadLine();
            WriteLine("Введите искомое слово:");
            string word = ReadLine();
            string pattern = $@"\b{word}\b";
            Regex reg = new Regex(pattern);

            MatchCollection match = reg.Matches(text);
            quantity = match.Count.ToString();

            if (quantity=="0")
            {
                WriteLine("В данном тексте нет таких слов.");
            }
            else
            {
                WriteLine($"Количество слова в строке: {quantity}");
            }

        }
    }
}