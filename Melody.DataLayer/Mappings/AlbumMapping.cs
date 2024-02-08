using Melody.DataLayer.EFCore.Entities;
using Melody.DataLayer.Models;
using Melody.Shared;

namespace Melody.DataLayer.Mappings
{
    public class AlbumMapping : Mapping
    {
        public AlbumMapping() : base()
        {
            
        }
        protected override void RegisterMapping()
        {
            CreateMap<AlbumEntity, Album>()
               .ReverseMap();
        }
    }
}
