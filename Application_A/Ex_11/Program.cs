namespace Ex_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите двухзнчаное число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int firstNumber = number / 10;
            int secondNumber = number % 10;

            Console.WriteLine($"Сложение цифр= {firstNumber + secondNumber}");
        }
    }
}