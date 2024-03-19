namespace Ex_10_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A objA = new A();
            Console.WriteLine("Значение свойства C в классе A: " + objA.C);

            B objB1 = new B();
            Console.WriteLine("Значение свойства C в классе B с конструктором по умолчанию: " + objB1.C);
            Console.WriteLine("Значение свойства D в классе B с конструктором по умолчанию: " + objB1.D);
            Console.WriteLine("Значение свойства C2 в классе B с конструктором по умолчанию: " + objB1.C2);

            B objB2 = new B(2, 4, 6);
            Console.WriteLine("Значение свойства C в классе B с пользовательским конструктором: " + objB2.C);
            Console.WriteLine("Значение свойства D в классе B с пользовательским конструктором: " + objB2.D);
            Console.WriteLine("Значение свойства C2 в классе B с пользовательским конструктором: " + objB2.C2);
        }
    }
}