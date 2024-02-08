using Melody.Services.Interfaces;

namespace Melody.Services.WebServices
{
    public class DeezerApiClient : IMusicApiClient
    {
        private readonly HttpClient _httpClient;

        public DeezerApiClient(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("deezerApi");
        }

        public Task<object> GetCreatorsAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<object> GetTracksAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
