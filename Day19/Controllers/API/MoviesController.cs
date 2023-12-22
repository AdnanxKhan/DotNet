using System.Net;
using System.Web.Http;
using MyApp.Dtos;
using MyApp.Models;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;

namespace MyApp.Controllers.API
{
    public class MoviesController : ApiController
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        public IEnumerable<MovieDto> GetMovie()
        {
            return _context.Movies.ToList().Select(Mapper.Map<Movie, MovieDto>);
        }

        public MovieDto GetMovie(int id)
        {
            var movie = _context.Movies.SingleOrDefault(c => c.MovieId == id);
            if (movie == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            return Mapper.Map<Movie, MovieDto>(movie);
        }

        [System.Web.Http.HttpPost]
        public MovieDto CreateMovie(MovieDto movieDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var movie = Mapper.Map<MovieDto, Movie>(movieDto);
            _context.Movies.Add(movie);
            _context.SaveChanges();
            movieDto.MovieId = movie.MovieId;
            return movieDto;
        }

        public void UpdateMovies(int id, MovieDto movieDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var movieInDb = _context.Movies.SingleOrDefault(c => c.MovieId == id);
            if (movieInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            Mapper.Map(movieDto, movieInDb);

            _context.SaveChanges();
        }

        [System.Web.Http.HttpDelete]
        public void DeleteMovie(int id)
        {
            var movieInDb = _context.Movies.SingleOrDefault(c => c.MovieId == id);
            if (movieInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Movies.Remove(movieInDb);
            _context.SaveChanges();
        }
    }
}
