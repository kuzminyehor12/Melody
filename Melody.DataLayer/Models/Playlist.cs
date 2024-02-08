namespace Melody.DataLayer.Models
{
    public class Playlist : BaseModel
    {
        public string Title { get; set; }

        public string? Coversheet { get; set; }

        public DateTime PublishedAt { get; set; }

        public Guid CreatorId { get; set; }

        public Creator Creator { get; set; }

        public virtual ICollection<Track> Tracks { get; set; }
    }
}
