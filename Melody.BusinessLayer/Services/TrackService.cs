﻿using AutoMapper;
using Melody.BusinessLayer.DTOs;
using Melody.BusinessLayer.Interfaces;
using Melody.BusinessLayer.Requests.Tracks;
using Melody.BusinessLayer.Utils;
using Melody.DataLayer.Infastructure;
using Melody.DataLayer.Models;
using Melody.Services.Interfaces;
using Melody.Shared;
using Melody.Shared.Extensions;
using System.Linq;

namespace Melody.BusinessLayer.Services
{
    public class TrackService : WriteService, ITrackService
    {
        private readonly IFileStorageService _fileStorageService;
        public TrackService(RepositoryContext context, IMapper mapper, IFileStorageService fileStorageService) : base(context, mapper)
        {
            _fileStorageService = fileStorageService;
        }

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
                $"{nameof(Playlist.PlaylistedTracks)}"
            };

            var result = await _context.Playlists.UpdateAsync(
                p => p.Id == request.PlaylistId,
                p => p.PlaylistedTracks.Remove(trackToExclude),
                includeProperties,
                cancellationToken: cancellationToken);

            return await SaveChangesAsync(result, cancellationToken);
        }

        public async Task<IEnumerable<TrackDto>> GetByAlbumAsync(GetTrackByAlbumRequest request, CancellationToken cancellationToken = default)
        {
            var tracks = await _context.Tracks.ArrayAsync(
                t => t.AlbumId == request.AlbumId, 
                t => t.PublishedAt,
                AllIncludeProperties(), 
                true,
                cancellationToken);

            return tracks.Select(_mapper.Map<TrackDto>);
        }

        public async Task<IEnumerable<TrackDto>> GetByGenreAsync(GetTrackByGenreRequest request, CancellationToken cancellationToken = default)
        {
            var tracks = await _context.Tracks.ArrayAsync(
                t => t.Genres.Any(g => g.Id == request.GenreId), 
                t => t.PublishedAt,
                AllIncludeProperties(),
                true,
                cancellationToken);

            return tracks.Select(_mapper.Map<TrackDto>);
        }

        public async Task<IEnumerable<TrackDto>> GetByPlaylistAsync(GetTrackByPlaylistRequest request, CancellationToken cancellationToken = default)
        {
            var tracks = await _context.Tracks.ArrayAsync(
                t => t.Playlists.Any(p => p.Id == request.PlaylistId),
                t => t.PublishedAt,
                AllIncludeProperties(),
                true,
                cancellationToken);

            return tracks.Select(_mapper.Map<TrackDto>);
        }

        public async Task<IEnumerable<TrackDto>> GetBySearchStringAsync(string searchString, CancellationToken cancellationToken = default)
        {
            var tracks = await _context.Tracks.ArrayAsync(
               t => t.Title.ToLower().Contains(searchString.ToLower()) 
               || t.Author.ToLower().Contains(searchString.ToLower()) 
               || t.Album.Title.ToLower().Contains(searchString.ToLower())
               || t.Album.Description.ToLower().Contains(searchString.ToLower()),
               t => t.ListeningsCount,
               AllIncludeProperties(),
               true,
               cancellationToken);

            var dtos = tracks.Select(_mapper.Map<TrackDto>).ToList();

            foreach (var dto in dtos)
            {
                if (!string.IsNullOrEmpty(dto.Coversheet))
                {
                    dto.CoversheetUrl = await _fileStorageService.DownloadAsync(BucketName.Coversheets, dto.Coversheet);
                }

                dto.DownloadUrl = await _fileStorageService.DownloadAsync(BucketName.Audios, dto.Filename);
            }

            return dtos;
        }

        public async Task<Result> IncludeIntoPlaylistAsync(IncludeTrackIntoPlaylistRequest request, CancellationToken cancellationToken = default)
        {
            var trackToInclude = await _context.Tracks.FirstAsync(t => t.Id.ToString() == request.TrackId.ToString(), cancellationToken: cancellationToken);
            Result result = Result.Success();

            if (trackToInclude is not null)
            {
                IEnumerable<string> includeProperties = new List<string>
                {
                   $"{nameof(Playlist.PlaylistedTracks)}"
                };

                foreach (var id in request.PlaylistIds)
                {
                    result = await _context.Playlists.UpdateAsync(
                        p => p.Id.ToString() == id,
                        p => p.PlaylistedTracks.Add(trackToInclude),
                        includeProperties,
                        cancellationToken: cancellationToken
                    );
                }
            }
            else
            {
                foreach (var id in request.PlaylistIds)
                {
                    result = await _context.Playlists.UpdateAsync(
                        p => p.Id.ToString() == id,
                        p => p.ExternalIds = p.ExternalIds.Concat(new string[] { request.TrackId.ToString() }).ToArray(),
                        cancellationToken: cancellationToken
                    );
                }
            }

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
                $"{nameof(Track.Creator)}",
                $"{nameof(Track.Genres)}",
                $"{nameof(Track.Album)}",
                $"{nameof(Track.Playlists)}",
                $"{nameof(Track.Followers)}"
            };
        }
    }
}
