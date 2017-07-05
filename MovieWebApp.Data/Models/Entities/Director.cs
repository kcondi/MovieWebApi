using System;
using System.Collections.Generic;

namespace MovieWebApp.Data.Models.Entities
{
    public class Director
    {
        public Director()
        {
            Movies=new HashSet<Movie>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public ICollection<Movie> Movies { get; set; }
    }
}
