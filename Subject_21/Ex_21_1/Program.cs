namespace Ex_21_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChocolateBoiler boiler = ChocolateBoiler.GetInstance();

            boiler.Fill();

            bool isEmpty = boiler.IsEmpty();
            Console.WriteLine("Бойлер заполнен: " + isEmpty);

            boiler.Drain();

            isEmpty = boiler.IsEmpty();
            Console.WriteLine("Бойлер заполнен: " + isEmpty);
            Console.ReadLine();
        }
    }
}