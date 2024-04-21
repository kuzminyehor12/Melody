using Melody.BusinessLayer.Interfaces;
using Melody.BusinessLayer.Requests.Search;
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
        public async Task<IActionResult> SearchDbItems(string query, CancellationToken cancellationToken = default)
        {
            var tracks = await _searchService.SearchDbItemsAsync(new SearchItemRequest { SearchString = query }, cancellationToken);
            return Ok(tracks);
        }
    }
}
