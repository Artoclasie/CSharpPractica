using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_18_3
{
    internal class SeaPrototype<T> : IEnumerable<T>
    {
        private List<T> creatures;

        public SeaPrototype()
        {
            creatures = new List<T>();
        }

        public void AddCreature(T creature)
        {
            creatures.Add(creature);
        }

        public bool RemoveCreature(T creature)
        {
            return creatures.Remove(creature);
        }

        public SeaPrototype<T> Clone()
        {
            SeaPrototype<T> clone = new SeaPrototype<T>();
            foreach (T creature in creatures)
            {
                clone.AddCreature(creature);
            }
            return clone;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return creatures.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return creatures.GetEnumerator();
        }
    }
}
