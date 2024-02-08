namespace Melody.DataLayer.EFCore.Entities
{
    public class GenreEntity : DisplayableEntity
    {
        public virtual ICollection<TrackEntity> Tracks { get; set; }
    }
}
