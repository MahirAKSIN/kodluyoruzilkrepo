using PatikaApp.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaApp.BusinessLayer.Abstract
{
    public interface IEducatorInfoService
    {
        Task<EducatorInfo> GetById(int id);
        Task<List<EducatorInfo>> GetAll();
        Task CreateAsync(EducatorInfo entity);
        Task UpdateAsync(EducatorInfo entity);
        Task DeleteAsync(EducatorInfo entity);
    }
}
