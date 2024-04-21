using AutoMapper;
using Melody.DataLayer.EFCore.Entities;
using Melody.DataLayer.EFCore.Infrastructure;
using Melody.DataLayer.Infrastructure;
using Melody.DataLayer.Interfaces;
using Melody.DataLayer.Models;

namespace Melody.DataLayer.Infastructure
{
    public class AudioBookCollectionRepository : Repository<AudioBookCollection, AudioBookCollectionEntity>, IAudioBookCollectionRepository
    {
        public AudioBookCollectionRepository(MelodyDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
            
        }
        protected override Task<AudioBookCollectionEntity> PopulateEntity(AudioBookCollection entity)
        {
            throw new NotImplementedException();
        }
    }
}
