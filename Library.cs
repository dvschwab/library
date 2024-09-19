using System; 
using System.Collections; 
using System.Collections.Generic; 

namespace LibraryApp
{


    public class Library
    {
        public string LibraryName {get; set;}
        public List<Book> Catalogue {get; set;}

        // Make a new library
        // Give it an empty catalogue if necessary

        public Library(string libraryName, List<Book> catalogue)
        {
            LibraryName = libraryName;
            
            if(catalogue != null)
            {
                Catalogue = catalogue;
            }
            else
            {
                this.Catalogue = new List<Book>();
            }
        }

        public bool HasBook(string bookTitle)
        {   
            if (bookTitle != null)
            {
                foreach(Book book in this.Catalogue)
                {
                    if (book.BookTitle == bookTitle)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public void ListCatalogue()
        {
            foreach (Book book in this.Catalogue)
            {
                Console.WriteLine(book.BookTitle);
            }
        }

        public string LendBook(Patron borrower, Book book)
        {
            this.Catalogue.Remove(book);
            borrower.Borrowed.Add(book);
            return(book.BookTitle);
        }
                
    }
}