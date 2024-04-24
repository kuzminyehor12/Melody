using Melody.DataLayer.EFCore.Entities;
using Melody.DataLayer.Models;
using Melody.Shared;

namespace Melody.DataLayer.Mappings
{
    public class AudioBookMapping : Mapping
    {
        public AudioBookMapping() : base()
        {
            
        }
        protected override void RegisterMapping()
        {
            CreateMap<AudioBookEntity, AudioBook>()
                .ForMember(album => album.Author, mem => mem
                   .MapFrom(entity => entity.AuthorName))
                .ReverseMap();
        }
    }
}
