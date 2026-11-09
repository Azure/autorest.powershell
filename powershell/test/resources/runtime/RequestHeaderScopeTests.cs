// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.PowerShell.Cmdlets.LroHeaders.Runtime;

public static class RequestHeaderScopeTests
{
    private const string RequestScopedHeadersKey = "Microsoft.Azure.PowerShell.RequestScopedHeaders";
    private const string ScopedHeader = "x-operation-token";
    private static readonly Uri PollUri = new Uri("https://example.invalid/status");

    public static void PollingGetExcludesScopedHeaders()
    {
        using (var write = NewWrite())
        using (var poll = write.CloneForFollowUpGetAndDispose(PollUri))
        {
            Require(poll.Method == HttpMethod.Get && poll.RequestUri == PollUri, "Expected polling GET.");
            Require(!poll.Headers.Contains(ScopedHeader), "Polling GET inherited request-scoped header.");
            Require(!poll.Properties.ContainsKey(RequestScopedHeadersKey), "Polling GET inherited scope metadata.");
            Require(poll.Content == null, "Polling GET inherited write content.");
        }
    }

    public static void FinalGetExcludesNewPollingScope()
    {
        using (var write = NewWrite())
        using (var poll = write.CloneForFollowUpGetAndDispose(PollUri))
        {
            poll.Headers.Add("x-poll-only", "poll-value");
            poll.Properties[RequestScopedHeadersKey] = Array.AsReadOnly(new[] { "x-poll-only" });
            using (var final = poll.CloneForFollowUpGetAndDispose(new Uri("https://example.invalid/resource")))
            {
                Require(!final.Headers.Contains(ScopedHeader) && !final.Headers.Contains("x-poll-only"), "Final GET inherited request-scoped headers.");
                Require(final.Method == HttpMethod.Get, "Final request must be GET.");
            }
        }
    }

    public static void RetryClonePreservesScopedHeaders()
    {
        using (var write = NewWrite())
        using (var retry = write.Clone())
        {
            Require(retry.Method == HttpMethod.Put && retry.Headers.Contains(ScopedHeader), "Retry lost original write semantics.");
            Require(retry.Properties[RequestScopedHeadersKey] == write.Properties[RequestScopedHeadersKey], "Retry lost scope snapshot.");
        }
    }

    public static void ContentRetryClonePreservesScope()
    {
        using (var write = NewWrite())
        using (var retry = write.CloneWithContent().GetAwaiter().GetResult())
        {
            Require(retry.Headers.Contains(ScopedHeader), "Content retry lost scoped header.");
            Require(retry.Content.ReadAsStringAsync().GetAwaiter().GetResult() == "write-body", "Content retry lost body.");
            Require(retry.Properties.ContainsKey(RequestScopedHeadersKey), "Content retry lost scope metadata.");
        }
    }

    public static void OriginalWriteRemainsUnmodified()
    {
        using (var write = NewWrite())
        using (var retry = write.Clone())
        using (var poll = retry.CloneForFollowUpGetAndDispose(PollUri))
        {
            Require(write.Headers.Contains(ScopedHeader), "Original write header was mutated.");
            Require(write.Properties.ContainsKey(RequestScopedHeadersKey), "Original write scope was mutated.");
            Require(write.Content.ReadAsStringAsync().GetAwaiter().GetResult() == "write-body", "Original write content was changed or disposed.");
        }
    }

    public static void CaseInsensitiveScopes()
    {
        using (var write = NewWrite())
        {
            write.Properties[RequestScopedHeadersKey] = Array.AsReadOnly(new[] { "X-OPERATION-TOKEN", "x-operation-token" });
            using (var poll = write.CloneForFollowUpGetAndDispose(PollUri))
            {
                Require(!poll.Headers.Contains(ScopedHeader), "Scope matching must ignore case.");
            }
        }
    }

    public static void UnmarkedHeadersSurvive()
    {
        using (var write = new HttpRequestMessage(HttpMethod.Put, "https://example.invalid/resource"))
        {
            write.Headers.Add(ScopedHeader, "unmarked");
            using (var poll = write.CloneForFollowUpGetAndDispose(PollUri))
            {
                Require(poll.Headers.Contains(ScopedHeader), "Unmarked headers must not be blacklisted.");
            }
        }
    }

    public static void MultipleScopedHeadersAreExcluded()
    {
        using (var write = NewWrite())
        {
            write.Headers.Add("x-second-scoped", "second");
            write.Headers.Add("x-shared", "shared");
            write.Properties[RequestScopedHeadersKey] = Array.AsReadOnly(new[] { ScopedHeader, "x-second-scoped" });
            using (var poll = write.CloneForFollowUpGetAndDispose(PollUri))
            {
                Require(!poll.Headers.Contains(ScopedHeader) && !poll.Headers.Contains("x-second-scoped"), "Follow-up GET must exclude every scoped header.");
                Require(poll.Headers.Contains("x-shared"), "Unmarked header was lost when excluding multiple scoped headers.");
            }
        }
    }

    public static void SharedHeadersAndContextSurvive()
    {
        using (var write = NewWrite())
        {
            write.Version = new Version(1, 1);
            write.Headers.Add("x-api-required", "required");
            write.Properties["request-context"] = "context";
            using (var poll = write.CloneForFollowUpGetAndDispose(PollUri))
            {
                Require(poll.Headers.Contains("x-api-required"), "Shared API header was lost.");
                Require(poll.Headers.Contains("Authorization"), "Same-origin authentication was lost.");
                Require((string)poll.Properties["request-context"] == "context", "Shared context was lost.");
                Require(poll.Version == new Version(1, 1), "HTTP version was lost.");
            }
        }
    }

    public static void CrossOriginCredentialIsolation()
    {
        foreach (var uri in new[] { "https://other.invalid/status", "http://example.invalid/status" })
        {
            using (var write = NewWrite())
            {
                write.Headers.Add("Proxy-Authorization", "credential");
                write.Headers.Add("Cookie", "session=value");
                using (var poll = write.CloneForFollowUpGetAndDispose(new Uri(uri)))
                {
                    Require(!poll.Headers.Contains("Authorization") && !poll.Headers.Contains("Proxy-Authorization") && !poll.Headers.Contains("Cookie"), "Cross-origin credentials were inherited.");
                    Require(!poll.Headers.Contains(ScopedHeader), "Cross-origin scoped header was inherited.");
                }
            }
        }
    }

    public static void RelativeSameOriginPreservesAuthorization()
    {
        using (var write = NewWrite())
        using (var poll = write.CloneForFollowUpGetAndDispose(new Uri("/status", UriKind.Relative)))
        {
            Require(poll.Headers.Contains("Authorization"), "Relative same-origin target lost authorization.");
            Require(!poll.Headers.Contains(ScopedHeader), "Relative target inherited scoped header.");
        }
    }

    public static void OrdinaryGetClonePreservesScope()
    {
        using (var write = NewWrite())
        using (var page = write.CloneAndDispose(PollUri, HttpMethod.Get))
        {
            Require(page.Headers.Contains(ScopedHeader), "Ordinary GET clone behavior changed.");
            Require(page.Properties.ContainsKey(RequestScopedHeadersKey), "Ordinary clone lost scope metadata.");
        }
    }

    public static void InvalidMetadataFailsExplicitly()
    {
        using (var write = NewWrite())
        {
            write.Properties[RequestScopedHeadersKey] = 42;
            try
            {
                using (var poll = write.CloneForFollowUpGetAndDispose(PollUri))
                {
                    throw new Exception("Invalid metadata was silently accepted.");
                }
            }
            catch (InvalidOperationException exception)
            {
                Require(exception.Message.Contains(RequestScopedHeadersKey), "Invalid metadata failure lacks context.");
            }
        }
    }

    public static void GeneratedLroExcludesScopedHeadersFromPollingAndFinalGet()
    {
        var sender = new LroSender();
        var result = new Microsoft.Azure.PowerShell.Cmdlets.LroHeaders.LroHeaders()
            .WidgetsCreateWithResult("00000000-0000-0000-0000-000000000000", "widget", null, new Listener(), sender)
            .GetAwaiter().GetResult();

        Require(result != null, "Generated LRO did not return the final resource.");
        Require(sender.Calls == 4, "Expected a PUT, two polling GETs, and a final GET.");
    }

    private sealed class Listener : IEventListener
    {
        public CancellationToken Token => CancellationToken.None;
        public Action Cancel => () => { throw new Exception("Unexpected cancellation."); };
        public Task Signal(string id, CancellationToken token, Func<EventData> createMessage) => Task.CompletedTask;
    }

    private sealed class LroSender : ISendAsync
    {
        public int Calls { get; private set; }

        public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, IEventListener callback)
        {
            Calls++;
            Require(Calls <= 4, "Generated LRO failed to terminate.");
            Require(!request.Headers.Contains("x-ms-client-request-id"), "Telemetry was inherited rather than reapplied.");
            request.Headers.Add("x-ms-client-request-id", "request-" + Calls);

            if (Calls == 1)
            {
                Require(request.Method == HttpMethod.Put, "Initial request must be PUT.");
                request.Headers.Add(ScopedHeader, "synthetic");
                request.Headers.Add("x-api-required", "shared");
                request.Properties["request-context"] = "context";
                request.Properties[RequestScopedHeadersKey] = Array.AsReadOnly(new[] { ScopedHeader });
            }
            else
            {
                Require(request.Method == HttpMethod.Get, "Follow-up request must be GET.");
                Require(request.Content == null, "Follow-up GET inherited write content.");
                Require(!request.Headers.Contains(ScopedHeader), "Generated LRO inherited the write's scoped header.");
                Require(!request.Headers.Contains("x-poll-only"), "Generated LRO inherited polling enrichment.");
                Require(!request.Properties.ContainsKey(RequestScopedHeadersKey), "Follow-up GET inherited scope metadata.");
                Require(request.Headers.Contains("x-api-required"), "Shared API header was lost.");
                Require((string)request.Properties["request-context"] == "context", "Shared request context was lost.");
                Require(Calls == 4
                    ? request.RequestUri.AbsolutePath.EndsWith("/widgets/widget", StringComparison.Ordinal)
                    : request.RequestUri.AbsolutePath == "/status", "Unexpected polling or final resource URI.");

                if (Calls == 2 || Calls == 3)
                {
                    request.Headers.Add("x-poll-only", "poll-value");
                    request.Properties[RequestScopedHeadersKey] = Array.AsReadOnly(new[] { "x-poll-only" });
                }
            }

            var response = new HttpResponseMessage(Calls == 1 ? HttpStatusCode.Accepted : HttpStatusCode.OK)
            {
                RequestMessage = request,
                Content = new StringContent(Calls == 2
                    ? "{\"status\":\"InProgress\"}"
                    : "{\"name\":\"widget\",\"properties\":{\"provisioningState\":\"Succeeded\"}}")
            };
            if (Calls == 1)
            {
                response.Headers.Add("Azure-AsyncOperation", "https://management.azure.com/status");
            }
            return Task.FromResult(response);
        }
    }

    private static HttpRequestMessage NewWrite()
    {
        var request = new HttpRequestMessage(HttpMethod.Put, "https://example.invalid/resource");
        request.Content = new StringContent("write-body");
        request.Headers.Add(ScopedHeader, "synthetic");
        request.Headers.Add("Authorization", "Bearer synthetic");
        request.Properties[RequestScopedHeadersKey] = Array.AsReadOnly(new[] { ScopedHeader });
        return request;
    }

    private static void Require(bool condition, string message)
    {
        if (!condition) throw new Exception(message);
    }
}
