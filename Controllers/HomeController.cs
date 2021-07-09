using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Dynamic;
using MVCBookStore.Models;

namespace MVCBookStore.Controllers
{
    public class HomeController: Controller
    {
        [ViewData]
        public string Title { get; set; } // using view data attribute

        [ViewData]
        public BookModel Book { get; set; }

        public ViewResult Index()
        {
            Directory.GetCurrentDirectory();

            /*
            ViewBag.Book1 = new BookModel()
            { Id = 34, Author = "Cumans" };*/


            return View();
        }

        public ViewResult AboutUs()
        {
            Title = "About Us"; // implementing viewdata attribute
            return View();
        }

        public ViewResult ContactUs()
        {
            Book = new BookModel() { Id = 55, Title = "AOE" };
            return View();
        }
        
    }
}
