namespace LibraryApp
{
    public interface ILibrary
    {
        bool HasBook(string book);
    }

    public class Library : ILibrary
    {
        public string Name {get; set;}
        public Library(string name)
        {
            Name = name;
        }

        public bool HasBook(Book book)
        {
            if(book.title ==)
        }
    }
}