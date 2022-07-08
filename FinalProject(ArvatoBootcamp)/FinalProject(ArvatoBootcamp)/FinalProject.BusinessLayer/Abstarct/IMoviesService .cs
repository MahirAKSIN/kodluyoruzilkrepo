using FinalProject.DataLayer.ContextDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BusinessLayer.Abstarct
{
    public interface IMoviesService
    {
        Task<Mytable> GetMovieDetail(int id);
        Task<List<Mytable>> GetMovieList(int id);
        Task<List<Mytable>> Search(int id);
        Task AddMoviesAsync(Mytable entity);
        Task UpdateMovieAsync(Mytable entity);
        Task DeleteMovieAsync(Mytable entity);


    }
}
