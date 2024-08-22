namespace LibraryApp
{
	public interface IBook
	{
		public long Book(long ID, string title, int numberOfPages, Library library);
		public bool isAvailable(Library library);
		public Library HeldBy();
		public Patron Borrower();
	}

	public class LibraryBook : IBook
	{
		public long BookID { get; set; }
		public string Title { get; set; }
		public int NumberOfPages { get; set;}
		public LibraryBook(long id, string title, int numberOfPages, Library library)
		{
			BookID = id;
			Title = title;
			NumberOfPages = numberOfPages;
			Library = library;
		}

		public bool isAvailable(Library library)
		{
			return false;
		}

		public Library HeldBy()
		{
			return false;
		}

		public Patron Borrower()
		{
			return false;
		}


	}
}