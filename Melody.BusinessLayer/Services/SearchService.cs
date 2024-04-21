using Melody.BusinessLayer.DTOs;
using Melody.BusinessLayer.Interfaces;
using Melody.BusinessLayer.Requests.Search;
using Melody.DataLayer.Infastructure;
using Melody.Services.Interfaces;

namespace Melody.BusinessLayer.Services
{
    public class SearchService : ISearchService
    {
        private readonly ITrackService _trackService;
        private readonly IDeezerApiClient _deezerApiClient;

        public SearchService(IDeezerApiClient deezerApiClient, ITrackService trackService)
        {
            _deezerApiClient = deezerApiClient;
            _trackService = trackService;
        }

        public Task<IEnumerable<DisplayableItemDto>> GetDisplayableItemsAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public async Task<dynamic> SearchApiItemsAsync(SearchItemRequest request, CancellationToken cancellationToken = default)
        {
            var response = await _deezerApiClient.SearchItemsAsync(request.SearchString, cancellationToken);
            return response;
        }

        public async Task<IEnumerable<TrackDto>> SearchDbItemsAsync(SearchItemRequest request, CancellationToken cancellationToken = default)
        {
            var tracks = await _trackService.GetBySearchStringAsync(request.SearchString, cancellationToken);
            return tracks;
        }
    }
}
