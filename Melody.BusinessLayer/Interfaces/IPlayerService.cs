using Melody.BusinessLayer.Requests.Player;
using Melody.Shared;

namespace Melody.BusinessLayer.Interfaces
{
    public interface IPlayerService
    {
        Task<Result> IncrementListeningsAsync(IncrementItemListeningsRequest request, CancellationToken cancellationToken = default);
    }
}
