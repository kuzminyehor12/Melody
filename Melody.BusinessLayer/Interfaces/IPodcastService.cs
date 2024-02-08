using Melody.BusinessLayer.DTOs;
using Melody.BusinessLayer.Requests.Podcasts;
using Melody.Shared;

namespace Melody.BusinessLayer.Interfaces
{
    public interface IPodcastService
    {
        Task<IEnumerable<PodcastDto>> GetByTopicAsync(GetPodcastByTopicRequest request, CancellationToken cancellationToken = default);

        Task<Result> AddAsync(CreatePodcastRequest request, CancellationToken cancellationToken = default);

        Task<Result> RemoveAsync(RemovePodcastRequest request, CancellationToken cancellationToken = default);
    }
}
