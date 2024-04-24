namespace Melody.BusinessLayer.DTOs
{
    public class AlbumDto : DisplayableItemDto
    {
        public string Description { get; set; }

        public DateTime CreatedAt { get; set; }

        public Guid CreatorId { get; set; }

        public ICollection<Guid> AlbumedTrackIds { get; set; }

        public int FollowersCount { get; set; }
    }
}
