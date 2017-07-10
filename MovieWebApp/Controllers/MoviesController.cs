using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MovieWebApp.Data.Models.Entities;
using MovieWebApp.Domain.Repositories;
using MovieWebApp.DTO;

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

        [HttpGet]
        [Route("")]
        public IHttpActionResult GetMovies()
        {
            return Ok(_movieRepository.GetAllMovies());
        }

        [HttpGet]
        [Route("details")]
        public IHttpActionResult GetMovieDetails(int id)
        {
        var movieDetails = _movieRepository.GetMovieDetails(id);
         var movie = MovieDto.FromMovie(movieDetails);
        return Ok(movie);
         //   var details = _movieRepository.GetMovieDetails(id);
          //  return Ok(details);
        }

        [HttpDelete]
        [Route("delete")]
        public IHttpActionResult DeleteMovie(int id)
        {
            _movieRepository.DeleteMovie(id);
            return Ok();
        }
    }
}
