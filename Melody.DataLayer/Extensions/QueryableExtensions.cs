using Melody.DataLayer.EFCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace Melody.DataLayer.Extensions
{
    public static class QueryableExtensions
    {
        public static IQueryable<T> IncludeAll<T>(this IQueryable<T> queryable, IEnumerable<string>? includes)
            where T : BaseEntity
        {
            if (includes == null || !includes.Any())
            {
                return queryable;
            }

            foreach (var include in includes)
            {
                queryable = queryable.Include(include);
            }

            return queryable;
        }
    }
}
