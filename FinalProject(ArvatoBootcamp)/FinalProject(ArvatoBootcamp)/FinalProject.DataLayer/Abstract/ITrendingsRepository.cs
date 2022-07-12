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

        Task<List<Mytable>> ListMostViewedMovies(int voteCount);
        Task<List<Mytable>> ListTopRatedMovies(int voteAverage);
        



        }
}
