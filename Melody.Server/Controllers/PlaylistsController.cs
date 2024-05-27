using Melody.BusinessLayer.Interfaces;
using Melody.BusinessLayer.Requests.Playlists;
using Melody.BusinessLayer.Utils;
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
                File = formCollection.Files.Any() ? new PersistentFile(formCollection.Files[0]) : null
            };

            var result = await _playlistService.AddAsync(createRequest, cancellationToken);

            if (result.IsSuccess)
            {
                return Ok();
            }

            Debug.WriteLine(JsonConvert.SerializeObject(result.Errors));
            return BadRequest();
        }

        [HttpGet("followed/{uid}")]
        public async Task<IActionResult> GetFollowedPlaylists(string uid, CancellationToken cancellationToken)
        {
            var playlists = await _playlistService.GetFollowedPlaylistsByUidAsync(uid, cancellationToken);
            return Ok(playlists);
        }

        [HttpGet("created/{uid}")]
        public async Task<IActionResult> GetCreatedPlaylists(string uid, CancellationToken cancellationToken)
        {
            var playlists = await _playlistService.GetCreatedPlaylistsByUidAsync(uid, cancellationToken);
            return Ok(playlists);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetPlaylistById(string id, CancellationToken cancellationToken)
        {
            var playlist = await _playlistService.GetPlaylistByIdAsync(Guid.Parse(id), cancellationToken);
            return Ok(playlist);
        }

        [HttpGet("{id}/tracks")]
        public async Task<IActionResult> GetTracksFromPlaylist(string id, CancellationToken cancellationToken)
        {
            var tracks = await _playlistService.GetTracksByPlaylistId(Guid.Parse(id), cancellationToken);
            return Ok(tracks);
        }
    }
}
