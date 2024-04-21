using Melody.Shared.Enums;
using Microsoft.AspNetCore.Http;

namespace Melody.BusinessLayer.Requests.Upload
{
    public class UploadAudioRequest
    {
        public UploadAudioDataRequest Data { get; set; }

        public IFormFile? File { get; set; }
    }
}
