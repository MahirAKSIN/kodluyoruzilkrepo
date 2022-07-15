using FinalProject.DataLayer.ContextDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DataLayer.Abstract
{
    public interface IGenresRepository:IRepository<Mytable>
    {
        /// <summary>
        /// Bu interfacede  IGenresRepository özel methodlar yazılabilir.
        /// Diğer methodlar solid kurallarını göz önüne alarak IRepository imzasız bir şekilde yazıldı.
        /// Imzasız methodlar IGenericRepositoryde imzalanacaktır
        /// </summary>

        //Task<List<Mytable>> GetAllWithDetails();
    }
}
