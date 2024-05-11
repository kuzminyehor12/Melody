using Melody.BusinessLayer.Requests.Auth;
using Melody.DataLayer.Models;
using Melody.Shared;

namespace Melody.BusinessLayer.Mappings
{
    public class UserMapping : Mapping
    {
        public UserMapping() : base()
        {
            
        }

        protected override void RegisterMapping()
        {
            CreateMap<RegisterUserRequest, User>()
                .ForMember(u => u.UserName, mem => mem
                    .MapFrom(request => request.DisplayName))
                .ForMember(u => u.RegisteredAt, mem => mem
                    .MapFrom(_ => DateTime.UtcNow));
        }
    }
}
