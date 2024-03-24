using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_13_4
{
    internal class FirstObserver
    {
        public void ReactToEvent(object sender, EventArgs e)
        {
            Console.WriteLine("Первый наблюдатель реагирует на событие");
        }
    }
}
