namespace Ex_11_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Construction[] construction = new Construction[5];
            construction[0] = new Office("Комбинированный тип офиса", 4);
            construction[1] = new Office("Дизайн-офис", 8);
            construction[2] = new Factory("Трубный завод", 8906823);
            construction[3] = new Factory("Метизный завод", 6754456);
            construction[4] = new Construction("Завод с офисом");

            foreach (Construction item in construction)
            {
                item.DisplayResults();
                Console.WriteLine();
            }
        }
    }
}