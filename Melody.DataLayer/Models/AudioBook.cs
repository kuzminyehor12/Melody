namespace Melody.DataLayer.Models
{
    public class AudioBook : AudioItem
    {
        public string Description { get; set; }

        public Guid? AudioBookCollectionId { get; set; }

        public AudioBookCollection AudioBookCollection { get; set; }

        public virtual ICollection<User> Followers { get; set; }
    }
}
