using FinalProject.DataLayer.Abstract;
using FinalProject.DataLayer.Concrete.EntityFramework;
using FinalProject.DataLayer.Redis;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//redis  Implement service
builder.Services.AddSingleton<IRedisHelper, RedisHelper>();
var key = Encoding.ASCII.GetBytes(builder.Configuration["Application:JWTSecret"]);


//JWT kimlik do�rulama servisi ca�r�ld�..

builder.Services.AddAuthentication(x =>
{

    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

}).AddJwtBearer(x =>
{

    x.Audience = "Mahir";
    x.RequireHttpsMetadata = false;
    x.SaveToken = true;
    x.ClaimsIssuer = "Mahir.Issuer.Developnent";
    x.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
    {

        IssuerSigningKey = new SymmetricSecurityKey(key),
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidateIssuer = false,
        ValidateAudience = false


    };

});



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();


}
//var app1 = builder.Build();
//IConfiguration configuration = app1.Configuration;
//IWebHostEnvironment environment = app1.Environment;



//
/// <summary>
/// asp.net core ile b�t�nle�ik olarak gelen dependency injection mekanizmas�nda �� farkl� lifetime se�ene�i mevcuttur.
/// 
/// singleton: uygulama ilk aya�a kalkt��� anda, servisin tek bir instance�� olu�turularak memory�de tutulur ve daha sonras�nda her servis �a�r�s�nda bu instance g�nderilir.
/// 
/// scoped : her request i�in tek bir instance yarat�lmas�n� sa�layan lifetime se�ene�idir. request cycle�� tamamlanana kadar ger�ekle�en servis �a�r�lar�nda daha �nce olu�turulan instance g�nderilir. daha sonra yeni bir request ba�lad���nda farkl� bir instance olu�turulur.
/// transient : her servis �a�r�s�nda yeni bir instance olu�turulur. ba�lay�c�l��� en az olan lifetime se�ene�idir.

/// 
/// </summary>

IServiceCollection services = new ServiceCollection();

//Proje boyunca Service �a�r�ld���nda,Manager'i kullan.

services.AddSingleton<IGenresRepository, EfCoreGenresRepository>();
services.AddSingleton<IMoviesRepository, EfCoreMoviesRepository>();
services.AddSingleton<ITrendingsRepository, EfCoreTrendingsRepository>();
services.AddControllersWithViews();//Projemizin MVC yap�s�nda olmas�n� sa�lar.

app.UseRouting();
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();




//Endpoint: istemciler(clients) ve host'lar aras�ndaki ileti�imi �a�lamak i�in kullan�lan bir aray�zd�r. Her endpoint'in kendi adresi vard�r ve bu adresin benzersiz olmas� i�in servisin kendi ana adresine eklenmektedir.7 �ub 2013

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "genres/AllGenres",
                    defaults: new { controller = "Genres", action = "GetListGenres" }
                    );
    endpoints.MapControllerRoute(
                    name: "movies",
                    pattern: "movies/createmovie",
                    defaults: new { controller = "Movies", action = "CreateMovie" }
                    );
    endpoints.MapControllerRoute(
                    name: "trendings",
                    pattern: "trendings/createtrendings",
                    defaults: new { controller = "Trendings", action = "ListMostViewedMovies" }
                    );

});
app.Run();