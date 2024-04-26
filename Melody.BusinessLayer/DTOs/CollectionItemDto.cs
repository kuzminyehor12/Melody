namespace Melody.BusinessLayer.DTOs
{
    public class CollectionItemDto : BaseDto
    {
        public string Title { get; set; }

        public string? Coversheet { get; set; }

        public string Description { get; set; }

        public Guid CreatorId { get; set; }

        public int FollowersCount { get; set; }
    }
}
