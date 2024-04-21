using AutoMapper;
using Melody.BusinessLayer.DTOs;
using Melody.BusinessLayer.Interfaces;
using Melody.BusinessLayer.Requests.Podcasts;
using Melody.Shared;

namespace Melody.BusinessLayer.Strategies
{
    public class PodcastStrategy : StrategyInjectionRoot, IUploadStrategy<BaseDto>
    {
        private IPodcastService PodcastService => _injector.PodcastService.Value;
        public PodcastStrategy(StrategyInjector injector) : base(injector)
        {
        }

        public async Task<Result> UploadAsync(BaseDto dto, CancellationToken cancellationToken)
        {
			try
			{
                var podcastDto = dto as PodcastDto;
                var request = Mapper.Map<CreatePodcastRequest>(podcastDto);
                var result = await PodcastService.AddAsync(request, cancellationToken);
                return result;
			}
			catch (Exception ex)
			{
				return Result.Failure(ex);
			}
        }
    }
}
