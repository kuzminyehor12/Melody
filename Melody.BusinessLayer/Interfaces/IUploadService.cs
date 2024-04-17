using Melody.BusinessLayer.Requests.Upload;
using Melody.Shared;

namespace Melody.BusinessLayer.Interfaces
{
    public interface IUploadService
    {
        Task<Result> UploadAudioAsync(UploadAudioRequest request, CancellationToken cancellationToken);
    }
}
