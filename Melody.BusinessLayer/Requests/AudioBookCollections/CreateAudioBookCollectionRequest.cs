namespace Melody.BusinessLayer.Requests.AudioBookCollections
{
    public class CreateAudioBookCollectionRequest
    {
        public string Title { get; set; }

        public string? Coversheet { get; set; }

        public string Description { get; set; }

        public DateTime PublishedAt { get; set; } = DateTime.Now;

        public Guid CreatorId { get; set; }
    }
}
