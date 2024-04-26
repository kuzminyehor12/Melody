using Melody.BusinessLayer.Interfaces;
using Melody.BusinessLayer.Requests.Search;
using Melody.Shared.Enums;
using Microsoft.AspNetCore.Mvc;

namespace Melody.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly ISearchService _searchService;

        public SearchController(ISearchService searchService)
        {
            _searchService = searchService;
        }

        [HttpGet("api")]
        public async Task<IActionResult> SearchApiItems(string query, CancellationToken cancellationToken = default)
        {
            var data = await _searchService.SearchApiItemsAsync(new SearchItemRequest { SearchString = query }, cancellationToken);
            return Ok(data);
        }

        [HttpGet("db")]
        public async Task<IActionResult> SearchDbItems(string query, SearchType type, CancellationToken cancellationToken = default)
        {
            var items = await _searchService.SearchDbItemsAsync(new SearchItemRequest { SearchString = query, Type = type }, cancellationToken);
            return Ok(items);
        }

        [HttpGet("collection")]
        public async Task<IActionResult> SearchCollectionDbItems(string query, SearchType collectionType, CancellationToken cancellationToken = default)
        {
            var items = await _searchService.SearchCollectionDbItemAsync(new SearchItemRequest { SearchString = query, Type = collectionType }, cancellationToken);
            return Ok(items);
        }
    }
}
