using Melody.DataLayer.EFCore.Entities;

namespace Melody.DataLayer.Models
{
    public class Album : BaseModel
    {
        public string Title { get; set; }

        public string? Coversheet { get; set; }

        public string Author { get; set; }

        public string Description { get; set; }

        public DateTime CreatedAt { get; set; }

        public Guid CreatorId { get; set; }

        public Creator Creator { get; set; }

        public virtual ICollection<Track> AlbumedTracks { get; set; }

        public virtual ICollection<User> Followers { get; set; }
    }
}
