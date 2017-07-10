using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MovieWebApp.Data.Models.Entities;

namespace MovieWebApp.DTO
{
    public class DirectorDto
    {
        public static DirectorDto FromDirector(Director director)
        {
            return new DirectorDto()
            {
                Id = director.Id,
                Name = director.Name,
                DateOfBirth = director.DateOfBirth
            };
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}