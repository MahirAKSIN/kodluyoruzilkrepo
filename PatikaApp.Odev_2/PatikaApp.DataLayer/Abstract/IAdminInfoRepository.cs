using PatikaApp.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaApp.DataLayer.Abstract
{
   public interface IAdminInfoRepository:IRepository<AdminInfo>
    {
        Task<List<AdminInfo>> GetAllWithDetails();

    }
}
