
namespace LibraryApp
{
    
    class Program
    {
        static void Main(string[] args)
        {

            // Make some books and then add them to a list

            Book witchBook = new Book("Wicca", 350);
            Book goodRead = new Book("Anna Karina", 780);
            Book alexBook = new Book("Anna Marie's Housekeeping", 130);
            Book amandaBook = new Book("Wheel of Time", 700);

            List<Book> theBooks = new List<Book>();
            theBooks.Add(witchBook);
            theBooks.Add(goodRead);
            theBooks.Add(alexBook);
            theBooks.Add(amandaBook);

            // Make the library having these books

            Library HomeLibrary = new Library("Burbank Rd.", theBooks);
            Console.WriteLine("Welcome to the {0} Library.", HomeLibrary.LibraryName);
            Console.WriteLine("Here are the books available for checkout:");
            HomeLibrary.ListCatalogue();

            // Make a Patron and have them borrow a book.

            Patron newPatron = new Patron(12345, "Book Lover", HomeLibrary);

            Console.WriteLine("The patron {0} has Library Card {1}", newPatron.PatronName, newPatron.CardNumber);
            Console.WriteLine("Their home library is the {0} Library", newPatron.HomeLibrary.LibraryName);

            HomeLibrary.LendBook(newPatron, witchBook);
            Console.WriteLine("The patron has now borrowed {0}", witchBook.BookTitle);
            Console.WriteLine("The library catalogue does not have this book any more");
            HomeLibrary.ListCatalogue();

            // Verify that the book is lended
            Console.WriteLine("Is the book {0} now lended?", witchBook.BookTitle);
            Console.WriteLine(witchBook.CheckIfLended(HomeLibrary).ToString());

            // Show the due date
            Console.WriteLine("The due date is {0:D}", witchBook.DueDate);
        }
    }
}