using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MovieWebApp.Data.Models.Entities;
using MovieWebApp.Domain.Repositories;
using MovieWebApp.DTO.MovieListDetails;

namespace MovieWebApp.Controllers
{
    [RoutePrefix("movielists")]
    public class MovieListsController : ApiController
    {
        public MovieListsController()
        {
            _movieListRepository=new MovieListRepository();
            _movieRepository=new MovieRepository();
        }
        private readonly MovieListRepository _movieListRepository;
        private readonly MovieRepository _movieRepository;

        [HttpGet]
        [Route("")]
        public IHttpActionResult GetAllMovieLists()
        {
            return Ok(_movieListRepository.GetAllMovieLists());
        }

        [HttpGet]
        [Route("details")]
        public IHttpActionResult GetMovieListDetails(int id)
        {
            var movieListDetails = _movieListRepository.GetMovieListDetails(id);
            var movieList = MovieListDto.FromMovieList(movieListDetails);
            return Ok(movieList);
        }

        [HttpDelete]
        [Route("delete")]
        public IHttpActionResult DeleteMovieList(int id)
        {
            _movieListRepository.DeleteMovieList(id);
            return Ok();
        }

        [HttpPost]
        [Route("add")]
        public IHttpActionResult AddMovieList(MovieList movieListToAdd)
        {
            _movieListRepository.AddMovieList(movieListToAdd);
            return Ok();
        }

        [HttpGet]
        [Route("add")]
        public IHttpActionResult GetAllMovies()
        {
            return Ok(_movieRepository.GetAllMovies());
        }

        [HttpGet]
        [Route("edit")]
        public IHttpActionResult GetMoviesMovieList(int id)
        {
            var allObjects = new
            {
                Movies = _movieRepository.GetAllMovies(),
                MovieList = MovieListDto.FromMovieList(_movieListRepository.GetMovieListDetails(id)) 
            };
            return Ok(allObjects);
        }

        [HttpPost]
        [Route("edit")]
        public IHttpActionResult EditMovie(MovieList editedMovieList)
        {
            _movieListRepository.EditMovieList(editedMovieList);
            return Ok();
        }
    }
}
