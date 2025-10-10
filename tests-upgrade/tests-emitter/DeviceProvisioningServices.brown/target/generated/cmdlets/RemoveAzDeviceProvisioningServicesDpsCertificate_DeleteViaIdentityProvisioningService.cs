// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Cmdlets
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Extensions;
    using Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.PowerShell;
    using Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Cmdlets;
    using System;

    /// <summary>Deletes the specified certificate associated with the Provisioning Service</summary>
    /// <remarks>
    /// [OpenAPI] Delete=>DELETE:"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/provisioningServices/{provisioningServiceName}/certificates/{certificateName}"
    /// </remarks>
    [global::System.Management.Automation.Cmdlet(global::System.Management.Automation.VerbsCommon.Remove, @"AzDeviceProvisioningServicesDpsCertificate_DeleteViaIdentityProvisioningService", SupportsShouldProcess = true)]
    [global::System.Management.Automation.OutputType(typeof(bool))]
    [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Description(@"Deletes the specified certificate associated with the Provisioning Service")]
    [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Generated]
    [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.HttpPath(Path = "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/provisioningServices/{provisioningServiceName}/certificates/{certificateName}", ApiVersion = "2025-02-01-preview")]
    public partial class RemoveAzDeviceProvisioningServicesDpsCertificate_DeleteViaIdentityProvisioningService : global::System.Management.Automation.PSCmdlet,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.IEventListener,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.IContext
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

        /// <summary>
        /// A flag to tell whether it is the first returned object in a call. Zero means no response yet. One means 1 returned object.
        /// Two means multiple returned objects in response.
        /// </summary>
        private int _responseSize = 0;

        /// <summary>Wait for .NET debugger to attach</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Wait for .NET debugger to attach")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter Break { get; set; }

        /// <summary>Accessor for cancellationTokenSource.</summary>
        public global::System.Threading.CancellationTokenSource CancellationTokenSource { get => _cancellationTokenSource ; set { _cancellationTokenSource = value; } }

        /// <summary>Backing field for <see cref="CertificateCreated" /> property.</summary>
        private global::System.DateTime _certificateCreated;

        /// <summary>Time the certificate is created.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Time the certificate is created.")]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Time the certificate is created.",
        SerializedName = @"certificate.created",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.ParameterCategory.Query)]
        public global::System.DateTime CertificateCreated { get => this._certificateCreated; set => this._certificateCreated = value; }

        /// <summary>Backing field for <see cref="CertificateHasPrivateKey" /> property.</summary>
        private global::System.Management.Automation.SwitchParameter _certificateHasPrivateKey;

        /// <summary>Indicates if the certificate contains a private key.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Indicates if the certificate contains a private key.")]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicates if the certificate contains a private key.",
        SerializedName = @"certificate.hasPrivateKey",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.ParameterCategory.Query)]
        public global::System.Management.Automation.SwitchParameter CertificateHasPrivateKey { get => this._certificateHasPrivateKey; set => this._certificateHasPrivateKey = value; }

        /// <summary>Backing field for <see cref="CertificateIsVerified" /> property.</summary>
        private global::System.Management.Automation.SwitchParameter _certificateIsVerified;

        /// <summary>Indicates if certificate has been verified by owner of the private key.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Indicates if certificate has been verified by owner of the private key.")]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicates if certificate has been verified by owner of the private key.",
        SerializedName = @"certificate.isVerified",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.ParameterCategory.Query)]
        public global::System.Management.Automation.SwitchParameter CertificateIsVerified { get => this._certificateIsVerified; set => this._certificateIsVerified = value; }

        /// <summary>Backing field for <see cref="CertificateLastUpdated" /> property.</summary>
        private global::System.DateTime _certificateLastUpdated;

        /// <summary>Certificate last updated time.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Certificate last updated time.")]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Certificate last updated time.",
        SerializedName = @"certificate.lastUpdated",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.ParameterCategory.Query)]
        public global::System.DateTime CertificateLastUpdated { get => this._certificateLastUpdated; set => this._certificateLastUpdated = value; }

        /// <summary>Backing field for <see cref="CertificateName" /> property.</summary>
        private string _certificateName;

        /// <summary>This is optional, and it is the Common Name of the certificate.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "This is optional, and it is the Common Name of the certificate.")]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"This is optional, and it is the Common Name of the certificate.",
        SerializedName = @"certificate.name",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.ParameterCategory.Query)]
        public string CertificateName { get => this._certificateName; set => this._certificateName = value; }

        /// <summary>Backing field for <see cref="CertificateName1" /> property.</summary>
        private string _certificateName1;

        /// <summary>Name of the certificate to retrieve.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "Name of the certificate to retrieve.")]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Name of the certificate to retrieve.",
        SerializedName = @"certificateName",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.ParameterCategory.Path)]
        public string CertificateName1 { get => this._certificateName1; set => this._certificateName1 = value; }

        /// <summary>Backing field for <see cref="CertificateNonce" /> property.</summary>
        private string _certificateNonce;

        /// <summary>Random number generated to indicate Proof of Possession.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Random number generated to indicate Proof of Possession.")]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Random number generated to indicate Proof of Possession.",
        SerializedName = @"certificate.nonce",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.ParameterCategory.Query)]
        public string CertificateNonce { get => this._certificateNonce; set => this._certificateNonce = value; }

        /// <summary>Backing field for <see cref="CertificatePurpose" /> property.</summary>
        private string _certificatePurpose;

        /// <summary>A description that mentions the purpose of the certificate.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "A description that mentions the purpose of the certificate.")]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A description that mentions the purpose of the certificate.",
        SerializedName = @"certificate.purpose",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.ParameterCategory.Query)]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PSArgumentCompleterAttribute("clientAuthentication", "serverAuthentication")]
        public string CertificatePurpose { get => this._certificatePurpose; set => this._certificatePurpose = value; }

        /// <summary>Backing field for <see cref="CertificateRawByte" /> property.</summary>
        private byte[] _certificateRawByte;

        /// <summary>Raw data within the certificate.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Raw data within the certificate.")]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Raw data within the certificate.",
        SerializedName = @"certificate.rawBytes",
        PossibleTypes = new [] { typeof(byte[]) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.ParameterCategory.Query)]
        public byte[] CertificateRawByte { get => this._certificateRawByte; set => this._certificateRawByte = value; }

        /// <summary>The reference to the client API class.</summary>
        public Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.IotDpsClient Client => Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Module.Instance.ClientAPI;

        /// <summary>
        /// The DefaultProfile parameter is not functional. Use the SubscriptionId parameter when available if executing the cmdlet
        /// against a different subscription
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The DefaultProfile parameter is not functional. Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::System.Management.Automation.Alias("AzureRMContext", "AzureCredential")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.ParameterCategory.Azure)]
        public global::System.Management.Automation.PSObject DefaultProfile { get; set; }

        /// <summary>Accessor for extensibleParameters.</summary>
        public global::System.Collections.Generic.IDictionary<global::System.String,global::System.Object> ExtensibleParameters { get => _extensibleParameters ; }

        /// <summary>SendAsync Pipeline Steps to be appended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be appended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.ParameterCategory.Runtime)]
        public Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.SendAsyncStep[] HttpPipelineAppend { get; set; }

        /// <summary>SendAsync Pipeline Steps to be prepended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be prepended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.ParameterCategory.Runtime)]
        public Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.SendAsyncStep[] HttpPipelinePrepend { get; set; }

        /// <summary>Backing field for <see cref="IfMatch" /> property.</summary>
        private string _ifMatch;

        /// <summary>ETag of the certificate</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "ETag of the certificate")]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"ETag of the certificate",
        SerializedName = @"If-Match",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.ParameterCategory.Header)]
        public string IfMatch { get => this._ifMatch; set => this._ifMatch = value; }

        /// <summary>Accessor for our copy of the InvocationInfo.</summary>
        public global::System.Management.Automation.InvocationInfo InvocationInformation { get => __invocationInfo = __invocationInfo ?? this.MyInvocation ; set { __invocationInfo = value; } }

        /// <summary>
        /// <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.IEventListener" /> cancellation delegate. Stops the cmdlet when called.
        /// </summary>
        global::System.Action Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.IEventListener.Cancel => _cancellationTokenSource.Cancel;

        /// <summary><see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.IEventListener" /> cancellation token.</summary>
        global::System.Threading.CancellationToken Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.IEventListener.Token => _cancellationTokenSource.Token;

        /// <summary>
        /// When specified, forces the cmdlet return a 'bool' given that there isn't a return type by default.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Returns true when the command succeeds")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter PassThru { get; set; }

        /// <summary>
        /// The instance of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.HttpPipeline" /> that the remote call will use.
        /// </summary>
        public Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.HttpPipeline Pipeline { get; set; }

        /// <summary>Backing field for <see cref="ProvisioningServiceInputObject" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IDeviceProvisioningServicesIdentity _provisioningServiceInputObject;

        /// <summary>Identity Parameter</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "Identity Parameter", ValueFromPipeline = true)]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.ParameterCategory.Path)]
        public Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IDeviceProvisioningServicesIdentity ProvisioningServiceInputObject { get => this._provisioningServiceInputObject; set => this._provisioningServiceInputObject = value; }

        /// <summary>The URI for the proxy server to use</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "The URI for the proxy server to use")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.ParameterCategory.Runtime)]
        public global::System.Uri Proxy { get; set; }

        /// <summary>Credentials for a proxy server to use for the remote call</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Credentials for a proxy server to use for the remote call")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.ParameterCategory.Runtime)]
        public global::System.Management.Automation.PSCredential ProxyCredential { get; set; }

        /// <summary>Use the default credentials for the proxy</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Use the default credentials for the proxy")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter ProxyUseDefaultCredentials { get; set; }

        /// <summary>
        /// <c>overrideOnDefault</c> will be called before the regular onDefault has been processed, allowing customization of what
        /// happens on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IErrorDetails">Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IErrorDetails</see>
        /// from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onDefault method should be processed, or if the method should
        /// return immediately (set to true to skip further processing )</param>

        partial void overrideOnDefault(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IErrorDetails> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// <c>overrideOnNoContent</c> will be called before the regular onNoContent has been processed, allowing customization of
        /// what happens on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="returnNow">/// Determines if the rest of the onNoContent method should be processed, or if the method should
        /// return immediately (set to true to skip further processing )</param>

        partial void overrideOnNoContent(global::System.Net.Http.HttpResponseMessage responseMessage, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// <c>overrideOnOk</c> will be called before the regular onOk has been processed, allowing customization of what happens
        /// on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="returnNow">/// Determines if the rest of the onOk method should be processed, or if the method should return
        /// immediately (set to true to skip further processing )</param>

        partial void overrideOnOk(global::System.Net.Http.HttpResponseMessage responseMessage, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// (overrides the default BeginProcessing method in global::System.Management.Automation.PSCmdlet)
        /// </summary>
        protected override void BeginProcessing()
        {
            var telemetryId = Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Module.Instance.GetTelemetryId.Invoke();
            if (telemetryId != "" && telemetryId != "internal")
            {
                __correlationId = telemetryId;
            }
            Module.Instance.SetProxyConfiguration(Proxy, ProxyCredential, ProxyUseDefaultCredentials);
            if (Break)
            {
                Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.AttachDebugger.Break();
            }
            ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Events.CmdletBeginProcessing).Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
        }

        /// <summary>Performs clean-up after the command execution</summary>
        protected override void EndProcessing()
        {
            if (1 ==_responseSize)
            {
                // Flush buffer
                WriteObject(_firstResponse);
            }
            var telemetryInfo = Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Module.Instance.GetTelemetryInfo?.Invoke(__correlationId);
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
         async global::System.Threading.Tasks.Task Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.IEventListener.Signal(string id, global::System.Threading.CancellationToken token, global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.EventData> messageData)
        {
            using( NoSynchronizationContext )
            {
                if (token.IsCancellationRequested)
                {
                    return ;
                }

                switch ( id )
                {
                    case Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Events.Verbose:
                    {
                        WriteVerbose($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Events.Warning:
                    {
                        WriteWarning($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Events.Information:
                    {
                        var data = messageData();
                        WriteInformation(data.Message, new string[]{});
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Events.Debug:
                    {
                        WriteDebug($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Events.Error:
                    {
                        WriteError(new global::System.Management.Automation.ErrorRecord( new global::System.Exception(messageData().Message), string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null ) );
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Events.Progress:
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
                await Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Module.Instance.Signal(id, token, messageData, (i, t, m) => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.IEventListener)this).Signal(i, t, () => Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.EventDataConverter.ConvertFrom(m()) as Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.EventData), InvocationInformation, this.ParameterSetName, __correlationId, __processRecordId, null );
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
            ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Events.CmdletProcessRecordStart).Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
            __processRecordId = System.Guid.NewGuid().ToString();
            try
            {
                // work
                if (ShouldProcess($"Call remote 'DpsCertificateDelete' operation"))
                {
                    using( var asyncCommandRuntime = new Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.PowerShell.AsyncCommandRuntime(this, ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.IEventListener)this).Token) )
                    {
                        asyncCommandRuntime.Wait( ProcessRecordAsync(),((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.IEventListener)this).Token);
                    }
                }
            }
            catch (global::System.AggregateException aggregateException)
            {
                // unroll the inner exceptions to get the root cause
                foreach( var innerException in aggregateException.Flatten().InnerExceptions )
                {
                    ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Events.CmdletException, $"{innerException.GetType().Name} - {innerException.Message} : {innerException.StackTrace}").Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    // Write exception out to error channel.
                    WriteError( new global::System.Management.Automation.ErrorRecord(innerException,string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null) );
                }
            }
            catch (global::System.Exception exception) when ((exception as System.Management.Automation.PipelineStoppedException)== null || (exception as System.Management.Automation.PipelineStoppedException).InnerException != null)
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Events.CmdletException, $"{exception.GetType().Name} - {exception.Message} : {exception.StackTrace}").Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                // Write exception out to error channel.
                WriteError( new global::System.Management.Automation.ErrorRecord(exception,string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null) );
            }
            finally
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Events.CmdletProcessRecordEnd).Wait();
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
                await ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Events.CmdletGetPipeline); if( ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                Pipeline = Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Module.Instance.CreatePipeline(InvocationInformation, __correlationId, __processRecordId, this.ParameterSetName, this.ExtensibleParameters);
                if (null != HttpPipelinePrepend)
                {
                    Pipeline.Prepend((this.CommandRuntime as Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelinePrepend) ?? HttpPipelinePrepend);
                }
                if (null != HttpPipelineAppend)
                {
                    Pipeline.Append((this.CommandRuntime as Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelineAppend) ?? HttpPipelineAppend);
                }
                // get the client instance
                try
                {
                    await ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Events.CmdletBeforeAPICall); if( ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    if (ProvisioningServiceInputObject?.Id != null)
                    {
                        this.ProvisioningServiceInputObject.Id += $"/certificates/{(global::System.Uri.EscapeDataString(this.CertificateName1.ToString()))}";
                        await this.Client.DpsCertificateDeleteViaIdentity(ProvisioningServiceInputObject.Id, IfMatch, this.InvocationInformation.BoundParameters.ContainsKey("CertificateName") ? CertificateName : null, this.InvocationInformation.BoundParameters.ContainsKey("CertificateRawByte") ? CertificateRawByte : null /* byte array */, this.InvocationInformation.BoundParameters.ContainsKey("CertificateIsVerified") ? CertificateIsVerified : default(global::System.Management.Automation.SwitchParameter?), this.InvocationInformation.BoundParameters.ContainsKey("CertificatePurpose") ? CertificatePurpose : null, this.InvocationInformation.BoundParameters.ContainsKey("CertificateCreated") ? CertificateCreated : default(global::System.DateTime?), this.InvocationInformation.BoundParameters.ContainsKey("CertificateLastUpdated") ? CertificateLastUpdated : default(global::System.DateTime?), this.InvocationInformation.BoundParameters.ContainsKey("CertificateHasPrivateKey") ? CertificateHasPrivateKey : default(global::System.Management.Automation.SwitchParameter?), this.InvocationInformation.BoundParameters.ContainsKey("CertificateNonce") ? CertificateNonce : null, onOk, onNoContent, onDefault, this, Pipeline);
                    }
                    else
                    {
                        // try to call with PATH parameters from Input Object
                        if (null == ProvisioningServiceInputObject.SubscriptionId)
                        {
                            ThrowTerminatingError( new global::System.Management.Automation.ErrorRecord(new global::System.Exception("ProvisioningServiceInputObject has null value for ProvisioningServiceInputObject.SubscriptionId"),string.Empty, global::System.Management.Automation.ErrorCategory.InvalidArgument, ProvisioningServiceInputObject) );
                        }
                        if (null == ProvisioningServiceInputObject.ResourceGroupName)
                        {
                            ThrowTerminatingError( new global::System.Management.Automation.ErrorRecord(new global::System.Exception("ProvisioningServiceInputObject has null value for ProvisioningServiceInputObject.ResourceGroupName"),string.Empty, global::System.Management.Automation.ErrorCategory.InvalidArgument, ProvisioningServiceInputObject) );
                        }
                        if (null == ProvisioningServiceInputObject.ProvisioningServiceName)
                        {
                            ThrowTerminatingError( new global::System.Management.Automation.ErrorRecord(new global::System.Exception("ProvisioningServiceInputObject has null value for ProvisioningServiceInputObject.ProvisioningServiceName"),string.Empty, global::System.Management.Automation.ErrorCategory.InvalidArgument, ProvisioningServiceInputObject) );
                        }
                        await this.Client.DpsCertificateDelete(ProvisioningServiceInputObject.SubscriptionId ?? null, ProvisioningServiceInputObject.ResourceGroupName ?? null, ProvisioningServiceInputObject.ProvisioningServiceName ?? null, CertificateName1, IfMatch, this.InvocationInformation.BoundParameters.ContainsKey("CertificateName") ? CertificateName : null, this.InvocationInformation.BoundParameters.ContainsKey("CertificateRawByte") ? CertificateRawByte : null /* byte array */, this.InvocationInformation.BoundParameters.ContainsKey("CertificateIsVerified") ? CertificateIsVerified : default(global::System.Management.Automation.SwitchParameter?), this.InvocationInformation.BoundParameters.ContainsKey("CertificatePurpose") ? CertificatePurpose : null, this.InvocationInformation.BoundParameters.ContainsKey("CertificateCreated") ? CertificateCreated : default(global::System.DateTime?), this.InvocationInformation.BoundParameters.ContainsKey("CertificateLastUpdated") ? CertificateLastUpdated : default(global::System.DateTime?), this.InvocationInformation.BoundParameters.ContainsKey("CertificateHasPrivateKey") ? CertificateHasPrivateKey : default(global::System.Management.Automation.SwitchParameter?), this.InvocationInformation.BoundParameters.ContainsKey("CertificateNonce") ? CertificateNonce : null, onOk, onNoContent, onDefault, this, Pipeline);
                    }
                    await ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Events.CmdletAfterAPICall); if( ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                }
                catch (Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.UndeclaredResponseException urexception)
                {
                    WriteError(new global::System.Management.Automation.ErrorRecord(urexception, urexception.StatusCode.ToString(), global::System.Management.Automation.ErrorCategory.InvalidOperation, new { CertificateName1=CertificateName1,IfMatch=IfMatch,CertificateName=this.InvocationInformation.BoundParameters.ContainsKey("CertificateName") ? CertificateName : null,CertificateRawByte=this.InvocationInformation.BoundParameters.ContainsKey("CertificateRawByte") ? CertificateRawByte : null /* byte array */,CertificateIsVerified=this.InvocationInformation.BoundParameters.ContainsKey("CertificateIsVerified") ? CertificateIsVerified : default(global::System.Management.Automation.SwitchParameter?),CertificatePurpose=this.InvocationInformation.BoundParameters.ContainsKey("CertificatePurpose") ? CertificatePurpose : null,CertificateCreated=this.InvocationInformation.BoundParameters.ContainsKey("CertificateCreated") ? CertificateCreated : default(global::System.DateTime?),CertificateLastUpdated=this.InvocationInformation.BoundParameters.ContainsKey("CertificateLastUpdated") ? CertificateLastUpdated : default(global::System.DateTime?),CertificateHasPrivateKey=this.InvocationInformation.BoundParameters.ContainsKey("CertificateHasPrivateKey") ? CertificateHasPrivateKey : default(global::System.Management.Automation.SwitchParameter?),CertificateNonce=this.InvocationInformation.BoundParameters.ContainsKey("CertificateNonce") ? CertificateNonce : null})
                    {
                      ErrorDetails = new global::System.Management.Automation.ErrorDetails(urexception.Message) { RecommendedAction = urexception.Action }
                    });
                }
                finally
                {
                    await ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Events.CmdletProcessRecordAsyncEnd);
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveAzDeviceProvisioningServicesDpsCertificate_DeleteViaIdentityProvisioningService"
        /// /> cmdlet class.
        /// </summary>
        public RemoveAzDeviceProvisioningServicesDpsCertificate_DeleteViaIdentityProvisioningService()
        {

        }

        /// <summary>Interrupts currently running code within the command.</summary>
        protected override void StopProcessing()
        {
            ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.IEventListener)this).Cancel();
            base.StopProcessing();
        }

        /// <param name="sendToPipeline"></param>
        new protected void WriteObject(object sendToPipeline)
        {
            Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Module.Instance.SanitizeOutput?.Invoke(sendToPipeline, __correlationId);
            base.WriteObject(sendToPipeline);
        }

        /// <param name="sendToPipeline"></param>
        /// <param name="enumerateCollection"></param>
        new protected void WriteObject(object sendToPipeline, bool enumerateCollection)
        {
            Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Module.Instance.SanitizeOutput?.Invoke(sendToPipeline, __correlationId);
            base.WriteObject(sendToPipeline, enumerateCollection);
        }

        /// <summary>
        /// a delegate that is called when the remote service returns default (any response code not handled elsewhere).
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IErrorDetails">Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IErrorDetails</see>
        /// from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onDefault(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IErrorDetails> response)
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
                    var ex = new Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IErrorDetails>(responseMessage, await response);
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
                if (true == InvocationInformation?.BoundParameters?.ContainsKey("PassThru"))
                {
                    WriteObject(true);
                }
            }
        }

        /// <summary>a delegate that is called when the remote service returns 200 (OK).</summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onOk(global::System.Net.Http.HttpResponseMessage responseMessage)
        {
            using( NoSynchronizationContext )
            {
                var _returnNow = global::System.Threading.Tasks.Task<bool>.FromResult(false);
                overrideOnOk(responseMessage, ref _returnNow);
                // if overrideOnOk has returned true, then return right away.
                if ((null != _returnNow && await _returnNow))
                {
                    return ;
                }
                // onOk - response for 200 / application/json
                if (true == InvocationInformation?.BoundParameters?.ContainsKey("PassThru"))
                {
                    WriteObject(true);
                }
            }
        }
    }
}