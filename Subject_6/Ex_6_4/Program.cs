using static System.Console;
namespace Ex_6_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Александр Сергеевич Пушкин";
            string alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            int ind = 0;
            fullName = fullName.ToLower();
            for (int i = 0; i < fullName.Length; i++)
            {
                char x = fullName[i];
                ind += alphabet.IndexOf(x)+1;
            }
            WriteLine(GetSingleDigitSum(ind));
        }
        static int GetSingleDigitSum(int num)
        {
            while (num > 9)
            {
                int tempNum = num;
                int sum = 0;
                while (tempNum > 0)
                {
                    sum += tempNum % 10;
                    tempNum /= 10;
                }
                num = sum;
            }
            return num;
        }
    }
}
