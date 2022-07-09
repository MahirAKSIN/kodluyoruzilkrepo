using FinalProject.BusinessLayer.Abstarct;
using FinalProject.DataLayer.Abstract;
using FinalProject.DataLayer.ContextDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BusinessLayer.Concrete
{
    public class MoviesManager : IMoviesService
    {
        IMoviesRepository _moviesRepository;

        public MoviesManager(IMoviesRepository moviesRepository)
        {
            _moviesRepository = moviesRepository;
        }

        public Task AddMoviesAsync(Mytable entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteMovieAsync(Mytable entity)
        {
            throw new NotImplementedException();
        }

        public Task<Mytable> GetMovieDetail(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Mytable>> GetMovieList(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Mytable>> Search(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateMovieAsync(Mytable entity)
        {
            throw new NotImplementedException();
        }
    }
}
