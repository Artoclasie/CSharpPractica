namespace Ex_20_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 74, 23, 65, 98 };

            Parallel.ForEach(numbers, (N, loopState) =>
            {
                long sum = 0;
                long product = 1;

                for (int i = 0; i <= N; i++)
                {
                    sum += i;
                    product *= i;

                    if (sum > 1000 || product > 1000000)
                    {
                        loopState.Break();
                        break;
                    }
                }

                Console.WriteLine($"N = {N}, Sum = {sum}, Product = {product}");
            });
        }
    }
}