namespace Melody.DataLayer.EFCore.Entities
{
    public class TopicEntity : DisplayableEntity
    {
        public virtual ICollection<PodcastEntity> Podcasts { get; set; }
    }
}
