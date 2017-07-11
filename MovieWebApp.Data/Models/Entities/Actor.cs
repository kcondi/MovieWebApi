using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MovieWebApp.Data.Models.Entities
{
    public enum Sex
    {
        Male,
        Female
    }
    public enum Hair
    {
     Brown,
     Blonde,
     Gray,
     Black,
     Red,
     Bald   
    }
    public enum EyeColor
    {
     Gray,
     Brown,
     Blue,
     Green,
     Albino
    }
    public class Actor
    {
        public Actor()
        {
            Movies=new HashSet<Movie>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Height { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public Sex Sex { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public Hair Hair{ get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public EyeColor EyeColor { get; set; }
        public ICollection<Movie> Movies { get; set; }
    }
}
