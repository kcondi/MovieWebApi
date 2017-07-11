using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MovieWebApp.Data.Models.Entities;

namespace MovieWebApp.DTO.ActorDetails
{
    public class MovieDto
    {
        public static MovieDto FromMovie(Movie movie)
        {
            return new MovieDto()
            {
                Id = movie.Id,
                Title = movie.Title,
            };
        }
        public int Id { get; set; }
        public string Title { get; set; }
    }
}