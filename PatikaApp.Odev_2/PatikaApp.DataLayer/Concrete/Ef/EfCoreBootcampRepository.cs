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
        //EfCoreBootcampRepository class EfCoreREpository tarafından imzası atılan methodları implement edildi
        //Eğer Irepository ve GenericRepositoryde olmayan özel methodlar varsa IBootcampInfoRepository Interface yazıldığı için 
        //onuda implement ettik.Burda IBootcampInfoRepository özekl bir method olmadığı için boş implement etti
    }
}
