using Melody.BusinessLayer.Requests.Follows;
using Melody.Shared;

namespace Melody.BusinessLayer.Interfaces
{
    public interface IFollowService
    {
        Task<Result> FollowTrackAsync(FollowTrackRequest request, CancellationToken cancellationToken = default);

        Task<Result> FollowPlaylistAsync(FollowPlaylistRequest request, CancellationToken cancellationToken = default);

        Task<Result> FollowPodcastAsync(FollowPodcastRequest request, CancellationToken cancellationToken = default);

        Task<Result> FollowAlbumAsync(FollowAlbumRequest request, CancellationToken cancellationToken = default);

        Task<Result> UnfollowTrackAsync(UnfollowTrackRequest request, CancellationToken cancellationToken = default);

        Task<Result> UnfollowPlaylistAsync(UnfollowPlaylistRequest request, CancellationToken cancellationToken = default);

        Task<Result> UnfollowPodcastAsync(UnfollowPodcastRequest request, CancellationToken cancellationToken = default);

        Task<Result> UnfollowAlbumAsync(UnfollowAlbumRequest request, CancellationToken cancellationToken = default);
    }
}
