
namespace Microsoft.Rest.ClientRuntime
{
    using System;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using static Microsoft.Rest.ClientRuntime.Extensions;

    public class RestException : Exception, IDisposable
    {
        public System.Net.HttpStatusCode StatusCode { get; set; }
        public string Code { get; protected set; }
        protected string message;
        public HttpRequestMessage RequestMessage { get; protected set; }
        public HttpResponseHeaders ResponseHeaders { get; protected set; }

        public string ResponseBody { get; protected set; }
        public string ClientRequestId { get; protected set; }
        public string RequestId { get; protected set; }

        public override string Message => message;

        public RestException(System.Net.Http.HttpResponseMessage response)
        {
            StatusCode = response.StatusCode;
            RequestMessage = response.RequestMessage.CloneWithContent().Result;
            ResponseBody = response.Content.ReadAsStringAsync().Result;
            ResponseHeaders = response.Headers;

            RequestId = response.GetFirstHeader("x-ms-request-id");
            ClientRequestId = response.GetFirstHeader("x-ms-client-request-id");

            try
            {
                // try to parse the body as JSON, and see if a code and message are in there.
                var json = Microsoft.Rest.ClientRuntime.Json.JsonNode.Parse(ResponseBody) as Microsoft.Rest.ClientRuntime.Json.JsonObject;
                { Code = If(json?.PropertyT<Microsoft.Rest.ClientRuntime.Json.JsonString>("code"), out var c) ? (string)c : (string)StatusCode.ToString(); }
                { message = If(json?.PropertyT<Microsoft.Rest.ClientRuntime.Json.JsonString>("message"), out var m) ? (string)m : (string)Message; }
            }
            catch
            {
                // couldn't get the code/message from the body response. 
                // we'll create one below.
            }
            if (string.IsNullOrEmpty(message))
            {
                if (StatusCode >= System.Net.HttpStatusCode.BadRequest && StatusCode < System.Net.HttpStatusCode.InternalServerError)
                {
                    message = $"The server responded with a Request Error, Status: {StatusCode}";
                }
                else if (StatusCode >= System.Net.HttpStatusCode.InternalServerError)
                {
                    message = $"The server responded with a Server Error, Status: {StatusCode}";
                }
                else
                {
                    message = $"The server responded with an unrecognized response, Status: {StatusCode}";
                }
            }
        }

        public void Dispose()
        {
            ((IDisposable)RequestMessage).Dispose();
        }
    }

    public class RestException<T> : RestException
    {
        public T Error { get; protected set; }
        public RestException(System.Net.Http.HttpResponseMessage response, T error) : base(response)
        {
            Error = error;
        }
    }


    public class UndeclaredResponseException : RestException
    {
        public UndeclaredResponseException(System.Net.Http.HttpResponseMessage response) : base(response)
        {

        }
    }
}