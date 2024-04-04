using static System.Console;

namespace Srez_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Write("Stroka:");
            string mess = ReadLine();

            if (string.IsNullOrEmpty(mess))
            {
                WriteLine("Empty");
            }
            else
            {
                Write(mess); // можно вывести здесь исходная строка
                bool haveNumbers = false;
                for (int i = 0; i < mess.Length; i++) 
                {
                    if (char.IsDigit(mess[i]) && mess[i] != 0)
                    {
                        haveNumbers = true;

                        mess = mess.Replace(mess[i], '0'); // 1 способ

                        mess = mess.Remove(i, 1); // 2 способ
                        mess = mess.Insert(i, "0");
                    }
                }
                if (!haveNumbers)// == false != true меняет значение на тру или фолс смотря на значение
                {
                    WriteLine("Цифры отстуствуют");
                }
                else
                {
                    WriteLine($"Измененная строка: {mess}");
                }
            }
        }
    }
}