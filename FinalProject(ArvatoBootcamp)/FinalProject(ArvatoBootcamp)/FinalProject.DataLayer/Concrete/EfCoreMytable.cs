using FinalProject.DataLayer.Abstract;
using FinalProject.DataLayer.Concrete.EntityFramework;
using FinalProject.DataLayer.ContextDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DataLayer.Concrete
{
    public class EfCoreMytable:EfCoreGenericRepository<Mytable>,IMytable
    {
    }
}
