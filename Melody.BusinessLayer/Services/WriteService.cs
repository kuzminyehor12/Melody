using AutoMapper;
using Melody.DataLayer.Infastructure;
using Melody.Shared;

namespace Melody.BusinessLayer.Services
{
    public abstract class WriteService
    {
        protected readonly RepositoryContext _context;
        protected readonly IMapper _mapper;

        protected WriteService(RepositoryContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        protected async Task<Result> SaveChangesAsync(Result result, CancellationToken cancellationToken = default)
        {
            if (result.IsSuccess)
            {
                try
                {
                    await _context.SaveChangesAsync(cancellationToken);
                    return Result.Success();
                }
                catch (Exception ex)
                {
                    return Result.Failure(ex);
                }
            }

            return result;
        }

        protected abstract IEnumerable<string> AllIncludeProperties();
    }
}
