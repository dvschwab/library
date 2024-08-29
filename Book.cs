namespace LibraryApp
{
	public interface IBook
	{
		public bool isAvailable(Library library);
	}

	public class Book : IBook
	{
		public long BookID { get; set; }
		public string Title { get; set; }
		public int NumberOfPages { get; set;}

		public Book(long id, string title, int numberOfPages)
		{
			BookID = id;
			Title = title;
			NumberOfPages = numberOfPages;
		}

		public bool isAvailable(Library library)
		{
			if (library.HasBook(Title))
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}