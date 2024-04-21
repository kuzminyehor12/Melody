using AutoMapper;
using Melody.BusinessLayer.DTOs;
using Melody.BusinessLayer.Interfaces;
using Melody.BusinessLayer.Requests.Tracks;
using Melody.Shared;

namespace Melody.BusinessLayer.Strategies
{
    public class TrackStrategy : StrategyInjectionRoot, IUploadStrategy<BaseDto>
    {
        private ITrackService TrackService => _injector.TrackService.Value;

        public TrackStrategy(StrategyInjector injector) : base(injector)
        {
            
        }

        public async Task<Result> UploadAsync(BaseDto dto, CancellationToken cancellationToken)
        {
			try
			{
				var trackDto = dto as TrackDto;
                var request = Mapper.Map<CreateTrackRequest>(trackDto);
                var result = await TrackService.AddAsync(request, cancellationToken);
                return result;
			}
			catch (Exception ex)
			{
				return Result.Failure(ex);
			}
        }
    }
}
