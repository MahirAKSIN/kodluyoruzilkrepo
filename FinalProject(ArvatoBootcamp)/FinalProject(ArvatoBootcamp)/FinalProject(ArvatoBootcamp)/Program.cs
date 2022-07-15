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


//JWT kimlik doðrulama servisi caðrýldý..

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
/// asp.net core ile bütünleþik olarak gelen dependency injection mekanizmasýnda üç farklý lifetime seçeneði mevcuttur.
/// 
/// singleton: uygulama ilk ayaða kalktýðý anda, servisin tek bir instance’ý oluþturularak memory’de tutulur ve daha sonrasýnda her servis çaðrýsýnda bu instance gönderilir.
/// 
/// scoped : her request için tek bir instance yaratýlmasýný saðlayan lifetime seçeneðidir. request cycle’ý tamamlanana kadar gerçekleþen servis çaðrýlarýnda daha önce oluþturulan instance gönderilir. daha sonra yeni bir request baþladýðýnda farklý bir instance oluþturulur.
/// transient : her servis çaðrýsýnda yeni bir instance oluþturulur. baðlayýcýlýðý en az olan lifetime seçeneðidir.

/// 
/// </summary>

IServiceCollection services = new ServiceCollection();

//Proje boyunca Service çaðrýldýðýnda,Manager'i kullan.

services.AddSingleton<IGenresRepository, EfCoreGenresRepository>();
services.AddSingleton<IMoviesRepository, EfCoreMoviesRepository>();
services.AddSingleton<ITrendingsRepository, EfCoreTrendingsRepository>();
services.AddControllersWithViews();//Projemizin MVC yapýsýnda olmasýný saðlar.

app.UseRouting();
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();




//Endpoint: istemciler(clients) ve host'lar arasýndaki iletiþimi þaðlamak için kullanýlan bir arayüzdür. Her endpoint'in kendi adresi vardýr ve bu adresin benzersiz olmasý için servisin kendi ana adresine eklenmektedir.7 Þub 2013

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