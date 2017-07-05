using System.Data.Entity;
using MovieWebApp.Data.Models.Entities;

namespace MovieWebApp.Data.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext() : base("MovieDatabase")
        {
            Database.SetInitializer(new MovieModelDbInitialization());
        }

        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<MovieList> MovieLists { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Actor> Actors { get; set; }
        public virtual DbSet<Director> Directors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>()
                .HasRequired(x => x.Genre)
                .WithMany(x => x.Movies)
                .HasForeignKey(x => x.GenreId);
            modelBuilder.Entity<Movie>()
                .HasRequired(x => x.Director)
                .WithMany(x => x.Movies)
                .HasForeignKey(x => x.DirectorId);
            base.OnModelCreating(modelBuilder);
        }
    }
}
