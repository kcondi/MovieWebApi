using MovieWebApp.Data.Models;
using MovieWebApp.Data.Models.Entities;

namespace MovieWebApp.Domain.Repositories
{
    public class DirectorRepository
    {
        public DirectorRepository()
        {
            _context = new MovieContext();
        }

        private readonly MovieContext _context;

        public Director GetDirector(int directorToGetId)
        {
            return _context.Directors.Find(directorToGetId);
        }
    }
}
