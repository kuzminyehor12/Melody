namespace Melody.DataLayer.EFCore.Entities
{
    public class CreatorEntity : BaseEntity
    {
        public virtual UserEntity User { get; set; }

        public virtual ICollection<PodcastEntity> Podcasts { get; set; }

        public virtual ICollection<TrackEntity> Tracks { get; set; }

        public virtual ICollection<AlbumEntity> Albums { get; set; }

        public virtual ICollection<PlaylistEntity> Playlists { get; set; }

        public virtual ICollection<AudioBookEntity> AudioBooks { get; set; }

        public virtual ICollection<AudioBookCollectionEntity> AudioBooksCollection { get; set; }
    }
}
