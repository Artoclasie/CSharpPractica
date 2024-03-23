using static System.Console;
namespace Ex_12_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OutputEncoding = System.Text.Encoding.UTF8;

            Func<double, double, double> Add = (a, b) => a + b;
            Func<double, double, double> Sub = (a, b) => a - b;
            Func<double, double, double> Mul = (a, b) => a * b;
            Func<double, double, double> Div = (a, b) =>
            {
                if (b == 0)
                {
                    WriteLine("Ошибка: деление на ноль!");
                    return double.NaN; 
                }
                else
                {
                    return a / b;
                }
            };

            WriteLine("Выберите действие:");
            WriteLine("1. Сложение (+)");
            WriteLine("2. Вычитание (-)");
            WriteLine("3. Умножение (*)");
            WriteLine("4. Деление (/)");

            Write("Введите номер действия: ");
            int choice = int.Parse(ReadLine());

            Write("Введите первое число: ");
            double num1 = double.Parse(ReadLine());

            Write("Введите второе число: ");
            double num2 = double.Parse(ReadLine());

            double result = 0;

            switch (choice)
            {
                case 1:
                    result = Add(num1, num2);
                    break;
                case 2:
                    result = Sub(num1, num2);
                    break;
                case 3:
                    result = Mul(num1, num2);
                    break;
                case 4:
                    result = Div(num1, num2);
                    break;
                default:
                    WriteLine("Неверный выбор.");
                    return;
            }

            WriteLine("Результат: " + result);
        }
    }
}
