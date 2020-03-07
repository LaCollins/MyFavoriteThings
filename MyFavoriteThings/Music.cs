using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings
{
    enum Genre
    {
        Industrial,
        Classical,
        Aggrotech
    }

    class Music
    {
        public Genre Genre { get; }
        public string ArtistName { get; }
        public int AlbumNumber { get; set; }
        public string ConcertLocation { get; private set; }

        public Music (string artistName, Genre genre)
        {
            ArtistName = artistName;
            Genre = genre;
        }

        public void RockOut(string concertLocation)
        {
            ConcertLocation = concertLocation;

            Console.WriteLine($"{ArtistName} is holding a concert at {ConcertLocation} tonight!");
        }

        public void CheckAlbums()
        {
            if (AlbumNumber > 0)
            {
                Console.WriteLine($"{ArtistName} has {AlbumNumber} {Genre} albums.");
            }
        }
    }
}
