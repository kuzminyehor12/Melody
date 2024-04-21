using AutoMapper;
using Melody.BusinessLayer.DTOs;
using Melody.BusinessLayer.Interfaces;
using Melody.BusinessLayer.Requests.AudioBookCollections;
using Melody.Shared;

namespace Melody.BusinessLayer.Strategies
{
    public class AudioBookCollectionStrategy : StrategyInjectionRoot, IUploadStrategy<BaseDto>
    {
        private IAudioBookCollectionService AudioBookCollectionService => _injector.AudioBookCollectionService.Value;

        public AudioBookCollectionStrategy(StrategyInjector injector) : base(injector)
        {
            
        }

        public async Task<Result> UploadAsync(BaseDto dto, CancellationToken cancellationToken)
        {
            try
            {
                var audioBookCollectionDto = dto as AudioBookCollectionDto;
                var request = Mapper.Map<CreateAudioBookCollectionRequest>(audioBookCollectionDto);
                var result = await AudioBookCollectionService.AddAsync(request, cancellationToken);
                // TODO: send to message queue to handle file upload
                return result;
            }
            catch (Exception ex)
            {
                return Result.Failure(ex);
            }
        }
    }
}
