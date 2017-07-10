using System.Collections.Generic;
using System.Linq;
using MovieWebApp.Data.Models.Entities;

namespace MovieWebApp.DTO
{
    public class MovieDto
    {
        public static MovieDto FromMovie(Movie movie)
        {
            return new MovieDto()
            {
                Id = movie.Id,
                Title = movie.Title,
                Year = movie.Year,
                Hashtag = movie.Hashtag,
                Genre = GenreDto.FromGenre(movie.Genre),
                Director = DirectorDto.FromDirector(movie.Director),
                Actors = movie.Actors
                .Select(ActorDto.FromActor)
                .ToList()
            };
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Hashtag { get; set; }
        public ICollection<MovieList> MovieLists { get; set; }
        public ICollection<ActorDto> Actors { get; set; }
        public int GenreId { get; set; }
        public GenreDto Genre { get; set; }
        public int DirectorId { get; set; }
        public DirectorDto Director { get; set; }
    }
}