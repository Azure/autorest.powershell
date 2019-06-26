
using System;

namespace Microsoft.Rest.ClientRuntime
{
    public interface IHeaderSerializable
    {
        void ReadHeaders(global::System.Net.Http.Headers.HttpResponseHeaders headers);
    }
}