using FinalProject.DataLayer.ContextDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BusinessLayer.Abstarct
{
    public interface IGenresService
    {
        //Sunum katmanından gelen bilgileri gerekli koşullara göre işleyerek veya denetleyerek
        //veri katmanının sağladığı metotları kullanarak veritabanına gönderen aynı şekilde veritabanından da bilgileri alarak gerekli
        //süreçlerden geçirip presentation katmanına gönderen katman.

        //---------------------
        //Mahir AKSIN-09072022
        //---------------------


        Task<Mytable> GetByIdGenre(int id);
        Task<List<Mytable>> GetAll();
        Task AddGenreAsync(Mytable entity);
        Task UpdateGenreAsync(Mytable entity);
        Task DeleteGenreAsync(Mytable entity);
        Task<List<Mytable>> ListGenres();
    }
}
