using Library.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Library.Pages
{
    public class IndexModel : PageModel
    {
        public LibraryService LS;
        public IndexModel(LibraryService lS)
        {
            LS = lS;
        }   

        public void OnGet(){}
        public IActionResult OnPostDeleteBook(string name)
        {
            LS.RemoveBook(name);
            return Page();
        }
        public void OnPostEditBook(string name)
        {
            LS.CurrenBook = LS.BookList[name];   
        }
        public IActionResult OnPostSearchBook(string search)
        {
            LS.SearchList.Clear();
            foreach (var book in LS.BookList)
            { 
                if(book.Value.Name.Contains(search))
                    LS.AddSearchBook(book.Value.Name, book.Value);
                if (book.Value.Author.Contains(search))
                    LS.AddSearchBook(book.Value.Name, book.Value);
                if (book.Value.Style.Contains(search))
                    LS.AddSearchBook(book.Value.Name, book.Value);
                if (book.Value.Publisher.Contains(search))
                    LS.AddSearchBook(book.Value.Name, book.Value);
                if (book.Value.Year.Contains(search))
                    LS.AddSearchBook(book.Value.Name, book.Value);
            }
            return Page();
        }
        public IActionResult OnPostResetSearch()
        {
            LS.SearchList.Clear();
            foreach (var book in LS.BookList)            
                LS.AddSearchBook(book.Value.Name, book.Value);            
            return Page();
        }
    }
}
