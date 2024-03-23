using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_12_3
{
    delegate TResult StringAction<TInput, TResult>(TInput input);
    internal class Class2
    {
        public string ToUpper(string input)
        {
            return input.ToUpper();
        }

        public string ToLower(string input)
        {
            return input.ToLower();
        }

        public int GetLength(string input)
        {
            return input.Length;
        }
    }
}
