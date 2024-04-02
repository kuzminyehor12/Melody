namespace Melody.DataLayer.Models
{
    public class Tag : DisplayableItem
    {
        public virtual ICollection<Playlist> TaggedPlaylists { get; set; }
    }
}
