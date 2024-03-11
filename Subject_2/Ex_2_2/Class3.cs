using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_2_2
{
    internal class Detail:Mechanism
    {
        public string NameDetail { get; set; }
        public string MaterialDetail { get; set; }

        public void ConclusionDetail(string nameDetail, string materialDetail)
        {
            Console.WriteLine($"Навзвание детали: {nameDetail}");
            Console.WriteLine($"Материал детали: {materialDetail}");
        }

        public void Material (string nameProduct, string nameDetail, string materialDetail)
        {
            if (nameProduct == "Автомобиль" && nameDetail == "Клапан" && materialDetail == "Кремниевая легированная сталь")
            {
                Console.WriteLine("Клапан в вашем двигателе сделан из нужного материала!");
            }
            else
            {
                Console.WriteLine("Вам стоит обратиться в мастерскую!");
            }
        }
    }
}
