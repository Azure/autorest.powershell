// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Help
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Extensions;

    /// <summary>
    /// Low-level API implementation for the HelpRP service.
    /// Help RP provider
    /// </summary>
    public partial class HelpRp
    {

        /// <summary>
        /// This API is used to check the uniqueness of a resource name used for a diagnostic, troubleshooter or solutions
        /// </summary>
        /// <param name="scope">The fully qualified Azure Resource manager identifier of the resource.</param>
        /// <param name="body">The required parameters for availability check.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task CheckNameAvailabilityCheckAvailability(string scope, Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ICheckNameAvailabilityRequest body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ICheckNameAvailabilityResponse>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/"
                        + (scope)
                        + "/providers/Microsoft.Help/checkNameAvailability"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.CheckNameAvailabilityCheckAvailability_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>
        /// This API is used to check the uniqueness of a resource name used for a diagnostic, troubleshooter or solutions
        /// </summary>
        /// <param name="viaIdentity"></param>
        /// <param name="body">The required parameters for availability check.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task CheckNameAvailabilityCheckAvailabilityViaIdentity(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ICheckNameAvailabilityRequest body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ICheckNameAvailabilityResponse>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/(?<scope>[^/]+)/providers/Microsoft.Help$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/{scope}/providers/Microsoft.Help'");
                }

                // replace URI parameters with values from identity
                var scope = _match.Groups["scope"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/"
                        + scope
                        + "/providers/Microsoft.Help/checkNameAvailability"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.CheckNameAvailabilityCheckAvailability_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>
        /// This API is used to check the uniqueness of a resource name used for a diagnostic, troubleshooter or solutions
        /// </summary>
        /// <param name="viaIdentity"></param>
        /// <param name="body">The required parameters for availability check.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ICheckNameAvailabilityResponse>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ICheckNameAvailabilityResponse> CheckNameAvailabilityCheckAvailabilityViaIdentityWithResult(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ICheckNameAvailabilityRequest body, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/(?<scope>[^/]+)/providers/Microsoft.Help$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/{scope}/providers/Microsoft.Help'");
                }

                // replace URI parameters with values from identity
                var scope = _match.Groups["scope"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/"
                        + scope
                        + "/providers/Microsoft.Help/checkNameAvailability"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.CheckNameAvailabilityCheckAvailabilityWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>
        /// This API is used to check the uniqueness of a resource name used for a diagnostic, troubleshooter or solutions
        /// </summary>
        /// <param name="scope">The fully qualified Azure Resource manager identifier of the resource.</param>
        /// <param name="jsonString">Json string supplied to the CheckNameAvailabilityCheckAvailability operation</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task CheckNameAvailabilityCheckAvailabilityViaJsonString(string scope, global::System.String jsonString, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ICheckNameAvailabilityResponse>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/"
                        + (scope)
                        + "/providers/Microsoft.Help/checkNameAvailability"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(jsonString, global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.CheckNameAvailabilityCheckAvailability_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>
        /// This API is used to check the uniqueness of a resource name used for a diagnostic, troubleshooter or solutions
        /// </summary>
        /// <param name="scope">The fully qualified Azure Resource manager identifier of the resource.</param>
        /// <param name="jsonString">Json string supplied to the CheckNameAvailabilityCheckAvailability operation</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ICheckNameAvailabilityResponse>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ICheckNameAvailabilityResponse> CheckNameAvailabilityCheckAvailabilityViaJsonStringWithResult(string scope, global::System.String jsonString, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/"
                        + (scope)
                        + "/providers/Microsoft.Help/checkNameAvailability"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(jsonString, global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.CheckNameAvailabilityCheckAvailabilityWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>
        /// This API is used to check the uniqueness of a resource name used for a diagnostic, troubleshooter or solutions
        /// </summary>
        /// <param name="scope">The fully qualified Azure Resource manager identifier of the resource.</param>
        /// <param name="body">The required parameters for availability check.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ICheckNameAvailabilityResponse>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ICheckNameAvailabilityResponse> CheckNameAvailabilityCheckAvailabilityWithResult(string scope, Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ICheckNameAvailabilityRequest body, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/"
                        + (scope)
                        + "/providers/Microsoft.Help/checkNameAvailability"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.CheckNameAvailabilityCheckAvailabilityWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>
        /// Actual wire call for <see cref= "CheckNameAvailabilityCheckAvailabilityWithResult" /> method.
        /// </summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ICheckNameAvailabilityResponse>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ICheckNameAvailabilityResponse> CheckNameAvailabilityCheckAvailabilityWithResult_Call(global::System.Net.Http.HttpRequestMessage request, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Help.Models.CheckNameAvailabilityResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(body.Result)) );
                            return await _result;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(body.Result)) );
                            // Error Response : default
                            var code = (await _result)?.Code;
                            var message = (await _result)?.Message;
                            if ((null == code || null == message))
                            {
                                // Unrecognized Response. Create an error record based on what we have.
                                var ex = new Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>(_response, await _result);
                                throw ex;
                            }
                            else
                            {
                                throw new global::System.Exception($"[{code}] : {message}");
                            }
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Actual wire call for <see cref= "CheckNameAvailabilityCheckAvailability" /> method.
        /// </summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task CheckNameAvailabilityCheckAvailability_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ICheckNameAvailabilityResponse>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Help.Models.CheckNameAvailabilityResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="CheckNameAvailabilityCheckAvailability" /> method. Call this like the actual call, but
        /// you will get validation events back.
        /// </summary>
        /// <param name="scope">The fully qualified Azure Resource manager identifier of the resource.</param>
        /// <param name="body">The required parameters for availability check.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task CheckNameAvailabilityCheckAvailability_Validate(string scope, Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ICheckNameAvailabilityRequest body, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(scope),scope);
                await eventListener.AssertNotNull(nameof(body), body);
                await eventListener.AssertObjectIsValid(nameof(body), body);
            }
        }

        /// <summary>
        /// update a diagnostic for the specific resource using solutionId from discovery solutions. <br/>Diagnostics are powerful
        /// solutions that access product resources or other relevant data and provide the root cause of the issue and the steps to
        /// address the issue.<br/><br/>
        /// </summary>
        /// <param name="scope">The fully qualified Azure Resource manager identifier of the resource.</param>
        /// <param name="diagnosticsResourceName">Unique resource name for insight resources</param>
        /// <param name="body">The required request body for this insightResource invocation.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DiagnosticsCreate(string scope, string diagnosticsResourceName, Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiagnosticResource body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiagnosticResource>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/"
                        + (scope)
                        + "/providers/Microsoft.Help/diagnostics/"
                        + global::System.Uri.EscapeDataString(diagnosticsResourceName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Put, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DiagnosticsCreate_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>
        /// update a diagnostic for the specific resource using solutionId from discovery solutions. <br/>Diagnostics are powerful
        /// solutions that access product resources or other relevant data and provide the root cause of the issue and the steps to
        /// address the issue.<br/><br/>
        /// </summary>
        /// <param name="viaIdentity"></param>
        /// <param name="body">The required request body for this insightResource invocation.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DiagnosticsCreateViaIdentity(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiagnosticResource body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiagnosticResource>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/(?<scope>[^/]+)/providers/Microsoft.Help/diagnostics/(?<diagnosticsResourceName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/{scope}/providers/Microsoft.Help/diagnostics/{diagnosticsResourceName}'");
                }

                // replace URI parameters with values from identity
                var scope = _match.Groups["scope"].Value;
                var diagnosticsResourceName = _match.Groups["diagnosticsResourceName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/"
                        + scope
                        + "/providers/Microsoft.Help/diagnostics/"
                        + diagnosticsResourceName
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Put, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DiagnosticsCreate_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>
        /// update a diagnostic for the specific resource using solutionId from discovery solutions. <br/>Diagnostics are powerful
        /// solutions that access product resources or other relevant data and provide the root cause of the issue and the steps to
        /// address the issue.<br/><br/>
        /// </summary>
        /// <param name="viaIdentity"></param>
        /// <param name="body">The required request body for this insightResource invocation.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiagnosticResource>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiagnosticResource> DiagnosticsCreateViaIdentityWithResult(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiagnosticResource body, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/(?<scope>[^/]+)/providers/Microsoft.Help/diagnostics/(?<diagnosticsResourceName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/{scope}/providers/Microsoft.Help/diagnostics/{diagnosticsResourceName}'");
                }

                // replace URI parameters with values from identity
                var scope = _match.Groups["scope"].Value;
                var diagnosticsResourceName = _match.Groups["diagnosticsResourceName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/"
                        + scope
                        + "/providers/Microsoft.Help/diagnostics/"
                        + diagnosticsResourceName
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Put, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.DiagnosticsCreateWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>
        /// update a diagnostic for the specific resource using solutionId from discovery solutions. <br/>Diagnostics are powerful
        /// solutions that access product resources or other relevant data and provide the root cause of the issue and the steps to
        /// address the issue.<br/><br/>
        /// </summary>
        /// <param name="scope">The fully qualified Azure Resource manager identifier of the resource.</param>
        /// <param name="diagnosticsResourceName">Unique resource name for insight resources</param>
        /// <param name="jsonString">Json string supplied to the DiagnosticsCreate operation</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DiagnosticsCreateViaJsonString(string scope, string diagnosticsResourceName, global::System.String jsonString, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiagnosticResource>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/"
                        + (scope)
                        + "/providers/Microsoft.Help/diagnostics/"
                        + global::System.Uri.EscapeDataString(diagnosticsResourceName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Put, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(jsonString, global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DiagnosticsCreate_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>
        /// update a diagnostic for the specific resource using solutionId from discovery solutions. <br/>Diagnostics are powerful
        /// solutions that access product resources or other relevant data and provide the root cause of the issue and the steps to
        /// address the issue.<br/><br/>
        /// </summary>
        /// <param name="scope">The fully qualified Azure Resource manager identifier of the resource.</param>
        /// <param name="diagnosticsResourceName">Unique resource name for insight resources</param>
        /// <param name="jsonString">Json string supplied to the DiagnosticsCreate operation</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiagnosticResource>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiagnosticResource> DiagnosticsCreateViaJsonStringWithResult(string scope, string diagnosticsResourceName, global::System.String jsonString, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/"
                        + (scope)
                        + "/providers/Microsoft.Help/diagnostics/"
                        + global::System.Uri.EscapeDataString(diagnosticsResourceName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Put, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(jsonString, global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.DiagnosticsCreateWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>
        /// update a diagnostic for the specific resource using solutionId from discovery solutions. <br/>Diagnostics are powerful
        /// solutions that access product resources or other relevant data and provide the root cause of the issue and the steps to
        /// address the issue.<br/><br/>
        /// </summary>
        /// <param name="scope">The fully qualified Azure Resource manager identifier of the resource.</param>
        /// <param name="diagnosticsResourceName">Unique resource name for insight resources</param>
        /// <param name="body">The required request body for this insightResource invocation.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiagnosticResource>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiagnosticResource> DiagnosticsCreateWithResult(string scope, string diagnosticsResourceName, Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiagnosticResource body, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/"
                        + (scope)
                        + "/providers/Microsoft.Help/diagnostics/"
                        + global::System.Uri.EscapeDataString(diagnosticsResourceName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Put, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.DiagnosticsCreateWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref= "DiagnosticsCreateWithResult" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiagnosticResource>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiagnosticResource> DiagnosticsCreateWithResult_Call(global::System.Net.Http.HttpRequestMessage request, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    // this operation supports x-ms-long-running-operation
                    var _originalUri = request.RequestUri.AbsoluteUri;
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Progress, "intentional placeholder", 0); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    // declared final-state-via: azure-async-operation
                    var asyncOperation = _response.GetFirstHeader(@"Azure-AsyncOperation");
                    var location = _response.GetFirstHeader(@"Location");
                    var operationLocation = _response.GetFirstHeader(@"Operation-Location");
                    while (request.Method == System.Net.Http.HttpMethod.Put && _response.StatusCode == global::System.Net.HttpStatusCode.OK || _response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                    {
                        // delay before making the next polling request
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.DelayBeforePolling, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }

                        // while we wait, let's grab the headers and get ready to poll.
                        if (!System.String.IsNullOrEmpty(_response.GetFirstHeader(@"Azure-AsyncOperation"))) {
                            asyncOperation = _response.GetFirstHeader(@"Azure-AsyncOperation");
                        }
                        if (!global::System.String.IsNullOrEmpty(_response.GetFirstHeader(@"Location"))) {
                            location = _response.GetFirstHeader(@"Location");
                        }
                        if (!global::System.String.IsNullOrEmpty(_response.GetFirstHeader(@"Operation-Location"))) {
                            operationLocation = _response.GetFirstHeader(@"Operation-Location");
                        }
                        var _uri = global::System.String.IsNullOrEmpty(asyncOperation) ? global::System.String.IsNullOrEmpty(location) ? global::System.String.IsNullOrEmpty(operationLocation) ? _originalUri : operationLocation : location : asyncOperation;
                        request = request.CloneAndDispose(new global::System.Uri(_uri), Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Get);

                        // and let's look at the current response body and see if we have some information we can give back to the listener
                        var content = await _response.Content.ReadAsStringAsync();

                        // drop the old response
                        _response?.Dispose();

                        // make the polling call
                        _response = await sender.SendAsync(request, eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }

                          // if we got back an OK, take a peek inside and see if it's done
                          if( _response.StatusCode == global::System.Net.HttpStatusCode.OK)
                          {
                              var error = false;
                              try {
                                  if( Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(await _response.Content.ReadAsStringAsync()) is Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonObject json)
                                  {
                                      var state = json.Property("properties")?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonString>("provisioningState") ?? json.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonString>("status");
                                      if( state is null )
                                      {
                                          // the body doesn't contain any information that has the state of the LRO
                                          // we're going to just get out, and let the consumer have the result
                                          break;
                                      }

                                      switch( state?.ToString()?.ToLower() )
                                      {
                                        case "failed":
                                            error = true;
                                            break;
                                        case "succeeded":
                                        case "canceled":
                                          // we're done polling.
                                          break;

                                        default:
                                          // need to keep polling!
                                          _response.StatusCode = global::System.Net.HttpStatusCode.Created;
                                          continue;
                                      }
                                  }
                              } catch {
                                  // if we run into a problem peeking into the result,
                                  // we really don't want to do anything special.
                              }
                              if (error) {
                                  throw new Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.UndeclaredResponseException(_response);
                              }
                          }

                        // check for terminal status code
                        if (_response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                        {
                            continue;
                        }
                        // we are done polling, do a request on final target?
                        // create a new request with the final uri
                        request = request.CloneAndDispose(new global::System.Uri(_originalUri), Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Get);

                        // drop the old response
                        _response?.Dispose();

                        // make the final call
                        _response = await sender.SendAsync(request,  eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                        break;
                    }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Help.Models.DiagnosticResource.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(body.Result)) );
                            return await _result;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(body.Result)) );
                            // Error Response : default
                            var code = (await _result)?.Code;
                            var message = (await _result)?.Message;
                            if ((null == code || null == message))
                            {
                                // Unrecognized Response. Create an error record based on what we have.
                                var ex = new Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>(_response, await _result);
                                throw ex;
                            }
                            else
                            {
                                throw new global::System.Exception($"[{code}] : {message}");
                            }
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>Actual wire call for <see cref= "DiagnosticsCreate" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DiagnosticsCreate_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiagnosticResource>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    // this operation supports x-ms-long-running-operation
                    var _originalUri = request.RequestUri.AbsoluteUri;
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Progress, "intentional placeholder", 0); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    // declared final-state-via: azure-async-operation
                    var asyncOperation = _response.GetFirstHeader(@"Azure-AsyncOperation");
                    var location = _response.GetFirstHeader(@"Location");
                    var operationLocation = _response.GetFirstHeader(@"Operation-Location");
                    while (request.Method == System.Net.Http.HttpMethod.Put && _response.StatusCode == global::System.Net.HttpStatusCode.OK || _response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                    {
                        // delay before making the next polling request
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.DelayBeforePolling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }

                        // while we wait, let's grab the headers and get ready to poll.
                        if (!System.String.IsNullOrEmpty(_response.GetFirstHeader(@"Azure-AsyncOperation"))) {
                            asyncOperation = _response.GetFirstHeader(@"Azure-AsyncOperation");
                        }
                        if (!global::System.String.IsNullOrEmpty(_response.GetFirstHeader(@"Location"))) {
                            location = _response.GetFirstHeader(@"Location");
                        }
                        if (!global::System.String.IsNullOrEmpty(_response.GetFirstHeader(@"Operation-Location"))) {
                            operationLocation = _response.GetFirstHeader(@"Operation-Location");
                        }
                        var _uri = global::System.String.IsNullOrEmpty(asyncOperation) ? global::System.String.IsNullOrEmpty(location) ? global::System.String.IsNullOrEmpty(operationLocation) ? _originalUri : operationLocation : location : asyncOperation;
                        request = request.CloneAndDispose(new global::System.Uri(_uri), Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Get);

                        // and let's look at the current response body and see if we have some information we can give back to the listener
                        var content = await _response.Content.ReadAsStringAsync();

                        // drop the old response
                        _response?.Dispose();

                        // make the polling call
                        _response = await sender.SendAsync(request, eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }

                          // if we got back an OK, take a peek inside and see if it's done
                          if( _response.StatusCode == global::System.Net.HttpStatusCode.OK)
                          {
                              var error = false;
                              try {
                                  if( Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(await _response.Content.ReadAsStringAsync()) is Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonObject json)
                                  {
                                      var state = json.Property("properties")?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonString>("provisioningState") ?? json.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonString>("status");
                                      if( state is null )
                                      {
                                          // the body doesn't contain any information that has the state of the LRO
                                          // we're going to just get out, and let the consumer have the result
                                          break;
                                      }

                                      switch( state?.ToString()?.ToLower() )
                                      {
                                        case "failed":
                                            error = true;
                                            break;
                                        case "succeeded":
                                        case "canceled":
                                          // we're done polling.
                                          break;

                                        default:
                                          // need to keep polling!
                                          _response.StatusCode = global::System.Net.HttpStatusCode.Created;
                                          continue;
                                      }
                                  }
                              } catch {
                                  // if we run into a problem peeking into the result,
                                  // we really don't want to do anything special.
                              }
                              if (error) {
                                  throw new Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.UndeclaredResponseException(_response);
                              }
                          }

                        // check for terminal status code
                        if (_response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                        {
                            continue;
                        }
                        // we are done polling, do a request on final target?
                        // create a new request with the final uri
                        request = request.CloneAndDispose(new global::System.Uri(_originalUri), Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Get);

                        // drop the old response
                        _response?.Dispose();

                        // make the final call
                        _response = await sender.SendAsync(request,  eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                        break;
                    }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Help.Models.DiagnosticResource.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="DiagnosticsCreate" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="scope">The fully qualified Azure Resource manager identifier of the resource.</param>
        /// <param name="diagnosticsResourceName">Unique resource name for insight resources</param>
        /// <param name="body">The required request body for this insightResource invocation.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DiagnosticsCreate_Validate(string scope, string diagnosticsResourceName, Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiagnosticResource body, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(scope),scope);
                await eventListener.AssertNotNull(nameof(diagnosticsResourceName),diagnosticsResourceName);
                await eventListener.AssertMinimumLength(nameof(diagnosticsResourceName),diagnosticsResourceName,1);
                await eventListener.AssertMaximumLength(nameof(diagnosticsResourceName),diagnosticsResourceName,100);
                await eventListener.AssertRegEx(nameof(diagnosticsResourceName), diagnosticsResourceName, @"^[A-Za-z0-9-+@()_]+$");
                await eventListener.AssertNotNull(nameof(body), body);
                await eventListener.AssertObjectIsValid(nameof(body), body);
            }
        }

        /// <summary>
        /// Get the diagnostics using the 'diagnosticsResourceName' you chose while creating the diagnostic.
        /// </summary>
        /// <param name="scope">The fully qualified Azure Resource manager identifier of the resource.</param>
        /// <param name="diagnosticsResourceName">Unique resource name for insight resources</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DiagnosticsGet(string scope, string diagnosticsResourceName, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiagnosticResource>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/"
                        + (scope)
                        + "/providers/Microsoft.Help/diagnostics/"
                        + global::System.Uri.EscapeDataString(diagnosticsResourceName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DiagnosticsGet_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>
        /// Get the diagnostics using the 'diagnosticsResourceName' you chose while creating the diagnostic.
        /// </summary>
        /// <param name="viaIdentity"></param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DiagnosticsGetViaIdentity(global::System.String viaIdentity, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiagnosticResource>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/(?<scope>[^/]+)/providers/Microsoft.Help/diagnostics/(?<diagnosticsResourceName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/{scope}/providers/Microsoft.Help/diagnostics/{diagnosticsResourceName}'");
                }

                // replace URI parameters with values from identity
                var scope = _match.Groups["scope"].Value;
                var diagnosticsResourceName = _match.Groups["diagnosticsResourceName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/"
                        + scope
                        + "/providers/Microsoft.Help/diagnostics/"
                        + diagnosticsResourceName
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DiagnosticsGet_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>
        /// Get the diagnostics using the 'diagnosticsResourceName' you chose while creating the diagnostic.
        /// </summary>
        /// <param name="viaIdentity"></param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiagnosticResource>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiagnosticResource> DiagnosticsGetViaIdentityWithResult(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/(?<scope>[^/]+)/providers/Microsoft.Help/diagnostics/(?<diagnosticsResourceName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/{scope}/providers/Microsoft.Help/diagnostics/{diagnosticsResourceName}'");
                }

                // replace URI parameters with values from identity
                var scope = _match.Groups["scope"].Value;
                var diagnosticsResourceName = _match.Groups["diagnosticsResourceName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/"
                        + scope
                        + "/providers/Microsoft.Help/diagnostics/"
                        + diagnosticsResourceName
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.DiagnosticsGetWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>
        /// Get the diagnostics using the 'diagnosticsResourceName' you chose while creating the diagnostic.
        /// </summary>
        /// <param name="scope">The fully qualified Azure Resource manager identifier of the resource.</param>
        /// <param name="diagnosticsResourceName">Unique resource name for insight resources</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiagnosticResource>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiagnosticResource> DiagnosticsGetWithResult(string scope, string diagnosticsResourceName, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/"
                        + (scope)
                        + "/providers/Microsoft.Help/diagnostics/"
                        + global::System.Uri.EscapeDataString(diagnosticsResourceName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.DiagnosticsGetWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref= "DiagnosticsGetWithResult" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiagnosticResource>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiagnosticResource> DiagnosticsGetWithResult_Call(global::System.Net.Http.HttpRequestMessage request, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Help.Models.DiagnosticResource.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(body.Result)) );
                            return await _result;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(body.Result)) );
                            // Error Response : default
                            var code = (await _result)?.Code;
                            var message = (await _result)?.Message;
                            if ((null == code || null == message))
                            {
                                // Unrecognized Response. Create an error record based on what we have.
                                var ex = new Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>(_response, await _result);
                                throw ex;
                            }
                            else
                            {
                                throw new global::System.Exception($"[{code}] : {message}");
                            }
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>Actual wire call for <see cref= "DiagnosticsGet" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DiagnosticsGet_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiagnosticResource>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Help.Models.DiagnosticResource.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="DiagnosticsGet" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="scope">The fully qualified Azure Resource manager identifier of the resource.</param>
        /// <param name="diagnosticsResourceName">Unique resource name for insight resources</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DiagnosticsGet_Validate(string scope, string diagnosticsResourceName, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(scope),scope);
                await eventListener.AssertNotNull(nameof(diagnosticsResourceName),diagnosticsResourceName);
                await eventListener.AssertMinimumLength(nameof(diagnosticsResourceName),diagnosticsResourceName,1);
                await eventListener.AssertMaximumLength(nameof(diagnosticsResourceName),diagnosticsResourceName,100);
                await eventListener.AssertRegEx(nameof(diagnosticsResourceName), diagnosticsResourceName, @"^[A-Za-z0-9-+@()_]+$");
            }
        }

        /// <summary>
        /// Lists the relevant Azure Diagnostics, Solutions and Troubleshooters using [problemClassification API](https://learn.microsoft.com/rest/api/support/problem-classifications/list?tabs=HTTP))
        /// AND resourceUri or resourceType.<br/> Discovery Solutions is the initial entry point within Help API, which identifies
        /// relevant Azure diagnostics and solutions. <br/><br/> Required Input : problemClassificationId (Use the [problemClassification
        /// API](https://learn.microsoft.com/rest/api/support/problem-classifications/list?tabs=HTTP)) <br/>Optional input: resourceUri
        /// OR resource Type <br/><br/> <b>Note: </b> ‘requiredInputs’ from Discovery solutions response must be passed via ‘additionalParameters’
        /// as an input to Diagnostics and Solutions API.
        /// </summary>
        /// <param name="Filter">'ProblemClassificationId' is a mandatory filter to get solutions ids. It also supports optional 'ResourceType'
        /// and 'SolutionType' filters. The [$filter](https://learn.microsoft.com/en-us/odata/webapi/first-odata-api#filter) supports
        /// only 'and', 'or' and 'eq' operators. Example: $filter=ProblemClassificationId eq '1ddda5b4-cf6c-4d4f-91ad-bc38ab0e811e'</param>
        /// <param name="Skiptoken">Skiptoken is only used if a previous operation returned a partial result.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DiscoverySolutionList(string Filter, string Skiptoken, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiscoveryResponse>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/providers/Microsoft.Help/discoverySolutions"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        + "&"
                        + (string.IsNullOrEmpty(Filter) ? global::System.String.Empty : "$filter=" + global::System.Uri.EscapeDataString(Filter))
                        + "&"
                        + (string.IsNullOrEmpty(Skiptoken) ? global::System.String.Empty : "$skiptoken=" + global::System.Uri.EscapeDataString(Skiptoken))
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DiscoverySolutionList_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>
        /// Lists the relevant Azure Diagnostics, Solutions and Troubleshooters using [problemClassification API](https://learn.microsoft.com/rest/api/support/problem-classifications/list?tabs=HTTP))
        /// AND resourceUri or resourceType.<br/> Discovery Solutions is the initial entry point within Help API, which identifies
        /// relevant Azure diagnostics and solutions. <br/><br/> Required Input : problemClassificationId (Use the [problemClassification
        /// API](https://learn.microsoft.com/rest/api/support/problem-classifications/list?tabs=HTTP)) <br/>Optional input: resourceUri
        /// OR resource Type <br/><br/> <b>Note: </b> ‘requiredInputs’ from Discovery solutions response must be passed via ‘additionalParameters’
        /// as an input to Diagnostics and Solutions API.
        /// </summary>
        /// <param name="viaIdentity"></param>
        /// <param name="Filter">'ProblemClassificationId' is a mandatory filter to get solutions ids. It also supports optional 'ResourceType'
        /// and 'SolutionType' filters. The [$filter](https://learn.microsoft.com/en-us/odata/webapi/first-odata-api#filter) supports
        /// only 'and', 'or' and 'eq' operators. Example: $filter=ProblemClassificationId eq '1ddda5b4-cf6c-4d4f-91ad-bc38ab0e811e'</param>
        /// <param name="Skiptoken">Skiptoken is only used if a previous operation returned a partial result.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DiscoverySolutionListViaIdentity(global::System.String viaIdentity, string Filter, string Skiptoken, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiscoveryResponse>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/providers/Microsoft.Help/discoverySolutions$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/providers/Microsoft.Help/discoverySolutions'");
                }

                // replace URI parameters with values from identity
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/providers/Microsoft.Help/discoverySolutions"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        + "&"
                        + (string.IsNullOrEmpty(Filter) ? global::System.String.Empty : "$filter=" + global::System.Uri.EscapeDataString(Filter))
                        + "&"
                        + (string.IsNullOrEmpty(Skiptoken) ? global::System.String.Empty : "$skiptoken=" + global::System.Uri.EscapeDataString(Skiptoken))
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DiscoverySolutionList_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>
        /// Lists the relevant Azure Diagnostics, Solutions and Troubleshooters using [problemClassification API](https://learn.microsoft.com/rest/api/support/problem-classifications/list?tabs=HTTP))
        /// AND resourceUri or resourceType.<br/> Discovery Solutions is the initial entry point within Help API, which identifies
        /// relevant Azure diagnostics and solutions. <br/><br/> Required Input : problemClassificationId (Use the [problemClassification
        /// API](https://learn.microsoft.com/rest/api/support/problem-classifications/list?tabs=HTTP)) <br/>Optional input: resourceUri
        /// OR resource Type <br/><br/> <b>Note: </b> ‘requiredInputs’ from Discovery solutions response must be passed via ‘additionalParameters’
        /// as an input to Diagnostics and Solutions API.
        /// </summary>
        /// <param name="viaIdentity"></param>
        /// <param name="Filter">'ProblemClassificationId' is a mandatory filter to get solutions ids. It also supports optional 'ResourceType'
        /// and 'SolutionType' filters. The [$filter](https://learn.microsoft.com/en-us/odata/webapi/first-odata-api#filter) supports
        /// only 'and', 'or' and 'eq' operators. Example: $filter=ProblemClassificationId eq '1ddda5b4-cf6c-4d4f-91ad-bc38ab0e811e'</param>
        /// <param name="Skiptoken">Skiptoken is only used if a previous operation returned a partial result.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiscoveryResponse>" />
        /// that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiscoveryResponse> DiscoverySolutionListViaIdentityWithResult(global::System.String viaIdentity, string Filter, string Skiptoken, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/providers/Microsoft.Help/discoverySolutions$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/providers/Microsoft.Help/discoverySolutions'");
                }

                // replace URI parameters with values from identity
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/providers/Microsoft.Help/discoverySolutions"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        + "&"
                        + (string.IsNullOrEmpty(Filter) ? global::System.String.Empty : "$filter=" + global::System.Uri.EscapeDataString(Filter))
                        + "&"
                        + (string.IsNullOrEmpty(Skiptoken) ? global::System.String.Empty : "$skiptoken=" + global::System.Uri.EscapeDataString(Skiptoken))
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.DiscoverySolutionListWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>
        /// Lists the relevant Azure Diagnostics, Solutions and Troubleshooters using [problemClassification API](https://learn.microsoft.com/rest/api/support/problem-classifications/list?tabs=HTTP))
        /// AND resourceUri or resourceType.<br/> Discovery Solutions is the initial entry point within Help API, which identifies
        /// relevant Azure diagnostics and solutions. <br/><br/> Required Input : problemClassificationId (Use the [problemClassification
        /// API](https://learn.microsoft.com/rest/api/support/problem-classifications/list?tabs=HTTP)) <br/>Optional input: resourceUri
        /// OR resource Type <br/><br/> <b>Note: </b> ‘requiredInputs’ from Discovery solutions response must be passed via ‘additionalParameters’
        /// as an input to Diagnostics and Solutions API.
        /// </summary>
        /// <param name="Filter">'ProblemClassificationId' is a mandatory filter to get solutions ids. It also supports optional 'ResourceType'
        /// and 'SolutionType' filters. The [$filter](https://learn.microsoft.com/en-us/odata/webapi/first-odata-api#filter) supports
        /// only 'and', 'or' and 'eq' operators. Example: $filter=ProblemClassificationId eq '1ddda5b4-cf6c-4d4f-91ad-bc38ab0e811e'</param>
        /// <param name="Skiptoken">Skiptoken is only used if a previous operation returned a partial result.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiscoveryResponse>" />
        /// that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiscoveryResponse> DiscoverySolutionListWithResult(string Filter, string Skiptoken, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/providers/Microsoft.Help/discoverySolutions"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        + "&"
                        + (string.IsNullOrEmpty(Filter) ? global::System.String.Empty : "$filter=" + global::System.Uri.EscapeDataString(Filter))
                        + "&"
                        + (string.IsNullOrEmpty(Skiptoken) ? global::System.String.Empty : "$skiptoken=" + global::System.Uri.EscapeDataString(Skiptoken))
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.DiscoverySolutionListWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref= "DiscoverySolutionListWithResult" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiscoveryResponse>" />
        /// that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiscoveryResponse> DiscoverySolutionListWithResult_Call(global::System.Net.Http.HttpRequestMessage request, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Help.Models.DiscoveryResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(body.Result)) );
                            return await _result;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(body.Result)) );
                            // Error Response : default
                            var code = (await _result)?.Code;
                            var message = (await _result)?.Message;
                            if ((null == code || null == message))
                            {
                                // Unrecognized Response. Create an error record based on what we have.
                                var ex = new Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>(_response, await _result);
                                throw ex;
                            }
                            else
                            {
                                throw new global::System.Exception($"[{code}] : {message}");
                            }
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>Actual wire call for <see cref= "DiscoverySolutionList" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DiscoverySolutionList_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiscoveryResponse>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Help.Models.DiscoveryResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="DiscoverySolutionList" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="Filter">'ProblemClassificationId' is a mandatory filter to get solutions ids. It also supports optional 'ResourceType'
        /// and 'SolutionType' filters. The [$filter](https://learn.microsoft.com/en-us/odata/webapi/first-odata-api#filter) supports
        /// only 'and', 'or' and 'eq' operators. Example: $filter=ProblemClassificationId eq '1ddda5b4-cf6c-4d4f-91ad-bc38ab0e811e'</param>
        /// <param name="Skiptoken">Skiptoken is only used if a previous operation returned a partial result.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DiscoverySolutionList_Validate(string Filter, string Skiptoken, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(Filter),Filter);
                await eventListener.AssertNotNull(nameof(Skiptoken),Skiptoken);
            }
        }

        /// <summary>
        /// Search for relevant Azure Diagnostics, Solutions and Troubleshooters using a natural language issue summary.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DiscoverySolutionNlpDiscoverSolutions(Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiscoveryNlpRequest body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiscoveryNlpResponse>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/providers/Microsoft.Help/discoverSolutions"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DiscoverySolutionNlpDiscoverSolutions_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>
        /// Search for relevant Azure Diagnostics, Solutions and Troubleshooters using a natural language issue summary and subscription.
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="body">The request body</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DiscoverySolutionNlpDiscoverSolutionsBySubscription(string subscriptionId, Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiscoveryNlpRequest body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiscoveryNlpResponse>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/providers/Microsoft.Help/discoverSolutions"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DiscoverySolutionNlpDiscoverSolutionsBySubscription_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>
        /// Search for relevant Azure Diagnostics, Solutions and Troubleshooters using a natural language issue summary and subscription.
        /// </summary>
        /// <param name="viaIdentity"></param>
        /// <param name="body">The request body</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DiscoverySolutionNlpDiscoverSolutionsBySubscriptionViaIdentity(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiscoveryNlpRequest body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiscoveryNlpResponse>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/providers/Microsoft.Help$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/providers/Microsoft.Help'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/providers/Microsoft.Help/discoverSolutions"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DiscoverySolutionNlpDiscoverSolutionsBySubscription_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>
        /// Search for relevant Azure Diagnostics, Solutions and Troubleshooters using a natural language issue summary and subscription.
        /// </summary>
        /// <param name="viaIdentity"></param>
        /// <param name="body">The request body</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiscoveryNlpResponse>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiscoveryNlpResponse> DiscoverySolutionNlpDiscoverSolutionsBySubscriptionViaIdentityWithResult(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiscoveryNlpRequest body, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/providers/Microsoft.Help$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/providers/Microsoft.Help'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/providers/Microsoft.Help/discoverSolutions"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.DiscoverySolutionNlpDiscoverSolutionsBySubscriptionWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>
        /// Search for relevant Azure Diagnostics, Solutions and Troubleshooters using a natural language issue summary and subscription.
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="jsonString">Json string supplied to the DiscoverySolutionNlpDiscoverSolutionsBySubscription operation</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DiscoverySolutionNlpDiscoverSolutionsBySubscriptionViaJsonString(string subscriptionId, global::System.String jsonString, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiscoveryNlpResponse>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/providers/Microsoft.Help/discoverSolutions"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(jsonString, global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DiscoverySolutionNlpDiscoverSolutionsBySubscription_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>
        /// Search for relevant Azure Diagnostics, Solutions and Troubleshooters using a natural language issue summary and subscription.
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="jsonString">Json string supplied to the DiscoverySolutionNlpDiscoverSolutionsBySubscription operation</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiscoveryNlpResponse>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiscoveryNlpResponse> DiscoverySolutionNlpDiscoverSolutionsBySubscriptionViaJsonStringWithResult(string subscriptionId, global::System.String jsonString, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/providers/Microsoft.Help/discoverSolutions"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(jsonString, global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.DiscoverySolutionNlpDiscoverSolutionsBySubscriptionWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>
        /// Search for relevant Azure Diagnostics, Solutions and Troubleshooters using a natural language issue summary and subscription.
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="body">The request body</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiscoveryNlpResponse>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiscoveryNlpResponse> DiscoverySolutionNlpDiscoverSolutionsBySubscriptionWithResult(string subscriptionId, Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiscoveryNlpRequest body, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/providers/Microsoft.Help/discoverSolutions"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.DiscoverySolutionNlpDiscoverSolutionsBySubscriptionWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>
        /// Actual wire call for <see cref= "DiscoverySolutionNlpDiscoverSolutionsBySubscriptionWithResult" /> method.
        /// </summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiscoveryNlpResponse>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiscoveryNlpResponse> DiscoverySolutionNlpDiscoverSolutionsBySubscriptionWithResult_Call(global::System.Net.Http.HttpRequestMessage request, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Help.Models.DiscoveryNlpResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(body.Result)) );
                            return await _result;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(body.Result)) );
                            // Error Response : default
                            var code = (await _result)?.Code;
                            var message = (await _result)?.Message;
                            if ((null == code || null == message))
                            {
                                // Unrecognized Response. Create an error record based on what we have.
                                var ex = new Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>(_response, await _result);
                                throw ex;
                            }
                            else
                            {
                                throw new global::System.Exception($"[{code}] : {message}");
                            }
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Actual wire call for <see cref= "DiscoverySolutionNlpDiscoverSolutionsBySubscription" /> method.
        /// </summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DiscoverySolutionNlpDiscoverSolutionsBySubscription_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiscoveryNlpResponse>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Help.Models.DiscoveryNlpResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="DiscoverySolutionNlpDiscoverSolutionsBySubscription" /> method. Call this like the actual
        /// call, but you will get validation events back.
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="body">The request body</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DiscoverySolutionNlpDiscoverSolutionsBySubscription_Validate(string subscriptionId, Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiscoveryNlpRequest body, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(subscriptionId),subscriptionId);
                await eventListener.AssertMinimumLength(nameof(subscriptionId),subscriptionId,1);
                await eventListener.AssertNotNull(nameof(body), body);
                await eventListener.AssertObjectIsValid(nameof(body), body);
            }
        }

        /// <summary>
        /// Search for relevant Azure Diagnostics, Solutions and Troubleshooters using a natural language issue summary.
        /// </summary>
        /// <param name="viaIdentity"></param>
        /// <param name="body">The request body</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DiscoverySolutionNlpDiscoverSolutionsViaIdentity(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiscoveryNlpRequest body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiscoveryNlpResponse>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/providers/Microsoft.Help$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/providers/Microsoft.Help'");
                }

                // replace URI parameters with values from identity
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/providers/Microsoft.Help/discoverSolutions"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DiscoverySolutionNlpDiscoverSolutions_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>
        /// Search for relevant Azure Diagnostics, Solutions and Troubleshooters using a natural language issue summary.
        /// </summary>
        /// <param name="viaIdentity"></param>
        /// <param name="body">The request body</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiscoveryNlpResponse>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiscoveryNlpResponse> DiscoverySolutionNlpDiscoverSolutionsViaIdentityWithResult(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiscoveryNlpRequest body, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/providers/Microsoft.Help$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/providers/Microsoft.Help'");
                }

                // replace URI parameters with values from identity
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/providers/Microsoft.Help/discoverSolutions"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.DiscoverySolutionNlpDiscoverSolutionsWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>
        /// Search for relevant Azure Diagnostics, Solutions and Troubleshooters using a natural language issue summary.
        /// </summary>
        /// <param name="jsonString">Json string supplied to the DiscoverySolutionNlpDiscoverSolutions operation</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DiscoverySolutionNlpDiscoverSolutionsViaJsonString(global::System.String jsonString, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiscoveryNlpResponse>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/providers/Microsoft.Help/discoverSolutions"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(jsonString, global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DiscoverySolutionNlpDiscoverSolutions_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>
        /// Search for relevant Azure Diagnostics, Solutions and Troubleshooters using a natural language issue summary.
        /// </summary>
        /// <param name="jsonString">Json string supplied to the DiscoverySolutionNlpDiscoverSolutions operation</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiscoveryNlpResponse>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiscoveryNlpResponse> DiscoverySolutionNlpDiscoverSolutionsViaJsonStringWithResult(global::System.String jsonString, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/providers/Microsoft.Help/discoverSolutions"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(jsonString, global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.DiscoverySolutionNlpDiscoverSolutionsWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>
        /// Search for relevant Azure Diagnostics, Solutions and Troubleshooters using a natural language issue summary.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiscoveryNlpResponse>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiscoveryNlpResponse> DiscoverySolutionNlpDiscoverSolutionsWithResult(Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiscoveryNlpRequest body, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/providers/Microsoft.Help/discoverSolutions"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.DiscoverySolutionNlpDiscoverSolutionsWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>
        /// Actual wire call for <see cref= "DiscoverySolutionNlpDiscoverSolutionsWithResult" /> method.
        /// </summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiscoveryNlpResponse>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiscoveryNlpResponse> DiscoverySolutionNlpDiscoverSolutionsWithResult_Call(global::System.Net.Http.HttpRequestMessage request, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Help.Models.DiscoveryNlpResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(body.Result)) );
                            return await _result;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(body.Result)) );
                            // Error Response : default
                            var code = (await _result)?.Code;
                            var message = (await _result)?.Message;
                            if ((null == code || null == message))
                            {
                                // Unrecognized Response. Create an error record based on what we have.
                                var ex = new Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>(_response, await _result);
                                throw ex;
                            }
                            else
                            {
                                throw new global::System.Exception($"[{code}] : {message}");
                            }
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Actual wire call for <see cref= "DiscoverySolutionNlpDiscoverSolutions" /> method.
        /// </summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DiscoverySolutionNlpDiscoverSolutions_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiscoveryNlpResponse>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Help.Models.DiscoveryNlpResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="DiscoverySolutionNlpDiscoverSolutions" /> method. Call this like the actual call, but
        /// you will get validation events back.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DiscoverySolutionNlpDiscoverSolutions_Validate(Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiscoveryNlpRequest body, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(body), body);
                await eventListener.AssertObjectIsValid(nameof(body), body);
            }
        }

        /// <summary>List the operations for the provider</summary>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task OperationsList(global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IOperationListResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/providers/Microsoft.Help/operations"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.OperationsList_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>List the operations for the provider</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task OperationsListViaIdentity(global::System.String viaIdentity, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IOperationListResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/providers/Microsoft.Help/operations$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/providers/Microsoft.Help/operations'");
                }

                // replace URI parameters with values from identity
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/providers/Microsoft.Help/operations"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.OperationsList_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>List the operations for the provider</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IOperationListResult>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IOperationListResult> OperationsListViaIdentityWithResult(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/providers/Microsoft.Help/operations$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/providers/Microsoft.Help/operations'");
                }

                // replace URI parameters with values from identity
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/providers/Microsoft.Help/operations"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.OperationsListWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>List the operations for the provider</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IOperationListResult>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IOperationListResult> OperationsListWithResult(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/providers/Microsoft.Help/operations"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.OperationsListWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref= "OperationsListWithResult" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IOperationListResult>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IOperationListResult> OperationsListWithResult_Call(global::System.Net.Http.HttpRequestMessage request, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Help.Models.OperationListResult.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(body.Result)) );
                            return await _result;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(body.Result)) );
                            // Error Response : default
                            var code = (await _result)?.Code;
                            var message = (await _result)?.Message;
                            if ((null == code || null == message))
                            {
                                // Unrecognized Response. Create an error record based on what we have.
                                var ex = new Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>(_response, await _result);
                                throw ex;
                            }
                            else
                            {
                                throw new global::System.Exception($"[{code}] : {message}");
                            }
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>Actual wire call for <see cref= "OperationsList" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task OperationsList_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IOperationListResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Help.Models.OperationListResult.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="OperationsList" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task OperationsList_Validate(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {

            }
        }

        /// <summary>
        /// update Simplified Solutions for an Azure subscription using 'solutionId' from Discovery Solutions as the input. <br/><br/>
        /// Simplified Solutions API makes the consumption of solutions APIs easier while still providing access to the same powerful
        /// solutions rendered in Solutions API. With Simplified Solutions, users don't have to worry about stitching together the
        /// article using replacement maps and can use the content in the API response to directly render as HTML content.<br/>
        /// </summary>
        /// <param name="scope">The fully qualified Azure Resource manager identifier of the resource.</param>
        /// <param name="simplifiedSolutionsResourceName">Simplified Solutions Resource Name.</param>
        /// <param name="body">The required request body for simplified Solutions resource creation.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task SimplifiedSolutionsCreate(string scope, string simplifiedSolutionsResourceName, Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISimplifiedSolutionsResource body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISimplifiedSolutionsResource>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/"
                        + (scope)
                        + "/providers/Microsoft.Help/simplifiedSolutions/"
                        + global::System.Uri.EscapeDataString(simplifiedSolutionsResourceName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Put, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.SimplifiedSolutionsCreate_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>
        /// update Simplified Solutions for an Azure subscription using 'solutionId' from Discovery Solutions as the input. <br/><br/>
        /// Simplified Solutions API makes the consumption of solutions APIs easier while still providing access to the same powerful
        /// solutions rendered in Solutions API. With Simplified Solutions, users don't have to worry about stitching together the
        /// article using replacement maps and can use the content in the API response to directly render as HTML content.<br/>
        /// </summary>
        /// <param name="viaIdentity"></param>
        /// <param name="body">The required request body for simplified Solutions resource creation.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task SimplifiedSolutionsCreateViaIdentity(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISimplifiedSolutionsResource body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISimplifiedSolutionsResource>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/(?<scope>[^/]+)/providers/Microsoft.Help/simplifiedSolutions/(?<simplifiedSolutionsResourceName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/{scope}/providers/Microsoft.Help/simplifiedSolutions/{simplifiedSolutionsResourceName}'");
                }

                // replace URI parameters with values from identity
                var scope = _match.Groups["scope"].Value;
                var simplifiedSolutionsResourceName = _match.Groups["simplifiedSolutionsResourceName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/"
                        + scope
                        + "/providers/Microsoft.Help/simplifiedSolutions/"
                        + simplifiedSolutionsResourceName
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Put, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.SimplifiedSolutionsCreate_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>
        /// update Simplified Solutions for an Azure subscription using 'solutionId' from Discovery Solutions as the input. <br/><br/>
        /// Simplified Solutions API makes the consumption of solutions APIs easier while still providing access to the same powerful
        /// solutions rendered in Solutions API. With Simplified Solutions, users don't have to worry about stitching together the
        /// article using replacement maps and can use the content in the API response to directly render as HTML content.<br/>
        /// </summary>
        /// <param name="viaIdentity"></param>
        /// <param name="body">The required request body for simplified Solutions resource creation.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISimplifiedSolutionsResource>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISimplifiedSolutionsResource> SimplifiedSolutionsCreateViaIdentityWithResult(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISimplifiedSolutionsResource body, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/(?<scope>[^/]+)/providers/Microsoft.Help/simplifiedSolutions/(?<simplifiedSolutionsResourceName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/{scope}/providers/Microsoft.Help/simplifiedSolutions/{simplifiedSolutionsResourceName}'");
                }

                // replace URI parameters with values from identity
                var scope = _match.Groups["scope"].Value;
                var simplifiedSolutionsResourceName = _match.Groups["simplifiedSolutionsResourceName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/"
                        + scope
                        + "/providers/Microsoft.Help/simplifiedSolutions/"
                        + simplifiedSolutionsResourceName
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Put, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.SimplifiedSolutionsCreateWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>
        /// update Simplified Solutions for an Azure subscription using 'solutionId' from Discovery Solutions as the input. <br/><br/>
        /// Simplified Solutions API makes the consumption of solutions APIs easier while still providing access to the same powerful
        /// solutions rendered in Solutions API. With Simplified Solutions, users don't have to worry about stitching together the
        /// article using replacement maps and can use the content in the API response to directly render as HTML content.<br/>
        /// </summary>
        /// <param name="scope">The fully qualified Azure Resource manager identifier of the resource.</param>
        /// <param name="simplifiedSolutionsResourceName">Simplified Solutions Resource Name.</param>
        /// <param name="jsonString">Json string supplied to the SimplifiedSolutionsCreate operation</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task SimplifiedSolutionsCreateViaJsonString(string scope, string simplifiedSolutionsResourceName, global::System.String jsonString, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISimplifiedSolutionsResource>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/"
                        + (scope)
                        + "/providers/Microsoft.Help/simplifiedSolutions/"
                        + global::System.Uri.EscapeDataString(simplifiedSolutionsResourceName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Put, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(jsonString, global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.SimplifiedSolutionsCreate_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>
        /// update Simplified Solutions for an Azure subscription using 'solutionId' from Discovery Solutions as the input. <br/><br/>
        /// Simplified Solutions API makes the consumption of solutions APIs easier while still providing access to the same powerful
        /// solutions rendered in Solutions API. With Simplified Solutions, users don't have to worry about stitching together the
        /// article using replacement maps and can use the content in the API response to directly render as HTML content.<br/>
        /// </summary>
        /// <param name="scope">The fully qualified Azure Resource manager identifier of the resource.</param>
        /// <param name="simplifiedSolutionsResourceName">Simplified Solutions Resource Name.</param>
        /// <param name="jsonString">Json string supplied to the SimplifiedSolutionsCreate operation</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISimplifiedSolutionsResource>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISimplifiedSolutionsResource> SimplifiedSolutionsCreateViaJsonStringWithResult(string scope, string simplifiedSolutionsResourceName, global::System.String jsonString, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/"
                        + (scope)
                        + "/providers/Microsoft.Help/simplifiedSolutions/"
                        + global::System.Uri.EscapeDataString(simplifiedSolutionsResourceName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Put, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(jsonString, global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.SimplifiedSolutionsCreateWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>
        /// update Simplified Solutions for an Azure subscription using 'solutionId' from Discovery Solutions as the input. <br/><br/>
        /// Simplified Solutions API makes the consumption of solutions APIs easier while still providing access to the same powerful
        /// solutions rendered in Solutions API. With Simplified Solutions, users don't have to worry about stitching together the
        /// article using replacement maps and can use the content in the API response to directly render as HTML content.<br/>
        /// </summary>
        /// <param name="scope">The fully qualified Azure Resource manager identifier of the resource.</param>
        /// <param name="simplifiedSolutionsResourceName">Simplified Solutions Resource Name.</param>
        /// <param name="body">The required request body for simplified Solutions resource creation.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISimplifiedSolutionsResource>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISimplifiedSolutionsResource> SimplifiedSolutionsCreateWithResult(string scope, string simplifiedSolutionsResourceName, Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISimplifiedSolutionsResource body, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/"
                        + (scope)
                        + "/providers/Microsoft.Help/simplifiedSolutions/"
                        + global::System.Uri.EscapeDataString(simplifiedSolutionsResourceName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Put, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.SimplifiedSolutionsCreateWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>
        /// Actual wire call for <see cref= "SimplifiedSolutionsCreateWithResult" /> method.
        /// </summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISimplifiedSolutionsResource>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISimplifiedSolutionsResource> SimplifiedSolutionsCreateWithResult_Call(global::System.Net.Http.HttpRequestMessage request, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    // this operation supports x-ms-long-running-operation
                    var _originalUri = request.RequestUri.AbsoluteUri;
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Progress, "intentional placeholder", 0); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    // declared final-state-via: azure-async-operation
                    var asyncOperation = _response.GetFirstHeader(@"Azure-AsyncOperation");
                    var location = _response.GetFirstHeader(@"Location");
                    var operationLocation = _response.GetFirstHeader(@"Operation-Location");
                    while (request.Method == System.Net.Http.HttpMethod.Put && _response.StatusCode == global::System.Net.HttpStatusCode.OK || _response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                    {
                        // delay before making the next polling request
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.DelayBeforePolling, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }

                        // while we wait, let's grab the headers and get ready to poll.
                        if (!System.String.IsNullOrEmpty(_response.GetFirstHeader(@"Azure-AsyncOperation"))) {
                            asyncOperation = _response.GetFirstHeader(@"Azure-AsyncOperation");
                        }
                        if (!global::System.String.IsNullOrEmpty(_response.GetFirstHeader(@"Location"))) {
                            location = _response.GetFirstHeader(@"Location");
                        }
                        if (!global::System.String.IsNullOrEmpty(_response.GetFirstHeader(@"Operation-Location"))) {
                            operationLocation = _response.GetFirstHeader(@"Operation-Location");
                        }
                        var _uri = global::System.String.IsNullOrEmpty(asyncOperation) ? global::System.String.IsNullOrEmpty(location) ? global::System.String.IsNullOrEmpty(operationLocation) ? _originalUri : operationLocation : location : asyncOperation;
                        request = request.CloneAndDispose(new global::System.Uri(_uri), Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Get);

                        // and let's look at the current response body and see if we have some information we can give back to the listener
                        var content = await _response.Content.ReadAsStringAsync();

                        // drop the old response
                        _response?.Dispose();

                        // make the polling call
                        _response = await sender.SendAsync(request, eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }

                          // if we got back an OK, take a peek inside and see if it's done
                          if( _response.StatusCode == global::System.Net.HttpStatusCode.OK)
                          {
                              var error = false;
                              try {
                                  if( Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(await _response.Content.ReadAsStringAsync()) is Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonObject json)
                                  {
                                      var state = json.Property("properties")?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonString>("provisioningState") ?? json.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonString>("status");
                                      if( state is null )
                                      {
                                          // the body doesn't contain any information that has the state of the LRO
                                          // we're going to just get out, and let the consumer have the result
                                          break;
                                      }

                                      switch( state?.ToString()?.ToLower() )
                                      {
                                        case "failed":
                                            error = true;
                                            break;
                                        case "succeeded":
                                        case "canceled":
                                          // we're done polling.
                                          break;

                                        default:
                                          // need to keep polling!
                                          _response.StatusCode = global::System.Net.HttpStatusCode.Created;
                                          continue;
                                      }
                                  }
                              } catch {
                                  // if we run into a problem peeking into the result,
                                  // we really don't want to do anything special.
                              }
                              if (error) {
                                  throw new Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.UndeclaredResponseException(_response);
                              }
                          }

                        // check for terminal status code
                        if (_response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                        {
                            continue;
                        }
                        // we are done polling, do a request on final target?
                        // create a new request with the final uri
                        request = request.CloneAndDispose(new global::System.Uri(_originalUri), Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Get);

                        // drop the old response
                        _response?.Dispose();

                        // make the final call
                        _response = await sender.SendAsync(request,  eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                        break;
                    }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Help.Models.SimplifiedSolutionsResource.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(body.Result)) );
                            return await _result;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(body.Result)) );
                            // Error Response : default
                            var code = (await _result)?.Code;
                            var message = (await _result)?.Message;
                            if ((null == code || null == message))
                            {
                                // Unrecognized Response. Create an error record based on what we have.
                                var ex = new Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>(_response, await _result);
                                throw ex;
                            }
                            else
                            {
                                throw new global::System.Exception($"[{code}] : {message}");
                            }
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>Actual wire call for <see cref= "SimplifiedSolutionsCreate" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task SimplifiedSolutionsCreate_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISimplifiedSolutionsResource>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    // this operation supports x-ms-long-running-operation
                    var _originalUri = request.RequestUri.AbsoluteUri;
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Progress, "intentional placeholder", 0); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    // declared final-state-via: azure-async-operation
                    var asyncOperation = _response.GetFirstHeader(@"Azure-AsyncOperation");
                    var location = _response.GetFirstHeader(@"Location");
                    var operationLocation = _response.GetFirstHeader(@"Operation-Location");
                    while (request.Method == System.Net.Http.HttpMethod.Put && _response.StatusCode == global::System.Net.HttpStatusCode.OK || _response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                    {
                        // delay before making the next polling request
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.DelayBeforePolling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }

                        // while we wait, let's grab the headers and get ready to poll.
                        if (!System.String.IsNullOrEmpty(_response.GetFirstHeader(@"Azure-AsyncOperation"))) {
                            asyncOperation = _response.GetFirstHeader(@"Azure-AsyncOperation");
                        }
                        if (!global::System.String.IsNullOrEmpty(_response.GetFirstHeader(@"Location"))) {
                            location = _response.GetFirstHeader(@"Location");
                        }
                        if (!global::System.String.IsNullOrEmpty(_response.GetFirstHeader(@"Operation-Location"))) {
                            operationLocation = _response.GetFirstHeader(@"Operation-Location");
                        }
                        var _uri = global::System.String.IsNullOrEmpty(asyncOperation) ? global::System.String.IsNullOrEmpty(location) ? global::System.String.IsNullOrEmpty(operationLocation) ? _originalUri : operationLocation : location : asyncOperation;
                        request = request.CloneAndDispose(new global::System.Uri(_uri), Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Get);

                        // and let's look at the current response body and see if we have some information we can give back to the listener
                        var content = await _response.Content.ReadAsStringAsync();

                        // drop the old response
                        _response?.Dispose();

                        // make the polling call
                        _response = await sender.SendAsync(request, eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }

                          // if we got back an OK, take a peek inside and see if it's done
                          if( _response.StatusCode == global::System.Net.HttpStatusCode.OK)
                          {
                              var error = false;
                              try {
                                  if( Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(await _response.Content.ReadAsStringAsync()) is Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonObject json)
                                  {
                                      var state = json.Property("properties")?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonString>("provisioningState") ?? json.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonString>("status");
                                      if( state is null )
                                      {
                                          // the body doesn't contain any information that has the state of the LRO
                                          // we're going to just get out, and let the consumer have the result
                                          break;
                                      }

                                      switch( state?.ToString()?.ToLower() )
                                      {
                                        case "failed":
                                            error = true;
                                            break;
                                        case "succeeded":
                                        case "canceled":
                                          // we're done polling.
                                          break;

                                        default:
                                          // need to keep polling!
                                          _response.StatusCode = global::System.Net.HttpStatusCode.Created;
                                          continue;
                                      }
                                  }
                              } catch {
                                  // if we run into a problem peeking into the result,
                                  // we really don't want to do anything special.
                              }
                              if (error) {
                                  throw new Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.UndeclaredResponseException(_response);
                              }
                          }

                        // check for terminal status code
                        if (_response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                        {
                            continue;
                        }
                        // we are done polling, do a request on final target?
                        // create a new request with the final uri
                        request = request.CloneAndDispose(new global::System.Uri(_originalUri), Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Get);

                        // drop the old response
                        _response?.Dispose();

                        // make the final call
                        _response = await sender.SendAsync(request,  eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                        break;
                    }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Help.Models.SimplifiedSolutionsResource.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="SimplifiedSolutionsCreate" /> method. Call this like the actual call, but you will get
        /// validation events back.
        /// </summary>
        /// <param name="scope">The fully qualified Azure Resource manager identifier of the resource.</param>
        /// <param name="simplifiedSolutionsResourceName">Simplified Solutions Resource Name.</param>
        /// <param name="body">The required request body for simplified Solutions resource creation.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task SimplifiedSolutionsCreate_Validate(string scope, string simplifiedSolutionsResourceName, Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISimplifiedSolutionsResource body, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(scope),scope);
                await eventListener.AssertNotNull(nameof(simplifiedSolutionsResourceName),simplifiedSolutionsResourceName);
                await eventListener.AssertMinimumLength(nameof(simplifiedSolutionsResourceName),simplifiedSolutionsResourceName,1);
                await eventListener.AssertMaximumLength(nameof(simplifiedSolutionsResourceName),simplifiedSolutionsResourceName,100);
                await eventListener.AssertRegEx(nameof(simplifiedSolutionsResourceName), simplifiedSolutionsResourceName, @"^[A-Za-z0-9-+@()_]+$");
                await eventListener.AssertNotNull(nameof(body), body);
                await eventListener.AssertObjectIsValid(nameof(body), body);
            }
        }

        /// <summary>
        /// Get the simplified Solutions using the applicable solutionResourceName while creating the simplified Solutions.
        /// </summary>
        /// <param name="scope">The fully qualified Azure Resource manager identifier of the resource.</param>
        /// <param name="simplifiedSolutionsResourceName">Simplified Solutions Resource Name.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task SimplifiedSolutionsGet(string scope, string simplifiedSolutionsResourceName, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISimplifiedSolutionsResource>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/"
                        + (scope)
                        + "/providers/Microsoft.Help/simplifiedSolutions/"
                        + global::System.Uri.EscapeDataString(simplifiedSolutionsResourceName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.SimplifiedSolutionsGet_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>
        /// Get the simplified Solutions using the applicable solutionResourceName while creating the simplified Solutions.
        /// </summary>
        /// <param name="viaIdentity"></param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task SimplifiedSolutionsGetViaIdentity(global::System.String viaIdentity, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISimplifiedSolutionsResource>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/(?<scope>[^/]+)/providers/Microsoft.Help/simplifiedSolutions/(?<simplifiedSolutionsResourceName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/{scope}/providers/Microsoft.Help/simplifiedSolutions/{simplifiedSolutionsResourceName}'");
                }

                // replace URI parameters with values from identity
                var scope = _match.Groups["scope"].Value;
                var simplifiedSolutionsResourceName = _match.Groups["simplifiedSolutionsResourceName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/"
                        + scope
                        + "/providers/Microsoft.Help/simplifiedSolutions/"
                        + simplifiedSolutionsResourceName
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.SimplifiedSolutionsGet_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>
        /// Get the simplified Solutions using the applicable solutionResourceName while creating the simplified Solutions.
        /// </summary>
        /// <param name="viaIdentity"></param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISimplifiedSolutionsResource>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISimplifiedSolutionsResource> SimplifiedSolutionsGetViaIdentityWithResult(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/(?<scope>[^/]+)/providers/Microsoft.Help/simplifiedSolutions/(?<simplifiedSolutionsResourceName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/{scope}/providers/Microsoft.Help/simplifiedSolutions/{simplifiedSolutionsResourceName}'");
                }

                // replace URI parameters with values from identity
                var scope = _match.Groups["scope"].Value;
                var simplifiedSolutionsResourceName = _match.Groups["simplifiedSolutionsResourceName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/"
                        + scope
                        + "/providers/Microsoft.Help/simplifiedSolutions/"
                        + simplifiedSolutionsResourceName
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.SimplifiedSolutionsGetWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>
        /// Get the simplified Solutions using the applicable solutionResourceName while creating the simplified Solutions.
        /// </summary>
        /// <param name="scope">The fully qualified Azure Resource manager identifier of the resource.</param>
        /// <param name="simplifiedSolutionsResourceName">Simplified Solutions Resource Name.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISimplifiedSolutionsResource>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISimplifiedSolutionsResource> SimplifiedSolutionsGetWithResult(string scope, string simplifiedSolutionsResourceName, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/"
                        + (scope)
                        + "/providers/Microsoft.Help/simplifiedSolutions/"
                        + global::System.Uri.EscapeDataString(simplifiedSolutionsResourceName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.SimplifiedSolutionsGetWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref= "SimplifiedSolutionsGetWithResult" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISimplifiedSolutionsResource>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISimplifiedSolutionsResource> SimplifiedSolutionsGetWithResult_Call(global::System.Net.Http.HttpRequestMessage request, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Help.Models.SimplifiedSolutionsResource.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(body.Result)) );
                            return await _result;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(body.Result)) );
                            // Error Response : default
                            var code = (await _result)?.Code;
                            var message = (await _result)?.Message;
                            if ((null == code || null == message))
                            {
                                // Unrecognized Response. Create an error record based on what we have.
                                var ex = new Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>(_response, await _result);
                                throw ex;
                            }
                            else
                            {
                                throw new global::System.Exception($"[{code}] : {message}");
                            }
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>Actual wire call for <see cref= "SimplifiedSolutionsGet" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task SimplifiedSolutionsGet_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISimplifiedSolutionsResource>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Help.Models.SimplifiedSolutionsResource.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="SimplifiedSolutionsGet" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="scope">The fully qualified Azure Resource manager identifier of the resource.</param>
        /// <param name="simplifiedSolutionsResourceName">Simplified Solutions Resource Name.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task SimplifiedSolutionsGet_Validate(string scope, string simplifiedSolutionsResourceName, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(scope),scope);
                await eventListener.AssertNotNull(nameof(simplifiedSolutionsResourceName),simplifiedSolutionsResourceName);
                await eventListener.AssertMinimumLength(nameof(simplifiedSolutionsResourceName),simplifiedSolutionsResourceName,1);
                await eventListener.AssertMaximumLength(nameof(simplifiedSolutionsResourceName),simplifiedSolutionsResourceName,100);
                await eventListener.AssertRegEx(nameof(simplifiedSolutionsResourceName), simplifiedSolutionsResourceName, @"^[A-Za-z0-9-+@()_]+$");
            }
        }

        /// <summary>
        /// create a solution for the specific Azure resource or subscription using the inputs ‘solutionId and requiredInputs’ from
        /// discovery solutions. <br/> Azure solutions comprise a comprehensive library of self-help resources that have been thoughtfully
        /// curated by Azure engineers to aid customers in resolving typical troubleshooting issues. These solutions encompass: <br/>
        /// (1.) Dynamic and context-aware diagnostics, guided troubleshooting wizards, and data visualizations. <br/> (2.) Rich instructional
        /// video tutorials and illustrative diagrams and images. <br/> (3.) Thoughtfully assembled textual troubleshooting instructions.
        /// <br/> All these components are seamlessly converged into unified solutions tailored to address a specific support problem
        /// area.
        /// </summary>
        /// <param name="scope">The fully qualified Azure Resource manager identifier of the resource.</param>
        /// <param name="solutionResourceName">Solution resource Name.</param>
        /// <param name="body">The required request body for this solution resource creation.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task SolutionCreate(string scope, string solutionResourceName, Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResource body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResource>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/"
                        + (scope)
                        + "/providers/Microsoft.Help/solutions/"
                        + global::System.Uri.EscapeDataString(solutionResourceName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Put, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.SolutionCreate_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>
        /// create a solution for the specific Azure resource or subscription using the inputs ‘solutionId and requiredInputs’ from
        /// discovery solutions. <br/> Azure solutions comprise a comprehensive library of self-help resources that have been thoughtfully
        /// curated by Azure engineers to aid customers in resolving typical troubleshooting issues. These solutions encompass: <br/>
        /// (1.) Dynamic and context-aware diagnostics, guided troubleshooting wizards, and data visualizations. <br/> (2.) Rich instructional
        /// video tutorials and illustrative diagrams and images. <br/> (3.) Thoughtfully assembled textual troubleshooting instructions.
        /// <br/> All these components are seamlessly converged into unified solutions tailored to address a specific support problem
        /// area.
        /// </summary>
        /// <param name="viaIdentity"></param>
        /// <param name="body">The required request body for this solution resource creation.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task SolutionCreateViaIdentity(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResource body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResource>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/(?<scope>[^/]+)/providers/Microsoft.Help/solutions/(?<solutionResourceName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/{scope}/providers/Microsoft.Help/solutions/{solutionResourceName}'");
                }

                // replace URI parameters with values from identity
                var scope = _match.Groups["scope"].Value;
                var solutionResourceName = _match.Groups["solutionResourceName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/"
                        + scope
                        + "/providers/Microsoft.Help/solutions/"
                        + solutionResourceName
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Put, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.SolutionCreate_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>
        /// create a solution for the specific Azure resource or subscription using the inputs ‘solutionId and requiredInputs’ from
        /// discovery solutions. <br/> Azure solutions comprise a comprehensive library of self-help resources that have been thoughtfully
        /// curated by Azure engineers to aid customers in resolving typical troubleshooting issues. These solutions encompass: <br/>
        /// (1.) Dynamic and context-aware diagnostics, guided troubleshooting wizards, and data visualizations. <br/> (2.) Rich instructional
        /// video tutorials and illustrative diagrams and images. <br/> (3.) Thoughtfully assembled textual troubleshooting instructions.
        /// <br/> All these components are seamlessly converged into unified solutions tailored to address a specific support problem
        /// area.
        /// </summary>
        /// <param name="viaIdentity"></param>
        /// <param name="body">The required request body for this solution resource creation.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResource>" />
        /// that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResource> SolutionCreateViaIdentityWithResult(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResource body, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/(?<scope>[^/]+)/providers/Microsoft.Help/solutions/(?<solutionResourceName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/{scope}/providers/Microsoft.Help/solutions/{solutionResourceName}'");
                }

                // replace URI parameters with values from identity
                var scope = _match.Groups["scope"].Value;
                var solutionResourceName = _match.Groups["solutionResourceName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/"
                        + scope
                        + "/providers/Microsoft.Help/solutions/"
                        + solutionResourceName
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Put, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.SolutionCreateWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>
        /// create a solution for the specific Azure resource or subscription using the inputs ‘solutionId and requiredInputs’ from
        /// discovery solutions. <br/> Azure solutions comprise a comprehensive library of self-help resources that have been thoughtfully
        /// curated by Azure engineers to aid customers in resolving typical troubleshooting issues. These solutions encompass: <br/>
        /// (1.) Dynamic and context-aware diagnostics, guided troubleshooting wizards, and data visualizations. <br/> (2.) Rich instructional
        /// video tutorials and illustrative diagrams and images. <br/> (3.) Thoughtfully assembled textual troubleshooting instructions.
        /// <br/> All these components are seamlessly converged into unified solutions tailored to address a specific support problem
        /// area.
        /// </summary>
        /// <param name="scope">The fully qualified Azure Resource manager identifier of the resource.</param>
        /// <param name="solutionResourceName">Solution resource Name.</param>
        /// <param name="jsonString">Json string supplied to the SolutionCreate operation</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task SolutionCreateViaJsonString(string scope, string solutionResourceName, global::System.String jsonString, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResource>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/"
                        + (scope)
                        + "/providers/Microsoft.Help/solutions/"
                        + global::System.Uri.EscapeDataString(solutionResourceName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Put, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(jsonString, global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.SolutionCreate_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>
        /// create a solution for the specific Azure resource or subscription using the inputs ‘solutionId and requiredInputs’ from
        /// discovery solutions. <br/> Azure solutions comprise a comprehensive library of self-help resources that have been thoughtfully
        /// curated by Azure engineers to aid customers in resolving typical troubleshooting issues. These solutions encompass: <br/>
        /// (1.) Dynamic and context-aware diagnostics, guided troubleshooting wizards, and data visualizations. <br/> (2.) Rich instructional
        /// video tutorials and illustrative diagrams and images. <br/> (3.) Thoughtfully assembled textual troubleshooting instructions.
        /// <br/> All these components are seamlessly converged into unified solutions tailored to address a specific support problem
        /// area.
        /// </summary>
        /// <param name="scope">The fully qualified Azure Resource manager identifier of the resource.</param>
        /// <param name="solutionResourceName">Solution resource Name.</param>
        /// <param name="jsonString">Json string supplied to the SolutionCreate operation</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResource>" />
        /// that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResource> SolutionCreateViaJsonStringWithResult(string scope, string solutionResourceName, global::System.String jsonString, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/"
                        + (scope)
                        + "/providers/Microsoft.Help/solutions/"
                        + global::System.Uri.EscapeDataString(solutionResourceName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Put, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(jsonString, global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.SolutionCreateWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>
        /// create a solution for the specific Azure resource or subscription using the inputs ‘solutionId and requiredInputs’ from
        /// discovery solutions. <br/> Azure solutions comprise a comprehensive library of self-help resources that have been thoughtfully
        /// curated by Azure engineers to aid customers in resolving typical troubleshooting issues. These solutions encompass: <br/>
        /// (1.) Dynamic and context-aware diagnostics, guided troubleshooting wizards, and data visualizations. <br/> (2.) Rich instructional
        /// video tutorials and illustrative diagrams and images. <br/> (3.) Thoughtfully assembled textual troubleshooting instructions.
        /// <br/> All these components are seamlessly converged into unified solutions tailored to address a specific support problem
        /// area.
        /// </summary>
        /// <param name="scope">The fully qualified Azure Resource manager identifier of the resource.</param>
        /// <param name="solutionResourceName">Solution resource Name.</param>
        /// <param name="body">The required request body for this solution resource creation.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResource>" />
        /// that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResource> SolutionCreateWithResult(string scope, string solutionResourceName, Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResource body, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/"
                        + (scope)
                        + "/providers/Microsoft.Help/solutions/"
                        + global::System.Uri.EscapeDataString(solutionResourceName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Put, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.SolutionCreateWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref= "SolutionCreateWithResult" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResource>" />
        /// that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResource> SolutionCreateWithResult_Call(global::System.Net.Http.HttpRequestMessage request, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    // this operation supports x-ms-long-running-operation
                    var _originalUri = request.RequestUri.AbsoluteUri;
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Progress, "intentional placeholder", 0); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    // declared final-state-via: azure-async-operation
                    var asyncOperation = _response.GetFirstHeader(@"Azure-AsyncOperation");
                    var location = _response.GetFirstHeader(@"Location");
                    var operationLocation = _response.GetFirstHeader(@"Operation-Location");
                    while (request.Method == System.Net.Http.HttpMethod.Put && _response.StatusCode == global::System.Net.HttpStatusCode.OK || _response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                    {
                        // delay before making the next polling request
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.DelayBeforePolling, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }

                        // while we wait, let's grab the headers and get ready to poll.
                        if (!System.String.IsNullOrEmpty(_response.GetFirstHeader(@"Azure-AsyncOperation"))) {
                            asyncOperation = _response.GetFirstHeader(@"Azure-AsyncOperation");
                        }
                        if (!global::System.String.IsNullOrEmpty(_response.GetFirstHeader(@"Location"))) {
                            location = _response.GetFirstHeader(@"Location");
                        }
                        if (!global::System.String.IsNullOrEmpty(_response.GetFirstHeader(@"Operation-Location"))) {
                            operationLocation = _response.GetFirstHeader(@"Operation-Location");
                        }
                        var _uri = global::System.String.IsNullOrEmpty(asyncOperation) ? global::System.String.IsNullOrEmpty(location) ? global::System.String.IsNullOrEmpty(operationLocation) ? _originalUri : operationLocation : location : asyncOperation;
                        request = request.CloneAndDispose(new global::System.Uri(_uri), Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Get);

                        // and let's look at the current response body and see if we have some information we can give back to the listener
                        var content = await _response.Content.ReadAsStringAsync();

                        // drop the old response
                        _response?.Dispose();

                        // make the polling call
                        _response = await sender.SendAsync(request, eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }

                          // if we got back an OK, take a peek inside and see if it's done
                          if( _response.StatusCode == global::System.Net.HttpStatusCode.OK)
                          {
                              var error = false;
                              try {
                                  if( Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(await _response.Content.ReadAsStringAsync()) is Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonObject json)
                                  {
                                      var state = json.Property("properties")?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonString>("provisioningState") ?? json.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonString>("status");
                                      if( state is null )
                                      {
                                          // the body doesn't contain any information that has the state of the LRO
                                          // we're going to just get out, and let the consumer have the result
                                          break;
                                      }

                                      switch( state?.ToString()?.ToLower() )
                                      {
                                        case "failed":
                                            error = true;
                                            break;
                                        case "succeeded":
                                        case "canceled":
                                          // we're done polling.
                                          break;

                                        default:
                                          // need to keep polling!
                                          _response.StatusCode = global::System.Net.HttpStatusCode.Created;
                                          continue;
                                      }
                                  }
                              } catch {
                                  // if we run into a problem peeking into the result,
                                  // we really don't want to do anything special.
                              }
                              if (error) {
                                  throw new Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.UndeclaredResponseException(_response);
                              }
                          }

                        // check for terminal status code
                        if (_response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                        {
                            continue;
                        }
                        // we are done polling, do a request on final target?
                        // create a new request with the final uri
                        request = request.CloneAndDispose(new global::System.Uri(_originalUri), Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Get);

                        // drop the old response
                        _response?.Dispose();

                        // make the final call
                        _response = await sender.SendAsync(request,  eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                        break;
                    }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Help.Models.SolutionResource.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(body.Result)) );
                            return await _result;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(body.Result)) );
                            // Error Response : default
                            var code = (await _result)?.Code;
                            var message = (await _result)?.Message;
                            if ((null == code || null == message))
                            {
                                // Unrecognized Response. Create an error record based on what we have.
                                var ex = new Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>(_response, await _result);
                                throw ex;
                            }
                            else
                            {
                                throw new global::System.Exception($"[{code}] : {message}");
                            }
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>Actual wire call for <see cref= "SolutionCreate" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task SolutionCreate_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResource>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    // this operation supports x-ms-long-running-operation
                    var _originalUri = request.RequestUri.AbsoluteUri;
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Progress, "intentional placeholder", 0); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    // declared final-state-via: azure-async-operation
                    var asyncOperation = _response.GetFirstHeader(@"Azure-AsyncOperation");
                    var location = _response.GetFirstHeader(@"Location");
                    var operationLocation = _response.GetFirstHeader(@"Operation-Location");
                    while (request.Method == System.Net.Http.HttpMethod.Put && _response.StatusCode == global::System.Net.HttpStatusCode.OK || _response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                    {
                        // delay before making the next polling request
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.DelayBeforePolling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }

                        // while we wait, let's grab the headers and get ready to poll.
                        if (!System.String.IsNullOrEmpty(_response.GetFirstHeader(@"Azure-AsyncOperation"))) {
                            asyncOperation = _response.GetFirstHeader(@"Azure-AsyncOperation");
                        }
                        if (!global::System.String.IsNullOrEmpty(_response.GetFirstHeader(@"Location"))) {
                            location = _response.GetFirstHeader(@"Location");
                        }
                        if (!global::System.String.IsNullOrEmpty(_response.GetFirstHeader(@"Operation-Location"))) {
                            operationLocation = _response.GetFirstHeader(@"Operation-Location");
                        }
                        var _uri = global::System.String.IsNullOrEmpty(asyncOperation) ? global::System.String.IsNullOrEmpty(location) ? global::System.String.IsNullOrEmpty(operationLocation) ? _originalUri : operationLocation : location : asyncOperation;
                        request = request.CloneAndDispose(new global::System.Uri(_uri), Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Get);

                        // and let's look at the current response body and see if we have some information we can give back to the listener
                        var content = await _response.Content.ReadAsStringAsync();

                        // drop the old response
                        _response?.Dispose();

                        // make the polling call
                        _response = await sender.SendAsync(request, eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }

                          // if we got back an OK, take a peek inside and see if it's done
                          if( _response.StatusCode == global::System.Net.HttpStatusCode.OK)
                          {
                              var error = false;
                              try {
                                  if( Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(await _response.Content.ReadAsStringAsync()) is Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonObject json)
                                  {
                                      var state = json.Property("properties")?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonString>("provisioningState") ?? json.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonString>("status");
                                      if( state is null )
                                      {
                                          // the body doesn't contain any information that has the state of the LRO
                                          // we're going to just get out, and let the consumer have the result
                                          break;
                                      }

                                      switch( state?.ToString()?.ToLower() )
                                      {
                                        case "failed":
                                            error = true;
                                            break;
                                        case "succeeded":
                                        case "canceled":
                                          // we're done polling.
                                          break;

                                        default:
                                          // need to keep polling!
                                          _response.StatusCode = global::System.Net.HttpStatusCode.Created;
                                          continue;
                                      }
                                  }
                              } catch {
                                  // if we run into a problem peeking into the result,
                                  // we really don't want to do anything special.
                              }
                              if (error) {
                                  throw new Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.UndeclaredResponseException(_response);
                              }
                          }

                        // check for terminal status code
                        if (_response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                        {
                            continue;
                        }
                        // we are done polling, do a request on final target?
                        // create a new request with the final uri
                        request = request.CloneAndDispose(new global::System.Uri(_originalUri), Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Get);

                        // drop the old response
                        _response?.Dispose();

                        // make the final call
                        _response = await sender.SendAsync(request,  eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                        break;
                    }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Help.Models.SolutionResource.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="SolutionCreate" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="scope">The fully qualified Azure Resource manager identifier of the resource.</param>
        /// <param name="solutionResourceName">Solution resource Name.</param>
        /// <param name="body">The required request body for this solution resource creation.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task SolutionCreate_Validate(string scope, string solutionResourceName, Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResource body, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(scope),scope);
                await eventListener.AssertNotNull(nameof(solutionResourceName),solutionResourceName);
                await eventListener.AssertMinimumLength(nameof(solutionResourceName),solutionResourceName,1);
                await eventListener.AssertMaximumLength(nameof(solutionResourceName),solutionResourceName,100);
                await eventListener.AssertRegEx(nameof(solutionResourceName), solutionResourceName, @"^[A-Za-z0-9-+@()_]+$");
                await eventListener.AssertNotNull(nameof(body), body);
                await eventListener.AssertObjectIsValid(nameof(body), body);
            }
        }

        /// <summary>
        /// Get the solution using the applicable solutionResourceName while creating the solution.
        /// </summary>
        /// <param name="scope">The fully qualified Azure Resource manager identifier of the resource.</param>
        /// <param name="solutionResourceName">Solution resource Name.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task SolutionGet(string scope, string solutionResourceName, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResource>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/"
                        + (scope)
                        + "/providers/Microsoft.Help/solutions/"
                        + global::System.Uri.EscapeDataString(solutionResourceName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.SolutionGet_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>
        /// Get the solution using the applicable solutionResourceName while creating the solution.
        /// </summary>
        /// <param name="viaIdentity"></param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task SolutionGetViaIdentity(global::System.String viaIdentity, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResource>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/(?<scope>[^/]+)/providers/Microsoft.Help/solutions/(?<solutionResourceName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/{scope}/providers/Microsoft.Help/solutions/{solutionResourceName}'");
                }

                // replace URI parameters with values from identity
                var scope = _match.Groups["scope"].Value;
                var solutionResourceName = _match.Groups["solutionResourceName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/"
                        + scope
                        + "/providers/Microsoft.Help/solutions/"
                        + solutionResourceName
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.SolutionGet_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>
        /// Get the solution using the applicable solutionResourceName while creating the solution.
        /// </summary>
        /// <param name="viaIdentity"></param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResource>" />
        /// that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResource> SolutionGetViaIdentityWithResult(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/(?<scope>[^/]+)/providers/Microsoft.Help/solutions/(?<solutionResourceName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/{scope}/providers/Microsoft.Help/solutions/{solutionResourceName}'");
                }

                // replace URI parameters with values from identity
                var scope = _match.Groups["scope"].Value;
                var solutionResourceName = _match.Groups["solutionResourceName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/"
                        + scope
                        + "/providers/Microsoft.Help/solutions/"
                        + solutionResourceName
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.SolutionGetWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>
        /// Get the solution using the applicable solutionResourceName while creating the solution.
        /// </summary>
        /// <param name="scope">The fully qualified Azure Resource manager identifier of the resource.</param>
        /// <param name="solutionResourceName">Solution resource Name.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResource>" />
        /// that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResource> SolutionGetWithResult(string scope, string solutionResourceName, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/"
                        + (scope)
                        + "/providers/Microsoft.Help/solutions/"
                        + global::System.Uri.EscapeDataString(solutionResourceName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.SolutionGetWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref= "SolutionGetWithResult" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResource>" />
        /// that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResource> SolutionGetWithResult_Call(global::System.Net.Http.HttpRequestMessage request, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Help.Models.SolutionResource.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(body.Result)) );
                            return await _result;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(body.Result)) );
                            // Error Response : default
                            var code = (await _result)?.Code;
                            var message = (await _result)?.Message;
                            if ((null == code || null == message))
                            {
                                // Unrecognized Response. Create an error record based on what we have.
                                var ex = new Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>(_response, await _result);
                                throw ex;
                            }
                            else
                            {
                                throw new global::System.Exception($"[{code}] : {message}");
                            }
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>Actual wire call for <see cref= "SolutionGet" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task SolutionGet_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResource>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Help.Models.SolutionResource.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="SolutionGet" /> method. Call this like the actual call, but you will get validation events
        /// back.
        /// </summary>
        /// <param name="scope">The fully qualified Azure Resource manager identifier of the resource.</param>
        /// <param name="solutionResourceName">Solution resource Name.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task SolutionGet_Validate(string scope, string solutionResourceName, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(scope),scope);
                await eventListener.AssertNotNull(nameof(solutionResourceName),solutionResourceName);
                await eventListener.AssertMinimumLength(nameof(solutionResourceName),solutionResourceName,1);
                await eventListener.AssertMaximumLength(nameof(solutionResourceName),solutionResourceName,100);
                await eventListener.AssertRegEx(nameof(solutionResourceName), solutionResourceName, @"^[A-Za-z0-9-+@()_]+$");
            }
        }

        /// <summary>
        /// Gets Self Help Solutions for a given solutionId. Self Help Solutions consist of rich instructional video tutorials, links
        /// and guides to public documentation related to a specific problem that enables users to troubleshoot Azure issues.
        /// </summary>
        /// <param name="solutionId">SolutionId is a unique id to identify a solution. You can retrieve the solution id using the
        /// Discovery api - https://learn.microsoft.com/en-us/rest/api/help/discovery-solution/list?view=rest-help-2023-09-01-preview&tabs=HTTP</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task SolutionSelfHelpGet(string solutionId, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourceSelfHelp>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/providers/Microsoft.Help/selfHelp/"
                        + global::System.Uri.EscapeDataString(solutionId)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.SolutionSelfHelpGet_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>
        /// Gets Self Help Solutions for a given solutionId. Self Help Solutions consist of rich instructional video tutorials, links
        /// and guides to public documentation related to a specific problem that enables users to troubleshoot Azure issues.
        /// </summary>
        /// <param name="viaIdentity"></param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task SolutionSelfHelpGetViaIdentity(global::System.String viaIdentity, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourceSelfHelp>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/providers/Microsoft.Help/selfHelp/(?<solutionId>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/providers/Microsoft.Help/selfHelp/{solutionId}'");
                }

                // replace URI parameters with values from identity
                var solutionId = _match.Groups["solutionId"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/providers/Microsoft.Help/selfHelp/"
                        + solutionId
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.SolutionSelfHelpGet_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>
        /// Gets Self Help Solutions for a given solutionId. Self Help Solutions consist of rich instructional video tutorials, links
        /// and guides to public documentation related to a specific problem that enables users to troubleshoot Azure issues.
        /// </summary>
        /// <param name="viaIdentity"></param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourceSelfHelp>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourceSelfHelp> SolutionSelfHelpGetViaIdentityWithResult(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/providers/Microsoft.Help/selfHelp/(?<solutionId>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/providers/Microsoft.Help/selfHelp/{solutionId}'");
                }

                // replace URI parameters with values from identity
                var solutionId = _match.Groups["solutionId"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/providers/Microsoft.Help/selfHelp/"
                        + solutionId
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.SolutionSelfHelpGetWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>
        /// Gets Self Help Solutions for a given solutionId. Self Help Solutions consist of rich instructional video tutorials, links
        /// and guides to public documentation related to a specific problem that enables users to troubleshoot Azure issues.
        /// </summary>
        /// <param name="solutionId">SolutionId is a unique id to identify a solution. You can retrieve the solution id using the
        /// Discovery api - https://learn.microsoft.com/en-us/rest/api/help/discovery-solution/list?view=rest-help-2023-09-01-preview&tabs=HTTP</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourceSelfHelp>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourceSelfHelp> SolutionSelfHelpGetWithResult(string solutionId, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/providers/Microsoft.Help/selfHelp/"
                        + global::System.Uri.EscapeDataString(solutionId)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.SolutionSelfHelpGetWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref= "SolutionSelfHelpGetWithResult" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourceSelfHelp>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourceSelfHelp> SolutionSelfHelpGetWithResult_Call(global::System.Net.Http.HttpRequestMessage request, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Help.Models.SolutionResourceSelfHelp.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(body.Result)) );
                            return await _result;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(body.Result)) );
                            // Error Response : default
                            var code = (await _result)?.Code;
                            var message = (await _result)?.Message;
                            if ((null == code || null == message))
                            {
                                // Unrecognized Response. Create an error record based on what we have.
                                var ex = new Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>(_response, await _result);
                                throw ex;
                            }
                            else
                            {
                                throw new global::System.Exception($"[{code}] : {message}");
                            }
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>Actual wire call for <see cref= "SolutionSelfHelpGet" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task SolutionSelfHelpGet_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourceSelfHelp>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Help.Models.SolutionResourceSelfHelp.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="SolutionSelfHelpGet" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="solutionId">SolutionId is a unique id to identify a solution. You can retrieve the solution id using the
        /// Discovery api - https://learn.microsoft.com/en-us/rest/api/help/discovery-solution/list?view=rest-help-2023-09-01-preview&tabs=HTTP</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task SolutionSelfHelpGet_Validate(string solutionId, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(solutionId),solutionId);
                await eventListener.AssertMinimumLength(nameof(solutionId),solutionId,1);
                await eventListener.AssertMaximumLength(nameof(solutionId),solutionId,100);
            }
        }

        /// <summary>
        /// update the requiredInputs or additional information needed to execute the solution
        /// </summary>
        /// <param name="scope">The fully qualified Azure Resource manager identifier of the resource.</param>
        /// <param name="solutionResourceName">Solution resource Name.</param>
        /// <param name="body">The required request body for updating a solution resource.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task SolutionUpdate(string scope, string solutionResourceName, Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBody body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResource>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/"
                        + (scope)
                        + "/providers/Microsoft.Help/solutions/"
                        + global::System.Uri.EscapeDataString(solutionResourceName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Patch, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.SolutionUpdate_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>
        /// update the requiredInputs or additional information needed to execute the solution
        /// </summary>
        /// <param name="viaIdentity"></param>
        /// <param name="body">The required request body for updating a solution resource.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task SolutionUpdateViaIdentity(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBody body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResource>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/(?<scope>[^/]+)/providers/Microsoft.Help/solutions/(?<solutionResourceName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/{scope}/providers/Microsoft.Help/solutions/{solutionResourceName}'");
                }

                // replace URI parameters with values from identity
                var scope = _match.Groups["scope"].Value;
                var solutionResourceName = _match.Groups["solutionResourceName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/"
                        + scope
                        + "/providers/Microsoft.Help/solutions/"
                        + solutionResourceName
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Patch, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.SolutionUpdate_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>
        /// update the requiredInputs or additional information needed to execute the solution
        /// </summary>
        /// <param name="viaIdentity"></param>
        /// <param name="body">The required request body for updating a solution resource.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResource>" />
        /// that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResource> SolutionUpdateViaIdentityWithResult(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBody body, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/(?<scope>[^/]+)/providers/Microsoft.Help/solutions/(?<solutionResourceName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/{scope}/providers/Microsoft.Help/solutions/{solutionResourceName}'");
                }

                // replace URI parameters with values from identity
                var scope = _match.Groups["scope"].Value;
                var solutionResourceName = _match.Groups["solutionResourceName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/"
                        + scope
                        + "/providers/Microsoft.Help/solutions/"
                        + solutionResourceName
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Patch, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.SolutionUpdateWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>
        /// update the requiredInputs or additional information needed to execute the solution
        /// </summary>
        /// <param name="scope">The fully qualified Azure Resource manager identifier of the resource.</param>
        /// <param name="solutionResourceName">Solution resource Name.</param>
        /// <param name="jsonString">Json string supplied to the SolutionUpdate operation</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task SolutionUpdateViaJsonString(string scope, string solutionResourceName, global::System.String jsonString, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResource>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/"
                        + (scope)
                        + "/providers/Microsoft.Help/solutions/"
                        + global::System.Uri.EscapeDataString(solutionResourceName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Patch, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(jsonString, global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.SolutionUpdate_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>
        /// update the requiredInputs or additional information needed to execute the solution
        /// </summary>
        /// <param name="scope">The fully qualified Azure Resource manager identifier of the resource.</param>
        /// <param name="solutionResourceName">Solution resource Name.</param>
        /// <param name="jsonString">Json string supplied to the SolutionUpdate operation</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResource>" />
        /// that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResource> SolutionUpdateViaJsonStringWithResult(string scope, string solutionResourceName, global::System.String jsonString, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/"
                        + (scope)
                        + "/providers/Microsoft.Help/solutions/"
                        + global::System.Uri.EscapeDataString(solutionResourceName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Patch, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(jsonString, global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.SolutionUpdateWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>
        /// update the requiredInputs or additional information needed to execute the solution
        /// </summary>
        /// <param name="scope">The fully qualified Azure Resource manager identifier of the resource.</param>
        /// <param name="solutionResourceName">Solution resource Name.</param>
        /// <param name="body">The required request body for updating a solution resource.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResource>" />
        /// that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResource> SolutionUpdateWithResult(string scope, string solutionResourceName, Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBody body, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/"
                        + (scope)
                        + "/providers/Microsoft.Help/solutions/"
                        + global::System.Uri.EscapeDataString(solutionResourceName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Patch, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.SolutionUpdateWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref= "SolutionUpdateWithResult" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResource>" />
        /// that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResource> SolutionUpdateWithResult_Call(global::System.Net.Http.HttpRequestMessage request, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    // this operation supports x-ms-long-running-operation
                    var _originalUri = request.RequestUri.AbsoluteUri;
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Progress, "intentional placeholder", 0); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    // declared final-state-via: azure-async-operation
                    var asyncOperation = _response.GetFirstHeader(@"Azure-AsyncOperation");
                    var location = _response.GetFirstHeader(@"Location");
                    var operationLocation = _response.GetFirstHeader(@"Operation-Location");
                    while (request.Method == System.Net.Http.HttpMethod.Put && _response.StatusCode == global::System.Net.HttpStatusCode.OK || _response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                    {
                        // delay before making the next polling request
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.DelayBeforePolling, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }

                        // while we wait, let's grab the headers and get ready to poll.
                        if (!System.String.IsNullOrEmpty(_response.GetFirstHeader(@"Azure-AsyncOperation"))) {
                            asyncOperation = _response.GetFirstHeader(@"Azure-AsyncOperation");
                        }
                        if (!global::System.String.IsNullOrEmpty(_response.GetFirstHeader(@"Location"))) {
                            location = _response.GetFirstHeader(@"Location");
                        }
                        if (!global::System.String.IsNullOrEmpty(_response.GetFirstHeader(@"Operation-Location"))) {
                            operationLocation = _response.GetFirstHeader(@"Operation-Location");
                        }
                        var _uri = global::System.String.IsNullOrEmpty(asyncOperation) ? global::System.String.IsNullOrEmpty(location) ? global::System.String.IsNullOrEmpty(operationLocation) ? _originalUri : operationLocation : location : asyncOperation;
                        request = request.CloneAndDispose(new global::System.Uri(_uri), Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Get);

                        // and let's look at the current response body and see if we have some information we can give back to the listener
                        var content = await _response.Content.ReadAsStringAsync();

                        // drop the old response
                        _response?.Dispose();

                        // make the polling call
                        _response = await sender.SendAsync(request, eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }

                          // if we got back an OK, take a peek inside and see if it's done
                          if( _response.StatusCode == global::System.Net.HttpStatusCode.OK)
                          {
                              var error = false;
                              try {
                                  if( Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(await _response.Content.ReadAsStringAsync()) is Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonObject json)
                                  {
                                      var state = json.Property("properties")?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonString>("provisioningState") ?? json.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonString>("status");
                                      if( state is null )
                                      {
                                          // the body doesn't contain any information that has the state of the LRO
                                          // we're going to just get out, and let the consumer have the result
                                          break;
                                      }

                                      switch( state?.ToString()?.ToLower() )
                                      {
                                        case "failed":
                                            error = true;
                                            break;
                                        case "succeeded":
                                        case "canceled":
                                          // we're done polling.
                                          break;

                                        default:
                                          // need to keep polling!
                                          _response.StatusCode = global::System.Net.HttpStatusCode.Created;
                                          continue;
                                      }
                                  }
                              } catch {
                                  // if we run into a problem peeking into the result,
                                  // we really don't want to do anything special.
                              }
                              if (error) {
                                  throw new Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.UndeclaredResponseException(_response);
                              }
                          }

                        // check for terminal status code
                        if (_response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                        {
                            continue;
                        }
                        // we are done polling, do a request on final target?
                        // create a new request with the final uri
                        request = request.CloneAndDispose(new global::System.Uri(_originalUri), Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Get);

                        // drop the old response
                        _response?.Dispose();

                        // make the final call
                        _response = await sender.SendAsync(request,  eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                        break;
                    }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Help.Models.SolutionResource.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(body.Result)) );
                            return await _result;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(body.Result)) );
                            // Error Response : default
                            var code = (await _result)?.Code;
                            var message = (await _result)?.Message;
                            if ((null == code || null == message))
                            {
                                // Unrecognized Response. Create an error record based on what we have.
                                var ex = new Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>(_response, await _result);
                                throw ex;
                            }
                            else
                            {
                                throw new global::System.Exception($"[{code}] : {message}");
                            }
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>Actual wire call for <see cref= "SolutionUpdate" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task SolutionUpdate_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResource>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    // this operation supports x-ms-long-running-operation
                    var _originalUri = request.RequestUri.AbsoluteUri;
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Progress, "intentional placeholder", 0); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    // declared final-state-via: azure-async-operation
                    var asyncOperation = _response.GetFirstHeader(@"Azure-AsyncOperation");
                    var location = _response.GetFirstHeader(@"Location");
                    var operationLocation = _response.GetFirstHeader(@"Operation-Location");
                    while (request.Method == System.Net.Http.HttpMethod.Put && _response.StatusCode == global::System.Net.HttpStatusCode.OK || _response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                    {
                        // delay before making the next polling request
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.DelayBeforePolling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }

                        // while we wait, let's grab the headers and get ready to poll.
                        if (!System.String.IsNullOrEmpty(_response.GetFirstHeader(@"Azure-AsyncOperation"))) {
                            asyncOperation = _response.GetFirstHeader(@"Azure-AsyncOperation");
                        }
                        if (!global::System.String.IsNullOrEmpty(_response.GetFirstHeader(@"Location"))) {
                            location = _response.GetFirstHeader(@"Location");
                        }
                        if (!global::System.String.IsNullOrEmpty(_response.GetFirstHeader(@"Operation-Location"))) {
                            operationLocation = _response.GetFirstHeader(@"Operation-Location");
                        }
                        var _uri = global::System.String.IsNullOrEmpty(asyncOperation) ? global::System.String.IsNullOrEmpty(location) ? global::System.String.IsNullOrEmpty(operationLocation) ? _originalUri : operationLocation : location : asyncOperation;
                        request = request.CloneAndDispose(new global::System.Uri(_uri), Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Get);

                        // and let's look at the current response body and see if we have some information we can give back to the listener
                        var content = await _response.Content.ReadAsStringAsync();

                        // drop the old response
                        _response?.Dispose();

                        // make the polling call
                        _response = await sender.SendAsync(request, eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }

                          // if we got back an OK, take a peek inside and see if it's done
                          if( _response.StatusCode == global::System.Net.HttpStatusCode.OK)
                          {
                              var error = false;
                              try {
                                  if( Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(await _response.Content.ReadAsStringAsync()) is Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonObject json)
                                  {
                                      var state = json.Property("properties")?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonString>("provisioningState") ?? json.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonString>("status");
                                      if( state is null )
                                      {
                                          // the body doesn't contain any information that has the state of the LRO
                                          // we're going to just get out, and let the consumer have the result
                                          break;
                                      }

                                      switch( state?.ToString()?.ToLower() )
                                      {
                                        case "failed":
                                            error = true;
                                            break;
                                        case "succeeded":
                                        case "canceled":
                                          // we're done polling.
                                          break;

                                        default:
                                          // need to keep polling!
                                          _response.StatusCode = global::System.Net.HttpStatusCode.Created;
                                          continue;
                                      }
                                  }
                              } catch {
                                  // if we run into a problem peeking into the result,
                                  // we really don't want to do anything special.
                              }
                              if (error) {
                                  throw new Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.UndeclaredResponseException(_response);
                              }
                          }

                        // check for terminal status code
                        if (_response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                        {
                            continue;
                        }
                        // we are done polling, do a request on final target?
                        // create a new request with the final uri
                        request = request.CloneAndDispose(new global::System.Uri(_originalUri), Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Get);

                        // drop the old response
                        _response?.Dispose();

                        // make the final call
                        _response = await sender.SendAsync(request,  eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                        break;
                    }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Help.Models.SolutionResource.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="SolutionUpdate" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="scope">The fully qualified Azure Resource manager identifier of the resource.</param>
        /// <param name="solutionResourceName">Solution resource Name.</param>
        /// <param name="body">The required request body for updating a solution resource.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task SolutionUpdate_Validate(string scope, string solutionResourceName, Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBody body, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(scope),scope);
                await eventListener.AssertNotNull(nameof(solutionResourceName),solutionResourceName);
                await eventListener.AssertMinimumLength(nameof(solutionResourceName),solutionResourceName,1);
                await eventListener.AssertMaximumLength(nameof(solutionResourceName),solutionResourceName,100);
                await eventListener.AssertRegEx(nameof(solutionResourceName), solutionResourceName, @"^[A-Za-z0-9-+@()_]+$");
                await eventListener.AssertNotNull(nameof(body), body);
                await eventListener.AssertObjectIsValid(nameof(body), body);
            }
        }

        /// <summary>
        /// Warm up the solution resource by preloading asynchronous diagnostics results into cache
        /// </summary>
        /// <param name="scope">The fully qualified Azure Resource manager identifier of the resource.</param>
        /// <param name="solutionResourceName">Solution resource Name.</param>
        /// <param name="body">The required request body for warming up a solution resource.</param>
        /// <param name="onNoContent">a delegate that is called when the remote service returns 204 (NoContent).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task SolutionWarmUp(string scope, string solutionResourceName, Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionWarmUpRequestBody body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onNoContent, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/"
                        + (scope)
                        + "/providers/Microsoft.Help/solutions/"
                        + global::System.Uri.EscapeDataString(solutionResourceName)
                        + "/warmup"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.SolutionWarmUp_Call (request, onNoContent,onDefault,eventListener,sender);
            }
        }

        /// <summary>
        /// Warm up the solution resource by preloading asynchronous diagnostics results into cache
        /// </summary>
        /// <param name="viaIdentity"></param>
        /// <param name="body">The required request body for warming up a solution resource.</param>
        /// <param name="onNoContent">a delegate that is called when the remote service returns 204 (NoContent).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task SolutionWarmUpViaIdentity(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionWarmUpRequestBody body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onNoContent, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/(?<scope>[^/]+)/providers/Microsoft.Help/solutions/(?<solutionResourceName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/{scope}/providers/Microsoft.Help/solutions/{solutionResourceName}'");
                }

                // replace URI parameters with values from identity
                var scope = _match.Groups["scope"].Value;
                var solutionResourceName = _match.Groups["solutionResourceName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/"
                        + scope
                        + "/providers/Microsoft.Help/solutions/"
                        + solutionResourceName
                        + "/warmup"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.SolutionWarmUp_Call (request, onNoContent,onDefault,eventListener,sender);
            }
        }

        /// <summary>
        /// Warm up the solution resource by preloading asynchronous diagnostics results into cache
        /// </summary>
        /// <param name="scope">The fully qualified Azure Resource manager identifier of the resource.</param>
        /// <param name="solutionResourceName">Solution resource Name.</param>
        /// <param name="jsonString">Json string supplied to the SolutionWarmUp operation</param>
        /// <param name="onNoContent">a delegate that is called when the remote service returns 204 (NoContent).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task SolutionWarmUpViaJsonString(string scope, string solutionResourceName, global::System.String jsonString, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onNoContent, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/"
                        + (scope)
                        + "/providers/Microsoft.Help/solutions/"
                        + global::System.Uri.EscapeDataString(solutionResourceName)
                        + "/warmup"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(jsonString, global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.SolutionWarmUp_Call (request, onNoContent,onDefault,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref= "SolutionWarmUp" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onNoContent">a delegate that is called when the remote service returns 204 (NoContent).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task SolutionWarmUp_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onNoContent, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.NoContent:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onNoContent(_response);
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="SolutionWarmUp" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="scope">The fully qualified Azure Resource manager identifier of the resource.</param>
        /// <param name="solutionResourceName">Solution resource Name.</param>
        /// <param name="body">The required request body for warming up a solution resource.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task SolutionWarmUp_Validate(string scope, string solutionResourceName, Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionWarmUpRequestBody body, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(scope),scope);
                await eventListener.AssertNotNull(nameof(solutionResourceName),solutionResourceName);
                await eventListener.AssertMinimumLength(nameof(solutionResourceName),solutionResourceName,1);
                await eventListener.AssertMaximumLength(nameof(solutionResourceName),solutionResourceName,100);
                await eventListener.AssertRegEx(nameof(solutionResourceName), solutionResourceName, @"^[A-Za-z0-9-+@()_]+$");
                await eventListener.AssertNotNull(nameof(body), body);
                await eventListener.AssertObjectIsValid(nameof(body), body);
            }
        }

        /// <summary>
        /// Uses ‘stepId’ and ‘responses’ as the trigger to continue the troubleshooting steps for the respective troubleshooter resource
        /// name. <br/>Continue API is used to provide inputs that are required for the specific troubleshooter to progress into the
        /// next step in the process. This API is used after the Troubleshooter has been created using the continue API.
        /// </summary>
        /// <param name="scope">The fully qualified Azure Resource manager identifier of the resource.</param>
        /// <param name="troubleshooterName">Troubleshooter resource Name.</param>
        /// <param name="body">The required request body for going to next step in Troubleshooter resource.</param>
        /// <param name="onNoContent">a delegate that is called when the remote service returns 204 (NoContent).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task TroubleshootersContinue(string scope, string troubleshooterName, Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IContinueRequestBody body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ITroubleshootersContinueNoContentResponseHeaders>, global::System.Threading.Tasks.Task> onNoContent, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/"
                        + (scope)
                        + "/providers/Microsoft.Help/troubleshooters/"
                        + global::System.Uri.EscapeDataString(troubleshooterName)
                        + "/continue"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.TroubleshootersContinue_Call (request, onNoContent,onDefault,eventListener,sender);
            }
        }

        /// <summary>
        /// Uses ‘stepId’ and ‘responses’ as the trigger to continue the troubleshooting steps for the respective troubleshooter resource
        /// name. <br/>Continue API is used to provide inputs that are required for the specific troubleshooter to progress into the
        /// next step in the process. This API is used after the Troubleshooter has been created using the continue API.
        /// </summary>
        /// <param name="viaIdentity"></param>
        /// <param name="body">The required request body for going to next step in Troubleshooter resource.</param>
        /// <param name="onNoContent">a delegate that is called when the remote service returns 204 (NoContent).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task TroubleshootersContinueViaIdentity(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IContinueRequestBody body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ITroubleshootersContinueNoContentResponseHeaders>, global::System.Threading.Tasks.Task> onNoContent, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/(?<scope>[^/]+)/providers/Microsoft.Help/troubleshooters/(?<troubleshooterName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/{scope}/providers/Microsoft.Help/troubleshooters/{troubleshooterName}'");
                }

                // replace URI parameters with values from identity
                var scope = _match.Groups["scope"].Value;
                var troubleshooterName = _match.Groups["troubleshooterName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/"
                        + scope
                        + "/providers/Microsoft.Help/troubleshooters/"
                        + troubleshooterName
                        + "/continue"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.TroubleshootersContinue_Call (request, onNoContent,onDefault,eventListener,sender);
            }
        }

        /// <summary>
        /// Uses ‘stepId’ and ‘responses’ as the trigger to continue the troubleshooting steps for the respective troubleshooter resource
        /// name. <br/>Continue API is used to provide inputs that are required for the specific troubleshooter to progress into the
        /// next step in the process. This API is used after the Troubleshooter has been created using the continue API.
        /// </summary>
        /// <param name="scope">The fully qualified Azure Resource manager identifier of the resource.</param>
        /// <param name="troubleshooterName">Troubleshooter resource Name.</param>
        /// <param name="jsonString">Json string supplied to the TroubleshootersContinue operation</param>
        /// <param name="onNoContent">a delegate that is called when the remote service returns 204 (NoContent).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task TroubleshootersContinueViaJsonString(string scope, string troubleshooterName, global::System.String jsonString, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ITroubleshootersContinueNoContentResponseHeaders>, global::System.Threading.Tasks.Task> onNoContent, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/"
                        + (scope)
                        + "/providers/Microsoft.Help/troubleshooters/"
                        + global::System.Uri.EscapeDataString(troubleshooterName)
                        + "/continue"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(jsonString, global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.TroubleshootersContinue_Call (request, onNoContent,onDefault,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref= "TroubleshootersContinue" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onNoContent">a delegate that is called when the remote service returns 204 (NoContent).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task TroubleshootersContinue_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ITroubleshootersContinueNoContentResponseHeaders>, global::System.Threading.Tasks.Task> onNoContent, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.NoContent:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onNoContent(_response,null /* deserializeFromResponse doesn't support '-header-' C:\Users\xidi\source\autorest.powershell\powershell\dist\llcsharp\schema\object.js*/);
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="TroubleshootersContinue" /> method. Call this like the actual call, but you will get
        /// validation events back.
        /// </summary>
        /// <param name="scope">The fully qualified Azure Resource manager identifier of the resource.</param>
        /// <param name="troubleshooterName">Troubleshooter resource Name.</param>
        /// <param name="body">The required request body for going to next step in Troubleshooter resource.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task TroubleshootersContinue_Validate(string scope, string troubleshooterName, Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IContinueRequestBody body, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(scope),scope);
                await eventListener.AssertNotNull(nameof(troubleshooterName),troubleshooterName);
                await eventListener.AssertMinimumLength(nameof(troubleshooterName),troubleshooterName,1);
                await eventListener.AssertMaximumLength(nameof(troubleshooterName),troubleshooterName,100);
                await eventListener.AssertRegEx(nameof(troubleshooterName), troubleshooterName, @"([A-Za-z0-9]+(-[A-Za-z0-9]+)+)");
                await eventListener.AssertNotNull(nameof(body), body);
                await eventListener.AssertObjectIsValid(nameof(body), body);
            }
        }

        /// <summary>
        /// update the specific troubleshooter action under a resource or subscription using the ‘solutionId’ and ‘properties.parameters’
        /// as the trigger. <br/> Azure Troubleshooters help with hard to classify issues, reducing the gap between customer observed
        /// problems and solutions by guiding the user effortlessly through the troubleshooting process. Each Troubleshooter flow
        /// represents a problem area within Azure and has a complex tree-like structure that addresses many root causes. These flows
        /// are prepared with the help of Subject Matter experts and customer support engineers by carefully considering previous
        /// support requests raised by customers. Troubleshooters terminate at a well curated solution based off of resource backend
        /// signals and customer manual selections.
        /// </summary>
        /// <param name="scope">The fully qualified Azure Resource manager identifier of the resource.</param>
        /// <param name="troubleshooterName">Troubleshooter resource Name.</param>
        /// <param name="body">The required request body for this Troubleshooter resource creation.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onCreated">a delegate that is called when the remote service returns 201 (Created).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task TroubleshootersCreate(string scope, string troubleshooterName, Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ITroubleshooterResource body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ITroubleshooterResource>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ITroubleshooterResource>, global::System.Threading.Tasks.Task> onCreated, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/"
                        + (scope)
                        + "/providers/Microsoft.Help/troubleshooters/"
                        + global::System.Uri.EscapeDataString(troubleshooterName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Put, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.TroubleshootersCreate_Call (request, onOk,onCreated,onDefault,eventListener,sender);
            }
        }

        /// <summary>
        /// update the specific troubleshooter action under a resource or subscription using the ‘solutionId’ and ‘properties.parameters’
        /// as the trigger. <br/> Azure Troubleshooters help with hard to classify issues, reducing the gap between customer observed
        /// problems and solutions by guiding the user effortlessly through the troubleshooting process. Each Troubleshooter flow
        /// represents a problem area within Azure and has a complex tree-like structure that addresses many root causes. These flows
        /// are prepared with the help of Subject Matter experts and customer support engineers by carefully considering previous
        /// support requests raised by customers. Troubleshooters terminate at a well curated solution based off of resource backend
        /// signals and customer manual selections.
        /// </summary>
        /// <param name="viaIdentity"></param>
        /// <param name="body">The required request body for this Troubleshooter resource creation.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onCreated">a delegate that is called when the remote service returns 201 (Created).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task TroubleshootersCreateViaIdentity(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ITroubleshooterResource body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ITroubleshooterResource>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ITroubleshooterResource>, global::System.Threading.Tasks.Task> onCreated, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/(?<scope>[^/]+)/providers/Microsoft.Help/troubleshooters/(?<troubleshooterName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/{scope}/providers/Microsoft.Help/troubleshooters/{troubleshooterName}'");
                }

                // replace URI parameters with values from identity
                var scope = _match.Groups["scope"].Value;
                var troubleshooterName = _match.Groups["troubleshooterName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/"
                        + scope
                        + "/providers/Microsoft.Help/troubleshooters/"
                        + troubleshooterName
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Put, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.TroubleshootersCreate_Call (request, onOk,onCreated,onDefault,eventListener,sender);
            }
        }

        /// <summary>
        /// update the specific troubleshooter action under a resource or subscription using the ‘solutionId’ and ‘properties.parameters’
        /// as the trigger. <br/> Azure Troubleshooters help with hard to classify issues, reducing the gap between customer observed
        /// problems and solutions by guiding the user effortlessly through the troubleshooting process. Each Troubleshooter flow
        /// represents a problem area within Azure and has a complex tree-like structure that addresses many root causes. These flows
        /// are prepared with the help of Subject Matter experts and customer support engineers by carefully considering previous
        /// support requests raised by customers. Troubleshooters terminate at a well curated solution based off of resource backend
        /// signals and customer manual selections.
        /// </summary>
        /// <param name="viaIdentity"></param>
        /// <param name="body">The required request body for this Troubleshooter resource creation.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ITroubleshooterResource>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ITroubleshooterResource> TroubleshootersCreateViaIdentityWithResult(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ITroubleshooterResource body, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/(?<scope>[^/]+)/providers/Microsoft.Help/troubleshooters/(?<troubleshooterName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/{scope}/providers/Microsoft.Help/troubleshooters/{troubleshooterName}'");
                }

                // replace URI parameters with values from identity
                var scope = _match.Groups["scope"].Value;
                var troubleshooterName = _match.Groups["troubleshooterName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/"
                        + scope
                        + "/providers/Microsoft.Help/troubleshooters/"
                        + troubleshooterName
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Put, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.TroubleshootersCreateWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>
        /// update the specific troubleshooter action under a resource or subscription using the ‘solutionId’ and ‘properties.parameters’
        /// as the trigger. <br/> Azure Troubleshooters help with hard to classify issues, reducing the gap between customer observed
        /// problems and solutions by guiding the user effortlessly through the troubleshooting process. Each Troubleshooter flow
        /// represents a problem area within Azure and has a complex tree-like structure that addresses many root causes. These flows
        /// are prepared with the help of Subject Matter experts and customer support engineers by carefully considering previous
        /// support requests raised by customers. Troubleshooters terminate at a well curated solution based off of resource backend
        /// signals and customer manual selections.
        /// </summary>
        /// <param name="scope">The fully qualified Azure Resource manager identifier of the resource.</param>
        /// <param name="troubleshooterName">Troubleshooter resource Name.</param>
        /// <param name="jsonString">Json string supplied to the TroubleshootersCreate operation</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onCreated">a delegate that is called when the remote service returns 201 (Created).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task TroubleshootersCreateViaJsonString(string scope, string troubleshooterName, global::System.String jsonString, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ITroubleshooterResource>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ITroubleshooterResource>, global::System.Threading.Tasks.Task> onCreated, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/"
                        + (scope)
                        + "/providers/Microsoft.Help/troubleshooters/"
                        + global::System.Uri.EscapeDataString(troubleshooterName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Put, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(jsonString, global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.TroubleshootersCreate_Call (request, onOk,onCreated,onDefault,eventListener,sender);
            }
        }

        /// <summary>
        /// update the specific troubleshooter action under a resource or subscription using the ‘solutionId’ and ‘properties.parameters’
        /// as the trigger. <br/> Azure Troubleshooters help with hard to classify issues, reducing the gap between customer observed
        /// problems and solutions by guiding the user effortlessly through the troubleshooting process. Each Troubleshooter flow
        /// represents a problem area within Azure and has a complex tree-like structure that addresses many root causes. These flows
        /// are prepared with the help of Subject Matter experts and customer support engineers by carefully considering previous
        /// support requests raised by customers. Troubleshooters terminate at a well curated solution based off of resource backend
        /// signals and customer manual selections.
        /// </summary>
        /// <param name="scope">The fully qualified Azure Resource manager identifier of the resource.</param>
        /// <param name="troubleshooterName">Troubleshooter resource Name.</param>
        /// <param name="jsonString">Json string supplied to the TroubleshootersCreate operation</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ITroubleshooterResource>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ITroubleshooterResource> TroubleshootersCreateViaJsonStringWithResult(string scope, string troubleshooterName, global::System.String jsonString, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/"
                        + (scope)
                        + "/providers/Microsoft.Help/troubleshooters/"
                        + global::System.Uri.EscapeDataString(troubleshooterName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Put, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(jsonString, global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.TroubleshootersCreateWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>
        /// update the specific troubleshooter action under a resource or subscription using the ‘solutionId’ and ‘properties.parameters’
        /// as the trigger. <br/> Azure Troubleshooters help with hard to classify issues, reducing the gap between customer observed
        /// problems and solutions by guiding the user effortlessly through the troubleshooting process. Each Troubleshooter flow
        /// represents a problem area within Azure and has a complex tree-like structure that addresses many root causes. These flows
        /// are prepared with the help of Subject Matter experts and customer support engineers by carefully considering previous
        /// support requests raised by customers. Troubleshooters terminate at a well curated solution based off of resource backend
        /// signals and customer manual selections.
        /// </summary>
        /// <param name="scope">The fully qualified Azure Resource manager identifier of the resource.</param>
        /// <param name="troubleshooterName">Troubleshooter resource Name.</param>
        /// <param name="body">The required request body for this Troubleshooter resource creation.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ITroubleshooterResource>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ITroubleshooterResource> TroubleshootersCreateWithResult(string scope, string troubleshooterName, Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ITroubleshooterResource body, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/"
                        + (scope)
                        + "/providers/Microsoft.Help/troubleshooters/"
                        + global::System.Uri.EscapeDataString(troubleshooterName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Put, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.TroubleshootersCreateWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref= "TroubleshootersCreateWithResult" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ITroubleshooterResource>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ITroubleshooterResource> TroubleshootersCreateWithResult_Call(global::System.Net.Http.HttpRequestMessage request, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Help.Models.TroubleshooterResource.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(body.Result)) );
                            return await _result;
                        }
                        case global::System.Net.HttpStatusCode.Created:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Help.Models.TroubleshooterResource.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(body.Result)) );
                            return await _result;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(body.Result)) );
                            // Error Response : default
                            var code = (await _result)?.Code;
                            var message = (await _result)?.Message;
                            if ((null == code || null == message))
                            {
                                // Unrecognized Response. Create an error record based on what we have.
                                var ex = new Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>(_response, await _result);
                                throw ex;
                            }
                            else
                            {
                                throw new global::System.Exception($"[{code}] : {message}");
                            }
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>Actual wire call for <see cref= "TroubleshootersCreate" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onCreated">a delegate that is called when the remote service returns 201 (Created).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task TroubleshootersCreate_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ITroubleshooterResource>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ITroubleshooterResource>, global::System.Threading.Tasks.Task> onCreated, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Help.Models.TroubleshooterResource.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        case global::System.Net.HttpStatusCode.Created:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onCreated(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Help.Models.TroubleshooterResource.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="TroubleshootersCreate" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="scope">The fully qualified Azure Resource manager identifier of the resource.</param>
        /// <param name="troubleshooterName">Troubleshooter resource Name.</param>
        /// <param name="body">The required request body for this Troubleshooter resource creation.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task TroubleshootersCreate_Validate(string scope, string troubleshooterName, Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ITroubleshooterResource body, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(scope),scope);
                await eventListener.AssertNotNull(nameof(troubleshooterName),troubleshooterName);
                await eventListener.AssertMinimumLength(nameof(troubleshooterName),troubleshooterName,1);
                await eventListener.AssertMaximumLength(nameof(troubleshooterName),troubleshooterName,100);
                await eventListener.AssertRegEx(nameof(troubleshooterName), troubleshooterName, @"([A-Za-z0-9]+(-[A-Za-z0-9]+)+)");
                await eventListener.AssertNotNull(nameof(body), body);
                await eventListener.AssertObjectIsValid(nameof(body), body);
            }
        }

        /// <summary>Ends the troubleshooter action</summary>
        /// <param name="scope">The fully qualified Azure Resource manager identifier of the resource.</param>
        /// <param name="troubleshooterName">Troubleshooter resource Name.</param>
        /// <param name="onNoContent">a delegate that is called when the remote service returns 204 (NoContent).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task TroubleshootersEnd(string scope, string troubleshooterName, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ITroubleshootersEndNoContentResponseHeaders>, global::System.Threading.Tasks.Task> onNoContent, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/"
                        + (scope)
                        + "/providers/Microsoft.Help/troubleshooters/"
                        + global::System.Uri.EscapeDataString(troubleshooterName)
                        + "/end"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.TroubleshootersEnd_Call (request, onNoContent,onDefault,eventListener,sender);
            }
        }

        /// <summary>Ends the troubleshooter action</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="onNoContent">a delegate that is called when the remote service returns 204 (NoContent).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task TroubleshootersEndViaIdentity(global::System.String viaIdentity, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ITroubleshootersEndNoContentResponseHeaders>, global::System.Threading.Tasks.Task> onNoContent, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/(?<scope>[^/]+)/providers/Microsoft.Help/troubleshooters/(?<troubleshooterName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/{scope}/providers/Microsoft.Help/troubleshooters/{troubleshooterName}'");
                }

                // replace URI parameters with values from identity
                var scope = _match.Groups["scope"].Value;
                var troubleshooterName = _match.Groups["troubleshooterName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/"
                        + scope
                        + "/providers/Microsoft.Help/troubleshooters/"
                        + troubleshooterName
                        + "/end"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.TroubleshootersEnd_Call (request, onNoContent,onDefault,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref= "TroubleshootersEnd" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onNoContent">a delegate that is called when the remote service returns 204 (NoContent).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task TroubleshootersEnd_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ITroubleshootersEndNoContentResponseHeaders>, global::System.Threading.Tasks.Task> onNoContent, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.NoContent:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onNoContent(_response,null /* deserializeFromResponse doesn't support '-header-' C:\Users\xidi\source\autorest.powershell\powershell\dist\llcsharp\schema\object.js*/);
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="TroubleshootersEnd" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="scope">The fully qualified Azure Resource manager identifier of the resource.</param>
        /// <param name="troubleshooterName">Troubleshooter resource Name.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task TroubleshootersEnd_Validate(string scope, string troubleshooterName, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(scope),scope);
                await eventListener.AssertNotNull(nameof(troubleshooterName),troubleshooterName);
                await eventListener.AssertMinimumLength(nameof(troubleshooterName),troubleshooterName,1);
                await eventListener.AssertMaximumLength(nameof(troubleshooterName),troubleshooterName,100);
                await eventListener.AssertRegEx(nameof(troubleshooterName), troubleshooterName, @"([A-Za-z0-9]+(-[A-Za-z0-9]+)+)");
            }
        }

        /// <summary>
        /// Gets troubleshooter instance result which includes the step status/result of the troubleshooter resource name that is
        /// being executed.<br/> Get API is used to retrieve the result of a Troubleshooter instance, which includes the status and
        /// result of each step in the Troubleshooter workflow. This API requires the Troubleshooter resource name that was created
        /// using the get API.
        /// </summary>
        /// <param name="scope">The fully qualified Azure Resource manager identifier of the resource.</param>
        /// <param name="troubleshooterName">Troubleshooter resource Name.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task TroubleshootersGet(string scope, string troubleshooterName, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ITroubleshooterResource>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/"
                        + (scope)
                        + "/providers/Microsoft.Help/troubleshooters/"
                        + global::System.Uri.EscapeDataString(troubleshooterName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.TroubleshootersGet_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>
        /// Gets troubleshooter instance result which includes the step status/result of the troubleshooter resource name that is
        /// being executed.<br/> Get API is used to retrieve the result of a Troubleshooter instance, which includes the status and
        /// result of each step in the Troubleshooter workflow. This API requires the Troubleshooter resource name that was created
        /// using the get API.
        /// </summary>
        /// <param name="viaIdentity"></param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task TroubleshootersGetViaIdentity(global::System.String viaIdentity, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ITroubleshooterResource>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/(?<scope>[^/]+)/providers/Microsoft.Help/troubleshooters/(?<troubleshooterName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/{scope}/providers/Microsoft.Help/troubleshooters/{troubleshooterName}'");
                }

                // replace URI parameters with values from identity
                var scope = _match.Groups["scope"].Value;
                var troubleshooterName = _match.Groups["troubleshooterName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/"
                        + scope
                        + "/providers/Microsoft.Help/troubleshooters/"
                        + troubleshooterName
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.TroubleshootersGet_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>
        /// Gets troubleshooter instance result which includes the step status/result of the troubleshooter resource name that is
        /// being executed.<br/> Get API is used to retrieve the result of a Troubleshooter instance, which includes the status and
        /// result of each step in the Troubleshooter workflow. This API requires the Troubleshooter resource name that was created
        /// using the get API.
        /// </summary>
        /// <param name="viaIdentity"></param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ITroubleshooterResource>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ITroubleshooterResource> TroubleshootersGetViaIdentityWithResult(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/(?<scope>[^/]+)/providers/Microsoft.Help/troubleshooters/(?<troubleshooterName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/{scope}/providers/Microsoft.Help/troubleshooters/{troubleshooterName}'");
                }

                // replace URI parameters with values from identity
                var scope = _match.Groups["scope"].Value;
                var troubleshooterName = _match.Groups["troubleshooterName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/"
                        + scope
                        + "/providers/Microsoft.Help/troubleshooters/"
                        + troubleshooterName
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.TroubleshootersGetWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>
        /// Gets troubleshooter instance result which includes the step status/result of the troubleshooter resource name that is
        /// being executed.<br/> Get API is used to retrieve the result of a Troubleshooter instance, which includes the status and
        /// result of each step in the Troubleshooter workflow. This API requires the Troubleshooter resource name that was created
        /// using the get API.
        /// </summary>
        /// <param name="scope">The fully qualified Azure Resource manager identifier of the resource.</param>
        /// <param name="troubleshooterName">Troubleshooter resource Name.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ITroubleshooterResource>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ITroubleshooterResource> TroubleshootersGetWithResult(string scope, string troubleshooterName, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/"
                        + (scope)
                        + "/providers/Microsoft.Help/troubleshooters/"
                        + global::System.Uri.EscapeDataString(troubleshooterName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.TroubleshootersGetWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref= "TroubleshootersGetWithResult" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ITroubleshooterResource>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ITroubleshooterResource> TroubleshootersGetWithResult_Call(global::System.Net.Http.HttpRequestMessage request, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Help.Models.TroubleshooterResource.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(body.Result)) );
                            return await _result;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(body.Result)) );
                            // Error Response : default
                            var code = (await _result)?.Code;
                            var message = (await _result)?.Message;
                            if ((null == code || null == message))
                            {
                                // Unrecognized Response. Create an error record based on what we have.
                                var ex = new Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>(_response, await _result);
                                throw ex;
                            }
                            else
                            {
                                throw new global::System.Exception($"[{code}] : {message}");
                            }
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>Actual wire call for <see cref= "TroubleshootersGet" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task TroubleshootersGet_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ITroubleshooterResource>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Help.Models.TroubleshooterResource.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="TroubleshootersGet" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="scope">The fully qualified Azure Resource manager identifier of the resource.</param>
        /// <param name="troubleshooterName">Troubleshooter resource Name.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task TroubleshootersGet_Validate(string scope, string troubleshooterName, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(scope),scope);
                await eventListener.AssertNotNull(nameof(troubleshooterName),troubleshooterName);
                await eventListener.AssertMinimumLength(nameof(troubleshooterName),troubleshooterName,1);
                await eventListener.AssertMaximumLength(nameof(troubleshooterName),troubleshooterName,100);
                await eventListener.AssertRegEx(nameof(troubleshooterName), troubleshooterName, @"([A-Za-z0-9]+(-[A-Za-z0-9]+)+)");
            }
        }

        /// <summary>
        /// Restarts the troubleshooter API using applicable troubleshooter resource name as the input.<br/> It returns new resource
        /// name which should be used in subsequent request. The old resource name is obsolete after this API is invoked.
        /// </summary>
        /// <param name="scope">The fully qualified Azure Resource manager identifier of the resource.</param>
        /// <param name="troubleshooterName">Troubleshooter resource Name.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task TroubleshootersRestart(string scope, string troubleshooterName, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IRestartTroubleshooterResponse>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/"
                        + (scope)
                        + "/providers/Microsoft.Help/troubleshooters/"
                        + global::System.Uri.EscapeDataString(troubleshooterName)
                        + "/restart"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.TroubleshootersRestart_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>
        /// Restarts the troubleshooter API using applicable troubleshooter resource name as the input.<br/> It returns new resource
        /// name which should be used in subsequent request. The old resource name is obsolete after this API is invoked.
        /// </summary>
        /// <param name="viaIdentity"></param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task TroubleshootersRestartViaIdentity(global::System.String viaIdentity, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IRestartTroubleshooterResponse>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/(?<scope>[^/]+)/providers/Microsoft.Help/troubleshooters/(?<troubleshooterName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/{scope}/providers/Microsoft.Help/troubleshooters/{troubleshooterName}'");
                }

                // replace URI parameters with values from identity
                var scope = _match.Groups["scope"].Value;
                var troubleshooterName = _match.Groups["troubleshooterName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/"
                        + scope
                        + "/providers/Microsoft.Help/troubleshooters/"
                        + troubleshooterName
                        + "/restart"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.TroubleshootersRestart_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>
        /// Restarts the troubleshooter API using applicable troubleshooter resource name as the input.<br/> It returns new resource
        /// name which should be used in subsequent request. The old resource name is obsolete after this API is invoked.
        /// </summary>
        /// <param name="viaIdentity"></param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IRestartTroubleshooterResponse>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IRestartTroubleshooterResponse> TroubleshootersRestartViaIdentityWithResult(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/(?<scope>[^/]+)/providers/Microsoft.Help/troubleshooters/(?<troubleshooterName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/{scope}/providers/Microsoft.Help/troubleshooters/{troubleshooterName}'");
                }

                // replace URI parameters with values from identity
                var scope = _match.Groups["scope"].Value;
                var troubleshooterName = _match.Groups["troubleshooterName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/"
                        + scope
                        + "/providers/Microsoft.Help/troubleshooters/"
                        + troubleshooterName
                        + "/restart"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.TroubleshootersRestartWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>
        /// Restarts the troubleshooter API using applicable troubleshooter resource name as the input.<br/> It returns new resource
        /// name which should be used in subsequent request. The old resource name is obsolete after this API is invoked.
        /// </summary>
        /// <param name="scope">The fully qualified Azure Resource manager identifier of the resource.</param>
        /// <param name="troubleshooterName">Troubleshooter resource Name.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IRestartTroubleshooterResponse>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IRestartTroubleshooterResponse> TroubleshootersRestartWithResult(string scope, string troubleshooterName, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-03-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/"
                        + (scope)
                        + "/providers/Microsoft.Help/troubleshooters/"
                        + global::System.Uri.EscapeDataString(troubleshooterName)
                        + "/restart"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.TroubleshootersRestartWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref= "TroubleshootersRestartWithResult" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IRestartTroubleshooterResponse>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IRestartTroubleshooterResponse> TroubleshootersRestartWithResult_Call(global::System.Net.Http.HttpRequestMessage request, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Help.Models.RestartTroubleshooterResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(body.Result)) .ReadHeaders(_response.Headers));
                            return await _result;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(body.Result)) );
                            // Error Response : default
                            var code = (await _result)?.Code;
                            var message = (await _result)?.Message;
                            if ((null == code || null == message))
                            {
                                // Unrecognized Response. Create an error record based on what we have.
                                var ex = new Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>(_response, await _result);
                                throw ex;
                            }
                            else
                            {
                                throw new global::System.Exception($"[{code}] : {message}");
                            }
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>Actual wire call for <see cref= "TroubleshootersRestart" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task TroubleshootersRestart_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IRestartTroubleshooterResponse>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Help.Models.RestartTroubleshooterResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(body.Result)) .ReadHeaders(_response.Headers)));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="TroubleshootersRestart" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="scope">The fully qualified Azure Resource manager identifier of the resource.</param>
        /// <param name="troubleshooterName">Troubleshooter resource Name.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task TroubleshootersRestart_Validate(string scope, string troubleshooterName, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(scope),scope);
                await eventListener.AssertNotNull(nameof(troubleshooterName),troubleshooterName);
                await eventListener.AssertMinimumLength(nameof(troubleshooterName),troubleshooterName,1);
                await eventListener.AssertMaximumLength(nameof(troubleshooterName),troubleshooterName,100);
                await eventListener.AssertRegEx(nameof(troubleshooterName), troubleshooterName, @"([A-Za-z0-9]+(-[A-Za-z0-9]+)+)");
            }
        }
    }
}