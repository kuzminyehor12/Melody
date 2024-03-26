using Melody.DataLayer.EFCore.Entities;
using Melody.DataLayer.EFCore.Extensions;
using Microsoft.EntityFrameworkCore;

namespace Melody.DataLayer.EFCore.Infrastructure
{
    public class MelodyDbContext : DbContext
    {
        public virtual DbSet<UserEntity> Users { get; set; }

        public virtual DbSet<TrackEntity> Tracks { get; set; }

        public virtual DbSet<AlbumEntity> Albums { get; set; }

        public virtual DbSet<PodcastEntity> Podcasts { get; set; }

        public virtual DbSet<GenreEntity> Genres { get; set; }

        public virtual DbSet<PlaylistEntity> Playlists { get; set; }

        public virtual DbSet<CreatorEntity> Creators { get; set; }

        public virtual DbSet<AudioBookEntity> AudioBooks { get; set; }

        public virtual DbSet<AudioBookCollectionEntity> AudioBookCollections { get; set; }

        public virtual DbSet<TagEntity> Tags { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.BuildTracks();
            modelBuilder.BuildPlaylists();
            modelBuilder.BuildCreators();
            modelBuilder.BuildUsers();
            modelBuilder.BuildPodcasts();
            modelBuilder.BuildGenres();
            modelBuilder.BuildAudioBooks();
            modelBuilder.BuildTags();
            modelBuilder.BuildAudioBookCollections();
        }
    }
}
