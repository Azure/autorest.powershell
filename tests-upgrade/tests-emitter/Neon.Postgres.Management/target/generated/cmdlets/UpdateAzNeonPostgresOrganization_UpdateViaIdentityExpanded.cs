// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Cmdlets
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Extensions;
    using Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.PowerShell;
    using Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Cmdlets;
    using System;

    /// <summary>update a OrganizationResource</summary>
    /// <remarks>
    /// [OpenAPI] Update=>PATCH:"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Neon.Postgres/organizations/{organizationName}"
    /// </remarks>
    [global::System.Management.Automation.Cmdlet(global::System.Management.Automation.VerbsData.Update, @"AzNeonPostgresOrganization_UpdateViaIdentityExpanded", SupportsShouldProcess = true)]
    [global::System.Management.Automation.OutputType(typeof(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResource))]
    [global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Description(@"update a OrganizationResource")]
    [global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Generated]
    [global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.HttpPath(Path = "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Neon.Postgres/organizations/{organizationName}", ApiVersion = "2024-08-01-preview")]
    public partial class UpdateAzNeonPostgresOrganization_UpdateViaIdentityExpanded : global::System.Management.Automation.PSCmdlet,
        Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.IEventListener,
        Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.IContext
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

        /// <summary>Organization Resource by Neon</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResource _propertiesBody = new Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.OrganizationResource();

        /// <summary>when specified, runs this cmdlet as a PowerShell job</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Run the command as a job")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Category(global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter AsJob { get; set; }

        /// <summary>Wait for .NET debugger to attach</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Wait for .NET debugger to attach")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Category(global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter Break { get; set; }

        /// <summary>Accessor for cancellationTokenSource.</summary>
        public global::System.Threading.CancellationTokenSource CancellationTokenSource { get => _cancellationTokenSource ; set { _cancellationTokenSource = value; } }

        /// <summary>The reference to the client API class.</summary>
        public Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.NeonPostgres Client => Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Module.Instance.ClientAPI;

        /// <summary>Business phone number of the company</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Business phone number of the company")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Category(global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Business phone number of the company",
        SerializedName = @"businessPhone",
        PossibleTypes = new [] { typeof(string) })]
        public string CompanyDetailBusinessPhone { get => _propertiesBody.CompanyDetailBusinessPhone ?? null; set => _propertiesBody.CompanyDetailBusinessPhone = value; }

        /// <summary>Company name</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Company name")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Category(global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Company name",
        SerializedName = @"companyName",
        PossibleTypes = new [] { typeof(string) })]
        public string CompanyDetailCompanyName { get => _propertiesBody.CompanyDetailCompanyName ?? null; set => _propertiesBody.CompanyDetailCompanyName = value; }

        /// <summary>Country name of the company</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Country name of the company")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Category(global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Country name of the company",
        SerializedName = @"country",
        PossibleTypes = new [] { typeof(string) })]
        public string CompanyDetailCountry { get => _propertiesBody.CompanyDetailCountry ?? null; set => _propertiesBody.CompanyDetailCountry = value; }

        /// <summary>Domain of the user</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Domain of the user")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Category(global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Domain of the user",
        SerializedName = @"domain",
        PossibleTypes = new [] { typeof(string) })]
        public string CompanyDetailDomain { get => _propertiesBody.CompanyDetailDomain ?? null; set => _propertiesBody.CompanyDetailDomain = value; }

        /// <summary>Number of employees in the company</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Number of employees in the company")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Category(global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Number of employees in the company",
        SerializedName = @"numberOfEmployees",
        PossibleTypes = new [] { typeof(long) })]
        public long CompanyDetailNumberOfEmployee { get => _propertiesBody.CompanyDetailNumberOfEmployee ?? default(long); set => _propertiesBody.CompanyDetailNumberOfEmployee = value; }

        /// <summary>Office address of the company</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Office address of the company")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Category(global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Office address of the company",
        SerializedName = @"officeAddress",
        PossibleTypes = new [] { typeof(string) })]
        public string CompanyDetailOfficeAddress { get => _propertiesBody.CompanyDetailOfficeAddress ?? null; set => _propertiesBody.CompanyDetailOfficeAddress = value; }

        /// <summary>
        /// The DefaultProfile parameter is not functional. Use the SubscriptionId parameter when available if executing the cmdlet
        /// against a different subscription
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The DefaultProfile parameter is not functional. Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::System.Management.Automation.Alias("AzureRMContext", "AzureCredential")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Category(global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.ParameterCategory.Azure)]
        public global::System.Management.Automation.PSObject DefaultProfile { get; set; }

        /// <summary>Accessor for extensibleParameters.</summary>
        public global::System.Collections.Generic.IDictionary<global::System.String,global::System.Object> ExtensibleParameters { get => _extensibleParameters ; }

        /// <summary>SendAsync Pipeline Steps to be appended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be appended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Category(global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.ParameterCategory.Runtime)]
        public Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.SendAsyncStep[] HttpPipelineAppend { get; set; }

        /// <summary>SendAsync Pipeline Steps to be prepended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be prepended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Category(global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.ParameterCategory.Runtime)]
        public Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.SendAsyncStep[] HttpPipelinePrepend { get; set; }

        /// <summary>Backing field for <see cref="InputObject" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.INeonPostgresIdentity _inputObject;

        /// <summary>Identity Parameter</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "Identity Parameter", ValueFromPipeline = true)]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Category(global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.ParameterCategory.Path)]
        public Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.INeonPostgresIdentity InputObject { get => this._inputObject; set => this._inputObject = value; }

        /// <summary>Accessor for our copy of the InvocationInfo.</summary>
        public global::System.Management.Automation.InvocationInfo InvocationInformation { get => __invocationInfo = __invocationInfo ?? this.MyInvocation ; set { __invocationInfo = value; } }

        /// <summary>
        /// <see cref="Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.IEventListener" /> cancellation delegate. Stops the cmdlet when called.
        /// </summary>
        global::System.Action Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.IEventListener.Cancel => _cancellationTokenSource.Cancel;

        /// <summary><see cref="Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.IEventListener" /> cancellation token.</summary>
        global::System.Threading.CancellationToken Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.IEventListener.Token => _cancellationTokenSource.Token;

        /// <summary>
        /// when specified, will make the remote call, and return an AsyncOperationResponse, letting the remote operation continue
        /// asynchronously.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Run the command asynchronously")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Category(global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter NoWait { get; set; }

        /// <summary>Organization Id in partner's system</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Organization Id in partner's system")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Category(global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Organization Id in partner's system",
        SerializedName = @"organizationId",
        PossibleTypes = new [] { typeof(string) })]
        public string PartnerOrganizationPropertyOrganizationId { get => _propertiesBody.PartnerOrganizationPropertyOrganizationId ?? null; set => _propertiesBody.PartnerOrganizationPropertyOrganizationId = value; }

        /// <summary>Organization name in partner's system</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Organization name in partner's system")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Category(global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Organization name in partner's system",
        SerializedName = @"organizationName",
        PossibleTypes = new [] { typeof(string) })]
        public string PartnerOrganizationPropertyOrganizationName { get => _propertiesBody.PartnerOrganizationPropertyOrganizationName ?? null; set => _propertiesBody.PartnerOrganizationPropertyOrganizationName = value; }

        /// <summary>
        /// The instance of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.HttpPipeline" /> that the remote call will use.
        /// </summary>
        public Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.HttpPipeline Pipeline { get; set; }

        /// <summary>The URI for the proxy server to use</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "The URI for the proxy server to use")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Category(global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.ParameterCategory.Runtime)]
        public global::System.Uri Proxy { get; set; }

        /// <summary>Credentials for a proxy server to use for the remote call</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Credentials for a proxy server to use for the remote call")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Category(global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.ParameterCategory.Runtime)]
        public global::System.Management.Automation.PSCredential ProxyCredential { get; set; }

        /// <summary>Use the default credentials for the proxy</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Use the default credentials for the proxy")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Category(global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter ProxyUseDefaultCredentials { get; set; }

        /// <summary>List of AAD domains fetched from Microsoft Graph for user.</summary>
        [global::System.Management.Automation.AllowEmptyCollection]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "List of AAD domains fetched from Microsoft Graph for user.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Category(global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of AAD domains fetched from Microsoft Graph for user.",
        SerializedName = @"aadDomains",
        PossibleTypes = new [] { typeof(string) })]
        public string[] SingleSignOnPropertyAadDomain { get => _propertiesBody.SingleSignOnPropertyAadDomain?.ToArray() ?? null /* fixedArrayOf */; set => _propertiesBody.SingleSignOnPropertyAadDomain = (value != null ? new System.Collections.Generic.List<string>(value) : null); }

        /// <summary>AAD enterprise application Id used to setup SSO</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "AAD enterprise application Id used to setup SSO")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Category(global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"AAD enterprise application Id used to setup SSO",
        SerializedName = @"enterpriseAppId",
        PossibleTypes = new [] { typeof(string) })]
        public string SingleSignOnPropertyEnterpriseAppId { get => _propertiesBody.SingleSignOnPropertyEnterpriseAppId ?? null; set => _propertiesBody.SingleSignOnPropertyEnterpriseAppId = value; }

        /// <summary>State of the Single Sign On for the organization</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "State of the Single Sign On for the organization")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Category(global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"State of the Single Sign On for the organization",
        SerializedName = @"singleSignOnState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PSArgumentCompleterAttribute("Initial", "Enable", "Disable")]
        public string SingleSignOnPropertySingleSignOnState { get => _propertiesBody.SingleSignOnPropertySingleSignOnState ?? null; set => _propertiesBody.SingleSignOnPropertySingleSignOnState = value; }

        /// <summary>URL for SSO to be used by the partner to redirect the user to their system</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "URL for SSO to be used by the partner to redirect the user to their system")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Category(global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"URL for SSO to be used by the partner to redirect the user to their system",
        SerializedName = @"singleSignOnUrl",
        PossibleTypes = new [] { typeof(string) })]
        public string SingleSignOnPropertySingleSignOnUrl { get => _propertiesBody.SingleSignOnPropertySingleSignOnUrl ?? null; set => _propertiesBody.SingleSignOnPropertySingleSignOnUrl = value; }

        /// <summary>Resource tags.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.ExportAs(typeof(global::System.Collections.Hashtable))]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Resource tags.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Category(global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource tags.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ITags) })]
        public Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ITags Tag { get => _propertiesBody.Tag ?? null /* object */; set => _propertiesBody.Tag = value; }

        /// <summary>Email address of the user</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Email address of the user")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Category(global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Email address of the user",
        SerializedName = @"emailAddress",
        PossibleTypes = new [] { typeof(string) })]
        public string UserDetailEmailAddress { get => _propertiesBody.UserDetailEmailAddress ?? null; set => _propertiesBody.UserDetailEmailAddress = value; }

        /// <summary>First name of the user</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "First name of the user")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Category(global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"First name of the user",
        SerializedName = @"firstName",
        PossibleTypes = new [] { typeof(string) })]
        public string UserDetailFirstName { get => _propertiesBody.UserDetailFirstName ?? null; set => _propertiesBody.UserDetailFirstName = value; }

        /// <summary>Last name of the user</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Last name of the user")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Category(global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Last name of the user",
        SerializedName = @"lastName",
        PossibleTypes = new [] { typeof(string) })]
        public string UserDetailLastName { get => _propertiesBody.UserDetailLastName ?? null; set => _propertiesBody.UserDetailLastName = value; }

        /// <summary>User's phone number</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "User's phone number")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Category(global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"User's phone number",
        SerializedName = @"phoneNumber",
        PossibleTypes = new [] { typeof(string) })]
        public string UserDetailPhoneNumber { get => _propertiesBody.UserDetailPhoneNumber ?? null; set => _propertiesBody.UserDetailPhoneNumber = value; }

        /// <summary>User's principal name</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "User's principal name")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Category(global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"User's principal name",
        SerializedName = @"upn",
        PossibleTypes = new [] { typeof(string) })]
        public string UserDetailUpn { get => _propertiesBody.UserDetailUpn ?? null; set => _propertiesBody.UserDetailUpn = value; }

        /// <summary>
        /// <c>overrideOnDefault</c> will be called before the regular onDefault has been processed, allowing customization of what
        /// happens on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IErrorResponse">Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IErrorResponse</see>
        /// from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onDefault method should be processed, or if the method should
        /// return immediately (set to true to skip further processing )</param>

        partial void overrideOnDefault(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IErrorResponse> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// <c>overrideOnOk</c> will be called before the regular onOk has been processed, allowing customization of what happens
        /// on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResource">Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResource</see>
        /// from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onOk method should be processed, or if the method should return
        /// immediately (set to true to skip further processing )</param>

        partial void overrideOnOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResource> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// (overrides the default BeginProcessing method in global::System.Management.Automation.PSCmdlet)
        /// </summary>
        protected override void BeginProcessing()
        {
            var telemetryId = Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Module.Instance.GetTelemetryId.Invoke();
            if (telemetryId != "" && telemetryId != "internal")
            {
                __correlationId = telemetryId;
            }
            Module.Instance.SetProxyConfiguration(Proxy, ProxyCredential, ProxyUseDefaultCredentials);
            if (Break)
            {
                Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.AttachDebugger.Break();
            }
            ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Events.CmdletBeginProcessing).Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
        }

        /// <summary>Creates a duplicate instance of this cmdlet (via JSON serialization).</summary>
        /// <returns>
        /// a duplicate instance of UpdateAzNeonPostgresOrganization_UpdateViaIdentityExpanded
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Cmdlets.UpdateAzNeonPostgresOrganization_UpdateViaIdentityExpanded Clone()
        {
            var clone = new UpdateAzNeonPostgresOrganization_UpdateViaIdentityExpanded();
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
            clone._propertiesBody = this._propertiesBody;
            return clone;
        }

        /// <summary>Performs clean-up after the command execution</summary>
        protected override void EndProcessing()
        {
            var telemetryInfo = Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Module.Instance.GetTelemetryInfo?.Invoke(__correlationId);
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
         async global::System.Threading.Tasks.Task Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.IEventListener.Signal(string id, global::System.Threading.CancellationToken token, global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.EventData> messageData)
        {
            using( NoSynchronizationContext )
            {
                if (token.IsCancellationRequested)
                {
                    return ;
                }

                switch ( id )
                {
                    case Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Events.Verbose:
                    {
                        WriteVerbose($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Events.Warning:
                    {
                        WriteWarning($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Events.Information:
                    {
                        // When an operation supports asjob, Information messages must go thru verbose.
                        WriteVerbose($"INFORMATION: {(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Events.Debug:
                    {
                        WriteDebug($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Events.Error:
                    {
                        WriteError(new global::System.Management.Automation.ErrorRecord( new global::System.Exception(messageData().Message), string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null ) );
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Events.Progress:
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
                    case Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Events.DelayBeforePolling:
                    {
                        var data = messageData();
                        if (true == MyInvocation?.BoundParameters?.ContainsKey("NoWait"))
                        {
                            if (data.ResponseMessage is System.Net.Http.HttpResponseMessage response)
                            {
                                var asyncOperation = response.GetFirstHeader(@"Azure-AsyncOperation");
                                var location = response.GetFirstHeader(@"Location");
                                var uri = global::System.String.IsNullOrEmpty(asyncOperation) ? global::System.String.IsNullOrEmpty(location) ? response.RequestMessage.RequestUri.AbsoluteUri : location : asyncOperation;
                                WriteObject(new Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.PowerShell.AsyncOperationResponse { Target = uri });
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
                await Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Module.Instance.Signal(id, token, messageData, (i, t, m) => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.IEventListener)this).Signal(i, t, () => Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.EventDataConverter.ConvertFrom(m()) as Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.EventData), InvocationInformation, this.ParameterSetName, __correlationId, __processRecordId, null );
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
            ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Events.CmdletProcessRecordStart).Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
            __processRecordId = System.Guid.NewGuid().ToString();
            try
            {
                // work
                if (ShouldProcess($"Call remote 'OrganizationsUpdate' operation"))
                {
                    if (true == MyInvocation?.BoundParameters?.ContainsKey("AsJob"))
                    {
                        var instance = this.Clone();
                        var job = new Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.PowerShell.AsyncJob(instance, this.MyInvocation.Line, this.MyInvocation.MyCommand.Name, this._cancellationTokenSource.Token, this._cancellationTokenSource.Cancel);
                        JobRepository.Add(job);
                        var task = instance.ProcessRecordAsync();
                        job.Monitor(task);
                        WriteObject(job);
                    }
                    else
                    {
                        using( var asyncCommandRuntime = new Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.PowerShell.AsyncCommandRuntime(this, ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.IEventListener)this).Token) )
                        {
                            asyncCommandRuntime.Wait( ProcessRecordAsync(),((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.IEventListener)this).Token);
                        }
                    }
                }
            }
            catch (global::System.AggregateException aggregateException)
            {
                // unroll the inner exceptions to get the root cause
                foreach( var innerException in aggregateException.Flatten().InnerExceptions )
                {
                    ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Events.CmdletException, $"{innerException.GetType().Name} - {innerException.Message} : {innerException.StackTrace}").Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    // Write exception out to error channel.
                    WriteError( new global::System.Management.Automation.ErrorRecord(innerException,string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null) );
                }
            }
            catch (global::System.Exception exception) when ((exception as System.Management.Automation.PipelineStoppedException)== null || (exception as System.Management.Automation.PipelineStoppedException).InnerException != null)
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Events.CmdletException, $"{exception.GetType().Name} - {exception.Message} : {exception.StackTrace}").Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                // Write exception out to error channel.
                WriteError( new global::System.Management.Automation.ErrorRecord(exception,string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null) );
            }
            finally
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Events.CmdletProcessRecordEnd).Wait();
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
                await ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Events.CmdletGetPipeline); if( ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                Pipeline = Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Module.Instance.CreatePipeline(InvocationInformation, __correlationId, __processRecordId, this.ParameterSetName, this.ExtensibleParameters);
                if (null != HttpPipelinePrepend)
                {
                    Pipeline.Prepend((this.CommandRuntime as Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelinePrepend) ?? HttpPipelinePrepend);
                }
                if (null != HttpPipelineAppend)
                {
                    Pipeline.Append((this.CommandRuntime as Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelineAppend) ?? HttpPipelineAppend);
                }
                // get the client instance
                try
                {
                    await ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Events.CmdletBeforeAPICall); if( ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    if (InputObject?.Id != null)
                    {
                        await this.Client.OrganizationsUpdateViaIdentity(InputObject.Id, _propertiesBody, onOk, onDefault, this, Pipeline, Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.SerializationMode.IncludeUpdate);
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
                        if (null == InputObject.OrganizationName)
                        {
                            ThrowTerminatingError( new global::System.Management.Automation.ErrorRecord(new global::System.Exception("InputObject has null value for InputObject.OrganizationName"),string.Empty, global::System.Management.Automation.ErrorCategory.InvalidArgument, InputObject) );
                        }
                        await this.Client.OrganizationsUpdate(InputObject.SubscriptionId ?? null, InputObject.ResourceGroupName ?? null, InputObject.OrganizationName ?? null, _propertiesBody, onOk, onDefault, this, Pipeline, Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.SerializationMode.IncludeUpdate);
                    }
                    await ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Events.CmdletAfterAPICall); if( ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                }
                catch (Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.UndeclaredResponseException urexception)
                {
                    WriteError(new global::System.Management.Automation.ErrorRecord(urexception, urexception.StatusCode.ToString(), global::System.Management.Automation.ErrorCategory.InvalidOperation, new { })
                    {
                      ErrorDetails = new global::System.Management.Automation.ErrorDetails(urexception.Message) { RecommendedAction = urexception.Action }
                    });
                }
                finally
                {
                    await ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Events.CmdletProcessRecordAsyncEnd);
                }
            }
        }

        /// <summary>Interrupts currently running code within the command.</summary>
        protected override void StopProcessing()
        {
            ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.IEventListener)this).Cancel();
            base.StopProcessing();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAzNeonPostgresOrganization_UpdateViaIdentityExpanded" /> cmdlet class.
        /// </summary>
        public UpdateAzNeonPostgresOrganization_UpdateViaIdentityExpanded()
        {

        }

        /// <param name="sendToPipeline"></param>
        new protected void WriteObject(object sendToPipeline)
        {
            Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Module.Instance.SanitizeOutput?.Invoke(sendToPipeline, __correlationId);
            base.WriteObject(sendToPipeline);
        }

        /// <param name="sendToPipeline"></param>
        /// <param name="enumerateCollection"></param>
        new protected void WriteObject(object sendToPipeline, bool enumerateCollection)
        {
            Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Module.Instance.SanitizeOutput?.Invoke(sendToPipeline, __correlationId);
            base.WriteObject(sendToPipeline, enumerateCollection);
        }

        /// <summary>
        /// a delegate that is called when the remote service returns default (any response code not handled elsewhere).
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IErrorResponse">Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IErrorResponse</see>
        /// from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onDefault(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IErrorResponse> response)
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
                    var ex = new Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IErrorResponse>(responseMessage, await response);
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
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResource">Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResource</see>
        /// from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResource> response)
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
                // (await response) // should be Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResource
                var result = (await response);
                WriteObject(result, false);
            }
        }
    }
}