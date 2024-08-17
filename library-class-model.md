# LIBRARY MODEL


interface ILibrary
	Library( string name)
	List<Book> Holdings()
	Lend(Book book)
	bool HasBook(Book book)
	unsigned int CollectionSize()
	
	
interface IBook
	Book(unsigned long ID, string title, unsigned int numberOfPages, Library library)
	bool isAvailable(Library library)
	Library HeldBy()
	Patron Borrower()
	
	
interface IPatron
	Patron(unsigned long cardNumber, string name, homeLibrary Library)
	Borrow(Book book)
	Return(Book book)
	List<Book> Borrowed()
	bool HasBook(Book book)
	Library HomeLibrary() 
	unsigned int NumberOfBooks()
	

abstract class Holding
	Holding(unsigned long ID, string title, Library library)
	
class Book : Holding : IBook
class Library : ILibrary
class Patron : IPatron
