using Melody.DataLayer.EFCore.Entities;
using Melody.DataLayer.Models;
using Melody.Shared;

namespace Melody.DataLayer.Mappings
{
    public class TopicMapping : Mapping
    {
        public TopicMapping() : base()
        {
            
        }
        protected override void RegisterMapping()
        {
            CreateMap<TopicEntity, Topic>()
               .ReverseMap();
        }
    }
}
