using Microsoft.AspNetCore.Http;

namespace Melody.BusinessLayer.Requests.Playlists
{
    public class CreatePlaylistRequest
    {
        public CreatePlaylistDataRequest Data { get; set; }

        public IFormFile? File { get; set; }
    }
}
