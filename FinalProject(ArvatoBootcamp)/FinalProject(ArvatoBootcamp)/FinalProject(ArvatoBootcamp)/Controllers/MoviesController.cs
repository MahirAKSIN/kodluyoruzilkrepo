using FinalProject.BusinessLayer.Concrete;
using FinalProject.DataLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject_ArvatoBootcamp_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        MoviesManager moviesManager = new MoviesManager(new EfCoreMoviesRepository());


        [HttpGet]
        public async Task<IActionResult> GetMovieDetails(int id)
        {
            var movie = await moviesManager.GetMovieDetail(id);
            return Ok(movie);

        }

        [HttpGet]
        public async Task<IActionResult> GetMovieList(int id)
        {
            var movie = await moviesManager.GetMovieList(id);
            return Ok(movie);
        }

    }
}
