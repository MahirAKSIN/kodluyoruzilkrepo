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
    public class EfCoreGenresRepository : EfCoreGenericRepository<Mytable>, IGenresRepository
    {
    //    public Task<List<Mytable>> GetAllWithDetails()
    //    {
    //        using (var c = new MoviesInfoContext())
    //        {
    //          return await c.Mytables.ToArrayAsync();
                
    //        }
       // }
    }
}
