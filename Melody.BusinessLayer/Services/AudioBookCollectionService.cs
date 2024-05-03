using AutoMapper;
using Melody.BusinessLayer.DTOs;
using Melody.BusinessLayer.Interfaces;
using Melody.BusinessLayer.Requests.AudioBookCollections;
using Melody.BusinessLayer.Utils;
using Melody.DataLayer.Infastructure;
using Melody.DataLayer.Models;
using Melody.Services.Interfaces;
using Melody.Shared;

namespace Melody.BusinessLayer.Services
{
    public class AudioBookCollectionService : WriteService, IAudioBookCollectionService
    {
        private readonly IFileStorageService _fileStorageService;
        public AudioBookCollectionService(RepositoryContext context, IMapper mapper, IFileStorageService fileStorageService) : base(context, mapper)
        {
            _fileStorageService = fileStorageService;
        }

        public async Task<Result> AddAsync(CreateAudioBookCollectionRequest request, CancellationToken cancellationToken)
        {
            var collection = _mapper.Map<AudioBookCollection>(request);
            var result = await _context.AudioBookCollections.CreateAsync(collection, cancellationToken);
            return await SaveChangesAsync(result);
        }

        public async Task<IEnumerable<AudioBookCollectionDto>> GetBySearchStringAsync(string searchString, CancellationToken cancellationToken = default)
        {
            var collections = await _context.AudioBookCollections.ArrayAsync(
              abc => abc.Title.ToLower().Contains(searchString.ToLower())
              || abc.Description.ToLower().Contains(searchString.ToLower()),
              t => t.Followers.Count(),
              AllIncludeProperties(),
              true,
              cancellationToken);

            var dtos = collections.Select(_mapper.Map<AudioBookCollectionDto>).ToList();

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
                $"{nameof(AudioBookCollection.AudioBooks)}",
                $"{nameof(AudioBookCollection.Creator)}",
                $"{nameof(AudioBookCollection.Followers)}"
            };
        }
    }
}
