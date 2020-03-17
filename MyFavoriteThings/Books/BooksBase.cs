using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings
{
    class BooksBase
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int NumberOfPages { get; set; }
        public virtual bool HaveRead { get; set; }

        public virtual void Open()
        {
            Random random = new Random();
            int selectedPage = random.Next(NumberOfPages);
            if (selectedPage == 0)
            {
                selectedPage += 1;
            }

            Console.WriteLine($"\nYou flip to page {selectedPage} in {Title}...");
        }

        public virtual void Read()
        {
            if (HaveRead)
            {
                Console.WriteLine($"\nYou have already read {Title}.");
            }
            else
            {
                Open();
                Console.WriteLine("and begin to read.");
            }
        }
    }
}
