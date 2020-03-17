using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.Books
{
    class PictureBook : BooksBase
    {
        public PictureBook(string title, int numberOfPages, string author)
        {
            Title = title;
            NumberOfPages = numberOfPages;
            Author = author;
        }

        public override void Open()
        {
            base.Open();
            Console.WriteLine("...and look at the pretty pictures.");
        }

        public override void Read()
        {
            Open();
        }
    }
}
