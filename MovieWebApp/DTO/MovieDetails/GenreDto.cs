using MovieWebApp.Data.Models.Entities;

namespace MovieWebApp.DTO.MovieDetails
{
    public class GenreDto
    {
        public static GenreDto FromGenre(Genre genre)
        {
            return new GenreDto()
            {
                Id = genre.Id,
                Name = genre.Name
            };
        }
        public int Id { get; set; }
        public string Name { get; set; }
    }
}