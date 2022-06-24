using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaApp.DataLayer.Abstract
{


    //database crud işlemleri ve ekstra methodların olusturuşduğu Interface
    //ilişkilerin başladığı class
    //Genericrepository De bu boş  methodların imzası atılacaktır
   public interface IRepository<T>
    {
        Task<T> GetById(int id);
        Task<List<T>> GetAll();
        Task CreateAsync(T entity);

        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}
