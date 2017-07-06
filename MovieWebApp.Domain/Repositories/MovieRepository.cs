using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using MovieWebApp.Data.Models;
using MovieWebApp.Data.Models.Entities;

namespace MovieWebApp.Domain.Repositories
{
    public class MovieRepository
    {
        public MovieRepository()
        {
            _context=new MovieContext();
        }

        private readonly MovieContext _context;

        public List<Movie> GetAllMovies()
        {
            return _context.Movies.ToList();
        }

        public Movie GetMovieDetails(int movieToGetId)
        {
            return _context.Movies
                .Include(x => x.Actors)
                .Include(x => x.Director)
                .SingleOrDefault(movie => movie.Id == movieToGetId);
        }

        public void AddMovie(Movie movieToAdd)
        {
            _context.Movies.Add(movieToAdd);
            _context.SaveChanges();
        }

        public void EditMovie(Movie editedMovie)
        {
            var movieToEdit = _context.Movies.Find(editedMovie.Id);
            if (movieToEdit == null)
                return;
            movieToEdit.Title = editedMovie.Title;
            movieToEdit.Genre = editedMovie.Genre;
            movieToEdit.Hashtag = editedMovie.Hashtag;
            movieToEdit.Year = editedMovie.Year;
            _context.SaveChanges();
        }

        public void DeleteMovie(int movieToDeleteId)
        {
            var movieToDelete = _context.Movies.Find(movieToDeleteId);
            if (movieToDelete == null)
                return;
            _context.Movies.Remove(movieToDelete);
            _context.SaveChanges();
        }
    }
}
