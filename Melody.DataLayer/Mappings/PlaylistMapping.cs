using Melody.DataLayer.EFCore.Entities;
using Melody.DataLayer.Models;
using Melody.Shared;
using Melody.Shared.Enums;

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
                .ForMember(model => model.Type, mem => mem
                    .MapFrom(entity => (PlaylistType)entity.Type))
               .ReverseMap();
        }
    }
}
