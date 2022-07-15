using FinalProject.BusinessLayer.Concrete;
using FinalProject.DataLayer.Concrete.EntityFramework;
using FinalProject.DataLayer.ContextDb;
using FinalProject.DataLayer.Redis;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject_ArvatoBootcamp_.Controllers
{


    //
    /// <summary>
    /// Bu controllerda Genres için yapılmıştır.
    /// Genres yapacağı butun işlemlerin tutulduğu yerdir
    /// Genres CRUD işlemleri ve diğer tabloların ilişkisinin düzenlendiği controllerdır
    /// HttpGEt,HttpPost ve projenin ana damarları olan APInin ayağa kalktığı yerdir
    /// </summary>



    [Route("api/[controller]")]
    [ApiController]
    public class GenresController : ControllerBase
    {
        GenresManager genresManager = new GenresManager(new EfCoreGenresRepository());
        IRedisHelper redisHelper;

        public GenresController(IRedisHelper redisHelper)
        {
            this.redisHelper = redisHelper;
        }

        [HttpGet]

        public async Task<IActionResult> GetListGenres()
        {
            var genres = await genresManager.GetAll();
            return Ok(genres);
        }
        [HttpGet("{id}")]

        public async Task<IActionResult> GetListGenre(int id)
        {
            var genres = await genresManager.GetByIdGenre(id);
            if (genres == null)
            {
                return NotFound();
            }

            var lastgenresid = await redisHelper.GetKeyAsync("lastgenresid");

            return Ok(genres);
        }
        [HttpPost]
        public async Task<IActionResult> CreateGenres(Mytable entity)
        {

            await genresManager.AddGenreAsync(entity);


            //Redis cacheleme methodu imzası
            await redisHelper.SetKeyAsync("lastgenresid", entity.Id.ToString());

            return CreatedAtAction(nameof(GetListGenre), new { id = entity.Id }, entity);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGenres(int id)
        {

            var information = await genresManager.GetByIdGenre(id);
            if (information == null)
            {
                return NotFound();
            }
            await genresManager.DeleteGenreAsync(information);
            return NoContent();
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Mytable entity)
        {
            if (id != entity.Id)
            {
                return BadRequest();
            }
            await genresManager.UpdateGenreAsync(entity);
            return NoContent();
        }

    }
}
