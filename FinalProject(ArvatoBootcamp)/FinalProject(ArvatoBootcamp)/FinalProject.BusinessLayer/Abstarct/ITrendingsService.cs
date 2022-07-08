using FinalProject.DataLayer.ContextDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BusinessLayer.Abstarct
{
    public interface ITrendingsService
    {
        //ListMostViewedMovies  -------  ListTopRatedMovies

        Task<Mytable> ListMostViewedMovies(int voteCount);
        Task<Mytable> ListTopRatedMovies(int voteAverage);



    }
}
