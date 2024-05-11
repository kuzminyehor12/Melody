namespace Melody.DataLayer.EFCore.Entities
{
    public class AudioBookCollectionEntity : BaseEntity
    {
        public string Title { get; set; }

        public string? Coversheet { get; set; }

        public string Description { get; set; } = string.Empty;

        public DateTime PublishedAt { get; set; }

        public Guid CreatorId { get; set; }

        public CreatorEntity Creator { get; set; }

        public virtual ICollection<AudioBookEntity> AudioBooks { get; set; }

        public virtual ICollection<UserEntity> Followers { get; set; }
    }
}
