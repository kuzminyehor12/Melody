using Melody.BusinessLayer.DTOs;
using Melody.Shared;

namespace Melody.BusinessLayer.Strategies
{
    public interface IUploadStrategy
    {
        Task<Result> UploadAsync(HasCreatorDto dto, CancellationToken cancellationToken);
    }
}
