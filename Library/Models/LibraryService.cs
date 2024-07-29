namespace Library.Models
{
    //Сервисный класс для работы с данными
    public class LibraryService
    {
        //Выбранная книга
        public Book CurrenBook; 
        static readonly Book book1 = new Book("CLR via C#", "Jeffrey Richter", "Programming", "Piter", "2013");
        static readonly Book book2 = new Book("ASP NET Core in Action", "Andrew Lock", "Programming", "DMK", "2021");

        //Список всех книг
        public readonly IDictionary<string, Book> BookList = new Dictionary<string, Book>
        {
            { book1.Name, book1},
            { book2.Name, book2},
        };

        //Список отфильтрованных книг
        public readonly IDictionary<string, Book> SearchList = new Dictionary<string, Book>
        {
            { book1.Name, book1},
            { book2.Name, book2},
        };
        // Метод добавления книги в список книг
        public void AddBook(string name, string author, string style, string publisher, string year)
        {
            Book book = new Book(name, author, style, publisher, year);
            BookList.Add(name, book);
            AddSearchBook(book.Name, book);
        }
        //Метод добавления книги в список отфильтрованных книг
        public void AddSearchBook(string name, Book book)
        {
            SearchList.Add(name, book);
        }
        //Метод удаления книги из списка книг
        public void RemoveBook(string name)
        {
            BookList.Remove(name);
            SearchList.Remove(name);
        }
    }
}
