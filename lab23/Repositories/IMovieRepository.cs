using lab23.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab23.Repositories
{
    public interface IMovieRepository
    {
        Task Create(MovieViewModel movie);
        Task Delete(int ID);
        Task<bool> Exists(int ID);
        Task<List<MovieViewModel>> Get();
        Task<MovieViewModel> Get(int ID);
        Task Update(MovieViewModel movie);

    }
}

