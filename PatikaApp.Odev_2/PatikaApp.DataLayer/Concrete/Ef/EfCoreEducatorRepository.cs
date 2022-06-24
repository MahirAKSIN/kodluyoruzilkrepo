using PatikaApp.DataLayer.Abstract;
using PatikaApp.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaApp.DataLayer.Concrete.Ef
{
   public class EfCoreEducatorRepository : EfCoreGenericRepository<EducatorInfo>, IEducatorInfoRepository
    {
        //EfCoreEducatorRepository class EfCoreREpository tarafından imzası atılan methodları implement edildi
        //Eğer Irepository ve GenericRepositoryde olmayan özel methodlar varsa IEducatorInfoRepository Interface yazıldığı için 
        //onuda implement ettik.Burda IEducatorInfoRepository özekl bir method olmadığı için boş implement etti

    }
}
