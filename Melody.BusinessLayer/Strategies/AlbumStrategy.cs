using AutoMapper;
using Melody.BusinessLayer.DTOs;
using Melody.BusinessLayer.Interfaces;
using Melody.BusinessLayer.Requests.Albums;
using Melody.Shared;

namespace Melody.BusinessLayer.Strategies
{
    public class AlbumStrategy : StrategyInjectionRoot, IUploadStrategy
    {
        private IAlbumService AlbumService => _injector.AlbumService.Value;

        public AlbumStrategy(StrategyInjector injector) : base(injector)
        {
            
        }

        public async Task<Result> UploadAsync(HasCreatorDto dto, CancellationToken cancellationToken)
        {
            try
            {
                var albumDto = dto as AlbumDto;
                var request = Mapper.Map<CreateAlbumRequest>(albumDto);
                var result = await AlbumService.AddAsync(request, cancellationToken);
                return result;
            }
            catch (Exception ex)
            {

                return Result.Failure(ex);
            }
        }
    }
}
