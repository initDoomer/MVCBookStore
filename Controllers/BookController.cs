using Microsoft.AspNetCore.Mvc;
using MVCBookStore.Models;
using MVCBookStore.Repository;
using System;
using System.Collections.Generic;
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

            var data = _bookRepository.GetBookById(id);

            return View(data);

        }

        public List<BookModel> SearchBooks(string bookName, string authorName)
        {

            return _bookRepository.SearchBook(bookName, authorName);
        }

    }
}
