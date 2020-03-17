using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.Reptiles
{
    class Iguana : ReptilesBase
    {
        public Iguana(string name, string species)
        {
            Name = name;
            Species = species;
            IsHerbivore = false;
        }

        public override void Speak()
        {
            Console.WriteLine("\nThe iguana judges you silently.");
        }

        public override void FeedReptile()
        {
            Console.WriteLine($"\n{Name} eats a leaf!");
            base.FeedReptile();
        }

        public void Dislike()
        {
            Console.WriteLine("\nThe iguana hates you and everything you stand for.");
        }
    }
}
