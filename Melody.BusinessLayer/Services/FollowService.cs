using AutoMapper;
using Melody.BusinessLayer.Interfaces;
using Melody.BusinessLayer.Requests.Follows;
using Melody.DataLayer.Infastructure;
using Melody.DataLayer.Models;
using Melody.Shared;

namespace Melody.BusinessLayer.Services
{
    public class FollowService : WriteService, IFollowService
    {
        public FollowService(RepositoryContext context, IMapper mapper) : base(context, mapper) { }

        public async Task<Result> FollowAlbumAsync(FollowAlbumRequest request, CancellationToken cancellationToken = default)
        {
            var includeProperties = new List<string>
            {
                $"{nameof(User.FollowedAlbums)}"
            };

            var albumToFollow = await _context.Albums.FirstAsync(a => a.Id == request.AlbumId, cancellationToken: cancellationToken);
            var result = await _context.Users.UpdateAsync(
                u => u.Id == request.FollowerId, 
                u => u.FollowedAlbums.Add(albumToFollow),
                includeProperties, 
                cancellationToken);

            return await SaveChangesAsync(result, cancellationToken);
        }

        public async Task<Result> FollowCreatorAsync(FollowCreatorRequest request, CancellationToken cancellationToken = default)
        {
            var includeProperties = new List<string>
            {
                $"{nameof(User.FollowedCreators)}"
            };

            var creatorToFollow = await _context.Creators.FirstAsync(c => c.Id == request.CreatorId, cancellationToken: cancellationToken);
            var result = await _context.Users.UpdateAsync(
                u => u.Id == request.FollowerId,
                u => u.FollowedCreators.Add(creatorToFollow),
                includeProperties,
                cancellationToken);

            return await SaveChangesAsync(result, cancellationToken);
        }

        public async Task<Result> FollowPlaylistAsync(FollowPlaylistRequest request, CancellationToken cancellationToken = default)
        {
            var includeProperties = new List<string>
            {
                $"{nameof(User.FollowedPlaylists)}"
            };

            var playlistToFollow = await _context.Playlists.FirstAsync(p => p.Id == request.PlaylistId, cancellationToken: cancellationToken);
            var result = await _context.Users.UpdateAsync(
                u => u.Id == request.FollowerId, 
                u => u.FollowedPlaylists.Add(playlistToFollow),
                includeProperties, 
                cancellationToken);

            return await SaveChangesAsync(result, cancellationToken);
        }

        public async Task<Result> FollowPodcastAsync(FollowPodcastRequest request, CancellationToken cancellationToken = default)
        {
            var includeProperties = new List<string>
            {
                $"{nameof(User.FollowedPodcasts)}"
            };

            var podcastToFollow = await _context.Podcasts.FirstAsync(p => p.Id == request.PodcastId, cancellationToken: cancellationToken);
            var result = await _context.Users.UpdateAsync(
                u => u.Id == request.FollowerId,
                u => u.FollowedPodcasts.Add(podcastToFollow),
                includeProperties,
                cancellationToken);

            return await SaveChangesAsync(result, cancellationToken);
        }

        public async Task<Result> FollowTrackAsync(FollowTrackRequest request, CancellationToken cancellationToken = default)
        {
            var includeProperties = new List<string>
            {
                $"{nameof(User.FollowedTracks)}"
            };

            var trackToFollow = await _context.Tracks.FirstAsync(t => t.Id == request.TrackId, cancellationToken: cancellationToken);
            var result = await _context.Users.UpdateAsync(
                u => u.Id == request.FollowerId,
                u => u.FollowedTracks.Add(trackToFollow),
                includeProperties,
                cancellationToken);

            return await SaveChangesAsync(result, cancellationToken);
        }

        public async Task<Result> UnfollowAlbumAsync(UnfollowAlbumRequest request, CancellationToken cancellationToken = default)
        {
            var includeProperties = new List<string>
            {
                $"{nameof(User.FollowedAlbums)}"
            };

            var albumToUnfollow = await _context.Albums.FirstAsync(a => a.Id == request.AlbumId, cancellationToken: cancellationToken);
            var result = await _context.Users.UpdateAsync(
                u => u.Id == request.FollowerId,
                u => u.FollowedAlbums.Remove(albumToUnfollow),
                includeProperties,
                cancellationToken);

            return await SaveChangesAsync(result, cancellationToken);
        }

        public async Task<Result> UnfollowCreatorAsync(UnfollowCreatorRequest request, CancellationToken cancellationToken = default)
        {
            var includeProperties = new List<string>
            {
                $"{nameof(User.FollowedCreators)}"
            };

            var creatorToUnfollow = await _context.Creators.FirstAsync(c => c.Id == request.CreatorId, cancellationToken: cancellationToken);
            var result = await _context.Users.UpdateAsync(
                u => u.Id == request.FollowerId,
                u => u.FollowedCreators.Remove(creatorToUnfollow),
                includeProperties,
                cancellationToken);

            return await SaveChangesAsync(result, cancellationToken);
        }

        public async Task<Result> UnfollowPlaylistAsync(UnfollowPlaylistRequest request, CancellationToken cancellationToken = default)
        {
            var includeProperties = new List<string>
            {
                $"{nameof(User.FollowedPlaylists)}"
            };

            var playlistToUnfollow = await _context.Playlists.FirstAsync(p => p.Id == request.PlaylistId, cancellationToken: cancellationToken);
            var result = await _context.Users.UpdateAsync(
                u => u.Id == request.FollowerId,
                u => u.FollowedPlaylists.Remove(playlistToUnfollow),
                includeProperties,
                cancellationToken);

            return await SaveChangesAsync(result, cancellationToken);
        }

        public async Task<Result> UnfollowPodcastAsync(UnfollowPodcastRequest request, CancellationToken cancellationToken = default)
        {
            var includeProperties = new List<string>
            {
                $"{nameof(User.FollowedPodcasts)}"
            };

            var podcastToUnfollow = await _context.Podcasts.FirstAsync(p => p.Id == request.PodcastId, cancellationToken: cancellationToken);
            var result = await _context.Users.UpdateAsync(
                u => u.Id == request.FollowerId,
                u => u.FollowedPodcasts.Remove(podcastToUnfollow),
                includeProperties,
                cancellationToken);

            return await SaveChangesAsync(result, cancellationToken);
        }

        public async Task<Result> UnfollowTrackAsync(UnfollowTrackRequest request, CancellationToken cancellationToken = default)
        {
            var includeProperties = new List<string>
            {
                $"{nameof(User.FollowedTracks)}"
            };

            var trackToUnfollow = await _context.Tracks.FirstAsync(t => t.Id == request.TrackId, cancellationToken: cancellationToken);
            var result = await _context.Users.UpdateAsync(
                u => u.Id == request.FollowerId,
                u => u.FollowedTracks.Remove(trackToUnfollow),
                includeProperties,
                cancellationToken);

            return await SaveChangesAsync(result, cancellationToken);
        }

        protected override IEnumerable<string> AllIncludeProperties()
        {
            return Enumerable.Empty<string>();
        }
    }
}
