using PatikaApp.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaApp.BusinessLayer.Abstract
{
   public  interface IBootcampInfoService
    {
        Task<BootcampInfo> GetById(int id);
        Task<List<BootcampInfo>> GetAll();
        Task CreateAsync(BootcampInfo entity);
        Task UpdateAsync(BootcampInfo entity);
        Task DeleteAsync(BootcampInfo entity);
        Task<List<BootcampInfo>> GetAllWithDetails();


    }
}
