using FinalProject.DataLayer.ContextDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BusinessLayer.Abstarct
{
    public interface IMoviesService
    {
        Task<Mytable> GetMovieById(int id);//id'ye göre movie detaylandırolacak
        Task<List<Mytable>> GetMovieList(int id);//include ile genre joinle 
        Task<List<Mytable>> Search(string title);//Id'den sıralama çekilecek
        Task AddMoviesAsync(Mytable entity);//Movie ekleme methodu(imzasız)
        Task UpdateMovieAsync(Mytable entity);//Movie Guncelleme methodu(imzasız)
        Task DeleteMovieAsync(Mytable entity);//Movie silme methodu(imzasız)


    }
}
