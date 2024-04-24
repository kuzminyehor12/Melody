using AutoMapper;
using Melody.BusinessLayer.Interfaces;
using Melody.BusinessLayer.Requests.Albums;
using Melody.DataLayer.Infastructure;
using Melody.DataLayer.Models;
using Melody.Shared;

namespace Melody.BusinessLayer.Services
{
    public class AlbumService : WriteService, IAlbumService
    {
        public AlbumService(RepositoryContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public async Task<Result> AddAsync(CreateAlbumRequest request, CancellationToken cancellationToken)
        {
            var album = _mapper.Map<Album>(request);
            var result = await _context.Albums.CreateAsync(album, cancellationToken);
            return await SaveChangesAsync(result);
        }

        protected override IEnumerable<string> AllIncludeProperties()
        {
            return Enumerable.Empty<string>();
        }
    }
}
