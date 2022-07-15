using FinalProject.DataLayer.ContextDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DataLayer.Abstract
{
    public interface ITrendingsRepository:IRepository<Mytable>
    {
        /// <summary>
        /// Bu interfacede  ITrendingsRepository özel methodlar yazılabilir.
        /// Diğer methodlar solid kurallarını göz önüne alarak IRepository imzasız bir şekilde yazıldı.
        /// Imzasız methodlar IGenericRepositoryde imzalanacaktır
        /// </summary>

        Task<List<Mytable>> ListMostViewedMovies(int voteCount);
        Task<List<Mytable>> ListTopRatedMovies(int voteAverage);
        



        }
}
