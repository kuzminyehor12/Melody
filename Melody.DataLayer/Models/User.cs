namespace Melody.DataLayer.Models
{
    public class User : BaseModel
    {
        public string Uid { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public string? Image { get; set; }

        public DateTime RegisteredAt { get; set; }

        public Creator Creator { get; set; }

        public virtual ICollection<Track> FollowedTracks { get; set; }

        public virtual ICollection<Playlist> FollowedPlaylists { get; set; }

        public virtual ICollection<Podcast> FollowedPodcasts { get; set; }

        public virtual ICollection<Album> FollowedAlbums { get; set; }

        public virtual ICollection<AudioBook> FollowedAudioBooks { get; set; }

        public virtual ICollection<AudioBookCollection> FollowedAudioBookCollections { get; set; }
    }
}
