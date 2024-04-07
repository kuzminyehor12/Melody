using Melody.DataLayer.EFCore.Infrastructure;
using Melody.DataLayer.Interfaces;

namespace Melody.DataLayer.Infastructure
{
    public class RepositoryContext
    {
        private readonly MelodyDbContext _dbContext;

        public virtual ITrackRepository Tracks { get; set; }

        public virtual IPodcastRepository Podcasts { get; set; }

        public virtual IPlaylistRepository Playlists { get; set; }

        public virtual IGenreRepository Genres { get; set; }

        public virtual ICreatorRepository Creators { get; set; }

        public virtual IAlbumRepository Albums { get; set; }

        public virtual IUserRepository Users { get; set; }

        public virtual IAudioBookRepository AudioBooks { get; set; }

        public virtual IAudioBookCollectionRepository AudioBookCollections { get; set; }

        public RepositoryContext(
            ITrackRepository tracks, 
            IPodcastRepository podcasts,
            IPlaylistRepository playlists,
            IAlbumRepository albums,
            ICreatorRepository creators,
            IUserRepository users,
            IGenreRepository genres,
            IAudioBookRepository audioBooks,
            IAudioBookCollectionRepository audioBookCollections,
            MelodyDbContext dbContext
           )
        {
            _dbContext = dbContext;
            Tracks = tracks;
            Podcasts = podcasts;
            Playlists = playlists;
            Albums = albums;
            Users = users;
            Genres = genres;
            Creators = creators;
            AudioBooks = audioBooks;
            AudioBookCollections = audioBookCollections;

            AttachContext(dbContext);
        }

        private void AttachContext(MelodyDbContext melodyDbContext)
        {
            Tracks.AttachContext(melodyDbContext);
            Podcasts.AttachContext(melodyDbContext);
            Playlists.AttachContext(melodyDbContext);
            Albums.AttachContext(melodyDbContext);
            Users.AttachContext(melodyDbContext);
            Genres.AttachContext(melodyDbContext);
            Creators.AttachContext(melodyDbContext);
            AudioBooks.AttachContext(melodyDbContext);
            AudioBookCollections.AttachContext(melodyDbContext);
        }

        public async Task SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            await _dbContext.SaveChangesAsync(cancellationToken);
        }
    }
}
