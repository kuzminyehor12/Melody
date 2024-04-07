using AutoMapper;
using Melody.BusinessLayer.DTOs;
using Melody.BusinessLayer.Interfaces;
using Melody.DataLayer.Infastructure;

namespace Melody.BusinessLayer.Services
{
    public class GenreService : IGenreService
    {
        private readonly RepositoryContext _context;
        private readonly IMapper _mapper;

        public GenreService(RepositoryContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GenreDto>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            var genres = await _context.Genres.ArrayAsync(keySelector: g => g.DisplayName);
            return genres.Select(_mapper.Map<GenreDto>);
        }
    }
}
