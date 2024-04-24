using Melody.DataLayer.EFCore.Entities;
using Melody.DataLayer.Models;
using Melody.Shared;

namespace Melody.DataLayer.Mappings
{
    public class PodcastMapping : Mapping
    {
        public PodcastMapping() : base()
        {
           
        }
        protected override void RegisterMapping()
        {
            CreateMap<PodcastEntity, Podcast>()
               .ForMember(podcast => podcast.Author, mem => mem
                   .MapFrom(entity => entity.AuthorName))
               .ReverseMap();
        }
    }
}
