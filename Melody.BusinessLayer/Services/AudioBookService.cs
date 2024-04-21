using Melody.BusinessLayer.Interfaces;
using Melody.BusinessLayer.Requests.AudioBooks;
using Melody.Shared;

namespace Melody.BusinessLayer.Services
{
    public class AudioBookService : IAudioBookService
    {
        public Task<Result> AddAsync(CreateAudioBookRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
