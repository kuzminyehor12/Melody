namespace Melody.DataLayer.Models
{
    public class Creator : BaseModel
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public string Email { get; set; }

        public string? Image { get; set; }

        public bool Verified { get; set; } = false;

        public DateTime RegisteredAt { get; set; }

        public virtual ICollection<User> Managers { get; set; }

        public virtual ICollection<User> Followers { get; set; }

        public virtual ICollection<Podcast> Podcasts { get; set; }

        public virtual ICollection<Track> Tracks { get; set; }

        public virtual ICollection<Album> Albums { get; set; }
    }
}
