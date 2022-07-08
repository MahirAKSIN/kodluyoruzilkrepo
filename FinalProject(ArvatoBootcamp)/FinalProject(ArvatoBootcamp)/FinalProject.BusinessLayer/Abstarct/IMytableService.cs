using FinalProject.DataLayer.ContextDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BusinessLayer.Abstarct
{
    public interface IMytableService
    {
        Task<Mytable> GetById(int id);
        Task<List<Mytable>> GetAll();
        Task CreateAsync(Mytable entity);
        Task UpdateAsync(Mytable entity);
        Task DeleteAsync(Mytable entity);
        Task<List<Mytable>> GetAllWithDetails();
    }
}
