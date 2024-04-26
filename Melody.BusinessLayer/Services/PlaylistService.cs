using AutoMapper;
using Melody.BusinessLayer.DTOs;
using Melody.BusinessLayer.Interfaces;
using Melody.DataLayer.Infastructure;
using Melody.DataLayer.Models;

namespace Melody.BusinessLayer.Services
{
    public class PlaylistService : WriteService, IPlaylistService
    {
        public PlaylistService(RepositoryContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public async Task<IEnumerable<PlaylistDto>> GetBySearchStringAsync(string searchString, CancellationToken cancellationToken = default)
        {
            var playlists = await _context.Playlists.ArrayAsync(
              p => (p.Title.Contains(searchString) || p.Description.Contains(searchString)) && p.IsPublic,
              a => a.Title,
              AllIncludeProperties(),
              true,
              cancellationToken);

            return playlists.Select(_mapper.Map<PlaylistDto>);
        }

        protected override IEnumerable<string> AllIncludeProperties()
        {
            return new List<string>
            {
                $"{nameof(Playlist.Creator)}",
                $"{nameof(Playlist.Followers)}",
                $"{nameof(Playlist.PlaylistedTracks)}",
                $"{nameof(Playlist.Tags)}"
            };
        }
    }
}
