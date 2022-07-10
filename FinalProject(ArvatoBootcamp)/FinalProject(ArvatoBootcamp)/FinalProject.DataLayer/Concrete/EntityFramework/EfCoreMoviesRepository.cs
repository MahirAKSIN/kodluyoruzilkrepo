using FinalProject.DataLayer.Abstract;
using FinalProject.DataLayer.ContextDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DataLayer.Concrete.EntityFramework
{
    public class EfCoreMoviesRepository : EfCoreGenericRepository<Mytable>, IMoviesRepository
    {
    }

}
