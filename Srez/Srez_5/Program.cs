using static System.Math; // чтоббы не писать Math
using static System.Console;

namespace Srez_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine(" a: b: h:");
            int a = Convert.ToInt32(ReadLine()); // int.Parse(C.R())
            int b = Convert.ToInt32(ReadLine());
            int h = Convert.ToInt32(ReadLine());

            if (a > b && h > 0)
            {
                WriteLine("Error");
            }
            else
            {
                for (int x = a; x <= b; x+=h)
                {
                    if (x <= 0)
                    {
                        WriteLine(Sin(x));
                    }
                    else if (x>0 && x < 9 && x == 9)
                    {
                        WriteLine(Math.Pow(x,3));
                    }
                    else
                    {
                        WriteLine(0);
                    }
                }
            }
        }
    }
}