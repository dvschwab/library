namespace LibraryApp
{
     
    public class Patron
    {
        unsigned long CardNumber {get;set;}
        string PatronName {get; set};
        Library HomeLibrary {get; set;}
        Patron(unsigned long cardNumber, string name, Library homeLibrary)
        {
        return false;
        }
        
    }
}