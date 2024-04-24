using AutoMapper;
using Melody.BusinessLayer.Interfaces;
using Melody.BusinessLayer.Requests.AudioBookCollections;
using Melody.DataLayer.Infastructure;
using Melody.DataLayer.Models;
using Melody.Shared;

namespace Melody.BusinessLayer.Services
{
    public class AudioBookCollectionService : WriteService, IAudioBookCollectionService
    {
        public AudioBookCollectionService(RepositoryContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public async Task<Result> AddAsync(CreateAudioBookCollectionRequest request, CancellationToken cancellationToken)
        {
            var collection = _mapper.Map<AudioBookCollection>(request);
            var result = await _context.AudioBookCollections.CreateAsync(collection, cancellationToken);
            return await SaveChangesAsync(result);
        }

        protected override IEnumerable<string> AllIncludeProperties()
        {
            return Enumerable.Empty<string>();
        }
    }
}
