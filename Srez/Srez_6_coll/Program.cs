using System;
using System.Threading.Channels;

namespace Srez_6_coll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("student");

            int n = Convert.ToInt32(Console.ReadLine());

            List<Student> sts = new List<Student>(n); // (n) - задается колво 

            for (int i = 0; i < n; i++)
            {
                sts.Add(new Student() { Name = "Vasilii", Age = 55 }); // random yes
            }

            string message = sts.Any(sts => sts.Age>k) ?
                string.Join('\n', sts)
                : "studenr no";
            Console.WriteLine("k:");
            int k = Convert.ToInt32(Console.ReadLine());

            bool haveStudents = haveStudents.Any(sts => sts.Age>k); // проверяет на существование
            if (haveStudents)
            {
                sts.Where(sts => sts.Age>k());
                sts.ForEach(sts => Console.WriteLine{s});
            }
        }
    }
}