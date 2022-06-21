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

        public Task CreateAsync(EducatorInfo entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(EducatorInfo entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<EducatorInfo>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<List<EducatorInfo>> GetAllWithDetails()
        {
            throw new NotImplementedException();
        }

        public Task<EducatorInfo> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(EducatorInfo entity)
        {
            throw new NotImplementedException();
        }
    }
}
