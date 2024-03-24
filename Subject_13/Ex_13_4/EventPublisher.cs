using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_13_4
{
    internal class EventPublisher
    {
        public delegate void EventHandler(object sender, EventArgs e);
        public event EventHandler EventOccurred;

        public void RaiseEvent()
        {
            Console.WriteLine("Событие произошло!");
            EventOccurred?.Invoke(this, EventArgs.Empty);
        }
    }
}
