using Melody.Shared.Enums;

namespace Melody.BusinessLayer.DTOs
{
    public class PlaylistDto : CollectionItemDto
    {
        public bool IsPublic { get; set; } = true;

        public DateTime PublishedAt { get; set; } = DateTime.Now;

        public virtual ICollection<Guid> PlaylistedTrackIds { get; set; }

        public virtual ICollection<Guid> TagIds { get; set; }
    }
}
