using AutoMapper;
using Melody.BusinessLayer.DTOs;
using Melody.BusinessLayer.Interfaces;
using Melody.BusinessLayer.Mappings;
using Melody.BusinessLayer.Requests.Upload;
using Melody.BusinessLayer.Strategies;
using Melody.BusinessLayer.Tasks;
using Melody.BusinessLayer.Utils;
using Melody.Services.Interfaces;
using Melody.Shared;
using Melody.Shared.Enums;

namespace Melody.BusinessLayer.Services
{
    public class UploadService : IUploadService
    {
        private readonly StrategyInjector _strategyInjector;
        private readonly IFileStorageService _fileStorageService;
        private readonly ICreatorService _creatorService;
        private readonly IMapper _mapper;

        public UploadService(
            StrategyInjector strategyInjector, 
            IMapper mapper, 
            IFileStorageService fileStorageService, 
            ICreatorService creatorService)
        {
            _strategyInjector = strategyInjector;
            _mapper = mapper;
            _fileStorageService = fileStorageService;
            _creatorService = creatorService;
        }

        private IUploadStrategy _uploadStrategy;

        public async Task<Result> UploadAudioAsync(UploadAudioRequest request, CancellationToken cancellationToken)
        {
            HasCreatorDto dto = CreateDto(request);

            var creatorId = await _creatorService.GetCreatorIdByUid(request.Data.CreatorId);
            dto.CreatorId = creatorId;

            var result = await _uploadStrategy.UploadAsync(dto, cancellationToken);
            
            return await result.OnSuccess(GetUploadTask());

            Func<Task<Result>> GetUploadTask() =>
                TaskProvider.CreateUploadTask(
                    file: request.File,
                    bucketName: BucketName.Audios,
                    onNull: () => request.Data.Type == AudioType.AudiobookCollection || request.Data.Type == AudioType.Album
                    ? Result.Success()
                    : Result.Failure(),
                    fileStorageService: _fileStorageService,
                    cancellationToken
                );
        }

        private HasCreatorDto CreateDto(UploadAudioRequest request)
        {
            HasCreatorDto dto;

            switch (request.Data.Type)
            {
                case AudioType.Track:
                    _uploadStrategy = new TrackStrategy(_strategyInjector);
                    dto = _mapper.Map<TrackDto>(request);
                    break;
                case AudioType.Album:
                    _uploadStrategy = new AlbumStrategy(_strategyInjector);
                    dto = _mapper.Map<AlbumDto>(request);
                    break;
                case AudioType.Audiobook:
                    _uploadStrategy = new AudioBookStrategy(_strategyInjector);
                    dto = _mapper.Map<AudioBookDto>(request);
                    break;
                case AudioType.AudiobookCollection:
                    _uploadStrategy = new AudioBookCollectionStrategy(_strategyInjector);
                    dto = _mapper.Map<AudioBookCollectionDto>(request);
                    break;
                case AudioType.Podcast:
                    _uploadStrategy = new PodcastStrategy(_strategyInjector);
                    dto = _mapper.Map<PodcastDto>(request);
                    break;
                default:
                    _uploadStrategy = new TrackStrategy(_strategyInjector);
                    dto = _mapper.Map<TrackDto>(request);
                    break;
            }

            return dto;
        }
    }
}
