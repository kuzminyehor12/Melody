using Melody.BusinessLayer.DTOs;
using Melody.BusinessLayer.Requests.Playlists;
using Melody.Shared;

namespace Melody.BusinessLayer.Interfaces
{
    public interface IPlaylistService
    {
        Task<IEnumerable<PlaylistDto>> GetBySearchStringAsync(string searchString, CancellationToken cancellationToken = default);

        Task<Result> AddAsync(CreatePlaylistRequest request, CancellationToken cancellationToken = default);
    }
}
