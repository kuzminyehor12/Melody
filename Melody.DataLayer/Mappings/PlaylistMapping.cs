using Melody.DataLayer.EFCore.Entities;
using Melody.DataLayer.Models;
using Melody.Shared;

namespace Melody.DataLayer.Mappings
{
    public class PlaylistMapping : Mapping
    {
        public PlaylistMapping() : base()
        {
            
        }
        protected override void RegisterMapping()
        {
            CreateMap<PlaylistEntity, Playlist>()
               .ReverseMap();
        }
    }
}
