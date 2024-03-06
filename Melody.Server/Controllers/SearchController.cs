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

        [HttpGet]
        public async Task<IActionResult> SearchItems(string query, CancellationToken cancellationToken = default)
        {
            var data = await _searchService.SearchItemAsync(new SearchItemRequest { SearchString = query }, cancellationToken);
            return Ok(data);
        }
    }
}
