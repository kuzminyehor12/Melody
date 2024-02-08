using Melody.BusinessLayer.DTOs;
using Melody.BusinessLayer.Requests.Queue;

namespace Melody.BusinessLayer.Interfaces
{
    // TBD
    public interface IQueueService
    {
        Task<IEnumerable<AudioItemDto>> GetCurrentStateAsync(GetCurrentQueueRequest request, CancellationToken cancellationToken = default);

        Task<IEnumerable<AudioItemDto>> GenerateRandomStateAsync(GenerateRandomQueueRequest request, CancellationToken cancellationToken = default);

        Task<IEnumerable<AudioItemDto>> EnqueueItemAsync(EnqueueItemRequest request, CancellationToken cancellationToken = default);
    }
}
