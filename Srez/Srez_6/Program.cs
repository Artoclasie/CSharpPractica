using System.Ling;
namespace Srez_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("student");

            int n = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
           Student[] sts = new Student[n];

            for (int i = 0; i < n; i++)
            {
                sts[i] = new Student() { Name = $"Vasilii{i+1}", Age = random.Next(0, 100) }; // "Vasili" + (i+1)/IsString();
            }

            Console.WriteLine("k:");
            int k = Convert.ToInt32(Console.ReadLine());

            bool haveStudents = haveStudents.Any(sts=>sts.Age>k); // проверяет на существование
            if (haveStudents)
            {
                sts.Where(sts => sts.Age>k());
                sts.ToList().ForEach(sts => CW{s});
            }
          //  for (int i = 0;i < n; i++)
           // {
              //  if (sts[i].Age > k)
             //   {
              //      haveStudents = true;

                    // Console.WriteLine("Student" + sts[i].Name + "age" + sts[i].Age);
              //      Console.WriteLine(sts[i]);
            //    }
           // }

            if (!haveStudents)
            {
                Console.WriteLine("No students");
            }
        }
    }
}