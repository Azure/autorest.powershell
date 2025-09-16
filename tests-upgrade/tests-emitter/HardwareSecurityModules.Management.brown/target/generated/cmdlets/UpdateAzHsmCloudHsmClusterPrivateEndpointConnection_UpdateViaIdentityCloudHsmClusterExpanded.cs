// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Hsm.Cmdlets
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Extensions;
    using Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.PowerShell;
    using Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Cmdlets;
    using System;

    /// <summary>update the private endpoint connection for the Cloud Hsm Cluster.</summary>
    /// <remarks>
    /// [OpenAPI] Get=>GET:"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/{cloudHsmClusterName}/privateEndpointConnections/{peConnectionName}"
    /// [OpenAPI] Create=>PUT:"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/{cloudHsmClusterName}/privateEndpointConnections/{peConnectionName}"
    /// </remarks>
    [global::System.Management.Automation.Cmdlet(global::System.Management.Automation.VerbsData.Update, @"AzHsmCloudHsmClusterPrivateEndpointConnection_UpdateViaIdentityCloudHsmClusterExpanded", SupportsShouldProcess = true)]
    [global::System.Management.Automation.OutputType(typeof(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IPrivateEndpointConnection))]
    [global::Microsoft.Azure.PowerShell.Cmdlets.Hsm.Description(@"update the private endpoint connection for the Cloud Hsm Cluster.")]
    [global::Microsoft.Azure.PowerShell.Cmdlets.Hsm.Generated]
    public partial class UpdateAzHsmCloudHsmClusterPrivateEndpointConnection_UpdateViaIdentityCloudHsmClusterExpanded : global::System.Management.Automation.PSCmdlet,
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener,
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IContext
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

        /// <summary>A buffer to record first returned object in response.</summary>
        private object _firstResponse = null;

        /// <summary>The private endpoint connection resource.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IPrivateEndpointConnection _propertiesBody = new Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.PrivateEndpointConnection();

        /// <summary>
        /// A flag to tell whether it is the first returned object in a call. Zero means no response yet. One means 1 returned object.
        /// Two means multiple returned objects in response.
        /// </summary>
        private int _responseSize = 0;

        /// <summary>Wait for .NET debugger to attach</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Wait for .NET debugger to attach")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Hsm.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Hsm.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter Break { get; set; }

        /// <summary>Accessor for cancellationTokenSource.</summary>
        public global::System.Threading.CancellationTokenSource CancellationTokenSource { get => _cancellationTokenSource ; set { _cancellationTokenSource = value; } }

        /// <summary>The reference to the client API class.</summary>
        public Microsoft.Azure.PowerShell.Cmdlets.Hsm.HardwareSecurityModules Client => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Module.Instance.ClientAPI;

        /// <summary>Backing field for <see cref="CloudHsmClusterInputObject" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IHsmIdentity _cloudHsmClusterInputObject;

        /// <summary>Identity Parameter</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "Identity Parameter", ValueFromPipeline = true)]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Hsm.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Hsm.ParameterCategory.Path)]
        public Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IHsmIdentity CloudHsmClusterInputObject { get => this._cloudHsmClusterInputObject; set => this._cloudHsmClusterInputObject = value; }

        /// <summary>
        /// The DefaultProfile parameter is not functional. Use the SubscriptionId parameter when available if executing the cmdlet
        /// against a different subscription
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The DefaultProfile parameter is not functional. Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::System.Management.Automation.Alias("AzureRMContext", "AzureCredential")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Hsm.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Hsm.ParameterCategory.Azure)]
        public global::System.Management.Automation.PSObject DefaultProfile { get; set; }

        /// <summary>
        /// Modified whenever there is a change in the state of private endpoint connection.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Modified whenever there is a change in the state of private endpoint connection.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Hsm.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Hsm.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Modified whenever there is a change in the state of private endpoint connection.",
        SerializedName = @"etag",
        PossibleTypes = new [] { typeof(string) })]
        public string Etag { get => _propertiesBody.Etag ?? null; set => _propertiesBody.Etag = value; }

        /// <summary>Accessor for extensibleParameters.</summary>
        public global::System.Collections.Generic.IDictionary<global::System.String,global::System.Object> ExtensibleParameters { get => _extensibleParameters ; }

        /// <summary>SendAsync Pipeline Steps to be appended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be appended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Hsm.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Hsm.ParameterCategory.Runtime)]
        public Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SendAsyncStep[] HttpPipelineAppend { get; set; }

        /// <summary>SendAsync Pipeline Steps to be prepended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be prepended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Hsm.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Hsm.ParameterCategory.Runtime)]
        public Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SendAsyncStep[] HttpPipelinePrepend { get; set; }

        /// <summary>Accessor for our copy of the InvocationInfo.</summary>
        public global::System.Management.Automation.InvocationInfo InvocationInformation { get => __invocationInfo = __invocationInfo ?? this.MyInvocation ; set { __invocationInfo = value; } }

        /// <summary>
        /// <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> cancellation delegate. Stops the cmdlet when called.
        /// </summary>
        global::System.Action Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener.Cancel => _cancellationTokenSource.Cancel;

        /// <summary><see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> cancellation token.</summary>
        global::System.Threading.CancellationToken Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener.Token => _cancellationTokenSource.Token;

        /// <summary>Backing field for <see cref="PeConnectionName" /> property.</summary>
        private string _peConnectionName;

        /// <summary>Name of the private endpoint connection associated with the Cloud HSM Cluster.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "Name of the private endpoint connection associated with the Cloud HSM Cluster.")]
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Name of the private endpoint connection associated with the Cloud HSM Cluster.",
        SerializedName = @"peConnectionName",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Hsm.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Hsm.ParameterCategory.Path)]
        public string PeConnectionName { get => this._peConnectionName; set => this._peConnectionName = value; }

        /// <summary>
        /// The instance of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.HttpPipeline" /> that the remote call will use.
        /// </summary>
        public Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.HttpPipeline Pipeline { get; set; }

        /// <summary>
        /// A message indicating if changes on the service provider require any updates on the consumer.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "A message indicating if changes on the service provider require any updates on the consumer.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Hsm.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Hsm.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A message indicating if changes on the service provider require any updates on the consumer.",
        SerializedName = @"actionsRequired",
        PossibleTypes = new [] { typeof(string) })]
        public string PrivateLinkServiceConnectionStateActionsRequired { get => _propertiesBody.PrivateLinkServiceConnectionStateActionsRequired ?? null; set => _propertiesBody.PrivateLinkServiceConnectionStateActionsRequired = value; }

        /// <summary>The reason for approval/rejection of the connection.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The reason for approval/rejection of the connection.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Hsm.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Hsm.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The reason for approval/rejection of the connection.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        public string PrivateLinkServiceConnectionStateDescription { get => _propertiesBody.PrivateLinkServiceConnectionStateDescription ?? null; set => _propertiesBody.PrivateLinkServiceConnectionStateDescription = value; }

        /// <summary>
        /// Indicates whether the connection has been Approved/Rejected/Removed by the owner of the service.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Indicates whether the connection has been Approved/Rejected/Removed by the owner of the service.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Hsm.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Hsm.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicates whether the connection has been Approved/Rejected/Removed by the owner of the service.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Hsm.PSArgumentCompleterAttribute("Pending", "Approved", "Rejected")]
        public string PrivateLinkServiceConnectionStateStatus { get => _propertiesBody.PrivateLinkServiceConnectionStateStatus ?? null; set => _propertiesBody.PrivateLinkServiceConnectionStateStatus = value; }

        /// <summary>The URI for the proxy server to use</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "The URI for the proxy server to use")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Hsm.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Hsm.ParameterCategory.Runtime)]
        public global::System.Uri Proxy { get; set; }

        /// <summary>Credentials for a proxy server to use for the remote call</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Credentials for a proxy server to use for the remote call")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Hsm.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Hsm.ParameterCategory.Runtime)]
        public global::System.Management.Automation.PSCredential ProxyCredential { get; set; }

        /// <summary>Use the default credentials for the proxy</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Use the default credentials for the proxy")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Hsm.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Hsm.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter ProxyUseDefaultCredentials { get; set; }

        /// <summary>
        /// <c>overrideOnDefault</c> will be called before the regular onDefault has been processed, allowing customization of what
        /// happens on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse">Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse</see>
        /// from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onDefault method should be processed, or if the method should
        /// return immediately (set to true to skip further processing )</param>

        partial void overrideOnDefault(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// <c>overrideOnOk</c> will be called before the regular onOk has been processed, allowing customization of what happens
        /// on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IPrivateEndpointConnection">Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IPrivateEndpointConnection</see>
        /// from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onOk method should be processed, or if the method should return
        /// immediately (set to true to skip further processing )</param>

        partial void overrideOnOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IPrivateEndpointConnection> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// (overrides the default BeginProcessing method in global::System.Management.Automation.PSCmdlet)
        /// </summary>
        protected override void BeginProcessing()
        {
            var telemetryId = Microsoft.Azure.PowerShell.Cmdlets.Hsm.Module.Instance.GetTelemetryId.Invoke();
            if (telemetryId != "" && telemetryId != "internal")
            {
                __correlationId = telemetryId;
            }
            Module.Instance.SetProxyConfiguration(Proxy, ProxyCredential, ProxyUseDefaultCredentials);
            if (Break)
            {
                Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.AttachDebugger.Break();
            }
            ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.CmdletBeginProcessing).Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
        }

        /// <summary>Performs clean-up after the command execution</summary>
        protected override void EndProcessing()
        {
            if (1 ==_responseSize)
            {
                // Flush buffer
                WriteObject(_firstResponse);
            }
            var telemetryInfo = Microsoft.Azure.PowerShell.Cmdlets.Hsm.Module.Instance.GetTelemetryInfo?.Invoke(__correlationId);
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
         async global::System.Threading.Tasks.Task Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener.Signal(string id, global::System.Threading.CancellationToken token, global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.EventData> messageData)
        {
            using( NoSynchronizationContext )
            {
                if (token.IsCancellationRequested)
                {
                    return ;
                }

                switch ( id )
                {
                    case Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Verbose:
                    {
                        WriteVerbose($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Warning:
                    {
                        WriteWarning($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Information:
                    {
                        var data = messageData();
                        WriteInformation(data.Message, new string[]{});
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Debug:
                    {
                        WriteDebug($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Error:
                    {
                        WriteError(new global::System.Management.Automation.ErrorRecord( new global::System.Exception(messageData().Message), string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null ) );
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.Progress:
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
                }
                await Microsoft.Azure.PowerShell.Cmdlets.Hsm.Module.Instance.Signal(id, token, messageData, (i, t, m) => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener)this).Signal(i, t, () => Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.EventDataConverter.ConvertFrom(m()) as Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.EventData), InvocationInformation, this.ParameterSetName, __correlationId, __processRecordId, null );
                if (token.IsCancellationRequested)
                {
                    return ;
                }
                WriteDebug($"{id}: {(messageData().Message ?? global::System.String.Empty)}");
            }
        }

        /// <summary>Performs execution of the command.</summary>
        protected override void ProcessRecord()
        {
            ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.CmdletProcessRecordStart).Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
            __processRecordId = System.Guid.NewGuid().ToString();
            try
            {
                // work
                if (ShouldProcess($"Call remote 'CloudHsmClusterPrivateEndpointConnectionsCreate' operation"))
                {
                    using( var asyncCommandRuntime = new Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.PowerShell.AsyncCommandRuntime(this, ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener)this).Token) )
                    {
                        asyncCommandRuntime.Wait( ProcessRecordAsync(),((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener)this).Token);
                    }
                }
            }
            catch (global::System.AggregateException aggregateException)
            {
                // unroll the inner exceptions to get the root cause
                foreach( var innerException in aggregateException.Flatten().InnerExceptions )
                {
                    ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.CmdletException, $"{innerException.GetType().Name} - {innerException.Message} : {innerException.StackTrace}").Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    // Write exception out to error channel.
                    WriteError( new global::System.Management.Automation.ErrorRecord(innerException,string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null) );
                }
            }
            catch (global::System.Exception exception) when ((exception as System.Management.Automation.PipelineStoppedException)== null || (exception as System.Management.Automation.PipelineStoppedException).InnerException != null)
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.CmdletException, $"{exception.GetType().Name} - {exception.Message} : {exception.StackTrace}").Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                // Write exception out to error channel.
                WriteError( new global::System.Management.Automation.ErrorRecord(exception,string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null) );
            }
            finally
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.CmdletProcessRecordEnd).Wait();
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
                await ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.CmdletGetPipeline); if( ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                Pipeline = Microsoft.Azure.PowerShell.Cmdlets.Hsm.Module.Instance.CreatePipeline(InvocationInformation, __correlationId, __processRecordId, this.ParameterSetName, this.ExtensibleParameters);
                if (null != HttpPipelinePrepend)
                {
                    Pipeline.Prepend((this.CommandRuntime as Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelinePrepend) ?? HttpPipelinePrepend);
                }
                if (null != HttpPipelineAppend)
                {
                    Pipeline.Append((this.CommandRuntime as Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelineAppend) ?? HttpPipelineAppend);
                }
                // get the client instance
                try
                {
                    await ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.CmdletBeforeAPICall); if( ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    if (CloudHsmClusterInputObject?.Id != null)
                    {
                        this.CloudHsmClusterInputObject.Id += $"/privateEndpointConnections/{(global::System.Uri.EscapeDataString(this.PeConnectionName.ToString()))}";
                        _propertiesBody = await this.Client.CloudHsmClusterPrivateEndpointConnectionsGetViaIdentityWithResult(CloudHsmClusterInputObject.Id, this, Pipeline);
                        this.Update_propertiesBody();
                        await this.Client.CloudHsmClusterPrivateEndpointConnectionsCreateViaIdentity(CloudHsmClusterInputObject.Id, _propertiesBody, onOk, onDefault, this, Pipeline, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeUpdate);
                    }
                    else
                    {
                        // try to call with PATH parameters from Input Object
                        if (null == CloudHsmClusterInputObject.SubscriptionId)
                        {
                            ThrowTerminatingError( new global::System.Management.Automation.ErrorRecord(new global::System.Exception("CloudHsmClusterInputObject has null value for CloudHsmClusterInputObject.SubscriptionId"),string.Empty, global::System.Management.Automation.ErrorCategory.InvalidArgument, CloudHsmClusterInputObject) );
                        }
                        if (null == CloudHsmClusterInputObject.ResourceGroupName)
                        {
                            ThrowTerminatingError( new global::System.Management.Automation.ErrorRecord(new global::System.Exception("CloudHsmClusterInputObject has null value for CloudHsmClusterInputObject.ResourceGroupName"),string.Empty, global::System.Management.Automation.ErrorCategory.InvalidArgument, CloudHsmClusterInputObject) );
                        }
                        if (null == CloudHsmClusterInputObject.CloudHsmClusterName)
                        {
                            ThrowTerminatingError( new global::System.Management.Automation.ErrorRecord(new global::System.Exception("CloudHsmClusterInputObject has null value for CloudHsmClusterInputObject.CloudHsmClusterName"),string.Empty, global::System.Management.Automation.ErrorCategory.InvalidArgument, CloudHsmClusterInputObject) );
                        }
                        _propertiesBody = await this.Client.CloudHsmClusterPrivateEndpointConnectionsGetWithResult(CloudHsmClusterInputObject.SubscriptionId ?? null, CloudHsmClusterInputObject.ResourceGroupName ?? null, CloudHsmClusterInputObject.CloudHsmClusterName ?? null, PeConnectionName, this, Pipeline);
                        this.Update_propertiesBody();
                        await this.Client.CloudHsmClusterPrivateEndpointConnectionsCreate(CloudHsmClusterInputObject.SubscriptionId ?? null, CloudHsmClusterInputObject.ResourceGroupName ?? null, CloudHsmClusterInputObject.CloudHsmClusterName ?? null, PeConnectionName, _propertiesBody, onOk, onDefault, this, Pipeline, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeUpdate);
                    }
                    await ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.CmdletAfterAPICall); if( ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                }
                catch (Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.UndeclaredResponseException urexception)
                {
                    WriteError(new global::System.Management.Automation.ErrorRecord(urexception, urexception.StatusCode.ToString(), global::System.Management.Automation.ErrorCategory.InvalidOperation, new { PeConnectionName=PeConnectionName})
                    {
                      ErrorDetails = new global::System.Management.Automation.ErrorDetails(urexception.Message) { RecommendedAction = urexception.Action }
                    });
                }
                finally
                {
                    await ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Events.CmdletProcessRecordAsyncEnd);
                }
            }
        }

        /// <summary>Interrupts currently running code within the command.</summary>
        protected override void StopProcessing()
        {
            ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener)this).Cancel();
            base.StopProcessing();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAzHsmCloudHsmClusterPrivateEndpointConnection_UpdateViaIdentityCloudHsmClusterExpanded"
        /// /> cmdlet class.
        /// </summary>
        public UpdateAzHsmCloudHsmClusterPrivateEndpointConnection_UpdateViaIdentityCloudHsmClusterExpanded()
        {

        }

        private void Update_propertiesBody()
        {
            if ((bool)(true == this.MyInvocation?.BoundParameters.ContainsKey("Etag")))
            {
                this.Etag = (string)(this.MyInvocation?.BoundParameters["Etag"]);
            }
            if ((bool)(true == this.MyInvocation?.BoundParameters.ContainsKey("PrivateLinkServiceConnectionStateDescription")))
            {
                this.PrivateLinkServiceConnectionStateDescription = (string)(this.MyInvocation?.BoundParameters["PrivateLinkServiceConnectionStateDescription"]);
            }
            if ((bool)(true == this.MyInvocation?.BoundParameters.ContainsKey("PrivateLinkServiceConnectionStateStatus")))
            {
                this.PrivateLinkServiceConnectionStateStatus = (string)(this.MyInvocation?.BoundParameters["PrivateLinkServiceConnectionStateStatus"]);
            }
            if ((bool)(true == this.MyInvocation?.BoundParameters.ContainsKey("PrivateLinkServiceConnectionStateActionsRequired")))
            {
                this.PrivateLinkServiceConnectionStateActionsRequired = (string)(this.MyInvocation?.BoundParameters["PrivateLinkServiceConnectionStateActionsRequired"]);
            }
        }

        /// <param name="sendToPipeline"></param>
        new protected void WriteObject(object sendToPipeline)
        {
            Microsoft.Azure.PowerShell.Cmdlets.Hsm.Module.Instance.SanitizeOutput?.Invoke(sendToPipeline, __correlationId);
            base.WriteObject(sendToPipeline);
        }

        /// <param name="sendToPipeline"></param>
        /// <param name="enumerateCollection"></param>
        new protected void WriteObject(object sendToPipeline, bool enumerateCollection)
        {
            Microsoft.Azure.PowerShell.Cmdlets.Hsm.Module.Instance.SanitizeOutput?.Invoke(sendToPipeline, __correlationId);
            base.WriteObject(sendToPipeline, enumerateCollection);
        }

        /// <summary>
        /// a delegate that is called when the remote service returns default (any response code not handled elsewhere).
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse">Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse</see>
        /// from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onDefault(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse> response)
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
                    var ex = new Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorResponse>(responseMessage, await response);
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
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IPrivateEndpointConnection">Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IPrivateEndpointConnection</see>
        /// from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IPrivateEndpointConnection> response)
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
                // (await response) // should be Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IPrivateEndpointConnection
                var result = (await response);
                if (null != result)
                {
                    if (0 == _responseSize)
                    {
                        _firstResponse = result;
                        _responseSize = 1;
                    }
                    else
                    {
                        if (1 ==_responseSize)
                        {
                            // Flush buffer
                            WriteObject(_firstResponse.AddMultipleTypeNameIntoPSObject());
                        }
                        WriteObject(result.AddMultipleTypeNameIntoPSObject());
                        _responseSize = 2;
                    }
                }
            }
        }
    }
}