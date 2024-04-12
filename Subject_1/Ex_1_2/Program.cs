using static System.Console;
namespace Ex_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Write("M: ");
            int number_1 = Convert.ToInt32(ReadLine());

            Write("N: ");
            int number_2 = Convert.ToInt32(ReadLine());

            if (number_1%number_2==0)
            {
                WriteLine($"Ответ:{number_1/number_2}");
            }
            else
            {
                WriteLine("M на N нацело не делится");
            }
        }
    }
}