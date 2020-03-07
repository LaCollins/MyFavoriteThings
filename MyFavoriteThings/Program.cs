using System;

namespace MyFavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            var jericho = new Reptiles("Jericho", Type.Snake);

            jericho.CheckDiet();
            jericho.FeedReptile();

            var rogue = new Reptiles("Rogue", Type.Iguana);

            rogue.CheckDiet();
            rogue.FeedReptile();

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

            var theGrapesOfWrath = new Books("The Grapes of Wrath", 525)
            {
                HaveRead = true
            };

            theGrapesOfWrath.Open();
            theGrapesOfWrath.Read();

            var braveNewWorld = new Books("Brave New World", 452)
            {
                HaveRead = false
            };

            braveNewWorld.Read();


            Console.ReadKey();
        }
    }
}
