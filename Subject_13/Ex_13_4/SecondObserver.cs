using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_13_4
{
    internal class SecondObserver
    {
        public void ReactToEvent(object sender, EventArgs e)
        {
            Console.WriteLine("Второй наблюдатель реагирует на событие");
        }
    }
}
