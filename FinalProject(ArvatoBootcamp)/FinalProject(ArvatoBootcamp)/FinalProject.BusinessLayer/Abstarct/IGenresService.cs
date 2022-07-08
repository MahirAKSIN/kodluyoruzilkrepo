using FinalProject.DataLayer.ContextDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BusinessLayer.Abstarct
{
    public interface IGenresService
    {
        Task<Mytable> GetByIdGenre(int id);
        Task<List<Mytable>> GetAll();
        Task AddGenreAsync(Mytable entity);
        Task UpdateGenreAsync(Mytable entity);
        Task DeleteGenreAsync(Mytable entity);
        Task<List<Mytable>> ListGenres();
    }
}
