namespace Library.Models
{
    public class LibraryService
    {
        public Book CurrenBook; 
        static readonly Book book1 = new Book("CLR via C#", "Jeffrey Richter", "Programming", "Piter", "2013");
        static readonly Book book2 = new Book("ASP NET Core in Action", "Andrew Lock", "Programming", "DMK", "2021");

        public readonly IDictionary<string, Book> BookList = new Dictionary<string, Book>
        {
            { book1.Name, book1},
            { book2.Name, book2},
        };
        public readonly IDictionary<string, Book> SearchList = new Dictionary<string, Book>
        {
            { book1.Name, book1},
            { book2.Name, book2},
        };

        public void AddBook(string name, string author, string style, string publisher, string year)
        {
            Book book = new Book(name, author, style, publisher, year);
            BookList.Add(name, book);
            AddSearchBook(book.Name, book);
        }
        public void AddSearchBook(string name, Book book)
        {
            SearchList.Add(name, book);
        }
        public void RemoveBook(string name)
        {
            BookList.Remove(name);
            SearchList.Remove(name);
        }
    }
}
