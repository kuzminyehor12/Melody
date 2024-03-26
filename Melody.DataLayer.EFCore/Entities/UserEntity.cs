namespace Melody.DataLayer.EFCore.Entities
{
    public class UserEntity : BaseEntity
    {
        public string UserName { get; set; }

        public string Email { get; set; }

        public string? Image { get; set; }

        public DateTime RegisteredAt { get; set; } = DateTime.Now;
        
        public virtual CreatorEntity Creator { get; set; }

        // Followed tracks are stored in playlist that stored in FollowedPlaylists
        // For each user by default 'Liked Songs' playlist will be created
        public virtual ICollection<PlaylistEntity> FollowedPlaylists { get; set; }

        public virtual ICollection<PodcastEntity> FollowedPodcasts { get; set; }

        public virtual ICollection<AlbumEntity> FollowedAlbums { get; set; }

        public virtual ICollection<AudioBookEntity> FollowedAudioBooks { get; set; }

        public virtual ICollection<AudioBookCollectionEntity> FollowedAudioBookCollections { get; set; }
    }
}
