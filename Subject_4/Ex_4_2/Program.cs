using static System.Console;
namespace Ex_4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                OutputEncoding = System.Text.Encoding.UTF8;
                Write("Введите значение x: ");
                double x = Convert.ToDouble(ReadLine());
                double result = CalculateFunction(x);
                WriteLine($"Значение функции для x = {x}: {result}");
            }
            catch (FormatException)
            {
                WriteLine("Ошибка формата ввода. Пожалуйста, введите корректное число.");
            }
            catch (DivideByZeroException)
            {
                WriteLine("Ошибка деления на ноль. Введите значение x, отличное от 0.");
            }
            catch (OutOfRangeException ex)
            {
                WriteLine($"Ошибка: {ex.Message}");
            }
            catch (Exception ex)
            {
                WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }
        static double CalculateFunction(double x)
        {
            if (x > -3 && x < 3)
            {
                return 2 * x;
            }
            else if (x <= -3)
            {
                throw new OutOfRangeException("Значение x находится за пределами допустимого диапазона.");
            }
            else
            {
                return 5 * x;
            }
        }
    }
    class OutOfRangeException : Exception
    {
        public OutOfRangeException(string message) : base(message)
        {
        }
    }
}
   