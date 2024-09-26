using System;
using System.Text;

namespace LibraryApp
{

	public interface IBook
	{
		public Boolean CheckIfLended (Library library);
		public string ToString();

	}
	public class Book : IBook
	{
		public string BookTitle { get; set; }
		public int NumberOfPages { get; set;}
		public Boolean IsLended {get; set;}
		public DateTime DueDate {get; set;}

		public Book(string bookTitle, int numberOfPages)
		{
			BookTitle = bookTitle;
			NumberOfPages = numberOfPages;
			IsLended = false;
			DueDate = new DateTime(2000,1,1);
		}

		public Boolean CheckIfLended (Library library)
		{
			if (library.HasBook(BookTitle))
			{
				return (false);
			}
			else
			{
				IsLended = true;
				return (true);
			}
		}

		public override string ToString()
		{
			return String.Empty;
		}
	}
}