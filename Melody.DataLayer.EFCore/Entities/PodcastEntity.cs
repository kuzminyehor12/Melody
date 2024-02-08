namespace Melody.DataLayer.EFCore.Entities
{
    public class PodcastEntity : AudioItemEntity
    {
        public Guid TopicId { get; set; }

        public TopicEntity Topic { get; set; }
    }
}
