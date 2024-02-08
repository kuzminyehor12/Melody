using Melody.DataLayer.EFCore.Entities;
using Melody.DataLayer.Models;
using Melody.Shared;
using System.Linq.Expressions;

namespace Melody.DataLayer.Interfaces
{
    public interface IRepository<TModel, TEntity> : IContextable
         where TModel : BaseModel
         where TEntity : BaseEntity
    {
        public Task<IEnumerable<TModel>> ArrayAsync(
            Expression<Func<TModel, bool>> predicate, 
            IEnumerable<string>? navigationPathProperty = null, 
            CancellationToken cancellationToken = default);

        public Task<TModel> FirstAsync(
            Expression<Func<TModel, bool>> predicate,
             IEnumerable<string>? navigationPathProperty = null,
            CancellationToken cancellationToken = default);

        public Task<bool> AnyAsync(
            Expression<Func<TModel, bool>> predicate,
            IEnumerable<string>? navigationPathProperty = null,
            CancellationToken cancellationToken = default);

        public Task<Result> UpdateAsync(
            Expression<Func<TModel, bool>> predicate,
            Action<TModel> updateSelector,
            IEnumerable<string>? navigationPathProperty = null,
            CancellationToken cancellationToken = default);

        public Task<Result> CreateAsync(TModel model, CancellationToken cancellationToken = default);

        public Task<Result> DeleteAsync(
            Expression<Func<TModel, bool>> predicate,
            IEnumerable<string>? navigationPathProperty = null,
            CancellationToken cancellationToken = default);
    }
}
