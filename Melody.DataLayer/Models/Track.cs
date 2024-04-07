namespace Melody.DataLayer.Models
{
    public class Track : AudioItem
    {
        public Guid? AlbumId { get; set; }

        public Album Album { get; set; }

        public virtual ICollection<Genre> Genres { get; set; }

        public virtual ICollection<Playlist> Playlists { get; set; }

        public virtual ICollection<User> Followers { get; set; }
    }
}
