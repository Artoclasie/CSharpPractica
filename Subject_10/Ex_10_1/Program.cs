namespace Ex_10_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal("Собака", 0.7);
            Console.WriteLine("Информация о животном:");
            animal.DisplayInfo();
            Console.WriteLine($"Вес животного: {animal.Weight(10):F2} кг");

            Console.WriteLine();

            Cat cat = new Cat("Толик", 0.4, "Дворняжка");
            Console.WriteLine("Информация о коте:");
            cat.DisplayInfo();
            Console.WriteLine($"Вес кота: {cat.Weight(15):F2} грамм");
        }
    }
}