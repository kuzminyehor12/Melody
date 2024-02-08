namespace Melody.DataLayer.Models
{
    public class Topic : DisplayableItem
    {
        public virtual ICollection<Podcast> Podcasts { get; set; }
    }
}
