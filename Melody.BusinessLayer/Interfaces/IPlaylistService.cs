using Melody.BusinessLayer.DTOs;

namespace Melody.BusinessLayer.Interfaces
{
    public interface IPlaylistService
    {
        Task<IEnumerable<AlbumDto>> GetBySearchStringAsync(string searchString, CancellationToken cancellationToken = default);
    }
}
