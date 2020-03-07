using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings
{
    enum GameGenre
    {
        MMO,
        Shooter,
        Platformer
    }

    class VideoGames
    {
        public string Title { get; }
        public DateTime ReleaseDate { get; }
        public string Developer { get; set; }
        public GameGenre GameGenre { get; set; }

        public VideoGames(string title, DateTime releaseDate)
        {
            Title = title;
            ReleaseDate = releaseDate;
        }

        public void Play()
        {
            switch (GameGenre)
            {
                case GameGenre.MMO:
                    {
                        Console.WriteLine("Hours and hours later...");
                    }
                    break;
                case GameGenre.Shooter:
                    {
                        Console.WriteLine("Pew pew");
                    }
                    break;
                case GameGenre.Platformer:
                    {
                        Console.WriteLine("Up, up, down, down, left, right, left, right...");
                    }
                    break;
                default:
                    return;
            }
        }

        public void Return()
        {
            if (string.IsNullOrWhiteSpace(Developer)) return;

            Console.WriteLine($"{Developer} refuses to give you your money back");
        }

    }
}
