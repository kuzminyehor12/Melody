using Melody.BusinessLayer.Requests.Auth;
using Melody.Shared;

namespace Melody.BusinessLayer.Interfaces
{
    public interface IAuthService
    {
        Task<Result> RegisterAsync(RegisterUserRequest request, CancellationToken cancellationToken = default);
    }
}
