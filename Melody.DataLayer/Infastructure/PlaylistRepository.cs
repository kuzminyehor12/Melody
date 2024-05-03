using AutoMapper;
using Melody.DataLayer.EFCore.Entities;
using Melody.DataLayer.EFCore.Infrastructure;
using Melody.DataLayer.Infrastructure;
using Melody.DataLayer.Interfaces;
using Melody.DataLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace Melody.DataLayer.Infastructure
{
    public class PlaylistRepository : Repository<Playlist, PlaylistEntity>, IPlaylistRepository
    {
        public PlaylistRepository(MelodyDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }
        protected override async Task<PlaylistEntity> PopulateEntity(Playlist model)
        {
            var entity = _mapper.Map<PlaylistEntity>(model);
            var tags = await _dbContext.Tags.Where(t => model.Tags.Select(t => t.Id).Contains(t.Id)).ToListAsync();
            entity.Tags = tags;
            return entity;
        }
    }
}
