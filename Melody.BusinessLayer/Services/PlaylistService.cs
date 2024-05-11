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

namespace Melody.BusinessLayer.Services
{
    public class PlaylistService : WriteService, IPlaylistService
    {
        private readonly IFileStorageService _fileStorageService;

        public PlaylistService(RepositoryContext context, IMapper mapper, IFileStorageService fileStorageService) : base(context, mapper)
        {
            _fileStorageService = fileStorageService;
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
                 $"{nameof(User.Creator)}.{nameof(Creator.Playlists)}"
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
