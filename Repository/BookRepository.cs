using MVCBookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCBookStore.Repository
{
    public class BookRepository
    {

        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookById(int id)
        {
            return DataSource().Where(u => u.Id == id).FirstOrDefault();

        }

        public List<BookModel> SearchBook(string title, string author)
        {
            return DataSource().Where(u => 
            u.Title.Contains(title) || u.Author.Contains(author)).ToList();                
         }

        private List<BookModel> DataSource()
        {

            return new List<BookModel>()
            {
                new BookModel(){Id=1, Title="c#",Author="rifleman" },
                new BookModel(){Id=2, Title=".net core",Author="microsoft" },
                new BookModel(){Id=3, Title="asp mvc",Author="open source" },
                new BookModel(){Id=4, Title="web dev",Author="mozila" }
            };

        }


    }
}
