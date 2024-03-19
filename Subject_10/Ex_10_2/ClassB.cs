using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_10_2
{
    internal class B: A
    {
        private int d = 3;

        public int D
        {
            get { return d; }
        }

        public int C2
        {
            get
            {
                int result = 0;
                int i = 0;
                while (i < a)
                {
                    result += b * d;
                    i++;
                }
                return result;
            }
        }

        public B() : base()
        {
        }

        public B(int a, int b, int d) : base()
        {
            this.a = a;
            this.b = b;
            this.d = d;
        }
    }
}
