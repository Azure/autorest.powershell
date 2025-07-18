// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Cmdlets
{
    using static Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Extensions;
    using Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.PowerShell;
    using Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Cmdlets;
    using System;

    /// <summary>create a InstanceResource</summary>
    /// <remarks>
    /// [OpenAPI] CreateOrUpdate=>PUT:"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.WeightsAndBiases/instances/{instancename}"
    /// </remarks>
    [global::System.Management.Automation.Cmdlet(global::System.Management.Automation.VerbsCommon.New, @"AzWeightsBiasesInstance_CreateViaIdentityExpanded", SupportsShouldProcess = true)]
    [global::System.Management.Automation.OutputType(typeof(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResource))]
    [global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Description(@"create a InstanceResource")]
    [global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Generated]
    [global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.HttpPath(Path = "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.WeightsAndBiases/instances/{instancename}", ApiVersion = "2024-09-18-preview")]
    public partial class NewAzWeightsBiasesInstance_CreateViaIdentityExpanded : global::System.Management.Automation.PSCmdlet,
        Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.IEventListener,
        Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.IContext
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

        /// <summary>
        /// Concrete tracked resource types can be created by aliasing this type using a specific property type.
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResource _resourceBody = new Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.InstanceResource();

        /// <summary>when specified, runs this cmdlet as a PowerShell job</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Run the command as a job")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Category(global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter AsJob { get; set; }

        /// <summary>Wait for .NET debugger to attach</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Wait for .NET debugger to attach")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Category(global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter Break { get; set; }

        /// <summary>Accessor for cancellationTokenSource.</summary>
        public global::System.Threading.CancellationTokenSource CancellationTokenSource { get => _cancellationTokenSource ; set { _cancellationTokenSource = value; } }

        /// <summary>The reference to the client API class.</summary>
        public Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.MicrosoftWeightsAndBiasesManagementService Client => Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Module.Instance.ClientAPI;

        /// <summary>
        /// The DefaultProfile parameter is not functional. Use the SubscriptionId parameter when available if executing the cmdlet
        /// against a different subscription
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The DefaultProfile parameter is not functional. Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::System.Management.Automation.Alias("AzureRMContext", "AzureCredential")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Category(global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.ParameterCategory.Azure)]
        public global::System.Management.Automation.PSObject DefaultProfile { get; set; }

        /// <summary>Determines whether to enable a system-assigned identity for the resource.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Determines whether to enable a system-assigned identity for the resource.")]
        public global::System.Management.Automation.SwitchParameter EnableSystemAssignedIdentity { set => _resourceBody.IdentityType = value.IsPresent ? "SystemAssigned": null ; }

        /// <summary>Accessor for extensibleParameters.</summary>
        public global::System.Collections.Generic.IDictionary<global::System.String,global::System.Object> ExtensibleParameters { get => _extensibleParameters ; }

        /// <summary>SendAsync Pipeline Steps to be appended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be appended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Category(global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.ParameterCategory.Runtime)]
        public Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.SendAsyncStep[] HttpPipelineAppend { get; set; }

        /// <summary>SendAsync Pipeline Steps to be prepended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be prepended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Category(global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.ParameterCategory.Runtime)]
        public Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.SendAsyncStep[] HttpPipelinePrepend { get; set; }

        /// <summary>Backing field for <see cref="InputObject" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IWeightsBiasesIdentity _inputObject;

        /// <summary>Identity Parameter</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "Identity Parameter", ValueFromPipeline = true)]
        [global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Category(global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.ParameterCategory.Path)]
        public Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IWeightsBiasesIdentity InputObject { get => this._inputObject; set => this._inputObject = value; }

        /// <summary>Accessor for our copy of the InvocationInfo.</summary>
        public global::System.Management.Automation.InvocationInfo InvocationInformation { get => __invocationInfo = __invocationInfo ?? this.MyInvocation ; set { __invocationInfo = value; } }

        /// <summary>The geo-location where the resource lives</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The geo-location where the resource lives")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Category(global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The geo-location where the resource lives",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        public string Location { get => _resourceBody.Location ?? null; set => _resourceBody.Location = value; }

        /// <summary>Azure subscription id for the the marketplace offer is purchased from</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Azure subscription id for the the marketplace offer is purchased from")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Category(global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Azure subscription id for the the marketplace offer is purchased from",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        public string MarketplaceSubscriptionId { get => _resourceBody.MarketplaceSubscriptionId ?? null; set => _resourceBody.MarketplaceSubscriptionId = value; }

        /// <summary>
        /// <see cref="Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.IEventListener" /> cancellation delegate. Stops the cmdlet when called.
        /// </summary>
        global::System.Action Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.IEventListener.Cancel => _cancellationTokenSource.Cancel;

        /// <summary><see cref="Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.IEventListener" /> cancellation token.</summary>
        global::System.Threading.CancellationToken Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.IEventListener.Token => _cancellationTokenSource.Token;

        /// <summary>
        /// when specified, will make the remote call, and return an AsyncOperationResponse, letting the remote operation continue
        /// asynchronously.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Run the command asynchronously")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Category(global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter NoWait { get; set; }

        /// <summary>Offer Id for the marketplace offer</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Offer Id for the marketplace offer")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Category(global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Offer Id for the marketplace offer",
        SerializedName = @"offerId",
        PossibleTypes = new [] { typeof(string) })]
        public string OfferDetailOfferId { get => _resourceBody.OfferDetailOfferId ?? null; set => _resourceBody.OfferDetailOfferId = value; }

        /// <summary>Plan Id for the marketplace offer</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Plan Id for the marketplace offer")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Category(global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Plan Id for the marketplace offer",
        SerializedName = @"planId",
        PossibleTypes = new [] { typeof(string) })]
        public string OfferDetailPlanId { get => _resourceBody.OfferDetailPlanId ?? null; set => _resourceBody.OfferDetailPlanId = value; }

        /// <summary>Plan Name for the marketplace offer</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Plan Name for the marketplace offer")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Category(global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Plan Name for the marketplace offer",
        SerializedName = @"planName",
        PossibleTypes = new [] { typeof(string) })]
        public string OfferDetailPlanName { get => _resourceBody.OfferDetailPlanName ?? null; set => _resourceBody.OfferDetailPlanName = value; }

        /// <summary>Publisher Id for the marketplace offer</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Publisher Id for the marketplace offer")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Category(global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Publisher Id for the marketplace offer",
        SerializedName = @"publisherId",
        PossibleTypes = new [] { typeof(string) })]
        public string OfferDetailPublisherId { get => _resourceBody.OfferDetailPublisherId ?? null; set => _resourceBody.OfferDetailPublisherId = value; }

        /// <summary>Plan Display Name for the marketplace offer</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Plan Display Name for the marketplace offer")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Category(global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Plan Display Name for the marketplace offer",
        SerializedName = @"termId",
        PossibleTypes = new [] { typeof(string) })]
        public string OfferDetailTermId { get => _resourceBody.OfferDetailTermId ?? null; set => _resourceBody.OfferDetailTermId = value; }

        /// <summary>Plan Display Name for the marketplace offer</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Plan Display Name for the marketplace offer")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Category(global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Plan Display Name for the marketplace offer",
        SerializedName = @"termUnit",
        PossibleTypes = new [] { typeof(string) })]
        public string OfferDetailTermUnit { get => _resourceBody.OfferDetailTermUnit ?? null; set => _resourceBody.OfferDetailTermUnit = value; }

        /// <summary>The region of the instance</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The region of the instance")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Category(global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The region of the instance",
        SerializedName = @"region",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PSArgumentCompleterAttribute("eastus", "centralus", "westus", "westeurope", "japaneast", "koreacentral")]
        public string PartnerPropertyRegion { get => _resourceBody.PartnerPropertyRegion ?? null; set => _resourceBody.PartnerPropertyRegion = value; }

        /// <summary>The subdomain of the instance</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The subdomain of the instance")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Category(global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The subdomain of the instance",
        SerializedName = @"subdomain",
        PossibleTypes = new [] { typeof(string) })]
        public string PartnerPropertySubdomain { get => _resourceBody.PartnerPropertySubdomain ?? null; set => _resourceBody.PartnerPropertySubdomain = value; }

        /// <summary>
        /// The instance of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.HttpPipeline" /> that the remote call will use.
        /// </summary>
        public Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.HttpPipeline Pipeline { get; set; }

        /// <summary>The URI for the proxy server to use</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "The URI for the proxy server to use")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Category(global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.ParameterCategory.Runtime)]
        public global::System.Uri Proxy { get; set; }

        /// <summary>Credentials for a proxy server to use for the remote call</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Credentials for a proxy server to use for the remote call")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Category(global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.ParameterCategory.Runtime)]
        public global::System.Management.Automation.PSCredential ProxyCredential { get; set; }

        /// <summary>Use the default credentials for the proxy</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Use the default credentials for the proxy")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Category(global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter ProxyUseDefaultCredentials { get; set; }

        /// <summary>List of AAD domains fetched from Microsoft Graph for user.</summary>
        [global::System.Management.Automation.AllowEmptyCollection]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "List of AAD domains fetched from Microsoft Graph for user.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Category(global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of AAD domains fetched from Microsoft Graph for user.",
        SerializedName = @"aadDomains",
        PossibleTypes = new [] { typeof(string) })]
        public string[] SingleSignOnPropertyAadDomain { get => _resourceBody.SingleSignOnPropertyAadDomain?.ToArray() ?? null /* fixedArrayOf */; set => _resourceBody.SingleSignOnPropertyAadDomain = (value != null ? new System.Collections.Generic.List<string>(value) : null); }

        /// <summary>AAD enterprise application Id used to setup SSO</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "AAD enterprise application Id used to setup SSO")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Category(global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"AAD enterprise application Id used to setup SSO",
        SerializedName = @"enterpriseAppId",
        PossibleTypes = new [] { typeof(string) })]
        public string SingleSignOnPropertyEnterpriseAppId { get => _resourceBody.SingleSignOnPropertyEnterpriseAppId ?? null; set => _resourceBody.SingleSignOnPropertyEnterpriseAppId = value; }

        /// <summary>State of the Single Sign On for the resource</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "State of the Single Sign On for the resource")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Category(global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"State of the Single Sign On for the resource",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PSArgumentCompleterAttribute("Initial", "Enable", "Disable")]
        public string SingleSignOnPropertyState { get => _resourceBody.SingleSignOnPropertyState ?? null; set => _resourceBody.SingleSignOnPropertyState = value; }

        /// <summary>Type of Single Sign-On mechanism being used</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Type of Single Sign-On mechanism being used")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Category(global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Type of Single Sign-On mechanism being used",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PSArgumentCompleterAttribute("Saml", "OpenId")]
        public string SingleSignOnPropertyType { get => _resourceBody.SingleSignOnPropertyType ?? null; set => _resourceBody.SingleSignOnPropertyType = value; }

        /// <summary>URL for SSO to be used by the partner to redirect the user to their system</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "URL for SSO to be used by the partner to redirect the user to their system")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Category(global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"URL for SSO to be used by the partner to redirect the user to their system",
        SerializedName = @"url",
        PossibleTypes = new [] { typeof(string) })]
        public string SingleSignOnPropertyUrl { get => _resourceBody.SingleSignOnPropertyUrl ?? null; set => _resourceBody.SingleSignOnPropertyUrl = value; }

        /// <summary>Resource tags.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.ExportAs(typeof(global::System.Collections.Hashtable))]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Resource tags.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Category(global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource tags.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.ITags) })]
        public Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.ITags Tag { get => _resourceBody.Tag ?? null /* object */; set => _resourceBody.Tag = value; }

        /// <summary>
        /// The array of user assigned identities associated with the resource. The elements in array will be ARM resource ids in
        /// the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}.'
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The array of user assigned identities associated with the resource. The elements in array will be ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}.'")]
        [global::System.Management.Automation.AllowEmptyCollection]
        public string[] UserAssignedIdentity { get; set; }

        /// <summary>Email address of the user</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Email address of the user")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Category(global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Email address of the user",
        SerializedName = @"emailAddress",
        PossibleTypes = new [] { typeof(string) })]
        public string UserEmailAddress { get => _resourceBody.UserEmailAddress ?? null; set => _resourceBody.UserEmailAddress = value; }

        /// <summary>First name of the user</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "First name of the user")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Category(global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"First name of the user",
        SerializedName = @"firstName",
        PossibleTypes = new [] { typeof(string) })]
        public string UserFirstName { get => _resourceBody.UserFirstName ?? null; set => _resourceBody.UserFirstName = value; }

        /// <summary>Last name of the user</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Last name of the user")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Category(global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Last name of the user",
        SerializedName = @"lastName",
        PossibleTypes = new [] { typeof(string) })]
        public string UserLastName { get => _resourceBody.UserLastName ?? null; set => _resourceBody.UserLastName = value; }

        /// <summary>User's phone number</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "User's phone number")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Category(global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"User's phone number",
        SerializedName = @"phoneNumber",
        PossibleTypes = new [] { typeof(string) })]
        public string UserPhoneNumber { get => _resourceBody.UserPhoneNumber ?? null; set => _resourceBody.UserPhoneNumber = value; }

        /// <summary>User's principal name</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "User's principal name")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Category(global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"User's principal name",
        SerializedName = @"upn",
        PossibleTypes = new [] { typeof(string) })]
        public string UserUpn { get => _resourceBody.UserUpn ?? null; set => _resourceBody.UserUpn = value; }

        /// <summary>
        /// <c>overrideOnDefault</c> will be called before the regular onDefault has been processed, allowing customization of what
        /// happens on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IErrorResponse">Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IErrorResponse</see>
        /// from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onDefault method should be processed, or if the method should
        /// return immediately (set to true to skip further processing )</param>

        partial void overrideOnDefault(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IErrorResponse> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// <c>overrideOnOk</c> will be called before the regular onOk has been processed, allowing customization of what happens
        /// on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResource">Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResource</see>
        /// from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onOk method should be processed, or if the method should return
        /// immediately (set to true to skip further processing )</param>

        partial void overrideOnOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResource> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// (overrides the default BeginProcessing method in global::System.Management.Automation.PSCmdlet)
        /// </summary>
        protected override void BeginProcessing()
        {
            var telemetryId = Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Module.Instance.GetTelemetryId.Invoke();
            if (telemetryId != "" && telemetryId != "internal")
            {
                __correlationId = telemetryId;
            }
            Module.Instance.SetProxyConfiguration(Proxy, ProxyCredential, ProxyUseDefaultCredentials);
            if (Break)
            {
                Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.AttachDebugger.Break();
            }
            ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Events.CmdletBeginProcessing).Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
        }

        /// <summary>Creates a duplicate instance of this cmdlet (via JSON serialization).</summary>
        /// <returns>a duplicate instance of NewAzWeightsBiasesInstance_CreateViaIdentityExpanded</returns>
        public Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Cmdlets.NewAzWeightsBiasesInstance_CreateViaIdentityExpanded Clone()
        {
            var clone = new NewAzWeightsBiasesInstance_CreateViaIdentityExpanded();
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
            return clone;
        }

        /// <summary>Performs clean-up after the command execution</summary>
        protected override void EndProcessing()
        {
            var telemetryInfo = Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Module.Instance.GetTelemetryInfo?.Invoke(__correlationId);
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
         async global::System.Threading.Tasks.Task Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.IEventListener.Signal(string id, global::System.Threading.CancellationToken token, global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.EventData> messageData)
        {
            using( NoSynchronizationContext )
            {
                if (token.IsCancellationRequested)
                {
                    return ;
                }

                switch ( id )
                {
                    case Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Events.Verbose:
                    {
                        WriteVerbose($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Events.Warning:
                    {
                        WriteWarning($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Events.Information:
                    {
                        // When an operation supports asjob, Information messages must go thru verbose.
                        WriteVerbose($"INFORMATION: {(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Events.Debug:
                    {
                        WriteDebug($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Events.Error:
                    {
                        WriteError(new global::System.Management.Automation.ErrorRecord( new global::System.Exception(messageData().Message), string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null ) );
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Events.Progress:
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
                    case Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Events.DelayBeforePolling:
                    {
                        var data = messageData();
                        if (true == MyInvocation?.BoundParameters?.ContainsKey("NoWait"))
                        {
                            if (data.ResponseMessage is System.Net.Http.HttpResponseMessage response)
                            {
                                var asyncOperation = response.GetFirstHeader(@"Azure-AsyncOperation");
                                var location = response.GetFirstHeader(@"Location");
                                var uri = global::System.String.IsNullOrEmpty(asyncOperation) ? global::System.String.IsNullOrEmpty(location) ? response.RequestMessage.RequestUri.AbsoluteUri : location : asyncOperation;
                                WriteObject(new Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.PowerShell.AsyncOperationResponse { Target = uri });
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
                await Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Module.Instance.Signal(id, token, messageData, (i, t, m) => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.IEventListener)this).Signal(i, t, () => Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.EventDataConverter.ConvertFrom(m()) as Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.EventData), InvocationInformation, this.ParameterSetName, __correlationId, __processRecordId, null );
                if (token.IsCancellationRequested)
                {
                    return ;
                }
                WriteDebug($"{id}: {(messageData().Message ?? global::System.String.Empty)}");
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewAzWeightsBiasesInstance_CreateViaIdentityExpanded" /> cmdlet class.
        /// </summary>
        public NewAzWeightsBiasesInstance_CreateViaIdentityExpanded()
        {

        }

        private void PreProcessManagedIdentityParameters()
        {
            if (this.UserAssignedIdentity?.Length > 0)
            {
                // calculate UserAssignedIdentity
                _resourceBody.IdentityUserAssignedIdentity.Clear();
                foreach( var id in this.UserAssignedIdentity )
                {
                    _resourceBody.IdentityUserAssignedIdentity.Add(id, new Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.UserAssignedIdentity());
                }
            }
            // calculate IdentityType
            if (this.UserAssignedIdentity?.Length > 0)
            {
                if ("SystemAssigned".Equals(_resourceBody.IdentityType, StringComparison.InvariantCultureIgnoreCase))
                {
                    _resourceBody.IdentityType = "SystemAssigned,UserAssigned";
                }
                else
                {
                    _resourceBody.IdentityType = "UserAssigned";
                }
            }
        }

        /// <summary>Performs execution of the command.</summary>
        protected override void ProcessRecord()
        {
            ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Events.CmdletProcessRecordStart).Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
            __processRecordId = System.Guid.NewGuid().ToString();
            try
            {
                // work
                if (ShouldProcess($"Call remote 'InstancesCreateOrUpdate' operation"))
                {
                    if (true == MyInvocation?.BoundParameters?.ContainsKey("AsJob"))
                    {
                        var instance = this.Clone();
                        var job = new Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.PowerShell.AsyncJob(instance, this.MyInvocation.Line, this.MyInvocation.MyCommand.Name, this._cancellationTokenSource.Token, this._cancellationTokenSource.Cancel);
                        JobRepository.Add(job);
                        var task = instance.ProcessRecordAsync();
                        job.Monitor(task);
                        WriteObject(job);
                    }
                    else
                    {
                        using( var asyncCommandRuntime = new Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.PowerShell.AsyncCommandRuntime(this, ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.IEventListener)this).Token) )
                        {
                            asyncCommandRuntime.Wait( ProcessRecordAsync(),((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.IEventListener)this).Token);
                        }
                    }
                }
            }
            catch (global::System.AggregateException aggregateException)
            {
                // unroll the inner exceptions to get the root cause
                foreach( var innerException in aggregateException.Flatten().InnerExceptions )
                {
                    ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Events.CmdletException, $"{innerException.GetType().Name} - {innerException.Message} : {innerException.StackTrace}").Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    // Write exception out to error channel.
                    WriteError( new global::System.Management.Automation.ErrorRecord(innerException,string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null) );
                }
            }
            catch (global::System.Exception exception) when ((exception as System.Management.Automation.PipelineStoppedException)== null || (exception as System.Management.Automation.PipelineStoppedException).InnerException != null)
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Events.CmdletException, $"{exception.GetType().Name} - {exception.Message} : {exception.StackTrace}").Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                // Write exception out to error channel.
                WriteError( new global::System.Management.Automation.ErrorRecord(exception,string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null) );
            }
            finally
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Events.CmdletProcessRecordEnd).Wait();
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
                await ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Events.CmdletGetPipeline); if( ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                Pipeline = Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Module.Instance.CreatePipeline(InvocationInformation, __correlationId, __processRecordId, this.ParameterSetName, this.ExtensibleParameters);
                if (null != HttpPipelinePrepend)
                {
                    Pipeline.Prepend((this.CommandRuntime as Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelinePrepend) ?? HttpPipelinePrepend);
                }
                if (null != HttpPipelineAppend)
                {
                    Pipeline.Append((this.CommandRuntime as Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelineAppend) ?? HttpPipelineAppend);
                }
                // get the client instance
                try
                {
                    await ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Events.CmdletBeforeAPICall); if( ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    if (InputObject?.Id != null)
                    {
                        this.PreProcessManagedIdentityParameters();
                        await this.Client.InstancesCreateOrUpdateViaIdentity(InputObject.Id, _resourceBody, onOk, onDefault, this, Pipeline, Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.SerializationMode.IncludeCreate);
                    }
                    else
                    {
                        // try to call with PATH parameters from Input Object
                        if (null == InputObject.SubscriptionId)
                        {
                            ThrowTerminatingError( new global::System.Management.Automation.ErrorRecord(new global::System.Exception("InputObject has null value for InputObject.SubscriptionId"),string.Empty, global::System.Management.Automation.ErrorCategory.InvalidArgument, InputObject) );
                        }
                        if (null == InputObject.ResourceGroupName)
                        {
                            ThrowTerminatingError( new global::System.Management.Automation.ErrorRecord(new global::System.Exception("InputObject has null value for InputObject.ResourceGroupName"),string.Empty, global::System.Management.Automation.ErrorCategory.InvalidArgument, InputObject) );
                        }
                        if (null == InputObject.Instancename)
                        {
                            ThrowTerminatingError( new global::System.Management.Automation.ErrorRecord(new global::System.Exception("InputObject has null value for InputObject.Instancename"),string.Empty, global::System.Management.Automation.ErrorCategory.InvalidArgument, InputObject) );
                        }
                        this.PreProcessManagedIdentityParameters();
                        await this.Client.InstancesCreateOrUpdate(InputObject.SubscriptionId ?? null, InputObject.ResourceGroupName ?? null, InputObject.Instancename ?? null, _resourceBody, onOk, onDefault, this, Pipeline, Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.SerializationMode.IncludeCreate);
                    }
                    await ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Events.CmdletAfterAPICall); if( ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                }
                catch (Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.UndeclaredResponseException urexception)
                {
                    WriteError(new global::System.Management.Automation.ErrorRecord(urexception, urexception.StatusCode.ToString(), global::System.Management.Automation.ErrorCategory.InvalidOperation, new { })
                    {
                      ErrorDetails = new global::System.Management.Automation.ErrorDetails(urexception.Message) { RecommendedAction = urexception.Action }
                    });
                }
                finally
                {
                    await ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Events.CmdletProcessRecordAsyncEnd);
                }
            }
        }

        /// <summary>Interrupts currently running code within the command.</summary>
        protected override void StopProcessing()
        {
            ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.IEventListener)this).Cancel();
            base.StopProcessing();
        }

        /// <param name="sendToPipeline"></param>
        new protected void WriteObject(object sendToPipeline)
        {
            Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Module.Instance.SanitizeOutput?.Invoke(sendToPipeline, __correlationId);
            base.WriteObject(sendToPipeline);
        }

        /// <param name="sendToPipeline"></param>
        /// <param name="enumerateCollection"></param>
        new protected void WriteObject(object sendToPipeline, bool enumerateCollection)
        {
            Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Module.Instance.SanitizeOutput?.Invoke(sendToPipeline, __correlationId);
            base.WriteObject(sendToPipeline, enumerateCollection);
        }

        /// <summary>
        /// a delegate that is called when the remote service returns default (any response code not handled elsewhere).
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IErrorResponse">Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IErrorResponse</see>
        /// from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onDefault(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IErrorResponse> response)
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
                    var ex = new Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IErrorResponse>(responseMessage, await response);
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
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResource">Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResource</see>
        /// from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResource> response)
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
                // (await response) // should be Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResource
                var result = (await response);
                WriteObject(result, false);
            }
        }
    }
}