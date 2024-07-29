using Library.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Library.Pages
{
    public class AddBookModel : PageModel
    {
        public LibraryService LS;
        public AddBookModel(LibraryService ls) 
        {
            LS = ls;
        }
        public void OnGet(){}
        //Метод для создании книги
        public void OnPostAddBook(string name, string author, string style, string publisher, string year)
        {
            LS.AddBook(name, author, style, publisher, year);
        }
    }
}
