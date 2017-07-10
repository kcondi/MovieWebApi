using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using MovieWebApp.Data.Models;
using MovieWebApp.Data.Models.Entities;

namespace MovieWebApp.Domain.Repositories
{
    public class ActorRepository
    {
        public ActorRepository()
        {
            _context=new MovieContext();
        }

        private readonly MovieContext _context;
        public Actor GetActor(int actorToGetId)
        {
            return _context.Actors.Find(actorToGetId);
        }

        public List<Actor> GetAllActors()
        {
            return _context.Actors.ToList();
        }
    }
}
