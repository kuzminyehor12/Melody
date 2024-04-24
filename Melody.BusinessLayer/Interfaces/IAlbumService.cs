using Melody.BusinessLayer.DTOs;
using Melody.BusinessLayer.Requests.Albums;
using Melody.Shared;

namespace Melody.BusinessLayer.Interfaces
{
    public interface IAlbumService
    {
        Task<IEnumerable<AlbumDto>> GetAlbumBySearchString(string searchString, CancellationToken cancellationToken = default);

        Task<Result> AddAsync(CreateAlbumRequest request, CancellationToken cancellationToken); 
    }
}
