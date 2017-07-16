using System;
using MovieWebApp.Data.Models.Entities;

namespace MovieWebApp.DTO.MovieDetails
{
    public class ActorDto
    {
        public static ActorDto FromActor(Actor actor)
        {
            return new ActorDto()
            {
                Id = actor.Id,
                Name=actor.Name,
                DateOfBirth = actor.DateOfBirth,
                Height = actor.Height,
                Sex = actor.Sex,
                Hair = actor.Hair,
                EyeColor = actor.EyeColor
            };
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Height { get; set; }
        public Sex Sex { get; set; }
        public Hair Hair { get; set; }
        public EyeColor EyeColor { get; set; }
        }      
    }