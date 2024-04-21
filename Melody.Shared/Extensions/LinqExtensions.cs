namespace Melody.Shared.Extensions
{
    public static class LinqExtensions
    {
        public static IEnumerable<T> ForEach<T>(this IEnumerable<T> source, Action<T> action)
        {
            foreach (var item in source)
            {
                action(item);
            }

            return source;
        }

        public static async Task<IEnumerable<T>> ForEachAsync<T>(this IEnumerable<T> source, Action<T> action)
        {
            foreach (var item in source)
            {
                await Task.Run(() => action(item));
            }

            return source;
        }
    }
}
