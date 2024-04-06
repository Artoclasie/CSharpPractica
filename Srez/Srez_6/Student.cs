using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Srez_6
{
    internal class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string  ToString() // для вывода
        {
            return "student" + Name + Age; ;
        }
    }
}
