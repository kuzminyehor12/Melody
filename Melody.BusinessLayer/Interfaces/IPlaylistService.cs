using Melody.BusinessLayer.DTOs;

namespace Melody.BusinessLayer.Interfaces
{
    public interface IPlaylistService
    {
        Task<IEnumerable<PlaylistDto>> GetBySearchStringAsync(string searchString, CancellationToken cancellationToken = default);
    }
}
