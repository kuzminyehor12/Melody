namespace Melody.DataLayer.Models
{
    public class AudioItem : BaseModel
    {
        public string Title { get; set; }

        public string AuthorName { get; set; }

        public string Filename { get; set; }

        public string? Coversheet { get; set; }

        public long DurationInMs { get; set; }

        public int ListeningsCount { get; set; }

        public DateTime PublishedAt { get; set; }

        public Guid CreatorId { get; set; }

        public Creator Creator { get; set; }
    }
}
