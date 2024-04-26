using Melody.DataLayer.Models;

namespace Melody.BusinessLayer.DTOs
{
    public class AudioBookCollectionDto : CollectionItemDto
    {
        public DateTime PublishedAt { get; set; } = DateTime.Now;

        public virtual ICollection<Guid> AudioBookIds { get; set; }
    }
}
