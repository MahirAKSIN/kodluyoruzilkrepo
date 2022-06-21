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
    public class BootcampInfoManager : IBootcampInfoService
    {
        IBootcampInfoRepository _bootcampInfo;

        public BootcampInfoManager(IBootcampInfoRepository bootcampInfo)
        {
            _bootcampInfo = bootcampInfo;
        }

        public Task CreateAsync(BootcampInfo entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(BootcampInfo entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<BootcampInfo>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<List<BootcampInfo>> GetAllWithDetails()
        {
            throw new NotImplementedException();
        }

        public Task<BootcampInfo> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(BootcampInfo entity)
        {
            throw new NotImplementedException();
        }
    }
}
