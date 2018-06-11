
namespace Microsoft.Rest.ClientRuntime
{
    public static class Method
    {
        public static System.Net.Http.HttpMethod Get = System.Net.Http.HttpMethod.Get;
        public static System.Net.Http.HttpMethod Put = System.Net.Http.HttpMethod.Put;
        public static System.Net.Http.HttpMethod Head = System.Net.Http.HttpMethod.Head;
        public static System.Net.Http.HttpMethod Post = System.Net.Http.HttpMethod.Post;
        public static System.Net.Http.HttpMethod Delete = System.Net.Http.HttpMethod.Delete;
        public static System.Net.Http.HttpMethod Options = System.Net.Http.HttpMethod.Options;
        public static System.Net.Http.HttpMethod Trace = System.Net.Http.HttpMethod.Trace;
        public static System.Net.Http.HttpMethod Patch = new System.Net.Http.HttpMethod("PATCH");
    }
}