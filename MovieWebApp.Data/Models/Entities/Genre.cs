﻿using System.Collections.Generic;

namespace MovieWebApp.Data.Models.Entities
{
    public class Genre
    {
        public Genre()
        {
            Movies=new HashSet<Movie>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Movie> Movies { get; set; }
    }
}
