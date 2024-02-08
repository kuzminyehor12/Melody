namespace Melody.DataLayer.Models
{
    public class Genre : DisplayableItem
    {
        public virtual ICollection<Track> Tracks { get; set; }
    }
}
