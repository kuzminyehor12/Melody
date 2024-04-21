using Melody.BusinessLayer.Interfaces;
using Melody.BusinessLayer.Services;
using Melody.DataLayer.Infastructure;
using Melody.DataLayer.Interfaces;

namespace Melody.Server.Extensions
{
    public static class ConfigureServicesExtensions
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<ITrackRepository, TrackRepository>();
            services.AddScoped<IPlaylistRepository, PlaylistRepository>();
            services.AddScoped<IPodcastRepository, PodcastRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IGenreRepository, GenreRepository>();
            services.AddScoped<ICreatorRepository, CreatorRepository>();
            services.AddScoped<IAlbumRepository, AlbumRepository>();
            services.AddScoped<IAudioBookRepository, AudioBookRepository>();
            services.AddScoped<IAudioBookCollectionRepository, AudioBookCollectionRepository>();
        }

        public static void AddBusinessServices(this IServiceCollection services)
        {
            services.AddTransient<IUploadService, UploadService>();
            services.AddTransient<ISearchService, SearchService>();
            services.AddTransient<IGenreService, GenreService>();
            services.AddTransient<IUploadService, UploadService>();
            services.AddTransient<ITrackService, TrackService>();
            services.AddTransient<IAlbumService, AlbumService>();
            services.AddTransient<IAudioBookService, AudioBookService>();
            services.AddTransient<IPodcastService, PodcastService>();
            services.AddTransient<IAudioBookCollectionService, AudioBookCollectionService>();
        }
    }
}
