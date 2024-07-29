namespace Library.Models
{
    public class Book
    {
        string _name;
        string _author;
        string _style;
        string _publisher;
        string _year;

        public string Name { get { return _name; } set { _name = value; } }
        public string Author { get { return _author; } set { _author = value; } }
        public string Style { get { return _style; } set { _style = value; } }
        public string Publisher { get { return _publisher; } set { _publisher = value; } }
        public string Year { get { return _year; } set { _year = value; } }
        public Book(string name, string author, string style, string publisher, string year)
        { 
            Name = name;
            Author = author;
            Style = style;
            Publisher = publisher;
            Year = year;
        }
    }
}
