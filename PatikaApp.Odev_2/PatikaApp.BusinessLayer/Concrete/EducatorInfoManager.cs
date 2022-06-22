using PatikaApp.BusinessLayer.Abstract;
using PatikaApp.DataLayer.Abstract;
using PatikaApp.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaApp.BusinessLayer.Concrete
{
    public class EducatorInfoManager : IEducatorInfoService
    {

        IEducatorInfoRepository _educatorInfo;

        public EducatorInfoManager(IEducatorInfoRepository educatorInfo)
        {
            _educatorInfo = educatorInfo;
        }

        public async Task CreateAsync(EducatorInfo entity)
        {
            await _educatorInfo.CreateAsync(entity);
        }

        public async Task DeleteAsync(EducatorInfo entity)
        {
            await _educatorInfo.DeleteAsync(entity);
        }

        public async Task<List<EducatorInfo>> GetAll()
        {
            return await _educatorInfo.GetAll();
        }

        public async Task<EducatorInfo> GetById(int id)
        {
            return await _educatorInfo.GetById(id);
        }

        public async Task UpdateAsync(EducatorInfo entity)
        {
            await _educatorInfo.UpdateAsync(entity);
        }
    }
}
