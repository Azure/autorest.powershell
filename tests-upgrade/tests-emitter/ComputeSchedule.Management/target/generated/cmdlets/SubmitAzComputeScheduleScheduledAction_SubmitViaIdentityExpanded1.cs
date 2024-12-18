// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Cmdlets
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Extensions;
    using Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.PowerShell;
    using Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Cmdlets;
    using System;

    /// <summary>virtualMachinesSubmitHibernate: submitHibernate for a virtual machine</summary>
    /// <remarks>
    /// [OpenAPI] VirtualMachinesSubmitHibernate=>POST:"/subscriptions/{subscriptionId}/providers/Microsoft.ComputeSchedule/locations/{locationparameter}/virtualMachinesSubmitHibernate"
    /// </remarks>
    [global::System.Management.Automation.Cmdlet(global::System.Management.Automation.VerbsLifecycle.Submit, @"AzComputeScheduleScheduledAction_SubmitViaIdentityExpanded1", SupportsShouldProcess = true)]
    [global::System.Management.Automation.OutputType(typeof(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IHibernateResourceOperationResponse))]
    [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Description(@"virtualMachinesSubmitHibernate: submitHibernate for a virtual machine")]
    [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Generated]
    [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.HttpPath(Path = "/subscriptions/{subscriptionId}/providers/Microsoft.ComputeSchedule/locations/{locationparameter}/virtualMachinesSubmitHibernate", ApiVersion = "2024-10-01")]
    public partial class SubmitAzComputeScheduleScheduledAction_SubmitViaIdentityExpanded1 : global::System.Management.Automation.PSCmdlet,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.IEventListener,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.IContext
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

        /// <summary>This is the request for hibernate</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ISubmitHibernateRequest _requestBody = new Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.SubmitHibernateRequest();

        /// <summary>
        /// A flag to tell whether it is the first returned object in a call. Zero means no response yet. One means 1 returned object.
        /// Two means multiple returned objects in response.
        /// </summary>
        private int _responseSize = 0;

        /// <summary>Wait for .NET debugger to attach</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Wait for .NET debugger to attach")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter Break { get; set; }

        /// <summary>Accessor for cancellationTokenSource.</summary>
        public global::System.Threading.CancellationTokenSource CancellationTokenSource { get => _cancellationTokenSource ; set { _cancellationTokenSource = value; } }

        /// <summary>The reference to the client API class.</summary>
        public Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.MicrosoftComputeSchedule Client => Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Module.Instance.ClientAPI;

        /// <summary>CorrelationId item</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "CorrelationId item")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"CorrelationId item",
        SerializedName = @"correlationid",
        PossibleTypes = new [] { typeof(string) })]
        public string Correlationid { get => _requestBody.Correlationid ?? null; set => _requestBody.Correlationid = value; }

        /// <summary>
        /// The DefaultProfile parameter is not functional. Use the SubscriptionId parameter when available if executing the cmdlet
        /// against a different subscription
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The DefaultProfile parameter is not functional. Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::System.Management.Automation.Alias("AzureRMContext", "AzureCredential")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.ParameterCategory.Azure)]
        public global::System.Management.Automation.PSObject DefaultProfile { get; set; }

        /// <summary>Details that could optimize the user's request</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Details that could optimize the user's request")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Details that could optimize the user's request",
        SerializedName = @"optimizationPreference",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PSArgumentCompleterAttribute("Cost", "Availability", "CostAvailabilityBalanced")]
        public string ExecutionParameterOptimizationPreference { get => _requestBody.ExecutionParameterOptimizationPreference ?? null; set => _requestBody.ExecutionParameterOptimizationPreference = value; }

        /// <summary>Accessor for extensibleParameters.</summary>
        public global::System.Collections.Generic.IDictionary<global::System.String,global::System.Object> ExtensibleParameters { get => _extensibleParameters ; }

        /// <summary>SendAsync Pipeline Steps to be appended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be appended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.ParameterCategory.Runtime)]
        public Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.SendAsyncStep[] HttpPipelineAppend { get; set; }

        /// <summary>SendAsync Pipeline Steps to be prepended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be prepended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.ParameterCategory.Runtime)]
        public Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.SendAsyncStep[] HttpPipelinePrepend { get; set; }

        /// <summary>Backing field for <see cref="InputObject" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IComputeScheduleIdentity _inputObject;

        /// <summary>Identity Parameter</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "Identity Parameter", ValueFromPipeline = true)]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.ParameterCategory.Path)]
        public Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IComputeScheduleIdentity InputObject { get => this._inputObject; set => this._inputObject = value; }

        /// <summary>Accessor for our copy of the InvocationInfo.</summary>
        public global::System.Management.Automation.InvocationInfo InvocationInformation { get => __invocationInfo = __invocationInfo ?? this.MyInvocation ; set { __invocationInfo = value; } }

        /// <summary>
        /// <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.IEventListener" /> cancellation delegate. Stops the cmdlet when called.
        /// </summary>
        global::System.Action Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.IEventListener.Cancel => _cancellationTokenSource.Cancel;

        /// <summary><see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.IEventListener" /> cancellation token.</summary>
        global::System.Threading.CancellationToken Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.IEventListener.Token => _cancellationTokenSource.Token;

        /// <summary>
        /// The instance of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.HttpPipeline" /> that the remote call will use.
        /// </summary>
        public Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.HttpPipeline Pipeline { get; set; }

        /// <summary>The URI for the proxy server to use</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "The URI for the proxy server to use")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.ParameterCategory.Runtime)]
        public global::System.Uri Proxy { get; set; }

        /// <summary>Credentials for a proxy server to use for the remote call</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Credentials for a proxy server to use for the remote call")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.ParameterCategory.Runtime)]
        public global::System.Management.Automation.PSCredential ProxyCredential { get; set; }

        /// <summary>Use the default credentials for the proxy</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Use the default credentials for the proxy")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter ProxyUseDefaultCredentials { get; set; }

        /// <summary>The resource ids used for the request</summary>
        [global::System.Management.Automation.AllowEmptyCollection]
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The resource ids used for the request")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The resource ids used for the request",
        SerializedName = @"ids",
        PossibleTypes = new [] { typeof(string) })]
        public string[] ResourceId { get => _requestBody.ResourceId?.ToArray() ?? null /* fixedArrayOf */; set => _requestBody.ResourceId = (value != null ? new System.Collections.Generic.List<string>(value) : null); }

        /// <summary>Retry count for user request</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Retry count for user request")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Retry count for user request",
        SerializedName = @"retryCount",
        PossibleTypes = new [] { typeof(int) })]
        public int RetryPolicyRetryCount { get => _requestBody.RetryPolicyRetryCount ?? default(int); set => _requestBody.RetryPolicyRetryCount = value; }

        /// <summary>Retry window in minutes for user request</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Retry window in minutes for user request")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Retry window in minutes for user request",
        SerializedName = @"retryWindowInMinutes",
        PossibleTypes = new [] { typeof(int) })]
        public int RetryPolicyRetryWindowInMinute { get => _requestBody.RetryPolicyRetryWindowInMinute ?? default(int); set => _requestBody.RetryPolicyRetryWindowInMinute = value; }

        /// <summary>The deadline for the operation</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The deadline for the operation")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The deadline for the operation",
        SerializedName = @"deadLine",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        public global::System.DateTime ScheduleDeadLine { get => _requestBody.ScheduleDeadLine ?? default(global::System.DateTime); set => _requestBody.ScheduleDeadLine = value; }

        /// <summary>The deadline for the operation</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The deadline for the operation")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The deadline for the operation",
        SerializedName = @"deadline",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        public global::System.DateTime ScheduleDeadline { get => _requestBody.ScheduleDeadline ?? default(global::System.DateTime); set => _requestBody.ScheduleDeadline = value; }

        /// <summary>The deadlinetype of the operation, this can either be InitiateAt or CompleteBy</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The deadlinetype of the operation, this can either be InitiateAt or CompleteBy")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The deadlinetype of the operation, this can either be InitiateAt or CompleteBy",
        SerializedName = @"deadlineType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PSArgumentCompleterAttribute("Unknown", "InitiateAt", "CompleteBy")]
        public string ScheduleDeadlineType { get => _requestBody.ScheduleDeadlineType ?? null; set => _requestBody.ScheduleDeadlineType = value; }

        /// <summary>The timezone for the operation</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The timezone for the operation")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The timezone for the operation",
        SerializedName = @"timeZone",
        PossibleTypes = new [] { typeof(string) })]
        public string ScheduleTimeZone { get => _requestBody.ScheduleTimeZone ?? null; set => _requestBody.ScheduleTimeZone = value; }

        /// <summary>The timezone for the operation</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The timezone for the operation")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The timezone for the operation",
        SerializedName = @"timezone",
        PossibleTypes = new [] { typeof(string) })]
        public string ScheduleTimezone { get => _requestBody.ScheduleTimezone ?? null; set => _requestBody.ScheduleTimezone = value; }

        /// <summary>
        /// <c>overrideOnDefault</c> will be called before the regular onDefault has been processed, allowing customization of what
        /// happens on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IErrorResponse">Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IErrorResponse</see>
        /// from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onDefault method should be processed, or if the method should
        /// return immediately (set to true to skip further processing )</param>

        partial void overrideOnDefault(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IErrorResponse> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// <c>overrideOnOk</c> will be called before the regular onOk has been processed, allowing customization of what happens
        /// on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IHibernateResourceOperationResponse">Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IHibernateResourceOperationResponse</see>
        /// from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onOk method should be processed, or if the method should return
        /// immediately (set to true to skip further processing )</param>

        partial void overrideOnOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IHibernateResourceOperationResponse> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// (overrides the default BeginProcessing method in global::System.Management.Automation.PSCmdlet)
        /// </summary>
        protected override void BeginProcessing()
        {
            var telemetryId = Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Module.Instance.GetTelemetryId.Invoke();
            if (telemetryId != "" && telemetryId != "internal")
            {
                __correlationId = telemetryId;
            }
            Module.Instance.SetProxyConfiguration(Proxy, ProxyCredential, ProxyUseDefaultCredentials);
            if (Break)
            {
                Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.AttachDebugger.Break();
            }
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Events.CmdletBeginProcessing).Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
        }

        /// <summary>Performs clean-up after the command execution</summary>
        protected override void EndProcessing()
        {
            if (1 ==_responseSize)
            {
                // Flush buffer
                WriteObject(_firstResponse);
            }
            var telemetryInfo = Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Module.Instance.GetTelemetryInfo?.Invoke(__correlationId);
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
         async global::System.Threading.Tasks.Task Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.IEventListener.Signal(string id, global::System.Threading.CancellationToken token, global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.EventData> messageData)
        {
            using( NoSynchronizationContext )
            {
                if (token.IsCancellationRequested)
                {
                    return ;
                }

                switch ( id )
                {
                    case Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Events.Verbose:
                    {
                        WriteVerbose($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Events.Warning:
                    {
                        WriteWarning($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Events.Information:
                    {
                        var data = messageData();
                        WriteInformation(data.Message, new string[]{});
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Events.Debug:
                    {
                        WriteDebug($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Events.Error:
                    {
                        WriteError(new global::System.Management.Automation.ErrorRecord( new global::System.Exception(messageData().Message), string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null ) );
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Events.Progress:
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
                await Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Module.Instance.Signal(id, token, messageData, (i, t, m) => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.IEventListener)this).Signal(i, t, () => Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.EventDataConverter.ConvertFrom(m()) as Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.EventData), InvocationInformation, this.ParameterSetName, __correlationId, __processRecordId, null );
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
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Events.CmdletProcessRecordStart).Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
            __processRecordId = System.Guid.NewGuid().ToString();
            try
            {
                // work
                if (ShouldProcess($"Call remote 'ScheduledActionsVirtualMachinesSubmitHibernate' operation"))
                {
                    using( var asyncCommandRuntime = new Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.PowerShell.AsyncCommandRuntime(this, ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.IEventListener)this).Token) )
                    {
                        asyncCommandRuntime.Wait( ProcessRecordAsync(),((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.IEventListener)this).Token);
                    }
                }
            }
            catch (global::System.AggregateException aggregateException)
            {
                // unroll the inner exceptions to get the root cause
                foreach( var innerException in aggregateException.Flatten().InnerExceptions )
                {
                    ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Events.CmdletException, $"{innerException.GetType().Name} - {innerException.Message} : {innerException.StackTrace}").Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    // Write exception out to error channel.
                    WriteError( new global::System.Management.Automation.ErrorRecord(innerException,string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null) );
                }
            }
            catch (global::System.Exception exception) when ((exception as System.Management.Automation.PipelineStoppedException)== null || (exception as System.Management.Automation.PipelineStoppedException).InnerException != null)
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Events.CmdletException, $"{exception.GetType().Name} - {exception.Message} : {exception.StackTrace}").Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                // Write exception out to error channel.
                WriteError( new global::System.Management.Automation.ErrorRecord(exception,string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null) );
            }
            finally
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Events.CmdletProcessRecordEnd).Wait();
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
                await ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Events.CmdletGetPipeline); if( ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                Pipeline = Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Module.Instance.CreatePipeline(InvocationInformation, __correlationId, __processRecordId, this.ParameterSetName, this.ExtensibleParameters);
                if (null != HttpPipelinePrepend)
                {
                    Pipeline.Prepend((this.CommandRuntime as Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelinePrepend) ?? HttpPipelinePrepend);
                }
                if (null != HttpPipelineAppend)
                {
                    Pipeline.Append((this.CommandRuntime as Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelineAppend) ?? HttpPipelineAppend);
                }
                // get the client instance
                try
                {
                    await ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Events.CmdletBeforeAPICall); if( ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    if (InputObject?.Id != null)
                    {
                        await this.Client.ScheduledActionsVirtualMachinesSubmitHibernateViaIdentity(InputObject.Id, _requestBody, onOk, onDefault, this, Pipeline);
                    }
                    else
                    {
                        // try to call with PATH parameters from Input Object
                        if (null == InputObject.SubscriptionId)
                        {
                            ThrowTerminatingError( new global::System.Management.Automation.ErrorRecord(new global::System.Exception("InputObject has null value for InputObject.SubscriptionId"),string.Empty, global::System.Management.Automation.ErrorCategory.InvalidArgument, InputObject) );
                        }
                        if (null == InputObject.Locationparameter)
                        {
                            ThrowTerminatingError( new global::System.Management.Automation.ErrorRecord(new global::System.Exception("InputObject has null value for InputObject.Locationparameter"),string.Empty, global::System.Management.Automation.ErrorCategory.InvalidArgument, InputObject) );
                        }
                        await this.Client.ScheduledActionsVirtualMachinesSubmitHibernate(InputObject.SubscriptionId ?? null, InputObject.Locationparameter ?? null, _requestBody, onOk, onDefault, this, Pipeline);
                    }
                    await ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Events.CmdletAfterAPICall); if( ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                }
                catch (Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.UndeclaredResponseException urexception)
                {
                    WriteError(new global::System.Management.Automation.ErrorRecord(urexception, urexception.StatusCode.ToString(), global::System.Management.Automation.ErrorCategory.InvalidOperation, new { })
                    {
                      ErrorDetails = new global::System.Management.Automation.ErrorDetails(urexception.Message) { RecommendedAction = urexception.Action }
                    });
                }
                finally
                {
                    await ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Events.CmdletProcessRecordAsyncEnd);
                }
            }
        }

        /// <summary>Interrupts currently running code within the command.</summary>
        protected override void StopProcessing()
        {
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.IEventListener)this).Cancel();
            base.StopProcessing();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitAzComputeScheduleScheduledAction_SubmitViaIdentityExpanded1" /> cmdlet
        /// class.
        /// </summary>
        public SubmitAzComputeScheduleScheduledAction_SubmitViaIdentityExpanded1()
        {

        }

        /// <param name="sendToPipeline"></param>
        new protected void WriteObject(object sendToPipeline)
        {
            Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Module.Instance.SanitizeOutput?.Invoke(sendToPipeline, __correlationId);
            base.WriteObject(sendToPipeline);
        }

        /// <param name="sendToPipeline"></param>
        /// <param name="enumerateCollection"></param>
        new protected void WriteObject(object sendToPipeline, bool enumerateCollection)
        {
            Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Module.Instance.SanitizeOutput?.Invoke(sendToPipeline, __correlationId);
            base.WriteObject(sendToPipeline, enumerateCollection);
        }

        /// <summary>
        /// a delegate that is called when the remote service returns default (any response code not handled elsewhere).
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IErrorResponse">Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IErrorResponse</see>
        /// from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onDefault(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IErrorResponse> response)
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
                    var ex = new Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IErrorResponse>(responseMessage, await response);
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
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IHibernateResourceOperationResponse">Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IHibernateResourceOperationResponse</see>
        /// from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IHibernateResourceOperationResponse> response)
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
                // (await response) // should be Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IHibernateResourceOperationResponse
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