using static System.Console;
namespace Srez_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Stroka:");

            string mess = ReadLine();

            if (string.IsNullOrEmpty(mess)) // проверяем на пустая или нет
            {
                WriteLine(" Yes");
            }
            else
            {
                WriteLine(mess);
                int count = 0;

                foreach (char symbol in mess)
                {
                    if (char.IsDigit(symbol))
                    {
                        int digit = (int)char.GetNumericValue(symbol); // symbol само число 
                        if (digit %2 != 0) // digit & 1 != 0 побитовое умножение на чет и нечет
                        {
                            count++;
                        }
                    }
                }

                if (count == 0)
                {
                    WriteLine("no");
                }
                else
                {
                    WriteLine(count);
                }
            }
        }
    }
}