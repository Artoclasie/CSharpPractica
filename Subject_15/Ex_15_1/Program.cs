namespace Ex_15_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int>();
            myList.Add(12);
            myList.Add(32);
            myList.Add(43);

            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }

            MyList<int> myList2 = new MyList<int>();
            myList2.Add(9);
            myList2.Add(4);
            myList2.Add(6);

            int[] array = myList2.GetArray();

            Console.WriteLine("Элементы массива:");
            foreach (var item in array)
            {
                Console.Write($"{item} "); ;
            }
        }
    }
}