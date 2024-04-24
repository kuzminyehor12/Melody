using AutoMapper;
using Melody.DataLayer.EFCore.Entities;
using Melody.DataLayer.EFCore.Infrastructure;
using Melody.DataLayer.Infrastructure;
using Melody.DataLayer.Interfaces;
using Melody.DataLayer.Models;

namespace Melody.DataLayer.Infastructure
{
    public class AlbumRepository : Repository<Album, AlbumEntity>, IAlbumRepository
    {
        public AlbumRepository(MelodyDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }
        protected override Task<AlbumEntity> PopulateEntity(Album entity)
        {
            var album = _mapper.Map<AlbumEntity>(entity);
            return Task.FromResult(album);
        }
    }
}
