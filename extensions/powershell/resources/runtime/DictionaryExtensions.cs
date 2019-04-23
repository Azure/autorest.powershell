namespace Microsoft.Rest.ClientRuntime
{
    internal static class DictionaryExtensions
    {
        internal static void HashTableToDictionary<T, V>(System.Collections.Hashtable hashtable, T dictionary) where T : System.Collections.Generic.IDictionary<string, V>, new()
        {
            foreach (var each in hashtable.Keys)
            {
                var key = each.ToString();
                var value = hashtable[key];
                if (null != value)
                {
                    if (value is System.Collections.Hashtable nested)
                    {
                        HashTableToDictionary<T, V>(nested, new T());
                    }
                    else
                    {
                        try
                        {
                            dictionary[key] = (V)value;
                        }
                        catch
                        {
                            // Values getting dropped; not compatible with target dictionary. Not sure what to do here.
                        }
                    }
                }
            }
        }
    }
}