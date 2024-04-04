namespace Ex_18_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            MusicCatalog catalog = new MusicCatalog();

            catalog.AddCD("CD1");
            catalog.AddCD("CD2");

            catalog.AddSongToCD("CD1", "Song1", "Artist1");
            catalog.AddSongToCD("CD1", "Song2", "Artist2");
            catalog.AddSongToCD("CD2", "Song3", "Artist3");

            catalog.DisplayCatalog();

            catalog.RemoveSongFromCD("CD1", "Song1");

            catalog.DisplayCatalog();
        }
    }
}