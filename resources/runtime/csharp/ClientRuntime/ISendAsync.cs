
namespace Microsoft.Rest.ClientRuntime
{
    using System.Net.Http;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Collections;
    using System.Linq;

    /// <summary>
    /// The interface for sending an HTTP request across the wire.
    /// </summary>
    public interface ISendAsync
    {
        Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, IEventListener callback);
    }

    public class SendAsyncTerminalFactory : ISendAsyncTerminalFactory, ISendAsync
    {
        SendAsync implementation;

        public SendAsyncTerminalFactory(SendAsync implementation) => this.implementation = implementation;
        public SendAsyncTerminalFactory(ISendAsync implementation) => this.implementation = implementation.SendAsync;
        public ISendAsync Create() => this;
        public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, IEventListener callback) => implementation(request, callback);
    }

    public partial class SendAsyncFactory : ISendAsyncFactory
    {
        public class Sender : ISendAsync
        {
            internal ISendAsync next;
            internal SendAsyncStep implementation;

            public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, IEventListener callback) => implementation(request, callback, next);
        }
        SendAsyncStep implementation;

        public SendAsyncFactory(SendAsyncStep implementation) => this.implementation = implementation;
        public ISendAsync Create(ISendAsync next) => new Sender { next = next, implementation = implementation };

    }

    public class HttpClientFactory : ISendAsyncTerminalFactory, ISendAsync
    {
        HttpClient client;
        public HttpClientFactory() : this(new HttpClient())
        {
        }
        public HttpClientFactory(HttpClient client) => this.client = client;
        public ISendAsync Create() => this;
        
        public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, IEventListener callback) => client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, callback.Token);
    }

    public interface ISendAsyncFactory
    {
        ISendAsync Create(ISendAsync next);
    }

    public interface ISendAsyncTerminalFactory
    {
        ISendAsync Create();
    }

    public partial class HttpPipeline : ISendAsync
    {
        private ISendAsync pipeline;
        private ISendAsyncTerminalFactory terminal;
        private List<ISendAsyncFactory> steps = new List<ISendAsyncFactory>();

        public HttpPipeline() : this(new HttpClientFactory())
        {
        }

        public HttpPipeline(ISendAsyncTerminalFactory terminalStep)
        {
            if (terminalStep == null)
            {
                throw new System.ArgumentNullException(nameof(terminalStep), "Terminal Step Factory in HttpPipeline may not be null");
            }
            TerminalFactory = terminalStep;
        }

        /// <summary>
        /// Returns an HttpPipeline with the current state of this pipeline.
        /// </summary>
        public HttpPipeline Clone() => new HttpPipeline(terminal) { steps = this.steps.ToList(), pipeline = this.pipeline };

        public ISendAsyncTerminalFactory TerminalFactory
        {
            get => terminal;
            set
            {
                if (value == null)
                {
                    throw new System.ArgumentNullException("TerminalFactory in HttpPipeline may not be null");
                }
                terminal = value;
            }
        }

        public ISendAsync Pipeline
        {
            get
            {
                // if the pipeline has been created and not invalidated, return it. 
                if (this.pipeline != null)
                {
                    return this.pipeline;
                }

                // create the pipeline from scratch.
                var next = terminal.Create();
                foreach (var factory in steps)
                {
                    // skip factories that return null.
                    next = factory.Create(next) ?? next;
                }
                return this.pipeline = next;
            }
        }

        public int Count => steps.Count;

        public HttpPipeline Prepend(ISendAsyncFactory item)
        {
            if (item != null)
            {
                steps.Add(item);
                pipeline = null;
            }
            return this;
        }

        public HttpPipeline Append(SendAsyncStep item)
        {
            if (item != null)
            {
                Append(new SendAsyncFactory(item));
            }
            return this;
        }

        public HttpPipeline Prepend(SendAsyncStep item)
        {
            if (item != null)
            {
                Prepend(new SendAsyncFactory(item));
            }
            return this;
        }
        public HttpPipeline Append(IEnumerable<SendAsyncStep> items)
        {
            if (items != null)
            {
                foreach (var item in items)
                {
                    Append(new SendAsyncFactory(item));
                }
            }
            return this;
        }

        public HttpPipeline Prepend(IEnumerable<SendAsyncStep> items)
        {
            if (items != null)
            {
                foreach (var item in items)
                {
                    Prepend(new SendAsyncFactory(item));
                }
            }
            return this;
        }

        public HttpPipeline Append(ISendAsyncFactory item)
        {
            if (item != null)
            {
                steps.Insert(0, item);
                pipeline = null;
            }
            return this;
        }
        public HttpPipeline Prepend(IEnumerable<ISendAsyncFactory> items)
        {
            if (items != null)
            {
                foreach (var item in items)
                {
                    Prepend(item);
                }
            }
            return this;
        }

        public HttpPipeline Append(IEnumerable<ISendAsyncFactory> items)
        {
            if (items != null)
            {
                foreach (var item in items)
                {
                    Append(item);
                }
            }
            return this;
        }

        // you can use this as the ISendAsync Implementation
        public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, IEventListener callback) => Pipeline.SendAsync(request, callback);
    }
}