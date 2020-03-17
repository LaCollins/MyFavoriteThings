using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.Reptiles
{
    class Snake : ReptilesBase
    {
        public Snake(string name, string species)
        {
            Name = name;
            Species = species;
            IsHerbivore = false;
        }

        public override void Speak()
        {
            Console.WriteLine("\nHiss!");
        }

        public override void FeedReptile()
        {
            Console.WriteLine($"\n{Name}, the {Species} eats a mouse!");
            base.FeedReptile();
        }

        public void Slither()
        {
            Console.WriteLine("\nslither, slither");
        }
    }
}
