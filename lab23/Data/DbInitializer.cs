using lab23.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab23.Data
{
    public class DbInitializer
    {
        public static void Initialize(MovieDbContext context)
        {
            context.Database.EnsureCreated();


            context.Movies.AddRange(new[]
            {
                new MovieViewModel
                {
                    Title = "Separation",
                    Genre = "Horror",
                    Runtime = 107
                },
                new MovieViewModel
                {
                    Title = "Mortal Kombat",
                    Genre = "Action",
                    Runtime = 110
                },
                new MovieViewModel
                {
                    Title = "Demon Slayer",
                    Genre = "Action",
                    Runtime = 117
                },
                new MovieViewModel
                {
                    Title = "Godzilla vs Kong",
                    Genre = "Action",
                    Runtime = 113
                },
                new MovieViewModel
                {
                    Title = "Nobody",
                    Genre = "Action",
                    Runtime = 92
                },
                new MovieViewModel
                {
                    Title = "Raya and the Last Dragon",
                    Genre = "Action",
                    Runtime = 114
                },
                new MovieViewModel
                {
                    Title = "Bloodshot",
                    Genre = "Action",
                    Runtime = 109
                },
                new MovieViewModel
                {
                    Title = "Trolls World Tour",
                    Genre = "Animated",
                    Runtime = 94
                },
                new MovieViewModel
                {
                    Title = "The Call of the Wild",
                    Genre = "Adventure",
                    Runtime = 100
                }

            });
            context.SaveChanges();
            if (context.Movies.Any())
            {
                return;
            };
            
        }
    }
}
