using PatikaApp.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaApp.BusinessLayer.Abstract
{

    //Sunum katmanından gelen bilgileri gerekli koşullara göre işleyerek veya denetleyerek
    //veri katmanının sağladığı metotları kullanarak veritabanına gönderen aynı şekilde veritabanından da bilgileri alarak gerekli
    //süreçlerden geçirip presentation katmanına gönderen katman
    public interface IBootcampInfoService
    {
        Task<BootcampInfo> GetById(int id);
        Task<List<BootcampInfo>> GetAll();
        Task CreateAsync(BootcampInfo entity);
        Task UpdateAsync(BootcampInfo entity);
        Task DeleteAsync(BootcampInfo entity);


    }
}
