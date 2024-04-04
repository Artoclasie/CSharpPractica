namespace Ex_18_1
{
    internal class Program
    {
        public static string ProcessText(string input)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in input)
            {
                if (c != '#')
                {
                    stack.Push(c);
                }
                else if (stack.Count > 0)
                {
                    stack.Pop();
                }
            }

            char[] resultArray = stack.ToArray();
            Array.Reverse(resultArray);
            return new string(resultArray);
        }

        static void Main()
        {
            string input = "abc#d##c";
            string output = ProcessText(input);

            Console.WriteLine("Преобразованный текст: " + output);
        }
    }
}