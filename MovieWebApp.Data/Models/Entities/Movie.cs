using System.Collections.Generic;

namespace MovieWebApp.Data.Models.Entities
{
    public class Movie
    {
        public Movie()
        {
            MovieLists=new HashSet<MovieList>();
            Actors=new HashSet<Actor>();
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Duration { get; set; }
        public string Hashtag { get; set; }
        public ICollection<MovieList> MovieLists { get; set; }
        public ICollection<Actor> Actors { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
        public int DirectorId { get; set; }
        public Director Director { get; set; }
    }
}
