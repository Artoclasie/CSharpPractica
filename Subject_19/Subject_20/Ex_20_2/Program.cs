using static System.Console;

namespace Ex_20_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task<double>[] tasks = new Task<double>[2];
            double a = 30; 
            double beta = 45;

            tasks[0] = Task.Run(() => GetZ1(a, beta));
            tasks[1] = Task.Run(() => GetZ2(beta));

            Task.WaitAll(tasks);
            WriteLine("Результаты выполнения всех задач:");
            WriteLine($"z1 = {tasks[0].Result}");
            WriteLine($"z2 = {tasks[1].Result}");

            int index = Task.WaitAny(tasks);
            WriteLine($"\nРезультат выполнения хотя бы одной задачи (задача {index + 1}):");
            WriteLine($"z{index + 1} = {tasks[index].Result}");
        }

        static double GetZ1(double a, double beta)
        {
            Thread.Sleep(2000); 
            return Math.Sin(a + Math.Cos(2 * beta - a)) / Math.Cos(a - Math.Sin(2 * beta - a));
        }

        static double GetZ2(double beta)
        {
            Thread.Sleep(3000); 
            return (1 + Math.Sin(2 * beta)) / Math.Cos(2 * beta);
        }
    }
}