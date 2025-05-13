// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Extensions;

    /// <summary>
    /// Low-level API implementation for the Microsoft.NetworkAnalytics service.
    /// </summary>
    public partial class MicrosoftNetworkAnalytics
    {

        /// <summary>Assign role to the data product.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="dataProductName">The data product resource name</param>
        /// <param name="body">The content of the action request</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DataProductsAddUserRole(string subscriptionId, string resourceGroupName, string dataProductName, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IRoleAssignmentCommonProperties body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IRoleAssignmentDetail>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts/"
                        + global::System.Uri.EscapeDataString(dataProductName)
                        + "/addUserRole"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DataProductsAddUserRole_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>Assign role to the data product.</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="body">The content of the action request</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DataProductsAddUserRoleViaIdentity(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IRoleAssignmentCommonProperties body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IRoleAssignmentDetail>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.NetworkAnalytics/dataProducts/(?<dataProductName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkAnalytics/dataProducts/{dataProductName}'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var dataProductName = _match.Groups["dataProductName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts/"
                        + dataProductName
                        + "/addUserRole"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DataProductsAddUserRole_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>Assign role to the data product.</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="body">The content of the action request</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IRoleAssignmentDetail>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IRoleAssignmentDetail> DataProductsAddUserRoleViaIdentityWithResult(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IRoleAssignmentCommonProperties body, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.NetworkAnalytics/dataProducts/(?<dataProductName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkAnalytics/dataProducts/{dataProductName}'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var dataProductName = _match.Groups["dataProductName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts/"
                        + dataProductName
                        + "/addUserRole"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.DataProductsAddUserRoleWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>Assign role to the data product.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="dataProductName">The data product resource name</param>
        /// <param name="jsonString">Json string supplied to the DataProductsAddUserRole operation</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DataProductsAddUserRoleViaJsonString(string subscriptionId, string resourceGroupName, string dataProductName, global::System.String jsonString, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IRoleAssignmentDetail>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts/"
                        + global::System.Uri.EscapeDataString(dataProductName)
                        + "/addUserRole"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(jsonString, global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DataProductsAddUserRole_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>Assign role to the data product.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="dataProductName">The data product resource name</param>
        /// <param name="jsonString">Json string supplied to the DataProductsAddUserRole operation</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IRoleAssignmentDetail>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IRoleAssignmentDetail> DataProductsAddUserRoleViaJsonStringWithResult(string subscriptionId, string resourceGroupName, string dataProductName, global::System.String jsonString, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts/"
                        + global::System.Uri.EscapeDataString(dataProductName)
                        + "/addUserRole"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(jsonString, global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.DataProductsAddUserRoleWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>Assign role to the data product.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="dataProductName">The data product resource name</param>
        /// <param name="body">The content of the action request</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IRoleAssignmentDetail>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IRoleAssignmentDetail> DataProductsAddUserRoleWithResult(string subscriptionId, string resourceGroupName, string dataProductName, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IRoleAssignmentCommonProperties body, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts/"
                        + global::System.Uri.EscapeDataString(dataProductName)
                        + "/addUserRole"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.DataProductsAddUserRoleWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref= "DataProductsAddUserRoleWithResult" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IRoleAssignmentDetail>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IRoleAssignmentDetail> DataProductsAddUserRoleWithResult_Call(global::System.Net.Http.HttpRequestMessage request, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.RoleAssignmentDetail.FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(body.Result)) );
                            return await _result;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(body.Result)) );
                            // Error Response : default
                            var code = (await _result)?.Code;
                            var message = (await _result)?.Message;
                            if ((null == code || null == message))
                            {
                                // Unrecognized Response. Create an error record based on what we have.
                                var ex = new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>(_response, await _result);
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
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>Actual wire call for <see cref= "DataProductsAddUserRole" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DataProductsAddUserRole_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IRoleAssignmentDetail>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.RoleAssignmentDetail.FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="DataProductsAddUserRole" /> method. Call this like the actual call, but you will get
        /// validation events back.
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="dataProductName">The data product resource name</param>
        /// <param name="body">The content of the action request</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DataProductsAddUserRole_Validate(string subscriptionId, string resourceGroupName, string dataProductName, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IRoleAssignmentCommonProperties body, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(subscriptionId),subscriptionId);
                await eventListener.AssertMinimumLength(nameof(subscriptionId),subscriptionId,1);
                await eventListener.AssertNotNull(nameof(resourceGroupName),resourceGroupName);
                await eventListener.AssertMinimumLength(nameof(resourceGroupName),resourceGroupName,1);
                await eventListener.AssertMaximumLength(nameof(resourceGroupName),resourceGroupName,90);
                await eventListener.AssertRegEx(nameof(resourceGroupName), resourceGroupName, @"^[-\w\._\(\)]+$");
                await eventListener.AssertNotNull(nameof(dataProductName),dataProductName);
                await eventListener.AssertMinimumLength(nameof(dataProductName),dataProductName,3);
                await eventListener.AssertMaximumLength(nameof(dataProductName),dataProductName,63);
                await eventListener.AssertRegEx(nameof(dataProductName), dataProductName, @"^[a-z][a-z0-9]*$");
                await eventListener.AssertNotNull(nameof(body), body);
                await eventListener.AssertObjectIsValid(nameof(body), body);
            }
        }

        /// <summary>Retrieve data type resource.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DataProductsCatalogsGet(string subscriptionId, string resourceGroupName, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductsCatalog>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.NetworkAnalytics/dataProductsCatalogs/default"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DataProductsCatalogsGet_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>Retrieve data type resource.</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DataProductsCatalogsGetViaIdentity(global::System.String viaIdentity, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductsCatalog>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.NetworkAnalytics/dataProductsCatalogs/default$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkAnalytics/dataProductsCatalogs/default'");
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
                        + "/providers/Microsoft.NetworkAnalytics/dataProductsCatalogs/default"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DataProductsCatalogsGet_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>Retrieve data type resource.</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductsCatalog>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductsCatalog> DataProductsCatalogsGetViaIdentityWithResult(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.NetworkAnalytics/dataProductsCatalogs/default$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkAnalytics/dataProductsCatalogs/default'");
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
                        + "/providers/Microsoft.NetworkAnalytics/dataProductsCatalogs/default"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.DataProductsCatalogsGetWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>Retrieve data type resource.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductsCatalog>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductsCatalog> DataProductsCatalogsGetWithResult(string subscriptionId, string resourceGroupName, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.NetworkAnalytics/dataProductsCatalogs/default"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.DataProductsCatalogsGetWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref= "DataProductsCatalogsGetWithResult" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductsCatalog>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductsCatalog> DataProductsCatalogsGetWithResult_Call(global::System.Net.Http.HttpRequestMessage request, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.DataProductsCatalog.FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(body.Result)) );
                            return await _result;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(body.Result)) );
                            // Error Response : default
                            var code = (await _result)?.Code;
                            var message = (await _result)?.Message;
                            if ((null == code || null == message))
                            {
                                // Unrecognized Response. Create an error record based on what we have.
                                var ex = new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>(_response, await _result);
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
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>Actual wire call for <see cref= "DataProductsCatalogsGet" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DataProductsCatalogsGet_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductsCatalog>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.DataProductsCatalog.FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="DataProductsCatalogsGet" /> method. Call this like the actual call, but you will get
        /// validation events back.
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DataProductsCatalogsGet_Validate(string subscriptionId, string resourceGroupName, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener)
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

        /// <summary>List data catalog by resource group.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DataProductsCatalogsListByResourceGroup(string subscriptionId, string resourceGroupName, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductsCatalogListResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.NetworkAnalytics/dataProductsCatalogs"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DataProductsCatalogsListByResourceGroup_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>List data catalog by resource group.</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DataProductsCatalogsListByResourceGroupViaIdentity(global::System.String viaIdentity, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductsCatalogListResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.NetworkAnalytics/dataProductsCatalogs$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkAnalytics/dataProductsCatalogs'");
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
                        + "/providers/Microsoft.NetworkAnalytics/dataProductsCatalogs"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DataProductsCatalogsListByResourceGroup_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>List data catalog by resource group.</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductsCatalogListResult>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductsCatalogListResult> DataProductsCatalogsListByResourceGroupViaIdentityWithResult(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.NetworkAnalytics/dataProductsCatalogs$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkAnalytics/dataProductsCatalogs'");
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
                        + "/providers/Microsoft.NetworkAnalytics/dataProductsCatalogs"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.DataProductsCatalogsListByResourceGroupWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>List data catalog by resource group.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductsCatalogListResult>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductsCatalogListResult> DataProductsCatalogsListByResourceGroupWithResult(string subscriptionId, string resourceGroupName, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.NetworkAnalytics/dataProductsCatalogs"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.DataProductsCatalogsListByResourceGroupWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>
        /// Actual wire call for <see cref= "DataProductsCatalogsListByResourceGroupWithResult" /> method.
        /// </summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductsCatalogListResult>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductsCatalogListResult> DataProductsCatalogsListByResourceGroupWithResult_Call(global::System.Net.Http.HttpRequestMessage request, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.DataProductsCatalogListResult.FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(body.Result)) );
                            return await _result;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(body.Result)) );
                            // Error Response : default
                            var code = (await _result)?.Code;
                            var message = (await _result)?.Message;
                            if ((null == code || null == message))
                            {
                                // Unrecognized Response. Create an error record based on what we have.
                                var ex = new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>(_response, await _result);
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
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Actual wire call for <see cref= "DataProductsCatalogsListByResourceGroup" /> method.
        /// </summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DataProductsCatalogsListByResourceGroup_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductsCatalogListResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.DataProductsCatalogListResult.FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="DataProductsCatalogsListByResourceGroup" /> method. Call this like the actual call, but
        /// you will get validation events back.
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DataProductsCatalogsListByResourceGroup_Validate(string subscriptionId, string resourceGroupName, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener)
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

        /// <summary>List data catalog by subscription.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DataProductsCatalogsListBySubscription(string subscriptionId, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductsCatalogListResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/providers/Microsoft.NetworkAnalytics/dataProductsCatalogs"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DataProductsCatalogsListBySubscription_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>List data catalog by subscription.</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DataProductsCatalogsListBySubscriptionViaIdentity(global::System.String viaIdentity, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductsCatalogListResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/providers/Microsoft.NetworkAnalytics/dataProductsCatalogs$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/providers/Microsoft.NetworkAnalytics/dataProductsCatalogs'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/providers/Microsoft.NetworkAnalytics/dataProductsCatalogs"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DataProductsCatalogsListBySubscription_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>List data catalog by subscription.</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductsCatalogListResult>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductsCatalogListResult> DataProductsCatalogsListBySubscriptionViaIdentityWithResult(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/providers/Microsoft.NetworkAnalytics/dataProductsCatalogs$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/providers/Microsoft.NetworkAnalytics/dataProductsCatalogs'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/providers/Microsoft.NetworkAnalytics/dataProductsCatalogs"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.DataProductsCatalogsListBySubscriptionWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>List data catalog by subscription.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductsCatalogListResult>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductsCatalogListResult> DataProductsCatalogsListBySubscriptionWithResult(string subscriptionId, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/providers/Microsoft.NetworkAnalytics/dataProductsCatalogs"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.DataProductsCatalogsListBySubscriptionWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>
        /// Actual wire call for <see cref= "DataProductsCatalogsListBySubscriptionWithResult" /> method.
        /// </summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductsCatalogListResult>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductsCatalogListResult> DataProductsCatalogsListBySubscriptionWithResult_Call(global::System.Net.Http.HttpRequestMessage request, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.DataProductsCatalogListResult.FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(body.Result)) );
                            return await _result;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(body.Result)) );
                            // Error Response : default
                            var code = (await _result)?.Code;
                            var message = (await _result)?.Message;
                            if ((null == code || null == message))
                            {
                                // Unrecognized Response. Create an error record based on what we have.
                                var ex = new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>(_response, await _result);
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
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Actual wire call for <see cref= "DataProductsCatalogsListBySubscription" /> method.
        /// </summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DataProductsCatalogsListBySubscription_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductsCatalogListResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.DataProductsCatalogListResult.FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="DataProductsCatalogsListBySubscription" /> method. Call this like the actual call, but
        /// you will get validation events back.
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DataProductsCatalogsListBySubscription_Validate(string subscriptionId, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(subscriptionId),subscriptionId);
                await eventListener.AssertMinimumLength(nameof(subscriptionId),subscriptionId,1);
            }
        }

        /// <summary>update data product resource.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="dataProductName">The data product resource name</param>
        /// <param name="body">Resource create parameters.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DataProductsCreate(string subscriptionId, string resourceGroupName, string dataProductName, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProduct body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProduct>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts/"
                        + global::System.Uri.EscapeDataString(dataProductName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Put, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DataProductsCreate_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>update data product resource.</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="body">Resource create parameters.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DataProductsCreateViaIdentity(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProduct body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProduct>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.NetworkAnalytics/dataProducts/(?<dataProductName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkAnalytics/dataProducts/{dataProductName}'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var dataProductName = _match.Groups["dataProductName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts/"
                        + dataProductName
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Put, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DataProductsCreate_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>update data product resource.</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="body">Resource create parameters.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProduct>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProduct> DataProductsCreateViaIdentityWithResult(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProduct body, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.NetworkAnalytics/dataProducts/(?<dataProductName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkAnalytics/dataProducts/{dataProductName}'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var dataProductName = _match.Groups["dataProductName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts/"
                        + dataProductName
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Put, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.DataProductsCreateWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>update data product resource.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="dataProductName">The data product resource name</param>
        /// <param name="jsonString">Json string supplied to the DataProductsCreate operation</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DataProductsCreateViaJsonString(string subscriptionId, string resourceGroupName, string dataProductName, global::System.String jsonString, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProduct>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts/"
                        + global::System.Uri.EscapeDataString(dataProductName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Put, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(jsonString, global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DataProductsCreate_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>update data product resource.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="dataProductName">The data product resource name</param>
        /// <param name="jsonString">Json string supplied to the DataProductsCreate operation</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProduct>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProduct> DataProductsCreateViaJsonStringWithResult(string subscriptionId, string resourceGroupName, string dataProductName, global::System.String jsonString, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts/"
                        + global::System.Uri.EscapeDataString(dataProductName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Put, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(jsonString, global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.DataProductsCreateWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>update data product resource.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="dataProductName">The data product resource name</param>
        /// <param name="body">Resource create parameters.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProduct>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProduct> DataProductsCreateWithResult(string subscriptionId, string resourceGroupName, string dataProductName, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProduct body, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts/"
                        + global::System.Uri.EscapeDataString(dataProductName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Put, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.DataProductsCreateWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref= "DataProductsCreateWithResult" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProduct>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProduct> DataProductsCreateWithResult_Call(global::System.Net.Http.HttpRequestMessage request, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    // this operation supports x-ms-long-running-operation
                    var _originalUri = request.RequestUri.AbsoluteUri;
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Progress, "intentional placeholder", 0); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    // declared final-state-via: azure-async-operation
                    var asyncOperation = _response.GetFirstHeader(@"Azure-AsyncOperation");
                    var location = _response.GetFirstHeader(@"Location");
                    var operationLocation = _response.GetFirstHeader(@"Operation-Location");
                    while (request.Method == System.Net.Http.HttpMethod.Put && _response.StatusCode == global::System.Net.HttpStatusCode.OK || _response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                    {
                        // delay before making the next polling request
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.DelayBeforePolling, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }

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
                        request = request.CloneAndDispose(new global::System.Uri(_uri), Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Get);

                        // and let's look at the current response body and see if we have some information we can give back to the listener
                        var content = await _response.Content.ReadAsStringAsync();

                        // drop the old response
                        _response?.Dispose();

                        // make the polling call
                        _response = await sender.SendAsync(request, eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }

                          // if we got back an OK, take a peek inside and see if it's done
                          if( _response.StatusCode == global::System.Net.HttpStatusCode.OK)
                          {
                              var error = false;
                              try {
                                  if( Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(await _response.Content.ReadAsStringAsync()) is Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonObject json)
                                  {
                                      var state = json.Property("properties")?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString>("provisioningState") ?? json.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString>("status");
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
                                  throw new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.UndeclaredResponseException(_response);
                              }
                          }

                        // check for terminal status code
                        if (_response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                        {
                            continue;
                        }
                        // we are done polling, do a request on final target?
                        // create a new request with the final uri
                        request = request.CloneAndDispose(new global::System.Uri(_originalUri), Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Get);

                        // drop the old response
                        _response?.Dispose();

                        // make the final call
                        _response = await sender.SendAsync(request,  eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                        break;
                    }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.DataProduct.FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(body.Result)) .ReadHeaders(_response.Headers));
                            return await _result;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(body.Result)) );
                            // Error Response : default
                            var code = (await _result)?.Code;
                            var message = (await _result)?.Message;
                            if ((null == code || null == message))
                            {
                                // Unrecognized Response. Create an error record based on what we have.
                                var ex = new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>(_response, await _result);
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
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>Actual wire call for <see cref= "DataProductsCreate" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DataProductsCreate_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProduct>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    // this operation supports x-ms-long-running-operation
                    var _originalUri = request.RequestUri.AbsoluteUri;
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Progress, "intentional placeholder", 0); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    // declared final-state-via: azure-async-operation
                    var asyncOperation = _response.GetFirstHeader(@"Azure-AsyncOperation");
                    var location = _response.GetFirstHeader(@"Location");
                    var operationLocation = _response.GetFirstHeader(@"Operation-Location");
                    while (request.Method == System.Net.Http.HttpMethod.Put && _response.StatusCode == global::System.Net.HttpStatusCode.OK || _response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                    {
                        // delay before making the next polling request
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.DelayBeforePolling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }

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
                        request = request.CloneAndDispose(new global::System.Uri(_uri), Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Get);

                        // and let's look at the current response body and see if we have some information we can give back to the listener
                        var content = await _response.Content.ReadAsStringAsync();

                        // drop the old response
                        _response?.Dispose();

                        // make the polling call
                        _response = await sender.SendAsync(request, eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }

                          // if we got back an OK, take a peek inside and see if it's done
                          if( _response.StatusCode == global::System.Net.HttpStatusCode.OK)
                          {
                              var error = false;
                              try {
                                  if( Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(await _response.Content.ReadAsStringAsync()) is Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonObject json)
                                  {
                                      var state = json.Property("properties")?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString>("provisioningState") ?? json.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString>("status");
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
                                  throw new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.UndeclaredResponseException(_response);
                              }
                          }

                        // check for terminal status code
                        if (_response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                        {
                            continue;
                        }
                        // we are done polling, do a request on final target?
                        // create a new request with the final uri
                        request = request.CloneAndDispose(new global::System.Uri(_originalUri), Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Get);

                        // drop the old response
                        _response?.Dispose();

                        // make the final call
                        _response = await sender.SendAsync(request,  eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                        break;
                    }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.DataProduct.FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(body.Result)) .ReadHeaders(_response.Headers)));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="DataProductsCreate" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="dataProductName">The data product resource name</param>
        /// <param name="body">Resource create parameters.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DataProductsCreate_Validate(string subscriptionId, string resourceGroupName, string dataProductName, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProduct body, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(subscriptionId),subscriptionId);
                await eventListener.AssertMinimumLength(nameof(subscriptionId),subscriptionId,1);
                await eventListener.AssertNotNull(nameof(resourceGroupName),resourceGroupName);
                await eventListener.AssertMinimumLength(nameof(resourceGroupName),resourceGroupName,1);
                await eventListener.AssertMaximumLength(nameof(resourceGroupName),resourceGroupName,90);
                await eventListener.AssertRegEx(nameof(resourceGroupName), resourceGroupName, @"^[-\w\._\(\)]+$");
                await eventListener.AssertNotNull(nameof(dataProductName),dataProductName);
                await eventListener.AssertMinimumLength(nameof(dataProductName),dataProductName,3);
                await eventListener.AssertMaximumLength(nameof(dataProductName),dataProductName,63);
                await eventListener.AssertRegEx(nameof(dataProductName), dataProductName, @"^[a-z][a-z0-9]*$");
                await eventListener.AssertNotNull(nameof(body), body);
                await eventListener.AssertObjectIsValid(nameof(body), body);
            }
        }

        /// <summary>Delete data product resource.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="dataProductName">The data product resource name</param>
        /// <param name="onNoContent">a delegate that is called when the remote service returns 204 (NoContent).</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DataProductsDelete(string subscriptionId, string resourceGroupName, string dataProductName, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onNoContent, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts/"
                        + global::System.Uri.EscapeDataString(dataProductName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Delete, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DataProductsDelete_Call (request, onNoContent,onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>Delete data product resource.</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="onNoContent">a delegate that is called when the remote service returns 204 (NoContent).</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DataProductsDeleteViaIdentity(global::System.String viaIdentity, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onNoContent, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.NetworkAnalytics/dataProducts/(?<dataProductName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkAnalytics/dataProducts/{dataProductName}'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var dataProductName = _match.Groups["dataProductName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts/"
                        + dataProductName
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Delete, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DataProductsDelete_Call (request, onNoContent,onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref= "DataProductsDelete" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onNoContent">a delegate that is called when the remote service returns 204 (NoContent).</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DataProductsDelete_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onNoContent, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    // this operation supports x-ms-long-running-operation
                    var _originalUri = request.RequestUri.AbsoluteUri;
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Progress, "intentional placeholder", 0); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    // declared final-state-via: location
                    var _finalUri = _response.GetFirstHeader(@"Location");
                    var asyncOperation = _response.GetFirstHeader(@"Azure-AsyncOperation");
                    var location = _response.GetFirstHeader(@"Location");
                    var operationLocation = _response.GetFirstHeader(@"Operation-Location");
                    while (request.Method == System.Net.Http.HttpMethod.Put && _response.StatusCode == global::System.Net.HttpStatusCode.OK || _response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                    {
                        // delay before making the next polling request
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.DelayBeforePolling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }

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
                        request = request.CloneAndDispose(new global::System.Uri(_uri), Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Get);

                        // and let's look at the current response body and see if we have some information we can give back to the listener
                        var content = await _response.Content.ReadAsStringAsync();

                        // drop the old response
                        _response?.Dispose();

                        // make the polling call
                        _response = await sender.SendAsync(request, eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }

                          // if we got back an OK, take a peek inside and see if it's done
                          if( _response.StatusCode == global::System.Net.HttpStatusCode.OK)
                          {
                              var error = false;
                              try {
                                  if( Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(await _response.Content.ReadAsStringAsync()) is Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonObject json)
                                  {
                                      var state = json.Property("properties")?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString>("provisioningState") ?? json.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString>("status");
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
                                  throw new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.UndeclaredResponseException(_response);
                              }
                          }

                        // check for terminal status code
                        if (_response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                        {
                            continue;
                        }
                        // we are done polling, do a request on final target?
                        // create a new request with the final uri
                        request = request.CloneAndDispose(new global::System.Uri(_finalUri), Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Get);

                        // drop the old response
                        _response?.Dispose();

                        // make the final call
                        _response = await sender.SendAsync(request,  eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                        break;
                    }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response);
                            break;
                        }
                        case global::System.Net.HttpStatusCode.NoContent:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onNoContent(_response);
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="DataProductsDelete" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="dataProductName">The data product resource name</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DataProductsDelete_Validate(string subscriptionId, string resourceGroupName, string dataProductName, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(subscriptionId),subscriptionId);
                await eventListener.AssertMinimumLength(nameof(subscriptionId),subscriptionId,1);
                await eventListener.AssertNotNull(nameof(resourceGroupName),resourceGroupName);
                await eventListener.AssertMinimumLength(nameof(resourceGroupName),resourceGroupName,1);
                await eventListener.AssertMaximumLength(nameof(resourceGroupName),resourceGroupName,90);
                await eventListener.AssertRegEx(nameof(resourceGroupName), resourceGroupName, @"^[-\w\._\(\)]+$");
                await eventListener.AssertNotNull(nameof(dataProductName),dataProductName);
                await eventListener.AssertMinimumLength(nameof(dataProductName),dataProductName,3);
                await eventListener.AssertMaximumLength(nameof(dataProductName),dataProductName,63);
                await eventListener.AssertRegEx(nameof(dataProductName), dataProductName, @"^[a-z][a-z0-9]*$");
            }
        }

        /// <summary>Generate sas token for storage account.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="dataProductName">The data product resource name</param>
        /// <param name="body">The content of the action request</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DataProductsGenerateStorageAccountSasToken(string subscriptionId, string resourceGroupName, string dataProductName, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IAccountSas body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IAccountSasToken>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts/"
                        + global::System.Uri.EscapeDataString(dataProductName)
                        + "/generateStorageAccountSasToken"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DataProductsGenerateStorageAccountSasToken_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>Generate sas token for storage account.</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="body">The content of the action request</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DataProductsGenerateStorageAccountSasTokenViaIdentity(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IAccountSas body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IAccountSasToken>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.NetworkAnalytics/dataProducts/(?<dataProductName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkAnalytics/dataProducts/{dataProductName}'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var dataProductName = _match.Groups["dataProductName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts/"
                        + dataProductName
                        + "/generateStorageAccountSasToken"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DataProductsGenerateStorageAccountSasToken_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>Generate sas token for storage account.</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="body">The content of the action request</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IAccountSasToken>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IAccountSasToken> DataProductsGenerateStorageAccountSasTokenViaIdentityWithResult(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IAccountSas body, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.NetworkAnalytics/dataProducts/(?<dataProductName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkAnalytics/dataProducts/{dataProductName}'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var dataProductName = _match.Groups["dataProductName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts/"
                        + dataProductName
                        + "/generateStorageAccountSasToken"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.DataProductsGenerateStorageAccountSasTokenWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>Generate sas token for storage account.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="dataProductName">The data product resource name</param>
        /// <param name="jsonString">Json string supplied to the DataProductsGenerateStorageAccountSasToken operation</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DataProductsGenerateStorageAccountSasTokenViaJsonString(string subscriptionId, string resourceGroupName, string dataProductName, global::System.String jsonString, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IAccountSasToken>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts/"
                        + global::System.Uri.EscapeDataString(dataProductName)
                        + "/generateStorageAccountSasToken"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(jsonString, global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DataProductsGenerateStorageAccountSasToken_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>Generate sas token for storage account.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="dataProductName">The data product resource name</param>
        /// <param name="jsonString">Json string supplied to the DataProductsGenerateStorageAccountSasToken operation</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IAccountSasToken>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IAccountSasToken> DataProductsGenerateStorageAccountSasTokenViaJsonStringWithResult(string subscriptionId, string resourceGroupName, string dataProductName, global::System.String jsonString, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts/"
                        + global::System.Uri.EscapeDataString(dataProductName)
                        + "/generateStorageAccountSasToken"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(jsonString, global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.DataProductsGenerateStorageAccountSasTokenWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>Generate sas token for storage account.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="dataProductName">The data product resource name</param>
        /// <param name="body">The content of the action request</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IAccountSasToken>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IAccountSasToken> DataProductsGenerateStorageAccountSasTokenWithResult(string subscriptionId, string resourceGroupName, string dataProductName, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IAccountSas body, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts/"
                        + global::System.Uri.EscapeDataString(dataProductName)
                        + "/generateStorageAccountSasToken"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.DataProductsGenerateStorageAccountSasTokenWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>
        /// Actual wire call for <see cref= "DataProductsGenerateStorageAccountSasTokenWithResult" /> method.
        /// </summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IAccountSasToken>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IAccountSasToken> DataProductsGenerateStorageAccountSasTokenWithResult_Call(global::System.Net.Http.HttpRequestMessage request, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.AccountSasToken.FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(body.Result)) );
                            return await _result;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(body.Result)) );
                            // Error Response : default
                            var code = (await _result)?.Code;
                            var message = (await _result)?.Message;
                            if ((null == code || null == message))
                            {
                                // Unrecognized Response. Create an error record based on what we have.
                                var ex = new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>(_response, await _result);
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
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Actual wire call for <see cref= "DataProductsGenerateStorageAccountSasToken" /> method.
        /// </summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DataProductsGenerateStorageAccountSasToken_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IAccountSasToken>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.AccountSasToken.FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="DataProductsGenerateStorageAccountSasToken" /> method. Call this like the actual call,
        /// but you will get validation events back.
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="dataProductName">The data product resource name</param>
        /// <param name="body">The content of the action request</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DataProductsGenerateStorageAccountSasToken_Validate(string subscriptionId, string resourceGroupName, string dataProductName, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IAccountSas body, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(subscriptionId),subscriptionId);
                await eventListener.AssertMinimumLength(nameof(subscriptionId),subscriptionId,1);
                await eventListener.AssertNotNull(nameof(resourceGroupName),resourceGroupName);
                await eventListener.AssertMinimumLength(nameof(resourceGroupName),resourceGroupName,1);
                await eventListener.AssertMaximumLength(nameof(resourceGroupName),resourceGroupName,90);
                await eventListener.AssertRegEx(nameof(resourceGroupName), resourceGroupName, @"^[-\w\._\(\)]+$");
                await eventListener.AssertNotNull(nameof(dataProductName),dataProductName);
                await eventListener.AssertMinimumLength(nameof(dataProductName),dataProductName,3);
                await eventListener.AssertMaximumLength(nameof(dataProductName),dataProductName,63);
                await eventListener.AssertRegEx(nameof(dataProductName), dataProductName, @"^[a-z][a-z0-9]*$");
                await eventListener.AssertNotNull(nameof(body), body);
                await eventListener.AssertObjectIsValid(nameof(body), body);
            }
        }

        /// <summary>Retrieve data product resource.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="dataProductName">The data product resource name</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DataProductsGet(string subscriptionId, string resourceGroupName, string dataProductName, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProduct>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts/"
                        + global::System.Uri.EscapeDataString(dataProductName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DataProductsGet_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>Retrieve data product resource.</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DataProductsGetViaIdentity(global::System.String viaIdentity, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProduct>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.NetworkAnalytics/dataProducts/(?<dataProductName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkAnalytics/dataProducts/{dataProductName}'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var dataProductName = _match.Groups["dataProductName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts/"
                        + dataProductName
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DataProductsGet_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>Retrieve data product resource.</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProduct>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProduct> DataProductsGetViaIdentityWithResult(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.NetworkAnalytics/dataProducts/(?<dataProductName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkAnalytics/dataProducts/{dataProductName}'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var dataProductName = _match.Groups["dataProductName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts/"
                        + dataProductName
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.DataProductsGetWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>Retrieve data product resource.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="dataProductName">The data product resource name</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProduct>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProduct> DataProductsGetWithResult(string subscriptionId, string resourceGroupName, string dataProductName, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts/"
                        + global::System.Uri.EscapeDataString(dataProductName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.DataProductsGetWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref= "DataProductsGetWithResult" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProduct>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProduct> DataProductsGetWithResult_Call(global::System.Net.Http.HttpRequestMessage request, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.DataProduct.FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(body.Result)) .ReadHeaders(_response.Headers));
                            return await _result;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(body.Result)) );
                            // Error Response : default
                            var code = (await _result)?.Code;
                            var message = (await _result)?.Message;
                            if ((null == code || null == message))
                            {
                                // Unrecognized Response. Create an error record based on what we have.
                                var ex = new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>(_response, await _result);
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
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>Actual wire call for <see cref= "DataProductsGet" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DataProductsGet_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProduct>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.DataProduct.FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(body.Result)) .ReadHeaders(_response.Headers)));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="DataProductsGet" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="dataProductName">The data product resource name</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DataProductsGet_Validate(string subscriptionId, string resourceGroupName, string dataProductName, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(subscriptionId),subscriptionId);
                await eventListener.AssertMinimumLength(nameof(subscriptionId),subscriptionId,1);
                await eventListener.AssertNotNull(nameof(resourceGroupName),resourceGroupName);
                await eventListener.AssertMinimumLength(nameof(resourceGroupName),resourceGroupName,1);
                await eventListener.AssertMaximumLength(nameof(resourceGroupName),resourceGroupName,90);
                await eventListener.AssertRegEx(nameof(resourceGroupName), resourceGroupName, @"^[-\w\._\(\)]+$");
                await eventListener.AssertNotNull(nameof(dataProductName),dataProductName);
                await eventListener.AssertMinimumLength(nameof(dataProductName),dataProductName,3);
                await eventListener.AssertMaximumLength(nameof(dataProductName),dataProductName,63);
                await eventListener.AssertRegEx(nameof(dataProductName), dataProductName, @"^[a-z][a-z0-9]*$");
            }
        }

        /// <summary>List data products by resource group.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DataProductsListByResourceGroup(string subscriptionId, string resourceGroupName, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductListResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DataProductsListByResourceGroup_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>List data products by resource group.</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DataProductsListByResourceGroupViaIdentity(global::System.String viaIdentity, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductListResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.NetworkAnalytics/dataProducts$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkAnalytics/dataProducts'");
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
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DataProductsListByResourceGroup_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>List data products by resource group.</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductListResult>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductListResult> DataProductsListByResourceGroupViaIdentityWithResult(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.NetworkAnalytics/dataProducts$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkAnalytics/dataProducts'");
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
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.DataProductsListByResourceGroupWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>List data products by resource group.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductListResult>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductListResult> DataProductsListByResourceGroupWithResult(string subscriptionId, string resourceGroupName, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.DataProductsListByResourceGroupWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>
        /// Actual wire call for <see cref= "DataProductsListByResourceGroupWithResult" /> method.
        /// </summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductListResult>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductListResult> DataProductsListByResourceGroupWithResult_Call(global::System.Net.Http.HttpRequestMessage request, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.DataProductListResult.FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(body.Result)) );
                            return await _result;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(body.Result)) );
                            // Error Response : default
                            var code = (await _result)?.Code;
                            var message = (await _result)?.Message;
                            if ((null == code || null == message))
                            {
                                // Unrecognized Response. Create an error record based on what we have.
                                var ex = new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>(_response, await _result);
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
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>Actual wire call for <see cref= "DataProductsListByResourceGroup" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DataProductsListByResourceGroup_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductListResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.DataProductListResult.FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="DataProductsListByResourceGroup" /> method. Call this like the actual call, but you will
        /// get validation events back.
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DataProductsListByResourceGroup_Validate(string subscriptionId, string resourceGroupName, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener)
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

        /// <summary>List data products by subscription.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DataProductsListBySubscription(string subscriptionId, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductListResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DataProductsListBySubscription_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>List data products by subscription.</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DataProductsListBySubscriptionViaIdentity(global::System.String viaIdentity, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductListResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/providers/Microsoft.NetworkAnalytics/dataProducts$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/providers/Microsoft.NetworkAnalytics/dataProducts'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DataProductsListBySubscription_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>List data products by subscription.</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductListResult>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductListResult> DataProductsListBySubscriptionViaIdentityWithResult(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/providers/Microsoft.NetworkAnalytics/dataProducts$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/providers/Microsoft.NetworkAnalytics/dataProducts'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.DataProductsListBySubscriptionWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>List data products by subscription.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductListResult>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductListResult> DataProductsListBySubscriptionWithResult(string subscriptionId, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.DataProductsListBySubscriptionWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>
        /// Actual wire call for <see cref= "DataProductsListBySubscriptionWithResult" /> method.
        /// </summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductListResult>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductListResult> DataProductsListBySubscriptionWithResult_Call(global::System.Net.Http.HttpRequestMessage request, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.DataProductListResult.FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(body.Result)) );
                            return await _result;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(body.Result)) );
                            // Error Response : default
                            var code = (await _result)?.Code;
                            var message = (await _result)?.Message;
                            if ((null == code || null == message))
                            {
                                // Unrecognized Response. Create an error record based on what we have.
                                var ex = new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>(_response, await _result);
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
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>Actual wire call for <see cref= "DataProductsListBySubscription" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DataProductsListBySubscription_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductListResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.DataProductListResult.FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="DataProductsListBySubscription" /> method. Call this like the actual call, but you will
        /// get validation events back.
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DataProductsListBySubscription_Validate(string subscriptionId, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(subscriptionId),subscriptionId);
                await eventListener.AssertMinimumLength(nameof(subscriptionId),subscriptionId,1);
            }
        }

        /// <summary>List user roles associated with the data product.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="dataProductName">The data product resource name</param>
        /// <param name="body">The content of the action request</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DataProductsListRolesAssignments(string subscriptionId, string resourceGroupName, string dataProductName, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IAny body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IListRoleAssignments>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts/"
                        + global::System.Uri.EscapeDataString(dataProductName)
                        + "/listRolesAssignments"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DataProductsListRolesAssignments_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>List user roles associated with the data product.</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="body">The content of the action request</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DataProductsListRolesAssignmentsViaIdentity(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IAny body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IListRoleAssignments>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.NetworkAnalytics/dataProducts/(?<dataProductName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkAnalytics/dataProducts/{dataProductName}'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var dataProductName = _match.Groups["dataProductName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts/"
                        + dataProductName
                        + "/listRolesAssignments"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DataProductsListRolesAssignments_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>List user roles associated with the data product.</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="body">The content of the action request</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IListRoleAssignments>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IListRoleAssignments> DataProductsListRolesAssignmentsViaIdentityWithResult(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IAny body, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.NetworkAnalytics/dataProducts/(?<dataProductName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkAnalytics/dataProducts/{dataProductName}'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var dataProductName = _match.Groups["dataProductName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts/"
                        + dataProductName
                        + "/listRolesAssignments"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.DataProductsListRolesAssignmentsWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>List user roles associated with the data product.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="dataProductName">The data product resource name</param>
        /// <param name="jsonString">Json string supplied to the DataProductsListRolesAssignments operation</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DataProductsListRolesAssignmentsViaJsonString(string subscriptionId, string resourceGroupName, string dataProductName, global::System.String jsonString, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IListRoleAssignments>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts/"
                        + global::System.Uri.EscapeDataString(dataProductName)
                        + "/listRolesAssignments"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(jsonString, global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DataProductsListRolesAssignments_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>List user roles associated with the data product.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="dataProductName">The data product resource name</param>
        /// <param name="jsonString">Json string supplied to the DataProductsListRolesAssignments operation</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IListRoleAssignments>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IListRoleAssignments> DataProductsListRolesAssignmentsViaJsonStringWithResult(string subscriptionId, string resourceGroupName, string dataProductName, global::System.String jsonString, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts/"
                        + global::System.Uri.EscapeDataString(dataProductName)
                        + "/listRolesAssignments"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(jsonString, global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.DataProductsListRolesAssignmentsWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>List user roles associated with the data product.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="dataProductName">The data product resource name</param>
        /// <param name="body">The content of the action request</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IListRoleAssignments>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IListRoleAssignments> DataProductsListRolesAssignmentsWithResult(string subscriptionId, string resourceGroupName, string dataProductName, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IAny body, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts/"
                        + global::System.Uri.EscapeDataString(dataProductName)
                        + "/listRolesAssignments"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.DataProductsListRolesAssignmentsWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>
        /// Actual wire call for <see cref= "DataProductsListRolesAssignmentsWithResult" /> method.
        /// </summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IListRoleAssignments>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IListRoleAssignments> DataProductsListRolesAssignmentsWithResult_Call(global::System.Net.Http.HttpRequestMessage request, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ListRoleAssignments.FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(body.Result)) );
                            return await _result;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(body.Result)) );
                            // Error Response : default
                            var code = (await _result)?.Code;
                            var message = (await _result)?.Message;
                            if ((null == code || null == message))
                            {
                                // Unrecognized Response. Create an error record based on what we have.
                                var ex = new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>(_response, await _result);
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
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>Actual wire call for <see cref= "DataProductsListRolesAssignments" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DataProductsListRolesAssignments_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IListRoleAssignments>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ListRoleAssignments.FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="DataProductsListRolesAssignments" /> method. Call this like the actual call, but you
        /// will get validation events back.
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="dataProductName">The data product resource name</param>
        /// <param name="body">The content of the action request</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DataProductsListRolesAssignments_Validate(string subscriptionId, string resourceGroupName, string dataProductName, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IAny body, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(subscriptionId),subscriptionId);
                await eventListener.AssertMinimumLength(nameof(subscriptionId),subscriptionId,1);
                await eventListener.AssertNotNull(nameof(resourceGroupName),resourceGroupName);
                await eventListener.AssertMinimumLength(nameof(resourceGroupName),resourceGroupName,1);
                await eventListener.AssertMaximumLength(nameof(resourceGroupName),resourceGroupName,90);
                await eventListener.AssertRegEx(nameof(resourceGroupName), resourceGroupName, @"^[-\w\._\(\)]+$");
                await eventListener.AssertNotNull(nameof(dataProductName),dataProductName);
                await eventListener.AssertMinimumLength(nameof(dataProductName),dataProductName,3);
                await eventListener.AssertMaximumLength(nameof(dataProductName),dataProductName,63);
                await eventListener.AssertRegEx(nameof(dataProductName), dataProductName, @"^[a-z][a-z0-9]*$");
                await eventListener.AssertNotNull(nameof(body), body);
                await eventListener.AssertObjectIsValid(nameof(body), body);
            }
        }

        /// <summary>Remove role from the data product.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="dataProductName">The data product resource name</param>
        /// <param name="body">The content of the action request</param>
        /// <param name="onNoContent">a delegate that is called when the remote service returns 204 (NoContent).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DataProductsRemoveUserRole(string subscriptionId, string resourceGroupName, string dataProductName, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IRoleAssignmentDetail body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onNoContent, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts/"
                        + global::System.Uri.EscapeDataString(dataProductName)
                        + "/removeUserRole"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DataProductsRemoveUserRole_Call (request, onNoContent,onDefault,eventListener,sender);
            }
        }

        /// <summary>Remove role from the data product.</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="body">The content of the action request</param>
        /// <param name="onNoContent">a delegate that is called when the remote service returns 204 (NoContent).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DataProductsRemoveUserRoleViaIdentity(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IRoleAssignmentDetail body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onNoContent, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.NetworkAnalytics/dataProducts/(?<dataProductName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkAnalytics/dataProducts/{dataProductName}'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var dataProductName = _match.Groups["dataProductName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts/"
                        + dataProductName
                        + "/removeUserRole"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DataProductsRemoveUserRole_Call (request, onNoContent,onDefault,eventListener,sender);
            }
        }

        /// <summary>Remove role from the data product.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="dataProductName">The data product resource name</param>
        /// <param name="jsonString">Json string supplied to the DataProductsRemoveUserRole operation</param>
        /// <param name="onNoContent">a delegate that is called when the remote service returns 204 (NoContent).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DataProductsRemoveUserRoleViaJsonString(string subscriptionId, string resourceGroupName, string dataProductName, global::System.String jsonString, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onNoContent, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts/"
                        + global::System.Uri.EscapeDataString(dataProductName)
                        + "/removeUserRole"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(jsonString, global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DataProductsRemoveUserRole_Call (request, onNoContent,onDefault,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref= "DataProductsRemoveUserRole" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onNoContent">a delegate that is called when the remote service returns 204 (NoContent).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DataProductsRemoveUserRole_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onNoContent, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.NoContent:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onNoContent(_response);
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="DataProductsRemoveUserRole" /> method. Call this like the actual call, but you will get
        /// validation events back.
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="dataProductName">The data product resource name</param>
        /// <param name="body">The content of the action request</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DataProductsRemoveUserRole_Validate(string subscriptionId, string resourceGroupName, string dataProductName, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IRoleAssignmentDetail body, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(subscriptionId),subscriptionId);
                await eventListener.AssertMinimumLength(nameof(subscriptionId),subscriptionId,1);
                await eventListener.AssertNotNull(nameof(resourceGroupName),resourceGroupName);
                await eventListener.AssertMinimumLength(nameof(resourceGroupName),resourceGroupName,1);
                await eventListener.AssertMaximumLength(nameof(resourceGroupName),resourceGroupName,90);
                await eventListener.AssertRegEx(nameof(resourceGroupName), resourceGroupName, @"^[-\w\._\(\)]+$");
                await eventListener.AssertNotNull(nameof(dataProductName),dataProductName);
                await eventListener.AssertMinimumLength(nameof(dataProductName),dataProductName,3);
                await eventListener.AssertMaximumLength(nameof(dataProductName),dataProductName,63);
                await eventListener.AssertRegEx(nameof(dataProductName), dataProductName, @"^[a-z][a-z0-9]*$");
                await eventListener.AssertNotNull(nameof(body), body);
                await eventListener.AssertObjectIsValid(nameof(body), body);
            }
        }

        /// <summary>Initiate key rotation on Data Product.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="dataProductName">The data product resource name</param>
        /// <param name="body">The content of the action request</param>
        /// <param name="onNoContent">a delegate that is called when the remote service returns 204 (NoContent).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DataProductsRotateKey(string subscriptionId, string resourceGroupName, string dataProductName, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IKeyVaultInfo body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onNoContent, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts/"
                        + global::System.Uri.EscapeDataString(dataProductName)
                        + "/rotateKey"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DataProductsRotateKey_Call (request, onNoContent,onDefault,eventListener,sender);
            }
        }

        /// <summary>Initiate key rotation on Data Product.</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="body">The content of the action request</param>
        /// <param name="onNoContent">a delegate that is called when the remote service returns 204 (NoContent).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DataProductsRotateKeyViaIdentity(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IKeyVaultInfo body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onNoContent, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.NetworkAnalytics/dataProducts/(?<dataProductName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkAnalytics/dataProducts/{dataProductName}'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var dataProductName = _match.Groups["dataProductName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts/"
                        + dataProductName
                        + "/rotateKey"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DataProductsRotateKey_Call (request, onNoContent,onDefault,eventListener,sender);
            }
        }

        /// <summary>Initiate key rotation on Data Product.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="dataProductName">The data product resource name</param>
        /// <param name="jsonString">Json string supplied to the DataProductsRotateKey operation</param>
        /// <param name="onNoContent">a delegate that is called when the remote service returns 204 (NoContent).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DataProductsRotateKeyViaJsonString(string subscriptionId, string resourceGroupName, string dataProductName, global::System.String jsonString, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onNoContent, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts/"
                        + global::System.Uri.EscapeDataString(dataProductName)
                        + "/rotateKey"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(jsonString, global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DataProductsRotateKey_Call (request, onNoContent,onDefault,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref= "DataProductsRotateKey" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onNoContent">a delegate that is called when the remote service returns 204 (NoContent).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DataProductsRotateKey_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onNoContent, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.NoContent:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onNoContent(_response);
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="DataProductsRotateKey" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="dataProductName">The data product resource name</param>
        /// <param name="body">The content of the action request</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DataProductsRotateKey_Validate(string subscriptionId, string resourceGroupName, string dataProductName, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IKeyVaultInfo body, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(subscriptionId),subscriptionId);
                await eventListener.AssertMinimumLength(nameof(subscriptionId),subscriptionId,1);
                await eventListener.AssertNotNull(nameof(resourceGroupName),resourceGroupName);
                await eventListener.AssertMinimumLength(nameof(resourceGroupName),resourceGroupName,1);
                await eventListener.AssertMaximumLength(nameof(resourceGroupName),resourceGroupName,90);
                await eventListener.AssertRegEx(nameof(resourceGroupName), resourceGroupName, @"^[-\w\._\(\)]+$");
                await eventListener.AssertNotNull(nameof(dataProductName),dataProductName);
                await eventListener.AssertMinimumLength(nameof(dataProductName),dataProductName,3);
                await eventListener.AssertMaximumLength(nameof(dataProductName),dataProductName,63);
                await eventListener.AssertRegEx(nameof(dataProductName), dataProductName, @"^[a-z][a-z0-9]*$");
                await eventListener.AssertNotNull(nameof(body), body);
                await eventListener.AssertObjectIsValid(nameof(body), body);
            }
        }

        /// <summary>Update data product resource.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="dataProductName">The data product resource name</param>
        /// <param name="body">The resource properties to be updated.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DataProductsUpdate(string subscriptionId, string resourceGroupName, string dataProductName, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductUpdate body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProduct>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts/"
                        + global::System.Uri.EscapeDataString(dataProductName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Patch, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DataProductsUpdate_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>Update data product resource.</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="body">The resource properties to be updated.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DataProductsUpdateViaIdentity(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductUpdate body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProduct>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.NetworkAnalytics/dataProducts/(?<dataProductName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkAnalytics/dataProducts/{dataProductName}'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var dataProductName = _match.Groups["dataProductName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts/"
                        + dataProductName
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Patch, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DataProductsUpdate_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>Update data product resource.</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="body">The resource properties to be updated.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProduct>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProduct> DataProductsUpdateViaIdentityWithResult(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductUpdate body, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.NetworkAnalytics/dataProducts/(?<dataProductName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkAnalytics/dataProducts/{dataProductName}'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var dataProductName = _match.Groups["dataProductName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts/"
                        + dataProductName
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Patch, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.DataProductsUpdateWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>Update data product resource.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="dataProductName">The data product resource name</param>
        /// <param name="jsonString">Json string supplied to the DataProductsUpdate operation</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DataProductsUpdateViaJsonString(string subscriptionId, string resourceGroupName, string dataProductName, global::System.String jsonString, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProduct>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts/"
                        + global::System.Uri.EscapeDataString(dataProductName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Patch, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(jsonString, global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DataProductsUpdate_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>Update data product resource.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="dataProductName">The data product resource name</param>
        /// <param name="jsonString">Json string supplied to the DataProductsUpdate operation</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProduct>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProduct> DataProductsUpdateViaJsonStringWithResult(string subscriptionId, string resourceGroupName, string dataProductName, global::System.String jsonString, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts/"
                        + global::System.Uri.EscapeDataString(dataProductName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Patch, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(jsonString, global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.DataProductsUpdateWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>Update data product resource.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="dataProductName">The data product resource name</param>
        /// <param name="body">The resource properties to be updated.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProduct>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProduct> DataProductsUpdateWithResult(string subscriptionId, string resourceGroupName, string dataProductName, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductUpdate body, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts/"
                        + global::System.Uri.EscapeDataString(dataProductName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Patch, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.DataProductsUpdateWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref= "DataProductsUpdateWithResult" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProduct>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProduct> DataProductsUpdateWithResult_Call(global::System.Net.Http.HttpRequestMessage request, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    // this operation supports x-ms-long-running-operation
                    var _originalUri = request.RequestUri.AbsoluteUri;
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Progress, "intentional placeholder", 0); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    // declared final-state-via: location
                    var _finalUri = _response.GetFirstHeader(@"Location");
                    var asyncOperation = _response.GetFirstHeader(@"Azure-AsyncOperation");
                    var location = _response.GetFirstHeader(@"Location");
                    var operationLocation = _response.GetFirstHeader(@"Operation-Location");
                    while (request.Method == System.Net.Http.HttpMethod.Put && _response.StatusCode == global::System.Net.HttpStatusCode.OK || _response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                    {
                        // delay before making the next polling request
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.DelayBeforePolling, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }

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
                        request = request.CloneAndDispose(new global::System.Uri(_uri), Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Get);

                        // and let's look at the current response body and see if we have some information we can give back to the listener
                        var content = await _response.Content.ReadAsStringAsync();

                        // drop the old response
                        _response?.Dispose();

                        // make the polling call
                        _response = await sender.SendAsync(request, eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }

                          // if we got back an OK, take a peek inside and see if it's done
                          if( _response.StatusCode == global::System.Net.HttpStatusCode.OK)
                          {
                              var error = false;
                              try {
                                  if( Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(await _response.Content.ReadAsStringAsync()) is Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonObject json)
                                  {
                                      var state = json.Property("properties")?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString>("provisioningState") ?? json.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString>("status");
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
                                  throw new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.UndeclaredResponseException(_response);
                              }
                          }

                        // check for terminal status code
                        if (_response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                        {
                            continue;
                        }
                        // we are done polling, do a request on final target?
                        // create a new request with the final uri
                        request = request.CloneAndDispose(new global::System.Uri(_finalUri), Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Get);

                        // drop the old response
                        _response?.Dispose();

                        // make the final call
                        _response = await sender.SendAsync(request,  eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                        break;
                    }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.DataProduct.FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(body.Result)) .ReadHeaders(_response.Headers));
                            return await _result;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(body.Result)) );
                            // Error Response : default
                            var code = (await _result)?.Code;
                            var message = (await _result)?.Message;
                            if ((null == code || null == message))
                            {
                                // Unrecognized Response. Create an error record based on what we have.
                                var ex = new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>(_response, await _result);
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
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>Actual wire call for <see cref= "DataProductsUpdate" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DataProductsUpdate_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProduct>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    // this operation supports x-ms-long-running-operation
                    var _originalUri = request.RequestUri.AbsoluteUri;
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Progress, "intentional placeholder", 0); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    // declared final-state-via: location
                    var _finalUri = _response.GetFirstHeader(@"Location");
                    var asyncOperation = _response.GetFirstHeader(@"Azure-AsyncOperation");
                    var location = _response.GetFirstHeader(@"Location");
                    var operationLocation = _response.GetFirstHeader(@"Operation-Location");
                    while (request.Method == System.Net.Http.HttpMethod.Put && _response.StatusCode == global::System.Net.HttpStatusCode.OK || _response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                    {
                        // delay before making the next polling request
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.DelayBeforePolling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }

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
                        request = request.CloneAndDispose(new global::System.Uri(_uri), Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Get);

                        // and let's look at the current response body and see if we have some information we can give back to the listener
                        var content = await _response.Content.ReadAsStringAsync();

                        // drop the old response
                        _response?.Dispose();

                        // make the polling call
                        _response = await sender.SendAsync(request, eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }

                          // if we got back an OK, take a peek inside and see if it's done
                          if( _response.StatusCode == global::System.Net.HttpStatusCode.OK)
                          {
                              var error = false;
                              try {
                                  if( Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(await _response.Content.ReadAsStringAsync()) is Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonObject json)
                                  {
                                      var state = json.Property("properties")?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString>("provisioningState") ?? json.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString>("status");
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
                                  throw new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.UndeclaredResponseException(_response);
                              }
                          }

                        // check for terminal status code
                        if (_response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                        {
                            continue;
                        }
                        // we are done polling, do a request on final target?
                        // create a new request with the final uri
                        request = request.CloneAndDispose(new global::System.Uri(_finalUri), Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Get);

                        // drop the old response
                        _response?.Dispose();

                        // make the final call
                        _response = await sender.SendAsync(request,  eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                        break;
                    }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.DataProduct.FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(body.Result)) .ReadHeaders(_response.Headers)));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="DataProductsUpdate" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="dataProductName">The data product resource name</param>
        /// <param name="body">The resource properties to be updated.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DataProductsUpdate_Validate(string subscriptionId, string resourceGroupName, string dataProductName, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductUpdate body, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(subscriptionId),subscriptionId);
                await eventListener.AssertMinimumLength(nameof(subscriptionId),subscriptionId,1);
                await eventListener.AssertNotNull(nameof(resourceGroupName),resourceGroupName);
                await eventListener.AssertMinimumLength(nameof(resourceGroupName),resourceGroupName,1);
                await eventListener.AssertMaximumLength(nameof(resourceGroupName),resourceGroupName,90);
                await eventListener.AssertRegEx(nameof(resourceGroupName), resourceGroupName, @"^[-\w\._\(\)]+$");
                await eventListener.AssertNotNull(nameof(dataProductName),dataProductName);
                await eventListener.AssertMinimumLength(nameof(dataProductName),dataProductName,3);
                await eventListener.AssertMaximumLength(nameof(dataProductName),dataProductName,63);
                await eventListener.AssertRegEx(nameof(dataProductName), dataProductName, @"^[a-z][a-z0-9]*$");
                await eventListener.AssertNotNull(nameof(body), body);
                await eventListener.AssertObjectIsValid(nameof(body), body);
            }
        }

        /// <summary>create data type resource.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="dataProductName">The data product resource name</param>
        /// <param name="dataTypeName">The data type name.</param>
        /// <param name="body">Resource create parameters.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DataTypesCreate(string subscriptionId, string resourceGroupName, string dataProductName, string dataTypeName, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataType body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataType>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts/"
                        + global::System.Uri.EscapeDataString(dataProductName)
                        + "/dataTypes/"
                        + global::System.Uri.EscapeDataString(dataTypeName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Put, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DataTypesCreate_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>create data type resource.</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="body">Resource create parameters.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DataTypesCreateViaIdentity(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataType body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataType>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.NetworkAnalytics/dataProducts/(?<dataProductName>[^/]+)/dataTypes/(?<dataTypeName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkAnalytics/dataProducts/{dataProductName}/dataTypes/{dataTypeName}'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var dataProductName = _match.Groups["dataProductName"].Value;
                var dataTypeName = _match.Groups["dataTypeName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts/"
                        + dataProductName
                        + "/dataTypes/"
                        + dataTypeName
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Put, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DataTypesCreate_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>create data type resource.</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="body">Resource create parameters.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataType>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataType> DataTypesCreateViaIdentityWithResult(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataType body, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.NetworkAnalytics/dataProducts/(?<dataProductName>[^/]+)/dataTypes/(?<dataTypeName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkAnalytics/dataProducts/{dataProductName}/dataTypes/{dataTypeName}'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var dataProductName = _match.Groups["dataProductName"].Value;
                var dataTypeName = _match.Groups["dataTypeName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts/"
                        + dataProductName
                        + "/dataTypes/"
                        + dataTypeName
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Put, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.DataTypesCreateWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>create data type resource.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="dataProductName">The data product resource name</param>
        /// <param name="dataTypeName">The data type name.</param>
        /// <param name="jsonString">Json string supplied to the DataTypesCreate operation</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DataTypesCreateViaJsonString(string subscriptionId, string resourceGroupName, string dataProductName, string dataTypeName, global::System.String jsonString, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataType>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts/"
                        + global::System.Uri.EscapeDataString(dataProductName)
                        + "/dataTypes/"
                        + global::System.Uri.EscapeDataString(dataTypeName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Put, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(jsonString, global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DataTypesCreate_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>create data type resource.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="dataProductName">The data product resource name</param>
        /// <param name="dataTypeName">The data type name.</param>
        /// <param name="jsonString">Json string supplied to the DataTypesCreate operation</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataType>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataType> DataTypesCreateViaJsonStringWithResult(string subscriptionId, string resourceGroupName, string dataProductName, string dataTypeName, global::System.String jsonString, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts/"
                        + global::System.Uri.EscapeDataString(dataProductName)
                        + "/dataTypes/"
                        + global::System.Uri.EscapeDataString(dataTypeName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Put, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(jsonString, global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.DataTypesCreateWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>create data type resource.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="dataProductName">The data product resource name</param>
        /// <param name="dataTypeName">The data type name.</param>
        /// <param name="body">Resource create parameters.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataType>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataType> DataTypesCreateWithResult(string subscriptionId, string resourceGroupName, string dataProductName, string dataTypeName, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataType body, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts/"
                        + global::System.Uri.EscapeDataString(dataProductName)
                        + "/dataTypes/"
                        + global::System.Uri.EscapeDataString(dataTypeName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Put, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.DataTypesCreateWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref= "DataTypesCreateWithResult" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataType>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataType> DataTypesCreateWithResult_Call(global::System.Net.Http.HttpRequestMessage request, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    // this operation supports x-ms-long-running-operation
                    var _originalUri = request.RequestUri.AbsoluteUri;
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Progress, "intentional placeholder", 0); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    // declared final-state-via: azure-async-operation
                    var asyncOperation = _response.GetFirstHeader(@"Azure-AsyncOperation");
                    var location = _response.GetFirstHeader(@"Location");
                    var operationLocation = _response.GetFirstHeader(@"Operation-Location");
                    while (request.Method == System.Net.Http.HttpMethod.Put && _response.StatusCode == global::System.Net.HttpStatusCode.OK || _response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                    {
                        // delay before making the next polling request
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.DelayBeforePolling, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }

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
                        request = request.CloneAndDispose(new global::System.Uri(_uri), Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Get);

                        // and let's look at the current response body and see if we have some information we can give back to the listener
                        var content = await _response.Content.ReadAsStringAsync();

                        // drop the old response
                        _response?.Dispose();

                        // make the polling call
                        _response = await sender.SendAsync(request, eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }

                          // if we got back an OK, take a peek inside and see if it's done
                          if( _response.StatusCode == global::System.Net.HttpStatusCode.OK)
                          {
                              var error = false;
                              try {
                                  if( Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(await _response.Content.ReadAsStringAsync()) is Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonObject json)
                                  {
                                      var state = json.Property("properties")?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString>("provisioningState") ?? json.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString>("status");
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
                                  throw new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.UndeclaredResponseException(_response);
                              }
                          }

                        // check for terminal status code
                        if (_response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                        {
                            continue;
                        }
                        // we are done polling, do a request on final target?
                        // create a new request with the final uri
                        request = request.CloneAndDispose(new global::System.Uri(_originalUri), Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Get);

                        // drop the old response
                        _response?.Dispose();

                        // make the final call
                        _response = await sender.SendAsync(request,  eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                        break;
                    }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.DataType.FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(body.Result)) .ReadHeaders(_response.Headers));
                            return await _result;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(body.Result)) );
                            // Error Response : default
                            var code = (await _result)?.Code;
                            var message = (await _result)?.Message;
                            if ((null == code || null == message))
                            {
                                // Unrecognized Response. Create an error record based on what we have.
                                var ex = new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>(_response, await _result);
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
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>Actual wire call for <see cref= "DataTypesCreate" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DataTypesCreate_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataType>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    // this operation supports x-ms-long-running-operation
                    var _originalUri = request.RequestUri.AbsoluteUri;
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Progress, "intentional placeholder", 0); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    // declared final-state-via: azure-async-operation
                    var asyncOperation = _response.GetFirstHeader(@"Azure-AsyncOperation");
                    var location = _response.GetFirstHeader(@"Location");
                    var operationLocation = _response.GetFirstHeader(@"Operation-Location");
                    while (request.Method == System.Net.Http.HttpMethod.Put && _response.StatusCode == global::System.Net.HttpStatusCode.OK || _response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                    {
                        // delay before making the next polling request
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.DelayBeforePolling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }

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
                        request = request.CloneAndDispose(new global::System.Uri(_uri), Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Get);

                        // and let's look at the current response body and see if we have some information we can give back to the listener
                        var content = await _response.Content.ReadAsStringAsync();

                        // drop the old response
                        _response?.Dispose();

                        // make the polling call
                        _response = await sender.SendAsync(request, eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }

                          // if we got back an OK, take a peek inside and see if it's done
                          if( _response.StatusCode == global::System.Net.HttpStatusCode.OK)
                          {
                              var error = false;
                              try {
                                  if( Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(await _response.Content.ReadAsStringAsync()) is Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonObject json)
                                  {
                                      var state = json.Property("properties")?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString>("provisioningState") ?? json.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString>("status");
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
                                  throw new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.UndeclaredResponseException(_response);
                              }
                          }

                        // check for terminal status code
                        if (_response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                        {
                            continue;
                        }
                        // we are done polling, do a request on final target?
                        // create a new request with the final uri
                        request = request.CloneAndDispose(new global::System.Uri(_originalUri), Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Get);

                        // drop the old response
                        _response?.Dispose();

                        // make the final call
                        _response = await sender.SendAsync(request,  eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                        break;
                    }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.DataType.FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(body.Result)) .ReadHeaders(_response.Headers)));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="DataTypesCreate" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="dataProductName">The data product resource name</param>
        /// <param name="dataTypeName">The data type name.</param>
        /// <param name="body">Resource create parameters.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DataTypesCreate_Validate(string subscriptionId, string resourceGroupName, string dataProductName, string dataTypeName, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataType body, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(subscriptionId),subscriptionId);
                await eventListener.AssertMinimumLength(nameof(subscriptionId),subscriptionId,1);
                await eventListener.AssertNotNull(nameof(resourceGroupName),resourceGroupName);
                await eventListener.AssertMinimumLength(nameof(resourceGroupName),resourceGroupName,1);
                await eventListener.AssertMaximumLength(nameof(resourceGroupName),resourceGroupName,90);
                await eventListener.AssertRegEx(nameof(resourceGroupName), resourceGroupName, @"^[-\w\._\(\)]+$");
                await eventListener.AssertNotNull(nameof(dataProductName),dataProductName);
                await eventListener.AssertMinimumLength(nameof(dataProductName),dataProductName,3);
                await eventListener.AssertMaximumLength(nameof(dataProductName),dataProductName,63);
                await eventListener.AssertRegEx(nameof(dataProductName), dataProductName, @"^[a-z][a-z0-9]*$");
                await eventListener.AssertNotNull(nameof(dataTypeName),dataTypeName);
                await eventListener.AssertMinimumLength(nameof(dataTypeName),dataTypeName,3);
                await eventListener.AssertMaximumLength(nameof(dataTypeName),dataTypeName,63);
                await eventListener.AssertRegEx(nameof(dataTypeName), dataTypeName, @"^[a-z][a-z0-9-]*$");
                await eventListener.AssertNotNull(nameof(body), body);
                await eventListener.AssertObjectIsValid(nameof(body), body);
            }
        }

        /// <summary>Delete data type resource.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="dataProductName">The data product resource name</param>
        /// <param name="dataTypeName">The data type name.</param>
        /// <param name="onNoContent">a delegate that is called when the remote service returns 204 (NoContent).</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DataTypesDelete(string subscriptionId, string resourceGroupName, string dataProductName, string dataTypeName, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onNoContent, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts/"
                        + global::System.Uri.EscapeDataString(dataProductName)
                        + "/dataTypes/"
                        + global::System.Uri.EscapeDataString(dataTypeName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Delete, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DataTypesDelete_Call (request, onNoContent,onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>Delete data for data type.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="dataProductName">The data product resource name</param>
        /// <param name="dataTypeName">The data type name.</param>
        /// <param name="body">The content of the action request</param>
        /// <param name="onNoContent">a delegate that is called when the remote service returns 204 (NoContent).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DataTypesDeleteData(string subscriptionId, string resourceGroupName, string dataProductName, string dataTypeName, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IAny body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onNoContent, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts/"
                        + global::System.Uri.EscapeDataString(dataProductName)
                        + "/dataTypes/"
                        + global::System.Uri.EscapeDataString(dataTypeName)
                        + "/deleteData"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DataTypesDeleteData_Call (request, onNoContent,onDefault,eventListener,sender);
            }
        }

        /// <summary>Delete data for data type.</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="body">The content of the action request</param>
        /// <param name="onNoContent">a delegate that is called when the remote service returns 204 (NoContent).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DataTypesDeleteDataViaIdentity(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IAny body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onNoContent, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.NetworkAnalytics/dataProducts/(?<dataProductName>[^/]+)/dataTypes/(?<dataTypeName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkAnalytics/dataProducts/{dataProductName}/dataTypes/{dataTypeName}'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var dataProductName = _match.Groups["dataProductName"].Value;
                var dataTypeName = _match.Groups["dataTypeName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts/"
                        + dataProductName
                        + "/dataTypes/"
                        + dataTypeName
                        + "/deleteData"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DataTypesDeleteData_Call (request, onNoContent,onDefault,eventListener,sender);
            }
        }

        /// <summary>Delete data for data type.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="dataProductName">The data product resource name</param>
        /// <param name="dataTypeName">The data type name.</param>
        /// <param name="jsonString">Json string supplied to the DataTypesDeleteData operation</param>
        /// <param name="onNoContent">a delegate that is called when the remote service returns 204 (NoContent).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DataTypesDeleteDataViaJsonString(string subscriptionId, string resourceGroupName, string dataProductName, string dataTypeName, global::System.String jsonString, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onNoContent, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts/"
                        + global::System.Uri.EscapeDataString(dataProductName)
                        + "/dataTypes/"
                        + global::System.Uri.EscapeDataString(dataTypeName)
                        + "/deleteData"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(jsonString, global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DataTypesDeleteData_Call (request, onNoContent,onDefault,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref= "DataTypesDeleteData" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onNoContent">a delegate that is called when the remote service returns 204 (NoContent).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DataTypesDeleteData_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onNoContent, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    // this operation supports x-ms-long-running-operation
                    var _originalUri = request.RequestUri.AbsoluteUri;
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Progress, "intentional placeholder", 0); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    // declared final-state-via: location
                    var _finalUri = _response.GetFirstHeader(@"Location");
                    var asyncOperation = _response.GetFirstHeader(@"Azure-AsyncOperation");
                    var location = _response.GetFirstHeader(@"Location");
                    var operationLocation = _response.GetFirstHeader(@"Operation-Location");
                    while (request.Method == System.Net.Http.HttpMethod.Put && _response.StatusCode == global::System.Net.HttpStatusCode.OK || _response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                    {
                        // delay before making the next polling request
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.DelayBeforePolling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }

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
                        request = request.CloneAndDispose(new global::System.Uri(_uri), Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Get);

                        // and let's look at the current response body and see if we have some information we can give back to the listener
                        var content = await _response.Content.ReadAsStringAsync();

                        // drop the old response
                        _response?.Dispose();

                        // make the polling call
                        _response = await sender.SendAsync(request, eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }

                          // if we got back an OK, take a peek inside and see if it's done
                          if( _response.StatusCode == global::System.Net.HttpStatusCode.OK)
                          {
                              var error = false;
                              try {
                                  if( Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(await _response.Content.ReadAsStringAsync()) is Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonObject json)
                                  {
                                      var state = json.Property("properties")?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString>("provisioningState") ?? json.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString>("status");
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
                                  throw new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.UndeclaredResponseException(_response);
                              }
                          }

                        // check for terminal status code
                        if (_response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                        {
                            continue;
                        }
                        // we are done polling, do a request on final target?
                        // create a new request with the final uri
                        request = request.CloneAndDispose(new global::System.Uri(_finalUri), Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Get);

                        // drop the old response
                        _response?.Dispose();

                        // make the final call
                        _response = await sender.SendAsync(request,  eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                        break;
                    }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.NoContent:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onNoContent(_response);
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="DataTypesDeleteData" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="dataProductName">The data product resource name</param>
        /// <param name="dataTypeName">The data type name.</param>
        /// <param name="body">The content of the action request</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DataTypesDeleteData_Validate(string subscriptionId, string resourceGroupName, string dataProductName, string dataTypeName, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IAny body, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(subscriptionId),subscriptionId);
                await eventListener.AssertMinimumLength(nameof(subscriptionId),subscriptionId,1);
                await eventListener.AssertNotNull(nameof(resourceGroupName),resourceGroupName);
                await eventListener.AssertMinimumLength(nameof(resourceGroupName),resourceGroupName,1);
                await eventListener.AssertMaximumLength(nameof(resourceGroupName),resourceGroupName,90);
                await eventListener.AssertRegEx(nameof(resourceGroupName), resourceGroupName, @"^[-\w\._\(\)]+$");
                await eventListener.AssertNotNull(nameof(dataProductName),dataProductName);
                await eventListener.AssertMinimumLength(nameof(dataProductName),dataProductName,3);
                await eventListener.AssertMaximumLength(nameof(dataProductName),dataProductName,63);
                await eventListener.AssertRegEx(nameof(dataProductName), dataProductName, @"^[a-z][a-z0-9]*$");
                await eventListener.AssertNotNull(nameof(dataTypeName),dataTypeName);
                await eventListener.AssertMinimumLength(nameof(dataTypeName),dataTypeName,3);
                await eventListener.AssertMaximumLength(nameof(dataTypeName),dataTypeName,63);
                await eventListener.AssertRegEx(nameof(dataTypeName), dataTypeName, @"^[a-z][a-z0-9-]*$");
                await eventListener.AssertNotNull(nameof(body), body);
                await eventListener.AssertObjectIsValid(nameof(body), body);
            }
        }

        /// <summary>Delete data type resource.</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="onNoContent">a delegate that is called when the remote service returns 204 (NoContent).</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DataTypesDeleteViaIdentity(global::System.String viaIdentity, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onNoContent, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.NetworkAnalytics/dataProducts/(?<dataProductName>[^/]+)/dataTypes/(?<dataTypeName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkAnalytics/dataProducts/{dataProductName}/dataTypes/{dataTypeName}'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var dataProductName = _match.Groups["dataProductName"].Value;
                var dataTypeName = _match.Groups["dataTypeName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts/"
                        + dataProductName
                        + "/dataTypes/"
                        + dataTypeName
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Delete, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DataTypesDelete_Call (request, onNoContent,onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref= "DataTypesDelete" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onNoContent">a delegate that is called when the remote service returns 204 (NoContent).</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DataTypesDelete_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onNoContent, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    // this operation supports x-ms-long-running-operation
                    var _originalUri = request.RequestUri.AbsoluteUri;
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Progress, "intentional placeholder", 0); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    // declared final-state-via: location
                    var _finalUri = _response.GetFirstHeader(@"Location");
                    var asyncOperation = _response.GetFirstHeader(@"Azure-AsyncOperation");
                    var location = _response.GetFirstHeader(@"Location");
                    var operationLocation = _response.GetFirstHeader(@"Operation-Location");
                    while (request.Method == System.Net.Http.HttpMethod.Put && _response.StatusCode == global::System.Net.HttpStatusCode.OK || _response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                    {
                        // delay before making the next polling request
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.DelayBeforePolling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }

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
                        request = request.CloneAndDispose(new global::System.Uri(_uri), Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Get);

                        // and let's look at the current response body and see if we have some information we can give back to the listener
                        var content = await _response.Content.ReadAsStringAsync();

                        // drop the old response
                        _response?.Dispose();

                        // make the polling call
                        _response = await sender.SendAsync(request, eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }

                          // if we got back an OK, take a peek inside and see if it's done
                          if( _response.StatusCode == global::System.Net.HttpStatusCode.OK)
                          {
                              var error = false;
                              try {
                                  if( Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(await _response.Content.ReadAsStringAsync()) is Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonObject json)
                                  {
                                      var state = json.Property("properties")?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString>("provisioningState") ?? json.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString>("status");
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
                                  throw new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.UndeclaredResponseException(_response);
                              }
                          }

                        // check for terminal status code
                        if (_response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                        {
                            continue;
                        }
                        // we are done polling, do a request on final target?
                        // create a new request with the final uri
                        request = request.CloneAndDispose(new global::System.Uri(_finalUri), Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Get);

                        // drop the old response
                        _response?.Dispose();

                        // make the final call
                        _response = await sender.SendAsync(request,  eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                        break;
                    }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response);
                            break;
                        }
                        case global::System.Net.HttpStatusCode.NoContent:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onNoContent(_response);
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="DataTypesDelete" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="dataProductName">The data product resource name</param>
        /// <param name="dataTypeName">The data type name.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DataTypesDelete_Validate(string subscriptionId, string resourceGroupName, string dataProductName, string dataTypeName, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(subscriptionId),subscriptionId);
                await eventListener.AssertMinimumLength(nameof(subscriptionId),subscriptionId,1);
                await eventListener.AssertNotNull(nameof(resourceGroupName),resourceGroupName);
                await eventListener.AssertMinimumLength(nameof(resourceGroupName),resourceGroupName,1);
                await eventListener.AssertMaximumLength(nameof(resourceGroupName),resourceGroupName,90);
                await eventListener.AssertRegEx(nameof(resourceGroupName), resourceGroupName, @"^[-\w\._\(\)]+$");
                await eventListener.AssertNotNull(nameof(dataProductName),dataProductName);
                await eventListener.AssertMinimumLength(nameof(dataProductName),dataProductName,3);
                await eventListener.AssertMaximumLength(nameof(dataProductName),dataProductName,63);
                await eventListener.AssertRegEx(nameof(dataProductName), dataProductName, @"^[a-z][a-z0-9]*$");
                await eventListener.AssertNotNull(nameof(dataTypeName),dataTypeName);
                await eventListener.AssertMinimumLength(nameof(dataTypeName),dataTypeName,3);
                await eventListener.AssertMaximumLength(nameof(dataTypeName),dataTypeName,63);
                await eventListener.AssertRegEx(nameof(dataTypeName), dataTypeName, @"^[a-z][a-z0-9-]*$");
            }
        }

        /// <summary>Generate sas token for storage container.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="dataProductName">The data product resource name</param>
        /// <param name="dataTypeName">The data type name.</param>
        /// <param name="body">The content of the action request</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DataTypesGenerateStorageContainerSasToken(string subscriptionId, string resourceGroupName, string dataProductName, string dataTypeName, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IContainerSaS body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IContainerSasToken>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts/"
                        + global::System.Uri.EscapeDataString(dataProductName)
                        + "/dataTypes/"
                        + global::System.Uri.EscapeDataString(dataTypeName)
                        + "/generateStorageContainerSasToken"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DataTypesGenerateStorageContainerSasToken_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>Generate sas token for storage container.</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="body">The content of the action request</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DataTypesGenerateStorageContainerSasTokenViaIdentity(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IContainerSaS body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IContainerSasToken>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.NetworkAnalytics/dataProducts/(?<dataProductName>[^/]+)/dataTypes/(?<dataTypeName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkAnalytics/dataProducts/{dataProductName}/dataTypes/{dataTypeName}'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var dataProductName = _match.Groups["dataProductName"].Value;
                var dataTypeName = _match.Groups["dataTypeName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts/"
                        + dataProductName
                        + "/dataTypes/"
                        + dataTypeName
                        + "/generateStorageContainerSasToken"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DataTypesGenerateStorageContainerSasToken_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>Generate sas token for storage container.</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="body">The content of the action request</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IContainerSasToken>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IContainerSasToken> DataTypesGenerateStorageContainerSasTokenViaIdentityWithResult(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IContainerSaS body, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.NetworkAnalytics/dataProducts/(?<dataProductName>[^/]+)/dataTypes/(?<dataTypeName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkAnalytics/dataProducts/{dataProductName}/dataTypes/{dataTypeName}'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var dataProductName = _match.Groups["dataProductName"].Value;
                var dataTypeName = _match.Groups["dataTypeName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts/"
                        + dataProductName
                        + "/dataTypes/"
                        + dataTypeName
                        + "/generateStorageContainerSasToken"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.DataTypesGenerateStorageContainerSasTokenWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>Generate sas token for storage container.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="dataProductName">The data product resource name</param>
        /// <param name="dataTypeName">The data type name.</param>
        /// <param name="jsonString">Json string supplied to the DataTypesGenerateStorageContainerSasToken operation</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DataTypesGenerateStorageContainerSasTokenViaJsonString(string subscriptionId, string resourceGroupName, string dataProductName, string dataTypeName, global::System.String jsonString, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IContainerSasToken>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts/"
                        + global::System.Uri.EscapeDataString(dataProductName)
                        + "/dataTypes/"
                        + global::System.Uri.EscapeDataString(dataTypeName)
                        + "/generateStorageContainerSasToken"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(jsonString, global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DataTypesGenerateStorageContainerSasToken_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>Generate sas token for storage container.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="dataProductName">The data product resource name</param>
        /// <param name="dataTypeName">The data type name.</param>
        /// <param name="jsonString">Json string supplied to the DataTypesGenerateStorageContainerSasToken operation</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IContainerSasToken>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IContainerSasToken> DataTypesGenerateStorageContainerSasTokenViaJsonStringWithResult(string subscriptionId, string resourceGroupName, string dataProductName, string dataTypeName, global::System.String jsonString, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts/"
                        + global::System.Uri.EscapeDataString(dataProductName)
                        + "/dataTypes/"
                        + global::System.Uri.EscapeDataString(dataTypeName)
                        + "/generateStorageContainerSasToken"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(jsonString, global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.DataTypesGenerateStorageContainerSasTokenWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>Generate sas token for storage container.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="dataProductName">The data product resource name</param>
        /// <param name="dataTypeName">The data type name.</param>
        /// <param name="body">The content of the action request</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IContainerSasToken>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IContainerSasToken> DataTypesGenerateStorageContainerSasTokenWithResult(string subscriptionId, string resourceGroupName, string dataProductName, string dataTypeName, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IContainerSaS body, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts/"
                        + global::System.Uri.EscapeDataString(dataProductName)
                        + "/dataTypes/"
                        + global::System.Uri.EscapeDataString(dataTypeName)
                        + "/generateStorageContainerSasToken"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.DataTypesGenerateStorageContainerSasTokenWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>
        /// Actual wire call for <see cref= "DataTypesGenerateStorageContainerSasTokenWithResult" /> method.
        /// </summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IContainerSasToken>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IContainerSasToken> DataTypesGenerateStorageContainerSasTokenWithResult_Call(global::System.Net.Http.HttpRequestMessage request, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ContainerSasToken.FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(body.Result)) );
                            return await _result;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(body.Result)) );
                            // Error Response : default
                            var code = (await _result)?.Code;
                            var message = (await _result)?.Message;
                            if ((null == code || null == message))
                            {
                                // Unrecognized Response. Create an error record based on what we have.
                                var ex = new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>(_response, await _result);
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
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Actual wire call for <see cref= "DataTypesGenerateStorageContainerSasToken" /> method.
        /// </summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DataTypesGenerateStorageContainerSasToken_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IContainerSasToken>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ContainerSasToken.FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="DataTypesGenerateStorageContainerSasToken" /> method. Call this like the actual call,
        /// but you will get validation events back.
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="dataProductName">The data product resource name</param>
        /// <param name="dataTypeName">The data type name.</param>
        /// <param name="body">The content of the action request</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DataTypesGenerateStorageContainerSasToken_Validate(string subscriptionId, string resourceGroupName, string dataProductName, string dataTypeName, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IContainerSaS body, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(subscriptionId),subscriptionId);
                await eventListener.AssertMinimumLength(nameof(subscriptionId),subscriptionId,1);
                await eventListener.AssertNotNull(nameof(resourceGroupName),resourceGroupName);
                await eventListener.AssertMinimumLength(nameof(resourceGroupName),resourceGroupName,1);
                await eventListener.AssertMaximumLength(nameof(resourceGroupName),resourceGroupName,90);
                await eventListener.AssertRegEx(nameof(resourceGroupName), resourceGroupName, @"^[-\w\._\(\)]+$");
                await eventListener.AssertNotNull(nameof(dataProductName),dataProductName);
                await eventListener.AssertMinimumLength(nameof(dataProductName),dataProductName,3);
                await eventListener.AssertMaximumLength(nameof(dataProductName),dataProductName,63);
                await eventListener.AssertRegEx(nameof(dataProductName), dataProductName, @"^[a-z][a-z0-9]*$");
                await eventListener.AssertNotNull(nameof(dataTypeName),dataTypeName);
                await eventListener.AssertMinimumLength(nameof(dataTypeName),dataTypeName,3);
                await eventListener.AssertMaximumLength(nameof(dataTypeName),dataTypeName,63);
                await eventListener.AssertRegEx(nameof(dataTypeName), dataTypeName, @"^[a-z][a-z0-9-]*$");
                await eventListener.AssertNotNull(nameof(body), body);
                await eventListener.AssertObjectIsValid(nameof(body), body);
            }
        }

        /// <summary>Retrieve data type resource.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="dataProductName">The data product resource name</param>
        /// <param name="dataTypeName">The data type name.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DataTypesGet(string subscriptionId, string resourceGroupName, string dataProductName, string dataTypeName, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataType>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts/"
                        + global::System.Uri.EscapeDataString(dataProductName)
                        + "/dataTypes/"
                        + global::System.Uri.EscapeDataString(dataTypeName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DataTypesGet_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>Retrieve data type resource.</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DataTypesGetViaIdentity(global::System.String viaIdentity, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataType>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.NetworkAnalytics/dataProducts/(?<dataProductName>[^/]+)/dataTypes/(?<dataTypeName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkAnalytics/dataProducts/{dataProductName}/dataTypes/{dataTypeName}'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var dataProductName = _match.Groups["dataProductName"].Value;
                var dataTypeName = _match.Groups["dataTypeName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts/"
                        + dataProductName
                        + "/dataTypes/"
                        + dataTypeName
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DataTypesGet_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>Retrieve data type resource.</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataType>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataType> DataTypesGetViaIdentityWithResult(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.NetworkAnalytics/dataProducts/(?<dataProductName>[^/]+)/dataTypes/(?<dataTypeName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkAnalytics/dataProducts/{dataProductName}/dataTypes/{dataTypeName}'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var dataProductName = _match.Groups["dataProductName"].Value;
                var dataTypeName = _match.Groups["dataTypeName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts/"
                        + dataProductName
                        + "/dataTypes/"
                        + dataTypeName
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.DataTypesGetWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>Retrieve data type resource.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="dataProductName">The data product resource name</param>
        /// <param name="dataTypeName">The data type name.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataType>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataType> DataTypesGetWithResult(string subscriptionId, string resourceGroupName, string dataProductName, string dataTypeName, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts/"
                        + global::System.Uri.EscapeDataString(dataProductName)
                        + "/dataTypes/"
                        + global::System.Uri.EscapeDataString(dataTypeName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.DataTypesGetWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref= "DataTypesGetWithResult" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataType>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataType> DataTypesGetWithResult_Call(global::System.Net.Http.HttpRequestMessage request, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.DataType.FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(body.Result)) .ReadHeaders(_response.Headers));
                            return await _result;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(body.Result)) );
                            // Error Response : default
                            var code = (await _result)?.Code;
                            var message = (await _result)?.Message;
                            if ((null == code || null == message))
                            {
                                // Unrecognized Response. Create an error record based on what we have.
                                var ex = new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>(_response, await _result);
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
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>Actual wire call for <see cref= "DataTypesGet" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DataTypesGet_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataType>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.DataType.FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(body.Result)) .ReadHeaders(_response.Headers)));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="DataTypesGet" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="dataProductName">The data product resource name</param>
        /// <param name="dataTypeName">The data type name.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DataTypesGet_Validate(string subscriptionId, string resourceGroupName, string dataProductName, string dataTypeName, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(subscriptionId),subscriptionId);
                await eventListener.AssertMinimumLength(nameof(subscriptionId),subscriptionId,1);
                await eventListener.AssertNotNull(nameof(resourceGroupName),resourceGroupName);
                await eventListener.AssertMinimumLength(nameof(resourceGroupName),resourceGroupName,1);
                await eventListener.AssertMaximumLength(nameof(resourceGroupName),resourceGroupName,90);
                await eventListener.AssertRegEx(nameof(resourceGroupName), resourceGroupName, @"^[-\w\._\(\)]+$");
                await eventListener.AssertNotNull(nameof(dataProductName),dataProductName);
                await eventListener.AssertMinimumLength(nameof(dataProductName),dataProductName,3);
                await eventListener.AssertMaximumLength(nameof(dataProductName),dataProductName,63);
                await eventListener.AssertRegEx(nameof(dataProductName), dataProductName, @"^[a-z][a-z0-9]*$");
                await eventListener.AssertNotNull(nameof(dataTypeName),dataTypeName);
                await eventListener.AssertMinimumLength(nameof(dataTypeName),dataTypeName,3);
                await eventListener.AssertMaximumLength(nameof(dataTypeName),dataTypeName,63);
                await eventListener.AssertRegEx(nameof(dataTypeName), dataTypeName, @"^[a-z][a-z0-9-]*$");
            }
        }

        /// <summary>List data type by parent resource.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="dataProductName">The data product resource name</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DataTypesListByDataProduct(string subscriptionId, string resourceGroupName, string dataProductName, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataTypeListResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts/"
                        + global::System.Uri.EscapeDataString(dataProductName)
                        + "/dataTypes"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DataTypesListByDataProduct_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>List data type by parent resource.</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DataTypesListByDataProductViaIdentity(global::System.String viaIdentity, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataTypeListResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.NetworkAnalytics/dataProducts/(?<dataProductName>[^/]+)/dataTypes$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkAnalytics/dataProducts/{dataProductName}/dataTypes'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var dataProductName = _match.Groups["dataProductName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts/"
                        + dataProductName
                        + "/dataTypes"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DataTypesListByDataProduct_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>List data type by parent resource.</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataTypeListResult>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataTypeListResult> DataTypesListByDataProductViaIdentityWithResult(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.NetworkAnalytics/dataProducts/(?<dataProductName>[^/]+)/dataTypes$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkAnalytics/dataProducts/{dataProductName}/dataTypes'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var dataProductName = _match.Groups["dataProductName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts/"
                        + dataProductName
                        + "/dataTypes"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.DataTypesListByDataProductWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>List data type by parent resource.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="dataProductName">The data product resource name</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataTypeListResult>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataTypeListResult> DataTypesListByDataProductWithResult(string subscriptionId, string resourceGroupName, string dataProductName, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts/"
                        + global::System.Uri.EscapeDataString(dataProductName)
                        + "/dataTypes"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.DataTypesListByDataProductWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>
        /// Actual wire call for <see cref= "DataTypesListByDataProductWithResult" /> method.
        /// </summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataTypeListResult>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataTypeListResult> DataTypesListByDataProductWithResult_Call(global::System.Net.Http.HttpRequestMessage request, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.DataTypeListResult.FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(body.Result)) );
                            return await _result;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(body.Result)) );
                            // Error Response : default
                            var code = (await _result)?.Code;
                            var message = (await _result)?.Message;
                            if ((null == code || null == message))
                            {
                                // Unrecognized Response. Create an error record based on what we have.
                                var ex = new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>(_response, await _result);
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
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>Actual wire call for <see cref= "DataTypesListByDataProduct" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DataTypesListByDataProduct_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataTypeListResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.DataTypeListResult.FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="DataTypesListByDataProduct" /> method. Call this like the actual call, but you will get
        /// validation events back.
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="dataProductName">The data product resource name</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DataTypesListByDataProduct_Validate(string subscriptionId, string resourceGroupName, string dataProductName, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(subscriptionId),subscriptionId);
                await eventListener.AssertMinimumLength(nameof(subscriptionId),subscriptionId,1);
                await eventListener.AssertNotNull(nameof(resourceGroupName),resourceGroupName);
                await eventListener.AssertMinimumLength(nameof(resourceGroupName),resourceGroupName,1);
                await eventListener.AssertMaximumLength(nameof(resourceGroupName),resourceGroupName,90);
                await eventListener.AssertRegEx(nameof(resourceGroupName), resourceGroupName, @"^[-\w\._\(\)]+$");
                await eventListener.AssertNotNull(nameof(dataProductName),dataProductName);
                await eventListener.AssertMinimumLength(nameof(dataProductName),dataProductName,3);
                await eventListener.AssertMaximumLength(nameof(dataProductName),dataProductName,63);
                await eventListener.AssertRegEx(nameof(dataProductName), dataProductName, @"^[a-z][a-z0-9]*$");
            }
        }

        /// <summary>update data type resource.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="dataProductName">The data product resource name</param>
        /// <param name="dataTypeName">The data type name.</param>
        /// <param name="body">The resource properties to be updated.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DataTypesUpdate(string subscriptionId, string resourceGroupName, string dataProductName, string dataTypeName, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataTypeUpdate body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataType>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts/"
                        + global::System.Uri.EscapeDataString(dataProductName)
                        + "/dataTypes/"
                        + global::System.Uri.EscapeDataString(dataTypeName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Patch, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DataTypesUpdate_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>update data type resource.</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="body">The resource properties to be updated.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DataTypesUpdateViaIdentity(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataTypeUpdate body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataType>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.NetworkAnalytics/dataProducts/(?<dataProductName>[^/]+)/dataTypes/(?<dataTypeName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkAnalytics/dataProducts/{dataProductName}/dataTypes/{dataTypeName}'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var dataProductName = _match.Groups["dataProductName"].Value;
                var dataTypeName = _match.Groups["dataTypeName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts/"
                        + dataProductName
                        + "/dataTypes/"
                        + dataTypeName
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Patch, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DataTypesUpdate_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>update data type resource.</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="body">The resource properties to be updated.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataType>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataType> DataTypesUpdateViaIdentityWithResult(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataTypeUpdate body, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.NetworkAnalytics/dataProducts/(?<dataProductName>[^/]+)/dataTypes/(?<dataTypeName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkAnalytics/dataProducts/{dataProductName}/dataTypes/{dataTypeName}'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var dataProductName = _match.Groups["dataProductName"].Value;
                var dataTypeName = _match.Groups["dataTypeName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts/"
                        + dataProductName
                        + "/dataTypes/"
                        + dataTypeName
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Patch, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.DataTypesUpdateWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>update data type resource.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="dataProductName">The data product resource name</param>
        /// <param name="dataTypeName">The data type name.</param>
        /// <param name="jsonString">Json string supplied to the DataTypesUpdate operation</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DataTypesUpdateViaJsonString(string subscriptionId, string resourceGroupName, string dataProductName, string dataTypeName, global::System.String jsonString, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataType>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts/"
                        + global::System.Uri.EscapeDataString(dataProductName)
                        + "/dataTypes/"
                        + global::System.Uri.EscapeDataString(dataTypeName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Patch, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(jsonString, global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.DataTypesUpdate_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>update data type resource.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="dataProductName">The data product resource name</param>
        /// <param name="dataTypeName">The data type name.</param>
        /// <param name="jsonString">Json string supplied to the DataTypesUpdate operation</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataType>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataType> DataTypesUpdateViaJsonStringWithResult(string subscriptionId, string resourceGroupName, string dataProductName, string dataTypeName, global::System.String jsonString, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts/"
                        + global::System.Uri.EscapeDataString(dataProductName)
                        + "/dataTypes/"
                        + global::System.Uri.EscapeDataString(dataTypeName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Patch, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(jsonString, global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.DataTypesUpdateWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>update data type resource.</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="dataProductName">The data product resource name</param>
        /// <param name="dataTypeName">The data type name.</param>
        /// <param name="body">The resource properties to be updated.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataType>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataType> DataTypesUpdateWithResult(string subscriptionId, string resourceGroupName, string dataProductName, string dataTypeName, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataTypeUpdate body, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.NetworkAnalytics/dataProducts/"
                        + global::System.Uri.EscapeDataString(dataProductName)
                        + "/dataTypes/"
                        + global::System.Uri.EscapeDataString(dataTypeName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Patch, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.DataTypesUpdateWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref= "DataTypesUpdateWithResult" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataType>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataType> DataTypesUpdateWithResult_Call(global::System.Net.Http.HttpRequestMessage request, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    // this operation supports x-ms-long-running-operation
                    var _originalUri = request.RequestUri.AbsoluteUri;
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Progress, "intentional placeholder", 0); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    // declared final-state-via: location
                    var _finalUri = _response.GetFirstHeader(@"Location");
                    var asyncOperation = _response.GetFirstHeader(@"Azure-AsyncOperation");
                    var location = _response.GetFirstHeader(@"Location");
                    var operationLocation = _response.GetFirstHeader(@"Operation-Location");
                    while (request.Method == System.Net.Http.HttpMethod.Put && _response.StatusCode == global::System.Net.HttpStatusCode.OK || _response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                    {
                        // delay before making the next polling request
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.DelayBeforePolling, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }

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
                        request = request.CloneAndDispose(new global::System.Uri(_uri), Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Get);

                        // and let's look at the current response body and see if we have some information we can give back to the listener
                        var content = await _response.Content.ReadAsStringAsync();

                        // drop the old response
                        _response?.Dispose();

                        // make the polling call
                        _response = await sender.SendAsync(request, eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }

                          // if we got back an OK, take a peek inside and see if it's done
                          if( _response.StatusCode == global::System.Net.HttpStatusCode.OK)
                          {
                              var error = false;
                              try {
                                  if( Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(await _response.Content.ReadAsStringAsync()) is Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonObject json)
                                  {
                                      var state = json.Property("properties")?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString>("provisioningState") ?? json.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString>("status");
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
                                  throw new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.UndeclaredResponseException(_response);
                              }
                          }

                        // check for terminal status code
                        if (_response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                        {
                            continue;
                        }
                        // we are done polling, do a request on final target?
                        // create a new request with the final uri
                        request = request.CloneAndDispose(new global::System.Uri(_finalUri), Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Get);

                        // drop the old response
                        _response?.Dispose();

                        // make the final call
                        _response = await sender.SendAsync(request,  eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                        break;
                    }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.DataType.FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(body.Result)) .ReadHeaders(_response.Headers));
                            return await _result;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(body.Result)) );
                            // Error Response : default
                            var code = (await _result)?.Code;
                            var message = (await _result)?.Message;
                            if ((null == code || null == message))
                            {
                                // Unrecognized Response. Create an error record based on what we have.
                                var ex = new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>(_response, await _result);
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
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>Actual wire call for <see cref= "DataTypesUpdate" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DataTypesUpdate_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataType>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    // this operation supports x-ms-long-running-operation
                    var _originalUri = request.RequestUri.AbsoluteUri;
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Progress, "intentional placeholder", 0); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    // declared final-state-via: location
                    var _finalUri = _response.GetFirstHeader(@"Location");
                    var asyncOperation = _response.GetFirstHeader(@"Azure-AsyncOperation");
                    var location = _response.GetFirstHeader(@"Location");
                    var operationLocation = _response.GetFirstHeader(@"Operation-Location");
                    while (request.Method == System.Net.Http.HttpMethod.Put && _response.StatusCode == global::System.Net.HttpStatusCode.OK || _response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                    {
                        // delay before making the next polling request
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.DelayBeforePolling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }

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
                        request = request.CloneAndDispose(new global::System.Uri(_uri), Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Get);

                        // and let's look at the current response body and see if we have some information we can give back to the listener
                        var content = await _response.Content.ReadAsStringAsync();

                        // drop the old response
                        _response?.Dispose();

                        // make the polling call
                        _response = await sender.SendAsync(request, eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }

                          // if we got back an OK, take a peek inside and see if it's done
                          if( _response.StatusCode == global::System.Net.HttpStatusCode.OK)
                          {
                              var error = false;
                              try {
                                  if( Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(await _response.Content.ReadAsStringAsync()) is Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonObject json)
                                  {
                                      var state = json.Property("properties")?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString>("provisioningState") ?? json.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString>("status");
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
                                  throw new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.UndeclaredResponseException(_response);
                              }
                          }

                        // check for terminal status code
                        if (_response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                        {
                            continue;
                        }
                        // we are done polling, do a request on final target?
                        // create a new request with the final uri
                        request = request.CloneAndDispose(new global::System.Uri(_finalUri), Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Get);

                        // drop the old response
                        _response?.Dispose();

                        // make the final call
                        _response = await sender.SendAsync(request,  eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                        break;
                    }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.DataType.FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(body.Result)) .ReadHeaders(_response.Headers)));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="DataTypesUpdate" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="dataProductName">The data product resource name</param>
        /// <param name="dataTypeName">The data type name.</param>
        /// <param name="body">The resource properties to be updated.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DataTypesUpdate_Validate(string subscriptionId, string resourceGroupName, string dataProductName, string dataTypeName, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataTypeUpdate body, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(subscriptionId),subscriptionId);
                await eventListener.AssertMinimumLength(nameof(subscriptionId),subscriptionId,1);
                await eventListener.AssertNotNull(nameof(resourceGroupName),resourceGroupName);
                await eventListener.AssertMinimumLength(nameof(resourceGroupName),resourceGroupName,1);
                await eventListener.AssertMaximumLength(nameof(resourceGroupName),resourceGroupName,90);
                await eventListener.AssertRegEx(nameof(resourceGroupName), resourceGroupName, @"^[-\w\._\(\)]+$");
                await eventListener.AssertNotNull(nameof(dataProductName),dataProductName);
                await eventListener.AssertMinimumLength(nameof(dataProductName),dataProductName,3);
                await eventListener.AssertMaximumLength(nameof(dataProductName),dataProductName,63);
                await eventListener.AssertRegEx(nameof(dataProductName), dataProductName, @"^[a-z][a-z0-9]*$");
                await eventListener.AssertNotNull(nameof(dataTypeName),dataTypeName);
                await eventListener.AssertMinimumLength(nameof(dataTypeName),dataTypeName,3);
                await eventListener.AssertMaximumLength(nameof(dataTypeName),dataTypeName,63);
                await eventListener.AssertRegEx(nameof(dataTypeName), dataTypeName, @"^[a-z][a-z0-9-]*$");
                await eventListener.AssertNotNull(nameof(body), body);
                await eventListener.AssertObjectIsValid(nameof(body), body);
            }
        }

        /// <summary>List the operations for the provider</summary>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task OperationsList(global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IOperationListResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/providers/Microsoft.NetworkAnalytics/operations"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.OperationsList_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>List the operations for the provider</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task OperationsListViaIdentity(global::System.String viaIdentity, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IOperationListResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/providers/Microsoft.NetworkAnalytics/operations$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/providers/Microsoft.NetworkAnalytics/operations'");
                }

                // replace URI parameters with values from identity
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/providers/Microsoft.NetworkAnalytics/operations"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.OperationsList_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>List the operations for the provider</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IOperationListResult>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IOperationListResult> OperationsListViaIdentityWithResult(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/providers/Microsoft.NetworkAnalytics/operations$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/providers/Microsoft.NetworkAnalytics/operations'");
                }

                // replace URI parameters with values from identity
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/providers/Microsoft.NetworkAnalytics/operations"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.OperationsListWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>List the operations for the provider</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IOperationListResult>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IOperationListResult> OperationsListWithResult(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2023-11-15";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/providers/Microsoft.NetworkAnalytics/operations"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.OperationsListWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref= "OperationsListWithResult" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IOperationListResult>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IOperationListResult> OperationsListWithResult_Call(global::System.Net.Http.HttpRequestMessage request, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.OperationListResult.FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(body.Result)) );
                            return await _result;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(body.Result)) );
                            // Error Response : default
                            var code = (await _result)?.Code;
                            var message = (await _result)?.Message;
                            if ((null == code || null == message))
                            {
                                // Unrecognized Response. Create an error record based on what we have.
                                var ex = new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>(_response, await _result);
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
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Finally, request, _response);
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
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task OperationsList_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IOperationListResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.OperationListResult.FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="OperationsList" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task OperationsList_Validate(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {

            }
        }
    }
}