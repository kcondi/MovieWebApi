using System.Collections.Generic;
using System.Linq;
using MovieWebApp.Data.Models.Entities;

namespace MovieWebApp.DTO.MovieListDetails
{
    public class MovieListDto
    {
        public static MovieListDto FromMovieList(MovieList movieList)
        {
            return new MovieListDto()
            {
                Id = movieList.Id,
                Name = movieList.Name,
                Movies = movieList.Movies
                    .Select(MovieWithoutCollectionsDto.FromMovie)
                    .ToList()
            };
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<MovieWithoutCollectionsDto> Movies { get; set; }
    }
}