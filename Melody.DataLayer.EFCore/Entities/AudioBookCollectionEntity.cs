namespace Melody.DataLayer.EFCore.Entities
{
    public class AudioBookCollectionEntity : BaseEntity
    {
        public string Title { get; set; }

        public string? Coversheet { get; set; }

        public string Description { get; set; }

        public DateTime PublishedAt { get; set; } = DateTime.Now;

        public Guid CreatorId { get; set; }

        public CreatorEntity Creator { get; set; }

        public virtual ICollection<AudioBookEntity> AudioBooks { get; set; }
    }
}
