using MyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyApp.Controllers
{
    public class MovieController : Controller
    {
        private ApplicationDbContext _context;
        public MovieController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Index()
        {
            List<Movie> movieList = _context.Movies.ToList();
            var movie = new Movie();

            return View(movieList);
     
        }
        public ActionResult Details (int id)
        {
            Movie movie = _context.Movies.SingleOrDefault(c => c.MovieId == id);
            return View(movie);
        }
    }
}