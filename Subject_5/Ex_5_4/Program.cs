namespace Ex_5_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] income = new int[10, 12]; 
            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    income[i, j] = rand.Next(1000, 10000); 
                }
            }

            int totalIncomeSeptember = 0;
            for (int i = 0; i < 10; i++)
            {
                totalIncomeSeptember += income[i, 8]; 
            }

            Console.WriteLine($"Общий доход фирмы за сентябрь: {totalIncomeSeptember}");

            Console.Write("Введите заданное число: ");
            int threshold = int.Parse(Console.ReadLine());

            if (totalIncomeSeptember > threshold)
            {
                Console.WriteLine("Общий доход фирмы в сентябре превысил заданное число.");
            }
            else
            {
                Console.WriteLine("Общий доход фирмы в сентябре не превысил заданное число.");
            }
        }
    }
}