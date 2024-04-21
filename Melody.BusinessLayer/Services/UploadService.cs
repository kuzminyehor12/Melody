using AutoMapper;
using Melody.BusinessLayer.DTOs;
using Melody.BusinessLayer.Interfaces;
using Melody.BusinessLayer.Requests.Upload;
using Melody.BusinessLayer.Strategies;
using Melody.Shared;
using Melody.Shared.Enums;

namespace Melody.BusinessLayer.Services
{
    public class UploadService : IUploadService
    {
        private readonly StrategyInjector _strategyInjector;
        private readonly IMapper _mapper;

        public UploadService(StrategyInjector strategyInjector, IMapper mapper)
        {
            _strategyInjector = strategyInjector;
            _mapper = mapper;
        }

        private IUploadStrategy<BaseDto> _uploadStrategy;

        public async Task<Result> UploadAudioAsync(UploadAudioRequest request, CancellationToken cancellationToken)
        {
            BaseDto dto = CreateDto(request);
            var result = await _uploadStrategy.UploadAsync(dto, cancellationToken);

            // TODO: upload file to file storage if file is not null

            return result;
        }

        private BaseDto CreateDto(UploadAudioRequest request)
        {
            BaseDto dto;

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
