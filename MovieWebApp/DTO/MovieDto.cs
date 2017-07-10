using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
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
                Genre = movie.Genre,
                Director = movie.DirectorId.Single(),

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
        public Genre Genre { get; set; }
        public int DirectorId { get; set; }
        public Director Director { get; set; }
    }
}