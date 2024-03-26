﻿using AutoMapper;
using Melody.BusinessLayer.DTOs;
using Melody.BusinessLayer.Interfaces;
using Melody.BusinessLayer.Requests.Tracks;
using Melody.DataLayer.Infastructure;
using Melody.DataLayer.Models;
using Melody.Shared;

namespace Melody.BusinessLayer.Services
{
    public class TrackService : WriteService, ITrackService
    {
        public TrackService(RepositoryContext context, IMapper mapper) : base(context, mapper) { }

        public async Task<Result> AddAsync(CreateTrackRequest request, CancellationToken cancellationToken = default)
        {
            var track = _mapper.Map<Track>(request);
            var result = await _context.Tracks.CreateAsync(track, cancellationToken);
            return await SaveChangesAsync(result);
        }

        public async Task<Result> ExcludeFromPlaylistAsync(ExcludeTrackFromPlaylistRequest request, CancellationToken cancellationToken = default)
        {
            var trackToExclude = await _context.Tracks.FirstAsync(t => t.Id == request.TrackId, cancellationToken: cancellationToken);

            IEnumerable<string> includeProperties = new List<string>
            { 
                    $"{nameof(Playlist.Tracks)}"
            };

            var result = await _context.Playlists.UpdateAsync(
                p => p.Id == request.PlaylistId,
                p => p.Tracks.Remove(trackToExclude),
                includeProperties,
                cancellationToken: cancellationToken);

            return await SaveChangesAsync(result, cancellationToken);
        }

        public async Task<IEnumerable<TrackDto>> GetByAlbumAsync(GetTrackByAlbumRequest request, CancellationToken cancellationToken = default)
        {
            var tracks = await _context.Tracks.ArrayAsync(
                t => t.AlbumId == request.AlbumId, 
                AllIncludeProperties(), 
                cancellationToken);

            return tracks.Select(_mapper.Map<TrackDto>);
        }

        public async Task<IEnumerable<TrackDto>> GetByCreatorAsync(GetTrackByCreatorRequest request, CancellationToken cancellationToken = default)
        {
            var tracks = await _context.Tracks.ArrayAsync(
               t => t.CreatorId == request.CreatorId,
               AllIncludeProperties(),
               cancellationToken);

            return tracks.Select(_mapper.Map<TrackDto>);
        }

        public async Task<IEnumerable<TrackDto>> GetByGenreAsync(GetTrackByGenreRequest request, CancellationToken cancellationToken = default)
        {
            var tracks = await _context.Tracks.ArrayAsync(
                t => t.Genres.Any(g => g.Id == request.GenreId), 
                AllIncludeProperties(), 
                cancellationToken);

            return tracks.Select(_mapper.Map<TrackDto>);
        }

        public async Task<IEnumerable<TrackDto>> GetByPlaylistAsync(GetTrackByPlaylistRequest request, CancellationToken cancellationToken = default)
        {
            var tracks = await _context.Tracks.ArrayAsync(
                t => t.Playlists.Any(p => p.Id == request.PlaylistId),
                AllIncludeProperties(),
                cancellationToken);

            return tracks.Select(_mapper.Map<TrackDto>);
        }

        public async Task<Result> IncludeIntoPlaylistAsync(IncludeTrackIntoPlaylistRequest request, CancellationToken cancellationToken = default)
        {
            var trackToInclude = await _context.Tracks.FirstAsync(t => t.Id == request.TrackId, cancellationToken: cancellationToken);

            IEnumerable<string> includeProperties = new List<string>
            {
               $"{nameof(Playlist.Tracks)}"
            };

            var result = await _context.Playlists.UpdateAsync(
                p => p.Id == request.PlaylistId,
                p => p.Tracks.Add(trackToInclude),
                includeProperties,
                cancellationToken: cancellationToken);

            return await SaveChangesAsync(result);
        }

        public async Task<Result> RemoveAsync(RemoveTrackRequest request, CancellationToken cancellationToken = default)
        {
            var result = await _context.Tracks.DeleteAsync(t => t.Id == request.TrackId, cancellationToken: cancellationToken);
            return await SaveChangesAsync(result);
        }

        protected override IEnumerable<string> AllIncludeProperties()
        {
            return new List<string>
            {
                $"{nameof(Track.Genres)}",
                $"{nameof(Track.Album)}",
                $"{nameof(Track.Playlists)}",
                $"{nameof(Track.Creator)}",
                $"{nameof(Track.Tags)}"
            };
        }
    }
}
