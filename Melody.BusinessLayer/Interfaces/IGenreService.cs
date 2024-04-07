using Melody.BusinessLayer.DTOs;

namespace Melody.BusinessLayer.Interfaces
{
    public interface IGenreService
    {
        public Task<IEnumerable<GenreDto>> GetAllAsync(CancellationToken cancellationToken = default);
    }
}
