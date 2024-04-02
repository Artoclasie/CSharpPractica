using System.IO;

namespace Ex_16_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "originalFile.txt"; 
            string newFilePath = "modifiedFile.txt"; 

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Что ж я узнал? Пора узнать, что в мирозданье,");
                writer.WriteLine("Куда ни обратись, — вопрос, а не ответ;");
                writer.WriteLine("А я дышу, живу и понял, что в незнанье");
                writer.WriteLine("Одно прискорбное, но страшного в нём нет.");
                writer.WriteLine("А между тем, когда б в смятении великом");
            }

            string[] lines = File.ReadAllLines(filePath);

            Array.Resize(ref lines, lines.Length - 1);

            File.WriteAllLines(newFilePath, lines);

            Console.WriteLine("Последняя строка удалена из исходного файла. Результат записан в новый файл.");
        }
    }
}