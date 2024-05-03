using Melody.BusinessLayer.Utils;
using Microsoft.AspNetCore.Http;

namespace Melody.BusinessLayer.Requests.Playlists
{
    public class CreatePlaylistRequest
    {
        public CreatePlaylistDataRequest Data { get; set; }

        public PersistentFile? File { get; set; }
    }
}
