namespace Melody.BusinessLayer.DTOs
{
    public class TrackDto : AudioItemDto
    {
        public Guid? AlbumId { get; set; }

        public IEnumerable<Guid> GenreIds { get; set; }
    }
}
