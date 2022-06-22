using PatikaApp.DataLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace PatikaApp.DataLayer.Concrete.Ef
{
    public class EfCoreGenericRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        public async Task CreateAsync(TEntity entity)
        {
            using (var c = new PatikaContext())
            {
                await c.Set<TEntity>().AddAsync(entity);
                await c.SaveChangesAsync();

            }

        }

        public async Task DeleteAsync(TEntity entity)
        {
            using (var c = new PatikaContext())
            {
                c.Set<TEntity>().Remove(entity);
                await c.SaveChangesAsync();
            }
        }

        public async Task<List<TEntity>> GetAll()
        {
            using (var c = new PatikaContext())
            {
                return await c.Set<TEntity>().ToListAsync();

            }
        }

        public async Task<TEntity> GetById(int id)
        {
            using (var c = new PatikaContext())
            {
                return await c.Set<TEntity>().FindAsync(id);

            }
        }

        public async Task UpdateAsync(TEntity entity)
        {
            using (var c = new PatikaContext())
            {
                c.Set<TEntity>().Update(entity);
                await c.SaveChangesAsync();
            }
        }
    }
}
