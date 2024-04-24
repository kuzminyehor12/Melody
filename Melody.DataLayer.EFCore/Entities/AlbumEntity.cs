namespace Melody.DataLayer.EFCore.Entities
{
    public class AlbumEntity : BaseEntity
    {
        public string Title { get; set; }

        public string? Coversheet { get; set; }

        public string AuthorName { get; set; }

        public string Description { get; set; }

        public DateTime CreatedAt { get; set; }

        public Guid CreatorId { get; set; }

        public CreatorEntity Creator { get; set; }

        public virtual ICollection<UserEntity> Followers { get; set; }

        public virtual ICollection<TrackEntity> AlbumedTracks { get; set; }
    }
}
