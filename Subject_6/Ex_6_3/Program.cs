using static System.Console;
namespace Ex_6_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OutputEncoding = System.Text.Encoding.UTF8;
            Write("Введите предложение: ");
            string inputSentence = ReadLine();

            string[] words = inputSentence.Split(' ');

            if (words.Length >= 2)
            {
                (words[^1], words[0]) = (words[0], words[^1]);

                string secondThirdConcatenated = words[1] + words[2];
                string reversedThirdWord = ReverseString(words[2]);

                string firstWordTrimmed = words[0][2..];

                WriteLine($"Предложение с первым и последним словами поменяными местами: {string.Join(" ", words)}");
                WriteLine($"Склеенное второе и третье слова: {secondThirdConcatenated}");
                WriteLine($"Третье слово в обратном порядке: {reversedThirdWord}");
                WriteLine($"Первое слово с удаленными первыми двумя буквами: {firstWordTrimmed}");
            }
            else
            {
                WriteLine("В предложении должно быть как минимум два слова.");
            }
        }

        static string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}