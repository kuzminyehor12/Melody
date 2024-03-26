using Melody.DataLayer.EFCore.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Linq.Expressions;

namespace Melody.DataLayer.EFCore.Extensions
{
    public static class EntityTypeBuilderExtensions
    {
        public static EntityTypeBuilder<TEntity> HasId<TEntity>(this EntityTypeBuilder<TEntity> entityTypeBuilder)
            where TEntity : BaseEntity
        {
            entityTypeBuilder.HasKey(e => e.Id);
            return entityTypeBuilder;
        }

        public static EntityTypeBuilder<TEntity> HasManyToMany<TEntity, TDependent>(
            this EntityTypeBuilder<TEntity> entityTypeBuilder,
            Expression<Func<TEntity, IEnumerable<TDependent>?>>? navigateExpression = null,
            Expression<Func<TDependent, IEnumerable<TEntity>?>>? navigateExpressionDependent = null,
            string tableName = "")
            where TEntity : BaseEntity
            where TDependent : BaseEntity
        {
            if (navigateExpression is null || navigateExpressionDependent is null)
            {
                return entityTypeBuilder;
            }

            var relationBuilder = entityTypeBuilder
                .HasMany(navigateExpression)
                .WithMany(navigateExpressionDependent);

            if (!string.IsNullOrEmpty(tableName))
            {
                relationBuilder.UsingEntity(tableName);
            }

            return entityTypeBuilder;
        }

        public static EntityTypeBuilder<TEntity> HasOneToMany<TEntity, TDependent>(
            this EntityTypeBuilder<TEntity> entityTypeBuilder,
            Expression<Func<TEntity, TDependent?>>? navigateExpression = null,
            Expression<Func<TDependent, IEnumerable<TEntity>?>>? navigateExpressionDependent = null,
            Expression<Func<TEntity, object>?>? foreignKeyExpression = null, 
            bool required = false)
            where TEntity : BaseEntity
            where TDependent : BaseEntity
        {
            if (navigateExpression is null || navigateExpressionDependent is null)
            {
                return entityTypeBuilder;
            }

            var relationBuilder = entityTypeBuilder
                .HasOne(navigateExpression)
                .WithMany(navigateExpressionDependent);

            if (required)
            {
                relationBuilder.IsRequired();
            }

            if (foreignKeyExpression is not null)
            {
                relationBuilder.HasForeignKey(foreignKeyExpression);
            }

            return entityTypeBuilder;
        }

        public static EntityTypeBuilder<TEntity> HasManyToOne<TEntity, TDependent>(
            this EntityTypeBuilder<TEntity> entityTypeBuilder,
            Expression<Func<TEntity, IEnumerable<TDependent>?>>? navigateExpression = null,
            Expression<Func<TDependent, TEntity>>? navigateExpressionDependent = null,
            Expression<Func<TDependent, object>?>? foreignKeyExpression = null,
            bool required = false)
            where TEntity : BaseEntity
            where TDependent : BaseEntity
        {
            if (navigateExpression is null || navigateExpressionDependent is null)
            {
                return entityTypeBuilder;
            }

            var relationBuilder = entityTypeBuilder
                .HasMany(navigateExpression)
                .WithOne(navigateExpressionDependent);

            if (required)
            {
                relationBuilder.IsRequired();
            }

            if (foreignKeyExpression is not null)
            {
                relationBuilder.HasForeignKey(foreignKeyExpression);
            }

            return entityTypeBuilder;
        }

        public static EntityTypeBuilder<TEntity> HasOneToOne<TEntity, TDependent>(
            this EntityTypeBuilder<TEntity> entityTypeBuilder,
            Expression<Func<TEntity, TDependent?>>? navigateExpression = null,
            Expression<Func<TDependent, TEntity?>>? navigateExpressionDependent = null,
            bool required = false)
            where TEntity : BaseEntity
            where TDependent : BaseEntity
        {
            if (navigateExpression is null || navigateExpressionDependent is null)
            {
                return entityTypeBuilder;
            }

            var relationBuilder = entityTypeBuilder
                .HasOne(navigateExpression)
                .WithOne(navigateExpressionDependent)
                .HasForeignKey<TEntity>(e => e.Id);

            if (required)
            {
                relationBuilder.IsRequired();
            }

            return entityTypeBuilder;
        }
    }
}
