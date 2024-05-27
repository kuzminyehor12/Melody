using AutoMapper;
using Melody.BusinessLayer.DTOs;
using Melody.BusinessLayer.Interfaces;
using Melody.BusinessLayer.Requests.Playlists;
using Melody.BusinessLayer.Tasks;
using Melody.BusinessLayer.Utils;
using Melody.DataLayer.Infastructure;
using Melody.DataLayer.Models;
using Melody.Services.Interfaces;
using Melody.Shared;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace Melody.BusinessLayer.Services
{
    public class PlaylistService : WriteService, IPlaylistService
    {
        private readonly IFileStorageService _fileStorageService;
        private readonly IDeezerApiClient _deezerApiClient;

        public PlaylistService(
            RepositoryContext context, 
            IMapper mapper, 
            IFileStorageService fileStorageService, 
            IDeezerApiClient deezerApiClient) : base(context, mapper)
        {
            _fileStorageService = fileStorageService;
            _deezerApiClient = deezerApiClient;
        }

        public async Task<Result> AddAsync(CreatePlaylistRequest request, CancellationToken cancellationToken = default)
        {
            var playlist = _mapper.Map<Playlist>(request);
            var result = await _context.Playlists.CreateAsync(playlist, cancellationToken);
            result = await result.OnSuccess(() => SaveChangesAsync(result));
            return await result.OnSuccess(GetUploadTask());

            Func<Task<Result>> GetUploadTask() => 
                TaskProvider.CreateUploadTask(
                    file: request.File,
                    bucketName: BucketName.Coversheets,
                    onNull: () => Result.Success(),
                    fileStorageService: _fileStorageService,
                    cancellationToken
                );
        }

        public async Task<IEnumerable<PlaylistDto>> GetBySearchStringAsync(string searchString, CancellationToken cancellationToken = default)
        {
            var playlists = await _context.Playlists.ArrayAsync(
              p => (p.Title.ToLower().Contains(searchString.ToLower()) 
              || p.Description.ToLower().Contains(searchString.ToLower())) 
              && p.IsPublic,
              a => a.Followers.Count(),
              AllIncludeProperties(),
              true,
              cancellationToken);

            var dtos = playlists.Select(_mapper.Map<PlaylistDto>).ToList();

            foreach (var dto in dtos)
            {
                if (!string.IsNullOrEmpty(dto.Coversheet))
                {
                    dto.CoversheetUrl = await _fileStorageService.DownloadAsync(BucketName.Coversheets, dto.Coversheet);
                }
            }

            return dtos;
        }

        public async Task<IEnumerable<PlaylistDto>> GetCreatedPlaylistsByUidAsync(string uid, CancellationToken cancellationToken = default)
        {
            var navigationProperties = new List<string>
            {
                 $"{nameof(User.Creator)}",
                 $"{nameof(User.Creator)}.{nameof(Creator.Playlists)}",
                 $"{nameof(User.Creator)}.{nameof(Creator.Playlists)}.{nameof(Playlist.PlaylistedTracks)}",
            };

            var user = await _context.Users.FirstAsync(u => u.Uid == uid, navigationProperties, cancellationToken);
            var dtos = user.Creator.Playlists.Select(_mapper.Map<PlaylistDto>).ToList();

            foreach (var dto in dtos)
            {
                if (!string.IsNullOrEmpty(dto.Coversheet))
                {
                    dto.CoversheetUrl = await _fileStorageService.DownloadAsync(BucketName.Coversheets, dto.Coversheet);
                }
            }

            return dtos;
        }

        public async Task<IEnumerable<PlaylistDto>> GetFollowedPlaylistsByUidAsync(string uid, CancellationToken cancellationToken = default)
        {
            var navigationProperties = new List<string>
            {
                 $"{nameof(User.FollowedPlaylists)}",
            };

            var user = await _context.Users.FirstAsync(u => u.Uid == uid, navigationProperties, cancellationToken);
            var dtos = user.FollowedPlaylists.Select(_mapper.Map<PlaylistDto>).ToList();

            foreach (var dto in dtos)
            {
                if (!string.IsNullOrEmpty(dto.Coversheet))
                {
                    dto.CoversheetUrl = await _fileStorageService.DownloadAsync(BucketName.Coversheets, dto.Coversheet);
                }
            }

            return dtos;
        }

        public async Task<PlaylistDto> GetPlaylistByIdAsync(Guid playlistId, CancellationToken cancellationToken = default)
        {
            var navigationProperties = new List<string>
            {
                 $"{nameof(Playlist.Creator)}",
                 $"{nameof(Playlist.Creator)}.{nameof(Creator.User)}",
            };

            var playlist = await _context.Playlists.FirstAsync(p => p.Id == playlistId, navigationPathProperty: navigationProperties, cancellationToken: cancellationToken);

            var dto = _mapper.Map<PlaylistDto>(playlist);

            if (!string.IsNullOrEmpty(dto.Coversheet))
            {
                dto.CoversheetUrl = await _fileStorageService.DownloadAsync(BucketName.Coversheets, dto.Coversheet);
            }

            return dto;
        }

        public async Task<IEnumerable<AudioItemDto>> GetTracksByPlaylistId(Guid playlistId, CancellationToken cancellationToken = default)
        {
            var navigationProperties = new List<string>
            {
                 $"{nameof(Track.Playlists)}",
                 $"{nameof(Track.Album)}",
            };

            var dbAudios = await _context.Tracks.ArrayAsync(
                t => t.Playlists.Select(t => t.Id).Contains(playlistId), 
                t => t.Id,
                navigationProperties,
                cancellationToken: cancellationToken);

            var playlist = await _context.Playlists.FirstAsync(p => p.Id == playlistId, cancellationToken: cancellationToken);
            var apiAudios = new List<AudioItemDto>();

            foreach (var id in playlist.ExternalIds)
            {
                var response = await _deezerApiClient.GetTrackByIdAsync(id, cancellationToken);
                var audio = JsonSerializer.Deserialize<JsonNode>(response);
                apiAudios.Add(new AudioItemDto
                {
                    ExternalId = audio["id"].GetValue<int>().ToString(),
                    Title = audio["title"].GetValue<string>(),
                    DownloadUrl = audio["preview"].GetValue<string>(),
                    Author = audio["artist"]["name"].GetValue<string>(),
                    CoversheetUrl = audio["album"]["cover_small"].GetValue<string>(),
                    DurationInMs = audio["duration"].GetValue<double>()
                });
            }

            var dbDtos = dbAudios.Select(_mapper.Map<TrackDto>).ToList();

            foreach (var dto in dbDtos)
            {
                if (!string.IsNullOrEmpty(dto.Coversheet))
                {
                    dto.CoversheetUrl = await _fileStorageService.DownloadAsync(BucketName.Coversheets, dto.Coversheet);
                }

                dto.DownloadUrl = await _fileStorageService.DownloadAsync(BucketName.Audios, dto.Filename);
            }

            return dbDtos.Concat(apiAudios).OrderBy(a => a.Title);
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
