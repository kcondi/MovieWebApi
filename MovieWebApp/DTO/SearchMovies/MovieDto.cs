using System.Collections.Generic;
using System.Linq;
using MovieWebApp.Data.Models.Entities;
using MovieWebApp.DTO.MovieDetails;

namespace MovieWebApp.DTO.SearchMovies
{
    public class MovieDto
    {
        public static MovieDto FromMovie(Movie movie)
        {
            return new MovieDto()
            {
                Id = movie.Id,
                Title = movie.Title,
                Director = DirectorDto.FromDirector(movie.Director),
                MovieLists = movie.MovieLists
                    .Select(MovieListDto.FromMovieList)
                    .ToList()
            };
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<MovieListDto> MovieLists { get; set; }
        public int DirectorId { get; set; }
        public DirectorDto Director { get; set; }
    }
}