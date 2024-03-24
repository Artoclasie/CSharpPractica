using System.Net.NetworkInformation;
using System.Threading;
using static System.Console;
using System.Diagnostics;
using System;

namespace Ex_14_2
{
    internal class Program
    {
        static void FirstThread()
        {
            for (int i = 0; i < 10; i++)
            {
               int summ =+ i;
               WriteLine($"Первый: {summ}");
            }
        }

        static void SecondThread()
        {
            for(int i = 0;i < 10;i++)
            {
                int summ =+ i;
                WriteLine($"Второй: {summ}");
            }
        }
        static void Main(string[] args)
        {
            Stopwatch sWatch = new Stopwatch();

            Thread thread1 = new Thread(new ThreadStart(FirstThread));
            Thread thread2 = new Thread(new ThreadStart(SecondThread));

            sWatch.Start();
            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();

            sWatch.Stop();

            WriteLine(sWatch.ElapsedMilliseconds);
        }
    }
}