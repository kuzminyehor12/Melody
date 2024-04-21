using Melody.BusinessLayer.Requests.AudioBooks;
using Melody.Shared;

namespace Melody.BusinessLayer.Interfaces
{
    public interface IAudioBookService
    {
        Task<Result> AddAsync(CreateAudioBookRequest request, CancellationToken cancellationToken);
    }
}
