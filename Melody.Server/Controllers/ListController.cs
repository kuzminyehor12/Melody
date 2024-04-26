using Melody.BusinessLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Melody.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListController : ControllerBase
    {
        private readonly IGenreService _genreService;
        private readonly IAlbumService _albumService;

        public ListController(IAlbumService albumService, IGenreService genreService)
        {
            _albumService = albumService;
            _genreService = genreService;
        }

        [HttpGet("genres")]
        public async Task<IActionResult> GetGenres(CancellationToken cancellationToken)
        {
            var genres = await _genreService.GetAllAsync(cancellationToken);
            return Ok(genres);
        }

        [HttpGet("albums")]
        public async Task<IActionResult> GetAlbums(string q, CancellationToken cancellationToken)
        {
            var albums = await _albumService.GetBySearchStringAsync(q, cancellationToken);
            return Ok(albums);
        }
    }
}
