namespace Ex_1_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 100; i < 1000; i++)
            {
                if (IsAutomorphic(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool IsAutomorphic(int number)
        {
            int square = number * number;
            string numStr = number.ToString();
            string squareStr = square.ToString();

            return squareStr.EndsWith(numStr);
        }
    }
}