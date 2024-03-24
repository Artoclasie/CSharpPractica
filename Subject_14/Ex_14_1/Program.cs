using static System.Console;
using System.Threading;

namespace Ex_14_1
{
    internal class Program
    {
        static void FirstThread()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(20);
                WriteLine($"First: {i} ");
            }
        }

        static void SecondThread()
        {
            for (int i = 10; i < 20; i++)
            {
                Thread.Sleep(60);
                WriteLine($"Second: {i} ");
            }
        }

        static void ThirdThread()
        {
            for (int i = 20; i < 30; i++)
            {
                Thread.Sleep(100);
                WriteLine($"Third: {i} ");
            }
        }

        static void Main(string[] args)
        {
            Thread thread1 = new Thread(new ThreadStart(FirstThread));
            Thread thread2 = new Thread(new ThreadStart(SecondThread));
            Thread thread3 = new Thread(new ThreadStart(ThirdThread));

            thread1.Priority = ThreadPriority.Highest;
            thread2.Priority = ThreadPriority.Normal;
            thread3.Priority = ThreadPriority.Lowest;

            thread1.Start();
            thread2.Start();
            thread3.Start();
        }
    }
}