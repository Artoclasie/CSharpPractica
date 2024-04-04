namespace Ex_18_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            SeaPrototype<SeaCreature> sea = new SeaPrototype<SeaCreature>();

            sea.AddCreature(new SeaCreature("Кальмар"));
            sea.AddCreature(new SeaCreature("Дельфин"));
            sea.AddCreature(new SeaCreature("Краб"));

            Console.WriteLine("Содержимое моря:");
            foreach (SeaCreature creature in sea)
            {
                Console.WriteLine(creature.Name);
            }

            SeaCreature crab = new SeaCreature("Краб");
            bool removed = sea.RemoveCreature(crab);
            if (removed)
            {
                Console.WriteLine("Краб удален из моря.");
            }
            else
            {
                Console.WriteLine("Краб не найден в море.");
            }

            SeaPrototype<SeaCreature> clonedSea = sea.Clone();
            Console.WriteLine("Клонированное море:");
            foreach (SeaCreature creature in clonedSea)
            {
                Console.WriteLine(creature.Name);
            }
        }
    }
}