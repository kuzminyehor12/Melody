namespace Melody.BusinessLayer.DTOs
{
    public class AudioItemDto : BaseDto
    {
        public string Title { get; set; }

        public string Filename { get; set; }

        public string? Coversheet { get; set; }

        public int ListeningsCount { get; set; }

        public DateTime PublishedAt { get; set; }

        public Guid CreatorId { get; set; }

        public int FollowersCount { get; set; }

        public IEnumerable<Guid> TagIds { get; set; }
    }
}
