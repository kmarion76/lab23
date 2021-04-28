using lab23.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace lab23.Data
{
    public class MovieDbContext: DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options)
            :base(options)
        {

        }
        public DbSet<MovieViewModel> Movies { get; set; }
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<MovieViewModel>().Property(x => x.Title).HasMaxLength(50);
            modelbuilder.Entity<MovieViewModel>().Property(x => x.Genre).HasMaxLength(20);
        }
       
    }
}
