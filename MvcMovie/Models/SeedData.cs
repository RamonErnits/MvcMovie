using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (!context.Movie.Any())
                {
                    AddMovies(context);  // DB has been seeded
                }

                if (!context.Actors.Any())
                {
                    AddActors(context);  // DB has been seeded
                }


                context.SaveChanges();
            }
        }



        private static void AddActors(MvcMovieContext context)
        {
            context.Actors.AddRange(
                new Actors
                {
                    FirstName = "Peeter",
                    LastName = "Oja",
                    Birth = DateTime.Parse("1960-7-2"),
                    Gender= "Male",
                    HomeTown="Ardu"
                },
                new Actors
                {
                    FirstName="Mina",
                    LastName="Sina",
                    Birth = DateTime.Parse("1994-10-10"),
                    Gender = "Male",
                    HomeTown="Kose"

                }
            );
         

            
        }
        private static void AddMovies(MvcMovieContext context)
        {
            context.Movie.AddRange(
                new Movie
                {
                    Title = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Romantic Comedy",
                    Rating = "R",
                    Price = 7.99M
                },

                new Movie
                {
                    Title = "Ghostbusters ",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "Comedy",
                    Rating = "R",
                    Price = 8.99M
                },

                new Movie
                {
                    Title = "Ghostbusters 2",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Genre = "Comedy",
                    Rating = "R",
                    Price = 9.99M
                },

                new Movie
                {
                    Title = "Rio Bravo",
                    ReleaseDate = DateTime.Parse("1959-4-15"),
                    Genre = "Western",
                    Rating = "R",
                    Price = 3.99M
                }
            );
        }
    }
}