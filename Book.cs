namespace LibraryApp
{
public interface IBook
	Book(unsigned long ID, string title, unsigned int numberOfPages, Library library)
	bool isAvailable(Library library)
	Library HeldBy()
	Patron Borrower()

public class LibraryBook : IBook
{
	public long BookID { get; set; }
	public string Title { get; set; }
	public unsigned int NumberOfPages { get; set;}
	LibraryBook(unsigned long ID, string title, unsigned int numberOfPages)
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