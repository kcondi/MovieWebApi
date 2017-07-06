using MovieWebApp.Data.Models;
using MovieWebApp.Data.Models.Entities;

namespace MovieWebApp.Domain.Repositories
{
    public class GenreRepository
    {
        public GenreRepository()
        {
            _context=new MovieContext();
        }

        private readonly MovieContext _context;

        public Genre GetGenre(int genreToGetId)
        {
            return _context.Genres.Find(genreToGetId);
        }
    }
}
