// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Cmdlets
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Extensions;
    using Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.PowerShell;
    using Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Cmdlets;
    using System;

    /// <summary>update data product resource.</summary>
    /// <remarks>
    /// [OpenAPI] Get=>GET:"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkAnalytics/dataProducts/{dataProductName}"
    /// [OpenAPI] Create=>PUT:"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkAnalytics/dataProducts/{dataProductName}"
    /// </remarks>
    [global::System.Management.Automation.Cmdlet(global::System.Management.Automation.VerbsData.Update, @"AzNetworkAnalyticsDataProduct_UpdateExpanded", SupportsShouldProcess = true)]
    [global::System.Management.Automation.OutputType(typeof(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProduct))]
    [global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Description(@"update data product resource.")]
    [global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Generated]
    public partial class UpdateAzNetworkAnalyticsDataProduct_UpdateExpanded : global::System.Management.Automation.PSCmdlet,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IContext
    {
        /// <summary>A unique id generatd for the this cmdlet when it is instantiated.</summary>
        private string __correlationId = System.Guid.NewGuid().ToString();

        /// <summary>A copy of the Invocation Info (necessary to allow asJob to clone this cmdlet)</summary>
        private global::System.Management.Automation.InvocationInfo __invocationInfo;

        /// <summary>A unique id generatd for the this cmdlet when ProcessRecord() is called.</summary>
        private string __processRecordId;

        /// <summary>
        /// The <see cref="global::System.Threading.CancellationTokenSource" /> for this operation.
        /// </summary>
        private global::System.Threading.CancellationTokenSource _cancellationTokenSource = new global::System.Threading.CancellationTokenSource();

        /// <summary>A dictionary to carry over additional data for pipeline.</summary>
        private global::System.Collections.Generic.Dictionary<global::System.String,global::System.Object> _extensibleParameters = new System.Collections.Generic.Dictionary<string, object>();

        /// <summary>The data product resource.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProduct _resourceBody = new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.DataProduct();

        /// <summary>when specified, runs this cmdlet as a PowerShell job</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Run the command as a job")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Category(global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter AsJob { get; set; }

        /// <summary>Wait for .NET debugger to attach</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Wait for .NET debugger to attach")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Category(global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter Break { get; set; }

        /// <summary>Accessor for cancellationTokenSource.</summary>
        public global::System.Threading.CancellationTokenSource CancellationTokenSource { get => _cancellationTokenSource ; set { _cancellationTokenSource = value; } }

        /// <summary>The reference to the client API class.</summary>
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.MicrosoftNetworkAnalytics Client => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Module.Instance.ClientAPI;

        /// <summary>Current configured minor version of the data product resource.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Current configured minor version of the data product resource.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Category(global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Current configured minor version of the data product resource.",
        SerializedName = @"currentMinorVersion",
        PossibleTypes = new [] { typeof(string) })]
        public string CurrentMinorVersion { get => _resourceBody.CurrentMinorVersion ?? null; set => _resourceBody.CurrentMinorVersion = value; }

        /// <summary>
        /// The DefaultProfile parameter is not functional. Use the SubscriptionId parameter when available if executing the cmdlet
        /// against a different subscription
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The DefaultProfile parameter is not functional. Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::System.Management.Automation.Alias("AzureRMContext", "AzureCredential")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Category(global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.ParameterCategory.Azure)]
        public global::System.Management.Automation.PSObject DefaultProfile { get; set; }

        /// <summary>Determines whether to enable a system-assigned identity for the resource.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Determines whether to enable a system-assigned identity for the resource.")]
        public System.Boolean? EnableSystemAssignedIdentity { get; set; }

        /// <summary>Accessor for extensibleParameters.</summary>
        public global::System.Collections.Generic.IDictionary<global::System.String,global::System.Object> ExtensibleParameters { get => _extensibleParameters ; }

        /// <summary>SendAsync Pipeline Steps to be appended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be appended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Category(global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.ParameterCategory.Runtime)]
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SendAsyncStep[] HttpPipelineAppend { get; set; }

        /// <summary>SendAsync Pipeline Steps to be prepended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be prepended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Category(global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.ParameterCategory.Runtime)]
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SendAsyncStep[] HttpPipelinePrepend { get; set; }

        /// <summary>Accessor for our copy of the InvocationInfo.</summary>
        public global::System.Management.Automation.InvocationInfo InvocationInformation { get => __invocationInfo = __invocationInfo ?? this.MyInvocation ; set { __invocationInfo = value; } }

        /// <summary>
        /// <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> cancellation delegate. Stops the cmdlet when called.
        /// </summary>
        global::System.Action Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener.Cancel => _cancellationTokenSource.Cancel;

        /// <summary><see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> cancellation token.</summary>
        global::System.Threading.CancellationToken Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener.Token => _cancellationTokenSource.Token;

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The data product resource name</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The data product resource name")]
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The data product resource name",
        SerializedName = @"dataProductName",
        PossibleTypes = new [] { typeof(string) })]
        [global::System.Management.Automation.Alias("DataProductName")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Category(global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.ParameterCategory.Path)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>
        /// when specified, will make the remote call, and return an AsyncOperationResponse, letting the remote operation continue
        /// asynchronously.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Run the command asynchronously")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Category(global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter NoWait { get; set; }

        /// <summary>List of name or email associated with data product resource deployment.</summary>
        [global::System.Management.Automation.AllowEmptyCollection]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "List of name or email associated with data product resource deployment.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Category(global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of name or email associated with data product resource deployment.",
        SerializedName = @"owners",
        PossibleTypes = new [] { typeof(string) })]
        public string[] Owner { get => _resourceBody.Owner?.ToArray() ?? null /* fixedArrayOf */; set => _resourceBody.Owner = (value != null ? new System.Collections.Generic.List<string>(value) : null); }

        /// <summary>
        /// The instance of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.HttpPipeline" /> that the remote call will use.
        /// </summary>
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.HttpPipeline Pipeline { get; set; }

        /// <summary>Flag to enable or disable private link for data product resource.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Flag to enable or disable private link for data product resource.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Category(global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Flag to enable or disable private link for data product resource.",
        SerializedName = @"privateLinksEnabled",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        public string PrivateLinksEnabled { get => _resourceBody.PrivateLinksEnabled ?? null; set => _resourceBody.PrivateLinksEnabled = value; }

        /// <summary>The URI for the proxy server to use</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "The URI for the proxy server to use")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Category(global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.ParameterCategory.Runtime)]
        public global::System.Uri Proxy { get; set; }

        /// <summary>Credentials for a proxy server to use for the remote call</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Credentials for a proxy server to use for the remote call")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Category(global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.ParameterCategory.Runtime)]
        public global::System.Management.Automation.PSCredential ProxyCredential { get; set; }

        /// <summary>Use the default credentials for the proxy</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Use the default credentials for the proxy")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Category(global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter ProxyUseDefaultCredentials { get; set; }

        /// <summary>Purview account url for data product to connect to.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Purview account url for data product to connect to.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Category(global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Purview account url for data product to connect to.",
        SerializedName = @"purviewAccount",
        PossibleTypes = new [] { typeof(string) })]
        public string PurviewAccount { get => _resourceBody.PurviewAccount ?? null; set => _resourceBody.PurviewAccount = value; }

        /// <summary>Purview collection url for data product to connect to.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Purview collection url for data product to connect to.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Category(global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Purview collection url for data product to connect to.",
        SerializedName = @"purviewCollection",
        PossibleTypes = new [] { typeof(string) })]
        public string PurviewCollection { get => _resourceBody.PurviewCollection ?? null; set => _resourceBody.PurviewCollection = value; }

        /// <summary>Backing field for <see cref="ResourceGroupName" /> property.</summary>
        private string _resourceGroupName;

        /// <summary>The name of the resource group. The name is case insensitive.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The name of the resource group. The name is case insensitive.")]
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The name of the resource group. The name is case insensitive.",
        SerializedName = @"resourceGroupName",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Category(global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.ParameterCategory.Path)]
        public string ResourceGroupName { get => this._resourceGroupName; set => this._resourceGroupName = value; }

        /// <summary>Backing field for <see cref="SubscriptionId" /> property.</summary>
        private string _subscriptionId;

        /// <summary>The ID of the target subscription. The value must be an UUID.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The ID of the target subscription. The value must be an UUID.")]
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The ID of the target subscription. The value must be an UUID.",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.DefaultInfo(
        Name = @"",
        Description =@"",
        Script = @"(Get-AzContext).Subscription.Id",
        SetCondition = @"")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Category(global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.ParameterCategory.Path)]
        public string SubscriptionId { get => this._subscriptionId; set => this._subscriptionId = value; }

        /// <summary>Resource tags.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.ExportAs(typeof(global::System.Collections.Hashtable))]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Resource tags.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Category(global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource tags.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ITags) })]
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ITags Tag { get => _resourceBody.Tag ?? null /* object */; set => _resourceBody.Tag = value; }

        /// <summary>
        /// The array of user assigned identities associated with the resource. The elements in array will be ARM resource ids in
        /// the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}.'
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The array of user assigned identities associated with the resource. The elements in array will be ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}.'")]
        [global::System.Management.Automation.AllowEmptyCollection]
        public string[] UserAssignedIdentity { get; set; }

        /// <summary>
        /// <c>overrideOnDefault</c> will be called before the regular onDefault has been processed, allowing customization of what
        /// happens on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse">Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse</see>
        /// from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onDefault method should be processed, or if the method should
        /// return immediately (set to true to skip further processing )</param>

        partial void overrideOnDefault(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// <c>overrideOnOk</c> will be called before the regular onOk has been processed, allowing customization of what happens
        /// on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProduct">Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProduct</see>
        /// from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onOk method should be processed, or if the method should return
        /// immediately (set to true to skip further processing )</param>

        partial void overrideOnOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProduct> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// (overrides the default BeginProcessing method in global::System.Management.Automation.PSCmdlet)
        /// </summary>
        protected override void BeginProcessing()
        {
            var telemetryId = Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Module.Instance.GetTelemetryId.Invoke();
            if (telemetryId != "" && telemetryId != "internal")
            {
                __correlationId = telemetryId;
            }
            Module.Instance.SetProxyConfiguration(Proxy, ProxyCredential, ProxyUseDefaultCredentials);
            if (Break)
            {
                Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.AttachDebugger.Break();
            }
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.CmdletBeginProcessing).Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
        }

        /// <summary>Creates a duplicate instance of this cmdlet (via JSON serialization).</summary>
        /// <returns>a duplicate instance of UpdateAzNetworkAnalyticsDataProduct_UpdateExpanded</returns>
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Cmdlets.UpdateAzNetworkAnalyticsDataProduct_UpdateExpanded Clone()
        {
            var clone = new UpdateAzNetworkAnalyticsDataProduct_UpdateExpanded();
            clone.__correlationId = this.__correlationId;
            clone.__processRecordId = this.__processRecordId;
            clone.DefaultProfile = this.DefaultProfile;
            clone.InvocationInformation = this.InvocationInformation;
            clone.Proxy = this.Proxy;
            clone.Pipeline = this.Pipeline;
            clone.AsJob = this.AsJob;
            clone.Break = this.Break;
            clone.ProxyCredential = this.ProxyCredential;
            clone.ProxyUseDefaultCredentials = this.ProxyUseDefaultCredentials;
            clone.HttpPipelinePrepend = this.HttpPipelinePrepend;
            clone.HttpPipelineAppend = this.HttpPipelineAppend;
            clone._resourceBody = this._resourceBody;
            clone.SubscriptionId = this.SubscriptionId;
            clone.ResourceGroupName = this.ResourceGroupName;
            clone.Name = this.Name;
            return clone;
        }

        /// <summary>Performs clean-up after the command execution</summary>
        protected override void EndProcessing()
        {
            var telemetryInfo = Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Module.Instance.GetTelemetryInfo?.Invoke(__correlationId);
            if (telemetryInfo != null)
            {
                telemetryInfo.TryGetValue("ShowSecretsWarning", out var showSecretsWarning);
                telemetryInfo.TryGetValue("SanitizedProperties", out var sanitizedProperties);
                telemetryInfo.TryGetValue("InvocationName", out var invocationName);
                if (showSecretsWarning == "true")
                {
                    if (string.IsNullOrEmpty(sanitizedProperties))
                    {
                        WriteWarning($"The output of cmdlet {invocationName} may compromise security by showing secrets. Learn more at https://go.microsoft.com/fwlink/?linkid=2258844");
                    }
                    else
                    {
                        WriteWarning($"The output of cmdlet {invocationName} may compromise security by showing the following secrets: {sanitizedProperties}. Learn more at https://go.microsoft.com/fwlink/?linkid=2258844");
                    }
                }
            }
        }

        /// <summary>Handles/Dispatches events during the call to the REST service.</summary>
        /// <param name="id">The message id</param>
        /// <param name="token">The message cancellation token. When this call is cancelled, this should be <c>true</c></param>
        /// <param name="messageData">Detailed message data for the message event.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the message is completed.
        /// </returns>
         async global::System.Threading.Tasks.Task Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener.Signal(string id, global::System.Threading.CancellationToken token, global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.EventData> messageData)
        {
            using( NoSynchronizationContext )
            {
                if (token.IsCancellationRequested)
                {
                    return ;
                }

                switch ( id )
                {
                    case Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Verbose:
                    {
                        WriteVerbose($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Warning:
                    {
                        WriteWarning($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Information:
                    {
                        // When an operation supports asjob, Information messages must go thru verbose.
                        WriteVerbose($"INFORMATION: {(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Debug:
                    {
                        WriteDebug($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Error:
                    {
                        WriteError(new global::System.Management.Automation.ErrorRecord( new global::System.Exception(messageData().Message), string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null ) );
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.Progress:
                    {
                        var data = messageData();
                        int progress = (int)data.Value;
                        string activityMessage, statusDescription;
                        global::System.Management.Automation.ProgressRecordType recordType;
                        if (progress < 100)
                        {
                            activityMessage = "In progress";
                            statusDescription = "Checking operation status";
                            recordType = System.Management.Automation.ProgressRecordType.Processing;
                        }
                        else
                        {
                            activityMessage = "Completed";
                            statusDescription = "Completed";
                            recordType = System.Management.Automation.ProgressRecordType.Completed;
                        }
                        WriteProgress(new global::System.Management.Automation.ProgressRecord(1, activityMessage, statusDescription)
                        {
                            PercentComplete = progress,
                        RecordType = recordType
                        });
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.DelayBeforePolling:
                    {
                        var data = messageData();
                        if (true == MyInvocation?.BoundParameters?.ContainsKey("NoWait"))
                        {
                            if (data.ResponseMessage is System.Net.Http.HttpResponseMessage response)
                            {
                                var asyncOperation = response.GetFirstHeader(@"Azure-AsyncOperation");
                                var location = response.GetFirstHeader(@"Location");
                                var uri = global::System.String.IsNullOrEmpty(asyncOperation) ? global::System.String.IsNullOrEmpty(location) ? response.RequestMessage.RequestUri.AbsoluteUri : location : asyncOperation;
                                WriteObject(new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.PowerShell.AsyncOperationResponse { Target = uri });
                                // do nothing more.
                                data.Cancel();
                                return;
                            }
                        }
                        else
                        {
                            if (data.ResponseMessage is System.Net.Http.HttpResponseMessage response)
                            {
                                int delay = (int)(response.Headers.RetryAfter?.Delta?.TotalSeconds ?? 30);
                                WriteDebug($"Delaying {delay} seconds before polling.");
                                for (var now = 0; now < delay; ++now)
                                {
                                    WriteProgress(new global::System.Management.Automation.ProgressRecord(1, "In progress", "Checking operation status")
                                    {
                                        PercentComplete = now * 100 / delay
                                    });
                                    await global::System.Threading.Tasks.Task.Delay(1000, token);
                                }
                            }
                        }
                        break;
                    }
                }
                await Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Module.Instance.Signal(id, token, messageData, (i, t, m) => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener)this).Signal(i, t, () => Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.EventDataConverter.ConvertFrom(m()) as Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.EventData), InvocationInformation, this.ParameterSetName, __correlationId, __processRecordId, null );
                if (token.IsCancellationRequested)
                {
                    return ;
                }
                WriteDebug($"{id}: {(messageData().Message ?? global::System.String.Empty)}");
            }
        }

        private void PreProcessManagedIdentityParametersWithGetResult()
        {
            bool supportsSystemAssignedIdentity = (true == this.EnableSystemAssignedIdentity || null == this.EnableSystemAssignedIdentity && true == _resourceBody?.IdentityType?.Contains("SystemAssigned"));
            bool supportsUserAssignedIdentity = false;
            if (this.UserAssignedIdentity?.Length > 0)
            {
                // calculate UserAssignedIdentity
                _resourceBody.IdentityUserAssignedIdentity.Clear();
                foreach( var id in this.UserAssignedIdentity )
                {
                    _resourceBody.IdentityUserAssignedIdentity.Add(id, new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.UserAssignedIdentity());
                }
            }
            supportsUserAssignedIdentity = true == this.MyInvocation?.BoundParameters?.ContainsKey("UserAssignedIdentity") && this.UserAssignedIdentity?.Length > 0 ||
                    true != this.MyInvocation?.BoundParameters?.ContainsKey("UserAssignedIdentity") && true == _resourceBody.IdentityType?.Contains("UserAssigned");
            if (!supportsUserAssignedIdentity)
            {
                _resourceBody.IdentityUserAssignedIdentity = null;
            }
            // calculate IdentityType
            if ((supportsUserAssignedIdentity && supportsSystemAssignedIdentity))
            {
                _resourceBody.IdentityType = "SystemAssigned,UserAssigned";
            }
            else if ((supportsUserAssignedIdentity && !supportsSystemAssignedIdentity))
            {
                _resourceBody.IdentityType = "UserAssigned";
            }
            else if ((!supportsUserAssignedIdentity && supportsSystemAssignedIdentity))
            {
                _resourceBody.IdentityType = "SystemAssigned";
            }
            else
            {
                _resourceBody.IdentityType = "None";
            }
        }

        /// <summary>Performs execution of the command.</summary>
        protected override void ProcessRecord()
        {
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.CmdletProcessRecordStart).Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
            __processRecordId = System.Guid.NewGuid().ToString();
            try
            {
                // work
                if (ShouldProcess($"Call remote 'DataProductsCreate' operation"))
                {
                    if (true == MyInvocation?.BoundParameters?.ContainsKey("AsJob"))
                    {
                        var instance = this.Clone();
                        var job = new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.PowerShell.AsyncJob(instance, this.MyInvocation.Line, this.MyInvocation.MyCommand.Name, this._cancellationTokenSource.Token, this._cancellationTokenSource.Cancel);
                        JobRepository.Add(job);
                        var task = instance.ProcessRecordAsync();
                        job.Monitor(task);
                        WriteObject(job);
                    }
                    else
                    {
                        using( var asyncCommandRuntime = new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.PowerShell.AsyncCommandRuntime(this, ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener)this).Token) )
                        {
                            asyncCommandRuntime.Wait( ProcessRecordAsync(),((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener)this).Token);
                        }
                    }
                }
            }
            catch (global::System.AggregateException aggregateException)
            {
                // unroll the inner exceptions to get the root cause
                foreach( var innerException in aggregateException.Flatten().InnerExceptions )
                {
                    ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.CmdletException, $"{innerException.GetType().Name} - {innerException.Message} : {innerException.StackTrace}").Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    // Write exception out to error channel.
                    WriteError( new global::System.Management.Automation.ErrorRecord(innerException,string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null) );
                }
            }
            catch (global::System.Exception exception) when ((exception as System.Management.Automation.PipelineStoppedException)== null || (exception as System.Management.Automation.PipelineStoppedException).InnerException != null)
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.CmdletException, $"{exception.GetType().Name} - {exception.Message} : {exception.StackTrace}").Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                // Write exception out to error channel.
                WriteError( new global::System.Management.Automation.ErrorRecord(exception,string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null) );
            }
            finally
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.CmdletProcessRecordEnd).Wait();
            }
        }

        /// <summary>Performs execution of the command, working asynchronously if required.</summary>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        protected async global::System.Threading.Tasks.Task ProcessRecordAsync()
        {
            using( NoSynchronizationContext )
            {
                await ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.CmdletGetPipeline); if( ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                Pipeline = Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Module.Instance.CreatePipeline(InvocationInformation, __correlationId, __processRecordId, this.ParameterSetName, this.ExtensibleParameters);
                if (null != HttpPipelinePrepend)
                {
                    Pipeline.Prepend((this.CommandRuntime as Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelinePrepend) ?? HttpPipelinePrepend);
                }
                if (null != HttpPipelineAppend)
                {
                    Pipeline.Append((this.CommandRuntime as Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelineAppend) ?? HttpPipelineAppend);
                }
                // get the client instance
                try
                {
                    await ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.CmdletBeforeAPICall); if( ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    _resourceBody = await this.Client.DataProductsGetWithResult(SubscriptionId, ResourceGroupName, Name, this, Pipeline);
                    this.PreProcessManagedIdentityParametersWithGetResult();
                    this.Update_resourceBody();
                    await this.Client.DataProductsCreate(SubscriptionId, ResourceGroupName, Name, _resourceBody, onOk, onDefault, this, Pipeline, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeUpdate);
                    await ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.CmdletAfterAPICall); if( ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                }
                catch (Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.UndeclaredResponseException urexception)
                {
                    WriteError(new global::System.Management.Automation.ErrorRecord(urexception, urexception.StatusCode.ToString(), global::System.Management.Automation.ErrorCategory.InvalidOperation, new { SubscriptionId=SubscriptionId,ResourceGroupName=ResourceGroupName,Name=Name})
                    {
                      ErrorDetails = new global::System.Management.Automation.ErrorDetails(urexception.Message) { RecommendedAction = urexception.Action }
                    });
                }
                finally
                {
                    await ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Events.CmdletProcessRecordAsyncEnd);
                }
            }
        }

        /// <summary>Interrupts currently running code within the command.</summary>
        protected override void StopProcessing()
        {
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener)this).Cancel();
            base.StopProcessing();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAzNetworkAnalyticsDataProduct_UpdateExpanded" /> cmdlet class.
        /// </summary>
        public UpdateAzNetworkAnalyticsDataProduct_UpdateExpanded()
        {

        }

        private void Update_resourceBody()
        {
            if ((bool)(true == this.MyInvocation?.BoundParameters.ContainsKey("Tag")))
            {
                this.Tag = (Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ITags)(this.MyInvocation?.BoundParameters["Tag"]);
            }
            if ((bool)(true == this.MyInvocation?.BoundParameters.ContainsKey("Owner")))
            {
                this.Owner = (string[])(this.MyInvocation?.BoundParameters["Owner"]);
            }
            if ((bool)(true == this.MyInvocation?.BoundParameters.ContainsKey("PurviewAccount")))
            {
                this.PurviewAccount = (string)(this.MyInvocation?.BoundParameters["PurviewAccount"]);
            }
            if ((bool)(true == this.MyInvocation?.BoundParameters.ContainsKey("PurviewCollection")))
            {
                this.PurviewCollection = (string)(this.MyInvocation?.BoundParameters["PurviewCollection"]);
            }
            if ((bool)(true == this.MyInvocation?.BoundParameters.ContainsKey("PrivateLinksEnabled")))
            {
                this.PrivateLinksEnabled = (string)(this.MyInvocation?.BoundParameters["PrivateLinksEnabled"]);
            }
            if ((bool)(true == this.MyInvocation?.BoundParameters.ContainsKey("CurrentMinorVersion")))
            {
                this.CurrentMinorVersion = (string)(this.MyInvocation?.BoundParameters["CurrentMinorVersion"]);
            }
        }

        /// <param name="sendToPipeline"></param>
        new protected void WriteObject(object sendToPipeline)
        {
            Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Module.Instance.SanitizeOutput?.Invoke(sendToPipeline, __correlationId);
            base.WriteObject(sendToPipeline);
        }

        /// <param name="sendToPipeline"></param>
        /// <param name="enumerateCollection"></param>
        new protected void WriteObject(object sendToPipeline, bool enumerateCollection)
        {
            Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Module.Instance.SanitizeOutput?.Invoke(sendToPipeline, __correlationId);
            base.WriteObject(sendToPipeline, enumerateCollection);
        }

        /// <summary>
        /// a delegate that is called when the remote service returns default (any response code not handled elsewhere).
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse">Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse</see>
        /// from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onDefault(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse> response)
        {
            using( NoSynchronizationContext )
            {
                var _returnNow = global::System.Threading.Tasks.Task<bool>.FromResult(false);
                overrideOnDefault(responseMessage, response, ref _returnNow);
                // if overrideOnDefault has returned true, then return right away.
                if ((null != _returnNow && await _returnNow))
                {
                    return ;
                }
                // Error Response : default
                var code = (await response)?.Code;
                var message = (await response)?.Message;
                if ((null == code || null == message))
                {
                    // Unrecognized Response. Create an error record based on what we have.
                    var ex = new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IErrorResponse>(responseMessage, await response);
                    WriteError( new global::System.Management.Automation.ErrorRecord(ex, ex.Code, global::System.Management.Automation.ErrorCategory.InvalidOperation, new {  })
                    {
                      ErrorDetails = new global::System.Management.Automation.ErrorDetails(ex.Message) { RecommendedAction = ex.Action }
                    });
                }
                else
                {
                    WriteError( new global::System.Management.Automation.ErrorRecord(new global::System.Exception($"[{code}] : {message}"), code?.ToString(), global::System.Management.Automation.ErrorCategory.InvalidOperation, new {  })
                    {
                      ErrorDetails = new global::System.Management.Automation.ErrorDetails(message) { RecommendedAction = global::System.String.Empty }
                    });
                }
            }
        }

        /// <summary>a delegate that is called when the remote service returns 200 (OK).</summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProduct">Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProduct</see>
        /// from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProduct> response)
        {
            using( NoSynchronizationContext )
            {
                var _returnNow = global::System.Threading.Tasks.Task<bool>.FromResult(false);
                overrideOnOk(responseMessage, response, ref _returnNow);
                // if overrideOnOk has returned true, then return right away.
                if ((null != _returnNow && await _returnNow))
                {
                    return ;
                }
                // onOk - response for 200 / application/json
                // (await response) // should be Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProduct
                var result = (await response);
                WriteObject(result, false);
            }
        }
    }
}