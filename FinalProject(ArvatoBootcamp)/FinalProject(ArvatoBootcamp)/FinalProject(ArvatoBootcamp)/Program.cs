using FinalProject.DataLayer.Abstract;
using FinalProject.DataLayer.Concrete.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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

IServiceCollection services = new ServiceCollection();
//Proje boyunca Service çaðrýldýðýnda,Manager'i kullan.

services.AddSingleton<IGenresRepository, EfCoreGenresRepository>();
services.AddSingleton<IMoviesRepository, EfCoreMoviesRepository>();
services.AddSingleton<ITrendingsRepository, EfCoreTrendingsRepository>();
services.AddControllersWithViews();//Projemizin MVC yapýsýnda olmasýný saðlar.

app.UseRouting();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseEndpoints(endpoints =>
//{
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