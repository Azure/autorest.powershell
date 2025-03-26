// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Cmdlets
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Extensions;
    using Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.PowerShell;
    using Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Cmdlets;
    using System;

    /// <summary>Revoke a certificate under a certificate profile.</summary>
    /// <remarks>
    /// [OpenAPI] RevokeCertificate=>POST:"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CodeSigning/codeSigningAccounts/{accountName}/certificateProfiles/{profileName}/revokeCertificate"
    /// </remarks>
    [global::System.Management.Automation.Cmdlet(global::System.Management.Automation.VerbsSecurity.Revoke, @"AzCodeSigningCertificateProfileCertificate_RevokeViaIdentityCodeSigningAccountExpanded", SupportsShouldProcess = true)]
    [global::System.Management.Automation.OutputType(typeof(bool))]
    [global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Description(@"Revoke a certificate under a certificate profile.")]
    [global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Generated]
    [global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.HttpPath(Path = "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CodeSigning/codeSigningAccounts/{accountName}/certificateProfiles/{profileName}/revokeCertificate", ApiVersion = "2024-09-30-preview")]
    public partial class RevokeAzCodeSigningCertificateProfileCertificate_RevokeViaIdentityCodeSigningAccountExpanded : global::System.Management.Automation.PSCmdlet,
        Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.IEventListener,
        Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.IContext
    {
        /// <summary>A unique id generatd for the this cmdlet when it is instantiated.</summary>
        private string __correlationId = System.Guid.NewGuid().ToString();

        /// <summary>A copy of the Invocation Info (necessary to allow asJob to clone this cmdlet)</summary>
        private global::System.Management.Automation.InvocationInfo __invocationInfo;

        /// <summary>A unique id generatd for the this cmdlet when ProcessRecord() is called.</summary>
        private string __processRecordId;

        /// <summary>Defines the certificate revocation properties.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IRevokeCertificate _body = new Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.RevokeCertificate();

        /// <summary>
        /// The <see cref="global::System.Threading.CancellationTokenSource" /> for this operation.
        /// </summary>
        private global::System.Threading.CancellationTokenSource _cancellationTokenSource = new global::System.Threading.CancellationTokenSource();

        /// <summary>A dictionary to carry over additional data for pipeline.</summary>
        private global::System.Collections.Generic.Dictionary<global::System.String,global::System.Object> _extensibleParameters = new System.Collections.Generic.Dictionary<string, object>();

        /// <summary>A buffer to record first returned object in response.</summary>
        private object _firstResponse = null;

        /// <summary>
        /// A flag to tell whether it is the first returned object in a call. Zero means no response yet. One means 1 returned object.
        /// Two means multiple returned objects in response.
        /// </summary>
        private int _responseSize = 0;

        /// <summary>Wait for .NET debugger to attach</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Wait for .NET debugger to attach")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Category(global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter Break { get; set; }

        /// <summary>Accessor for cancellationTokenSource.</summary>
        public global::System.Threading.CancellationTokenSource CancellationTokenSource { get => _cancellationTokenSource ; set { _cancellationTokenSource = value; } }

        /// <summary>The reference to the client API class.</summary>
        public Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.CodeSigningManagementClient Client => Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Module.Instance.ClientAPI;

        /// <summary>Backing field for <see cref="CodeSigningAccountInputObject" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICodeSigningIdentity _codeSigningAccountInputObject;

        /// <summary>Identity Parameter</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "Identity Parameter", ValueFromPipeline = true)]
        [global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Category(global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.ParameterCategory.Path)]
        public Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICodeSigningIdentity CodeSigningAccountInputObject { get => this._codeSigningAccountInputObject; set => this._codeSigningAccountInputObject = value; }

        /// <summary>
        /// The DefaultProfile parameter is not functional. Use the SubscriptionId parameter when available if executing the cmdlet
        /// against a different subscription
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The DefaultProfile parameter is not functional. Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::System.Management.Automation.Alias("AzureRMContext", "AzureCredential")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Category(global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.ParameterCategory.Azure)]
        public global::System.Management.Automation.PSObject DefaultProfile { get; set; }

        /// <summary>The timestamp when the revocation is effective.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The timestamp when the revocation is effective.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Category(global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The timestamp when the revocation is effective.",
        SerializedName = @"effectiveAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        public global::System.DateTime EffectiveAt { get => _body.EffectiveAt; set => _body.EffectiveAt = value; }

        /// <summary>Accessor for extensibleParameters.</summary>
        public global::System.Collections.Generic.IDictionary<global::System.String,global::System.Object> ExtensibleParameters { get => _extensibleParameters ; }

        /// <summary>SendAsync Pipeline Steps to be appended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be appended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Category(global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.ParameterCategory.Runtime)]
        public Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.SendAsyncStep[] HttpPipelineAppend { get; set; }

        /// <summary>SendAsync Pipeline Steps to be prepended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be prepended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Category(global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.ParameterCategory.Runtime)]
        public Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.SendAsyncStep[] HttpPipelinePrepend { get; set; }

        /// <summary>Accessor for our copy of the InvocationInfo.</summary>
        public global::System.Management.Automation.InvocationInfo InvocationInformation { get => __invocationInfo = __invocationInfo ?? this.MyInvocation ; set { __invocationInfo = value; } }

        /// <summary>
        /// <see cref="Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.IEventListener" /> cancellation delegate. Stops the cmdlet when called.
        /// </summary>
        global::System.Action Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.IEventListener.Cancel => _cancellationTokenSource.Cancel;

        /// <summary><see cref="Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.IEventListener" /> cancellation token.</summary>
        global::System.Threading.CancellationToken Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.IEventListener.Token => _cancellationTokenSource.Token;

        /// <summary>
        /// When specified, forces the cmdlet return a 'bool' given that there isn't a return type by default.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Returns true when the command succeeds")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Category(global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter PassThru { get; set; }

        /// <summary>
        /// The instance of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.HttpPipeline" /> that the remote call will use.
        /// </summary>
        public Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.HttpPipeline Pipeline { get; set; }

        /// <summary>Backing field for <see cref="ProfileName" /> property.</summary>
        private string _profileName;

        /// <summary>Certificate profile name.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "Certificate profile name.")]
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Certificate profile name.",
        SerializedName = @"profileName",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Category(global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.ParameterCategory.Path)]
        public string ProfileName { get => this._profileName; set => this._profileName = value; }

        /// <summary>The URI for the proxy server to use</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "The URI for the proxy server to use")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Category(global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.ParameterCategory.Runtime)]
        public global::System.Uri Proxy { get; set; }

        /// <summary>Credentials for a proxy server to use for the remote call</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Credentials for a proxy server to use for the remote call")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Category(global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.ParameterCategory.Runtime)]
        public global::System.Management.Automation.PSCredential ProxyCredential { get; set; }

        /// <summary>Use the default credentials for the proxy</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Use the default credentials for the proxy")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Category(global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter ProxyUseDefaultCredentials { get; set; }

        /// <summary>Reason for the revocation.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "Reason for the revocation.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Category(global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Reason for the revocation.",
        SerializedName = @"reason",
        PossibleTypes = new [] { typeof(string) })]
        public string Reason { get => _body.Reason ?? null; set => _body.Reason = value; }

        /// <summary>Remarks for the revocation.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Remarks for the revocation.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Category(global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Remarks for the revocation.",
        SerializedName = @"remarks",
        PossibleTypes = new [] { typeof(string) })]
        public string Remark { get => _body.Remark ?? null; set => _body.Remark = value; }

        /// <summary>Serial number of the certificate.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "Serial number of the certificate.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Category(global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Serial number of the certificate.",
        SerializedName = @"serialNumber",
        PossibleTypes = new [] { typeof(string) })]
        public string SerialNumber { get => _body.SerialNumber ?? null; set => _body.SerialNumber = value; }

        /// <summary>Thumbprint of the certificate.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "Thumbprint of the certificate.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Category(global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Thumbprint of the certificate.",
        SerializedName = @"thumbprint",
        PossibleTypes = new [] { typeof(string) })]
        public string Thumbprint { get => _body.Thumbprint ?? null; set => _body.Thumbprint = value; }

        /// <summary>
        /// <c>overrideOnDefault</c> will be called before the regular onDefault has been processed, allowing customization of what
        /// happens on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IErrorResponse">Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IErrorResponse</see>
        /// from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onDefault method should be processed, or if the method should
        /// return immediately (set to true to skip further processing )</param>

        partial void overrideOnDefault(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IErrorResponse> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// <c>overrideOnNoContent</c> will be called before the regular onNoContent has been processed, allowing customization of
        /// what happens on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="returnNow">/// Determines if the rest of the onNoContent method should be processed, or if the method should
        /// return immediately (set to true to skip further processing )</param>

        partial void overrideOnNoContent(global::System.Net.Http.HttpResponseMessage responseMessage, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// (overrides the default BeginProcessing method in global::System.Management.Automation.PSCmdlet)
        /// </summary>
        protected override void BeginProcessing()
        {
            var telemetryId = Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Module.Instance.GetTelemetryId.Invoke();
            if (telemetryId != "" && telemetryId != "internal")
            {
                __correlationId = telemetryId;
            }
            Module.Instance.SetProxyConfiguration(Proxy, ProxyCredential, ProxyUseDefaultCredentials);
            if (Break)
            {
                Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.AttachDebugger.Break();
            }
            ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Events.CmdletBeginProcessing).Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
        }

        /// <summary>Performs clean-up after the command execution</summary>
        protected override void EndProcessing()
        {
            if (1 ==_responseSize)
            {
                // Flush buffer
                WriteObject(_firstResponse);
            }
            var telemetryInfo = Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Module.Instance.GetTelemetryInfo?.Invoke(__correlationId);
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
         async global::System.Threading.Tasks.Task Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.IEventListener.Signal(string id, global::System.Threading.CancellationToken token, global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.EventData> messageData)
        {
            using( NoSynchronizationContext )
            {
                if (token.IsCancellationRequested)
                {
                    return ;
                }

                switch ( id )
                {
                    case Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Events.Verbose:
                    {
                        WriteVerbose($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Events.Warning:
                    {
                        WriteWarning($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Events.Information:
                    {
                        var data = messageData();
                        WriteInformation(data.Message, new string[]{});
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Events.Debug:
                    {
                        WriteDebug($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Events.Error:
                    {
                        WriteError(new global::System.Management.Automation.ErrorRecord( new global::System.Exception(messageData().Message), string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null ) );
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Events.Progress:
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
                await Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Module.Instance.Signal(id, token, messageData, (i, t, m) => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.IEventListener)this).Signal(i, t, () => Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.EventDataConverter.ConvertFrom(m()) as Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.EventData), InvocationInformation, this.ParameterSetName, __correlationId, __processRecordId, null );
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
            ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Events.CmdletProcessRecordStart).Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
            __processRecordId = System.Guid.NewGuid().ToString();
            try
            {
                // work
                if (ShouldProcess($"Call remote 'CertificateProfilesRevokeCertificate' operation"))
                {
                    using( var asyncCommandRuntime = new Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.PowerShell.AsyncCommandRuntime(this, ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.IEventListener)this).Token) )
                    {
                        asyncCommandRuntime.Wait( ProcessRecordAsync(),((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.IEventListener)this).Token);
                    }
                }
            }
            catch (global::System.AggregateException aggregateException)
            {
                // unroll the inner exceptions to get the root cause
                foreach( var innerException in aggregateException.Flatten().InnerExceptions )
                {
                    ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Events.CmdletException, $"{innerException.GetType().Name} - {innerException.Message} : {innerException.StackTrace}").Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    // Write exception out to error channel.
                    WriteError( new global::System.Management.Automation.ErrorRecord(innerException,string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null) );
                }
            }
            catch (global::System.Exception exception) when ((exception as System.Management.Automation.PipelineStoppedException)== null || (exception as System.Management.Automation.PipelineStoppedException).InnerException != null)
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Events.CmdletException, $"{exception.GetType().Name} - {exception.Message} : {exception.StackTrace}").Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                // Write exception out to error channel.
                WriteError( new global::System.Management.Automation.ErrorRecord(exception,string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null) );
            }
            finally
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Events.CmdletProcessRecordEnd).Wait();
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
                await ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Events.CmdletGetPipeline); if( ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                Pipeline = Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Module.Instance.CreatePipeline(InvocationInformation, __correlationId, __processRecordId, this.ParameterSetName, this.ExtensibleParameters);
                if (null != HttpPipelinePrepend)
                {
                    Pipeline.Prepend((this.CommandRuntime as Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelinePrepend) ?? HttpPipelinePrepend);
                }
                if (null != HttpPipelineAppend)
                {
                    Pipeline.Append((this.CommandRuntime as Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelineAppend) ?? HttpPipelineAppend);
                }
                // get the client instance
                try
                {
                    await ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Events.CmdletBeforeAPICall); if( ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    if (CodeSigningAccountInputObject?.Id != null)
                    {
                        this.CodeSigningAccountInputObject.Id += $"/certificateProfiles/{(global::System.Uri.EscapeDataString(this.ProfileName.ToString()))}";
                        await this.Client.CertificateProfilesRevokeCertificateViaIdentity(CodeSigningAccountInputObject.Id, _body, onNoContent, onDefault, this, Pipeline);
                    }
                    else
                    {
                        // try to call with PATH parameters from Input Object
                        if (null == CodeSigningAccountInputObject.SubscriptionId)
                        {
                            ThrowTerminatingError( new global::System.Management.Automation.ErrorRecord(new global::System.Exception("CodeSigningAccountInputObject has null value for CodeSigningAccountInputObject.SubscriptionId"),string.Empty, global::System.Management.Automation.ErrorCategory.InvalidArgument, CodeSigningAccountInputObject) );
                        }
                        if (null == CodeSigningAccountInputObject.ResourceGroupName)
                        {
                            ThrowTerminatingError( new global::System.Management.Automation.ErrorRecord(new global::System.Exception("CodeSigningAccountInputObject has null value for CodeSigningAccountInputObject.ResourceGroupName"),string.Empty, global::System.Management.Automation.ErrorCategory.InvalidArgument, CodeSigningAccountInputObject) );
                        }
                        if (null == CodeSigningAccountInputObject.AccountName)
                        {
                            ThrowTerminatingError( new global::System.Management.Automation.ErrorRecord(new global::System.Exception("CodeSigningAccountInputObject has null value for CodeSigningAccountInputObject.AccountName"),string.Empty, global::System.Management.Automation.ErrorCategory.InvalidArgument, CodeSigningAccountInputObject) );
                        }
                        await this.Client.CertificateProfilesRevokeCertificate(CodeSigningAccountInputObject.SubscriptionId ?? null, CodeSigningAccountInputObject.ResourceGroupName ?? null, CodeSigningAccountInputObject.AccountName ?? null, ProfileName, _body, onNoContent, onDefault, this, Pipeline);
                    }
                    await ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Events.CmdletAfterAPICall); if( ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                }
                catch (Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.UndeclaredResponseException urexception)
                {
                    WriteError(new global::System.Management.Automation.ErrorRecord(urexception, urexception.StatusCode.ToString(), global::System.Management.Automation.ErrorCategory.InvalidOperation, new { ProfileName=ProfileName})
                    {
                      ErrorDetails = new global::System.Management.Automation.ErrorDetails(urexception.Message) { RecommendedAction = urexception.Action }
                    });
                }
                finally
                {
                    await ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Events.CmdletProcessRecordAsyncEnd);
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RevokeAzCodeSigningCertificateProfileCertificate_RevokeViaIdentityCodeSigningAccountExpanded"
        /// /> cmdlet class.
        /// </summary>
        public RevokeAzCodeSigningCertificateProfileCertificate_RevokeViaIdentityCodeSigningAccountExpanded()
        {

        }

        /// <summary>Interrupts currently running code within the command.</summary>
        protected override void StopProcessing()
        {
            ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.IEventListener)this).Cancel();
            base.StopProcessing();
        }

        /// <param name="sendToPipeline"></param>
        new protected void WriteObject(object sendToPipeline)
        {
            Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Module.Instance.SanitizeOutput?.Invoke(sendToPipeline, __correlationId);
            base.WriteObject(sendToPipeline);
        }

        /// <param name="sendToPipeline"></param>
        /// <param name="enumerateCollection"></param>
        new protected void WriteObject(object sendToPipeline, bool enumerateCollection)
        {
            Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Module.Instance.SanitizeOutput?.Invoke(sendToPipeline, __correlationId);
            base.WriteObject(sendToPipeline, enumerateCollection);
        }

        /// <summary>
        /// a delegate that is called when the remote service returns default (any response code not handled elsewhere).
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IErrorResponse">Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IErrorResponse</see>
        /// from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onDefault(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IErrorResponse> response)
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
                    var ex = new Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IErrorResponse>(responseMessage, await response);
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

        /// <summary>a delegate that is called when the remote service returns 204 (NoContent).</summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onNoContent(global::System.Net.Http.HttpResponseMessage responseMessage)
        {
            using( NoSynchronizationContext )
            {
                var _returnNow = global::System.Threading.Tasks.Task<bool>.FromResult(false);
                overrideOnNoContent(responseMessage, ref _returnNow);
                // if overrideOnNoContent has returned true, then return right away.
                if ((null != _returnNow && await _returnNow))
                {
                    return ;
                }
                // onNoContent - response for 204 / application/json
                if (true == MyInvocation?.BoundParameters?.ContainsKey("PassThru"))
                {
                    WriteObject(true);
                }
            }
        }
    }
}