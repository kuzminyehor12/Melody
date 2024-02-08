using Melody.DataLayer.Models;

namespace Melody.BusinessLayer.Requests.Podcasts
{
    public class CreatePodcastRequest
    {
        public string Title { get; set; }

        public string Filename { get; set; }

        public string? Coversheet { get; set; }

        public Guid CreatorId { get; set; }

        public IEnumerable<Guid> TopicIds { get; set; }
    }
}
