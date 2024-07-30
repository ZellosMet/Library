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
        //Метод удаление книги из списка
        public IActionResult OnPostDeleteBook(string name)
        {
            LS.RemoveBook(name);
            return Page();
        }
        //Метод редактирования книги
        public void OnPostEditBook(string name)
        {
            //Запоминаем выбранную книгу
            LS.CurrenBook = LS.BookList[name];   
        }
        //Метод фильтрации книги по всем параметрам
        public IActionResult OnPostSearchBook(string search, string select)
        {
            if (search == null)
            {
                AllSearch();
                return Page();
            } 
            LS.SearchList.Clear();
            foreach (var book in LS.BookList)
            {
                switch (select)
                {
                    case "Name": if (book.Value.Name.Contains(search)) LS.AddSearchBook(book.Value.Name, book.Value); break;
                    case "Author": if (book.Value.Author.Contains(search)) LS.AddSearchBook(book.Value.Name, book.Value); break;
                    case "Style": if (book.Value.Style.Contains(search)) LS.AddSearchBook(book.Value.Name, book.Value); break;
                    case "Publisher": if (book.Value.Publisher.Contains(search)) LS.AddSearchBook(book.Value.Name, book.Value); break;
                    case "Year": if (book.Value.Year.Contains(search)) LS.AddSearchBook(book.Value.Name, book.Value); break;
                    default: AllSearch(); break;
                }
            }
            return Page();
        }
        //Метод обнуления фильтрации
        public void AllSearch()
        {
            LS.SearchList.Clear();
            foreach (var book in LS.BookList)            
                LS.AddSearchBook(book.Value.Name, book.Value);            
        }
    }
}
