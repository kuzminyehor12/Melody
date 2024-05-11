using Melody.Shared.Enums;

namespace Melody.BusinessLayer.Requests.Upload
{
    public class UploadAudioDataRequest
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public AudioType Type { get; set; }

        public string? Description { get; set; }

        public string[] GenreIds { get; set; }

        public string? CollectionId { get; set; }

        public string CreatorId { get; set; }
    }
}
