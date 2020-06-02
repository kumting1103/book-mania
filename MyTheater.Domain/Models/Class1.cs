using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyTheater.Domain.Models
{
    public interface IMovieRepository
    {
        Task AddAsync(Movie movie);

        Task<Movie> FindAsync(int movieId);
    }
}
