using FinalProject.BusinessLayer.Abstarct;
using FinalProject.DataLayer.ContextDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BusinessLayer.Concrete
{
    public class MytableManager : IMytableService
    {

        /// <summary>
        /// Bu classta IMytableService'i implement yaparak imzasız olana 
        /// methodları içine linq sorguları ile imzalanır. 
        /// 
        /// </summary>
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

        public Task<List<Mytable>> GetAllWithDetails()
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
