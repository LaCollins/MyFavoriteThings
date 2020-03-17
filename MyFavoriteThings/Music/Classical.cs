using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.Music
{
    class Classical : MusicBase
    {
        public Classical(string artistName, string genre)
        {
            ArtistName = artistName;
            Genre = genre;
        }

        public void Encore()
        {
            Console.WriteLine($"\n{ArtistName} plays \"Anitra's Dance\" by Greig");
        }
    }
}
