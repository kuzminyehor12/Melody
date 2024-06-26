﻿namespace Melody.DataLayer.Models
{
    public class AudioBookCollection : BaseModel
    {
        public string Title { get; set; }

        public string? Coversheet { get; set; }

        public string Description { get; set; }

        public DateTime PublishedAt { get; set; }

        public Guid CreatorId { get; set; }

        public Creator Creator { get; set; }

        public virtual ICollection<AudioBook> AudioBooks { get; set; }

        public virtual ICollection<User> Followers { get; set; }
    }
}
