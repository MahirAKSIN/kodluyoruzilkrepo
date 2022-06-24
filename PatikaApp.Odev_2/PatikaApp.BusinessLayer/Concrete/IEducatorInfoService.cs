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

        //Sunum katmanından gelen bilgileri gerekli koşullara göre işleyerek veya denetleyerek
        //veri katmanının sağladığı metotları kullanarak veritabanına gönderen aynı şekilde veritabanından da bilgileri alarak gerekli
        //süreçlerden geçirip presentation katmanına gönderen katman
        Task<EducatorInfo> GetById(int id);
        Task<List<EducatorInfo>> GetAll();
        Task CreateAsync(EducatorInfo entity);
        Task UpdateAsync(EducatorInfo entity);
        Task DeleteAsync(EducatorInfo entity);
    }
}
