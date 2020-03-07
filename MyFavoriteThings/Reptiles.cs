using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings
{
    enum Type
    {
        Snake,
        Iguana,
        Alligator
    }
    class Reptiles
    {
        public string Name { get; }
        public Type Type { get; }
        public bool IsHerbivore { get; private set; }
        
        public Reptiles(string name, Type type)
        {
            Name = name;
            Type = type;
        }

        public void CheckDiet()
        {
            switch (Type)
            {
                case Type.Snake:
                    IsHerbivore = false;
                    break;
                case Type.Iguana:
                    IsHerbivore = true;
                    break;
                case Type.Alligator:
                    IsHerbivore = false;
                    break;
                default:
                    break;
            }
        }

        public void FeedReptile()
        {
            if (IsHerbivore)
            {
                Console.WriteLine($"{Name} should be fed veggies because they are a {Type}.");
            }
            else
            {
                Console.WriteLine($"{Name} should be fed meats because they are a {Type}.");
            }
        }


    }
}
