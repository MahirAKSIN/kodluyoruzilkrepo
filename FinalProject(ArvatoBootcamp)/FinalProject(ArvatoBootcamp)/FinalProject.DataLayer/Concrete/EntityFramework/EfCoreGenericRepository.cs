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
    public class EfCoreGenericRepository<TEntity> : IRepository<TEntity> where TEntity : class

    {
        public async Task CreateAsync(TEntity entity)
        {
            using (var c=new MoviesInfoContext())
            {
                await c.Set<TEntity>().AddAsync(entity);
                await c.SaveChangesAsync();
            }

        }

        public async Task DeleteAsync(TEntity entity)
        {
            using (var c = new MoviesInfoContext())
            {
                 c.Set<TEntity>().Remove(entity);
                await c.SaveChangesAsync();
            }
        }

        public async Task<List<TEntity>> GetAll()
        {
            using (var c =new MoviesInfoContext())
            {
                return await c.Set<TEntity>().ToListAsync();
            }
        }

        public async Task<TEntity> GetById(int id)
        {
            using (var c = new MoviesInfoContext())
            {
                return await c.Set<TEntity>().FindAsync(id);
            }
        }

        public async Task UpdateAsync(TEntity entity)
        {
            using (var c = new MoviesInfoContext())
            {
                  c.Set<TEntity>().Update(entity);
                await c.SaveChangesAsync();
            }
        }
    }
}
