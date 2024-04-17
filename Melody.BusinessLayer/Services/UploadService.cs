using Melody.BusinessLayer.Interfaces;
using Melody.BusinessLayer.Requests.Upload;
using Melody.Shared;

namespace Melody.BusinessLayer.Services
{
    public class UploadService : IUploadService
    {
        public Task<Result> UploadAudioAsync(UploadAudioRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
