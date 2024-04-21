using Melody.BusinessLayer.Interfaces;
using Melody.BusinessLayer.Requests.Albums;
using Melody.Shared;

namespace Melody.BusinessLayer.Services
{
    public class AlbumService : IAlbumService
    {
        public Task<Result> AddAsync(CreateAlbumRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
