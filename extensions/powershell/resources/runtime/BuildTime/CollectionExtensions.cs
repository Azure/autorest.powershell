using System.Collections.Generic;
using System.Linq;

namespace Microsoft.Rest.ClientRuntime.PowerShell
{
    internal static class CollectionExtensions
    {
        public static T[] NullIfEmpty<T>(this T[] collection) => (collection?.Any() ?? false) ? collection : null;
        public static IEnumerable<T> EmptyIfNull<T>(this IEnumerable<T> collection) => collection ?? Enumerable.Empty<T>();
    }
}
