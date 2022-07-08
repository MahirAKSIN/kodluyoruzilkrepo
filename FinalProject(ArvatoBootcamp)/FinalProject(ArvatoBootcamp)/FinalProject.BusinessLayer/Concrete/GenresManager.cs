using FinalProject.DataLayer.Abstract;
using FinalProject.DataLayer.ContextDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BusinessLayer.Concrete
{
    internal class GenresManager : IGenresRepository
    {
        public Task CreateAsync(Mytable entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Mytable entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<Mytable>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Mytable> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Mytable entity)
        {
            throw new NotImplementedException();
        }
    }
}
