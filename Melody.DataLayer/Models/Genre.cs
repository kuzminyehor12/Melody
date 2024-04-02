namespace Melody.DataLayer.Models
{
    public class Genre : DisplayableItem
    {
        public virtual ICollection<Track> GenredTracks { get; set; }
    }
}
