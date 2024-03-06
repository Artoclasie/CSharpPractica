namespace Ex_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение альфа: ");
            double alpha = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение бетта ");
            double beta = Convert.ToInt32(Console.ReadLine());

            double s_1 = (Math.Sin(alpha) + Math.Cos(2 * beta - alpha)) / (Math.Cos(alpha) - Math.Sin(2 * beta - alpha));

            double s_2 = (1 + Math.Sin(2 * beta)) / (Math.Cos(2 * beta));

            Console.WriteLine($"Ответ на первое уравнение:{s_1} \n Ответ на второе уравнение:{s_2}");
        }
    }
}