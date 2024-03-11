using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_2_2
{
    internal class Note:Product
    {
        public string NameNote { get; set; }
        public string TypeNote { get; set; }
        public void ConclusionNote(string nameProduct,int numberProduct,string nameNote, string typeNote)
        {
            Console.WriteLine($"Узел находится в изделии: {nameProduct},номер изделия: {numberProduct}");
            Console.WriteLine($"Название узла: {nameNote}");
            Console.WriteLine($"Тип узла:{typeNote}");
        }
    }
}
