using Melody.DataLayer.EFCore.Entities;
using Melody.DataLayer.EFCore.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace Melody.DataLayer.EFCore.Extensions
{
    public static class ModelBulderExtensions
    {
        public static void BuildTracks(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TrackEntity>()
                .HasId()
                .HasManyToMany(t => t.Genres, g => g.GenredTracks, nameof(GenreEntity.GenredTracks))
                .HasOneToMany(t => t.Creator, c => c.Tracks, t => t.CreatorId, true)
                .HasManyToMany(t => t.Playlists, p => p.PlaylistedTracks, nameof(PlaylistEntity.PlaylistedTracks))
                .HasOneToMany(t => t.Album, a => a.AlbumedTracks, t => t.AlbumId)
                .HasManyToMany(t => t.Followers, u => u.FollowedTracks, nameof(UserEntity.FollowedTracks));
        }

        public static void BuildPlaylists(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PlaylistEntity>()
                .HasId()
                .HasOneToMany(p => p.Creator, c => c.Playlists, p => p.CreatorId, true)
                .HasManyToMany(p => p.Tags, t => t.TaggedPlaylists, nameof(TagEntity.TaggedPlaylists));
        }

        public static void BuildCreators(this ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<CreatorEntity>()
                .HasId()
                .HasManyToOne(c => c.Podcasts, p => p.Creator, p => p.CreatorId, true)
                .HasManyToOne(c => c.AudioBooks, a => a.Creator, a => a.CreatorId, true)
                .HasManyToOne(c => c.AudioBooksCollection, abc => abc.Creator, abc => abc.CreatorId, true)
                .HasManyToOne(c => c.Albums, al => al.Creator, al => al.CreatorId, true)
                .HasOneToOne(c => c.User, u => u.Creator, true);
        }

        public static void BuildUsers(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserEntity>()
                .HasId()
                .HasManyToMany(u => u.FollowedPodcasts, p => p.Followers, nameof(UserEntity.FollowedPodcasts))
                .HasManyToMany(u => u.FollowedAlbums, al => al.Followers, nameof(UserEntity.FollowedAlbums))
                .HasManyToMany(u => u.FollowedPlaylists, p => p.Followers, nameof(UserEntity.FollowedPlaylists))
                .HasManyToMany(u => u.FollowedAudioBooks, a => a.Followers, nameof(UserEntity.FollowedAudioBooks))
                .HasManyToMany(u => u.FollowedAudioBookCollections, abc => abc.Followers, nameof(UserEntity.FollowedAudioBookCollections));
        }

        public static void BuildAudioBooks(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AudioBookEntity>()
                .HasId()
                .HasOneToMany(a => a.AudioBookCollection, abc => abc.AudioBooks, a => a.AudioBookCollectionId, true);
        }

        public static void BuildPodcasts(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PodcastEntity>()
                .HasId();
        }

        public static void BuildAudioBookCollections(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AudioBookCollectionEntity>()
                .HasId();
        }

        public static void BuildTags(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TagEntity>()
                .HasId();
        }

        public static void BuildGenres(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GenreEntity>()
                .HasId()
                .HasData(GenresData.GetList());
        }
    }
}
