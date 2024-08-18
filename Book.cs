namespace LibraryApp
{
public interface IBook
	public Book(unsigned long ID, string title, unsigned int numberOfPages, Library library)
	public bool isAvailable(Library library)
	public Library HeldBy()
	public Patron Borrower()

public class LibraryBook : IBook
{
	public long BookID { get; set; }
	public string Title { get; set; }
	public unsigned int NumberOfPages { get; set;}
	public LibraryBook(unsigned long ID, string title, unsigned int numberOfPages)
	{
		BookID = ID;
		Title = title;
		NumberOfPages = numberOfPages;
	}

	bool isAvailable(Library library)
	{
		return false;
	}

	Library HeldBy()
	{
		return false;
	}

	Patron Borrower()
	{
		return false;
	}


}
}