using AutoMapper;
using Melody.BusinessLayer.Requests.Auth;
using Melody.DataLayer.Infastructure;
using Melody.DataLayer.Interfaces;
using Melody.DataLayer.Models;
using Melody.Shared;

namespace Melody.BusinessLayer.Services
{
    public class AuthService : WriteService, IAuthService
    {
        public AuthService(RepositoryContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public async Task<Result> RegisterAsync(RegisterUserRequest request, CancellationToken cancellationToken = default)
        {
            var user = _mapper.Map<User>(request);
            var exists = await _context.Users.AnyAsync(u => u.Id == user.Id);

            if (!exists) 
            {
                var result = await _context.Users.CreateAsync(user, cancellationToken);
                var creator = new Creator
                {
                    Id = user.Id
                };

                result = await _context.Creators.CreateAsync(creator, cancellationToken);
                return await SaveChangesAsync(result, cancellationToken);
            }

            return Result.Success();
        }

        protected override IEnumerable<string> AllIncludeProperties()
        {
            return Enumerable.Empty<string>();
        }
    }
}
