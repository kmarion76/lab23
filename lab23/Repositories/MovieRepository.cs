using lab23.Data;
using lab23.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab23.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly MovieDbContext _context; 
        public MovieRepository(MovieDbContext context)
        {
            _context = context;
        }
        public async Task Create(MovieViewModel movie)
        {
            _context.Movies.Add(movie);
            await _context.SaveChangesAsync();
        }

        public Task Delete(int ID)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Exists(int ID)
        {
            throw new NotImplementedException();
        }

        public async Task<List<MovieViewModel>> Get()
        {
            return await _context.Movies.ToListAsync();

        }

        public async Task<MovieViewModel> Get(int ID)
        {
            return await _context.Movies.FindAsync(ID);
        }

        public Task Update(MovieViewModel movie)
        {
            throw new NotImplementedException();
        }
        

    }
}
