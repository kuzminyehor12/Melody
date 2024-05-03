namespace Melody.BusinessLayer.Requests.Playlists
{
    public class CreatePlaylistDataRequest
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public Guid CreatorId { get; set; }

        public bool IsPublic { get; set; } = true;

        public DateTime PublishedAt { get; set; } = DateTime.Now;

        public string[] TagIds { get; set; } = Array.Empty<string>();
    }
}
