

namespace LibraryApp
{
    public class Library
    {
        public string Name {get; set;}
        public Library(string name)
        {
            Name = name;
        }
    }   
    class Program
    {
        static void Main(string[] args)
        {
            Library HomeLibrary = new Library("Burbank Rd. Library");
            Console.WriteLine("Welcome to {0}! We have ALL THE BOOKS!", HomeLibrary.Name);
        }
    }
}