namespace Melody.BusinessLayer.DTOs
{
    public class AudioBookDto : AudioItemDto
    {
        public string Description { get; set; }

        public string AuthorName { get; set; }

        public Guid? AudioBookCollectionId { get; set; }
    }
}
