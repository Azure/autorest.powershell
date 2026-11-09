// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

public static class Tests
{
    private const string ScopedHeader = "x-operation-token";
    private static readonly Uri PollUri = new Uri("https://example.invalid/status");

    public static void PollingGetExcludesScopedHeaders()
    {
        using (var write = NewWrite())
        using (var poll = write.CloneForFollowUpGetAndDispose(PollUri))
        {
            Require(poll.Method == HttpMethod.Get && poll.RequestUri == PollUri, "Expected polling GET.");
            Require(!poll.Headers.Contains(ScopedHeader), "Polling GET inherited request-scoped header.");
            Require(!poll.Properties.ContainsKey(Extensions.RequestScopedHeadersKey), "Polling GET inherited scope metadata.");
            Require(poll.Content == null, "Polling GET inherited write content.");
        }
    }

    public static void FinalGetExcludesNewPollingScope()
    {
        using (var write = NewWrite())
        using (var poll = write.CloneForFollowUpGetAndDispose(PollUri))
        {
            poll.Headers.Add("x-poll-only", "poll-value");
            poll.Properties[Extensions.RequestScopedHeadersKey] = Array.AsReadOnly(new[] { "x-poll-only" });
            using (var final = poll.CloneForFollowUpGetAndDispose(new Uri("https://example.invalid/resource")))
            {
                Require(!final.Headers.Contains(ScopedHeader) && !final.Headers.Contains("x-poll-only"), "Final GET inherited request-scoped headers.");
                Require(final.Method == HttpMethod.Get, "Final request must be GET.");
            }
        }
    }

    public static void RetryPreservesScopedHeaders()
    {
        using (var write = NewWrite())
        using (var retry = write.Clone())
        {
            Require(retry.Method == HttpMethod.Put && retry.Headers.Contains(ScopedHeader), "Retry lost original write semantics.");
            Require(retry.Properties[Extensions.RequestScopedHeadersKey] == write.Properties[Extensions.RequestScopedHeadersKey], "Retry lost scope snapshot.");
        }
    }

    public static void ContentRetryPreservesScope()
    {
        using (var write = NewWrite())
        using (var retry = write.CloneWithContent().GetAwaiter().GetResult())
        {
            Require(retry.Headers.Contains(ScopedHeader), "Content retry lost scoped header.");
            Require(retry.Content.ReadAsStringAsync().GetAwaiter().GetResult() == "write-body", "Content retry lost body.");
            Require(retry.Properties.ContainsKey(Extensions.RequestScopedHeadersKey), "Content retry lost scope metadata.");
        }
    }

    public static void OriginalWriteRemainsUnmodified()
    {
        using (var write = NewWrite())
        using (var retry = write.Clone())
        using (var poll = retry.CloneForFollowUpGetAndDispose(PollUri))
        {
            Require(write.Headers.Contains(ScopedHeader), "Original write header was mutated.");
            Require(write.Properties.ContainsKey(Extensions.RequestScopedHeadersKey), "Original write scope was mutated.");
            Require(write.Content.ReadAsStringAsync().GetAwaiter().GetResult() == "write-body", "Original write content was changed or disposed.");
        }
    }

    public static void CaseInsensitiveScopes()
    {
        using (var write = NewWrite())
        {
            write.Properties[Extensions.RequestScopedHeadersKey] = Array.AsReadOnly(new[] { "X-OPERATION-TOKEN", "x-operation-token" });
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

    public static void PaginationRetainsExistingBehavior()
    {
        using (var write = NewWrite())
        using (var page = write.CloneAndDispose(PollUri, HttpMethod.Get))
        {
            Require(page.Headers.Contains(ScopedHeader), "Ordinary GET clone behavior changed.");
            Require(page.Properties.ContainsKey(Extensions.RequestScopedHeadersKey), "Ordinary clone lost scope metadata.");
        }
    }

    public static void InvalidMetadataFailsExplicitly()
    {
        using (var write = NewWrite())
        {
            write.Properties[Extensions.RequestScopedHeadersKey] = 42;
            try
            {
                using (var poll = write.CloneForFollowUpGetAndDispose(PollUri))
                {
                    throw new Exception("Invalid metadata was silently accepted.");
                }
            }
            catch (InvalidOperationException exception)
            {
                Require(exception.Message.Contains(Extensions.RequestScopedHeadersKey), "Invalid metadata failure lacks context.");
            }
        }
    }

    private static HttpRequestMessage NewWrite()
    {
        var request = new HttpRequestMessage(HttpMethod.Put, "https://example.invalid/resource");
        request.Content = new StringContent("write-body");
        request.Headers.Add(ScopedHeader, "synthetic");
        request.Headers.Add("Authorization", "Bearer synthetic");
        request.Properties[Extensions.RequestScopedHeadersKey] = Array.AsReadOnly(new[] { ScopedHeader });
        return request;
    }

    private static void Require(bool condition, string message)
    {
        if (!condition) throw new Exception(message);
    }
}
