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

        public List<BookModel> GetAllBook()
        {

            return _bookRepository.GetAllBooks();
        }

        public BookModel GetBook(int id)
        {

            return _bookRepository.GetBookById(id);

        }

        public List<BookModel> SearchBooks(string bookName, string authorName)
        {

            return _bookRepository.SearchBook(bookName, authorName);
        }

    }
}
