using Melody.BusinessLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Melody.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListController : ControllerBase
    {
        private readonly IGenreService _genreService;

        public ListController(IGenreService genreService)
        {
            _genreService = genreService;
        }

        [HttpGet("genres")]
        public async Task<IActionResult> GetGenres(CancellationToken cancellationToken)
        {
            var genres = await _genreService.GetAllAsync(cancellationToken);
            return Ok(genres);
        }
    }
}
