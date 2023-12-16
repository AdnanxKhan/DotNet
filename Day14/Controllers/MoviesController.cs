using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication10.Models;
using WebApplication10.ViewModels;

namespace WebApplication10.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek"};
            var customers = new List<Customer>() 
            {
                new Customer{Name = "Adnan" },
                new Customer{ Name ="Jeet " }
            };
            var viewModel = new RandomViewModel
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
        }
    }
}