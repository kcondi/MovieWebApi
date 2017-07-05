using System;
using System.Collections.Generic;

namespace MovieWebApp.Data.Models.Entities
{
    public enum Sex
    {
        Male,
        Female
    }
    public enum HairColor
    {
     Brunette,
     Blonde,
     Gray,
     White,
     Black,
     Red   
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
        public int Weight { get; set; }
        public Sex Sex { get; set; }
        public HairColor HairColor { get; set; }
        public EyeColor EyeColor { get; set; }
        public ICollection<Movie> Movies { get; set; }
    }
}
