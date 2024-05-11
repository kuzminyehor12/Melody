namespace Melody.BusinessLayer.DTOs
{
    public class CollectionItemDto : HasCreatorDto
    {
        public string Author { get; set; }

        public string Title { get; set; }

        public string? Coversheet { get; set; }

        public string Description { get; set; }

        public int FollowersCount { get; set; }

        public string? CoversheetUrl { get; set; }
    }
}
