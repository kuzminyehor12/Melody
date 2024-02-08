using AutoMapper;
using Melody.DataLayer.EFCore.Entities;
using Melody.DataLayer.EFCore.Infrastructure;
using Melody.DataLayer.Extensions;
using Melody.DataLayer.Interfaces;
using Melody.DataLayer.Models;
using Melody.Shared;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Melody.DataLayer.Infrastructure
{
    public class Repository<TModel, TEntity> : IRepository<TModel, TEntity>
         where TModel : BaseModel
         where TEntity : BaseEntity
    {
        private MelodyDbContext _dbContext;
        private readonly IMapper _mapper;

        public Repository(MelodyDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<bool> AnyAsync(
            Expression<Func<TModel, bool>> predicate,
            IEnumerable<string>? navigationPathProperty = null, 
            CancellationToken cancellationToken = default)
        {
            return await All()
                .IncludeAll(navigationPathProperty)
                .AnyAsync(MapExpression(predicate), cancellationToken);
        }

        public async Task<IEnumerable<TModel>> ArrayAsync(
            Expression<Func<TModel, bool>> predicate,
            IEnumerable<string>? navigationPathProperty = null,
            CancellationToken cancellationToken = default)
        {
            var entities = await All()
                .Where(MapExpression(predicate))
                .IncludeAll(navigationPathProperty)
                .ToListAsync(cancellationToken);
            return _mapper.Map<IEnumerable<TModel>>(entities);
        }

        public void AttachContext(DbContext dbContext)
        {
            if (dbContext is MelodyDbContext melodyDbContext)
            {
                _dbContext = melodyDbContext;
            }
        }

        public async Task<Result> CreateAsync(TModel model, CancellationToken cancellationToken = default)
        {
            try
            {
                var entity = _mapper.Map<TEntity>(model);
                var entry = await _dbContext.AddAsync(entity, cancellationToken);
                return Result.Success(entry.Entity.Id, nameof(CreateAsync));
            }
            catch (Exception ex)
            {
                return Result.Failure(ex);
            }
        }

        public async Task<Result> DeleteAsync(
            Expression<Func<TModel, bool>> predicate,
            IEnumerable<string>? navigationPathProperty = null,
            CancellationToken cancellationToken = default)
        {
            try
            {
                var model = await FirstAsync(predicate, navigationPathProperty, cancellationToken);
                var entity = _mapper.Map<TEntity>(model);
                var entry = _dbContext.Remove(entity);
                return Result.Success(entry.Entity.Id, nameof(DeleteAsync));
            }
            catch (Exception ex)
            {
                return Result.Failure(ex);
            }
        }

        public async Task<TModel> FirstAsync(
            Expression<Func<TModel, bool>> predicate,
            IEnumerable<string>? navigationPathProperty = null,
            CancellationToken cancellationToken = default)
        {
            var entity = await All().IncludeAll(navigationPathProperty).FirstAsync(MapExpression(predicate), cancellationToken);
            return _mapper.Map<TModel>(entity);
        }

        public async Task<Result> UpdateAsync(
            Expression<Func<TModel, bool>> predicate,
            Action<TModel> updateSelector,
            IEnumerable<string>? navigationPathProperty = null,
            CancellationToken cancellationToken = default)
        {
            try
            {
                var model = await FirstAsync(predicate, navigationPathProperty, cancellationToken);
                updateSelector(model);
                var entity = _mapper.Map<TEntity>(model);
                var entry = _dbContext.Update(entity);
                return Result.Success(entry.Entity.Id, nameof(UpdateAsync));
            }
            catch (Exception ex)
            {
                return Result.Failure(ex);
            }
        }

        private IQueryable<TEntity> All()
        {
            return _dbContext.Set<TEntity>().Where(e => !e.IsDeleted);
        }

        private Expression<Func<TEntity, bool>> MapExpression(Expression<Func<TModel, bool>> predicate)
        {
            return _mapper.Map<Expression<Func<TEntity, bool>>>(predicate);
        }
    }
}
