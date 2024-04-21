using AutoMapper.Extensions.ExpressionMapping;
using Melody.BusinessLayer.Interfaces;
using Melody.BusinessLayer.Mappings;
using Melody.BusinessLayer.Services;
using Melody.BusinessLayer.Strategies;
using Melody.DataLayer.EFCore.Infrastructure;
using Melody.DataLayer.Infastructure;
using Melody.DataLayer.Mappings;
using Melody.Server.Configuration;
using Melody.Server.Extensions;
using Melody.Services.Interfaces;
using Microsoft.Extensions.Options;
using Refit;

namespace Melody.Server
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var apiConfig = builder.Configuration.GetSection("ApiConfig").Get<ApiConfig>();
            var postgresConnectionString = builder.Configuration["ConnectionStrings:Postgres"];

            builder.Services.AddAutoMapper(BLAssembly.GetAssembly(), DLAssembly.GetAssembly());
            builder.Services.AddAutoMapper(config =>
            {
                config.AddExpressionMapping();
            });

            builder.Services.AddNpgsql<MelodyDbContext>(postgresConnectionString);

            builder.Services.AddRefitClient<IDeezerApiClient>()
                .ConfigureHttpClient(c =>
                {
                    c.BaseAddress = new Uri(apiConfig.Url);
                    c.DefaultRequestHeaders.Add(apiConfig.Key.HeaderName, apiConfig.Key.HeaderValue);
                    c.DefaultRequestHeaders.Add(apiConfig.Host.HeaderName, apiConfig.Host.HeaderValue);
                });

            builder.Services.AddRepositories();

            builder.Services.AddScoped<RepositoryContext>();

            builder.Services.AddBusinessServices();

            builder.Services.AddTransient<StrategyInjector>();

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
