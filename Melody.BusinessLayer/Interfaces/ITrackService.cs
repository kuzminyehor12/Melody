using Melody.BusinessLayer.DTOs;
using Melody.BusinessLayer.Requests.Tracks;
using Melody.Shared;

namespace Melody.BusinessLayer.Interfaces
{
    public interface ITrackService
    {
        Task<IEnumerable<TrackDto>> GetByPlaylistAsync(GetTrackByPlaylistRequest request, CancellationToken cancellationToken = default);

        Task<IEnumerable<TrackDto>> GetByGenreAsync(GetTrackByGenreRequest request, CancellationToken cancellationToken = default);

        Task<IEnumerable<TrackDto>> GetByAlbumAsync(GetTrackByAlbumRequest request, CancellationToken cancellationToken = default);
        
        Task<Result> AddAsync(CreateTrackRequest request, CancellationToken cancellationToken = default);

        Task<Result> RemoveAsync(RemoveTrackRequest request, CancellationToken cancellationToken = default);

        Task<Result> IncludeIntoPlaylistAsync(IncludeTrackIntoPlaylistRequest request, CancellationToken cancellationToken = default);

        Task<Result> ExcludeFromPlaylistAsync(ExcludeTrackFromPlaylistRequest request, CancellationToken cancellationToken = default);
    }
}
