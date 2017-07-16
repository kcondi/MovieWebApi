using System;
using System.Linq;
using System.Web.Http;
using MovieWebApp.Data.Models.Entities;
using MovieWebApp.Domain.Repositories;
using MovieWebApp.DTO.MovieListDetails;
using Newtonsoft.Json.Linq;

namespace MovieWebApp.Controllers
{
    [RoutePrefix("movielists")]
    public class MovieListsController : ApiController
    {
        public MovieListsController()
        {
            _movieListRepository=new MovieListRepository();
            _movieRepository=new MovieRepository();
            _genreRepository=new GenreRepository();
            _randomNumber=new Random();
        }
        private readonly MovieListRepository _movieListRepository;
        private readonly MovieRepository _movieRepository;
        private readonly GenreRepository _genreRepository;
        private readonly Random _randomNumber;

        [HttpGet]
        [Route("")]
        public IHttpActionResult GetAllMovieListsAndGenres()
        {
            var listsAndGenres = new
            {
                MovieLists = _movieListRepository.GetAllMovieLists(),
                Genres = _genreRepository.GetAllGenres()
            };
            return Ok(listsAndGenres);
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

        [HttpPost]
        [Route("addrandom")]
        public IHttpActionResult AddRandomList(JObject indata)
        {
            var numberOfMovies = indata["numberOfMovies"].ToObject<int>();
            var genre = indata["genre"].ToObject<Genre>();
            var movies = _movieRepository.GetAllMoviesWithGenres();
            var newMovieList = new MovieList()
            {
                Name = "Random List"
            };

            if (genre != null && movies.Any(movie => movie.Genre.Name == genre.Name))
                movies = movies.FindAll(movie => movie.Genre.Name == genre.Name);

            for (var i = 0; i < numberOfMovies; i++)
                {
                    var randomMovie = movies[_randomNumber.Next(movies.Count)];
                    newMovieList.Movies.Add(randomMovie);
                    movies.Remove(randomMovie);
                    if (!movies.Any())
                        break;
                }
            _movieListRepository.AddMovieList(newMovieList);
            return Ok();
        }
    }
}
