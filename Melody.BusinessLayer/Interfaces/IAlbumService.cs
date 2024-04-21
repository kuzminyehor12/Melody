using Melody.BusinessLayer.Requests.Albums;
using Melody.Shared;

namespace Melody.BusinessLayer.Interfaces
{
    public interface IAlbumService
    {
        Task<Result> AddAsync(CreateAlbumRequest request, CancellationToken cancellationToken); 
    }
}
