using Melody.BusinessLayer.Mappings;
using Melody.DataLayer.Infastructure;
using Melody.DataLayer.Models;

namespace Melody.BusinessLayer.Services
{
    public class CreatorService : ICreatorService
    {
        private readonly RepositoryContext _context;

        public CreatorService(RepositoryContext context)
        {
            _context = context;
        }

        public async Task<Guid> GetCreatorIdByUid(string uid, CancellationToken cancellationToken = default)
        {
            var creator = await _context.Creators.FirstAsync(c => c.User.Uid == uid, AllIncludeProperties(), cancellationToken);
            return creator.Id;
        }

        public IEnumerable<string> AllIncludeProperties()
        {
            return new List<string>
            {
                $"{nameof(Creator.User)}"
            };
        }
    }
}
