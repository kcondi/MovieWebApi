using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using MovieWebApp.Data.Models;
using MovieWebApp.Data.Models.Entities;

namespace MovieWebApp.Domain.Repositories
{
    public class MovieListRepository
    {
        public MovieListRepository()
        {
            _context = new MovieContext();
        }

        private readonly MovieContext _context;

        public List<MovieList> GetAllMovieLists()
        {
            return _context.MovieLists.ToList();
        }
        public MovieList GetMovieListDetails(int movieListToGetId)
        {
            return _context.MovieLists
                .Include(movieList => movieList.Movies)
                .SingleOrDefault(movieList => movieList.Id == movieListToGetId);
        }
        public void AddMovieList(MovieList movieListToAdd)
        {
            foreach (var movie in movieListToAdd.Movies)
                _context.Movies.Attach(movie);

            _context.MovieLists.Add(movieListToAdd);
            _context.SaveChanges();
        }
        public void EditMovieList(MovieList editedMovieList)
        {
            foreach (var movie in editedMovieList.Movies)
                _context.Movies.Attach(movie);

            var movieListToEdit = _context.MovieLists
                .Include(movieList => movieList.Movies)
                .FirstOrDefault(movieList => movieList.Id == editedMovieList.Id);
            if (movieListToEdit == null)
                return;
            movieListToEdit.Name = editedMovieList.Name;
            movieListToEdit.Movies = editedMovieList.Movies;
            _context.SaveChanges();
        }
        public void DeleteMovieList(int movieListToDeleteId)
        {
            var movieListToDelete = _context.MovieLists.Find(movieListToDeleteId);
            if (movieListToDelete == null)
                return;
            _context.MovieLists.Remove(movieListToDelete);
            _context.SaveChanges();
        }
    }
}
