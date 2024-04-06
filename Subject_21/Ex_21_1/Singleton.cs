using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_21_1
{
    internal class Singleton
    {
        private volatile static Singleton uniqueInstance;
        private static readonly object lockObject = new object();
        private Singleton() { }

        public static Singleton getInstance
        {
            get
            {
                lock (lockObject)
                {
                    if (uniqueInstance == null)
                    {
                        uniqueInstance = new Singleton();
                    }
                    return uniqueInstance;
                }
            }
        }
    }
}
