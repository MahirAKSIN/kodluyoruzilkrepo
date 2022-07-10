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


        //[HttpGet]   

    }
}
