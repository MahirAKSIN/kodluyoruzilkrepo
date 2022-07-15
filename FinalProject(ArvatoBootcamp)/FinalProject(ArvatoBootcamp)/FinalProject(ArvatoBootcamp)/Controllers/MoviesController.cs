using FinalProject.BusinessLayer.Concrete;
using FinalProject.DataLayer.Concrete.EntityFramework;
using FinalProject.DataLayer.ContextDb;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject_ArvatoBootcamp_.Controllers
{


    //
    /// <summary>
    /// Bu controllerda Movies için yapılmıştır.
    /// Bu controllerda sadece Movies için dataları List halinde getirme işlemi yapılacaktır
    /// Diğer Crud işlemleri bu controller tarafından da yapılacaktır
    /// 
    /// 
    /// </summary>



    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        MoviesManager moviesManager = new MoviesManager(new EfCoreMoviesRepository());
       
        
        [HttpGet]
        public async Task<IActionResult> GetMovieDetails(int id)
        {
            var movie = await moviesManager.GetMovieById(id);
            if (movie == null)
            {
                return NotFound();
            }
            return Ok(movie);

        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMovieList(int id)
        {
            var movie = await moviesManager.GetMovieList(id);
            if (movie == null)
            {
                return NotFound();
            }
            return Ok(movie);
        }
        [HttpPost]
        public async Task<IActionResult> Search(string title)
        {

            var movie = await moviesManager.Search(title);
            if (movie == null)
            {
                return NotFound();
            }
            return Ok(movie);


        }
        [HttpPost("{id}")]
        public async Task<IActionResult> CreateMovie(Mytable entity)
        {
            await moviesManager.AddMoviesAsync(entity);
            return CreatedAtAction(nameof(moviesManager), new { id = entity.Id }, entity);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateMovie(int id,Mytable entity)
        {
            if (id != entity.Id)
            {
                return BadRequest();
            }
            await moviesManager.UpdateMovieAsync(entity);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMovie(int id)
        {

            var information = await moviesManager.GetMovieById(id);
            if (information == null)
            {
                return NotFound();
            }
            await moviesManager.DeleteMovieAsync(information);
            return NoContent();
        }
    }
}
