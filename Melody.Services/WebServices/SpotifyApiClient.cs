using Melody.Services.Interfaces;

namespace Melody.Services.WebServices
{
    public class SpotifyApiClient : IMusicApiClient
    {
        private readonly HttpClient _httpClient;

        public SpotifyApiClient(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("spotifyApi");
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
