using AutoMapper;
using Melody.DataLayer.EFCore.Entities;
using Melody.DataLayer.EFCore.Infrastructure;
using Melody.DataLayer.Infrastructure;
using Melody.DataLayer.Interfaces;
using Melody.DataLayer.Models;

namespace Melody.DataLayer.Infastructure
{
    public class PlaylistRepository : Repository<Playlist, PlaylistEntity>, IPlaylistRepository
    {
        public PlaylistRepository(MelodyDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }
    }
}
