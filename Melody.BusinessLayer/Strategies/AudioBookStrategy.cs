using AutoMapper;
using Melody.BusinessLayer.DTOs;
using Melody.BusinessLayer.Interfaces;
using Melody.BusinessLayer.Requests.AudioBooks;
using Melody.Shared;

namespace Melody.BusinessLayer.Strategies
{
    public class AudioBookStrategy : StrategyInjectionRoot, IUploadStrategy<BaseDto>
    {
        private IAudioBookService AudioBookService => _injector.AudioBookService.Value;

        public AudioBookStrategy(StrategyInjector injector) : base(injector)
        {

        }

        public async Task<Result> UploadAsync(BaseDto dto, CancellationToken cancellationToken)
        {
            try
            {
                var audioBookDto = dto as AudioBookDto;
                var request = Mapper.Map<CreateAudioBookRequest>(audioBookDto);
                var result = await AudioBookService.AddAsync(request, cancellationToken);
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
