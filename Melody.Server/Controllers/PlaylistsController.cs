using Melody.BusinessLayer.Interfaces;
using Melody.BusinessLayer.Requests.Playlists;
using Melody.BusinessLayer.Requests.Upload;
using Melody.BusinessLayer.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;

namespace Melody.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlaylistsController : ControllerBase
    {
        private readonly IPlaylistService _playlistService;

        public PlaylistsController(IPlaylistService playlistService)
        {
            _playlistService = playlistService;
        }

        [HttpPost]
        public async Task<IActionResult> CreatePlaylist(CancellationToken cancellationToken)
        {
            var formCollection = await Request.ReadFormAsync(cancellationToken);

            var createRequest = new CreatePlaylistRequest
            {
                Data = JsonConvert.DeserializeObject<CreatePlaylistDataRequest>(formCollection["data"]),
                File = formCollection.Files.Any() ? formCollection.Files[0] : null
            };

            var result = await _playlistService.AddAsync(createRequest, cancellationToken);

            if (result.IsSuccess)
            {
                return Ok();
            }

            Debug.WriteLine(JsonConvert.SerializeObject(result.Errors));
            return BadRequest();
        }
    }
}
