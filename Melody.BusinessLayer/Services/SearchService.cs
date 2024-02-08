using Melody.BusinessLayer.DTOs;
using Melody.BusinessLayer.Interfaces;
using Melody.BusinessLayer.Requests.Search;
using Melody.DataLayer.Infastructure;
using Melody.Services.Interfaces;

namespace Melody.BusinessLayer.Services
{
    public class SearchService : ISearchService
    {
        private readonly RepositoryContext _context;
        private readonly IMusicApiClient _apiClient;

        public SearchService(RepositoryContext context, IMusicApiClient apiClient)
        {
            _context = context;
            _apiClient = apiClient;
        }

        public Task<IEnumerable<DisplayableItemDto>> GetDisplayableItemsAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<BaseDto>> SearchItemAsync(SearchItemRequest request, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
