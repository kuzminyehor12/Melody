namespace Melody.DataLayer.EFCore.Entities
{
    public class TrackEntity : AudioItemEntity
    {
        public Guid? AlbumId { get; set; }

        public AlbumEntity? Album { get; set; }

        public virtual ICollection<GenreEntity> Genres { get; set; }

        public virtual ICollection<PlaylistEntity> Playlists { get; set; }
    }
}
