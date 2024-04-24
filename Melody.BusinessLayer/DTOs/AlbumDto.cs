namespace Melody.BusinessLayer.DTOs
{
    public class AlbumDto : BaseDto
    {
        public string Title { get; set; }

        public string? Coversheet { get; set; }

        public string Author { get; set; }

        public string Description { get; set; }

        public DateTime CreatedAt { get; set; }

        public Guid CreatorId { get; set; }

        public ICollection<Guid> AlbumedTrackIds { get; set; }

        public int FollowersCount { get; set; }
    }
}
