using FinalProject.DataLayer.ContextDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BusinessLayer.Abstarct
{
    public interface ITrendingsService
    {

        //Sunum katmanından gelen bilgileri gerekli koşullara göre işleyerek veya denetleyerek
        //veri katmanının sağladığı metotları kullanarak veritabanına gönderen aynı şekilde veritabanından da bilgileri alarak gerekli
        //süreçlerden geçirip presentation katmanına gönderen katman

        //ListMostViewedMovies  -------  ListTopRatedMovies

        Task<Mytable> ListMostViewedMovies(int voteCount);
        Task<Mytable> ListTopRatedMovies(int voteAverage);



    }
}
   