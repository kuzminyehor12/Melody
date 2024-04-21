using AutoMapper;
using Melody.DataLayer.EFCore.Entities;
using Melody.DataLayer.EFCore.Infrastructure;
using Melody.DataLayer.Infrastructure;
using Melody.DataLayer.Interfaces;
using Melody.DataLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace Melody.DataLayer.Infastructure
{
    public class TrackRepository : Repository<Track, TrackEntity>, ITrackRepository
    {
        public TrackRepository(MelodyDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        protected override async Task<TrackEntity> PopulateEntity(Track model)
        {
            var entity = _mapper.Map<TrackEntity>(model);
            var genres = await _dbContext.Genres.Where(g => model.Genres.Select(g => g.Id).Contains(g.Id)).ToListAsync();
            entity.Genres = genres;
            return entity;
        }
    }
}
