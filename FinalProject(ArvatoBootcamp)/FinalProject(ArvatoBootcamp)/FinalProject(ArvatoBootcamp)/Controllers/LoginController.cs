using FinalProject.BusinessLayer.Concrete;
using FinalProject.DataLayer.Concrete.EntityFramework;
using FinalProject.DataLayer.ContextDb;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Web.Services3.Security.Utility;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace FinalProject_ArvatoBootcamp_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        GenresManager genresManager = new GenresManager(new EfCoreGenresRepository());
        MoviesInfoContext _c;
        IConfiguration configuration;
        ClaimsIdentity Subject;
        SigningCredentials SigningCredentials;
        DateTime Expires;


        public LoginController(MoviesInfoContext c, IConfiguration configuration)
        {
            _c = c;
            this.configuration = configuration;
        }

        [HttpGet("login")]
        public String Login(string Username, string Password)
        {
            var login = _c.Logins.FirstOrDefault(x => x.UserName == Username && x.Passwored == Password);
            if (login != null)
            {
                string token = GenerateToken(login.UserName);
            }
            return "";
        }

        private string GenerateToken(string userName)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(configuration["Application:JWTSecret"]);

            var tokenDecription = new SecurityTokenDescriptor
            {
                Audience = "Mahir",
                Issuer = "Mahir.Issuer.Developnent",
                Subject = new ClaimsIdentity(new Claim[] {
                    new Claim(ClaimTypes.NameIdentifier, Guid.NewGuid().ToString()),
                    new Claim(ClaimTypes.Name, userName),
                }),
                Expires = DateTime.UtcNow.AddMinutes(10),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key),SecurityAlgorithms.HmacSha256Signature),



            };
            var token = tokenHandler.CreateToken(tokenDecription);
            return tokenHandler.WriteToken(token);

        }
    }


}



