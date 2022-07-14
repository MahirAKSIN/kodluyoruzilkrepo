using FinalProject.BusinessLayer.Concrete;
using FinalProject.DataLayer.Concrete.EntityFramework;
using FinalProject.DataLayer.ContextDb;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject_ArvatoBootcamp_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        GenresManager genresManager = new GenresManager(new EfCoreGenresRepository());
        MoviesInfoContext _c;

        public LoginController(MoviesInfoContext c)
        {
            _c = c;
        }

        [HttpGet]
        public String Login(string Username, string Password)
        {
            var user = _c.Logins.FirstOrDefault(x => x.UserName == Username && x.Passwored == Password);
            if (user != null)
            {

            }
            return "";
        }

    }
}
