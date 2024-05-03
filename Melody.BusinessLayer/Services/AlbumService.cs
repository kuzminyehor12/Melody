using AutoMapper;
using Melody.BusinessLayer.DTOs;
using Melody.BusinessLayer.Interfaces;
using Melody.BusinessLayer.Requests.Albums;
using Melody.BusinessLayer.Utils;
using Melody.DataLayer.Infastructure;
using Melody.DataLayer.Models;
using Melody.Services.Interfaces;
using Melody.Shared;

namespace Melody.BusinessLayer.Services
{
    public class AlbumService : WriteService, IAlbumService
    {
        private readonly IFileStorageService _fileStorageService;
        public AlbumService(RepositoryContext context, IMapper mapper, IFileStorageService fileStorageService) : base(context, mapper)
        {
            _fileStorageService = fileStorageService;
        }

        public async Task<Result> AddAsync(CreateAlbumRequest request, CancellationToken cancellationToken)
        {
            var album = _mapper.Map<Album>(request);
            var result = await _context.Albums.CreateAsync(album, cancellationToken);
            return await SaveChangesAsync(result);
        }

        public async Task<IEnumerable<AlbumDto>> GetBySearchStringAsync(string searchString, CancellationToken cancellationToken = default)
        {
            var albums = await _context.Albums.ArrayAsync(
               a => a.Author.ToLower().Contains(searchString.ToLower()) 
               || a.Title.ToLower().Contains(searchString.ToLower()) 
               || a.Description.ToLower().Contains(searchString.ToLower()),
               a => a.Followers.Count(),
               AllIncludeProperties(),
               true,
               cancellationToken);

            var dtos = albums.Select(_mapper.Map<AlbumDto>).ToList();

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
                $"{nameof(Album.AlbumedTracks)}",
                $"{nameof(Album.Creator)}",
                $"{nameof(Album.Followers)}"
            };
        }
    }
}
