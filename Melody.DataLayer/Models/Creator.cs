namespace Melody.DataLayer.Models
{
    public class Creator : BaseModel
    {
        public User User { get; set; }

        public virtual ICollection<Playlist> Playlists { get; set; }

        public virtual ICollection<Podcast> Podcasts { get; set; }

        public virtual ICollection<Track> Tracks { get; set; }

        public virtual ICollection<Album> Albums { get; set; }

        public virtual ICollection<AudioBook> AudioBooks { get; set; }

        public virtual ICollection<AudioBookCollection> AudioBookCollections { get; set; }
    }
}
