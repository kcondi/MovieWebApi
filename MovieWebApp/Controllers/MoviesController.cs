using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MovieWebApp.Domain.Repositories;

namespace MovieWebApp.Controllers
{
    [RoutePrefix("movies")]
    public class MoviesController : ApiController
    {
        public MoviesController()
        {
            _movieRepository=new MovieRepository();
            _genreRepository=new GenreRepository();
            _actorRepository=new ActorRepository();
            _directorRepository=new DirectorRepository();
        }

        private readonly MovieRepository _movieRepository;
        private readonly GenreRepository _genreRepository;
        private readonly ActorRepository _actorRepository;
        private readonly DirectorRepository _directorRepository;


    }
}
