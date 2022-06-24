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


        //Sunum katmanından gelen bilgileri gerekli koşullara göre işleyerek veya denetleyerek
        //veri katmanının sağladığı metotları kullanarak veritabanına gönderen aynı şekilde veritabanından da bilgileri alarak gerekli
        //süreçlerden geçirip presentation katmanına gönderen katman.
        //Mahir AKSIN
        Task<AdminInfo> GetById(int id);
        Task<List<AdminInfo>> GetAll();
        Task CreateAsync(AdminInfo entity);
        Task UpdateAsync(AdminInfo entity);
        Task DeleteAsync(AdminInfo entity);
        Task<List<AdminInfo>> GetAllWithDetails();
    }
}
