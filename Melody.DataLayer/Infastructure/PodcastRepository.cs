using AutoMapper;
using Melody.DataLayer.EFCore.Entities;
using Melody.DataLayer.EFCore.Infrastructure;
using Melody.DataLayer.Infrastructure;
using Melody.DataLayer.Interfaces;
using Melody.DataLayer.Models;

namespace Melody.DataLayer.Infastructure
{
    public class PodcastRepository : Repository<Podcast, PodcastEntity>, IPodcastRepository
    {
        public PodcastRepository(MelodyDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        protected override Task<PodcastEntity> PopulateEntity(Podcast entity)
        {
            throw new NotImplementedException();
        }
    }
}
