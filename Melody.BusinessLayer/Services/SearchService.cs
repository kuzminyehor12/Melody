using Melody.BusinessLayer.DTOs;
using Melody.BusinessLayer.Interfaces;
using Melody.BusinessLayer.Requests.Search;
using Melody.DataLayer.Infastructure;
using Melody.Services.Interfaces;

namespace Melody.BusinessLayer.Services
{
    public class SearchService : ISearchService
    {
        private readonly IDeezerApiClient _deezerApiClient;

        public SearchService(IDeezerApiClient deezerApiClient)
        {
            _deezerApiClient = deezerApiClient;
        }

        public Task<IEnumerable<DisplayableItemDto>> GetDisplayableItemsAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public async Task<dynamic> SearchItemAsync(SearchItemRequest request, CancellationToken cancellationToken = default)
        {
            var response = await _deezerApiClient.SearchItemsAsync(request.SearchString, cancellationToken);
            return response;
        }
    }
}
