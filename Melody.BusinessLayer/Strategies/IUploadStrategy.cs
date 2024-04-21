using Melody.BusinessLayer.DTOs;
using Melody.Shared;

namespace Melody.BusinessLayer.Strategies
{
    public interface IUploadStrategy<in TDto>
        where TDto : BaseDto
    {
        Task<Result> UploadAsync(TDto dto, CancellationToken cancellationToken);
    }
}
