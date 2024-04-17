using Melody.Shared.Enums;
using Microsoft.AspNetCore.Http;

namespace Melody.BusinessLayer.Requests.Upload
{
    public class UploadAudioRequest
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public IFormFile? File { get; set; }

        public AudioType Type { get; set; }

        public string? Description { get; set; }

        public string[] GenreIds { get; set; }

        public string? CollectionId { get; set; }
    }
}
