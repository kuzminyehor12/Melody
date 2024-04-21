namespace Melody.BusinessLayer.Requests.Tracks
{
    public class CreateTrackRequest
    {
        public string Title { get; set; }

        public string Filename { get; set; }

        public long DurationInMs { get; set; }

        public string Author { get; set; }

        public Guid? AlbumId { get; set; }

        public IEnumerable<Guid> GenreIds { get; set; }
    }
}
