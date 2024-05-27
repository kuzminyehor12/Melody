using Refit;

namespace Melody.Services.Interfaces
{
    public interface IDeezerApiClient
    {
        [Get("/search")]
        [Headers("X-RapidAPI-Key", "X-RapidAPI-Host")]
        Task<dynamic> SearchItemsAsync(string q, CancellationToken cancellationToken = default);

        [Get("/track/{id}")]
        [Headers("X-RapidAPI-Key", "X-RapidAPI-Host")]
        Task<dynamic> GetTrackByIdAsync([AliasAs("id")] string id, CancellationToken cancellationToken = default);
    }
}
