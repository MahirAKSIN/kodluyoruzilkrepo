using FinalProject.BusinessLayer.Concrete;
using FinalProject.DataLayer.Concrete.EntityFramework;
using FinalProject.DataLayer.ContextDb;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject_ArvatoBootcamp_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenresController : ControllerBase
    {
        GenresManager genresManager = new GenresManager(new EfCoreGenresRepository());

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
            return Ok(genres);
        }
        [HttpPost]
        public async Task<IActionResult> CreateGenres(Mytable entity)
        {

            await genresManager.AddGenreAsync(entity);

            return CreatedAtAction(nameof(GetListGenre),new {id=entity.Id},entity);
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
