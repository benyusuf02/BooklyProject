using BooklyProject.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BooklyProject.Entities;

namespace BooklyProject.Controllers
{
    [Authorize]
    public class BooksController : Controller
    {
        BooklyContext context= new BooklyContext();
        // GET: Books
        [HttpGet]
        public ActionResult Index(string searchText)
        {
            List<Book> values;
            if (string.IsNullOrEmpty(searchText))
            {
                values = context.Books.Where (x => x.BookName.Contains(searchText)).ToList();
                return View(values);
            }
            else
            {
                values = context.Books.ToList();
                return View(values);
            }
        }
    }
}