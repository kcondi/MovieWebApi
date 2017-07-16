using System;
using System.Collections.Generic;
using System.Linq;
using MovieWebApp.Data.Models.Entities;

namespace MovieWebApp.DTO.DirectorDetails
{
    public class DirectorDto
    {
        public static DirectorDto FromDirector(Director director)
        {
            return new DirectorDto()
            {
                Id = director.Id,
                Name = director.Name,
                DateOfBirth = director.DateOfBirth,
                Movies = director.Movies
                    .Select(MovieWithoutCollectionsDto.FromMovie)
                    .ToList()
            };
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public ICollection<MovieWithoutCollectionsDto> Movies { get; set; }
    }
}