
namespace Microsoft.Rest.ClientRuntime
{
    using System.Net.Http;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Collections;
    using System.Linq;

    using GetEventData = System.Func<EventData>;
    using NextDelegate = System.Func<
            System.Net.Http.HttpRequestMessage /* request */,
            System.Func<
                string /* id */,
                System.Threading.CancellationToken /* token */,
                System.Func<System.EventArgs> /* getEventData */,
            /* returnType */ System.Threading.Tasks.Task>, /*eventListener */
                                                           /* returnType */ System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>
    >;

    using EventListenerDelegate = System.Func<
        string /* id */,
        System.Threading.CancellationToken /* token */,
        System.Func<System.EventArgs> /* getEventData */,
    /* returnType */ System.Threading.Tasks.Task>;

    using SendAsyncStepDelegate = System.Func<
            System.Net.Http.HttpRequestMessage /* request */,

            System.Func<
                string /* id */,
                System.Threading.CancellationToken /* token */,
                System.Func<System.EventArgs> /*getEventData */,
                /* returnType */ System.Threading.Tasks.Task> /* eventListener */,

            System.Func<
                System.Net.Http.HttpRequestMessage,
                System.Func<string, System.Threading.CancellationToken, System.Func<System.EventArgs>,
            System.Threading.Tasks.Task>,

          System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>> /*next*/,
        System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>>;


    public class DelegateBasedEventListener : IEventListener
    {
        private EventListenerDelegate _listener;
        public DelegateBasedEventListener(EventListenerDelegate listener)
        {
            _listener = listener;
        }
        public CancellationToken Token => CancellationToken.None;
        public System.Action Cancel => () => { };


        public Task Signal(string id, CancellationToken token, GetEventData createMessage)
        {
            return _listener(id, token, () => createMessage());
        }
    }

    /// <summary>
    /// This is a necessary extension to the SendAsyncFactory to support the 'generic' delegate format.
    /// </summary>
    public partial class SendAsyncFactory
    {
        /// <summary>
        /// This translates a generic-defined delegate for a listener into one that fits our ISendAsync pattern.
        /// (Provided to support out-of-module delgation for Azure Cmdlets)
        /// </summary>
        /// <param name="step">The Pipeline Step as a delegate</param>
        public SendAsyncFactory(SendAsyncStepDelegate step) => this.implementation = (request, listener, next) => step(request, (id, token, getEventData) => listener.Signal(id, token, () => getEventData() as EventData), (req, listenerDelegate) => next.SendAsync(req, new DelegateBasedEventListener(listenerDelegate)));
    }

    public partial class HttpPipeline : ISendAsync
    {
        public HttpPipeline Append(SendAsyncStepDelegate item)
        {
            if (item != null)
            {
                Append(new SendAsyncFactory(item));
            }
            return this;
        }

        public HttpPipeline Prepend(SendAsyncStepDelegate item)
        {
            if (item != null)
            {
                Prepend(new SendAsyncFactory(item));
            }
            return this;
        }
    }
}