namespace Melody.DataLayer.EFCore.Entities
{
    public class CreatorEntity : BaseEntity
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public string Email { get; set; }

        public string? Image { get; set; }

        public bool Verified { get; set; } = false;

        public DateTime RegisteredAt { get; set; } = DateTime.Now;

        public virtual ICollection<UserEntity> Managers { get; set; }

        public virtual ICollection<UserEntity> Followers { get; set; }

        public virtual ICollection<PodcastEntity> Podcasts { get; set; }

        public virtual ICollection<TrackEntity> Tracks { get; set; }

        public virtual ICollection<AlbumEntity> Albums { get; set; }
    }
}
