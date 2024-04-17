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
    }
}
