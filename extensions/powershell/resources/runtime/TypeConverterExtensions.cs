using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;

namespace Microsoft.Rest.ClientRuntime.PowerShell
{
    internal static class TypeConverterExtensions
    {
        internal static T GetValueForProperty<T, K, V>(this System.Collections.Generic.IDictionary<K, V> dictionary, string propertyName, T defaultValue, System.Func<object, object> converter)
        {
            try
            {
                var key = System.Linq.Enumerable.FirstOrDefault(dictionary.Keys, each => System.String.Equals(each.ToString(), propertyName, System.StringComparison.CurrentCultureIgnoreCase));
                return key == null ? defaultValue : (T)converter(dictionary[key]);
            }
            catch
            {
            }
            return defaultValue;
        }
        internal static T GetValueForProperty<T>(this System.Collections.IDictionary dictionary, string propertyName, T defaultValue, System.Func<object, object> converter)
        {
            try
            {
                var key = System.Linq.Enumerable.FirstOrDefault(dictionary.Keys.OfType<object>(), each => System.String.Equals(each.ToString(), propertyName, System.StringComparison.CurrentCultureIgnoreCase));
                return key == null ? defaultValue : (T)converter(dictionary[key]);
            }
            catch
            {
            }
            return defaultValue;
        }

        internal static T GetValueForProperty<T>(this System.Management.Automation.PSObject psObject, string propertyName, T defaultValue, System.Func<object, object> converter)
        {
            try
            {
                var property = System.Linq.Enumerable.FirstOrDefault(psObject.Properties, each => System.String.Equals(each.Name.ToString(), propertyName, System.StringComparison.CurrentCultureIgnoreCase));
                return property == null ? defaultValue : (T)converter(property.Value);
            }
            catch
            {
            }
            return defaultValue;
        }
    }
}
