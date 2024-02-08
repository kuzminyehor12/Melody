namespace Melody.DataLayer.Models
{
    public class User : BaseModel
    {
        public string UserName { get; set; }

        public string Email { get; set; }

        public string? Image { get; set; }

        public DateTime RegisteredAt { get; set; }

        public virtual ICollection<Creator> ManagedCreators { get; set; }

        public virtual ICollection<Creator> FollowedCreators { get; set; }

        public virtual ICollection<Playlist> FollowedPlaylists { get; set; }

        public virtual ICollection<Track> FollowedTracks { get; set; }

        public virtual ICollection<Podcast> FollowedPodcasts { get; set; }

        public virtual ICollection<Album> FollowedAlbums { get; set; }
    }
}
