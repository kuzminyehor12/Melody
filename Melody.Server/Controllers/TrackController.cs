using Melody.BusinessLayer.Interfaces;
using Melody.BusinessLayer.Requests.Tracks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Melody.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrackController : ControllerBase
    {
        private readonly ITrackService _trackService;

        public TrackController(ITrackService trackService)
        {
            _trackService = trackService;
        }

        [HttpPost("include")]
        public async Task<IActionResult> IncludeTrackIntoPlaylist(IncludeTrackIntoPlaylistRequest request, CancellationToken cancellationToken)
        {
            var result = await _trackService.IncludeIntoPlaylistAsync(request, cancellationToken);

            if (result.IsFailure)
            {
                return BadRequest(result);
            }

            return Ok(result);
        }
    }
}
