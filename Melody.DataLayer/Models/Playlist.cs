using Melody.Shared.Enums;

namespace Melody.DataLayer.Models
{
    public class Playlist : BaseModel
    {
        public string Title { get; set; }

        public string? Coversheet { get; set; }

        public string Description { get; set; }

        public DateTime PublishedAt { get; set; }

        public Guid CreatorId { get; set; }

        public Creator Creator { get; set; }

        public bool IsPublic { get; set; } = true;

        public PlaylistType Type { get; set; }

        public virtual ICollection<Track> PlaylistedTracks { get; set; }

        public virtual ICollection<User> Followers { get; set; }

        public virtual ICollection<Tag> Tags { get; set; }
    }
}
