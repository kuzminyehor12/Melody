using AutoMapper;
using Melody.DataLayer.EFCore.Entities;
using Melody.DataLayer.EFCore.Infrastructure;
using Melody.DataLayer.Infrastructure;
using Melody.DataLayer.Interfaces;
using Melody.DataLayer.Models;

namespace Melody.DataLayer.Infastructure
{
    public class CreatorRepository : Repository<Creator, CreatorEntity>, ICreatorRepository
    {
        public CreatorRepository(MelodyDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }
        protected override Task<CreatorEntity> PopulateEntity(Creator model)
        {
            var entity = _mapper.Map<CreatorEntity>(model);
            return Task.FromResult(entity);
        }
    }
}
