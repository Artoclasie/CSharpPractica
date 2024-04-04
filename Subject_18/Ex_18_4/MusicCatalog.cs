using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_18_4
{
    internal class MusicCatalog
    {
        private Hashtable cds;

        public MusicCatalog()
        {
            cds = new Hashtable();
        }

        public void AddCD(string title)
        {
            cds[title] = new CD(title);
        }

        public void RemoveCD(string title)
        {
            cds.Remove(title);
        }

        public void AddSongToCD(string cdTitle, string songTitle, string artist)
        {
            if (cds.ContainsKey(cdTitle))
            {
                CD cd = (CD)cds[cdTitle];
                cd.AddSong(songTitle, artist);
            }
            else
            {
                Console.WriteLine($"CD with title '{cdTitle}' not found.");
            }
        }

        public void RemoveSongFromCD(string cdTitle, string songTitle)
        {
            if (cds.ContainsKey(cdTitle))
            {
                CD cd = (CD)cds[cdTitle];
                cd.RemoveSong(songTitle);
            }
            else
            {
                Console.WriteLine($"CD with title '{cdTitle}' not found.");
            }
        }

        public void DisplayCatalog()
        {
            Console.WriteLine("Music Catalog:");
            foreach (DictionaryEntry entry in cds)
            {
                CD cd = (CD)entry.Value;
                cd.Display();
            }
        }
    }
}
