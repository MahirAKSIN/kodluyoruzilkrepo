using FinalProject.BusinessLayer.Concrete;
using FinalProject.DataLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject_ArvatoBootcamp_.Controllers
{
    //
    /// <summary>
    /// Bu controllerda Trendings için yapılmıştır.
    /// Bu controllerda sadece Trendings için dataları List halinde getirme işlemi yapılacaktır
    /// Diğer Crud işlemleri bu controllerda yapılmayacak
    /// 
    /// 
    /// </summary>




    [Route("api/[controller]")]
    [ApiController]
    public class TrendingsController : ControllerBase
    {
        TrendingsManager trendingsManager = new TrendingsManager(new EfCoreTrendingsRepository());


        [HttpGet]

        public async Task<IActionResult> ListMostViewedMovies(int voteCount)
        {
            var trendings = await trendingsManager.ListMostViewedMovies(voteCount);

            if (trendings == null)
            {
                return NotFound();
            }
            return Ok(trendings);
        }
        [HttpGet("{id}")]

        public async Task<IActionResult> ListTopRatedMovies(int voteCount)
        {
            var trendings = await trendingsManager.ListTopRatedMovies(voteCount);

            if (trendings == null)
            {
                return NotFound();
            }
            return Ok(trendings);
        }


    }
}
