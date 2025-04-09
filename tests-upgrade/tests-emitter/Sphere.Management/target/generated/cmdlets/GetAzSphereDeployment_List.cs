// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Sphere.Cmdlets
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Extensions;
    using Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.PowerShell;
    using Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Cmdlets;
    using System;

    /// <summary>
    /// List Deployment resources by DeviceGroup. '.default' and '.unassigned' are system defined values and cannot be used for
    /// product or device group name.
    /// </summary>
    /// <remarks>
    /// [OpenAPI] ListByDeviceGroup=>GET:"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureSphere/catalogs/{catalogName}/products/{productName}/deviceGroups/{deviceGroupName}/deployments"
    /// </remarks>
    [global::System.Management.Automation.Cmdlet(global::System.Management.Automation.VerbsCommon.Get, @"AzSphereDeployment_List")]
    [global::System.Management.Automation.OutputType(typeof(Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeployment))]
    [global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.Description(@"List Deployment resources by DeviceGroup. '.default' and '.unassigned' are system defined values and cannot be used for product or device group name.")]
    [global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.Generated]
    [global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.HttpPath(Path = "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureSphere/catalogs/{catalogName}/products/{productName}/deviceGroups/{deviceGroupName}/deployments", ApiVersion = "2024-04-01")]
    public partial class GetAzSphereDeployment_List : global::System.Management.Automation.PSCmdlet,
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IEventListener,
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IContext
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

        /// <summary>A flag to tell whether it is the first onOK call.</summary>
        private bool _isFirst = true;

        /// <summary>Link to retrieve next page.</summary>
        private string _nextLink;

        /// <summary>
        /// A flag to tell whether it is the first returned object in a call. Zero means no response yet. One means 1 returned object.
        /// Two means multiple returned objects in response.
        /// </summary>
        private int _responseSize = 0;

        /// <summary>Wait for .NET debugger to attach</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Wait for .NET debugger to attach")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter Break { get; set; }

        /// <summary>Accessor for cancellationTokenSource.</summary>
        public global::System.Threading.CancellationTokenSource CancellationTokenSource { get => _cancellationTokenSource ; set { _cancellationTokenSource = value; } }

        /// <summary>Backing field for <see cref="CatalogName" /> property.</summary>
        private string _catalogName;

        /// <summary>Name of catalog</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "Name of catalog")]
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Name of catalog",
        SerializedName = @"catalogName",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.ParameterCategory.Path)]
        public string CatalogName { get => this._catalogName; set => this._catalogName = value; }

        /// <summary>The reference to the client API class.</summary>
        public Microsoft.Azure.PowerShell.Cmdlets.Sphere.Sphere Client => Microsoft.Azure.PowerShell.Cmdlets.Sphere.Module.Instance.ClientAPI;

        /// <summary>
        /// The DefaultProfile parameter is not functional. Use the SubscriptionId parameter when available if executing the cmdlet
        /// against a different subscription
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The DefaultProfile parameter is not functional. Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::System.Management.Automation.Alias("AzureRMContext", "AzureCredential")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.ParameterCategory.Azure)]
        public global::System.Management.Automation.PSObject DefaultProfile { get; set; }

        /// <summary>Backing field for <see cref="DeviceGroupName" /> property.</summary>
        private string _deviceGroupName;

        /// <summary>Name of device group.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "Name of device group.")]
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Name of device group.",
        SerializedName = @"deviceGroupName",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.ParameterCategory.Path)]
        public string DeviceGroupName { get => this._deviceGroupName; set => this._deviceGroupName = value; }

        /// <summary>Accessor for extensibleParameters.</summary>
        public global::System.Collections.Generic.IDictionary<global::System.String,global::System.Object> ExtensibleParameters { get => _extensibleParameters ; }

        /// <summary>Backing field for <see cref="Filter" /> property.</summary>
        private string _filter;

        /// <summary>Filter the result list using the given expression</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Filter the result list using the given expression")]
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Filter the result list using the given expression",
        SerializedName = @"$filter",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.ParameterCategory.Query)]
        public string Filter { get => this._filter; set => this._filter = value; }

        /// <summary>SendAsync Pipeline Steps to be appended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be appended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.ParameterCategory.Runtime)]
        public Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.SendAsyncStep[] HttpPipelineAppend { get; set; }

        /// <summary>SendAsync Pipeline Steps to be prepended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be prepended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.ParameterCategory.Runtime)]
        public Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.SendAsyncStep[] HttpPipelinePrepend { get; set; }

        /// <summary>Accessor for our copy of the InvocationInfo.</summary>
        public global::System.Management.Automation.InvocationInfo InvocationInformation { get => __invocationInfo = __invocationInfo ?? this.MyInvocation ; set { __invocationInfo = value; } }

        /// <summary>Backing field for <see cref="Maxpagesize" /> property.</summary>
        private int _maxpagesize;

        /// <summary>The maximum number of result items per page.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The maximum number of result items per page.")]
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The maximum number of result items per page.",
        SerializedName = @"$maxpagesize",
        PossibleTypes = new [] { typeof(int) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.ParameterCategory.Query)]
        public int Maxpagesize { get => this._maxpagesize; set => this._maxpagesize = value; }

        /// <summary>
        /// <see cref="Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IEventListener" /> cancellation delegate. Stops the cmdlet when called.
        /// </summary>
        global::System.Action Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IEventListener.Cancel => _cancellationTokenSource.Cancel;

        /// <summary><see cref="Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IEventListener" /> cancellation token.</summary>
        global::System.Threading.CancellationToken Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IEventListener.Token => _cancellationTokenSource.Token;

        /// <summary>
        /// The instance of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.HttpPipeline" /> that the remote call will use.
        /// </summary>
        public Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.HttpPipeline Pipeline { get; set; }

        /// <summary>Backing field for <see cref="ProductName" /> property.</summary>
        private string _productName;

        /// <summary>Name of product.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "Name of product.")]
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Name of product.",
        SerializedName = @"productName",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.ParameterCategory.Path)]
        public string ProductName { get => this._productName; set => this._productName = value; }

        /// <summary>The URI for the proxy server to use</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "The URI for the proxy server to use")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.ParameterCategory.Runtime)]
        public global::System.Uri Proxy { get; set; }

        /// <summary>Credentials for a proxy server to use for the remote call</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Credentials for a proxy server to use for the remote call")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.ParameterCategory.Runtime)]
        public global::System.Management.Automation.PSCredential ProxyCredential { get; set; }

        /// <summary>Use the default credentials for the proxy</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Use the default credentials for the proxy")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter ProxyUseDefaultCredentials { get; set; }

        /// <summary>Backing field for <see cref="ResourceGroupName" /> property.</summary>
        private string _resourceGroupName;

        /// <summary>The name of the resource group. The name is case insensitive.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The name of the resource group. The name is case insensitive.")]
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The name of the resource group. The name is case insensitive.",
        SerializedName = @"resourceGroupName",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.ParameterCategory.Path)]
        public string ResourceGroupName { get => this._resourceGroupName; set => this._resourceGroupName = value; }

        /// <summary>Backing field for <see cref="Skip" /> property.</summary>
        private int _skip;

        /// <summary>The number of result items to skip.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The number of result items to skip.")]
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of result items to skip.",
        SerializedName = @"$skip",
        PossibleTypes = new [] { typeof(int) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.ParameterCategory.Query)]
        public int Skip { get => this._skip; set => this._skip = value; }

        /// <summary>Backing field for <see cref="SubscriptionId" /> property.</summary>
        private string[] _subscriptionId;

        /// <summary>The ID of the target subscription. The value must be an UUID.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The ID of the target subscription. The value must be an UUID.")]
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The ID of the target subscription. The value must be an UUID.",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.DefaultInfo(
        Name = @"",
        Description =@"",
        Script = @"(Get-AzContext).Subscription.Id",
        SetCondition = @"")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.ParameterCategory.Path)]
        public string[] SubscriptionId { get => this._subscriptionId; set => this._subscriptionId = value; }

        /// <summary>Backing field for <see cref="Top" /> property.</summary>
        private int _top;

        /// <summary>The number of result items to return.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The number of result items to return.")]
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of result items to return.",
        SerializedName = @"$top",
        PossibleTypes = new [] { typeof(int) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.ParameterCategory.Query)]
        public int Top { get => this._top; set => this._top = value; }

        /// <summary>
        /// <c>overrideOnDefault</c> will be called before the regular onDefault has been processed, allowing customization of what
        /// happens on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IErrorResponse">Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IErrorResponse</see>
        /// from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onDefault method should be processed, or if the method should
        /// return immediately (set to true to skip further processing )</param>

        partial void overrideOnDefault(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IErrorResponse> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// <c>overrideOnOk</c> will be called before the regular onOk has been processed, allowing customization of what happens
        /// on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeploymentListResult">Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeploymentListResult</see>
        /// from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onOk method should be processed, or if the method should return
        /// immediately (set to true to skip further processing )</param>

        partial void overrideOnOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeploymentListResult> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// (overrides the default BeginProcessing method in global::System.Management.Automation.PSCmdlet)
        /// </summary>
        protected override void BeginProcessing()
        {
            var telemetryId = Microsoft.Azure.PowerShell.Cmdlets.Sphere.Module.Instance.GetTelemetryId.Invoke();
            if (telemetryId != "" && telemetryId != "internal")
            {
                __correlationId = telemetryId;
            }
            Module.Instance.SetProxyConfiguration(Proxy, ProxyCredential, ProxyUseDefaultCredentials);
            if (Break)
            {
                Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.AttachDebugger.Break();
            }
            ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Events.CmdletBeginProcessing).Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
        }

        /// <summary>Performs clean-up after the command execution</summary>
        protected override void EndProcessing()
        {
            if (1 ==_responseSize)
            {
                // Flush buffer
                WriteObject(_firstResponse);
            }
            var telemetryInfo = Microsoft.Azure.PowerShell.Cmdlets.Sphere.Module.Instance.GetTelemetryInfo?.Invoke(__correlationId);
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

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAzSphereDeployment_List" /> cmdlet class.
        /// </summary>
        public GetAzSphereDeployment_List()
        {

        }

        /// <summary>Handles/Dispatches events during the call to the REST service.</summary>
        /// <param name="id">The message id</param>
        /// <param name="token">The message cancellation token. When this call is cancelled, this should be <c>true</c></param>
        /// <param name="messageData">Detailed message data for the message event.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the message is completed.
        /// </returns>
         async global::System.Threading.Tasks.Task Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IEventListener.Signal(string id, global::System.Threading.CancellationToken token, global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.EventData> messageData)
        {
            using( NoSynchronizationContext )
            {
                if (token.IsCancellationRequested)
                {
                    return ;
                }

                switch ( id )
                {
                    case Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Events.Verbose:
                    {
                        WriteVerbose($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Events.Warning:
                    {
                        WriteWarning($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Events.Information:
                    {
                        var data = messageData();
                        WriteInformation(data.Message, new string[]{});
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Events.Debug:
                    {
                        WriteDebug($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Events.Error:
                    {
                        WriteError(new global::System.Management.Automation.ErrorRecord( new global::System.Exception(messageData().Message), string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null ) );
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Events.Progress:
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
                await Microsoft.Azure.PowerShell.Cmdlets.Sphere.Module.Instance.Signal(id, token, messageData, (i, t, m) => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IEventListener)this).Signal(i, t, () => Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.EventDataConverter.ConvertFrom(m()) as Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.EventData), InvocationInformation, this.ParameterSetName, __correlationId, __processRecordId, null );
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
            ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Events.CmdletProcessRecordStart).Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
            __processRecordId = System.Guid.NewGuid().ToString();
            try
            {
                // work
                using( var asyncCommandRuntime = new Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.PowerShell.AsyncCommandRuntime(this, ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IEventListener)this).Token) )
                {
                    asyncCommandRuntime.Wait( ProcessRecordAsync(),((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IEventListener)this).Token);
                }
            }
            catch (global::System.AggregateException aggregateException)
            {
                // unroll the inner exceptions to get the root cause
                foreach( var innerException in aggregateException.Flatten().InnerExceptions )
                {
                    ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Events.CmdletException, $"{innerException.GetType().Name} - {innerException.Message} : {innerException.StackTrace}").Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    // Write exception out to error channel.
                    WriteError( new global::System.Management.Automation.ErrorRecord(innerException,string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null) );
                }
            }
            catch (global::System.Exception exception) when ((exception as System.Management.Automation.PipelineStoppedException)== null || (exception as System.Management.Automation.PipelineStoppedException).InnerException != null)
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Events.CmdletException, $"{exception.GetType().Name} - {exception.Message} : {exception.StackTrace}").Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                // Write exception out to error channel.
                WriteError( new global::System.Management.Automation.ErrorRecord(exception,string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null) );
            }
            finally
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Events.CmdletProcessRecordEnd).Wait();
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
                await ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Events.CmdletGetPipeline); if( ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                Pipeline = Microsoft.Azure.PowerShell.Cmdlets.Sphere.Module.Instance.CreatePipeline(InvocationInformation, __correlationId, __processRecordId, this.ParameterSetName, this.ExtensibleParameters);
                if (null != HttpPipelinePrepend)
                {
                    Pipeline.Prepend((this.CommandRuntime as Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelinePrepend) ?? HttpPipelinePrepend);
                }
                if (null != HttpPipelineAppend)
                {
                    Pipeline.Append((this.CommandRuntime as Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelineAppend) ?? HttpPipelineAppend);
                }
                // get the client instance
                try
                {
                    foreach( var SubscriptionId in this.SubscriptionId )
                    {
                        await ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Events.CmdletBeforeAPICall); if( ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                        await this.Client.DeploymentsListByDeviceGroup(SubscriptionId, ResourceGroupName, CatalogName, ProductName, DeviceGroupName, this.InvocationInformation.BoundParameters.ContainsKey("Filter") ? Filter : null, this.InvocationInformation.BoundParameters.ContainsKey("Top") ? Top : default(int?), this.InvocationInformation.BoundParameters.ContainsKey("Skip") ? Skip : default(int?), this.InvocationInformation.BoundParameters.ContainsKey("Maxpagesize") ? Maxpagesize : default(int?), onOk, onDefault, this, Pipeline);
                        await ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Events.CmdletAfterAPICall); if( ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    }
                }
                catch (Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.UndeclaredResponseException urexception)
                {
                    WriteError(new global::System.Management.Automation.ErrorRecord(urexception, urexception.StatusCode.ToString(), global::System.Management.Automation.ErrorCategory.InvalidOperation, new { SubscriptionId=SubscriptionId,ResourceGroupName=ResourceGroupName,CatalogName=CatalogName,Filter=this.InvocationInformation.BoundParameters.ContainsKey("Filter") ? Filter : null,Top=this.InvocationInformation.BoundParameters.ContainsKey("Top") ? Top : default(int?),Skip=this.InvocationInformation.BoundParameters.ContainsKey("Skip") ? Skip : default(int?),Maxpagesize=this.InvocationInformation.BoundParameters.ContainsKey("Maxpagesize") ? Maxpagesize : default(int?),ProductName=ProductName,DeviceGroupName=DeviceGroupName})
                    {
                      ErrorDetails = new global::System.Management.Automation.ErrorDetails(urexception.Message) { RecommendedAction = urexception.Action }
                    });
                }
                finally
                {
                    await ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Events.CmdletProcessRecordAsyncEnd);
                }
            }
        }

        /// <summary>Interrupts currently running code within the command.</summary>
        protected override void StopProcessing()
        {
            ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IEventListener)this).Cancel();
            base.StopProcessing();
        }

        /// <param name="sendToPipeline"></param>
        new protected void WriteObject(object sendToPipeline)
        {
            Microsoft.Azure.PowerShell.Cmdlets.Sphere.Module.Instance.SanitizeOutput?.Invoke(sendToPipeline, __correlationId);
            base.WriteObject(sendToPipeline);
        }

        /// <param name="sendToPipeline"></param>
        /// <param name="enumerateCollection"></param>
        new protected void WriteObject(object sendToPipeline, bool enumerateCollection)
        {
            Microsoft.Azure.PowerShell.Cmdlets.Sphere.Module.Instance.SanitizeOutput?.Invoke(sendToPipeline, __correlationId);
            base.WriteObject(sendToPipeline, enumerateCollection);
        }

        /// <summary>
        /// a delegate that is called when the remote service returns default (any response code not handled elsewhere).
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IErrorResponse">Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IErrorResponse</see>
        /// from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onDefault(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IErrorResponse> response)
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
                    var ex = new Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IErrorResponse>(responseMessage, await response);
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
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeploymentListResult">Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeploymentListResult</see>
        /// from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeploymentListResult> response)
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
                // (await response) // should be Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeploymentListResult
                var result = (await response);
                // response should be returning an array of some kind. +Pageable
                // pageable / value / nextLink
                if (null != result.Value)
                {
                    if (0 == _responseSize && 1 == result.Value.Count)
                    {
                        _firstResponse = result.Value[0];
                        _responseSize = 1;
                    }
                    else
                    {
                        if (1 ==_responseSize)
                        {
                            // Flush buffer
                            WriteObject(_firstResponse.AddMultipleTypeNameIntoPSObject());
                        }
                        var values = new System.Collections.Generic.List<System.Management.Automation.PSObject>();
                        foreach( var value in result.Value )
                        {
                            values.Add(value.AddMultipleTypeNameIntoPSObject());
                        }
                        WriteObject(values, true);
                        _responseSize = 2;
                    }
                }
                _nextLink = result.NextLink;
                if (_isFirst)
                {
                    _isFirst = false;
                    while (!String.IsNullOrEmpty(_nextLink))
                    {
                        if (responseMessage.RequestMessage is System.Net.Http.HttpRequestMessage requestMessage )
                        {
                            requestMessage = requestMessage.Clone(new global::System.Uri( _nextLink ),Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Method.Get );
                            await ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Events.FollowingNextLink); if( ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                            await this.Client.DeploymentsListByDeviceGroup_Call(requestMessage, onOk, onDefault, this, Pipeline);
                        }
                    }
                }
            }
        }
    }
}