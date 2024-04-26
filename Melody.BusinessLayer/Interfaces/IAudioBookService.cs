using Melody.BusinessLayer.DTOs;
using Melody.BusinessLayer.Requests.AudioBooks;
using Melody.Shared;

namespace Melody.BusinessLayer.Interfaces
{
    public interface IAudioBookService
    {
        Task<IEnumerable<AudioBookDto>> GetBySearchStringAsync(string searchString, CancellationToken cancellationToken);

        Task<Result> AddAsync(CreateAudioBookRequest request, CancellationToken cancellationToken);
    }
}
