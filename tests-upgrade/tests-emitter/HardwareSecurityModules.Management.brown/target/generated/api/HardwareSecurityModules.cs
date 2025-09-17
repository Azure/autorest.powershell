// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Hsm
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Extensions;

    /// <summary>
    /// Low-level API implementation for the HardwareSecurityModules service.
    /// The Azure management API provides a RESTful set of web services that interact with Hardware Security Modules.
    /// </summary>
    public partial class HardwareSecurityModules
    {

        /// <summary>Gets the backup operation status of the specified Cloud HSM Cluster</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="cloudHsmClusterName">A sequence of textual characters.</param>
        /// <param name="jobId">Identifier for the backup operation</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onAccepted">a delegate that is called when the remote service returns 202 (Accepted).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task CloudHsmClusterBackupStatusGet(string subscriptionId, string resourceGroupName, string cloudHsmClusterName, string jobId, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ICloudHsmClusterBackupStatusGetAcceptedResponseHeaders>, global::System.Threading.Tasks.Task> onAccepted, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/"
                        + global::System.Uri.EscapeDataString(cloudHsmClusterName)
                        + "/backupOperationStatus/"
                        + global::System.Uri.EscapeDataString(jobId)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.CloudHsmClusterBackupStatusGet_Call (request, onOk,onAccepted,onDefault,eventListener,sender);
            }
        }

        /// <summary>Gets the backup operation status of the specified Cloud HSM Cluster</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onAccepted">a delegate that is called when the remote service returns 202 (Accepted).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task CloudHsmClusterBackupStatusGetViaIdentity(global::System.String viaIdentity, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ICloudHsmClusterBackupStatusGetAcceptedResponseHeaders>, global::System.Threading.Tasks.Task> onAccepted, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/(?<cloudHsmClusterName>[^/]+)/backupOperationStatus/(?<jobId>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/{cloudHsmClusterName}/backupOperationStatus/{jobId}'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var cloudHsmClusterName = _match.Groups["cloudHsmClusterName"].Value;
                var jobId = _match.Groups["jobId"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/"
                        + cloudHsmClusterName
                        + "/backupOperationStatus/"
                        + jobId
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.CloudHsmClusterBackupStatusGet_Call (request, onOk,onAccepted,onDefault,eventListener,sender);
            }
        }

        /// <summary>Gets the backup operation status of the specified Cloud HSM Cluster</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupResult>" /> that
        /// will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupResult> CloudHsmClusterBackupStatusGetViaIdentityWithResult(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/(?<cloudHsmClusterName>[^/]+)/backupOperationStatus/(?<jobId>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/{cloudHsmClusterName}/backupOperationStatus/{jobId}'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var cloudHsmClusterName = _match.Groups["cloudHsmClusterName"].Value;
                var jobId = _match.Groups["jobId"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/"
                        + cloudHsmClusterName
                        + "/backupOperationStatus/"
                        + jobId
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.CloudHsmClusterBackupStatusGetWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>Gets the backup operation status of the specified Cloud HSM Cluster</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="cloudHsmClusterName">A sequence of textual characters.</param>
        /// <param name="jobId">Identifier for the backup operation</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupResult>" /> that
        /// will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupResult> CloudHsmClusterBackupStatusGetWithResult(string subscriptionId, string resourceGroupName, string cloudHsmClusterName, string jobId, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/"
                        + global::System.Uri.EscapeDataString(cloudHsmClusterName)
                        + "/backupOperationStatus/"
                        + global::System.Uri.EscapeDataString(jobId)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.CloudHsmClusterBackupStatusGetWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>
        /// Actual wire call for <see cref= "CloudHsmClusterBackupStatusGetWithResult" /> method.
        /// </summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupResult>" /> that
        /// will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupResult> CloudHsmClusterBackupStatusGetWithResult_Call(global::System.Net.Http.HttpRequestMessage request, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.BackupResult.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) .ReadHeaders(_response.Headers));
                            return await _result;
                        }
                        case global::System.Net.HttpStatusCode.Accepted:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            throw new Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.UndeclaredResponseException(_response);
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) );
                            // Error Response : default
                            var code = (await _result)?.Code;
                            var message = (await _result)?.Message;
                            if ((null == code || null == message))
                            {
                                // Unrecognized Response. Create an error record based on what we have.
                                var ex = new Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>(_response, await _result);
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
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>Actual wire call for <see cref= "CloudHsmClusterBackupStatusGet" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onAccepted">a delegate that is called when the remote service returns 202 (Accepted).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task CloudHsmClusterBackupStatusGet_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ICloudHsmClusterBackupStatusGetAcceptedResponseHeaders>, global::System.Threading.Tasks.Task> onAccepted, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.BackupResult.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) .ReadHeaders(_response.Headers)));
                            break;
                        }
                        case global::System.Net.HttpStatusCode.Accepted:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onAccepted(_response,null /* deserializeFromResponse doesn't support '-header-' C:\Users\xidi\source\autorest.powershell\powershell\dist\llcsharp\schema\object.js*/);
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="CloudHsmClusterBackupStatusGet" /> method. Call this like the actual call, but you will
        /// get validation events back.
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="cloudHsmClusterName">A sequence of textual characters.</param>
        /// <param name="jobId">Identifier for the backup operation</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task CloudHsmClusterBackupStatusGet_Validate(string subscriptionId, string resourceGroupName, string cloudHsmClusterName, string jobId, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(subscriptionId),subscriptionId);
                await eventListener.AssertMinimumLength(nameof(subscriptionId),subscriptionId,1);
                await eventListener.AssertNotNull(nameof(resourceGroupName),resourceGroupName);
                await eventListener.AssertMinimumLength(nameof(resourceGroupName),resourceGroupName,1);
                await eventListener.AssertMaximumLength(nameof(resourceGroupName),resourceGroupName,90);
                await eventListener.AssertRegEx(nameof(resourceGroupName), resourceGroupName, @"^[-\w\._\(\)]+$");
                await eventListener.AssertNotNull(nameof(cloudHsmClusterName),cloudHsmClusterName);
                await eventListener.AssertMinimumLength(nameof(cloudHsmClusterName),cloudHsmClusterName,3);
                await eventListener.AssertMaximumLength(nameof(cloudHsmClusterName),cloudHsmClusterName,23);
                await eventListener.AssertRegEx(nameof(cloudHsmClusterName), cloudHsmClusterName, @"^[a-zA-Z0-9-]{3,23}$");
                await eventListener.AssertNotNull(nameof(jobId),jobId);
            }
        }

        /// <summary>update the private endpoint connection for the Cloud Hsm Cluster.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="cloudHsmClusterName">The name of the Cloud HSM Cluster within the specified resource group. Cloud HSM Cluster
        /// names must be between 3 and 23 characters in length.</param>
        /// <param name="peConnectionName">Name of the private endpoint connection associated with the Cloud HSM Cluster.</param>
        /// <param name="body">Parameters of the PrivateEndpointConnection</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task CloudHsmClusterPrivateEndpointConnectionsCreate(string subscriptionId, string resourceGroupName, string cloudHsmClusterName, string peConnectionName, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IPrivateEndpointConnection body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IPrivateEndpointConnection>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/"
                        + global::System.Uri.EscapeDataString(cloudHsmClusterName)
                        + "/privateEndpointConnections/"
                        + global::System.Uri.EscapeDataString(peConnectionName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Put, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.CloudHsmClusterPrivateEndpointConnectionsCreate_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>update the private endpoint connection for the Cloud Hsm Cluster.</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="body">Parameters of the PrivateEndpointConnection</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task CloudHsmClusterPrivateEndpointConnectionsCreateViaIdentity(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IPrivateEndpointConnection body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IPrivateEndpointConnection>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/(?<cloudHsmClusterName>[^/]+)/privateEndpointConnections/(?<peConnectionName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/{cloudHsmClusterName}/privateEndpointConnections/{peConnectionName}'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var cloudHsmClusterName = _match.Groups["cloudHsmClusterName"].Value;
                var peConnectionName = _match.Groups["peConnectionName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/"
                        + cloudHsmClusterName
                        + "/privateEndpointConnections/"
                        + peConnectionName
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Put, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.CloudHsmClusterPrivateEndpointConnectionsCreate_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>update the private endpoint connection for the Cloud Hsm Cluster.</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="body">Parameters of the PrivateEndpointConnection</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IPrivateEndpointConnection>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IPrivateEndpointConnection> CloudHsmClusterPrivateEndpointConnectionsCreateViaIdentityWithResult(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IPrivateEndpointConnection body, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/(?<cloudHsmClusterName>[^/]+)/privateEndpointConnections/(?<peConnectionName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/{cloudHsmClusterName}/privateEndpointConnections/{peConnectionName}'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var cloudHsmClusterName = _match.Groups["cloudHsmClusterName"].Value;
                var peConnectionName = _match.Groups["peConnectionName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/"
                        + cloudHsmClusterName
                        + "/privateEndpointConnections/"
                        + peConnectionName
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Put, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.CloudHsmClusterPrivateEndpointConnectionsCreateWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>update the private endpoint connection for the Cloud Hsm Cluster.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="cloudHsmClusterName">The name of the Cloud HSM Cluster within the specified resource group. Cloud HSM Cluster
        /// names must be between 3 and 23 characters in length.</param>
        /// <param name="peConnectionName">Name of the private endpoint connection associated with the Cloud HSM Cluster.</param>
        /// <param name="jsonString">Json string supplied to the CloudHsmClusterPrivateEndpointConnectionsCreate operation</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task CloudHsmClusterPrivateEndpointConnectionsCreateViaJsonString(string subscriptionId, string resourceGroupName, string cloudHsmClusterName, string peConnectionName, global::System.String jsonString, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IPrivateEndpointConnection>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/"
                        + global::System.Uri.EscapeDataString(cloudHsmClusterName)
                        + "/privateEndpointConnections/"
                        + global::System.Uri.EscapeDataString(peConnectionName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Put, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(jsonString, global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.CloudHsmClusterPrivateEndpointConnectionsCreate_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>update the private endpoint connection for the Cloud Hsm Cluster.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="cloudHsmClusterName">The name of the Cloud HSM Cluster within the specified resource group. Cloud HSM Cluster
        /// names must be between 3 and 23 characters in length.</param>
        /// <param name="peConnectionName">Name of the private endpoint connection associated with the Cloud HSM Cluster.</param>
        /// <param name="jsonString">Json string supplied to the CloudHsmClusterPrivateEndpointConnectionsCreate operation</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IPrivateEndpointConnection>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IPrivateEndpointConnection> CloudHsmClusterPrivateEndpointConnectionsCreateViaJsonStringWithResult(string subscriptionId, string resourceGroupName, string cloudHsmClusterName, string peConnectionName, global::System.String jsonString, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/"
                        + global::System.Uri.EscapeDataString(cloudHsmClusterName)
                        + "/privateEndpointConnections/"
                        + global::System.Uri.EscapeDataString(peConnectionName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Put, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(jsonString, global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.CloudHsmClusterPrivateEndpointConnectionsCreateWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>update the private endpoint connection for the Cloud Hsm Cluster.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="cloudHsmClusterName">The name of the Cloud HSM Cluster within the specified resource group. Cloud HSM Cluster
        /// names must be between 3 and 23 characters in length.</param>
        /// <param name="peConnectionName">Name of the private endpoint connection associated with the Cloud HSM Cluster.</param>
        /// <param name="body">Parameters of the PrivateEndpointConnection</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IPrivateEndpointConnection>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IPrivateEndpointConnection> CloudHsmClusterPrivateEndpointConnectionsCreateWithResult(string subscriptionId, string resourceGroupName, string cloudHsmClusterName, string peConnectionName, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IPrivateEndpointConnection body, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/"
                        + global::System.Uri.EscapeDataString(cloudHsmClusterName)
                        + "/privateEndpointConnections/"
                        + global::System.Uri.EscapeDataString(peConnectionName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Put, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.CloudHsmClusterPrivateEndpointConnectionsCreateWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>
        /// Actual wire call for <see cref= "CloudHsmClusterPrivateEndpointConnectionsCreateWithResult" /> method.
        /// </summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IPrivateEndpointConnection>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IPrivateEndpointConnection> CloudHsmClusterPrivateEndpointConnectionsCreateWithResult_Call(global::System.Net.Http.HttpRequestMessage request, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.PrivateEndpointConnection.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) );
                            return await _result;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) );
                            // Error Response : default
                            var code = (await _result)?.Code;
                            var message = (await _result)?.Message;
                            if ((null == code || null == message))
                            {
                                // Unrecognized Response. Create an error record based on what we have.
                                var ex = new Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>(_response, await _result);
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
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Actual wire call for <see cref= "CloudHsmClusterPrivateEndpointConnectionsCreate" /> method.
        /// </summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task CloudHsmClusterPrivateEndpointConnectionsCreate_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IPrivateEndpointConnection>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.PrivateEndpointConnection.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="CloudHsmClusterPrivateEndpointConnectionsCreate" /> method. Call this like the actual
        /// call, but you will get validation events back.
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="cloudHsmClusterName">The name of the Cloud HSM Cluster within the specified resource group. Cloud HSM Cluster
        /// names must be between 3 and 23 characters in length.</param>
        /// <param name="peConnectionName">Name of the private endpoint connection associated with the Cloud HSM Cluster.</param>
        /// <param name="body">Parameters of the PrivateEndpointConnection</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task CloudHsmClusterPrivateEndpointConnectionsCreate_Validate(string subscriptionId, string resourceGroupName, string cloudHsmClusterName, string peConnectionName, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IPrivateEndpointConnection body, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(subscriptionId),subscriptionId);
                await eventListener.AssertMinimumLength(nameof(subscriptionId),subscriptionId,1);
                await eventListener.AssertNotNull(nameof(resourceGroupName),resourceGroupName);
                await eventListener.AssertMinimumLength(nameof(resourceGroupName),resourceGroupName,1);
                await eventListener.AssertMaximumLength(nameof(resourceGroupName),resourceGroupName,90);
                await eventListener.AssertRegEx(nameof(resourceGroupName), resourceGroupName, @"^[-\w\._\(\)]+$");
                await eventListener.AssertNotNull(nameof(cloudHsmClusterName),cloudHsmClusterName);
                await eventListener.AssertMinimumLength(nameof(cloudHsmClusterName),cloudHsmClusterName,3);
                await eventListener.AssertMaximumLength(nameof(cloudHsmClusterName),cloudHsmClusterName,23);
                await eventListener.AssertRegEx(nameof(cloudHsmClusterName), cloudHsmClusterName, @"^[a-zA-Z0-9-]{3,23}$");
                await eventListener.AssertNotNull(nameof(peConnectionName),peConnectionName);
                await eventListener.AssertMinimumLength(nameof(peConnectionName),peConnectionName,3);
                await eventListener.AssertMaximumLength(nameof(peConnectionName),peConnectionName,24);
                await eventListener.AssertRegEx(nameof(peConnectionName), peConnectionName, @"^[a-zA-Z0-9-]{3,24}$");
                await eventListener.AssertNotNull(nameof(body), body);
                await eventListener.AssertObjectIsValid(nameof(body), body);
            }
        }

        /// <summary>Deletes the private endpoint connection for the Cloud Hsm Cluster.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="cloudHsmClusterName">The name of the Cloud HSM Cluster within the specified resource group. Cloud HSM Cluster
        /// names must be between 3 and 23 characters in length.</param>
        /// <param name="peConnectionName">Name of the private endpoint connection associated with the Cloud HSM Cluster.</param>
        /// <param name="onNoContent">a delegate that is called when the remote service returns 204 (NoContent).</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task CloudHsmClusterPrivateEndpointConnectionsDelete(string subscriptionId, string resourceGroupName, string cloudHsmClusterName, string peConnectionName, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onNoContent, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/"
                        + global::System.Uri.EscapeDataString(cloudHsmClusterName)
                        + "/privateEndpointConnections/"
                        + global::System.Uri.EscapeDataString(peConnectionName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Delete, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.CloudHsmClusterPrivateEndpointConnectionsDelete_Call (request, onNoContent,onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>Deletes the private endpoint connection for the Cloud Hsm Cluster.</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="onNoContent">a delegate that is called when the remote service returns 204 (NoContent).</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task CloudHsmClusterPrivateEndpointConnectionsDeleteViaIdentity(global::System.String viaIdentity, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onNoContent, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/(?<cloudHsmClusterName>[^/]+)/privateEndpointConnections/(?<peConnectionName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/{cloudHsmClusterName}/privateEndpointConnections/{peConnectionName}'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var cloudHsmClusterName = _match.Groups["cloudHsmClusterName"].Value;
                var peConnectionName = _match.Groups["peConnectionName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/"
                        + cloudHsmClusterName
                        + "/privateEndpointConnections/"
                        + peConnectionName
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Delete, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.CloudHsmClusterPrivateEndpointConnectionsDelete_Call (request, onNoContent,onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>
        /// Actual wire call for <see cref= "CloudHsmClusterPrivateEndpointConnectionsDelete" /> method.
        /// </summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onNoContent">a delegate that is called when the remote service returns 204 (NoContent).</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task CloudHsmClusterPrivateEndpointConnectionsDelete_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onNoContent, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    // this operation supports x-ms-long-running-operation
                    var _originalUri = request.RequestUri.AbsoluteUri;
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Progress, "intentional placeholder", 0); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    // declared final-state-via: location
                    var _finalUri = _response.GetFirstHeader(@"Location");
                    var asyncOperation = _response.GetFirstHeader(@"Azure-AsyncOperation");
                    var location = _response.GetFirstHeader(@"Location");
                    var operationLocation = _response.GetFirstHeader(@"Operation-Location");
                    while (request.Method == System.Net.Http.HttpMethod.Put && _response.StatusCode == global::System.Net.HttpStatusCode.OK || _response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                    {
                        // delay before making the next polling request
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.DelayBeforePolling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }

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
                        request = request.CloneAndDispose(new global::System.Uri(_uri), Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get);

                        // and let's look at the current response body and see if we have some information we can give back to the listener
                        var content = await _response.Content.ReadAsStringAsync();

                        // drop the old response
                        _response?.Dispose();

                        // make the polling call
                        _response = await sender.SendAsync(request, eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }

                          // if we got back an OK, take a peek inside and see if it's done
                          if( _response.StatusCode == global::System.Net.HttpStatusCode.OK)
                          {
                              var error = false;
                              try {
                                  if( Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(await _response.Content.ReadAsStringAsync()) is Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonObject json)
                                  {
                                      var state = json.Property("properties")?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonString>("provisioningState") ?? json.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonString>("status");
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
                                  throw new Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.UndeclaredResponseException(_response);
                              }
                          }

                        // check for terminal status code
                        if (_response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                        {
                            continue;
                        }
                        // we are done polling, do a request on final target?
                        // create a new request with the final uri
                        request = request.CloneAndDispose(new global::System.Uri(_finalUri), Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get);

                        // drop the old response
                        _response?.Dispose();

                        // make the final call
                        _response = await sender.SendAsync(request,  eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                        break;
                    }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response);
                            break;
                        }
                        case global::System.Net.HttpStatusCode.NoContent:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onNoContent(_response);
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="CloudHsmClusterPrivateEndpointConnectionsDelete" /> method. Call this like the actual
        /// call, but you will get validation events back.
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="cloudHsmClusterName">The name of the Cloud HSM Cluster within the specified resource group. Cloud HSM Cluster
        /// names must be between 3 and 23 characters in length.</param>
        /// <param name="peConnectionName">Name of the private endpoint connection associated with the Cloud HSM Cluster.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task CloudHsmClusterPrivateEndpointConnectionsDelete_Validate(string subscriptionId, string resourceGroupName, string cloudHsmClusterName, string peConnectionName, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(subscriptionId),subscriptionId);
                await eventListener.AssertMinimumLength(nameof(subscriptionId),subscriptionId,1);
                await eventListener.AssertNotNull(nameof(resourceGroupName),resourceGroupName);
                await eventListener.AssertMinimumLength(nameof(resourceGroupName),resourceGroupName,1);
                await eventListener.AssertMaximumLength(nameof(resourceGroupName),resourceGroupName,90);
                await eventListener.AssertRegEx(nameof(resourceGroupName), resourceGroupName, @"^[-\w\._\(\)]+$");
                await eventListener.AssertNotNull(nameof(cloudHsmClusterName),cloudHsmClusterName);
                await eventListener.AssertMinimumLength(nameof(cloudHsmClusterName),cloudHsmClusterName,3);
                await eventListener.AssertMaximumLength(nameof(cloudHsmClusterName),cloudHsmClusterName,23);
                await eventListener.AssertRegEx(nameof(cloudHsmClusterName), cloudHsmClusterName, @"^[a-zA-Z0-9-]{3,23}$");
                await eventListener.AssertNotNull(nameof(peConnectionName),peConnectionName);
                await eventListener.AssertMinimumLength(nameof(peConnectionName),peConnectionName,3);
                await eventListener.AssertMaximumLength(nameof(peConnectionName),peConnectionName,24);
                await eventListener.AssertRegEx(nameof(peConnectionName), peConnectionName, @"^[a-zA-Z0-9-]{3,24}$");
            }
        }

        /// <summary>Gets the private endpoint connection for the Cloud Hsm Cluster.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="cloudHsmClusterName">The name of the Cloud HSM Cluster within the specified resource group. Cloud HSM Cluster
        /// names must be between 3 and 23 characters in length.</param>
        /// <param name="peConnectionName">Name of the private endpoint connection associated with the Cloud HSM Cluster.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task CloudHsmClusterPrivateEndpointConnectionsGet(string subscriptionId, string resourceGroupName, string cloudHsmClusterName, string peConnectionName, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IPrivateEndpointConnection>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/"
                        + global::System.Uri.EscapeDataString(cloudHsmClusterName)
                        + "/privateEndpointConnections/"
                        + global::System.Uri.EscapeDataString(peConnectionName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.CloudHsmClusterPrivateEndpointConnectionsGet_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>Gets the private endpoint connection for the Cloud Hsm Cluster.</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task CloudHsmClusterPrivateEndpointConnectionsGetViaIdentity(global::System.String viaIdentity, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IPrivateEndpointConnection>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/(?<cloudHsmClusterName>[^/]+)/privateEndpointConnections/(?<peConnectionName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/{cloudHsmClusterName}/privateEndpointConnections/{peConnectionName}'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var cloudHsmClusterName = _match.Groups["cloudHsmClusterName"].Value;
                var peConnectionName = _match.Groups["peConnectionName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/"
                        + cloudHsmClusterName
                        + "/privateEndpointConnections/"
                        + peConnectionName
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.CloudHsmClusterPrivateEndpointConnectionsGet_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>Gets the private endpoint connection for the Cloud Hsm Cluster.</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IPrivateEndpointConnection>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IPrivateEndpointConnection> CloudHsmClusterPrivateEndpointConnectionsGetViaIdentityWithResult(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/(?<cloudHsmClusterName>[^/]+)/privateEndpointConnections/(?<peConnectionName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/{cloudHsmClusterName}/privateEndpointConnections/{peConnectionName}'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var cloudHsmClusterName = _match.Groups["cloudHsmClusterName"].Value;
                var peConnectionName = _match.Groups["peConnectionName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/"
                        + cloudHsmClusterName
                        + "/privateEndpointConnections/"
                        + peConnectionName
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.CloudHsmClusterPrivateEndpointConnectionsGetWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>Gets the private endpoint connection for the Cloud Hsm Cluster.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="cloudHsmClusterName">The name of the Cloud HSM Cluster within the specified resource group. Cloud HSM Cluster
        /// names must be between 3 and 23 characters in length.</param>
        /// <param name="peConnectionName">Name of the private endpoint connection associated with the Cloud HSM Cluster.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IPrivateEndpointConnection>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IPrivateEndpointConnection> CloudHsmClusterPrivateEndpointConnectionsGetWithResult(string subscriptionId, string resourceGroupName, string cloudHsmClusterName, string peConnectionName, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/"
                        + global::System.Uri.EscapeDataString(cloudHsmClusterName)
                        + "/privateEndpointConnections/"
                        + global::System.Uri.EscapeDataString(peConnectionName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.CloudHsmClusterPrivateEndpointConnectionsGetWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>
        /// Actual wire call for <see cref= "CloudHsmClusterPrivateEndpointConnectionsGetWithResult" /> method.
        /// </summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IPrivateEndpointConnection>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IPrivateEndpointConnection> CloudHsmClusterPrivateEndpointConnectionsGetWithResult_Call(global::System.Net.Http.HttpRequestMessage request, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.PrivateEndpointConnection.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) );
                            return await _result;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) );
                            // Error Response : default
                            var code = (await _result)?.Code;
                            var message = (await _result)?.Message;
                            if ((null == code || null == message))
                            {
                                // Unrecognized Response. Create an error record based on what we have.
                                var ex = new Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>(_response, await _result);
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
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Actual wire call for <see cref= "CloudHsmClusterPrivateEndpointConnectionsGet" /> method.
        /// </summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task CloudHsmClusterPrivateEndpointConnectionsGet_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IPrivateEndpointConnection>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.PrivateEndpointConnection.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="CloudHsmClusterPrivateEndpointConnectionsGet" /> method. Call this like the actual call,
        /// but you will get validation events back.
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="cloudHsmClusterName">The name of the Cloud HSM Cluster within the specified resource group. Cloud HSM Cluster
        /// names must be between 3 and 23 characters in length.</param>
        /// <param name="peConnectionName">Name of the private endpoint connection associated with the Cloud HSM Cluster.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task CloudHsmClusterPrivateEndpointConnectionsGet_Validate(string subscriptionId, string resourceGroupName, string cloudHsmClusterName, string peConnectionName, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(subscriptionId),subscriptionId);
                await eventListener.AssertMinimumLength(nameof(subscriptionId),subscriptionId,1);
                await eventListener.AssertNotNull(nameof(resourceGroupName),resourceGroupName);
                await eventListener.AssertMinimumLength(nameof(resourceGroupName),resourceGroupName,1);
                await eventListener.AssertMaximumLength(nameof(resourceGroupName),resourceGroupName,90);
                await eventListener.AssertRegEx(nameof(resourceGroupName), resourceGroupName, @"^[-\w\._\(\)]+$");
                await eventListener.AssertNotNull(nameof(cloudHsmClusterName),cloudHsmClusterName);
                await eventListener.AssertMinimumLength(nameof(cloudHsmClusterName),cloudHsmClusterName,3);
                await eventListener.AssertMaximumLength(nameof(cloudHsmClusterName),cloudHsmClusterName,23);
                await eventListener.AssertRegEx(nameof(cloudHsmClusterName), cloudHsmClusterName, @"^[a-zA-Z0-9-]{3,23}$");
                await eventListener.AssertNotNull(nameof(peConnectionName),peConnectionName);
                await eventListener.AssertMinimumLength(nameof(peConnectionName),peConnectionName,3);
                await eventListener.AssertMaximumLength(nameof(peConnectionName),peConnectionName,24);
                await eventListener.AssertRegEx(nameof(peConnectionName), peConnectionName, @"^[a-zA-Z0-9-]{3,24}$");
            }
        }

        /// <summary>Gets the private link resources supported for the Cloud Hsm Cluster.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="cloudHsmClusterName">The name of the Cloud HSM Cluster within the specified resource group. Cloud HSM Cluster
        /// names must be between 3 and 23 characters in length.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task CloudHsmClusterPrivateLinkResourcesListByCloudHsmCluster(string subscriptionId, string resourceGroupName, string cloudHsmClusterName, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IPrivateLinkResourceListResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/"
                        + global::System.Uri.EscapeDataString(cloudHsmClusterName)
                        + "/privateLinkResources"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.CloudHsmClusterPrivateLinkResourcesListByCloudHsmCluster_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>Gets the private link resources supported for the Cloud Hsm Cluster.</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task CloudHsmClusterPrivateLinkResourcesListByCloudHsmClusterViaIdentity(global::System.String viaIdentity, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IPrivateLinkResourceListResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/(?<cloudHsmClusterName>[^/]+)/privateLinkResources$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/{cloudHsmClusterName}/privateLinkResources'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var cloudHsmClusterName = _match.Groups["cloudHsmClusterName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/"
                        + cloudHsmClusterName
                        + "/privateLinkResources"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.CloudHsmClusterPrivateLinkResourcesListByCloudHsmCluster_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>Gets the private link resources supported for the Cloud Hsm Cluster.</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IPrivateLinkResourceListResult>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IPrivateLinkResourceListResult> CloudHsmClusterPrivateLinkResourcesListByCloudHsmClusterViaIdentityWithResult(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/(?<cloudHsmClusterName>[^/]+)/privateLinkResources$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/{cloudHsmClusterName}/privateLinkResources'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var cloudHsmClusterName = _match.Groups["cloudHsmClusterName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/"
                        + cloudHsmClusterName
                        + "/privateLinkResources"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.CloudHsmClusterPrivateLinkResourcesListByCloudHsmClusterWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>Gets the private link resources supported for the Cloud Hsm Cluster.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="cloudHsmClusterName">The name of the Cloud HSM Cluster within the specified resource group. Cloud HSM Cluster
        /// names must be between 3 and 23 characters in length.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IPrivateLinkResourceListResult>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IPrivateLinkResourceListResult> CloudHsmClusterPrivateLinkResourcesListByCloudHsmClusterWithResult(string subscriptionId, string resourceGroupName, string cloudHsmClusterName, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/"
                        + global::System.Uri.EscapeDataString(cloudHsmClusterName)
                        + "/privateLinkResources"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.CloudHsmClusterPrivateLinkResourcesListByCloudHsmClusterWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>
        /// Actual wire call for <see cref= "CloudHsmClusterPrivateLinkResourcesListByCloudHsmClusterWithResult" /> method.
        /// </summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IPrivateLinkResourceListResult>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IPrivateLinkResourceListResult> CloudHsmClusterPrivateLinkResourcesListByCloudHsmClusterWithResult_Call(global::System.Net.Http.HttpRequestMessage request, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.PrivateLinkResourceListResult.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) );
                            return await _result;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) );
                            // Error Response : default
                            var code = (await _result)?.Code;
                            var message = (await _result)?.Message;
                            if ((null == code || null == message))
                            {
                                // Unrecognized Response. Create an error record based on what we have.
                                var ex = new Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>(_response, await _result);
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
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Actual wire call for <see cref= "CloudHsmClusterPrivateLinkResourcesListByCloudHsmCluster" /> method.
        /// </summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task CloudHsmClusterPrivateLinkResourcesListByCloudHsmCluster_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IPrivateLinkResourceListResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.PrivateLinkResourceListResult.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="CloudHsmClusterPrivateLinkResourcesListByCloudHsmCluster" /> method. Call this like the
        /// actual call, but you will get validation events back.
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="cloudHsmClusterName">The name of the Cloud HSM Cluster within the specified resource group. Cloud HSM Cluster
        /// names must be between 3 and 23 characters in length.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task CloudHsmClusterPrivateLinkResourcesListByCloudHsmCluster_Validate(string subscriptionId, string resourceGroupName, string cloudHsmClusterName, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(subscriptionId),subscriptionId);
                await eventListener.AssertMinimumLength(nameof(subscriptionId),subscriptionId,1);
                await eventListener.AssertNotNull(nameof(resourceGroupName),resourceGroupName);
                await eventListener.AssertMinimumLength(nameof(resourceGroupName),resourceGroupName,1);
                await eventListener.AssertMaximumLength(nameof(resourceGroupName),resourceGroupName,90);
                await eventListener.AssertRegEx(nameof(resourceGroupName), resourceGroupName, @"^[-\w\._\(\)]+$");
                await eventListener.AssertNotNull(nameof(cloudHsmClusterName),cloudHsmClusterName);
                await eventListener.AssertMinimumLength(nameof(cloudHsmClusterName),cloudHsmClusterName,3);
                await eventListener.AssertMaximumLength(nameof(cloudHsmClusterName),cloudHsmClusterName,23);
                await eventListener.AssertRegEx(nameof(cloudHsmClusterName), cloudHsmClusterName, @"^[a-zA-Z0-9-]{3,23}$");
            }
        }

        /// <summary>Gets the restore operation status of the specified Cloud HSM Cluster</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="cloudHsmClusterName">Name of the Cloud HSM Cluster</param>
        /// <param name="jobId">Identifier for the restore operation</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onAccepted">a delegate that is called when the remote service returns 202 (Accepted).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task CloudHsmClusterRestoreStatusGet(string subscriptionId, string resourceGroupName, string cloudHsmClusterName, string jobId, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IRestoreResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ICloudHsmClusterRestoreStatusGetAcceptedResponseHeaders>, global::System.Threading.Tasks.Task> onAccepted, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/"
                        + global::System.Uri.EscapeDataString(cloudHsmClusterName)
                        + "/restoreOperationStatus/"
                        + global::System.Uri.EscapeDataString(jobId)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.CloudHsmClusterRestoreStatusGet_Call (request, onOk,onAccepted,onDefault,eventListener,sender);
            }
        }

        /// <summary>Gets the restore operation status of the specified Cloud HSM Cluster</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onAccepted">a delegate that is called when the remote service returns 202 (Accepted).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task CloudHsmClusterRestoreStatusGetViaIdentity(global::System.String viaIdentity, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IRestoreResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ICloudHsmClusterRestoreStatusGetAcceptedResponseHeaders>, global::System.Threading.Tasks.Task> onAccepted, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/(?<cloudHsmClusterName>[^/]+)/restoreOperationStatus/(?<jobId>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/{cloudHsmClusterName}/restoreOperationStatus/{jobId}'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var cloudHsmClusterName = _match.Groups["cloudHsmClusterName"].Value;
                var jobId = _match.Groups["jobId"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/"
                        + cloudHsmClusterName
                        + "/restoreOperationStatus/"
                        + jobId
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.CloudHsmClusterRestoreStatusGet_Call (request, onOk,onAccepted,onDefault,eventListener,sender);
            }
        }

        /// <summary>Gets the restore operation status of the specified Cloud HSM Cluster</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IRestoreResult>" /> that
        /// will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IRestoreResult> CloudHsmClusterRestoreStatusGetViaIdentityWithResult(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/(?<cloudHsmClusterName>[^/]+)/restoreOperationStatus/(?<jobId>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/{cloudHsmClusterName}/restoreOperationStatus/{jobId}'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var cloudHsmClusterName = _match.Groups["cloudHsmClusterName"].Value;
                var jobId = _match.Groups["jobId"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/"
                        + cloudHsmClusterName
                        + "/restoreOperationStatus/"
                        + jobId
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.CloudHsmClusterRestoreStatusGetWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>Gets the restore operation status of the specified Cloud HSM Cluster</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="cloudHsmClusterName">Name of the Cloud HSM Cluster</param>
        /// <param name="jobId">Identifier for the restore operation</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IRestoreResult>" /> that
        /// will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IRestoreResult> CloudHsmClusterRestoreStatusGetWithResult(string subscriptionId, string resourceGroupName, string cloudHsmClusterName, string jobId, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/"
                        + global::System.Uri.EscapeDataString(cloudHsmClusterName)
                        + "/restoreOperationStatus/"
                        + global::System.Uri.EscapeDataString(jobId)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.CloudHsmClusterRestoreStatusGetWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>
        /// Actual wire call for <see cref= "CloudHsmClusterRestoreStatusGetWithResult" /> method.
        /// </summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IRestoreResult>" /> that
        /// will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IRestoreResult> CloudHsmClusterRestoreStatusGetWithResult_Call(global::System.Net.Http.HttpRequestMessage request, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.RestoreResult.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) .ReadHeaders(_response.Headers));
                            return await _result;
                        }
                        case global::System.Net.HttpStatusCode.Accepted:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            throw new Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.UndeclaredResponseException(_response);
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) );
                            // Error Response : default
                            var code = (await _result)?.Code;
                            var message = (await _result)?.Message;
                            if ((null == code || null == message))
                            {
                                // Unrecognized Response. Create an error record based on what we have.
                                var ex = new Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>(_response, await _result);
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
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>Actual wire call for <see cref= "CloudHsmClusterRestoreStatusGet" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onAccepted">a delegate that is called when the remote service returns 202 (Accepted).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task CloudHsmClusterRestoreStatusGet_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IRestoreResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ICloudHsmClusterRestoreStatusGetAcceptedResponseHeaders>, global::System.Threading.Tasks.Task> onAccepted, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.RestoreResult.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) .ReadHeaders(_response.Headers)));
                            break;
                        }
                        case global::System.Net.HttpStatusCode.Accepted:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onAccepted(_response,null /* deserializeFromResponse doesn't support '-header-' C:\Users\xidi\source\autorest.powershell\powershell\dist\llcsharp\schema\object.js*/);
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="CloudHsmClusterRestoreStatusGet" /> method. Call this like the actual call, but you will
        /// get validation events back.
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="cloudHsmClusterName">Name of the Cloud HSM Cluster</param>
        /// <param name="jobId">Identifier for the restore operation</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task CloudHsmClusterRestoreStatusGet_Validate(string subscriptionId, string resourceGroupName, string cloudHsmClusterName, string jobId, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(subscriptionId),subscriptionId);
                await eventListener.AssertMinimumLength(nameof(subscriptionId),subscriptionId,1);
                await eventListener.AssertNotNull(nameof(resourceGroupName),resourceGroupName);
                await eventListener.AssertMinimumLength(nameof(resourceGroupName),resourceGroupName,1);
                await eventListener.AssertMaximumLength(nameof(resourceGroupName),resourceGroupName,90);
                await eventListener.AssertRegEx(nameof(resourceGroupName), resourceGroupName, @"^[-\w\._\(\)]+$");
                await eventListener.AssertNotNull(nameof(cloudHsmClusterName),cloudHsmClusterName);
                await eventListener.AssertMinimumLength(nameof(cloudHsmClusterName),cloudHsmClusterName,3);
                await eventListener.AssertMaximumLength(nameof(cloudHsmClusterName),cloudHsmClusterName,23);
                await eventListener.AssertRegEx(nameof(cloudHsmClusterName), cloudHsmClusterName, @"^[a-zA-Z0-9-]{3,23}$");
                await eventListener.AssertNotNull(nameof(jobId),jobId);
            }
        }

        /// <summary>backup a backup of the Cloud HSM Cluster in the specified subscription</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="cloudHsmClusterName">The name of the Cloud HSM Cluster within the specified resource group. Cloud HSM Cluster
        /// names must be between 3 and 23 characters in length.</param>
        /// <param name="body">Azure storage Resource Uri</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task CloudHsmClustersBackup(string subscriptionId, string resourceGroupName, string cloudHsmClusterName, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupRequestProperties body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/"
                        + global::System.Uri.EscapeDataString(cloudHsmClusterName)
                        + "/backup"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.CloudHsmClustersBackup_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>backup a backup of the Cloud HSM Cluster in the specified subscription</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="body">Azure storage Resource Uri</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task CloudHsmClustersBackupViaIdentity(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupRequestProperties body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/(?<cloudHsmClusterName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/{cloudHsmClusterName}'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var cloudHsmClusterName = _match.Groups["cloudHsmClusterName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/"
                        + cloudHsmClusterName
                        + "/backup"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.CloudHsmClustersBackup_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>backup a backup of the Cloud HSM Cluster in the specified subscription</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="body">Azure storage Resource Uri</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupResult>" /> that
        /// will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupResult> CloudHsmClustersBackupViaIdentityWithResult(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupRequestProperties body, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/(?<cloudHsmClusterName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/{cloudHsmClusterName}'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var cloudHsmClusterName = _match.Groups["cloudHsmClusterName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/"
                        + cloudHsmClusterName
                        + "/backup"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.CloudHsmClustersBackupWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>backup a backup of the Cloud HSM Cluster in the specified subscription</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="cloudHsmClusterName">The name of the Cloud HSM Cluster within the specified resource group. Cloud HSM Cluster
        /// names must be between 3 and 23 characters in length.</param>
        /// <param name="jsonString">Json string supplied to the CloudHsmClustersBackup operation</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task CloudHsmClustersBackupViaJsonString(string subscriptionId, string resourceGroupName, string cloudHsmClusterName, global::System.String jsonString, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/"
                        + global::System.Uri.EscapeDataString(cloudHsmClusterName)
                        + "/backup"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(jsonString, global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.CloudHsmClustersBackup_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>backup a backup of the Cloud HSM Cluster in the specified subscription</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="cloudHsmClusterName">The name of the Cloud HSM Cluster within the specified resource group. Cloud HSM Cluster
        /// names must be between 3 and 23 characters in length.</param>
        /// <param name="jsonString">Json string supplied to the CloudHsmClustersBackup operation</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupResult>" /> that
        /// will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupResult> CloudHsmClustersBackupViaJsonStringWithResult(string subscriptionId, string resourceGroupName, string cloudHsmClusterName, global::System.String jsonString, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/"
                        + global::System.Uri.EscapeDataString(cloudHsmClusterName)
                        + "/backup"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(jsonString, global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.CloudHsmClustersBackupWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>backup a backup of the Cloud HSM Cluster in the specified subscription</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="cloudHsmClusterName">The name of the Cloud HSM Cluster within the specified resource group. Cloud HSM Cluster
        /// names must be between 3 and 23 characters in length.</param>
        /// <param name="body">Azure storage Resource Uri</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupResult>" /> that
        /// will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupResult> CloudHsmClustersBackupWithResult(string subscriptionId, string resourceGroupName, string cloudHsmClusterName, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupRequestProperties body, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/"
                        + global::System.Uri.EscapeDataString(cloudHsmClusterName)
                        + "/backup"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.CloudHsmClustersBackupWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref= "CloudHsmClustersBackupWithResult" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupResult>" /> that
        /// will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupResult> CloudHsmClustersBackupWithResult_Call(global::System.Net.Http.HttpRequestMessage request, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    // this operation supports x-ms-long-running-operation
                    var _originalUri = request.RequestUri.AbsoluteUri;
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Progress, "intentional placeholder", 0); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    // declared final-state-via: azure-async-operation
                    var _finalUri = _response.GetFirstHeader(@"Azure-AsyncOperation");
                    var asyncOperation = _response.GetFirstHeader(@"Azure-AsyncOperation");
                    var location = _response.GetFirstHeader(@"Location");
                    var operationLocation = _response.GetFirstHeader(@"Operation-Location");
                    while (request.Method == System.Net.Http.HttpMethod.Put && _response.StatusCode == global::System.Net.HttpStatusCode.OK || _response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                    {
                        // delay before making the next polling request
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.DelayBeforePolling, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }

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
                        request = request.CloneAndDispose(new global::System.Uri(_uri), Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get);

                        // and let's look at the current response body and see if we have some information we can give back to the listener
                        var content = await _response.Content.ReadAsStringAsync();

                        // drop the old response
                        _response?.Dispose();

                        // make the polling call
                        _response = await sender.SendAsync(request, eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }

                          // if we got back an OK, take a peek inside and see if it's done
                          if( _response.StatusCode == global::System.Net.HttpStatusCode.OK)
                          {
                              var error = false;
                              try {
                                  if( Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(await _response.Content.ReadAsStringAsync()) is Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonObject json)
                                  {
                                      var state = json.Property("properties")?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonString>("provisioningState") ?? json.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonString>("status");
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
                                  throw new Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.UndeclaredResponseException(_response);
                              }
                          }

                        // check for terminal status code
                        if (_response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                        {
                            continue;
                        }
                        // we are done polling, do a request on final target?
                        // create a new request with the final uri
                        request = request.CloneAndDispose(new global::System.Uri(_finalUri), Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get);

                        // drop the old response
                        _response?.Dispose();

                        // make the final call
                        _response = await sender.SendAsync(request,  eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                        break;
                    }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.BackupResult.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) .ReadHeaders(_response.Headers));
                            return await _result;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) );
                            // Error Response : default
                            var code = (await _result)?.Code;
                            var message = (await _result)?.Message;
                            if ((null == code || null == message))
                            {
                                // Unrecognized Response. Create an error record based on what we have.
                                var ex = new Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>(_response, await _result);
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
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>Actual wire call for <see cref= "CloudHsmClustersBackup" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task CloudHsmClustersBackup_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    // this operation supports x-ms-long-running-operation
                    var _originalUri = request.RequestUri.AbsoluteUri;
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Progress, "intentional placeholder", 0); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    // declared final-state-via: azure-async-operation
                    var _finalUri = _response.GetFirstHeader(@"Azure-AsyncOperation");
                    var asyncOperation = _response.GetFirstHeader(@"Azure-AsyncOperation");
                    var location = _response.GetFirstHeader(@"Location");
                    var operationLocation = _response.GetFirstHeader(@"Operation-Location");
                    while (request.Method == System.Net.Http.HttpMethod.Put && _response.StatusCode == global::System.Net.HttpStatusCode.OK || _response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                    {
                        // delay before making the next polling request
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.DelayBeforePolling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }

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
                        request = request.CloneAndDispose(new global::System.Uri(_uri), Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get);

                        // and let's look at the current response body and see if we have some information we can give back to the listener
                        var content = await _response.Content.ReadAsStringAsync();

                        // drop the old response
                        _response?.Dispose();

                        // make the polling call
                        _response = await sender.SendAsync(request, eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }

                          // if we got back an OK, take a peek inside and see if it's done
                          if( _response.StatusCode == global::System.Net.HttpStatusCode.OK)
                          {
                              var error = false;
                              try {
                                  if( Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(await _response.Content.ReadAsStringAsync()) is Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonObject json)
                                  {
                                      var state = json.Property("properties")?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonString>("provisioningState") ?? json.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonString>("status");
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
                                  throw new Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.UndeclaredResponseException(_response);
                              }
                          }

                        // check for terminal status code
                        if (_response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                        {
                            continue;
                        }
                        // we are done polling, do a request on final target?
                        // create a new request with the final uri
                        request = request.CloneAndDispose(new global::System.Uri(_finalUri), Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get);

                        // drop the old response
                        _response?.Dispose();

                        // make the final call
                        _response = await sender.SendAsync(request,  eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                        break;
                    }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.BackupResult.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) .ReadHeaders(_response.Headers)));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="CloudHsmClustersBackup" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="cloudHsmClusterName">The name of the Cloud HSM Cluster within the specified resource group. Cloud HSM Cluster
        /// names must be between 3 and 23 characters in length.</param>
        /// <param name="body">Azure storage Resource Uri</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task CloudHsmClustersBackup_Validate(string subscriptionId, string resourceGroupName, string cloudHsmClusterName, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupRequestProperties body, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(subscriptionId),subscriptionId);
                await eventListener.AssertMinimumLength(nameof(subscriptionId),subscriptionId,1);
                await eventListener.AssertNotNull(nameof(resourceGroupName),resourceGroupName);
                await eventListener.AssertMinimumLength(nameof(resourceGroupName),resourceGroupName,1);
                await eventListener.AssertMaximumLength(nameof(resourceGroupName),resourceGroupName,90);
                await eventListener.AssertRegEx(nameof(resourceGroupName), resourceGroupName, @"^[-\w\._\(\)]+$");
                await eventListener.AssertNotNull(nameof(cloudHsmClusterName),cloudHsmClusterName);
                await eventListener.AssertMinimumLength(nameof(cloudHsmClusterName),cloudHsmClusterName,3);
                await eventListener.AssertMaximumLength(nameof(cloudHsmClusterName),cloudHsmClusterName,23);
                await eventListener.AssertRegEx(nameof(cloudHsmClusterName), cloudHsmClusterName, @"^[a-zA-Z0-9-]{3,23}$");
                await eventListener.AssertNotNull(nameof(body), body);
                await eventListener.AssertObjectIsValid(nameof(body), body);
            }
        }

        /// <summary>update a Cloud HSM Cluster in the specified subscription.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="cloudHsmClusterName">The name of the Cloud HSM Cluster within the specified resource group. Cloud HSM Cluster
        /// names must be between 3 and 23 characters in length.</param>
        /// <param name="body">Parameters to create Cloud HSM Cluster</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task CloudHsmClustersCreateOrUpdate(string subscriptionId, string resourceGroupName, string cloudHsmClusterName, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ICloudHsmCluster body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ICloudHsmCluster>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/"
                        + global::System.Uri.EscapeDataString(cloudHsmClusterName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Put, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.CloudHsmClustersCreateOrUpdate_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>update a Cloud HSM Cluster in the specified subscription.</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="body">Parameters to create Cloud HSM Cluster</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task CloudHsmClustersCreateOrUpdateViaIdentity(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ICloudHsmCluster body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ICloudHsmCluster>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/(?<cloudHsmClusterName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/{cloudHsmClusterName}'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var cloudHsmClusterName = _match.Groups["cloudHsmClusterName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/"
                        + cloudHsmClusterName
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Put, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.CloudHsmClustersCreateOrUpdate_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>update a Cloud HSM Cluster in the specified subscription.</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="body">Parameters to create Cloud HSM Cluster</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ICloudHsmCluster>" /> that
        /// will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ICloudHsmCluster> CloudHsmClustersCreateOrUpdateViaIdentityWithResult(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ICloudHsmCluster body, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/(?<cloudHsmClusterName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/{cloudHsmClusterName}'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var cloudHsmClusterName = _match.Groups["cloudHsmClusterName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/"
                        + cloudHsmClusterName
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Put, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.CloudHsmClustersCreateOrUpdateWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>update a Cloud HSM Cluster in the specified subscription.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="cloudHsmClusterName">The name of the Cloud HSM Cluster within the specified resource group. Cloud HSM Cluster
        /// names must be between 3 and 23 characters in length.</param>
        /// <param name="jsonString">Json string supplied to the CloudHsmClustersCreateOrUpdate operation</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task CloudHsmClustersCreateOrUpdateViaJsonString(string subscriptionId, string resourceGroupName, string cloudHsmClusterName, global::System.String jsonString, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ICloudHsmCluster>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/"
                        + global::System.Uri.EscapeDataString(cloudHsmClusterName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Put, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(jsonString, global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.CloudHsmClustersCreateOrUpdate_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>update a Cloud HSM Cluster in the specified subscription.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="cloudHsmClusterName">The name of the Cloud HSM Cluster within the specified resource group. Cloud HSM Cluster
        /// names must be between 3 and 23 characters in length.</param>
        /// <param name="jsonString">Json string supplied to the CloudHsmClustersCreateOrUpdate operation</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ICloudHsmCluster>" /> that
        /// will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ICloudHsmCluster> CloudHsmClustersCreateOrUpdateViaJsonStringWithResult(string subscriptionId, string resourceGroupName, string cloudHsmClusterName, global::System.String jsonString, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/"
                        + global::System.Uri.EscapeDataString(cloudHsmClusterName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Put, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(jsonString, global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.CloudHsmClustersCreateOrUpdateWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>update a Cloud HSM Cluster in the specified subscription.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="cloudHsmClusterName">The name of the Cloud HSM Cluster within the specified resource group. Cloud HSM Cluster
        /// names must be between 3 and 23 characters in length.</param>
        /// <param name="body">Parameters to create Cloud HSM Cluster</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ICloudHsmCluster>" /> that
        /// will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ICloudHsmCluster> CloudHsmClustersCreateOrUpdateWithResult(string subscriptionId, string resourceGroupName, string cloudHsmClusterName, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ICloudHsmCluster body, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/"
                        + global::System.Uri.EscapeDataString(cloudHsmClusterName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Put, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.CloudHsmClustersCreateOrUpdateWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>
        /// Actual wire call for <see cref= "CloudHsmClustersCreateOrUpdateWithResult" /> method.
        /// </summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ICloudHsmCluster>" /> that
        /// will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ICloudHsmCluster> CloudHsmClustersCreateOrUpdateWithResult_Call(global::System.Net.Http.HttpRequestMessage request, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    // this operation supports x-ms-long-running-operation
                    var _originalUri = request.RequestUri.AbsoluteUri;
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Progress, "intentional placeholder", 0); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    // declared final-state-via: original-uri
                    var asyncOperation = _response.GetFirstHeader(@"Azure-AsyncOperation");
                    var location = _response.GetFirstHeader(@"Location");
                    var operationLocation = _response.GetFirstHeader(@"Operation-Location");
                    while (request.Method == System.Net.Http.HttpMethod.Put && _response.StatusCode == global::System.Net.HttpStatusCode.OK || _response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                    {
                        // delay before making the next polling request
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.DelayBeforePolling, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }

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
                        request = request.CloneAndDispose(new global::System.Uri(_uri), Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get);

                        // and let's look at the current response body and see if we have some information we can give back to the listener
                        var content = await _response.Content.ReadAsStringAsync();

                        // drop the old response
                        _response?.Dispose();

                        // make the polling call
                        _response = await sender.SendAsync(request, eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }

                          // if we got back an OK, take a peek inside and see if it's done
                          if( _response.StatusCode == global::System.Net.HttpStatusCode.OK)
                          {
                              var error = false;
                              try {
                                  if( Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(await _response.Content.ReadAsStringAsync()) is Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonObject json)
                                  {
                                      var state = json.Property("properties")?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonString>("provisioningState") ?? json.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonString>("status");
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
                                  throw new Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.UndeclaredResponseException(_response);
                              }
                          }

                        // check for terminal status code
                        if (_response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                        {
                            continue;
                        }
                        // we are done polling, do a request on final target?
                        // create a new request with the final uri
                        request = request.CloneAndDispose(new global::System.Uri(_originalUri), Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get);

                        // drop the old response
                        _response?.Dispose();

                        // make the final call
                        _response = await sender.SendAsync(request,  eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                        break;
                    }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.CloudHsmCluster.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) );
                            return await _result;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) );
                            // Error Response : default
                            var code = (await _result)?.Code;
                            var message = (await _result)?.Message;
                            if ((null == code || null == message))
                            {
                                // Unrecognized Response. Create an error record based on what we have.
                                var ex = new Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>(_response, await _result);
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
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>Actual wire call for <see cref= "CloudHsmClustersCreateOrUpdate" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task CloudHsmClustersCreateOrUpdate_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ICloudHsmCluster>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    // this operation supports x-ms-long-running-operation
                    var _originalUri = request.RequestUri.AbsoluteUri;
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Progress, "intentional placeholder", 0); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    // declared final-state-via: original-uri
                    var asyncOperation = _response.GetFirstHeader(@"Azure-AsyncOperation");
                    var location = _response.GetFirstHeader(@"Location");
                    var operationLocation = _response.GetFirstHeader(@"Operation-Location");
                    while (request.Method == System.Net.Http.HttpMethod.Put && _response.StatusCode == global::System.Net.HttpStatusCode.OK || _response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                    {
                        // delay before making the next polling request
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.DelayBeforePolling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }

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
                        request = request.CloneAndDispose(new global::System.Uri(_uri), Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get);

                        // and let's look at the current response body and see if we have some information we can give back to the listener
                        var content = await _response.Content.ReadAsStringAsync();

                        // drop the old response
                        _response?.Dispose();

                        // make the polling call
                        _response = await sender.SendAsync(request, eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }

                          // if we got back an OK, take a peek inside and see if it's done
                          if( _response.StatusCode == global::System.Net.HttpStatusCode.OK)
                          {
                              var error = false;
                              try {
                                  if( Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(await _response.Content.ReadAsStringAsync()) is Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonObject json)
                                  {
                                      var state = json.Property("properties")?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonString>("provisioningState") ?? json.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonString>("status");
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
                                  throw new Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.UndeclaredResponseException(_response);
                              }
                          }

                        // check for terminal status code
                        if (_response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                        {
                            continue;
                        }
                        // we are done polling, do a request on final target?
                        // create a new request with the final uri
                        request = request.CloneAndDispose(new global::System.Uri(_originalUri), Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get);

                        // drop the old response
                        _response?.Dispose();

                        // make the final call
                        _response = await sender.SendAsync(request,  eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                        break;
                    }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.CloudHsmCluster.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="CloudHsmClustersCreateOrUpdate" /> method. Call this like the actual call, but you will
        /// get validation events back.
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="cloudHsmClusterName">The name of the Cloud HSM Cluster within the specified resource group. Cloud HSM Cluster
        /// names must be between 3 and 23 characters in length.</param>
        /// <param name="body">Parameters to create Cloud HSM Cluster</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task CloudHsmClustersCreateOrUpdate_Validate(string subscriptionId, string resourceGroupName, string cloudHsmClusterName, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ICloudHsmCluster body, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(subscriptionId),subscriptionId);
                await eventListener.AssertMinimumLength(nameof(subscriptionId),subscriptionId,1);
                await eventListener.AssertNotNull(nameof(resourceGroupName),resourceGroupName);
                await eventListener.AssertMinimumLength(nameof(resourceGroupName),resourceGroupName,1);
                await eventListener.AssertMaximumLength(nameof(resourceGroupName),resourceGroupName,90);
                await eventListener.AssertRegEx(nameof(resourceGroupName), resourceGroupName, @"^[-\w\._\(\)]+$");
                await eventListener.AssertNotNull(nameof(cloudHsmClusterName),cloudHsmClusterName);
                await eventListener.AssertMinimumLength(nameof(cloudHsmClusterName),cloudHsmClusterName,3);
                await eventListener.AssertMaximumLength(nameof(cloudHsmClusterName),cloudHsmClusterName,23);
                await eventListener.AssertRegEx(nameof(cloudHsmClusterName), cloudHsmClusterName, @"^[a-zA-Z0-9-]{3,23}$");
                await eventListener.AssertNotNull(nameof(body), body);
                await eventListener.AssertObjectIsValid(nameof(body), body);
            }
        }

        /// <summary>Deletes the specified Cloud HSM Cluster</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="cloudHsmClusterName">The name of the Cloud HSM Cluster within the specified resource group. Cloud HSM Cluster
        /// names must be between 3 and 23 characters in length.</param>
        /// <param name="onNoContent">a delegate that is called when the remote service returns 204 (NoContent).</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task CloudHsmClustersDelete(string subscriptionId, string resourceGroupName, string cloudHsmClusterName, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onNoContent, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/"
                        + global::System.Uri.EscapeDataString(cloudHsmClusterName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Delete, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.CloudHsmClustersDelete_Call (request, onNoContent,onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>Deletes the specified Cloud HSM Cluster</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="onNoContent">a delegate that is called when the remote service returns 204 (NoContent).</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task CloudHsmClustersDeleteViaIdentity(global::System.String viaIdentity, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onNoContent, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/(?<cloudHsmClusterName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/{cloudHsmClusterName}'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var cloudHsmClusterName = _match.Groups["cloudHsmClusterName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/"
                        + cloudHsmClusterName
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Delete, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.CloudHsmClustersDelete_Call (request, onNoContent,onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref= "CloudHsmClustersDelete" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onNoContent">a delegate that is called when the remote service returns 204 (NoContent).</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task CloudHsmClustersDelete_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onNoContent, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    // this operation supports x-ms-long-running-operation
                    var _originalUri = request.RequestUri.AbsoluteUri;
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Progress, "intentional placeholder", 0); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    // declared final-state-via: location
                    var _finalUri = _response.GetFirstHeader(@"Location");
                    var asyncOperation = _response.GetFirstHeader(@"Azure-AsyncOperation");
                    var location = _response.GetFirstHeader(@"Location");
                    var operationLocation = _response.GetFirstHeader(@"Operation-Location");
                    while (request.Method == System.Net.Http.HttpMethod.Put && _response.StatusCode == global::System.Net.HttpStatusCode.OK || _response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                    {
                        // delay before making the next polling request
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.DelayBeforePolling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }

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
                        request = request.CloneAndDispose(new global::System.Uri(_uri), Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get);

                        // and let's look at the current response body and see if we have some information we can give back to the listener
                        var content = await _response.Content.ReadAsStringAsync();

                        // drop the old response
                        _response?.Dispose();

                        // make the polling call
                        _response = await sender.SendAsync(request, eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }

                          // if we got back an OK, take a peek inside and see if it's done
                          if( _response.StatusCode == global::System.Net.HttpStatusCode.OK)
                          {
                              var error = false;
                              try {
                                  if( Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(await _response.Content.ReadAsStringAsync()) is Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonObject json)
                                  {
                                      var state = json.Property("properties")?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonString>("provisioningState") ?? json.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonString>("status");
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
                                  throw new Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.UndeclaredResponseException(_response);
                              }
                          }

                        // check for terminal status code
                        if (_response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                        {
                            continue;
                        }
                        // we are done polling, do a request on final target?
                        // create a new request with the final uri
                        request = request.CloneAndDispose(new global::System.Uri(_finalUri), Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get);

                        // drop the old response
                        _response?.Dispose();

                        // make the final call
                        _response = await sender.SendAsync(request,  eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                        break;
                    }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response);
                            break;
                        }
                        case global::System.Net.HttpStatusCode.NoContent:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onNoContent(_response);
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="CloudHsmClustersDelete" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="cloudHsmClusterName">The name of the Cloud HSM Cluster within the specified resource group. Cloud HSM Cluster
        /// names must be between 3 and 23 characters in length.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task CloudHsmClustersDelete_Validate(string subscriptionId, string resourceGroupName, string cloudHsmClusterName, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(subscriptionId),subscriptionId);
                await eventListener.AssertMinimumLength(nameof(subscriptionId),subscriptionId,1);
                await eventListener.AssertNotNull(nameof(resourceGroupName),resourceGroupName);
                await eventListener.AssertMinimumLength(nameof(resourceGroupName),resourceGroupName,1);
                await eventListener.AssertMaximumLength(nameof(resourceGroupName),resourceGroupName,90);
                await eventListener.AssertRegEx(nameof(resourceGroupName), resourceGroupName, @"^[-\w\._\(\)]+$");
                await eventListener.AssertNotNull(nameof(cloudHsmClusterName),cloudHsmClusterName);
                await eventListener.AssertMinimumLength(nameof(cloudHsmClusterName),cloudHsmClusterName,3);
                await eventListener.AssertMaximumLength(nameof(cloudHsmClusterName),cloudHsmClusterName,23);
                await eventListener.AssertRegEx(nameof(cloudHsmClusterName), cloudHsmClusterName, @"^[a-zA-Z0-9-]{3,23}$");
            }
        }

        /// <summary>Gets the specified Cloud HSM Cluster</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="cloudHsmClusterName">The name of the Cloud HSM Cluster within the specified resource group. Cloud HSM Cluster
        /// names must be between 3 and 23 characters in length.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task CloudHsmClustersGet(string subscriptionId, string resourceGroupName, string cloudHsmClusterName, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ICloudHsmCluster>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/"
                        + global::System.Uri.EscapeDataString(cloudHsmClusterName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.CloudHsmClustersGet_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>Gets the specified Cloud HSM Cluster</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task CloudHsmClustersGetViaIdentity(global::System.String viaIdentity, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ICloudHsmCluster>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/(?<cloudHsmClusterName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/{cloudHsmClusterName}'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var cloudHsmClusterName = _match.Groups["cloudHsmClusterName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/"
                        + cloudHsmClusterName
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.CloudHsmClustersGet_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>Gets the specified Cloud HSM Cluster</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ICloudHsmCluster>" /> that
        /// will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ICloudHsmCluster> CloudHsmClustersGetViaIdentityWithResult(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/(?<cloudHsmClusterName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/{cloudHsmClusterName}'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var cloudHsmClusterName = _match.Groups["cloudHsmClusterName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/"
                        + cloudHsmClusterName
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.CloudHsmClustersGetWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>Gets the specified Cloud HSM Cluster</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="cloudHsmClusterName">The name of the Cloud HSM Cluster within the specified resource group. Cloud HSM Cluster
        /// names must be between 3 and 23 characters in length.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ICloudHsmCluster>" /> that
        /// will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ICloudHsmCluster> CloudHsmClustersGetWithResult(string subscriptionId, string resourceGroupName, string cloudHsmClusterName, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/"
                        + global::System.Uri.EscapeDataString(cloudHsmClusterName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.CloudHsmClustersGetWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref= "CloudHsmClustersGetWithResult" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ICloudHsmCluster>" /> that
        /// will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ICloudHsmCluster> CloudHsmClustersGetWithResult_Call(global::System.Net.Http.HttpRequestMessage request, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.CloudHsmCluster.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) );
                            return await _result;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) );
                            // Error Response : default
                            var code = (await _result)?.Code;
                            var message = (await _result)?.Message;
                            if ((null == code || null == message))
                            {
                                // Unrecognized Response. Create an error record based on what we have.
                                var ex = new Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>(_response, await _result);
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
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>Actual wire call for <see cref= "CloudHsmClustersGet" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task CloudHsmClustersGet_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ICloudHsmCluster>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.CloudHsmCluster.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="CloudHsmClustersGet" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="cloudHsmClusterName">The name of the Cloud HSM Cluster within the specified resource group. Cloud HSM Cluster
        /// names must be between 3 and 23 characters in length.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task CloudHsmClustersGet_Validate(string subscriptionId, string resourceGroupName, string cloudHsmClusterName, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(subscriptionId),subscriptionId);
                await eventListener.AssertMinimumLength(nameof(subscriptionId),subscriptionId,1);
                await eventListener.AssertNotNull(nameof(resourceGroupName),resourceGroupName);
                await eventListener.AssertMinimumLength(nameof(resourceGroupName),resourceGroupName,1);
                await eventListener.AssertMaximumLength(nameof(resourceGroupName),resourceGroupName,90);
                await eventListener.AssertRegEx(nameof(resourceGroupName), resourceGroupName, @"^[-\w\._\(\)]+$");
                await eventListener.AssertNotNull(nameof(cloudHsmClusterName),cloudHsmClusterName);
                await eventListener.AssertMinimumLength(nameof(cloudHsmClusterName),cloudHsmClusterName,3);
                await eventListener.AssertMaximumLength(nameof(cloudHsmClusterName),cloudHsmClusterName,23);
                await eventListener.AssertRegEx(nameof(cloudHsmClusterName), cloudHsmClusterName, @"^[a-zA-Z0-9-]{3,23}$");
            }
        }

        /// <summary>
        /// The List operation gets information about the Cloud HSM Clusters associated with the subscription and within the specified
        /// resource group.
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="Skiptoken">The page-continuation token to use with a paged version of this API</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task CloudHsmClustersListByResourceGroup(string subscriptionId, string resourceGroupName, string Skiptoken, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ICloudHsmClusterListResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        + "&"
                        + (string.IsNullOrEmpty(Skiptoken) ? global::System.String.Empty : "$skiptoken=" + global::System.Uri.EscapeDataString(Skiptoken))
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.CloudHsmClustersListByResourceGroup_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>
        /// The List operation gets information about the Cloud HSM Clusters associated with the subscription and within the specified
        /// resource group.
        /// </summary>
        /// <param name="viaIdentity"></param>
        /// <param name="Skiptoken">The page-continuation token to use with a paged version of this API</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task CloudHsmClustersListByResourceGroupViaIdentity(global::System.String viaIdentity, string Skiptoken, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ICloudHsmClusterListResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        + "&"
                        + (string.IsNullOrEmpty(Skiptoken) ? global::System.String.Empty : "$skiptoken=" + global::System.Uri.EscapeDataString(Skiptoken))
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.CloudHsmClustersListByResourceGroup_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>
        /// The List operation gets information about the Cloud HSM Clusters associated with the subscription and within the specified
        /// resource group.
        /// </summary>
        /// <param name="viaIdentity"></param>
        /// <param name="Skiptoken">The page-continuation token to use with a paged version of this API</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ICloudHsmClusterListResult>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ICloudHsmClusterListResult> CloudHsmClustersListByResourceGroupViaIdentityWithResult(global::System.String viaIdentity, string Skiptoken, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        + "&"
                        + (string.IsNullOrEmpty(Skiptoken) ? global::System.String.Empty : "$skiptoken=" + global::System.Uri.EscapeDataString(Skiptoken))
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.CloudHsmClustersListByResourceGroupWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>
        /// The List operation gets information about the Cloud HSM Clusters associated with the subscription and within the specified
        /// resource group.
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="Skiptoken">The page-continuation token to use with a paged version of this API</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ICloudHsmClusterListResult>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ICloudHsmClusterListResult> CloudHsmClustersListByResourceGroupWithResult(string subscriptionId, string resourceGroupName, string Skiptoken, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        + "&"
                        + (string.IsNullOrEmpty(Skiptoken) ? global::System.String.Empty : "$skiptoken=" + global::System.Uri.EscapeDataString(Skiptoken))
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.CloudHsmClustersListByResourceGroupWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>
        /// Actual wire call for <see cref= "CloudHsmClustersListByResourceGroupWithResult" /> method.
        /// </summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ICloudHsmClusterListResult>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ICloudHsmClusterListResult> CloudHsmClustersListByResourceGroupWithResult_Call(global::System.Net.Http.HttpRequestMessage request, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.CloudHsmClusterListResult.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) );
                            return await _result;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) );
                            // Error Response : default
                            var code = (await _result)?.Code;
                            var message = (await _result)?.Message;
                            if ((null == code || null == message))
                            {
                                // Unrecognized Response. Create an error record based on what we have.
                                var ex = new Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>(_response, await _result);
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
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Actual wire call for <see cref= "CloudHsmClustersListByResourceGroup" /> method.
        /// </summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task CloudHsmClustersListByResourceGroup_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ICloudHsmClusterListResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.CloudHsmClusterListResult.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="CloudHsmClustersListByResourceGroup" /> method. Call this like the actual call, but you
        /// will get validation events back.
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="Skiptoken">The page-continuation token to use with a paged version of this API</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task CloudHsmClustersListByResourceGroup_Validate(string subscriptionId, string resourceGroupName, string Skiptoken, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(subscriptionId),subscriptionId);
                await eventListener.AssertMinimumLength(nameof(subscriptionId),subscriptionId,1);
                await eventListener.AssertNotNull(nameof(resourceGroupName),resourceGroupName);
                await eventListener.AssertMinimumLength(nameof(resourceGroupName),resourceGroupName,1);
                await eventListener.AssertMaximumLength(nameof(resourceGroupName),resourceGroupName,90);
                await eventListener.AssertRegEx(nameof(resourceGroupName), resourceGroupName, @"^[-\w\._\(\)]+$");
                await eventListener.AssertNotNull(nameof(Skiptoken),Skiptoken);
            }
        }

        /// <summary>
        /// The List operation gets information about the Cloud HSM Clusters associated with the subscription.
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="Skiptoken">The page-continuation token to use with a paged version of this API</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task CloudHsmClustersListBySubscription(string subscriptionId, string Skiptoken, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ICloudHsmClusterListResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        + "&"
                        + (string.IsNullOrEmpty(Skiptoken) ? global::System.String.Empty : "$skiptoken=" + global::System.Uri.EscapeDataString(Skiptoken))
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.CloudHsmClustersListBySubscription_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>
        /// The List operation gets information about the Cloud HSM Clusters associated with the subscription.
        /// </summary>
        /// <param name="viaIdentity"></param>
        /// <param name="Skiptoken">The page-continuation token to use with a paged version of this API</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task CloudHsmClustersListBySubscriptionViaIdentity(global::System.String viaIdentity, string Skiptoken, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ICloudHsmClusterListResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        + "&"
                        + (string.IsNullOrEmpty(Skiptoken) ? global::System.String.Empty : "$skiptoken=" + global::System.Uri.EscapeDataString(Skiptoken))
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.CloudHsmClustersListBySubscription_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>
        /// The List operation gets information about the Cloud HSM Clusters associated with the subscription.
        /// </summary>
        /// <param name="viaIdentity"></param>
        /// <param name="Skiptoken">The page-continuation token to use with a paged version of this API</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ICloudHsmClusterListResult>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ICloudHsmClusterListResult> CloudHsmClustersListBySubscriptionViaIdentityWithResult(global::System.String viaIdentity, string Skiptoken, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        + "&"
                        + (string.IsNullOrEmpty(Skiptoken) ? global::System.String.Empty : "$skiptoken=" + global::System.Uri.EscapeDataString(Skiptoken))
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.CloudHsmClustersListBySubscriptionWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>
        /// The List operation gets information about the Cloud HSM Clusters associated with the subscription.
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="Skiptoken">The page-continuation token to use with a paged version of this API</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ICloudHsmClusterListResult>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ICloudHsmClusterListResult> CloudHsmClustersListBySubscriptionWithResult(string subscriptionId, string Skiptoken, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        + "&"
                        + (string.IsNullOrEmpty(Skiptoken) ? global::System.String.Empty : "$skiptoken=" + global::System.Uri.EscapeDataString(Skiptoken))
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.CloudHsmClustersListBySubscriptionWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>
        /// Actual wire call for <see cref= "CloudHsmClustersListBySubscriptionWithResult" /> method.
        /// </summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ICloudHsmClusterListResult>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ICloudHsmClusterListResult> CloudHsmClustersListBySubscriptionWithResult_Call(global::System.Net.Http.HttpRequestMessage request, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.CloudHsmClusterListResult.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) );
                            return await _result;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) );
                            // Error Response : default
                            var code = (await _result)?.Code;
                            var message = (await _result)?.Message;
                            if ((null == code || null == message))
                            {
                                // Unrecognized Response. Create an error record based on what we have.
                                var ex = new Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>(_response, await _result);
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
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>Actual wire call for <see cref= "CloudHsmClustersListBySubscription" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task CloudHsmClustersListBySubscription_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ICloudHsmClusterListResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.CloudHsmClusterListResult.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="CloudHsmClustersListBySubscription" /> method. Call this like the actual call, but you
        /// will get validation events back.
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="Skiptoken">The page-continuation token to use with a paged version of this API</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task CloudHsmClustersListBySubscription_Validate(string subscriptionId, string Skiptoken, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(subscriptionId),subscriptionId);
                await eventListener.AssertMinimumLength(nameof(subscriptionId),subscriptionId,1);
                await eventListener.AssertNotNull(nameof(Skiptoken),Skiptoken);
            }
        }

        /// <summary>Restores all key materials of a specified Cloud HSM Cluster</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="cloudHsmClusterName">The name of the Cloud HSM Cluster within the specified resource group. Cloud HSM Cluster
        /// names must be between 3 and 23 characters in length.</param>
        /// <param name="body">Restore Operation Required properties</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task CloudHsmClustersRestore(string subscriptionId, string resourceGroupName, string cloudHsmClusterName, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IRestoreRequestProperties body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IRestoreResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/"
                        + global::System.Uri.EscapeDataString(cloudHsmClusterName)
                        + "/restore"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.CloudHsmClustersRestore_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>Restores all key materials of a specified Cloud HSM Cluster</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="body">Restore Operation Required properties</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task CloudHsmClustersRestoreViaIdentity(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IRestoreRequestProperties body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IRestoreResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/(?<cloudHsmClusterName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/{cloudHsmClusterName}'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var cloudHsmClusterName = _match.Groups["cloudHsmClusterName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/"
                        + cloudHsmClusterName
                        + "/restore"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.CloudHsmClustersRestore_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>Restores all key materials of a specified Cloud HSM Cluster</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="body">Restore Operation Required properties</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IRestoreResult>" /> that
        /// will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IRestoreResult> CloudHsmClustersRestoreViaIdentityWithResult(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IRestoreRequestProperties body, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/(?<cloudHsmClusterName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/{cloudHsmClusterName}'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var cloudHsmClusterName = _match.Groups["cloudHsmClusterName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/"
                        + cloudHsmClusterName
                        + "/restore"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.CloudHsmClustersRestoreWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>Restores all key materials of a specified Cloud HSM Cluster</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="cloudHsmClusterName">The name of the Cloud HSM Cluster within the specified resource group. Cloud HSM Cluster
        /// names must be between 3 and 23 characters in length.</param>
        /// <param name="jsonString">Json string supplied to the CloudHsmClustersRestore operation</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task CloudHsmClustersRestoreViaJsonString(string subscriptionId, string resourceGroupName, string cloudHsmClusterName, global::System.String jsonString, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IRestoreResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/"
                        + global::System.Uri.EscapeDataString(cloudHsmClusterName)
                        + "/restore"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(jsonString, global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.CloudHsmClustersRestore_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>Restores all key materials of a specified Cloud HSM Cluster</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="cloudHsmClusterName">The name of the Cloud HSM Cluster within the specified resource group. Cloud HSM Cluster
        /// names must be between 3 and 23 characters in length.</param>
        /// <param name="jsonString">Json string supplied to the CloudHsmClustersRestore operation</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IRestoreResult>" /> that
        /// will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IRestoreResult> CloudHsmClustersRestoreViaJsonStringWithResult(string subscriptionId, string resourceGroupName, string cloudHsmClusterName, global::System.String jsonString, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/"
                        + global::System.Uri.EscapeDataString(cloudHsmClusterName)
                        + "/restore"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(jsonString, global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.CloudHsmClustersRestoreWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>Restores all key materials of a specified Cloud HSM Cluster</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="cloudHsmClusterName">The name of the Cloud HSM Cluster within the specified resource group. Cloud HSM Cluster
        /// names must be between 3 and 23 characters in length.</param>
        /// <param name="body">Restore Operation Required properties</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IRestoreResult>" /> that
        /// will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IRestoreResult> CloudHsmClustersRestoreWithResult(string subscriptionId, string resourceGroupName, string cloudHsmClusterName, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IRestoreRequestProperties body, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/"
                        + global::System.Uri.EscapeDataString(cloudHsmClusterName)
                        + "/restore"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.CloudHsmClustersRestoreWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref= "CloudHsmClustersRestoreWithResult" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IRestoreResult>" /> that
        /// will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IRestoreResult> CloudHsmClustersRestoreWithResult_Call(global::System.Net.Http.HttpRequestMessage request, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    // this operation supports x-ms-long-running-operation
                    var _originalUri = request.RequestUri.AbsoluteUri;
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Progress, "intentional placeholder", 0); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    // declared final-state-via: azure-async-operation
                    var _finalUri = _response.GetFirstHeader(@"Azure-AsyncOperation");
                    var asyncOperation = _response.GetFirstHeader(@"Azure-AsyncOperation");
                    var location = _response.GetFirstHeader(@"Location");
                    var operationLocation = _response.GetFirstHeader(@"Operation-Location");
                    while (request.Method == System.Net.Http.HttpMethod.Put && _response.StatusCode == global::System.Net.HttpStatusCode.OK || _response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                    {
                        // delay before making the next polling request
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.DelayBeforePolling, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }

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
                        request = request.CloneAndDispose(new global::System.Uri(_uri), Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get);

                        // and let's look at the current response body and see if we have some information we can give back to the listener
                        var content = await _response.Content.ReadAsStringAsync();

                        // drop the old response
                        _response?.Dispose();

                        // make the polling call
                        _response = await sender.SendAsync(request, eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }

                          // if we got back an OK, take a peek inside and see if it's done
                          if( _response.StatusCode == global::System.Net.HttpStatusCode.OK)
                          {
                              var error = false;
                              try {
                                  if( Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(await _response.Content.ReadAsStringAsync()) is Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonObject json)
                                  {
                                      var state = json.Property("properties")?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonString>("provisioningState") ?? json.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonString>("status");
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
                                  throw new Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.UndeclaredResponseException(_response);
                              }
                          }

                        // check for terminal status code
                        if (_response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                        {
                            continue;
                        }
                        // we are done polling, do a request on final target?
                        // create a new request with the final uri
                        request = request.CloneAndDispose(new global::System.Uri(_finalUri), Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get);

                        // drop the old response
                        _response?.Dispose();

                        // make the final call
                        _response = await sender.SendAsync(request,  eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                        break;
                    }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.RestoreResult.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) .ReadHeaders(_response.Headers));
                            return await _result;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) );
                            // Error Response : default
                            var code = (await _result)?.Code;
                            var message = (await _result)?.Message;
                            if ((null == code || null == message))
                            {
                                // Unrecognized Response. Create an error record based on what we have.
                                var ex = new Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>(_response, await _result);
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
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>Actual wire call for <see cref= "CloudHsmClustersRestore" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task CloudHsmClustersRestore_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IRestoreResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    // this operation supports x-ms-long-running-operation
                    var _originalUri = request.RequestUri.AbsoluteUri;
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Progress, "intentional placeholder", 0); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    // declared final-state-via: azure-async-operation
                    var _finalUri = _response.GetFirstHeader(@"Azure-AsyncOperation");
                    var asyncOperation = _response.GetFirstHeader(@"Azure-AsyncOperation");
                    var location = _response.GetFirstHeader(@"Location");
                    var operationLocation = _response.GetFirstHeader(@"Operation-Location");
                    while (request.Method == System.Net.Http.HttpMethod.Put && _response.StatusCode == global::System.Net.HttpStatusCode.OK || _response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                    {
                        // delay before making the next polling request
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.DelayBeforePolling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }

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
                        request = request.CloneAndDispose(new global::System.Uri(_uri), Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get);

                        // and let's look at the current response body and see if we have some information we can give back to the listener
                        var content = await _response.Content.ReadAsStringAsync();

                        // drop the old response
                        _response?.Dispose();

                        // make the polling call
                        _response = await sender.SendAsync(request, eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }

                          // if we got back an OK, take a peek inside and see if it's done
                          if( _response.StatusCode == global::System.Net.HttpStatusCode.OK)
                          {
                              var error = false;
                              try {
                                  if( Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(await _response.Content.ReadAsStringAsync()) is Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonObject json)
                                  {
                                      var state = json.Property("properties")?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonString>("provisioningState") ?? json.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonString>("status");
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
                                  throw new Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.UndeclaredResponseException(_response);
                              }
                          }

                        // check for terminal status code
                        if (_response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                        {
                            continue;
                        }
                        // we are done polling, do a request on final target?
                        // create a new request with the final uri
                        request = request.CloneAndDispose(new global::System.Uri(_finalUri), Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get);

                        // drop the old response
                        _response?.Dispose();

                        // make the final call
                        _response = await sender.SendAsync(request,  eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                        break;
                    }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.RestoreResult.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) .ReadHeaders(_response.Headers)));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="CloudHsmClustersRestore" /> method. Call this like the actual call, but you will get
        /// validation events back.
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="cloudHsmClusterName">The name of the Cloud HSM Cluster within the specified resource group. Cloud HSM Cluster
        /// names must be between 3 and 23 characters in length.</param>
        /// <param name="body">Restore Operation Required properties</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task CloudHsmClustersRestore_Validate(string subscriptionId, string resourceGroupName, string cloudHsmClusterName, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IRestoreRequestProperties body, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(subscriptionId),subscriptionId);
                await eventListener.AssertMinimumLength(nameof(subscriptionId),subscriptionId,1);
                await eventListener.AssertNotNull(nameof(resourceGroupName),resourceGroupName);
                await eventListener.AssertMinimumLength(nameof(resourceGroupName),resourceGroupName,1);
                await eventListener.AssertMaximumLength(nameof(resourceGroupName),resourceGroupName,90);
                await eventListener.AssertRegEx(nameof(resourceGroupName), resourceGroupName, @"^[-\w\._\(\)]+$");
                await eventListener.AssertNotNull(nameof(cloudHsmClusterName),cloudHsmClusterName);
                await eventListener.AssertMinimumLength(nameof(cloudHsmClusterName),cloudHsmClusterName,3);
                await eventListener.AssertMaximumLength(nameof(cloudHsmClusterName),cloudHsmClusterName,23);
                await eventListener.AssertRegEx(nameof(cloudHsmClusterName), cloudHsmClusterName, @"^[a-zA-Z0-9-]{3,23}$");
                await eventListener.AssertNotNull(nameof(body), body);
                await eventListener.AssertObjectIsValid(nameof(body), body);
            }
        }

        /// <summary>Update a Cloud HSM Cluster in the specified subscription.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="cloudHsmClusterName">The name of the Cloud HSM Cluster within the specified resource group. Cloud HSM Cluster
        /// names must be between 3 and 23 characters in length.</param>
        /// <param name="body">Parameters to create Cloud HSM Cluster</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task CloudHsmClustersUpdate(string subscriptionId, string resourceGroupName, string cloudHsmClusterName, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ICloudHsmClusterPatchParameters body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ICloudHsmCluster>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/"
                        + global::System.Uri.EscapeDataString(cloudHsmClusterName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Patch, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.CloudHsmClustersUpdate_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>Update a Cloud HSM Cluster in the specified subscription.</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="body">Parameters to create Cloud HSM Cluster</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task CloudHsmClustersUpdateViaIdentity(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ICloudHsmClusterPatchParameters body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ICloudHsmCluster>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/(?<cloudHsmClusterName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/{cloudHsmClusterName}'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var cloudHsmClusterName = _match.Groups["cloudHsmClusterName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/"
                        + cloudHsmClusterName
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Patch, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.CloudHsmClustersUpdate_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>Update a Cloud HSM Cluster in the specified subscription.</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="body">Parameters to create Cloud HSM Cluster</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ICloudHsmCluster>" /> that
        /// will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ICloudHsmCluster> CloudHsmClustersUpdateViaIdentityWithResult(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ICloudHsmClusterPatchParameters body, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/(?<cloudHsmClusterName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/{cloudHsmClusterName}'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var cloudHsmClusterName = _match.Groups["cloudHsmClusterName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/"
                        + cloudHsmClusterName
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Patch, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.CloudHsmClustersUpdateWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>Update a Cloud HSM Cluster in the specified subscription.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="cloudHsmClusterName">The name of the Cloud HSM Cluster within the specified resource group. Cloud HSM Cluster
        /// names must be between 3 and 23 characters in length.</param>
        /// <param name="jsonString">Json string supplied to the CloudHsmClustersUpdate operation</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task CloudHsmClustersUpdateViaJsonString(string subscriptionId, string resourceGroupName, string cloudHsmClusterName, global::System.String jsonString, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ICloudHsmCluster>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/"
                        + global::System.Uri.EscapeDataString(cloudHsmClusterName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Patch, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(jsonString, global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.CloudHsmClustersUpdate_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>Update a Cloud HSM Cluster in the specified subscription.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="cloudHsmClusterName">The name of the Cloud HSM Cluster within the specified resource group. Cloud HSM Cluster
        /// names must be between 3 and 23 characters in length.</param>
        /// <param name="jsonString">Json string supplied to the CloudHsmClustersUpdate operation</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ICloudHsmCluster>" /> that
        /// will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ICloudHsmCluster> CloudHsmClustersUpdateViaJsonStringWithResult(string subscriptionId, string resourceGroupName, string cloudHsmClusterName, global::System.String jsonString, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/"
                        + global::System.Uri.EscapeDataString(cloudHsmClusterName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Patch, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(jsonString, global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.CloudHsmClustersUpdateWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>Update a Cloud HSM Cluster in the specified subscription.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="cloudHsmClusterName">The name of the Cloud HSM Cluster within the specified resource group. Cloud HSM Cluster
        /// names must be between 3 and 23 characters in length.</param>
        /// <param name="body">Parameters to create Cloud HSM Cluster</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ICloudHsmCluster>" /> that
        /// will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ICloudHsmCluster> CloudHsmClustersUpdateWithResult(string subscriptionId, string resourceGroupName, string cloudHsmClusterName, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ICloudHsmClusterPatchParameters body, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/"
                        + global::System.Uri.EscapeDataString(cloudHsmClusterName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Patch, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.CloudHsmClustersUpdateWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref= "CloudHsmClustersUpdateWithResult" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ICloudHsmCluster>" /> that
        /// will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ICloudHsmCluster> CloudHsmClustersUpdateWithResult_Call(global::System.Net.Http.HttpRequestMessage request, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    // this operation supports x-ms-long-running-operation
                    var _originalUri = request.RequestUri.AbsoluteUri;
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Progress, "intentional placeholder", 0); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    // declared final-state-via: location
                    var _finalUri = _response.GetFirstHeader(@"Location");
                    var asyncOperation = _response.GetFirstHeader(@"Azure-AsyncOperation");
                    var location = _response.GetFirstHeader(@"Location");
                    var operationLocation = _response.GetFirstHeader(@"Operation-Location");
                    while (request.Method == System.Net.Http.HttpMethod.Put && _response.StatusCode == global::System.Net.HttpStatusCode.OK || _response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                    {
                        // delay before making the next polling request
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.DelayBeforePolling, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }

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
                        request = request.CloneAndDispose(new global::System.Uri(_uri), Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get);

                        // and let's look at the current response body and see if we have some information we can give back to the listener
                        var content = await _response.Content.ReadAsStringAsync();

                        // drop the old response
                        _response?.Dispose();

                        // make the polling call
                        _response = await sender.SendAsync(request, eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }

                          // if we got back an OK, take a peek inside and see if it's done
                          if( _response.StatusCode == global::System.Net.HttpStatusCode.OK)
                          {
                              var error = false;
                              try {
                                  if( Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(await _response.Content.ReadAsStringAsync()) is Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonObject json)
                                  {
                                      var state = json.Property("properties")?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonString>("provisioningState") ?? json.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonString>("status");
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
                                  throw new Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.UndeclaredResponseException(_response);
                              }
                          }

                        // check for terminal status code
                        if (_response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                        {
                            continue;
                        }
                        // we are done polling, do a request on final target?
                        // create a new request with the final uri
                        request = request.CloneAndDispose(new global::System.Uri(_finalUri), Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get);

                        // drop the old response
                        _response?.Dispose();

                        // make the final call
                        _response = await sender.SendAsync(request,  eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                        break;
                    }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.CloudHsmCluster.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) );
                            return await _result;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) );
                            // Error Response : default
                            var code = (await _result)?.Code;
                            var message = (await _result)?.Message;
                            if ((null == code || null == message))
                            {
                                // Unrecognized Response. Create an error record based on what we have.
                                var ex = new Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>(_response, await _result);
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
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>Actual wire call for <see cref= "CloudHsmClustersUpdate" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task CloudHsmClustersUpdate_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ICloudHsmCluster>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    // this operation supports x-ms-long-running-operation
                    var _originalUri = request.RequestUri.AbsoluteUri;
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Progress, "intentional placeholder", 0); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    // declared final-state-via: location
                    var _finalUri = _response.GetFirstHeader(@"Location");
                    var asyncOperation = _response.GetFirstHeader(@"Azure-AsyncOperation");
                    var location = _response.GetFirstHeader(@"Location");
                    var operationLocation = _response.GetFirstHeader(@"Operation-Location");
                    while (request.Method == System.Net.Http.HttpMethod.Put && _response.StatusCode == global::System.Net.HttpStatusCode.OK || _response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                    {
                        // delay before making the next polling request
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.DelayBeforePolling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }

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
                        request = request.CloneAndDispose(new global::System.Uri(_uri), Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get);

                        // and let's look at the current response body and see if we have some information we can give back to the listener
                        var content = await _response.Content.ReadAsStringAsync();

                        // drop the old response
                        _response?.Dispose();

                        // make the polling call
                        _response = await sender.SendAsync(request, eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }

                          // if we got back an OK, take a peek inside and see if it's done
                          if( _response.StatusCode == global::System.Net.HttpStatusCode.OK)
                          {
                              var error = false;
                              try {
                                  if( Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(await _response.Content.ReadAsStringAsync()) is Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonObject json)
                                  {
                                      var state = json.Property("properties")?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonString>("provisioningState") ?? json.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonString>("status");
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
                                  throw new Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.UndeclaredResponseException(_response);
                              }
                          }

                        // check for terminal status code
                        if (_response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                        {
                            continue;
                        }
                        // we are done polling, do a request on final target?
                        // create a new request with the final uri
                        request = request.CloneAndDispose(new global::System.Uri(_finalUri), Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get);

                        // drop the old response
                        _response?.Dispose();

                        // make the final call
                        _response = await sender.SendAsync(request,  eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                        break;
                    }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.CloudHsmCluster.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="CloudHsmClustersUpdate" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="cloudHsmClusterName">The name of the Cloud HSM Cluster within the specified resource group. Cloud HSM Cluster
        /// names must be between 3 and 23 characters in length.</param>
        /// <param name="body">Parameters to create Cloud HSM Cluster</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task CloudHsmClustersUpdate_Validate(string subscriptionId, string resourceGroupName, string cloudHsmClusterName, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ICloudHsmClusterPatchParameters body, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(subscriptionId),subscriptionId);
                await eventListener.AssertMinimumLength(nameof(subscriptionId),subscriptionId,1);
                await eventListener.AssertNotNull(nameof(resourceGroupName),resourceGroupName);
                await eventListener.AssertMinimumLength(nameof(resourceGroupName),resourceGroupName,1);
                await eventListener.AssertMaximumLength(nameof(resourceGroupName),resourceGroupName,90);
                await eventListener.AssertRegEx(nameof(resourceGroupName), resourceGroupName, @"^[-\w\._\(\)]+$");
                await eventListener.AssertNotNull(nameof(cloudHsmClusterName),cloudHsmClusterName);
                await eventListener.AssertMinimumLength(nameof(cloudHsmClusterName),cloudHsmClusterName,3);
                await eventListener.AssertMaximumLength(nameof(cloudHsmClusterName),cloudHsmClusterName,23);
                await eventListener.AssertRegEx(nameof(cloudHsmClusterName), cloudHsmClusterName, @"^[a-zA-Z0-9-]{3,23}$");
                await eventListener.AssertNotNull(nameof(body), body);
                await eventListener.AssertObjectIsValid(nameof(body), body);
            }
        }

        /// <summary>
        /// Pre Backup operation to validate whether the customer can perform a backup on the Cloud HSM Cluster resource in the specified
        /// subscription.
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="cloudHsmClusterName">The name of the Cloud HSM Cluster within the specified resource group. Cloud HSM Cluster
        /// names must be between 3 and 23 characters in length.</param>
        /// <param name="body">Backup Operation Required properties</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task CloudHsmClustersValidateBackupProperties(string subscriptionId, string resourceGroupName, string cloudHsmClusterName, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupRequestProperties body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/"
                        + global::System.Uri.EscapeDataString(cloudHsmClusterName)
                        + "/validateBackupProperties"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.CloudHsmClustersValidateBackupProperties_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>
        /// Pre Backup operation to validate whether the customer can perform a backup on the Cloud HSM Cluster resource in the specified
        /// subscription.
        /// </summary>
        /// <param name="viaIdentity"></param>
        /// <param name="body">Backup Operation Required properties</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task CloudHsmClustersValidateBackupPropertiesViaIdentity(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupRequestProperties body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/(?<cloudHsmClusterName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/{cloudHsmClusterName}'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var cloudHsmClusterName = _match.Groups["cloudHsmClusterName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/"
                        + cloudHsmClusterName
                        + "/validateBackupProperties"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.CloudHsmClustersValidateBackupProperties_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>
        /// Pre Backup operation to validate whether the customer can perform a backup on the Cloud HSM Cluster resource in the specified
        /// subscription.
        /// </summary>
        /// <param name="viaIdentity"></param>
        /// <param name="body">Backup Operation Required properties</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupResult>" /> that
        /// will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupResult> CloudHsmClustersValidateBackupPropertiesViaIdentityWithResult(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupRequestProperties body, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/(?<cloudHsmClusterName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/{cloudHsmClusterName}'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var cloudHsmClusterName = _match.Groups["cloudHsmClusterName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/"
                        + cloudHsmClusterName
                        + "/validateBackupProperties"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.CloudHsmClustersValidateBackupPropertiesWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>
        /// Pre Backup operation to validate whether the customer can perform a backup on the Cloud HSM Cluster resource in the specified
        /// subscription.
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="cloudHsmClusterName">The name of the Cloud HSM Cluster within the specified resource group. Cloud HSM Cluster
        /// names must be between 3 and 23 characters in length.</param>
        /// <param name="jsonString">Json string supplied to the CloudHsmClustersValidateBackupProperties operation</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task CloudHsmClustersValidateBackupPropertiesViaJsonString(string subscriptionId, string resourceGroupName, string cloudHsmClusterName, global::System.String jsonString, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/"
                        + global::System.Uri.EscapeDataString(cloudHsmClusterName)
                        + "/validateBackupProperties"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(jsonString, global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.CloudHsmClustersValidateBackupProperties_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>
        /// Pre Backup operation to validate whether the customer can perform a backup on the Cloud HSM Cluster resource in the specified
        /// subscription.
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="cloudHsmClusterName">The name of the Cloud HSM Cluster within the specified resource group. Cloud HSM Cluster
        /// names must be between 3 and 23 characters in length.</param>
        /// <param name="jsonString">Json string supplied to the CloudHsmClustersValidateBackupProperties operation</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupResult>" /> that
        /// will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupResult> CloudHsmClustersValidateBackupPropertiesViaJsonStringWithResult(string subscriptionId, string resourceGroupName, string cloudHsmClusterName, global::System.String jsonString, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/"
                        + global::System.Uri.EscapeDataString(cloudHsmClusterName)
                        + "/validateBackupProperties"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(jsonString, global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.CloudHsmClustersValidateBackupPropertiesWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>
        /// Pre Backup operation to validate whether the customer can perform a backup on the Cloud HSM Cluster resource in the specified
        /// subscription.
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="cloudHsmClusterName">The name of the Cloud HSM Cluster within the specified resource group. Cloud HSM Cluster
        /// names must be between 3 and 23 characters in length.</param>
        /// <param name="body">Backup Operation Required properties</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupResult>" /> that
        /// will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupResult> CloudHsmClustersValidateBackupPropertiesWithResult(string subscriptionId, string resourceGroupName, string cloudHsmClusterName, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupRequestProperties body, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/"
                        + global::System.Uri.EscapeDataString(cloudHsmClusterName)
                        + "/validateBackupProperties"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.CloudHsmClustersValidateBackupPropertiesWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>
        /// Actual wire call for <see cref= "CloudHsmClustersValidateBackupPropertiesWithResult" /> method.
        /// </summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupResult>" /> that
        /// will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupResult> CloudHsmClustersValidateBackupPropertiesWithResult_Call(global::System.Net.Http.HttpRequestMessage request, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    // this operation supports x-ms-long-running-operation
                    var _originalUri = request.RequestUri.AbsoluteUri;
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Progress, "intentional placeholder", 0); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    // declared final-state-via: azure-async-operation
                    var _finalUri = _response.GetFirstHeader(@"Azure-AsyncOperation");
                    var asyncOperation = _response.GetFirstHeader(@"Azure-AsyncOperation");
                    var location = _response.GetFirstHeader(@"Location");
                    var operationLocation = _response.GetFirstHeader(@"Operation-Location");
                    while (request.Method == System.Net.Http.HttpMethod.Put && _response.StatusCode == global::System.Net.HttpStatusCode.OK || _response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                    {
                        // delay before making the next polling request
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.DelayBeforePolling, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }

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
                        request = request.CloneAndDispose(new global::System.Uri(_uri), Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get);

                        // and let's look at the current response body and see if we have some information we can give back to the listener
                        var content = await _response.Content.ReadAsStringAsync();

                        // drop the old response
                        _response?.Dispose();

                        // make the polling call
                        _response = await sender.SendAsync(request, eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }

                          // if we got back an OK, take a peek inside and see if it's done
                          if( _response.StatusCode == global::System.Net.HttpStatusCode.OK)
                          {
                              var error = false;
                              try {
                                  if( Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(await _response.Content.ReadAsStringAsync()) is Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonObject json)
                                  {
                                      var state = json.Property("properties")?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonString>("provisioningState") ?? json.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonString>("status");
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
                                  throw new Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.UndeclaredResponseException(_response);
                              }
                          }

                        // check for terminal status code
                        if (_response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                        {
                            continue;
                        }
                        // we are done polling, do a request on final target?
                        // create a new request with the final uri
                        request = request.CloneAndDispose(new global::System.Uri(_finalUri), Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get);

                        // drop the old response
                        _response?.Dispose();

                        // make the final call
                        _response = await sender.SendAsync(request,  eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                        break;
                    }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.BackupResult.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) .ReadHeaders(_response.Headers));
                            return await _result;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) );
                            // Error Response : default
                            var code = (await _result)?.Code;
                            var message = (await _result)?.Message;
                            if ((null == code || null == message))
                            {
                                // Unrecognized Response. Create an error record based on what we have.
                                var ex = new Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>(_response, await _result);
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
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Actual wire call for <see cref= "CloudHsmClustersValidateBackupProperties" /> method.
        /// </summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task CloudHsmClustersValidateBackupProperties_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    // this operation supports x-ms-long-running-operation
                    var _originalUri = request.RequestUri.AbsoluteUri;
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Progress, "intentional placeholder", 0); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    // declared final-state-via: azure-async-operation
                    var _finalUri = _response.GetFirstHeader(@"Azure-AsyncOperation");
                    var asyncOperation = _response.GetFirstHeader(@"Azure-AsyncOperation");
                    var location = _response.GetFirstHeader(@"Location");
                    var operationLocation = _response.GetFirstHeader(@"Operation-Location");
                    while (request.Method == System.Net.Http.HttpMethod.Put && _response.StatusCode == global::System.Net.HttpStatusCode.OK || _response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                    {
                        // delay before making the next polling request
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.DelayBeforePolling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }

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
                        request = request.CloneAndDispose(new global::System.Uri(_uri), Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get);

                        // and let's look at the current response body and see if we have some information we can give back to the listener
                        var content = await _response.Content.ReadAsStringAsync();

                        // drop the old response
                        _response?.Dispose();

                        // make the polling call
                        _response = await sender.SendAsync(request, eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }

                          // if we got back an OK, take a peek inside and see if it's done
                          if( _response.StatusCode == global::System.Net.HttpStatusCode.OK)
                          {
                              var error = false;
                              try {
                                  if( Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(await _response.Content.ReadAsStringAsync()) is Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonObject json)
                                  {
                                      var state = json.Property("properties")?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonString>("provisioningState") ?? json.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonString>("status");
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
                                  throw new Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.UndeclaredResponseException(_response);
                              }
                          }

                        // check for terminal status code
                        if (_response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                        {
                            continue;
                        }
                        // we are done polling, do a request on final target?
                        // create a new request with the final uri
                        request = request.CloneAndDispose(new global::System.Uri(_finalUri), Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get);

                        // drop the old response
                        _response?.Dispose();

                        // make the final call
                        _response = await sender.SendAsync(request,  eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                        break;
                    }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.BackupResult.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) .ReadHeaders(_response.Headers)));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="CloudHsmClustersValidateBackupProperties" /> method. Call this like the actual call,
        /// but you will get validation events back.
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="cloudHsmClusterName">The name of the Cloud HSM Cluster within the specified resource group. Cloud HSM Cluster
        /// names must be between 3 and 23 characters in length.</param>
        /// <param name="body">Backup Operation Required properties</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task CloudHsmClustersValidateBackupProperties_Validate(string subscriptionId, string resourceGroupName, string cloudHsmClusterName, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupRequestProperties body, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(subscriptionId),subscriptionId);
                await eventListener.AssertMinimumLength(nameof(subscriptionId),subscriptionId,1);
                await eventListener.AssertNotNull(nameof(resourceGroupName),resourceGroupName);
                await eventListener.AssertMinimumLength(nameof(resourceGroupName),resourceGroupName,1);
                await eventListener.AssertMaximumLength(nameof(resourceGroupName),resourceGroupName,90);
                await eventListener.AssertRegEx(nameof(resourceGroupName), resourceGroupName, @"^[-\w\._\(\)]+$");
                await eventListener.AssertNotNull(nameof(cloudHsmClusterName),cloudHsmClusterName);
                await eventListener.AssertMinimumLength(nameof(cloudHsmClusterName),cloudHsmClusterName,3);
                await eventListener.AssertMaximumLength(nameof(cloudHsmClusterName),cloudHsmClusterName,23);
                await eventListener.AssertRegEx(nameof(cloudHsmClusterName), cloudHsmClusterName, @"^[a-zA-Z0-9-]{3,23}$");
                await eventListener.AssertNotNull(nameof(body), body);
                await eventListener.AssertObjectIsValid(nameof(body), body);
            }
        }

        /// <summary>Queued validating pre restore operation</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="cloudHsmClusterName">The name of the Cloud HSM Cluster within the specified resource group. Cloud HSM Cluster
        /// names must be between 3 and 23 characters in length.</param>
        /// <param name="body">Optional Parameters to validate prior performing a restore operation.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task CloudHsmClustersValidateRestoreProperties(string subscriptionId, string resourceGroupName, string cloudHsmClusterName, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IRestoreRequestProperties body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IRestoreResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/"
                        + global::System.Uri.EscapeDataString(cloudHsmClusterName)
                        + "/validateRestoreProperties"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.CloudHsmClustersValidateRestoreProperties_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>Queued validating pre restore operation</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="body">Optional Parameters to validate prior performing a restore operation.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task CloudHsmClustersValidateRestorePropertiesViaIdentity(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IRestoreRequestProperties body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IRestoreResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/(?<cloudHsmClusterName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/{cloudHsmClusterName}'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var cloudHsmClusterName = _match.Groups["cloudHsmClusterName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/"
                        + cloudHsmClusterName
                        + "/validateRestoreProperties"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.CloudHsmClustersValidateRestoreProperties_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>Queued validating pre restore operation</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="body">Optional Parameters to validate prior performing a restore operation.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IRestoreResult>" /> that
        /// will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IRestoreResult> CloudHsmClustersValidateRestorePropertiesViaIdentityWithResult(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IRestoreRequestProperties body, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/(?<cloudHsmClusterName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/{cloudHsmClusterName}'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var cloudHsmClusterName = _match.Groups["cloudHsmClusterName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/"
                        + cloudHsmClusterName
                        + "/validateRestoreProperties"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.CloudHsmClustersValidateRestorePropertiesWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>Queued validating pre restore operation</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="cloudHsmClusterName">The name of the Cloud HSM Cluster within the specified resource group. Cloud HSM Cluster
        /// names must be between 3 and 23 characters in length.</param>
        /// <param name="jsonString">Json string supplied to the CloudHsmClustersValidateRestoreProperties operation</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task CloudHsmClustersValidateRestorePropertiesViaJsonString(string subscriptionId, string resourceGroupName, string cloudHsmClusterName, global::System.String jsonString, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IRestoreResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/"
                        + global::System.Uri.EscapeDataString(cloudHsmClusterName)
                        + "/validateRestoreProperties"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(jsonString, global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.CloudHsmClustersValidateRestoreProperties_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>Queued validating pre restore operation</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="cloudHsmClusterName">The name of the Cloud HSM Cluster within the specified resource group. Cloud HSM Cluster
        /// names must be between 3 and 23 characters in length.</param>
        /// <param name="jsonString">Json string supplied to the CloudHsmClustersValidateRestoreProperties operation</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IRestoreResult>" /> that
        /// will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IRestoreResult> CloudHsmClustersValidateRestorePropertiesViaJsonStringWithResult(string subscriptionId, string resourceGroupName, string cloudHsmClusterName, global::System.String jsonString, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/"
                        + global::System.Uri.EscapeDataString(cloudHsmClusterName)
                        + "/validateRestoreProperties"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(jsonString, global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.CloudHsmClustersValidateRestorePropertiesWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>Queued validating pre restore operation</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="cloudHsmClusterName">The name of the Cloud HSM Cluster within the specified resource group. Cloud HSM Cluster
        /// names must be between 3 and 23 characters in length.</param>
        /// <param name="body">Optional Parameters to validate prior performing a restore operation.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IRestoreResult>" /> that
        /// will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IRestoreResult> CloudHsmClustersValidateRestorePropertiesWithResult(string subscriptionId, string resourceGroupName, string cloudHsmClusterName, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IRestoreRequestProperties body, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/"
                        + global::System.Uri.EscapeDataString(cloudHsmClusterName)
                        + "/validateRestoreProperties"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.CloudHsmClustersValidateRestorePropertiesWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>
        /// Actual wire call for <see cref= "CloudHsmClustersValidateRestorePropertiesWithResult" /> method.
        /// </summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IRestoreResult>" /> that
        /// will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IRestoreResult> CloudHsmClustersValidateRestorePropertiesWithResult_Call(global::System.Net.Http.HttpRequestMessage request, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    // this operation supports x-ms-long-running-operation
                    var _originalUri = request.RequestUri.AbsoluteUri;
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Progress, "intentional placeholder", 0); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    // declared final-state-via: azure-async-operation
                    var _finalUri = _response.GetFirstHeader(@"Azure-AsyncOperation");
                    var asyncOperation = _response.GetFirstHeader(@"Azure-AsyncOperation");
                    var location = _response.GetFirstHeader(@"Location");
                    var operationLocation = _response.GetFirstHeader(@"Operation-Location");
                    while (request.Method == System.Net.Http.HttpMethod.Put && _response.StatusCode == global::System.Net.HttpStatusCode.OK || _response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                    {
                        // delay before making the next polling request
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.DelayBeforePolling, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }

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
                        request = request.CloneAndDispose(new global::System.Uri(_uri), Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get);

                        // and let's look at the current response body and see if we have some information we can give back to the listener
                        var content = await _response.Content.ReadAsStringAsync();

                        // drop the old response
                        _response?.Dispose();

                        // make the polling call
                        _response = await sender.SendAsync(request, eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }

                          // if we got back an OK, take a peek inside and see if it's done
                          if( _response.StatusCode == global::System.Net.HttpStatusCode.OK)
                          {
                              var error = false;
                              try {
                                  if( Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(await _response.Content.ReadAsStringAsync()) is Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonObject json)
                                  {
                                      var state = json.Property("properties")?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonString>("provisioningState") ?? json.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonString>("status");
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
                                  throw new Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.UndeclaredResponseException(_response);
                              }
                          }

                        // check for terminal status code
                        if (_response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                        {
                            continue;
                        }
                        // we are done polling, do a request on final target?
                        // create a new request with the final uri
                        request = request.CloneAndDispose(new global::System.Uri(_finalUri), Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get);

                        // drop the old response
                        _response?.Dispose();

                        // make the final call
                        _response = await sender.SendAsync(request,  eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                        break;
                    }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.RestoreResult.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) .ReadHeaders(_response.Headers));
                            return await _result;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) );
                            // Error Response : default
                            var code = (await _result)?.Code;
                            var message = (await _result)?.Message;
                            if ((null == code || null == message))
                            {
                                // Unrecognized Response. Create an error record based on what we have.
                                var ex = new Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>(_response, await _result);
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
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Actual wire call for <see cref= "CloudHsmClustersValidateRestoreProperties" /> method.
        /// </summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task CloudHsmClustersValidateRestoreProperties_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IRestoreResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    // this operation supports x-ms-long-running-operation
                    var _originalUri = request.RequestUri.AbsoluteUri;
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Progress, "intentional placeholder", 0); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    // declared final-state-via: azure-async-operation
                    var _finalUri = _response.GetFirstHeader(@"Azure-AsyncOperation");
                    var asyncOperation = _response.GetFirstHeader(@"Azure-AsyncOperation");
                    var location = _response.GetFirstHeader(@"Location");
                    var operationLocation = _response.GetFirstHeader(@"Operation-Location");
                    while (request.Method == System.Net.Http.HttpMethod.Put && _response.StatusCode == global::System.Net.HttpStatusCode.OK || _response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                    {
                        // delay before making the next polling request
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.DelayBeforePolling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }

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
                        request = request.CloneAndDispose(new global::System.Uri(_uri), Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get);

                        // and let's look at the current response body and see if we have some information we can give back to the listener
                        var content = await _response.Content.ReadAsStringAsync();

                        // drop the old response
                        _response?.Dispose();

                        // make the polling call
                        _response = await sender.SendAsync(request, eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }

                          // if we got back an OK, take a peek inside and see if it's done
                          if( _response.StatusCode == global::System.Net.HttpStatusCode.OK)
                          {
                              var error = false;
                              try {
                                  if( Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(await _response.Content.ReadAsStringAsync()) is Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonObject json)
                                  {
                                      var state = json.Property("properties")?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonString>("provisioningState") ?? json.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonString>("status");
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
                                  throw new Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.UndeclaredResponseException(_response);
                              }
                          }

                        // check for terminal status code
                        if (_response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                        {
                            continue;
                        }
                        // we are done polling, do a request on final target?
                        // create a new request with the final uri
                        request = request.CloneAndDispose(new global::System.Uri(_finalUri), Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get);

                        // drop the old response
                        _response?.Dispose();

                        // make the final call
                        _response = await sender.SendAsync(request,  eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                        break;
                    }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.RestoreResult.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) .ReadHeaders(_response.Headers)));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="CloudHsmClustersValidateRestoreProperties" /> method. Call this like the actual call,
        /// but you will get validation events back.
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="cloudHsmClusterName">The name of the Cloud HSM Cluster within the specified resource group. Cloud HSM Cluster
        /// names must be between 3 and 23 characters in length.</param>
        /// <param name="body">Optional Parameters to validate prior performing a restore operation.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task CloudHsmClustersValidateRestoreProperties_Validate(string subscriptionId, string resourceGroupName, string cloudHsmClusterName, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IRestoreRequestProperties body, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(subscriptionId),subscriptionId);
                await eventListener.AssertMinimumLength(nameof(subscriptionId),subscriptionId,1);
                await eventListener.AssertNotNull(nameof(resourceGroupName),resourceGroupName);
                await eventListener.AssertMinimumLength(nameof(resourceGroupName),resourceGroupName,1);
                await eventListener.AssertMaximumLength(nameof(resourceGroupName),resourceGroupName,90);
                await eventListener.AssertRegEx(nameof(resourceGroupName), resourceGroupName, @"^[-\w\._\(\)]+$");
                await eventListener.AssertNotNull(nameof(cloudHsmClusterName),cloudHsmClusterName);
                await eventListener.AssertMinimumLength(nameof(cloudHsmClusterName),cloudHsmClusterName,3);
                await eventListener.AssertMaximumLength(nameof(cloudHsmClusterName),cloudHsmClusterName,23);
                await eventListener.AssertRegEx(nameof(cloudHsmClusterName), cloudHsmClusterName, @"^[a-zA-Z0-9-]{3,23}$");
                await eventListener.AssertNotNull(nameof(body), body);
                await eventListener.AssertObjectIsValid(nameof(body), body);
            }
        }

        /// <summary>update a dedicated HSM in the specified subscription.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="name">Name of the dedicated Hsm</param>
        /// <param name="body">Parameters to create or update the dedicated hsm</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DedicatedHsmCreateOrUpdate(string subscriptionId, string resourceGroupName, string name, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsm body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsm>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmError>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.HardwareSecurityModules/dedicatedHSMs/"
                        + global::System.Uri.EscapeDataString(name)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Put, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DedicatedHsmCreateOrUpdate_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>update a dedicated HSM in the specified subscription.</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="body">Parameters to create or update the dedicated hsm</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DedicatedHsmCreateOrUpdateViaIdentity(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsm body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsm>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmError>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.HardwareSecurityModules/dedicatedHSMs/(?<name>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HardwareSecurityModules/dedicatedHSMs/{name}'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var name = _match.Groups["name"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.HardwareSecurityModules/dedicatedHSMs/"
                        + name
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Put, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DedicatedHsmCreateOrUpdate_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>update a dedicated HSM in the specified subscription.</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="body">Parameters to create or update the dedicated hsm</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsm>" /> that
        /// will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsm> DedicatedHsmCreateOrUpdateViaIdentityWithResult(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsm body, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.HardwareSecurityModules/dedicatedHSMs/(?<name>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HardwareSecurityModules/dedicatedHSMs/{name}'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var name = _match.Groups["name"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.HardwareSecurityModules/dedicatedHSMs/"
                        + name
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Put, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.DedicatedHsmCreateOrUpdateWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>update a dedicated HSM in the specified subscription.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="name">Name of the dedicated Hsm</param>
        /// <param name="jsonString">Json string supplied to the DedicatedHsmCreateOrUpdate operation</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DedicatedHsmCreateOrUpdateViaJsonString(string subscriptionId, string resourceGroupName, string name, global::System.String jsonString, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsm>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmError>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.HardwareSecurityModules/dedicatedHSMs/"
                        + global::System.Uri.EscapeDataString(name)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Put, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(jsonString, global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DedicatedHsmCreateOrUpdate_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>update a dedicated HSM in the specified subscription.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="name">Name of the dedicated Hsm</param>
        /// <param name="jsonString">Json string supplied to the DedicatedHsmCreateOrUpdate operation</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsm>" /> that
        /// will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsm> DedicatedHsmCreateOrUpdateViaJsonStringWithResult(string subscriptionId, string resourceGroupName, string name, global::System.String jsonString, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.HardwareSecurityModules/dedicatedHSMs/"
                        + global::System.Uri.EscapeDataString(name)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Put, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(jsonString, global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.DedicatedHsmCreateOrUpdateWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>update a dedicated HSM in the specified subscription.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="name">Name of the dedicated Hsm</param>
        /// <param name="body">Parameters to create or update the dedicated hsm</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsm>" /> that
        /// will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsm> DedicatedHsmCreateOrUpdateWithResult(string subscriptionId, string resourceGroupName, string name, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsm body, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.HardwareSecurityModules/dedicatedHSMs/"
                        + global::System.Uri.EscapeDataString(name)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Put, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.DedicatedHsmCreateOrUpdateWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>
        /// Actual wire call for <see cref= "DedicatedHsmCreateOrUpdateWithResult" /> method.
        /// </summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsm>" /> that
        /// will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsm> DedicatedHsmCreateOrUpdateWithResult_Call(global::System.Net.Http.HttpRequestMessage request, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    // this operation supports x-ms-long-running-operation
                    var _originalUri = request.RequestUri.AbsoluteUri;
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Progress, "intentional placeholder", 0); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    // declared final-state-via: azure-async-operation
                    var asyncOperation = _response.GetFirstHeader(@"Azure-AsyncOperation");
                    var location = _response.GetFirstHeader(@"Location");
                    var operationLocation = _response.GetFirstHeader(@"Operation-Location");
                    while (request.Method == System.Net.Http.HttpMethod.Put && _response.StatusCode == global::System.Net.HttpStatusCode.OK || _response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                    {
                        // delay before making the next polling request
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.DelayBeforePolling, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }

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
                        request = request.CloneAndDispose(new global::System.Uri(_uri), Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get);

                        // and let's look at the current response body and see if we have some information we can give back to the listener
                        var content = await _response.Content.ReadAsStringAsync();

                        // drop the old response
                        _response?.Dispose();

                        // make the polling call
                        _response = await sender.SendAsync(request, eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }

                          // if we got back an OK, take a peek inside and see if it's done
                          if( _response.StatusCode == global::System.Net.HttpStatusCode.OK)
                          {
                              var error = false;
                              try {
                                  if( Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(await _response.Content.ReadAsStringAsync()) is Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonObject json)
                                  {
                                      var state = json.Property("properties")?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonString>("provisioningState") ?? json.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonString>("status");
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
                                  throw new Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.UndeclaredResponseException(_response);
                              }
                          }

                        // check for terminal status code
                        if (_response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                        {
                            continue;
                        }
                        // we are done polling, do a request on final target?
                        // create a new request with the final uri
                        request = request.CloneAndDispose(new global::System.Uri(_originalUri), Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get);

                        // drop the old response
                        _response?.Dispose();

                        // make the final call
                        _response = await sender.SendAsync(request,  eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                        break;
                    }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.DedicatedHsm.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) );
                            return await _result;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.DedicatedHsmError.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) );
                            // Error Response : default
                            var code = (await _result)?.Error?.Code;
                            var message = (await _result)?.Error?.Message;
                            if ((null == code || null == message))
                            {
                                // Unrecognized Response. Create an error record based on what we have.
                                var ex = new Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmError>(_response, await _result);
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
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>Actual wire call for <see cref= "DedicatedHsmCreateOrUpdate" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DedicatedHsmCreateOrUpdate_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsm>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmError>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    // this operation supports x-ms-long-running-operation
                    var _originalUri = request.RequestUri.AbsoluteUri;
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Progress, "intentional placeholder", 0); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    // declared final-state-via: azure-async-operation
                    var asyncOperation = _response.GetFirstHeader(@"Azure-AsyncOperation");
                    var location = _response.GetFirstHeader(@"Location");
                    var operationLocation = _response.GetFirstHeader(@"Operation-Location");
                    while (request.Method == System.Net.Http.HttpMethod.Put && _response.StatusCode == global::System.Net.HttpStatusCode.OK || _response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                    {
                        // delay before making the next polling request
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.DelayBeforePolling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }

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
                        request = request.CloneAndDispose(new global::System.Uri(_uri), Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get);

                        // and let's look at the current response body and see if we have some information we can give back to the listener
                        var content = await _response.Content.ReadAsStringAsync();

                        // drop the old response
                        _response?.Dispose();

                        // make the polling call
                        _response = await sender.SendAsync(request, eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }

                          // if we got back an OK, take a peek inside and see if it's done
                          if( _response.StatusCode == global::System.Net.HttpStatusCode.OK)
                          {
                              var error = false;
                              try {
                                  if( Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(await _response.Content.ReadAsStringAsync()) is Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonObject json)
                                  {
                                      var state = json.Property("properties")?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonString>("provisioningState") ?? json.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonString>("status");
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
                                  throw new Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.UndeclaredResponseException(_response);
                              }
                          }

                        // check for terminal status code
                        if (_response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                        {
                            continue;
                        }
                        // we are done polling, do a request on final target?
                        // create a new request with the final uri
                        request = request.CloneAndDispose(new global::System.Uri(_originalUri), Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get);

                        // drop the old response
                        _response?.Dispose();

                        // make the final call
                        _response = await sender.SendAsync(request,  eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                        break;
                    }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.DedicatedHsm.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.DedicatedHsmError.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="DedicatedHsmCreateOrUpdate" /> method. Call this like the actual call, but you will get
        /// validation events back.
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="name">Name of the dedicated Hsm</param>
        /// <param name="body">Parameters to create or update the dedicated hsm</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DedicatedHsmCreateOrUpdate_Validate(string subscriptionId, string resourceGroupName, string name, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsm body, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(subscriptionId),subscriptionId);
                await eventListener.AssertMinimumLength(nameof(subscriptionId),subscriptionId,1);
                await eventListener.AssertNotNull(nameof(resourceGroupName),resourceGroupName);
                await eventListener.AssertMinimumLength(nameof(resourceGroupName),resourceGroupName,1);
                await eventListener.AssertMaximumLength(nameof(resourceGroupName),resourceGroupName,90);
                await eventListener.AssertRegEx(nameof(resourceGroupName), resourceGroupName, @"^[-\w\._\(\)]+$");
                await eventListener.AssertNotNull(nameof(name),name);
                await eventListener.AssertRegEx(nameof(name), name, @"^[a-zA-Z0-9-]{3,24}$");
                await eventListener.AssertNotNull(nameof(body), body);
                await eventListener.AssertObjectIsValid(nameof(body), body);
            }
        }

        /// <summary>Deletes the specified Azure Dedicated HSM.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="name">Name of the dedicated Hsm</param>
        /// <param name="onNoContent">a delegate that is called when the remote service returns 204 (NoContent).</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DedicatedHsmDelete(string subscriptionId, string resourceGroupName, string name, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onNoContent, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmError>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.HardwareSecurityModules/dedicatedHSMs/"
                        + global::System.Uri.EscapeDataString(name)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Delete, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DedicatedHsmDelete_Call (request, onNoContent,onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>Deletes the specified Azure Dedicated HSM.</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="onNoContent">a delegate that is called when the remote service returns 204 (NoContent).</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DedicatedHsmDeleteViaIdentity(global::System.String viaIdentity, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onNoContent, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmError>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.HardwareSecurityModules/dedicatedHSMs/(?<name>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HardwareSecurityModules/dedicatedHSMs/{name}'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var name = _match.Groups["name"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.HardwareSecurityModules/dedicatedHSMs/"
                        + name
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Delete, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DedicatedHsmDelete_Call (request, onNoContent,onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref= "DedicatedHsmDelete" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onNoContent">a delegate that is called when the remote service returns 204 (NoContent).</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DedicatedHsmDelete_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onNoContent, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmError>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    // this operation supports x-ms-long-running-operation
                    var _originalUri = request.RequestUri.AbsoluteUri;
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Progress, "intentional placeholder", 0); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    // declared final-state-via: location
                    var _finalUri = _response.GetFirstHeader(@"Location");
                    var asyncOperation = _response.GetFirstHeader(@"Azure-AsyncOperation");
                    var location = _response.GetFirstHeader(@"Location");
                    var operationLocation = _response.GetFirstHeader(@"Operation-Location");
                    while (request.Method == System.Net.Http.HttpMethod.Put && _response.StatusCode == global::System.Net.HttpStatusCode.OK || _response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                    {
                        // delay before making the next polling request
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.DelayBeforePolling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }

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
                        request = request.CloneAndDispose(new global::System.Uri(_uri), Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get);

                        // and let's look at the current response body and see if we have some information we can give back to the listener
                        var content = await _response.Content.ReadAsStringAsync();

                        // drop the old response
                        _response?.Dispose();

                        // make the polling call
                        _response = await sender.SendAsync(request, eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }

                          // if we got back an OK, take a peek inside and see if it's done
                          if( _response.StatusCode == global::System.Net.HttpStatusCode.OK)
                          {
                              var error = false;
                              try {
                                  if( Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(await _response.Content.ReadAsStringAsync()) is Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonObject json)
                                  {
                                      var state = json.Property("properties")?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonString>("provisioningState") ?? json.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonString>("status");
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
                                  throw new Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.UndeclaredResponseException(_response);
                              }
                          }

                        // check for terminal status code
                        if (_response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                        {
                            continue;
                        }
                        // we are done polling, do a request on final target?
                        // create a new request with the final uri
                        request = request.CloneAndDispose(new global::System.Uri(_finalUri), Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get);

                        // drop the old response
                        _response?.Dispose();

                        // make the final call
                        _response = await sender.SendAsync(request,  eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                        break;
                    }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response);
                            break;
                        }
                        case global::System.Net.HttpStatusCode.NoContent:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onNoContent(_response);
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.DedicatedHsmError.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="DedicatedHsmDelete" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="name">Name of the dedicated Hsm</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DedicatedHsmDelete_Validate(string subscriptionId, string resourceGroupName, string name, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(subscriptionId),subscriptionId);
                await eventListener.AssertMinimumLength(nameof(subscriptionId),subscriptionId,1);
                await eventListener.AssertNotNull(nameof(resourceGroupName),resourceGroupName);
                await eventListener.AssertMinimumLength(nameof(resourceGroupName),resourceGroupName,1);
                await eventListener.AssertMaximumLength(nameof(resourceGroupName),resourceGroupName,90);
                await eventListener.AssertRegEx(nameof(resourceGroupName), resourceGroupName, @"^[-\w\._\(\)]+$");
                await eventListener.AssertNotNull(nameof(name),name);
                await eventListener.AssertRegEx(nameof(name), name, @"^[a-zA-Z0-9-]{3,24}$");
            }
        }

        /// <summary>Gets the specified Azure dedicated HSM.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="name">Name of the dedicated Hsm</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DedicatedHsmGet(string subscriptionId, string resourceGroupName, string name, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsm>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmError>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.HardwareSecurityModules/dedicatedHSMs/"
                        + global::System.Uri.EscapeDataString(name)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DedicatedHsmGet_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>Gets the specified Azure dedicated HSM.</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DedicatedHsmGetViaIdentity(global::System.String viaIdentity, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsm>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmError>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.HardwareSecurityModules/dedicatedHSMs/(?<name>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HardwareSecurityModules/dedicatedHSMs/{name}'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var name = _match.Groups["name"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.HardwareSecurityModules/dedicatedHSMs/"
                        + name
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DedicatedHsmGet_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>Gets the specified Azure dedicated HSM.</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsm>" /> that
        /// will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsm> DedicatedHsmGetViaIdentityWithResult(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.HardwareSecurityModules/dedicatedHSMs/(?<name>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HardwareSecurityModules/dedicatedHSMs/{name}'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var name = _match.Groups["name"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.HardwareSecurityModules/dedicatedHSMs/"
                        + name
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.DedicatedHsmGetWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>Gets the specified Azure dedicated HSM.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="name">Name of the dedicated Hsm</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsm>" /> that
        /// will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsm> DedicatedHsmGetWithResult(string subscriptionId, string resourceGroupName, string name, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.HardwareSecurityModules/dedicatedHSMs/"
                        + global::System.Uri.EscapeDataString(name)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.DedicatedHsmGetWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref= "DedicatedHsmGetWithResult" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsm>" /> that
        /// will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsm> DedicatedHsmGetWithResult_Call(global::System.Net.Http.HttpRequestMessage request, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.DedicatedHsm.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) );
                            return await _result;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.DedicatedHsmError.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) );
                            // Error Response : default
                            var code = (await _result)?.Error?.Code;
                            var message = (await _result)?.Error?.Message;
                            if ((null == code || null == message))
                            {
                                // Unrecognized Response. Create an error record based on what we have.
                                var ex = new Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmError>(_response, await _result);
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
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>Actual wire call for <see cref= "DedicatedHsmGet" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DedicatedHsmGet_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsm>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmError>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.DedicatedHsm.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.DedicatedHsmError.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="DedicatedHsmGet" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="name">Name of the dedicated Hsm</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DedicatedHsmGet_Validate(string subscriptionId, string resourceGroupName, string name, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(subscriptionId),subscriptionId);
                await eventListener.AssertMinimumLength(nameof(subscriptionId),subscriptionId,1);
                await eventListener.AssertNotNull(nameof(resourceGroupName),resourceGroupName);
                await eventListener.AssertMinimumLength(nameof(resourceGroupName),resourceGroupName,1);
                await eventListener.AssertMaximumLength(nameof(resourceGroupName),resourceGroupName,90);
                await eventListener.AssertRegEx(nameof(resourceGroupName), resourceGroupName, @"^[-\w\._\(\)]+$");
                await eventListener.AssertNotNull(nameof(name),name);
                await eventListener.AssertRegEx(nameof(name), name, @"^[a-zA-Z0-9-]{3,24}$");
            }
        }

        /// <summary>
        /// The List operation gets information about the dedicated HSMs associated with the subscription and within the specified
        /// resource group.
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="Top">Maximum number of results to return.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DedicatedHsmListByResourceGroup(string subscriptionId, string resourceGroupName, int? Top, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmListResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmError>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.HardwareSecurityModules/dedicatedHSMs"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        + "&"
                        + (null == Top ? global::System.String.Empty : "$top=" + global::System.Uri.EscapeDataString(Top.ToString()))
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DedicatedHsmListByResourceGroup_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>
        /// The List operation gets information about the dedicated HSMs associated with the subscription and within the specified
        /// resource group.
        /// </summary>
        /// <param name="viaIdentity"></param>
        /// <param name="Top">Maximum number of results to return.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DedicatedHsmListByResourceGroupViaIdentity(global::System.String viaIdentity, int? Top, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmListResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmError>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.HardwareSecurityModules/dedicatedHSMs$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HardwareSecurityModules/dedicatedHSMs'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.HardwareSecurityModules/dedicatedHSMs"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        + "&"
                        + (null == Top ? global::System.String.Empty : "$top=" + global::System.Uri.EscapeDataString(Top.ToString()))
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DedicatedHsmListByResourceGroup_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>
        /// The List operation gets information about the dedicated HSMs associated with the subscription and within the specified
        /// resource group.
        /// </summary>
        /// <param name="viaIdentity"></param>
        /// <param name="Top">Maximum number of results to return.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmListResult>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmListResult> DedicatedHsmListByResourceGroupViaIdentityWithResult(global::System.String viaIdentity, int? Top, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.HardwareSecurityModules/dedicatedHSMs$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HardwareSecurityModules/dedicatedHSMs'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.HardwareSecurityModules/dedicatedHSMs"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        + "&"
                        + (null == Top ? global::System.String.Empty : "$top=" + global::System.Uri.EscapeDataString(Top.ToString()))
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.DedicatedHsmListByResourceGroupWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>
        /// The List operation gets information about the dedicated HSMs associated with the subscription and within the specified
        /// resource group.
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="Top">Maximum number of results to return.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmListResult>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmListResult> DedicatedHsmListByResourceGroupWithResult(string subscriptionId, string resourceGroupName, int? Top, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.HardwareSecurityModules/dedicatedHSMs"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        + "&"
                        + (null == Top ? global::System.String.Empty : "$top=" + global::System.Uri.EscapeDataString(Top.ToString()))
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.DedicatedHsmListByResourceGroupWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>
        /// Actual wire call for <see cref= "DedicatedHsmListByResourceGroupWithResult" /> method.
        /// </summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmListResult>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmListResult> DedicatedHsmListByResourceGroupWithResult_Call(global::System.Net.Http.HttpRequestMessage request, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.DedicatedHsmListResult.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) );
                            return await _result;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.DedicatedHsmError.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) );
                            // Error Response : default
                            var code = (await _result)?.Error?.Code;
                            var message = (await _result)?.Error?.Message;
                            if ((null == code || null == message))
                            {
                                // Unrecognized Response. Create an error record based on what we have.
                                var ex = new Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmError>(_response, await _result);
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
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>Actual wire call for <see cref= "DedicatedHsmListByResourceGroup" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DedicatedHsmListByResourceGroup_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmListResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmError>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.DedicatedHsmListResult.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.DedicatedHsmError.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="DedicatedHsmListByResourceGroup" /> method. Call this like the actual call, but you will
        /// get validation events back.
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="Top">Maximum number of results to return.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DedicatedHsmListByResourceGroup_Validate(string subscriptionId, string resourceGroupName, int? Top, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(subscriptionId),subscriptionId);
                await eventListener.AssertMinimumLength(nameof(subscriptionId),subscriptionId,1);
                await eventListener.AssertNotNull(nameof(resourceGroupName),resourceGroupName);
                await eventListener.AssertMinimumLength(nameof(resourceGroupName),resourceGroupName,1);
                await eventListener.AssertMaximumLength(nameof(resourceGroupName),resourceGroupName,90);
                await eventListener.AssertRegEx(nameof(resourceGroupName), resourceGroupName, @"^[-\w\._\(\)]+$");
            }
        }

        /// <summary>
        /// The List operation gets information about the dedicated HSMs associated with the subscription.
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="Top">Maximum number of results to return.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DedicatedHsmListBySubscription(string subscriptionId, int? Top, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmListResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmError>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/providers/Microsoft.HardwareSecurityModules/dedicatedHSMs"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        + "&"
                        + (null == Top ? global::System.String.Empty : "$top=" + global::System.Uri.EscapeDataString(Top.ToString()))
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DedicatedHsmListBySubscription_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>
        /// The List operation gets information about the dedicated HSMs associated with the subscription.
        /// </summary>
        /// <param name="viaIdentity"></param>
        /// <param name="Top">Maximum number of results to return.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DedicatedHsmListBySubscriptionViaIdentity(global::System.String viaIdentity, int? Top, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmListResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmError>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/providers/Microsoft.HardwareSecurityModules/dedicatedHSMs$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/providers/Microsoft.HardwareSecurityModules/dedicatedHSMs'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/providers/Microsoft.HardwareSecurityModules/dedicatedHSMs"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        + "&"
                        + (null == Top ? global::System.String.Empty : "$top=" + global::System.Uri.EscapeDataString(Top.ToString()))
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DedicatedHsmListBySubscription_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>
        /// The List operation gets information about the dedicated HSMs associated with the subscription.
        /// </summary>
        /// <param name="viaIdentity"></param>
        /// <param name="Top">Maximum number of results to return.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmListResult>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmListResult> DedicatedHsmListBySubscriptionViaIdentityWithResult(global::System.String viaIdentity, int? Top, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/providers/Microsoft.HardwareSecurityModules/dedicatedHSMs$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/providers/Microsoft.HardwareSecurityModules/dedicatedHSMs'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/providers/Microsoft.HardwareSecurityModules/dedicatedHSMs"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        + "&"
                        + (null == Top ? global::System.String.Empty : "$top=" + global::System.Uri.EscapeDataString(Top.ToString()))
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.DedicatedHsmListBySubscriptionWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>
        /// The List operation gets information about the dedicated HSMs associated with the subscription.
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="Top">Maximum number of results to return.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmListResult>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmListResult> DedicatedHsmListBySubscriptionWithResult(string subscriptionId, int? Top, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/providers/Microsoft.HardwareSecurityModules/dedicatedHSMs"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        + "&"
                        + (null == Top ? global::System.String.Empty : "$top=" + global::System.Uri.EscapeDataString(Top.ToString()))
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.DedicatedHsmListBySubscriptionWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>
        /// Actual wire call for <see cref= "DedicatedHsmListBySubscriptionWithResult" /> method.
        /// </summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmListResult>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmListResult> DedicatedHsmListBySubscriptionWithResult_Call(global::System.Net.Http.HttpRequestMessage request, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.DedicatedHsmListResult.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) );
                            return await _result;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.DedicatedHsmError.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) );
                            // Error Response : default
                            var code = (await _result)?.Error?.Code;
                            var message = (await _result)?.Error?.Message;
                            if ((null == code || null == message))
                            {
                                // Unrecognized Response. Create an error record based on what we have.
                                var ex = new Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmError>(_response, await _result);
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
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>Actual wire call for <see cref= "DedicatedHsmListBySubscription" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DedicatedHsmListBySubscription_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmListResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmError>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.DedicatedHsmListResult.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.DedicatedHsmError.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="DedicatedHsmListBySubscription" /> method. Call this like the actual call, but you will
        /// get validation events back.
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="Top">Maximum number of results to return.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DedicatedHsmListBySubscription_Validate(string subscriptionId, int? Top, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(subscriptionId),subscriptionId);
                await eventListener.AssertMinimumLength(nameof(subscriptionId),subscriptionId,1);
            }
        }

        /// <summary>
        /// Gets a list of egress endpoints (network endpoints of all outbound dependencies) in the specified dedicated hsm resource.
        /// The operation returns properties of each egress endpoint.
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="name">Name of the dedicated Hsm</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DedicatedHsmListOutboundNetworkDependenciesEndpoints(string subscriptionId, string resourceGroupName, string name, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IOutboundEnvironmentEndpointCollection>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmError>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.HardwareSecurityModules/dedicatedHSMs/"
                        + global::System.Uri.EscapeDataString(name)
                        + "/outboundNetworkDependenciesEndpoints"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DedicatedHsmListOutboundNetworkDependenciesEndpoints_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>
        /// Gets a list of egress endpoints (network endpoints of all outbound dependencies) in the specified dedicated hsm resource.
        /// The operation returns properties of each egress endpoint.
        /// </summary>
        /// <param name="viaIdentity"></param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DedicatedHsmListOutboundNetworkDependenciesEndpointsViaIdentity(global::System.String viaIdentity, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IOutboundEnvironmentEndpointCollection>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmError>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.HardwareSecurityModules/dedicatedHSMs/(?<name>[^/]+)/outboundNetworkDependenciesEndpoints$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HardwareSecurityModules/dedicatedHSMs/{name}/outboundNetworkDependenciesEndpoints'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var name = _match.Groups["name"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.HardwareSecurityModules/dedicatedHSMs/"
                        + name
                        + "/outboundNetworkDependenciesEndpoints"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DedicatedHsmListOutboundNetworkDependenciesEndpoints_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>
        /// Gets a list of egress endpoints (network endpoints of all outbound dependencies) in the specified dedicated hsm resource.
        /// The operation returns properties of each egress endpoint.
        /// </summary>
        /// <param name="viaIdentity"></param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IOutboundEnvironmentEndpointCollection>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IOutboundEnvironmentEndpointCollection> DedicatedHsmListOutboundNetworkDependenciesEndpointsViaIdentityWithResult(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.HardwareSecurityModules/dedicatedHSMs/(?<name>[^/]+)/outboundNetworkDependenciesEndpoints$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HardwareSecurityModules/dedicatedHSMs/{name}/outboundNetworkDependenciesEndpoints'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var name = _match.Groups["name"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.HardwareSecurityModules/dedicatedHSMs/"
                        + name
                        + "/outboundNetworkDependenciesEndpoints"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.DedicatedHsmListOutboundNetworkDependenciesEndpointsWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>
        /// Gets a list of egress endpoints (network endpoints of all outbound dependencies) in the specified dedicated hsm resource.
        /// The operation returns properties of each egress endpoint.
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="name">Name of the dedicated Hsm</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IOutboundEnvironmentEndpointCollection>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IOutboundEnvironmentEndpointCollection> DedicatedHsmListOutboundNetworkDependenciesEndpointsWithResult(string subscriptionId, string resourceGroupName, string name, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.HardwareSecurityModules/dedicatedHSMs/"
                        + global::System.Uri.EscapeDataString(name)
                        + "/outboundNetworkDependenciesEndpoints"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.DedicatedHsmListOutboundNetworkDependenciesEndpointsWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>
        /// Actual wire call for <see cref= "DedicatedHsmListOutboundNetworkDependenciesEndpointsWithResult" /> method.
        /// </summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IOutboundEnvironmentEndpointCollection>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IOutboundEnvironmentEndpointCollection> DedicatedHsmListOutboundNetworkDependenciesEndpointsWithResult_Call(global::System.Net.Http.HttpRequestMessage request, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.OutboundEnvironmentEndpointCollection.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) );
                            return await _result;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.DedicatedHsmError.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) );
                            // Error Response : default
                            var code = (await _result)?.Error?.Code;
                            var message = (await _result)?.Error?.Message;
                            if ((null == code || null == message))
                            {
                                // Unrecognized Response. Create an error record based on what we have.
                                var ex = new Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmError>(_response, await _result);
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
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Actual wire call for <see cref= "DedicatedHsmListOutboundNetworkDependenciesEndpoints" /> method.
        /// </summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DedicatedHsmListOutboundNetworkDependenciesEndpoints_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IOutboundEnvironmentEndpointCollection>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmError>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.OutboundEnvironmentEndpointCollection.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.DedicatedHsmError.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="DedicatedHsmListOutboundNetworkDependenciesEndpoints" /> method. Call this like the actual
        /// call, but you will get validation events back.
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="name">Name of the dedicated Hsm</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DedicatedHsmListOutboundNetworkDependenciesEndpoints_Validate(string subscriptionId, string resourceGroupName, string name, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(subscriptionId),subscriptionId);
                await eventListener.AssertMinimumLength(nameof(subscriptionId),subscriptionId,1);
                await eventListener.AssertNotNull(nameof(resourceGroupName),resourceGroupName);
                await eventListener.AssertMinimumLength(nameof(resourceGroupName),resourceGroupName,1);
                await eventListener.AssertMaximumLength(nameof(resourceGroupName),resourceGroupName,90);
                await eventListener.AssertRegEx(nameof(resourceGroupName), resourceGroupName, @"^[-\w\._\(\)]+$");
                await eventListener.AssertNotNull(nameof(name),name);
                await eventListener.AssertRegEx(nameof(name), name, @"^[a-zA-Z0-9-]{3,24}$");
            }
        }

        /// <summary>update a dedicated HSM in the specified subscription.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="name">Name of the dedicated Hsm</param>
        /// <param name="body">Parameters to patch the dedicated HSM</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DedicatedHsmUpdate(string subscriptionId, string resourceGroupName, string name, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPatchParameters body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsm>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmError>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.HardwareSecurityModules/dedicatedHSMs/"
                        + global::System.Uri.EscapeDataString(name)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Patch, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DedicatedHsmUpdate_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>update a dedicated HSM in the specified subscription.</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="body">Parameters to patch the dedicated HSM</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DedicatedHsmUpdateViaIdentity(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPatchParameters body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsm>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmError>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.HardwareSecurityModules/dedicatedHSMs/(?<name>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HardwareSecurityModules/dedicatedHSMs/{name}'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var name = _match.Groups["name"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.HardwareSecurityModules/dedicatedHSMs/"
                        + name
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Patch, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DedicatedHsmUpdate_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>update a dedicated HSM in the specified subscription.</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="body">Parameters to patch the dedicated HSM</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsm>" /> that
        /// will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsm> DedicatedHsmUpdateViaIdentityWithResult(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPatchParameters body, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.HardwareSecurityModules/dedicatedHSMs/(?<name>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HardwareSecurityModules/dedicatedHSMs/{name}'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var name = _match.Groups["name"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.HardwareSecurityModules/dedicatedHSMs/"
                        + name
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Patch, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.DedicatedHsmUpdateWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>update a dedicated HSM in the specified subscription.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="name">Name of the dedicated Hsm</param>
        /// <param name="jsonString">Json string supplied to the DedicatedHsmUpdate operation</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DedicatedHsmUpdateViaJsonString(string subscriptionId, string resourceGroupName, string name, global::System.String jsonString, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsm>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmError>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.HardwareSecurityModules/dedicatedHSMs/"
                        + global::System.Uri.EscapeDataString(name)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Patch, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(jsonString, global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DedicatedHsmUpdate_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>update a dedicated HSM in the specified subscription.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="name">Name of the dedicated Hsm</param>
        /// <param name="jsonString">Json string supplied to the DedicatedHsmUpdate operation</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsm>" /> that
        /// will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsm> DedicatedHsmUpdateViaJsonStringWithResult(string subscriptionId, string resourceGroupName, string name, global::System.String jsonString, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.HardwareSecurityModules/dedicatedHSMs/"
                        + global::System.Uri.EscapeDataString(name)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Patch, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(jsonString, global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.DedicatedHsmUpdateWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>update a dedicated HSM in the specified subscription.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="name">Name of the dedicated Hsm</param>
        /// <param name="body">Parameters to patch the dedicated HSM</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsm>" /> that
        /// will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsm> DedicatedHsmUpdateWithResult(string subscriptionId, string resourceGroupName, string name, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPatchParameters body, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.HardwareSecurityModules/dedicatedHSMs/"
                        + global::System.Uri.EscapeDataString(name)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Patch, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.DedicatedHsmUpdateWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref= "DedicatedHsmUpdateWithResult" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsm>" /> that
        /// will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsm> DedicatedHsmUpdateWithResult_Call(global::System.Net.Http.HttpRequestMessage request, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    // this operation supports x-ms-long-running-operation
                    var _originalUri = request.RequestUri.AbsoluteUri;
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Progress, "intentional placeholder", 0); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    // declared final-state-via: location
                    var _finalUri = _response.GetFirstHeader(@"Location");
                    var asyncOperation = _response.GetFirstHeader(@"Azure-AsyncOperation");
                    var location = _response.GetFirstHeader(@"Location");
                    var operationLocation = _response.GetFirstHeader(@"Operation-Location");
                    while (request.Method == System.Net.Http.HttpMethod.Put && _response.StatusCode == global::System.Net.HttpStatusCode.OK || _response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                    {
                        // delay before making the next polling request
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.DelayBeforePolling, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }

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
                        request = request.CloneAndDispose(new global::System.Uri(_uri), Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get);

                        // and let's look at the current response body and see if we have some information we can give back to the listener
                        var content = await _response.Content.ReadAsStringAsync();

                        // drop the old response
                        _response?.Dispose();

                        // make the polling call
                        _response = await sender.SendAsync(request, eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }

                          // if we got back an OK, take a peek inside and see if it's done
                          if( _response.StatusCode == global::System.Net.HttpStatusCode.OK)
                          {
                              var error = false;
                              try {
                                  if( Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(await _response.Content.ReadAsStringAsync()) is Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonObject json)
                                  {
                                      var state = json.Property("properties")?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonString>("provisioningState") ?? json.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonString>("status");
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
                                  throw new Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.UndeclaredResponseException(_response);
                              }
                          }

                        // check for terminal status code
                        if (_response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                        {
                            continue;
                        }
                        // we are done polling, do a request on final target?
                        // create a new request with the final uri
                        request = request.CloneAndDispose(new global::System.Uri(_finalUri), Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get);

                        // drop the old response
                        _response?.Dispose();

                        // make the final call
                        _response = await sender.SendAsync(request,  eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                        break;
                    }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.DedicatedHsm.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) );
                            return await _result;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.DedicatedHsmError.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) );
                            // Error Response : default
                            var code = (await _result)?.Error?.Code;
                            var message = (await _result)?.Error?.Message;
                            if ((null == code || null == message))
                            {
                                // Unrecognized Response. Create an error record based on what we have.
                                var ex = new Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmError>(_response, await _result);
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
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>Actual wire call for <see cref= "DedicatedHsmUpdate" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DedicatedHsmUpdate_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsm>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmError>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    // this operation supports x-ms-long-running-operation
                    var _originalUri = request.RequestUri.AbsoluteUri;
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Progress, "intentional placeholder", 0); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    // declared final-state-via: location
                    var _finalUri = _response.GetFirstHeader(@"Location");
                    var asyncOperation = _response.GetFirstHeader(@"Azure-AsyncOperation");
                    var location = _response.GetFirstHeader(@"Location");
                    var operationLocation = _response.GetFirstHeader(@"Operation-Location");
                    while (request.Method == System.Net.Http.HttpMethod.Put && _response.StatusCode == global::System.Net.HttpStatusCode.OK || _response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                    {
                        // delay before making the next polling request
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.DelayBeforePolling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }

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
                        request = request.CloneAndDispose(new global::System.Uri(_uri), Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get);

                        // and let's look at the current response body and see if we have some information we can give back to the listener
                        var content = await _response.Content.ReadAsStringAsync();

                        // drop the old response
                        _response?.Dispose();

                        // make the polling call
                        _response = await sender.SendAsync(request, eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }

                          // if we got back an OK, take a peek inside and see if it's done
                          if( _response.StatusCode == global::System.Net.HttpStatusCode.OK)
                          {
                              var error = false;
                              try {
                                  if( Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(await _response.Content.ReadAsStringAsync()) is Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonObject json)
                                  {
                                      var state = json.Property("properties")?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonString>("provisioningState") ?? json.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonString>("status");
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
                                  throw new Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.UndeclaredResponseException(_response);
                              }
                          }

                        // check for terminal status code
                        if (_response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                        {
                            continue;
                        }
                        // we are done polling, do a request on final target?
                        // create a new request with the final uri
                        request = request.CloneAndDispose(new global::System.Uri(_finalUri), Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get);

                        // drop the old response
                        _response?.Dispose();

                        // make the final call
                        _response = await sender.SendAsync(request,  eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                        break;
                    }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.DedicatedHsm.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.DedicatedHsmError.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="DedicatedHsmUpdate" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="name">Name of the dedicated Hsm</param>
        /// <param name="body">Parameters to patch the dedicated HSM</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DedicatedHsmUpdate_Validate(string subscriptionId, string resourceGroupName, string name, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPatchParameters body, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(subscriptionId),subscriptionId);
                await eventListener.AssertMinimumLength(nameof(subscriptionId),subscriptionId,1);
                await eventListener.AssertNotNull(nameof(resourceGroupName),resourceGroupName);
                await eventListener.AssertMinimumLength(nameof(resourceGroupName),resourceGroupName,1);
                await eventListener.AssertMaximumLength(nameof(resourceGroupName),resourceGroupName,90);
                await eventListener.AssertRegEx(nameof(resourceGroupName), resourceGroupName, @"^[-\w\._\(\)]+$");
                await eventListener.AssertNotNull(nameof(name),name);
                await eventListener.AssertRegEx(nameof(name), name, @"^[a-zA-Z0-9-]{3,24}$");
                await eventListener.AssertNotNull(nameof(body), body);
                await eventListener.AssertObjectIsValid(nameof(body), body);
            }
        }

        /// <summary>List the operations for the provider</summary>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task OperationsList(global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IOperationListResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/providers/Microsoft.HardwareSecurityModules/operations"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.OperationsList_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>List the operations for the provider</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task OperationsListViaIdentity(global::System.String viaIdentity, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IOperationListResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/providers/Microsoft.HardwareSecurityModules/operations$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/providers/Microsoft.HardwareSecurityModules/operations'");
                }

                // replace URI parameters with values from identity
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/providers/Microsoft.HardwareSecurityModules/operations"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.OperationsList_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>List the operations for the provider</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IOperationListResult>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IOperationListResult> OperationsListViaIdentityWithResult(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/providers/Microsoft.HardwareSecurityModules/operations$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/providers/Microsoft.HardwareSecurityModules/operations'");
                }

                // replace URI parameters with values from identity
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/providers/Microsoft.HardwareSecurityModules/operations"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.OperationsListWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>List the operations for the provider</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IOperationListResult>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IOperationListResult> OperationsListWithResult(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/providers/Microsoft.HardwareSecurityModules/operations"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.OperationsListWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref= "OperationsListWithResult" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IOperationListResult>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IOperationListResult> OperationsListWithResult_Call(global::System.Net.Http.HttpRequestMessage request, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.OperationListResult.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) );
                            return await _result;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) );
                            // Error Response : default
                            var code = (await _result)?.Code;
                            var message = (await _result)?.Message;
                            if ((null == code || null == message))
                            {
                                // Unrecognized Response. Create an error record based on what we have.
                                var ex = new Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>(_response, await _result);
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
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Finally, request, _response);
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
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task OperationsList_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IOperationListResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.OperationListResult.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="OperationsList" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task OperationsList_Validate(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {

            }
        }

        /// <summary>
        /// The List operation gets information about the private endpoint connections associated with the Cloud HSM Cluster
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="cloudHsmClusterName">The name of the Cloud HSM Cluster within the specified resource group. Cloud HSM Cluster
        /// names must be between 3 and 23 characters in length.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task PrivateEndpointConnectionsListByCloudHsmCluster(string subscriptionId, string resourceGroupName, string cloudHsmClusterName, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IPrivateEndpointConnectionListResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/"
                        + global::System.Uri.EscapeDataString(cloudHsmClusterName)
                        + "/privateEndpointConnections"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.PrivateEndpointConnectionsListByCloudHsmCluster_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>
        /// The List operation gets information about the private endpoint connections associated with the Cloud HSM Cluster
        /// </summary>
        /// <param name="viaIdentity"></param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task PrivateEndpointConnectionsListByCloudHsmClusterViaIdentity(global::System.String viaIdentity, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IPrivateEndpointConnectionListResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/(?<cloudHsmClusterName>[^/]+)/privateEndpointConnections$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/{cloudHsmClusterName}/privateEndpointConnections'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var cloudHsmClusterName = _match.Groups["cloudHsmClusterName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/"
                        + cloudHsmClusterName
                        + "/privateEndpointConnections"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.PrivateEndpointConnectionsListByCloudHsmCluster_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>
        /// The List operation gets information about the private endpoint connections associated with the Cloud HSM Cluster
        /// </summary>
        /// <param name="viaIdentity"></param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IPrivateEndpointConnectionListResult>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IPrivateEndpointConnectionListResult> PrivateEndpointConnectionsListByCloudHsmClusterViaIdentityWithResult(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/(?<cloudHsmClusterName>[^/]+)/privateEndpointConnections$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/{cloudHsmClusterName}/privateEndpointConnections'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var cloudHsmClusterName = _match.Groups["cloudHsmClusterName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/"
                        + cloudHsmClusterName
                        + "/privateEndpointConnections"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.PrivateEndpointConnectionsListByCloudHsmClusterWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>
        /// The List operation gets information about the private endpoint connections associated with the Cloud HSM Cluster
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="cloudHsmClusterName">The name of the Cloud HSM Cluster within the specified resource group. Cloud HSM Cluster
        /// names must be between 3 and 23 characters in length.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IPrivateEndpointConnectionListResult>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IPrivateEndpointConnectionListResult> PrivateEndpointConnectionsListByCloudHsmClusterWithResult(string subscriptionId, string resourceGroupName, string cloudHsmClusterName, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2025-03-31";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/"
                        + global::System.Uri.EscapeDataString(cloudHsmClusterName)
                        + "/privateEndpointConnections"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.PrivateEndpointConnectionsListByCloudHsmClusterWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>
        /// Actual wire call for <see cref= "PrivateEndpointConnectionsListByCloudHsmClusterWithResult" /> method.
        /// </summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IPrivateEndpointConnectionListResult>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IPrivateEndpointConnectionListResult> PrivateEndpointConnectionsListByCloudHsmClusterWithResult_Call(global::System.Net.Http.HttpRequestMessage request, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.PrivateEndpointConnectionListResult.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) );
                            return await _result;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) );
                            // Error Response : default
                            var code = (await _result)?.Code;
                            var message = (await _result)?.Message;
                            if ((null == code || null == message))
                            {
                                // Unrecognized Response. Create an error record based on what we have.
                                var ex = new Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>(_response, await _result);
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
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Actual wire call for <see cref= "PrivateEndpointConnectionsListByCloudHsmCluster" /> method.
        /// </summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task PrivateEndpointConnectionsListByCloudHsmCluster_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IPrivateEndpointConnectionListResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.PrivateEndpointConnectionListResult.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="PrivateEndpointConnectionsListByCloudHsmCluster" /> method. Call this like the actual
        /// call, but you will get validation events back.
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="cloudHsmClusterName">The name of the Cloud HSM Cluster within the specified resource group. Cloud HSM Cluster
        /// names must be between 3 and 23 characters in length.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task PrivateEndpointConnectionsListByCloudHsmCluster_Validate(string subscriptionId, string resourceGroupName, string cloudHsmClusterName, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(subscriptionId),subscriptionId);
                await eventListener.AssertMinimumLength(nameof(subscriptionId),subscriptionId,1);
                await eventListener.AssertNotNull(nameof(resourceGroupName),resourceGroupName);
                await eventListener.AssertMinimumLength(nameof(resourceGroupName),resourceGroupName,1);
                await eventListener.AssertMaximumLength(nameof(resourceGroupName),resourceGroupName,90);
                await eventListener.AssertRegEx(nameof(resourceGroupName), resourceGroupName, @"^[-\w\._\(\)]+$");
                await eventListener.AssertNotNull(nameof(cloudHsmClusterName),cloudHsmClusterName);
                await eventListener.AssertMinimumLength(nameof(cloudHsmClusterName),cloudHsmClusterName,3);
                await eventListener.AssertMaximumLength(nameof(cloudHsmClusterName),cloudHsmClusterName,23);
                await eventListener.AssertRegEx(nameof(cloudHsmClusterName), cloudHsmClusterName, @"^[a-zA-Z0-9-]{3,23}$");
            }
        }
    }
}