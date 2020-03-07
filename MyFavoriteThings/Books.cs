using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings
{
    class Books
    {
        public string Title { get; }
        public int NumberOfPages { get; }
        public bool HaveRead { get; set; }

        public Books(string title, int numberOfPages)
        {
            Title = title;
            NumberOfPages = numberOfPages;
        }

        public void Open()
        {
            Random random = new Random();
            int selectedPage = random.Next(NumberOfPages);

            Console.WriteLine($"You flip to page {selectedPage} in {Title}...");
        }

        public void Read()
        {
            if (HaveRead)
            {
                Console.WriteLine($"You have already read {Title}.");
            }
            else
            {
                Open();
                Console.WriteLine("and begin to read.");
            }
        }
    }
}
