using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.Music
{
    class Industrial : MusicBase
    {
        public Industrial(string artistName, string genre)
        {
            ArtistName = artistName;
            Genre = genre;
        }

        public void Bringit()
        {
            if (Genre == "Aggrotech")
            {
                Console.WriteLine("\nThe Cybergoths stomp to the rhythm of bass.");
            }
            else
            {
                Console.WriteLine("\nThe Rivetheads stomp to the rhythm of bass.");
            }
        }
    }
}