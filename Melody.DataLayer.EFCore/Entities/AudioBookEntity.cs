namespace Melody.DataLayer.EFCore.Entities
{
    public class AudioBookEntity : AudioItemEntity
    {
        public string AuthorName { get; set; }

        public string Description { get; set; }

        public Guid? AudioBookCollectionId { get; set; }

        public AudioBookCollectionEntity AudioBookCollection { get; set; }
    }
}
