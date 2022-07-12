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

        public async Task AddMoviesAsync(Mytable entity)
        {
            await _moviesRepository.CreateAsync(entity);
        }

        public async Task DeleteMovieAsync(Mytable entity)
        {

            await _moviesRepository.DeleteAsync(entity);
        }

        public async Task<Mytable> GetMovieById(int id)
        {
            return await _moviesRepository.GetById(id);

        }

        public Task<List<Mytable>> GetMovieList(long id)
        {
            var moviesList = _moviesRepository.GetMovieList(id);
            return moviesList;

        }

        public Task<List<Mytable>> GetMovieList(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Mytable>> Search(string title)
        {
            var search = _moviesRepository.Search(title);
            return search;
        }

        public async Task UpdateMovieAsync( Mytable entity)
        {
            await _moviesRepository.UpdateAsync(entity);
        }
    }
}
