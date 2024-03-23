namespace Ex_12_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = "Hello, World!";

            Class2 class2 = new Class2 ();

            StringAction<string, string> stringActionDelegate;

            stringActionDelegate = class2.ToUpper;
            Console.WriteLine("Строка в верхнем регистре: " + stringActionDelegate(inputString));

            stringActionDelegate = class2.ToLower;
            Console.WriteLine("Строка в нижнем регистре: " + stringActionDelegate(inputString));

            StringAction<string, int> lengthDelegate = class2.GetLength;
            Console.WriteLine("Длина строки: " + lengthDelegate(inputString));
        }
    }
}