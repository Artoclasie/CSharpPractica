namespace Ex_20_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = 2;
            int B = 12;

            Parallel.For(A, B + 1, i =>
            {
                double result = Math.Tan(i);
                Console.WriteLine($"tg({i}) = {result}");
            });
        }
    }
}