namespace Ex_18_2
{
    internal class Program
    {
        public static void ProcessFile(string filePath, int a, int b)
        {
            Queue<int> inRangeQueue = new Queue<int>();
            Queue<int> lessThanAQueue = new Queue<int>();
            Queue<int> moreThanBQueue = new Queue<int>();

            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                int number = int.Parse(line);
                if (number >= a && number <= b)
                {
                    inRangeQueue.Enqueue(number);
                }
                else if (number < a)
                {
                    lessThanAQueue.Enqueue(number);
                }
                else
                {
                    moreThanBQueue.Enqueue(number);
                }
            }

            Console.WriteLine("Числа из интервала [{0},{1}]:", a, b);
            PrintQueue(inRangeQueue);

            Console.WriteLine("\nЧисла меньше {0}:", a);
            PrintQueue(lessThanAQueue);

            Console.WriteLine("\nЧисла больше {0}:", b);
            PrintQueue(moreThanBQueue);
        }

        public static void PrintQueue(Queue<int> queue)
        {
            foreach (int number in queue)
            {
                Console.Write(number + " ");
            }
        }

        static void Main()
        {
            string filePath = "Numbers_file.txt";
            int a = 7;
            int b = 22;

            ProcessFile(filePath, a, b);
        }
    }
}