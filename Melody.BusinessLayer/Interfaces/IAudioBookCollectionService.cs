using Melody.BusinessLayer.Requests.AudioBookCollections;
using Melody.Shared;

namespace Melody.BusinessLayer.Interfaces
{
    public interface IAudioBookCollectionService
    {
        Task<Result> AddAsync(CreateAudioBookCollectionRequest request, CancellationToken cancellationToken);
    }
}
