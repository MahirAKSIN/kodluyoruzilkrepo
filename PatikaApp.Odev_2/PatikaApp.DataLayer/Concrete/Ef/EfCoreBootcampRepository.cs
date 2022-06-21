using PatikaApp.DataLayer.Abstract;
using PatikaApp.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaApp.DataLayer.Concrete.Ef
{
   public class EfCoreBootcampRepository : EfCoreGenericRepository<BootcampInfo>, IBootcampInfoRepository
    {
    }
}
