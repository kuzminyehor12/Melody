namespace Melody.DataLayer.Models
{
    public class Podcast : AudioItem
    {
        public string Description { get; set; }

        public virtual ICollection<User> Followers { get; set; }
    }
}
