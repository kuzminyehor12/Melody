using Melody.BusinessLayer.Interfaces;
using Melody.BusinessLayer.Mappings;
using Melody.BusinessLayer.Services;
using Melody.DataLayer.Mappings;
using Melody.Services.Interfaces;
using Refit;

namespace Melody.Server
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddAutoMapper(BLAssembly.GetAssembly(), DLAssembly.GetAssembly());

            builder.Services.AddRefitClient<IDeezerApiClient>()
                .ConfigureHttpClient(c =>
                {
                    c.BaseAddress = new Uri("https://deezerdevs-deezer.p.rapidapi.com");
                    c.DefaultRequestHeaders.Add("X-RapidAPI-Key", "84ae771033mshf62081246a48f34p12b39djsn446c9a3027dc");
                    c.DefaultRequestHeaders.Add("X-RapidAPI-Host", "deezerdevs-deezer.p.rapidapi.com");
                });

            builder.Services.AddScoped<ISearchService, SearchService>();
            builder.Services.AddScoped<IGenreService, GenreService>();

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            app.UseCors(options =>
            {
                options.AllowAnyHeader();
                options.AllowAnyMethod();
                options.AllowAnyOrigin();
            });

            app.UseDefaultFiles();
            app.UseStaticFiles();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.MapFallbackToFile("/index.html");

            app.Run();
        }
    }
}
