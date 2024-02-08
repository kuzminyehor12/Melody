namespace Melody.DataLayer.Models
{
    public class Podcast : AudioItem
    {
        public Guid TopicId { get; set; }
        public Topic Topic { get; set; }
    }
}
