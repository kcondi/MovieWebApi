using System;
using System.Collections.Generic;
using System.Linq;
using MovieWebApp.Data.Models.Entities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MovieWebApp.DTO.ActorDetails
{
    public class ActorDto
    {
        public static ActorDto FromActor(Actor actor)
        {
            return new ActorDto()
            {
                Id = actor.Id,
                Name = actor.Name,
                DateOfBirth = actor.DateOfBirth,
                Height = actor.Height,
                Sex = actor.Sex,
                Hair = actor.Hair,
                EyeColor = actor.EyeColor,
                Movies= actor.Movies
                    .Select(MovieWithoutCollectionsDto.FromMovie)
                    .ToList()
            };
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Height { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public Sex Sex { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public Hair Hair { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public EyeColor EyeColor { get; set; }
        public ICollection<MovieWithoutCollectionsDto> Movies { get; set; }
    }
}