using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_18_4
{
    internal class CD
    {
        public string Title { get; }
        public Hashtable Songs { get; }

        public CD(string title)
        {
            Title = title;
            Songs = new Hashtable();
        }

        public void AddSong(string title, string artist)
        {
            Songs[title] = artist;
        }

        public void RemoveSong(string title)
        {
            Songs.Remove(title);
        }

        public void Display()
        {
            Console.WriteLine($"CD: {Title}");
            foreach (DictionaryEntry song in Songs)
            {
                Console.WriteLine($"- {song.Key} by {song.Value}");
            }
            Console.WriteLine();
        }
    }
}
