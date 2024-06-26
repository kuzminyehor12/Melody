﻿namespace Melody.DataLayer.EFCore.Entities
{
    public class AudioItemEntity : BaseEntity
    {
        public string Title { get; set; }

        public string AuthorName { get; set; }

        public string Filename { get; set; }

        public double DurationInMs { get; set; }

        public string? Coversheet { get; set; }

        public int ListeningsCount { get; set; }

        public DateTime PublishedAt { get; set; }

        public Guid CreatorId { get; set; }

        public CreatorEntity Creator { get; set; }

        public virtual ICollection<UserEntity> Followers { get; set; }
    }
}
