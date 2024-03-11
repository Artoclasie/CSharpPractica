using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_2_2
{
    internal class Mechanism:Note
    {
        public string NameMechanism { get; set; }
        public void ConclusionMechanism(int numberProduct,string typeNote,string nameMechanism)
        {
            Console.WriteLine($"Механизм находится в изделии под номером: {numberProduct}.\nТип узла: {typeNote}");
            Console.WriteLine($"название механизма: {nameMechanism}");
        }
    }
}
