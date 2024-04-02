namespace Ex_16_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath1 = "First_file.txt"; 
            string filePath2 = "Second_file.txt"; 

            string[] lines1 = File.ReadAllLines(filePath1);
            string[] lines2 = File.ReadAllLines(filePath2);

            if (lines1.Length != lines2.Length)
            {
                Console.WriteLine("Файлы имеют разное количество строк и не могут быть сравнены.");
                return;
            }

            for (int i = 0; i < lines1.Length; i++)
            {
                if (lines1[i] != lines2[i])
                {
                    Console.WriteLine($"Файлы отличаются на строке {i + 1}:");
                    Console.WriteLine($"Файл 1: {lines1[i]}");
                    Console.WriteLine($"Файл 2: {lines2[i]}");
                    return;
                }
            }

            Console.WriteLine("Файлы идентичны.");
        }
    }
}