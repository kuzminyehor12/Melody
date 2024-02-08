using Melody.DataLayer.EFCore.Entities;
using Melody.DataLayer.Models;
using Melody.Shared;

namespace Melody.DataLayer.Mappings
{
    public class AudioBookCollectionMapping : Mapping
    {
        public AudioBookCollectionMapping() : base()
        {
            
        }
        protected override void RegisterMapping()
        {
            CreateMap<AudioBookCollectionEntity, AudioBookCollection>()
                .ReverseMap();
        }
    }
}
