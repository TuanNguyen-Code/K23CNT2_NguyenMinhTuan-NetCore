using Lession04.Models;
using Microsoft.AspNetCore.Mvc;
using Humanizer;

namespace Lession04.Controllers
{
    public class BooksController : Controller
    {
        protected Book book = new Book();
        public IActionResult NmitIndex()
        {
            ViewBag.authors = book.Authors;
            ViewBag.genres = book.Genres;

            var books = book.GetBookList();
            return View(books);
        }
    }
}
