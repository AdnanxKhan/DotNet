using MyApp.Models;
using MyApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
       
        public ActionResult Create()
        {
            var movie = new Movie();
            return View(movie);
        }
        [HttpPost]
       
        public ActionResult Create(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                
                return View("Create", movie);
            }
            _context.Movies.Add(movie);
            _context.SaveChanges();
                
            return  RedirectToAction("Index","Movie");
        }
        [HttpGet]
        public ActionResult Details(int id)
        {
            Movie movie = _context.Movies.SingleOrDefault(c => c.MovieId == id);
            return View("Details",movie);
        }
        [HttpPost]
        public ActionResult Details(Movie movie)
        {
           


                var movieInDb = _context.Movies.SingleOrDefault(m => m.MovieId == movie.MovieId);
               
                    movieInDb.MovieName = movie.MovieName;
                    movieInDb.Genre = movie.Genre;
                    movieInDb.ReleaseDate = movie.ReleaseDate;
                    movieInDb.DateAdded = movie.DateAdded;
                    movieInDb.NumberInStock = movie.NumberInStock;
                    _context.SaveChanges();

                    return RedirectToAction("Index", "Movie");
           
        }
        public ActionResult Delete(int id)
        {
            var movie = _context.Movies.SingleOrDefault(c => c.MovieId== id);

            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ConfirmDelete(int id)
        {
            var movie = _context.Movies.SingleOrDefault(c => c.MovieId == id);

            if (movie == null)
                return HttpNotFound();

            _context.Movies.Remove(movie);
            _context.SaveChanges();

            return RedirectToAction("Index", "Movie");
        }

    }
}