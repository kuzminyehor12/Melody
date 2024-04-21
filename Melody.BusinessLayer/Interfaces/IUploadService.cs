using Melody.BusinessLayer.DTOs;
using Melody.BusinessLayer.Requests.Upload;
using Melody.BusinessLayer.Strategies;
using Melody.Shared;
using Melody.Shared.Enums;

namespace Melody.BusinessLayer.Interfaces
{
    public interface IUploadService
    {
        Task<Result> UploadAudioAsync(UploadAudioRequest request, CancellationToken cancellationToken);
    }
}
