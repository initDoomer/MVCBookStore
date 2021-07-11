using Microsoft.AspNetCore.Mvc;
using MVCBookStore.Models;
using MVCBookStore.Repository;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCBookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;
        public BookController()
        {
            _bookRepository = new BookRepository();
        }

        public ViewResult GetAllBook()
        {

            var data =  _bookRepository.GetAllBooks();
            return View(data);
        }

        public ViewResult GetBook(int id)
        {

            dynamic data1 = new ExpandoObject();
            data1.book = _bookRepository.GetBookById(id);
            data1.Info = "Using Dynamic Views with expando";

            return View(data1);

        }

        public List<BookModel> SearchBooks(string bookName, string authorName)
        {

            return _bookRepository.SearchBook(bookName, authorName);
        }

    }
}
