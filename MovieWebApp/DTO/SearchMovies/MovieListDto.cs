using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MovieWebApp.Data.Models.Entities;

namespace MovieWebApp.DTO.SearchMovies
{
    public class MovieListDto
    {
        public static MovieListDto FromMovieList(MovieList movieList)
        {
            return new MovieListDto()
            {
                Id = movieList.Id,
                Name = movieList.Name
            };
        }
        public int Id { get; set; }
        public string Name { get; set; }
    }
}