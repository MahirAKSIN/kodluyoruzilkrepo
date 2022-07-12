using FinalProject.DataLayer.Abstract;
using FinalProject.DataLayer.ContextDb;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DataLayer.Concrete.EntityFramework
{
    public class EfCoreTrendingsRepository : EfCoreGenericRepository<Mytable>, ITrendingsRepository
    {
        
        public Task<List<Mytable>> ListMostViewedMovies(int voteCount)
        {
            using (var c = new MoviesInfoContext())
            {
                var TrendingsVieweList =  c.Mytables.Include(x => x.VoteAverage).Where(i => i.Id == voteCount).ToListAsync();
                return TrendingsVieweList;
            }
        }

        public Task<List<Mytable>> ListTopRatedMovies(int voteAverage)
        {
            using (var c = new MoviesInfoContext())
            {
                var TrendingsRateList = c.Mytables.Include(x => x.VoteAverage).Where(i => i.Id == voteAverage).ToListAsync();
                return TrendingsRateList;
            }
        }
    }
}
