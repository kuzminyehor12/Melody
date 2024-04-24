namespace Melody.BusinessLayer.Requests.Albums
{
    public class CreateAlbumRequest
    {
        public string Title { get; set; }

        public string? Coversheet { get; set; }

        public string Author { get; set; }

        public string Description { get; set; }

        public DateTime CreatedAt { get; set; }

        public Guid CreatorId { get; set; }
    }
}
