using System.Diagnostics; 

namespace Ex_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal notebookPrice = 2.75M;
            decimal numberNotebooks = 5;

            decimal pencilPrice = 0.85M;
            decimal numberPencils = 2;

            Console.WriteLine($"Стоимость покупки: {(notebookPrice*numberNotebooks) +(pencilPrice*numberPencils)}");

        }
    }
}