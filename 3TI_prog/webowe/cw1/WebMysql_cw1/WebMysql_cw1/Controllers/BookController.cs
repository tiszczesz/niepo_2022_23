using Microsoft.AspNetCore.Mvc;
using WebMysql_cw1.Data;
using WebMysql_cw1.Models;

namespace WebMysql_cw1.Controllers
{
    public class BookController : Controller
    {
        private BookContext _bookContext;
        public BookController(BookContext bookContext)
        {
            _bookContext = bookContext;
        }

        public IActionResult Index()
        {
            List<Book> books = _bookContext.Books.ToList();
            return View(books);
        }
    }
}
