using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.Reptiles
{
    class Alligator : ReptilesBase
    {
        public Alligator(string name, string species)
        {
            Name = name;
            Species = species;
            IsHerbivore = false;
        }

        public override void Speak()
        {
            Console.WriteLine("\nGrunt!");
        }

        public override void FeedReptile()
        {
            Console.WriteLine($"\n{Name}, eats a tourist!");
            base.FeedReptile();
        }

        public void DeathRoll()
        {
            Console.WriteLine("\nSplash! Splash!");
        }
    }
}
