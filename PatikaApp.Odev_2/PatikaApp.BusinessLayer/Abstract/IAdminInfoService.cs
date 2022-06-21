using PatikaApp.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaApp.BusinessLayer.Abstract
{
   public interface IAdminInfoService
    {
        Task<AdminInfo> GetById(int id);
        Task<List<AdminInfo>> GetAll();
        Task CreateAsync(AdminInfo entity);
        Task UpdateAsync(AdminInfo entity);
        Task DeleteAsync(AdminInfo entity);
        Task<List<AdminInfo>> GetAllWithDetails();
    }
}
