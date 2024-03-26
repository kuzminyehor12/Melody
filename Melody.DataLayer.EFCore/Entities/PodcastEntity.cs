namespace Melody.DataLayer.EFCore.Entities
{
    public class PodcastEntity : AudioItemEntity
    {
        public string Description { get; set; } = string.Empty;

        public virtual ICollection<UserEntity> Followers { get; set; }
    }
}
