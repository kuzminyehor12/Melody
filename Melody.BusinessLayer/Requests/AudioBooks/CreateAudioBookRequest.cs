namespace Melody.BusinessLayer.Requests.AudioBooks
{
    public class CreateAudioBookRequest
    {
        public string Title { get; set; }

        public string Filename { get; set; }

        public long DurationInMs { get; set; }

        public string? Coversheet { get; set; }

        public Guid CreatorId { get; set; }

        public string Description { get; set; }

        public Guid? AudioBookCollectionId { get; set; }
    }
}
