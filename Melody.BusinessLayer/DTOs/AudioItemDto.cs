namespace Melody.BusinessLayer.DTOs
{
    public class AudioItemDto : HasCreatorDto
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public string Filename { get; set; }

        public double DurationInMs { get; set; }

        public string? Coversheet { get; set; }

        public int ListeningsCount { get; set; }

        public DateTime PublishedAt { get; set; }

        public int FollowersCount { get; set; }

        public string? DownloadUrl { get; set; }

        public string? CoversheetUrl { get; set; }
    }
}
