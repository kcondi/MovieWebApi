using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MovieWebApp.Data.Models.Entities;

namespace MovieWebApp.DTO
{
    public class MovieWithoutCollectionsDto
    {
        public static MovieWithoutCollectionsDto FromMovie(Movie movie)
        {
            return new MovieWithoutCollectionsDto()
            {
                Id = movie.Id,
                Title = movie.Title
            };
        }
        public int Id { get; set; }
        public string Title { get; set; }
    }
}