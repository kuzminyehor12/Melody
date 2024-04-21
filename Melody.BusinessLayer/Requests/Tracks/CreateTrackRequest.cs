namespace Melody.BusinessLayer.Requests.Tracks
{
    public class CreateTrackRequest
    {
        public string Title { get; set; }

        public string Filename { get; set; }

        public string? Coversheet { get; set; }

        public int ListeningsCount { get; set; }

        public Guid? AlbumId { get; set; }

        public IEnumerable<Guid> GenreIds { get; set; }

        public IEnumerable<Guid> PlaylistIds { get; set; }
    }
}
