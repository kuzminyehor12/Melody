using Melody.BusinessLayer.Interfaces;
using Melody.BusinessLayer.Requests.AudioBookCollections;
using Melody.Shared;

namespace Melody.BusinessLayer.Services
{
    public class AudioBookCollectionService : IAudioBookCollectionService
    {
        public Task<Result> AddAsync(CreateAudioBookCollectionRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
