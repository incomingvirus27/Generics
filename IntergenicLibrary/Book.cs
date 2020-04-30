namespace IntergenicLibrary
{
    public class Book
    {
        
        public string BookName{get; set;}
        public string BookID{get; set;}

        public Book(string bookname, string bookID)
        {
            BookName = bookname;
            BookID = bookID;
        }
    }
}