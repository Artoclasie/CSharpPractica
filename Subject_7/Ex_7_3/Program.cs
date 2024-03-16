using static System.Console;
using System.Text.RegularExpressions;

namespace Ex_7_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            OutputEncoding = System.Text.Encoding.UTF8;
            WriteLine("Введите текст:");
            string inputText = ReadLine();

            string[] words = inputText.Split(new char[] { ' ', ',', '.', ':', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            WriteLine("Пары слов, в которых последняя буква первого слова совпадает с первой буквой второго слова:");

            for (int i = 0; i < words.Length - 1; i++)
            {
                string firstWord = words[i];
                string secondWord = words[i + 1];

                if (firstWord.Length > 0 && secondWord.Length > 0 && char.ToLower(firstWord[^1]) == char.ToLower(secondWord[0]))
                {
                    WriteLine($"{firstWord} {secondWord}");
                }
            }

            ReadLine();
        }
    }
}