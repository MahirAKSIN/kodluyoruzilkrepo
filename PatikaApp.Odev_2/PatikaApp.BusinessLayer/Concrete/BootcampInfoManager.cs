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

        public async Task CreateAsync(BootcampInfo entity)
        {
            await _bootcampInfo.CreateAsync(entity);
        }

        public async Task DeleteAsync(BootcampInfo entity)
        {
            await _bootcampInfo.DeleteAsync(entity);
        }

        public async Task<List<BootcampInfo>> GetAll()
        {
            return await _bootcampInfo.GetAll();
        }
             

        public async Task<BootcampInfo> GetById(int id)
        {
            return await _bootcampInfo.GetById(id);
        }

        public async Task UpdateAsync(BootcampInfo entity)
        {
            await _bootcampInfo.UpdateAsync(entity);
        }
    }
}
