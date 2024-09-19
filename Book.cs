namespace LibraryApp
{

	public class Book
	{
		public string BookTitle { get; set; }
		public int NumberOfPages { get; set;}

		public Book(string bookTitle, int numberOfPages)
		{
			BookTitle = bookTitle;
			NumberOfPages = numberOfPages;
		}
	}
}