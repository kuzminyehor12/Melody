using Melody.DataLayer.Models;

namespace Melody.BusinessLayer.DTOs
{
    public class AudioBookCollectionDto : BaseDto
    {
        public string Title { get; set; }

        public string? Coversheet { get; set; }

        public string Description { get; set; }

        public DateTime PublishedAt { get; set; } = DateTime.Now;

        public Guid CreatorId { get; set; }

        public virtual ICollection<Guid> AudioBookIds { get; set; }

        public int FollowersCount { get; set; }
    }
}
