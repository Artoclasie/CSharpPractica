using static System.Console;
namespace Ex_1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("a - автомобиль, в -велосипед, м - мотоцикл, с - самолет, п - поезд");
            char symbol = Convert.ToChar(ReadLine());

            switch (symbol)
            {
                case 'а':
                    WriteLine("Максимальная скорость автомобиля: 508,73 км/ч");
                    break;
                case 'в':
                    WriteLine("Максимальная скорость велосипеда: 295,6 км/ч");
                    break;
                case 'м':
                    WriteLine("Максимальная скорость мотоцикла: 195 км/ч");
                    break;
                case 'с':
                    WriteLine("Максимальная скорость самолета: 745 км/ч");
                    break;
                case 'п':
                    WriteLine("Максимальная скорость поезда: 603 км/ч");
                    break;
            }
        }
    }
}