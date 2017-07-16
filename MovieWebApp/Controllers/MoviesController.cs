using System.Linq;
using System.Web.Http;
using MovieWebApp.Data.Models.Entities;
using MovieWebApp.Domain.Repositories;
using MovieWebApp.DTO.MovieDetails;

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
        public IHttpActionResult GetAllMovies()
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
        }

        [HttpDelete]
        [Route("delete")]
        public IHttpActionResult DeleteMovie(int id)
        {
            _movieRepository.DeleteMovie(id);
            return Ok();
        }

        [HttpPost]
        [Route("add")]
        public IHttpActionResult AddMovie(Movie movieToAdd)
        {
            _movieRepository.AddMovie(movieToAdd);
            return Ok();
        }

        [HttpGet]
        [Route("add")]
        public IHttpActionResult GetActorsGenresDirectors()
        {
            var actorsGenresDirectors = new
            {
                Actors=_actorRepository.GetAllActors(),
                Genres = _genreRepository.GetAllGenres(),
                Directors =_directorRepository.GetAllDirectors()
            };
            return Ok(actorsGenresDirectors);
        }

        [HttpGet]
        [Route("edit")]
        public IHttpActionResult GetActorsGenresDirectorsMovie(int id)
        {
            var allObjects = new
            {
                Actors = _actorRepository.GetAllActors(),
                Directors = _directorRepository.GetAllDirectors(),
                Genres = _genreRepository.GetAllGenres(),
                Movie= MovieDto.FromMovie(_movieRepository.GetMovieDetails(id))
            };
            return Ok(allObjects);
        }

        [HttpPost]
        [Route("edit")]
        public IHttpActionResult EditMovie(Movie editedMovie)
        {
            _movieRepository.EditMovie(editedMovie);
            return Ok();
        }

        [HttpGet]
        [Route("search")]
        public IHttpActionResult SearchMovies(string searchtext)
        {
            var filteredMovies = _movieRepository.SearchForMovies(searchtext);
            var movies = filteredMovies.Select(DTO.SearchMovies.MovieDto.FromMovie).ToList();
            return Ok(movies);
        }
    }
}
