using Melody.DataLayer.EFCore.Entities;
using Melody.DataLayer.Models;
using Melody.Shared;

namespace Melody.DataLayer.Mappings
{
    public class CreatorMapping : Mapping
    {
        public CreatorMapping() : base()
        {
            
        }
        protected override void RegisterMapping()
        {
            CreateMap<CreatorEntity, Creator>()
               .ReverseMap();
        }
    }
}
