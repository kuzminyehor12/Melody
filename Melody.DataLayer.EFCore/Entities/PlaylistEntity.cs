﻿namespace Melody.DataLayer.EFCore.Entities
{
    public class PlaylistEntity : BaseEntity
    {
        public string Title { get; set; }

        public string? Coversheet { get; set; }

        public DateTime PublishedAt { get; set; } = DateTime.Now;

        public bool IsPublic { get; set; } = true;

        // SongBased, AudioBookBased, PodcastBased, Unknown
        public short Type { get; set; }

        public Guid CreatorId { get; set; }

        public CreatorEntity Creator { get; set; }

        public virtual ICollection<TrackEntity> PlaylistedTracks { get; set; }

        public virtual ICollection<TagEntity> Tags { get; set; }

        public virtual ICollection<UserEntity> Followers { get; set; }
    }
}
