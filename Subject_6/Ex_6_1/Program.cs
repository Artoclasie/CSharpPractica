namespace Ex_6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите фрагмент текста:");
            string text = Console.ReadLine();

            char[] charArray = text.ToCharArray(); 

            for (int i = 0; i < charArray.Length; i++)
            {
                if (char.IsLetter(charArray[i])) 
                {
                    if (char.IsLower(charArray[i])) 
                    {
                        charArray[i] = char.ToUpper(charArray[i]);
                    }
                    else
                    {
                        charArray[i] = char.ToLower(charArray[i]); 
                    }
                }
            }

            string result = new string(charArray);

            Console.WriteLine($"Текст с измененным регистром: {result}");
        }
    }
}