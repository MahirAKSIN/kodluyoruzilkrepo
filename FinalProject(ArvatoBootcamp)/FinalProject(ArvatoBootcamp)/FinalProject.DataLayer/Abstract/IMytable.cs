using FinalProject.DataLayer.ContextDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DataLayer.Abstract
{
    public interface IMytable:IRepository<Mytable>
    {
        /// <summary>
        /// Bu interfacede  IMytable özel methodlar yazılabilir.
        /// Diğer methodlar solid kurallarını göz önüne alarak IRepository imzasız bir şekilde yazıldı.
        /// Imzasız methodlar IGenericRepositoryde imzalanacaktır
        /// </summary>
    }
}
