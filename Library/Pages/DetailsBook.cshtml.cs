using Library.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Library.Pages
{
    public class DetailsBookModel : PageModel
    {
        public LibraryService LS;
        public DetailsBookModel(LibraryService lS)
        {
            LS = lS;
        }       
        //Метод получения выбранной книги
        public IActionResult OnGet(string name)
        {
            LS.CurrenBook = LS.BookList[name];
            return Page();
        }        
    }
}
