namespace Melody.DataLayer.Models
{
    public class Album : DisplayableItem
    {
        public virtual ICollection<Track> Tracks { get; set; }
    }
}
