namespace Melody.BusinessLayer.DTOs
{
    public class AlbumDto : CollectionItemDto
    {
        public DateTime CreatedAt { get; set; }

        public ICollection<Guid> AlbumedTrackIds { get; set; }
    }
}
