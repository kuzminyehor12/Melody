namespace Melody.DataLayer.Models
{
    public class AudioBook : AudioItem
    {
        public string AuthorName { get; set; }

        public string Description { get; set; }

        public Guid? AudioBookCollectionId { get; set; }

        public AudioBookCollection AudioBookCollection { get; set; }
    }
}
