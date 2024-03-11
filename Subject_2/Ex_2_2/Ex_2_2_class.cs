using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using static System.Console;

namespace Ex_2_2
{
    public class Product
    {
        public string NameProduct { get; set; }
        public int NumberProduct { get; set; }
        public string ColorProduct { get; set; }

        public void ConclusionProduct (string nameProduct,int numberProduct, string colorProduct)
        {
            WriteLine($"Название изделия: {nameProduct}");
            WriteLine($"Номер изделия: {numberProduct}");
            WriteLine($"Цвет изделия: {colorProduct}");
        }
    }
}
