using Melody.BusinessLayer.DTOs;
using Melody.BusinessLayer.Requests.Playlists;
using Melody.Shared;

namespace Melody.BusinessLayer.Interfaces
{
    public interface IPlaylistService
    {
        Task<IEnumerable<PlaylistDto>> GetFollowedPlaylistsByUidAsync(string uid, CancellationToken cancellationToken = default);

        Task<IEnumerable<PlaylistDto>> GetCreatedPlaylistsByUidAsync(string uid, CancellationToken cancellationToken = default);

        Task<IEnumerable<PlaylistDto>> GetBySearchStringAsync(string searchString, CancellationToken cancellationToken = default);

        Task<Result> AddAsync(CreatePlaylistRequest request, CancellationToken cancellationToken = default);

        Task<IEnumerable<AudioItemDto>> GetTracksByPlaylistId(Guid playlistId, CancellationToken cancellationToken = default);

        Task<PlaylistDto> GetPlaylistByIdAsync(Guid playlistId, CancellationToken cancellationToken = default);
    }
}
