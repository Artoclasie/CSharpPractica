using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_11_1
{
    internal class Construction
    {
        protected string name;

        public Construction(string name)
        {
            this.name = name;
        }
        public virtual void DisplayResults()
        {
            Console.WriteLine($"Название: {name}");
        }
    }
}
