using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.Reptiles
{
    abstract class ReptilesBase
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public bool IsHerbivore { get; set; }
        public bool HasScales => true;

        public abstract void Speak();

        public virtual void FeedReptile()
        {
            Console.WriteLine("Nom, nom, nom");
        }


    }
}
