using FinalProject.BusinessLayer.Abstarct;
using FinalProject.DataLayer.Abstract;
using FinalProject.DataLayer.ContextDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BusinessLayer.Concrete
{
    /// <summary>
    /// Bu classta IGenresService'i implement yaparak imzasız olana 
    /// methodları içine linq sorguları ile imzalanır. 
    /// 
    /// </summary>


    public class GenresManager : IGenresService
    {
        IGenresRepository _genresRepository;

        public GenresManager(IGenresRepository genresRepository)
        {
            _genresRepository = genresRepository;
        }

        public async Task AddGenreAsync(Mytable entity)
        {
            await _genresRepository.CreateAsync(entity);
        }

        public async Task DeleteGenreAsync(Mytable entity)
        {
            await _genresRepository.DeleteAsync(entity);
        }

        public async Task<List<Mytable>> GetAll()
        {
            return await _genresRepository.GetAll();

        }

        public async Task<Mytable> GetByIdGenre(int id)
        {
            return await _genresRepository.GetById(id);
        }

        public async Task<List<Mytable>> ListGenres()
        {
            return await _genresRepository.GetAll();
        }

        public async Task UpdateGenreAsync(Mytable entity)
        {
            await _genresRepository.UpdateAsync(entity);


        }
    }
}
