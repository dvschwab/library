using System;
using System.Collections.Generic;

namespace LibraryApp
{
    public class Catalogue
    {
        public List<Book> Holdings;
        public int NumberOfBooks;

        public Catalogue()
        {
            Holdings = new List<Book>();
            NumberOfBooks = 0;
        }

        public Catalogue(List<Book> holdings)
        {
            Holdings = holdings;
            NumberOfBooks = Holdings.Count();
        }
    }
}