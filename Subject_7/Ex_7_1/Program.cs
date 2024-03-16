using static System.Console;
using System.Text.RegularExpressions;

namespace Ex_7_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Введите текст:");
            string inputText = ReadLine();

            Write("Введите длинну слова:");
            int wordLength;
            if (!int.TryParse(ReadLine(), out wordLength) || wordLength <= 0)
            {
                WriteLine("Некорректная длинна слова.");
                return;
            }

            string pattern = $@"\b\w{{{wordLength}}}\b";

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(inputText);

            if (matches.Count > 0)
            {
                WriteLine($"Слова длинны {wordLength}:");
                foreach (Match match in matches)
                {
                    WriteLine(match.Value);
                }
            }
            else
            {
                WriteLine($"Слов длинны {wordLength} не найдено.");
            }
            ReadKey();
        }
    }
}