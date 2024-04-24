using Melody.DataLayer.EFCore.Entities;

namespace Melody.DataLayer.Models
{
    public class Album : DisplayableItem
    {
        public string Description { get; set; }

        public DateTime CreatedAt { get; set; }

        public Guid CreatorId { get; set; }

        public virtual ICollection<Track> AlbumedTracks { get; set; }

        public virtual ICollection<User> Followers { get; set; }
    }
}
