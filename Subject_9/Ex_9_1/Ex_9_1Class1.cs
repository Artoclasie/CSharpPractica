using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_9_1
{
    class TestClass : Ix, Iy, Iz
    {

        public void IxF0(char symbol)
        {
            char lowerCaseSymbol = char.ToLower(symbol);
            Console.WriteLine($"Интерфейс Ix  метод F0:{lowerCaseSymbol}");
        }

        public void IxF1()
        {
            Console.WriteLine("IxF1");
        }

        public void F0(char symbol)
        {
            char result = char.IsLetter(symbol) ? '*' : symbol;
            Console.WriteLine($"метод F0:{result}");
        }

        public void F1()
        {
            Console.WriteLine("F1");
        }


        void Iz.F0(char symbol)
        {
            char result = char.IsLetter(symbol) ? '5' : symbol;
            Console.WriteLine($"Интерфейс Iz  метод F0:{result}");
        }

        void Iz.F1()
        {
            Console.WriteLine("IzF1:");
        }
    }
}
