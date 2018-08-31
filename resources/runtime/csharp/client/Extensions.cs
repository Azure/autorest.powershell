namespace Microsoft.Rest.ClientRuntime
{
    public static partial class Extensions
    {
        public static bool If<T>(T input, out T output)
        {
            if (null == input)
            {
                output = default(T);
                return false;
            }
            output = input;
            return true;
        }

        public static void AddIf<T>(T value, System.Action<T> addMethod)
        {
            if (null != value)
            {
                addMethod(value);
            }
        }

        public static void AddIf<T>(T value, string serializedName, System.Action<string, T> addMethod)
        {
            if (null != value)
            {
                addMethod(serializedName, value);
            }
        }

        /// <summary>
        /// Returns the first header value as a string from an HttpReponseMessage. 
        /// </summary>
        /// <param name="response">the HttpResponseMessage to fetch a header from</param>
        /// <param name="headerName">the header name</param>
        /// <returns>the first header value as a string from an HttpReponseMessage. string.empty if there is no header value matching</returns>
        public static string GetFirstHeader(this System.Net.Http.HttpResponseMessage response, string headerName) => response.Headers.TryGetValues(headerName, out var values) ? System.Linq.Enumerable.FirstOrDefault(values) : string.Empty;

    }

}