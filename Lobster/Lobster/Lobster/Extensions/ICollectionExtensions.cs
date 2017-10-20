using System.Collections.Generic;

namespace Lobster.Extensions
{
    internal static class ICollectionExtensions
    {
        public static void AddRange<T>(
            this ICollection<T> source,
            IEnumerable<T> values)
        {
            foreach (var item in values)
                source.Add(item);
        }
    }
}
