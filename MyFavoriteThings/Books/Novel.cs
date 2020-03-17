using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.Books
{
    class Novel : BooksBase
    {
        public Novel(string title, int numberOfPages, string author)
        {
            Title = title;
            NumberOfPages = numberOfPages;
            Author = author;
        }
    }
}
