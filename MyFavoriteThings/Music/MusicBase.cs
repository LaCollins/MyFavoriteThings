using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings
{
    class MusicBase
    {
        public string Genre { get; set; }
        public string ArtistName { get; set; }
        public int AlbumNumber { get; set; }
        public string ConcertLocation { get; private set; }

        public void RockOut(string concertLocation)
        {
            ConcertLocation = concertLocation;

            Console.WriteLine($"\n{ArtistName} is holding a concert at {ConcertLocation} tonight!");
        }

        public void CheckAlbums()
        {
            if (AlbumNumber > 0)
            {
                Console.WriteLine($"\n{ArtistName} has {AlbumNumber} {Genre} albums.");
            }
        }
    }
}
