// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Cmdlets
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;
    using Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.PowerShell;
    using Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Cmdlets;
    using System;

    /// <summary>
    /// [DEPRECATED NOTICE: This operation will soon be removed]. This method validates the customer shipping address and provide
    /// alternate addresses if any.
    /// </summary>
    /// <remarks>
    /// [OpenAPI] ValidateAddress=>POST:"/subscriptions/{subscriptionId}/providers/Microsoft.DataBox/locations/{location}/validateAddress"
    /// </remarks>
    [global::System.Management.Automation.Cmdlet(global::System.Management.Automation.VerbsDiagnostic.Test, @"AzDataBoxServiceAddress_ValidateExpanded", SupportsShouldProcess = true)]
    [global::System.Management.Automation.OutputType(typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAddressValidationOutput))]
    [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.Description(@"[DEPRECATED NOTICE: This operation will soon be removed]. This method validates the customer shipping address and provide alternate addresses if any.")]
    [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.Generated]
    [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.HttpPath(Path = "/subscriptions/{subscriptionId}/providers/Microsoft.DataBox/locations/{location}/validateAddress", ApiVersion = "2025-07-01")]
    public partial class TestAzDataBoxServiceAddress_ValidateExpanded : global::System.Management.Automation.PSCmdlet,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IEventListener,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IContext
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

        /// <summary>
        /// The requirements to validate customer address where the device needs to be shipped.
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddress _validateAddressBody = new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ValidateAddress();

        /// <summary>Wait for .NET debugger to attach</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Wait for .NET debugger to attach")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.Category(global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter Break { get; set; }

        /// <summary>Accessor for cancellationTokenSource.</summary>
        public global::System.Threading.CancellationTokenSource CancellationTokenSource { get => _cancellationTokenSource ; set { _cancellationTokenSource = value; } }

        /// <summary>The reference to the client API class.</summary>
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.DataBoxManagementClient Client => Microsoft.Azure.PowerShell.Cmdlets.DataBox.Module.Instance.ClientAPI;

        /// <summary>
        /// The DefaultProfile parameter is not functional. Use the SubscriptionId parameter when available if executing the cmdlet
        /// against a different subscription
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The DefaultProfile parameter is not functional. Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::System.Management.Automation.Alias("AzureRMContext", "AzureCredential")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.Category(global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.ParameterCategory.Azure)]
        public global::System.Management.Automation.PSObject DefaultProfile { get; set; }

        /// <summary>Device type to be used for the job.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "Device type to be used for the job.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.Category(global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Device type to be used for the job.",
        SerializedName = @"deviceType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("DataBox", "DataBoxDisk", "DataBoxHeavy", "DataBoxCustomerDisk")]
        public string DeviceType { get => _validateAddressBody.DeviceType ?? null; set => _validateAddressBody.DeviceType = value; }

        /// <summary>Accessor for extensibleParameters.</summary>
        public global::System.Collections.Generic.IDictionary<global::System.String,global::System.Object> ExtensibleParameters { get => _extensibleParameters ; }

        /// <summary>SendAsync Pipeline Steps to be appended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be appended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.Category(global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.ParameterCategory.Runtime)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.SendAsyncStep[] HttpPipelineAppend { get; set; }

        /// <summary>SendAsync Pipeline Steps to be prepended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be prepended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.Category(global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.ParameterCategory.Runtime)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.SendAsyncStep[] HttpPipelinePrepend { get; set; }

        /// <summary>Accessor for our copy of the InvocationInfo.</summary>
        public global::System.Management.Automation.InvocationInfo InvocationInformation { get => __invocationInfo = __invocationInfo ?? this.MyInvocation ; set { __invocationInfo = value; } }

        /// <summary>Backing field for <see cref="Location" /> property.</summary>
        private string _location;

        /// <summary>The name of the Azure region.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The name of the Azure region.")]
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The name of the Azure region.",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.Category(global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.ParameterCategory.Path)]
        public string Location { get => this._location; set => this._location = value; }

        /// <summary>
        /// <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IEventListener" /> cancellation delegate. Stops the cmdlet when called.
        /// </summary>
        global::System.Action Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IEventListener.Cancel => _cancellationTokenSource.Cancel;

        /// <summary><see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IEventListener" /> cancellation token.</summary>
        global::System.Threading.CancellationToken Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IEventListener.Token => _cancellationTokenSource.Token;

        /// <summary>
        /// The customer friendly name of the combination of version and capacity of the device. This field is necessary only at the
        /// time of ordering the newer generation device i.e. AzureDataBox120 and AzureDataBox525 as of Feb/2025
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The customer friendly name of the combination of version and capacity of the device. This field is necessary only at the time of ordering the newer generation device i.e. AzureDataBox120 and AzureDataBox525 as of Feb/2025")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.Category(global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The customer friendly name of the combination of version and capacity of the device. This field is necessary only at the time of ordering the newer generation device i.e. AzureDataBox120 and AzureDataBox525 as of Feb/2025",
        SerializedName = @"model",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("DataBox", "DataBoxDisk", "DataBoxHeavy", "DataBoxCustomerDisk", "AzureDataBox120", "AzureDataBox525")]
        public string Model { get => _validateAddressBody.Model ?? null; set => _validateAddressBody.Model = value; }

        /// <summary>
        /// The instance of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.HttpPipeline" /> that the remote call will use.
        /// </summary>
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.HttpPipeline Pipeline { get; set; }

        /// <summary>The URI for the proxy server to use</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "The URI for the proxy server to use")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.Category(global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.ParameterCategory.Runtime)]
        public global::System.Uri Proxy { get; set; }

        /// <summary>Credentials for a proxy server to use for the remote call</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Credentials for a proxy server to use for the remote call")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.Category(global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.ParameterCategory.Runtime)]
        public global::System.Management.Automation.PSCredential ProxyCredential { get; set; }

        /// <summary>Use the default credentials for the proxy</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Use the default credentials for the proxy")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.Category(global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter ProxyUseDefaultCredentials { get; set; }

        /// <summary>Name of the City.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Name of the City.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.Category(global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the City.",
        SerializedName = @"city",
        PossibleTypes = new [] { typeof(string) })]
        public string ShippingAddressCity { get => _validateAddressBody.ShippingAddressCity ?? null; set => _validateAddressBody.ShippingAddressCity = value; }

        /// <summary>Name of the company.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Name of the company.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.Category(global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the company.",
        SerializedName = @"companyName",
        PossibleTypes = new [] { typeof(string) })]
        public string ShippingAddressCompanyName { get => _validateAddressBody.ShippingAddressCompanyName ?? null; set => _validateAddressBody.ShippingAddressCompanyName = value; }

        /// <summary>Name of the Country.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "Name of the Country.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.Category(global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Name of the Country.",
        SerializedName = @"country",
        PossibleTypes = new [] { typeof(string) })]
        public string ShippingAddressCountry { get => _validateAddressBody.ShippingAddressCountry ?? null; set => _validateAddressBody.ShippingAddressCountry = value; }

        /// <summary>Postal code.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Postal code.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.Category(global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Postal code.",
        SerializedName = @"postalCode",
        PossibleTypes = new [] { typeof(string) })]
        public string ShippingAddressPostalCode { get => _validateAddressBody.ShippingAddressPostalCode ?? null; set => _validateAddressBody.ShippingAddressPostalCode = value; }

        /// <summary>Flag to indicate if customer has chosen to skip default address validation</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Flag to indicate if customer has chosen to skip default address validation")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.Category(global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Flag to indicate if customer has chosen to skip default address validation",
        SerializedName = @"skipAddressValidation",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter ShippingAddressSkipAddressValidation { get => _validateAddressBody.ShippingAddressSkipAddressValidation ?? default(global::System.Management.Automation.SwitchParameter); set => _validateAddressBody.ShippingAddressSkipAddressValidation = value; }

        /// <summary>Name of the State or Province.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Name of the State or Province.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.Category(global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the State or Province.",
        SerializedName = @"stateOrProvince",
        PossibleTypes = new [] { typeof(string) })]
        public string ShippingAddressStateOrProvince { get => _validateAddressBody.ShippingAddressStateOrProvince ?? null; set => _validateAddressBody.ShippingAddressStateOrProvince = value; }

        /// <summary>Street Address line 1.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "Street Address line 1.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.Category(global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Street Address line 1.",
        SerializedName = @"streetAddress1",
        PossibleTypes = new [] { typeof(string) })]
        public string ShippingAddressStreetAddress1 { get => _validateAddressBody.ShippingAddressStreetAddress1 ?? null; set => _validateAddressBody.ShippingAddressStreetAddress1 = value; }

        /// <summary>Street Address line 2.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Street Address line 2.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.Category(global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Street Address line 2.",
        SerializedName = @"streetAddress2",
        PossibleTypes = new [] { typeof(string) })]
        public string ShippingAddressStreetAddress2 { get => _validateAddressBody.ShippingAddressStreetAddress2 ?? null; set => _validateAddressBody.ShippingAddressStreetAddress2 = value; }

        /// <summary>Street Address line 3.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Street Address line 3.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.Category(global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Street Address line 3.",
        SerializedName = @"streetAddress3",
        PossibleTypes = new [] { typeof(string) })]
        public string ShippingAddressStreetAddress3 { get => _validateAddressBody.ShippingAddressStreetAddress3 ?? null; set => _validateAddressBody.ShippingAddressStreetAddress3 = value; }

        /// <summary>Tax Identification Number</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Tax Identification Number")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.Category(global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Tax Identification Number",
        SerializedName = @"taxIdentificationNumber",
        PossibleTypes = new [] { typeof(string) })]
        public string ShippingAddressTaxIdentificationNumber { get => _validateAddressBody.ShippingAddressTaxIdentificationNumber ?? null; set => _validateAddressBody.ShippingAddressTaxIdentificationNumber = value; }

        /// <summary>Type of address.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Type of address.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.Category(global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Type of address.",
        SerializedName = @"addressType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("None", "Residential", "Commercial")]
        public string ShippingAddressType { get => _validateAddressBody.ShippingAddressType ?? null; set => _validateAddressBody.ShippingAddressType = value; }

        /// <summary>Extended Zip Code.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Extended Zip Code.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.Category(global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Extended Zip Code.",
        SerializedName = @"zipExtendedCode",
        PossibleTypes = new [] { typeof(string) })]
        public string ShippingAddressZipExtendedCode { get => _validateAddressBody.ShippingAddressZipExtendedCode ?? null; set => _validateAddressBody.ShippingAddressZipExtendedCode = value; }

        /// <summary>Backing field for <see cref="SubscriptionId" /> property.</summary>
        private string _subscriptionId;

        /// <summary>The ID of the target subscription. The value must be an UUID.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The ID of the target subscription. The value must be an UUID.")]
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The ID of the target subscription. The value must be an UUID.",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.DefaultInfo(
        Name = @"",
        Description =@"",
        Script = @"(Get-AzContext).Subscription.Id",
        SetCondition = @"")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.Category(global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.ParameterCategory.Path)]
        public string SubscriptionId { get => this._subscriptionId; set => this._subscriptionId = value; }

        /// <summary>Indicates Shipment Logistics type that the customer preferred.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Indicates Shipment Logistics type that the customer preferred.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.Category(global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicates Shipment Logistics type that the customer preferred.",
        SerializedName = @"preferredShipmentType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("CustomerManaged", "MicrosoftManaged")]
        public string TransportPreferencePreferredShipmentType { get => _validateAddressBody.TransportPreferencePreferredShipmentType ?? null; set => _validateAddressBody.TransportPreferencePreferredShipmentType = value; }

        /// <summary>Identifies the type of validation request.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "Identifies the type of validation request.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.Category(global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Identifies the type of validation request.",
        SerializedName = @"validationType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("ValidateAddress", "ValidateSubscriptionIsAllowedToCreateJob", "ValidatePreferences", "ValidateCreateOrderLimit", "ValidateSkuAvailability", "ValidateDataTransferDetails")]
        public string ValidationType { get => _validateAddressBody.ValidationType ?? null; set => _validateAddressBody.ValidationType = value; }

        /// <summary>
        /// <c>overrideOnDefault</c> will be called before the regular onDefault has been processed, allowing customization of what
        /// happens on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IApiError">Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IApiError</see>
        /// from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onDefault method should be processed, or if the method should
        /// return immediately (set to true to skip further processing )</param>

        partial void overrideOnDefault(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IApiError> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// <c>overrideOnOk</c> will be called before the regular onOk has been processed, allowing customization of what happens
        /// on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAddressValidationOutput">Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAddressValidationOutput</see>
        /// from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onOk method should be processed, or if the method should return
        /// immediately (set to true to skip further processing )</param>

        partial void overrideOnOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAddressValidationOutput> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// (overrides the default BeginProcessing method in global::System.Management.Automation.PSCmdlet)
        /// </summary>
        protected override void BeginProcessing()
        {
            var telemetryId = Microsoft.Azure.PowerShell.Cmdlets.DataBox.Module.Instance.GetTelemetryId.Invoke();
            if (telemetryId != "" && telemetryId != "internal")
            {
                __correlationId = telemetryId;
            }
            Module.Instance.SetProxyConfiguration(Proxy, ProxyCredential, ProxyUseDefaultCredentials);
            if (Break)
            {
                Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.AttachDebugger.Break();
            }
            ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Events.CmdletBeginProcessing).Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
        }

        /// <summary>Performs clean-up after the command execution</summary>
        protected override void EndProcessing()
        {
            if (1 ==_responseSize)
            {
                // Flush buffer
                WriteObject(_firstResponse);
            }
            var telemetryInfo = Microsoft.Azure.PowerShell.Cmdlets.DataBox.Module.Instance.GetTelemetryInfo?.Invoke(__correlationId);
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
         async global::System.Threading.Tasks.Task Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IEventListener.Signal(string id, global::System.Threading.CancellationToken token, global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.EventData> messageData)
        {
            using( NoSynchronizationContext )
            {
                if (token.IsCancellationRequested)
                {
                    return ;
                }

                switch ( id )
                {
                    case Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Events.Verbose:
                    {
                        WriteVerbose($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Events.Warning:
                    {
                        WriteWarning($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Events.Information:
                    {
                        var data = messageData();
                        WriteInformation(data.Message, new string[]{});
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Events.Debug:
                    {
                        WriteDebug($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Events.Error:
                    {
                        WriteError(new global::System.Management.Automation.ErrorRecord( new global::System.Exception(messageData().Message), string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null ) );
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Events.Progress:
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
                await Microsoft.Azure.PowerShell.Cmdlets.DataBox.Module.Instance.Signal(id, token, messageData, (i, t, m) => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IEventListener)this).Signal(i, t, () => Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.EventDataConverter.ConvertFrom(m()) as Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.EventData), InvocationInformation, this.ParameterSetName, __correlationId, __processRecordId, null );
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
            ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Events.CmdletProcessRecordStart).Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
            __processRecordId = System.Guid.NewGuid().ToString();
            try
            {
                // work
                if (ShouldProcess($"Call remote 'ServiceValidateAddress' operation"))
                {
                    using( var asyncCommandRuntime = new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.PowerShell.AsyncCommandRuntime(this, ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IEventListener)this).Token) )
                    {
                        asyncCommandRuntime.Wait( ProcessRecordAsync(),((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IEventListener)this).Token);
                    }
                }
            }
            catch (global::System.AggregateException aggregateException)
            {
                // unroll the inner exceptions to get the root cause
                foreach( var innerException in aggregateException.Flatten().InnerExceptions )
                {
                    ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Events.CmdletException, $"{innerException.GetType().Name} - {innerException.Message} : {innerException.StackTrace}").Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    // Write exception out to error channel.
                    WriteError( new global::System.Management.Automation.ErrorRecord(innerException,string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null) );
                }
            }
            catch (global::System.Exception exception) when ((exception as System.Management.Automation.PipelineStoppedException)== null || (exception as System.Management.Automation.PipelineStoppedException).InnerException != null)
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Events.CmdletException, $"{exception.GetType().Name} - {exception.Message} : {exception.StackTrace}").Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                // Write exception out to error channel.
                WriteError( new global::System.Management.Automation.ErrorRecord(exception,string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null) );
            }
            finally
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Events.CmdletProcessRecordEnd).Wait();
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
                await ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Events.CmdletGetPipeline); if( ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                Pipeline = Microsoft.Azure.PowerShell.Cmdlets.DataBox.Module.Instance.CreatePipeline(InvocationInformation, __correlationId, __processRecordId, this.ParameterSetName, this.ExtensibleParameters);
                if (null != HttpPipelinePrepend)
                {
                    Pipeline.Prepend((this.CommandRuntime as Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelinePrepend) ?? HttpPipelinePrepend);
                }
                if (null != HttpPipelineAppend)
                {
                    Pipeline.Append((this.CommandRuntime as Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelineAppend) ?? HttpPipelineAppend);
                }
                // get the client instance
                try
                {
                    await ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Events.CmdletBeforeAPICall); if( ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    await this.Client.ServiceValidateAddress(SubscriptionId, Location, _validateAddressBody, onOk, onDefault, this, Pipeline);
                    await ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Events.CmdletAfterAPICall); if( ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                }
                catch (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.UndeclaredResponseException urexception)
                {
                    WriteError(new global::System.Management.Automation.ErrorRecord(urexception, urexception.StatusCode.ToString(), global::System.Management.Automation.ErrorCategory.InvalidOperation, new { SubscriptionId=SubscriptionId,Location=Location})
                    {
                      ErrorDetails = new global::System.Management.Automation.ErrorDetails(urexception.Message) { RecommendedAction = urexception.Action }
                    });
                }
                finally
                {
                    await ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Events.CmdletProcessRecordAsyncEnd);
                }
            }
        }

        /// <summary>Interrupts currently running code within the command.</summary>
        protected override void StopProcessing()
        {
            ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IEventListener)this).Cancel();
            base.StopProcessing();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestAzDataBoxServiceAddress_ValidateExpanded" /> cmdlet class.
        /// </summary>
        public TestAzDataBoxServiceAddress_ValidateExpanded()
        {

        }

        /// <param name="sendToPipeline"></param>
        new protected void WriteObject(object sendToPipeline)
        {
            Microsoft.Azure.PowerShell.Cmdlets.DataBox.Module.Instance.SanitizeOutput?.Invoke(sendToPipeline, __correlationId);
            base.WriteObject(sendToPipeline);
        }

        /// <param name="sendToPipeline"></param>
        /// <param name="enumerateCollection"></param>
        new protected void WriteObject(object sendToPipeline, bool enumerateCollection)
        {
            Microsoft.Azure.PowerShell.Cmdlets.DataBox.Module.Instance.SanitizeOutput?.Invoke(sendToPipeline, __correlationId);
            base.WriteObject(sendToPipeline, enumerateCollection);
        }

        /// <summary>
        /// a delegate that is called when the remote service returns default (any response code not handled elsewhere).
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IApiError">Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IApiError</see>
        /// from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onDefault(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IApiError> response)
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
                    var ex = new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IApiError>(responseMessage, await response);
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
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAddressValidationOutput">Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAddressValidationOutput</see>
        /// from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAddressValidationOutput> response)
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
                // (await response) // should be Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAddressValidationOutput
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