using Melody.BusinessLayer.DTOs;
using Melody.BusinessLayer.Requests.AudioBookCollections;
using Melody.Shared;

namespace Melody.BusinessLayer.Interfaces
{
    public interface IAudioBookCollectionService
    {
        Task<IEnumerable<AudioBookCollectionDto>> GetBySearchStringAsync(string searchString, CancellationToken cancellationToken = default);

        Task<Result> AddAsync(CreateAudioBookCollectionRequest request, CancellationToken cancellationToken);
    }
}
