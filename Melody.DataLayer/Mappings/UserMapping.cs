using Melody.DataLayer.EFCore.Entities;
using Melody.DataLayer.Models;
using Melody.Shared;

namespace Melody.DataLayer.Mappings
{
    public class UserMapping : Mapping
    {
        public UserMapping() : base()
        {
            
        }
        protected override void RegisterMapping()
        {
            CreateMap<UserEntity, User>()
               .ReverseMap();
        }
    }
}
