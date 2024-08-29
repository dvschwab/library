
namespace LibraryApp
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Library HomeLibrary = new Library("Burbank Rd. Library");
            Console.WriteLine("Welcome to {0}! We have ALL THE BOOKS!", HomeLibrary.Name);

            bool result = HomeLibrary.HasBook("Bible");
            Console.WriteLine(result);
            result = HomeLibrary.HasBook("Wicca");
            Console.WriteLine(result);
        }
    }
}