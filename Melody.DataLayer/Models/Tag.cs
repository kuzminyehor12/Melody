namespace Melody.DataLayer.Models
{
    public class Tag : DisplayableItem
    {
        public virtual ICollection<Podcast> Podcasts { get; set; }

        public virtual ICollection<Track> Tracks { get; set; }
    }
}
