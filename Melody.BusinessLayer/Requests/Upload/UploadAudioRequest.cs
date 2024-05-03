using Melody.BusinessLayer.Utils;

namespace Melody.BusinessLayer.Requests.Upload
{
    public class UploadAudioRequest
    {
        public UploadAudioDataRequest Data { get; set; }

        public PersistentFile? File { get; set; }
    }
}
