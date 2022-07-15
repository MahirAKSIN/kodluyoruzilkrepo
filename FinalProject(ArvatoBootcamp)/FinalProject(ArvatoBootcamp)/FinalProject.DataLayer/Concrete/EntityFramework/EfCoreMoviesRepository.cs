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


    //EfCoreMoviesRepository class EfCoreREpository tarafından imzası atılan methodları implement edildi
    //Eğer IRepository ve GenericRepositoryde olmayan özel methodlar varsa EfCoreMoviesRepository Interface yazıldığı için 
    //onuda implement ettik
    public class EfCoreMoviesRepository : EfCoreGenericRepository<Mytable>, IMoviesRepository
    {
        public async Task<List<Mytable>> GetMovieById()
        {
            using (var c = new MoviesInfoContext())
            {
                var d = await c.Mytables.ToListAsync();
                return d;
            }
        }
        public async Task<List<Mytable>> GetMovieList(long id)
        {
            {
                using (var c = new MoviesInfoContext())
                {
                    var movieList = await c.Mytables.Include(x => x.Genres).Where(i => i.Id == id).ToListAsync();
                    return movieList;
                }
            }
        }
        public async Task<List<Mytable>> GetMovieListDate(long id)
        {
            using (var c = new MoviesInfoContext())
            {
                var movieList = await c.Mytables.Include(x => x.ReleaseDate).Where(i => i.Id == id).ToListAsync();
                return movieList;
            }
        }
        public async Task<List<Mytable>> GetMovieListRate(long id)
        {
            using (var c = new MoviesInfoContext())
            {
                var movieList = await c.Mytables.Include(x => x.VoteAverage).Where(i => i.Id == id).ToListAsync();
                return movieList;
            }
        }
        public async Task<List<Mytable>> Search(string title)
        {
            using (var c = new MoviesInfoContext())
            {
                var moviesSearch = await c.Mytables.Include(x => x.Title).Where(i => i.ReleaseDate == title).ToListAsync();
                return moviesSearch;
            }
        }
    }
}
