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
        /// <summary>
        /// Bu interfacede  IMoviesRepository özel methodlar yazılabilir.
        /// Diğer methodlar solid kurallarını göz önüne alarak IRepository imzasız bir şekilde yazıldı.
        /// Imzasız methodlar IGenericRepositoryde imzalanacaktır
        /// </summary>
        Task<List<Mytable>> GetMovieById();
        Task<List<Mytable>> GetMovieList(long id);
        Task<List<Mytable>> GetMovieListRate(long id);
        Task<List<Mytable>> GetMovieListDate(long id);
        Task<List<Mytable>> Search(string title);


    }
}
