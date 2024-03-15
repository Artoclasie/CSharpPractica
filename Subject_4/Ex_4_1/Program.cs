using static System.Console;
namespace Ex_4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                OutputEncoding = System.Text.Encoding.UTF8;
                
                Write("Введите значение x для уравнения a: ");
                double x_A = GetInput();
                CalculateAndPrintResult('a', x_A);
                
                Write("Введите значение x для уравнения b: ");
                double x_B = GetInput();
                CalculateAndPrintResult('b', x_B);
            }
            catch (FormatException ex)
            {
                WriteLine($"Ошибка формата ввода: {ex.Message}");
            }
            catch (DivideByZeroException ex)
            {
                WriteLine($"Ошибка деления на ноль: {ex.Message}");
            }
            catch (Exception ex)
            {
                WriteLine($"Произошла ошибка: {ex.Message}");
            }

        }
        static double GetInput()
        {
            if (!double.TryParse(ReadLine(), out double input))
            {
                throw new FormatException("Некорректный формат ввода.");
            }
            return input;
        }
        static void CalculateAndPrintResult(char equation, double x)
        {
            double y;
            switch (equation)
            {
                case 'a':
                    if (Math.Abs(x - 5) < 1e-10)
                    {
                        throw new DivideByZeroException("Знаменатель равен нулю в уравнении a.");
                    }
                    y = (Math.Sin(x) / (x - 5)) + Math.Pow(x, 3);
                    break;
                case 'b':
                    if ((3 * x + 6) <= 0)
                    {
                        throw new DivideByZeroException("Знаменатель равен нулю или отрицателен в уравнении b.");
                    }
                    y = Math.Log(x) - (Math.Cos(x) / (3 * x + 6));
                    break;

                default:
                    throw new InvalidOperationException("Некорректное уравнение.");
            }

            WriteLine($"Значение уравнения {equation}: y = {y}");
        }
    }
}
