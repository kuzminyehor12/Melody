namespace Melody.DataLayer.EFCore.Entities
{
    public class TagEntity : DisplayableEntity
    {
        public virtual ICollection<TrackEntity> Tracks { get; set; }

        public virtual ICollection<PodcastEntity> Podcasts { get; set; }
    }
}
