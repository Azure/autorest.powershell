using System.Linq;

namespace Microsoft.Rest.ClientRuntime.PowerShell
{
    internal static class CollectionExtensions
    {
        public static T[] NullIfEmpty<T>(this T[] collection) => (collection?.Any() ?? false) ? collection : null;
    }
}
