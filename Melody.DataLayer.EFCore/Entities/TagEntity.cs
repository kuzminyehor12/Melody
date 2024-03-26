namespace Melody.DataLayer.EFCore.Entities
{
    public class TagEntity : DisplayableEntity
    {
        public virtual ICollection<PlaylistEntity> TaggedPlaylists { get; set; }
    }
}
