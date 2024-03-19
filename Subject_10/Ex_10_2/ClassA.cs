using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_10_2
{
    internal class A
    {
        protected int a = 5;
        protected int b = 10;

        public int C
        {
            get { return a * b; }
        }
    }
}
