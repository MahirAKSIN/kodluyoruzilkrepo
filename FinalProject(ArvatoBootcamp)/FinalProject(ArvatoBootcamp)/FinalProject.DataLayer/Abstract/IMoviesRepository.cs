using FinalProject.DataLayer.ContextDb;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DataLayer.Abstract
{
    public interface IMoviesRepository : IRepository<Mytable>
    {
        Task<List<Mytable>> GetMovieById();
        Task<List<Mytable>> GetMovieList(long id);
        Task<List<Mytable>> GetMovieListRate(long id);
        Task<List<Mytable>> GetMovieListDate(long id);
        Task<List<Mytable>> Search(string title);


    }
}
