using MyFavoriteThings.Books;
using MyFavoriteThings.Reptiles;
using System;

namespace MyFavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            var jericho = new Snake("Jericho", "Boa Constrictor");

            jericho.FeedReptile();
            jericho.Speak();
            jericho.Slither();

            var rogue = new Iguana("Rogue", "Green Iguana");

            rogue.FeedReptile();
            rogue.Speak();
            rogue.Dislike();

            var snuggles = new Alligator("Snuggles", "American Alligator");

            snuggles.FeedReptile();
            snuggles.Speak();
            snuggles.DeathRoll();

            var fgfc820 = new Music("FGFC820", Genre.Aggrotech)
            {
                AlbumNumber = 10
            };

            fgfc820.RockOut("Bridgestone Arena");
            fgfc820.CheckAlbums();

            var vnvNation = new Music("VNV Nation", Genre.Industrial)
            {
                AlbumNumber = 20
            };

            vnvNation.RockOut("Exit/In");
            vnvNation.CheckAlbums();

            var theGrapesOfWrath = new Novel("The Grapes of Wrath", 525, "John Steinbeck")
            {
                HaveRead = true
            };

            theGrapesOfWrath.Open();
            theGrapesOfWrath.Read();

            var braveNewWorld = new Novel("Brave New World", 452, "Aldous Huxley")
            {
                HaveRead = false
            };

            braveNewWorld.Read();

            var verdi = new PictureBook("Verdi", 15, "Janell Cannon");

            verdi.Read();

            var worldOfWarcraft = new VideoGames("World of Warcraft", new DateTime(2004, 11, 24))
            {
                Developer = "Blizzard",
                GameGenre = GameGenre.MMO
            };

            worldOfWarcraft.Play();
            worldOfWarcraft.Return();

            var doom = new VideoGames("Doom", new DateTime(1993, 12, 10))
            {
                Developer = "id Software",
                GameGenre = GameGenre.Shooter
            };

            doom.Play();
            doom.Return();

            Console.ReadKey();
        }
    }
}
