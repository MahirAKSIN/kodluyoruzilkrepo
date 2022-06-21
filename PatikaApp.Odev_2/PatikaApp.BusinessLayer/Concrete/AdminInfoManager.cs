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
    public class AdminInfoManager : IAdminInfoService
    {
        IAdminInfoRepository _adminInfoRepository;

        public AdminInfoManager(IAdminInfoRepository adminInfoRepository)
        {
            _adminInfoRepository = adminInfoRepository;
        }

        public async Task CreateAsync(AdminInfo entity)
        {
            await _adminInfoRepository.CreateAsync(entity);
        }

        public async Task DeleteAsync(AdminInfo entity)
        {
            await _adminInfoRepository.DeleteAsync(entity);
        }

        public async Task<List<AdminInfo>> GetAll()
        {
            return await _adminInfoRepository.GetAll();
        }

        public async Task<List<AdminInfo>> GetAllWithDetails()
        {
            return await _adminInfoRepository.GetAllWithDetails();
        }

        public async Task<AdminInfo> GetById(int id)
        {
            return await _adminInfoRepository.GetById(id);
        }

        public async Task UpdateAsync(AdminInfo entity)
        {
            await _adminInfoRepository.UpdateAsync(entity);
        }
    }
}
