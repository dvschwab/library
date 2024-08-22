namespace LibraryApp
{
     
    public class Patron
    {
        public long CardNumber {get;set;}
        public string PatronName {get; set;}
        public Library HomeLibrary {get; set;}
        public Patron( long cardNumber, string name, Library homeLibrary)
        {
            CardNumber = cardNumber;
            PatronName = name;
            HomeLibrary = homeLibrary;
        }
        
    }
}