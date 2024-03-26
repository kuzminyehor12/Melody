namespace Melody.DataLayer.EFCore.Entities
{
    public class AudioBookEntity : AudioItemEntity
    {
        public string Description { get; set; } = string.Empty;

        public Guid? AudioBookCollectionId { get; set; }

        public AudioBookCollectionEntity AudioBookCollection { get; set; }

        public virtual ICollection<UserEntity> Followers { get; set; }
    }
}
