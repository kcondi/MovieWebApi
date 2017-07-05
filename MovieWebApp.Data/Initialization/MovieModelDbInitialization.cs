using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieWebApp.Data.Models;
using MovieWebApp.Data.Models.Entities;

namespace MovieWebApp.Data.Initialization
{
    public class MovieModelDbInitialization : CreateDatabaseIfNotExists<MovieContext>
    {
        protected override void Seed(MovieContext context)
        {
            #region Genres
            var genres=new List<Genre>()
            {
                new Genre() {Name="Action"},
                new Genre() {Name="Adventure"},
                new Genre() {Name="Animated"},
                new Genre() {Name="Fantasy"},
                new Genre() {Name="Horror"},
                new Genre() {Name="Science fiction"},
                new Genre() {Name="Thriller"},
                new Genre() {Name="Western"},
                new Genre() {Name="Comedy"},
                new Genre() {Name="Romantic comedy"},
                new Genre() {Name="Documentary"},
                new Genre() {Name="Educational"},
                new Genre() {Name="Sports"},
                new Genre() {Name="Romance"},
                new Genre() {Name="Historical"},
                new Genre() {Name="Biography"},
                new Genre() {Name="Crime"}
            };
            #endregion
            #region Actors
            var actors = new List<Actor>()
            {
                new Actor()
                {
                    Name = "Jack Nicholson",
                    Sex = Sex.Male,
                    DateOfBirth = new DateTime(1937, 4, 22),
                    Height = 177,
                    Hair = Hair.Black,
                    EyeColor = EyeColor.Brown
                },
                new Actor()
                {
                    Name = "Robert De Niro",
                    Sex = Sex.Male,
                    DateOfBirth = new DateTime(1943, 8, 17),
                    Height = 178,
                    Hair = Hair.Gray,
                    EyeColor = EyeColor.Brown
                },
                new Actor()
                {
                    Name = "Tom Hanks",
                    Sex = Sex.Male,
                    DateOfBirth = new DateTime(1956, 7, 9),
                    Height = 185,
                    Hair = Hair.Brown,
                    EyeColor = EyeColor.Blue
                },
                new Actor()
                {
                    Name = "Brad Pitt",
                    Sex = Sex.Male,
                    DateOfBirth = new DateTime(1963, 12, 18),
                    Height = 180,
                    Hair = Hair.Blonde,
                    EyeColor = EyeColor.Blue
                },
                new Actor()
                {
                    Name = "Anthony Hopkins",
                    Sex = Sex.Male,
                    DateOfBirth = new DateTime(1937, 12, 31),
                    Height = 174,
                    Hair = Hair.Gray,
                    EyeColor = EyeColor.Blue
                },
                new Actor()
                {
                    Name = "Clint Eastwood",
                    Sex = Sex.Male,
                    DateOfBirth = new DateTime(1930, 5, 31),
                    Height = 193,
                    Hair = Hair.Brown,
                    EyeColor = EyeColor.Gray
                },
                new Actor()
                {
                    Name = "Leonardo DiCaprio",
                    Sex = Sex.Male,
                    DateOfBirth = new DateTime(1974, 11, 11),
                    Height = 178,
                    Hair = Hair.Blonde,
                    EyeColor = EyeColor.Blue
                },
                new Actor()
                {
                    Name = "Samuel L. Jackson",
                    Sex = Sex.Male,
                    DateOfBirth = new DateTime(1948, 12, 21),
                    Height = 189,
                    Hair = Hair.Bald,
                    EyeColor = EyeColor.Brown
                },
                new Actor()
                {
                    Name = "Morgan Freeman",
                    Sex = Sex.Male,
                    DateOfBirth = new DateTime(1937, 6, 1),
                    Height = 188,
                    Hair = Hair.Gray,
                    EyeColor = EyeColor.Brown
                },
                new Actor()
                {
                    Name = "Bruce Willis",
                    Sex = Sex.Male,
                    DateOfBirth = new DateTime(1955, 3, 19),
                    Height = 182,
                    Hair = Hair.Bald,
                    EyeColor = EyeColor.Blue
                },
                new Actor()
                {
                    Name = "Tom Cruise",
                    Sex = Sex.Male,
                    DateOfBirth = new DateTime(1962, 7, 3),
                    Height = 170,
                    Hair = Hair.Brown,
                    EyeColor = EyeColor.Brown
                },
                new Actor()
                {
                    Name = "George Clooney",
                    Sex = Sex.Male,
                    DateOfBirth = new DateTime(1937, 4, 22),
                    Height = 180,
                    Hair = Hair.Brown,
                    EyeColor = EyeColor.Brown
                },
                new Actor()
                {
                    Name = "Sean Connery",
                    Sex = Sex.Male,
                    DateOfBirth = new DateTime(1930, 8, 25),
                    Height = 189,
                    Hair = Hair.Black,
                    EyeColor = EyeColor.Brown
                },
                new Actor()
                {
                    Name = "Richard Gere",
                    Sex = Sex.Male,
                    DateOfBirth = new DateTime(1949, 8, 31),
                    Height = 178,
                    Hair = Hair.Gray,
                    EyeColor = EyeColor.Brown
                },
                new Actor()
                {
                    Name = "Matt Damon",
                    Sex = Sex.Male,
                    DateOfBirth = new DateTime(1970, 10, 8),
                    Height = 178,
                    Hair = Hair.Brown,
                    EyeColor = EyeColor.Blue
                },
                new Actor()
                {
                    Name = "Forest Whitaker",
                    Sex = Sex.Male,
                    DateOfBirth = new DateTime(1961, 7, 15),
                    Height = 188,
                    Hair = Hair.Black,
                    EyeColor = EyeColor.Brown
                },
                new Actor()
                {
                    Name = "Liam Neeson",
                    Sex = Sex.Male,
                    DateOfBirth = new DateTime(1952, 6, 7),
                    Height = 193,
                    Hair = Hair.Brown,
                    EyeColor = EyeColor.Blue
                },
                new Actor()
                {
                    Name = "Will Smith",
                    Sex = Sex.Male,
                    DateOfBirth = new DateTime(1968, 9, 25),
                    Height = 188,
                    Hair = Hair.Black,
                    EyeColor = EyeColor.Brown
                },
                new Actor()
                {
                    Name = "John Travolta",
                    Sex = Sex.Male,
                    DateOfBirth = new DateTime(1954, 2, 18),
                    Height = 183,
                    Hair = Hair.Brown,
                    EyeColor = EyeColor.Blue
                },
                new Actor()
                {
                    Name = "Arnold Schwarzenegger",
                    Sex = Sex.Male,
                    DateOfBirth = new DateTime(1947, 7, 30),
                    Height = 188,
                    Hair = Hair.Brown,
                    EyeColor = EyeColor.Blue
                },
                new Actor()
                {
                    Name = "Arnold Schwarzenegger",
                    Sex = Sex.Female,
                    DateOfBirth = new DateTime(1947, 7, 30),
                    Height = 188,
                    Hair = Hair.Brown,
                    EyeColor = EyeColor.Blue
                },
                new Actor()
                {
                    Name = "Arnold Schwarzenegger",
                    Sex = Sex.Female,
                    DateOfBirth = new DateTime(1947, 7, 30),
                    Height = 188,
                    Hair = Hair.Brown,
                    EyeColor = EyeColor.Blue
                },
                new Actor()
                {
                    Name = "Arnold Schwarzenegger",
                    Sex = Sex.Female,
                    DateOfBirth = new DateTime(1947, 7, 30),
                    Height = 188,
                    Hair = Hair.Brown,
                    EyeColor = EyeColor.Blue
                },
                new Actor()
                {
                    Name = "Arnold Schwarzenegger",
                    Sex = Sex.Female,
                    DateOfBirth = new DateTime(1947, 7, 30),
                    Height = 188,
                    Hair = Hair.Brown,
                    EyeColor = EyeColor.Blue
                },
                new Actor()
                {
                    Name = "Arnold Schwarzenegger",
                    Sex = Sex.Female,
                    DateOfBirth = new DateTime(1947, 7, 30),
                    Height = 188,
                    Hair = Hair.Brown,
                    EyeColor = EyeColor.Blue
                },
                new Actor()
                {
                    Name = "Arnold Schwarzenegger",
                    Sex = Sex.Female,
                    DateOfBirth = new DateTime(1947, 7, 30),
                    Height = 188,
                    Hair = Hair.Brown,
                    EyeColor = EyeColor.Blue
                },
                new Actor()
                {
                    Name = "Arnold Schwarzenegger",
                    Sex = Sex.Female,
                    DateOfBirth = new DateTime(1947, 7, 30),
                    Height = 188,
                    Hair = Hair.Brown,
                    EyeColor = EyeColor.Blue
                },
                new Actor()
                {
                    Name = "Arnold Schwarzenegger",
                    Sex = Sex.Female,
                    DateOfBirth = new DateTime(1947, 7, 30),
                    Height = 188,
                    Hair = Hair.Brown,
                    EyeColor = EyeColor.Blue
                },
                new Actor()
                {
                    Name = "Arnold Schwarzenegger",
                    Sex = Sex.Female,
                    DateOfBirth = new DateTime(1947, 7, 30),
                    Height = 188,
                    Hair = Hair.Brown,
                    EyeColor = EyeColor.Blue
                },
                new Actor()
                {
                    Name = "Arnold Schwarzenegger",
                    Sex = Sex.Female,
                    DateOfBirth = new DateTime(1947, 7, 30),
                    Height = 188,
                    Hair = Hair.Brown,
                    EyeColor = EyeColor.Blue
                },
                new Actor()
                {
                    Name = "Arnold Schwarzenegger",
                    Sex = Sex.Female,
                    DateOfBirth = new DateTime(1947, 7, 30),
                    Height = 188,
                    Hair = Hair.Brown,
                    EyeColor = EyeColor.Blue
                },
                new Actor()
                {
                    Name = "Arnold Schwarzenegger",
                    Sex = Sex.Female,
                    DateOfBirth = new DateTime(1947, 7, 30),
                    Height = 188,
                    Hair = Hair.Brown,
                    EyeColor = EyeColor.Blue
                },
                new Actor()
                {
                    Name = "Arnold Schwarzenegger",
                    Sex = Sex.Female,
                    DateOfBirth = new DateTime(1947, 7, 30),
                    Height = 188,
                    Hair = Hair.Brown,
                    EyeColor = EyeColor.Blue
                },
                new Actor()
                {
                    Name = "Arnold Schwarzenegger",
                    Sex = Sex.Female,
                    DateOfBirth = new DateTime(1947, 7, 30),
                    Height = 188,
                    Hair = Hair.Brown,
                    EyeColor = EyeColor.Blue
                },
                new Actor()
                {
                    Name = "Arnold Schwarzenegger",
                    Sex = Sex.Female,
                    DateOfBirth = new DateTime(1947, 7, 30),
                    Height = 188,
                    Hair = Hair.Brown,
                    EyeColor = EyeColor.Blue
                },
                new Actor()
                {
                    Name = "Arnold Schwarzenegger",
                    Sex = Sex.Female,
                    DateOfBirth = new DateTime(1947, 7, 30),
                    Height = 188,
                    Hair = Hair.Brown,
                    EyeColor = EyeColor.Blue
                },
                new Actor()
                {
                    Name = "Arnold Schwarzenegger",
                    Sex = Sex.Female,
                    DateOfBirth = new DateTime(1947, 7, 30),
                    Height = 188,
                    Hair = Hair.Brown,
                    EyeColor = EyeColor.Blue
                },
                new Actor()
                {
                    Name = "Arnold Schwarzenegger",
                    Sex = Sex.Female,
                    DateOfBirth = new DateTime(1947, 7, 30),
                    Height = 188,
                    Hair = Hair.Brown,
                    EyeColor = EyeColor.Blue
                },
                new Actor()
                {
                    Name = "Arnold Schwarzenegger",
                    Sex = Sex.Female,
                    DateOfBirth = new DateTime(1947, 7, 30),
                    Height = 188,
                    Hair = Hair.Brown,
                    EyeColor = EyeColor.Blue
                },
                new Actor()
                {
                    Name = "Arnold Schwarzenegger",
                    Sex = Sex.Female,
                    DateOfBirth = new DateTime(1947, 7, 30),
                    Height = 188,
                    Hair = Hair.Brown,
                    EyeColor = EyeColor.Blue
                }
            };
            #endregion
            #region Directors
            var directors = new List<Director>()
            {
                new Director()
                {
                    Name = "Milos Forman",
                    DateOfBirth = new DateTime(1932, 2, 18)
                },
                new Director()
                {
                    Name = "Rob Reiner",
                    DateOfBirth = new DateTime(1947, 3, 6)
                },
                new Director()
                {
                    Name = "Steven Spielberg",
                    DateOfBirth = new DateTime(1946, 12, 18)
                },
                new Director()
                {
                    Name = "Clint Eastwood",
                    DateOfBirth = new DateTime(1930, 5, 31)
                },
                new Director()
                {
                    Name = "James Cameron",
                    DateOfBirth = new DateTime(1954, 8, 16)
                },
                new Director()
                {
                    Name = "Quentin Tarantino",
                    DateOfBirth = new DateTime(1963, 3, 27)
                },
                new Director()
                {
                    Name = "Doug Liman",
                    DateOfBirth = new DateTime(1965, 7, 24)
                },
                new Director()
                {
                    Name = "Steven Soderbergh",
                    DateOfBirth = new DateTime(1963, 1, 14)
                }
            };
            #endregion
            var movies = new List<Movie>()
            {
                new Movie()
                {
                    Title= "One Flew Over The Cuckoo's Nest",
                    Year=1975,
                    Hashtag = "wacky",
                    Genre = genres[6]
                },
                new Movie()
                {
                    Title= "Titanic",
                    Year=1997,
                    Hashtag = "sosad",
                    Genre = genres[13]
                },
                new Movie()
                {
                    Title= "The Bucket List",
                    Year=2007,
                    Hashtag = "truestory",
                    Genre = genres[1]
                },
                new Movie()
                {
                    Title= "Saving Private Ryan",
                    Year=1998,
                    Hashtag = "trynottocry",
                    Genre = genres[0]
                },
                new Movie()
                {
                    Title= "Pulp Fiction",
                    Year=1994,
                    Hashtag = "travoltathesicko",
                    Genre = genres[6]
                }
            };
            movies[0].Director = directors[0];
            movies[0].Actors.Add(actors[0]);

            movies[1].Director = directors[4];
            movies[1].Actors.Add(actors[0]);
            base.Seed(context);
        }
    }
}
