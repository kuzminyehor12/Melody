using Melody.BusinessLayer.DTOs;
using Melody.DataLayer.Models;
using Melody.Shared;

namespace Melody.BusinessLayer.Mappings
{
    public class GenreMapping : Mapping
    {
        public GenreMapping() : base()
        {

        }
        protected override void RegisterMapping()
        {
            CreateMap<Genre, GenreDto>()
               .ReverseMap();
        }
    }
}
