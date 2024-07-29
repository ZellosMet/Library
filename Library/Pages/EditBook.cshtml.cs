using Library.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Library.Pages
{
    public class EditBookModel : PageModel
    {
        public LibraryService LS;
        public EditBookModel(LibraryService lS)
        {
            LS = lS;
        }
        //Метод для получения выбранной книги
        public IActionResult OnGet(string name)
        {
            LS.CurrenBook = LS.BookList[name];
            return Page();
        }
        //Метод для изменения книги
        public IActionResult OnPostEditBook(string name, string author, string style, string publisher, string year)
        { 
            LS.RemoveBook(LS.CurrenBook.Name);
            LS.AddBook(name, author, style, publisher, year);
            LS.CurrenBook = LS.BookList[name];
            return Page();
        }
    }
}
