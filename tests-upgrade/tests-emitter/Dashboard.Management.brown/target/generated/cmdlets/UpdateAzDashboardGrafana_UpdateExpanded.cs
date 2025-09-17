// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Cmdlets
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Extensions;
    using Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.PowerShell;
    using Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Cmdlets;
    using System;

    /// <summary>
    /// update a workspace for Grafana resource. This API is idempotent, so user can either update a new grafana or update an
    /// existing grafana.
    /// </summary>
    /// <remarks>
    /// [OpenAPI] Get=>GET:"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Dashboard/grafana/{workspaceName}"
    /// [OpenAPI] Create=>PUT:"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Dashboard/grafana/{workspaceName}"
    /// </remarks>
    [global::System.Management.Automation.Cmdlet(global::System.Management.Automation.VerbsData.Update, @"AzDashboardGrafana_UpdateExpanded", SupportsShouldProcess = true)]
    [global::System.Management.Automation.OutputType(typeof(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafana))]
    [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Description(@"update a workspace for Grafana resource. This API is idempotent, so user can either update a new grafana or update an existing grafana.")]
    [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Generated]
    public partial class UpdateAzDashboardGrafana_UpdateExpanded : global::System.Management.Automation.PSCmdlet,
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.IEventListener,
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.IContext
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

        /// <summary>The grafana resource type.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafana _requestBodyParametersBody = new Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ManagedGrafana();

        /// <summary>The api key setting of the Grafana instance.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The api key setting of the Grafana instance.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The api key setting of the Grafana instance.",
        SerializedName = @"apiKey",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PSArgumentCompleterAttribute("Disabled", "Enabled")]
        public string ApiKey { get => _requestBodyParametersBody.ApiKey ?? null; set => _requestBodyParametersBody.ApiKey = value; }

        /// <summary>when specified, runs this cmdlet as a PowerShell job</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Run the command as a job")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter AsJob { get; set; }

        /// <summary>Wait for .NET debugger to attach</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Wait for .NET debugger to attach")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter Break { get; set; }

        /// <summary>Accessor for cancellationTokenSource.</summary>
        public global::System.Threading.CancellationTokenSource CancellationTokenSource { get => _cancellationTokenSource ; set { _cancellationTokenSource = value; } }

        /// <summary>The reference to the client API class.</summary>
        public Microsoft.Azure.PowerShell.Cmdlets.Dashboard.MicrosoftDashboard Client => Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Module.Instance.ClientAPI;

        /// <summary>
        /// The DefaultProfile parameter is not functional. Use the SubscriptionId parameter when available if executing the cmdlet
        /// against a different subscription
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The DefaultProfile parameter is not functional. Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::System.Management.Automation.Alias("AzureRMContext", "AzureCredential")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.ParameterCategory.Azure)]
        public global::System.Management.Automation.PSObject DefaultProfile { get; set; }

        /// <summary>Whether a Grafana instance uses deterministic outbound IPs.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Whether a Grafana instance uses deterministic outbound IPs.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Whether a Grafana instance uses deterministic outbound IPs.",
        SerializedName = @"deterministicOutboundIP",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PSArgumentCompleterAttribute("Disabled", "Enabled")]
        public string DeterministicOutboundIP { get => _requestBodyParametersBody.DeterministicOutboundIP ?? null; set => _requestBodyParametersBody.DeterministicOutboundIP = value; }

        /// <summary>Determines whether to enable a system-assigned identity for the resource.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Determines whether to enable a system-assigned identity for the resource.")]
        public System.Boolean? EnableSystemAssignedIdentity { get; set; }

        /// <summary>The AutoRenew setting of the Enterprise subscription</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The AutoRenew setting of the Enterprise subscription")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The AutoRenew setting of the Enterprise subscription",
        SerializedName = @"marketplaceAutoRenew",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PSArgumentCompleterAttribute("Disabled", "Enabled")]
        public string EnterpriseConfigurationMarketplaceAutoRenew { get => _requestBodyParametersBody.EnterpriseConfigurationMarketplaceAutoRenew ?? null; set => _requestBodyParametersBody.EnterpriseConfigurationMarketplaceAutoRenew = value; }

        /// <summary>The Plan Id of the Azure Marketplace subscription for the Enterprise plugins</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The Plan Id of the Azure Marketplace subscription for the Enterprise plugins")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Plan Id of the Azure Marketplace subscription for the Enterprise plugins",
        SerializedName = @"marketplacePlanId",
        PossibleTypes = new [] { typeof(string) })]
        public string EnterpriseConfigurationMarketplacePlanId { get => _requestBodyParametersBody.EnterpriseConfigurationMarketplacePlanId ?? null; set => _requestBodyParametersBody.EnterpriseConfigurationMarketplacePlanId = value; }

        /// <summary>Accessor for extensibleParameters.</summary>
        public global::System.Collections.Generic.IDictionary<global::System.String,global::System.Object> ExtensibleParameters { get => _extensibleParameters ; }

        /// <summary>Array of AzureMonitorWorkspaceIntegration</summary>
        [global::System.Management.Automation.AllowEmptyCollection]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Array of AzureMonitorWorkspaceIntegration")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Array of AzureMonitorWorkspaceIntegration",
        SerializedName = @"azureMonitorWorkspaceIntegrations",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IAzureMonitorWorkspaceIntegration) })]
        public Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IAzureMonitorWorkspaceIntegration[] GrafanaIntegrationAzureMonitorWorkspaceIntegration { get => _requestBodyParametersBody.GrafanaIntegrationAzureMonitorWorkspaceIntegration?.ToArray() ?? null /* fixedArrayOf */; set => _requestBodyParametersBody.GrafanaIntegrationAzureMonitorWorkspaceIntegration = (value != null ? new System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IAzureMonitorWorkspaceIntegration>(value) : null); }

        /// <summary>The major Grafana software version to target.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The major Grafana software version to target.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The major Grafana software version to target.",
        SerializedName = @"grafanaMajorVersion",
        PossibleTypes = new [] { typeof(string) })]
        public string GrafanaMajorVersion { get => _requestBodyParametersBody.GrafanaMajorVersion ?? null; set => _requestBodyParametersBody.GrafanaMajorVersion = value; }

        /// <summary>
        /// Installed plugin list of the Grafana instance. Key is plugin id, value is plugin definition.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.ExportAs(typeof(global::System.Collections.Hashtable))]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Installed plugin list of the Grafana instance. Key is plugin id, value is plugin definition.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Installed plugin list of the Grafana instance. Key is plugin id, value is plugin definition.",
        SerializedName = @"grafanaPlugins",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesGrafanaPlugins) })]
        public Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesGrafanaPlugins GrafanaPlugin { get => _requestBodyParametersBody.GrafanaPlugin ?? null /* object */; set => _requestBodyParametersBody.GrafanaPlugin = value; }

        /// <summary>SendAsync Pipeline Steps to be appended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be appended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.ParameterCategory.Runtime)]
        public Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.SendAsyncStep[] HttpPipelineAppend { get; set; }

        /// <summary>SendAsync Pipeline Steps to be prepended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be prepended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.ParameterCategory.Runtime)]
        public Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.SendAsyncStep[] HttpPipelinePrepend { get; set; }

        /// <summary>Accessor for our copy of the InvocationInfo.</summary>
        public global::System.Management.Automation.InvocationInfo InvocationInformation { get => __invocationInfo = __invocationInfo ?? this.MyInvocation ; set { __invocationInfo = value; } }

        /// <summary>
        /// <see cref="Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.IEventListener" /> cancellation delegate. Stops the cmdlet when called.
        /// </summary>
        global::System.Action Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.IEventListener.Cancel => _cancellationTokenSource.Cancel;

        /// <summary><see cref="Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.IEventListener" /> cancellation token.</summary>
        global::System.Threading.CancellationToken Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.IEventListener.Token => _cancellationTokenSource.Token;

        /// <summary>
        /// when specified, will make the remote call, and return an AsyncOperationResponse, letting the remote operation continue
        /// asynchronously.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Run the command asynchronously")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter NoWait { get; set; }

        /// <summary>
        /// The instance of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.HttpPipeline" /> that the remote call will use.
        /// </summary>
        public Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.HttpPipeline Pipeline { get; set; }

        /// <summary>The URI for the proxy server to use</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "The URI for the proxy server to use")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.ParameterCategory.Runtime)]
        public global::System.Uri Proxy { get; set; }

        /// <summary>Credentials for a proxy server to use for the remote call</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Credentials for a proxy server to use for the remote call")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.ParameterCategory.Runtime)]
        public global::System.Management.Automation.PSCredential ProxyCredential { get; set; }

        /// <summary>Use the default credentials for the proxy</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Use the default credentials for the proxy")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter ProxyUseDefaultCredentials { get; set; }

        /// <summary>Indicate the state for enable or disable traffic over the public interface.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Indicate the state for enable or disable traffic over the public interface.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicate the state for enable or disable traffic over the public interface.",
        SerializedName = @"publicNetworkAccess",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        public string PublicNetworkAccess { get => _requestBodyParametersBody.PublicNetworkAccess ?? null; set => _requestBodyParametersBody.PublicNetworkAccess = value; }

        /// <summary>Backing field for <see cref="ResourceGroupName" /> property.</summary>
        private string _resourceGroupName;

        /// <summary>The name of the resource group. The name is case insensitive.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The name of the resource group. The name is case insensitive.")]
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The name of the resource group. The name is case insensitive.",
        SerializedName = @"resourceGroupName",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.ParameterCategory.Path)]
        public string ResourceGroupName { get => this._resourceGroupName; set => this._resourceGroupName = value; }

        /// <summary>
        /// Set to true to execute the CSRF check even if the login cookie is not in a request (default false).
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Set to true to execute the CSRF check even if the login cookie is not in a request (default false).")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Set to true to execute the CSRF check even if the login cookie is not in a request (default false).",
        SerializedName = @"csrfAlwaysCheck",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter SecurityCsrfAlwaysCheck { get => _requestBodyParametersBody.SecurityCsrfAlwaysCheck ?? default(global::System.Management.Automation.SwitchParameter); set => _requestBodyParametersBody.SecurityCsrfAlwaysCheck = value; }

        /// <summary>The name of the SKU.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The name of the SKU.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the SKU.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        public string SkuName { get => _requestBodyParametersBody.SkuName ?? null; set => _requestBodyParametersBody.SkuName = value; }

        /// <summary>Enable this to allow Grafana to send email. Default is false</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Enable this to allow Grafana to send email. Default is false")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Enable this to allow Grafana to send email. Default is false",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter SmtpEnabled { get => _requestBodyParametersBody.SmtpEnabled ?? default(global::System.Management.Automation.SwitchParameter); set => _requestBodyParametersBody.SmtpEnabled = value; }

        /// <summary>Address used when sending out emailshttps://pkg.go.dev/net/mail#Address</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Address used when sending out emailshttps://pkg.go.dev/net/mail#Address")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Address used when sending out emailshttps://pkg.go.dev/net/mail#Address",
        SerializedName = @"fromAddress",
        PossibleTypes = new [] { typeof(string) })]
        public string SmtpFromAddress { get => _requestBodyParametersBody.SmtpFromAddress ?? null; set => _requestBodyParametersBody.SmtpFromAddress = value; }

        /// <summary>
        /// Name to be used when sending out emails. Default is "Azure Managed Grafana Notification"https://pkg.go.dev/net/mail#Address
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Name to be used when sending out emails. Default is \"Azure Managed Grafana Notification\"https://pkg.go.dev/net/mail#Address")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name to be used when sending out emails. Default is ""Azure Managed Grafana Notification""https://pkg.go.dev/net/mail#Address",
        SerializedName = @"fromName",
        PossibleTypes = new [] { typeof(string) })]
        public string SmtpFromName { get => _requestBodyParametersBody.SmtpFromName ?? null; set => _requestBodyParametersBody.SmtpFromName = value; }

        /// <summary>SMTP server hostname with port, e.g. test.email.net:587</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "SMTP server hostname with port, e.g. test.email.net:587")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"SMTP server hostname with port, e.g. test.email.net:587",
        SerializedName = @"host",
        PossibleTypes = new [] { typeof(string) })]
        public string SmtpHost { get => _requestBodyParametersBody.SmtpHost ?? null; set => _requestBodyParametersBody.SmtpHost = value; }

        /// <summary>
        /// Password of SMTP auth. If the password contains # or ;, then you have to wrap it with triple quotes
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Password of SMTP auth. If the password contains # or ;, then you have to wrap it with triple quotes")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Password of SMTP auth. If the password contains # or ;, then you have to wrap it with triple quotes",
        SerializedName = @"password",
        PossibleTypes = new [] { typeof(System.Security.SecureString) })]
        public System.Security.SecureString SmtpPassword { get => _requestBodyParametersBody.SmtpPassword ?? null; set => _requestBodyParametersBody.SmtpPassword = value; }

        /// <summary>
        /// Verify SSL for SMTP server. Default is falsehttps://pkg.go.dev/crypto/tls#Config
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Verify SSL for SMTP server. Default is falsehttps://pkg.go.dev/crypto/tls#Config")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Verify SSL for SMTP server. Default is falsehttps://pkg.go.dev/crypto/tls#Config",
        SerializedName = @"skipVerify",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter SmtpSkipVerify { get => _requestBodyParametersBody.SmtpSkipVerify ?? default(global::System.Management.Automation.SwitchParameter); set => _requestBodyParametersBody.SmtpSkipVerify = value; }

        /// <summary>
        /// The StartTLSPolicy setting of the SMTP configurationhttps://pkg.go.dev/github.com/go-mail/mail#StartTLSPolicy
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The StartTLSPolicy setting of the SMTP configurationhttps://pkg.go.dev/github.com/go-mail/mail#StartTLSPolicy")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The StartTLSPolicy setting of the SMTP configurationhttps://pkg.go.dev/github.com/go-mail/mail#StartTLSPolicy",
        SerializedName = @"startTLSPolicy",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PSArgumentCompleterAttribute("OpportunisticStartTLS", "MandatoryStartTLS", "NoStartTLS")]
        public string SmtpStartTlsPolicy { get => _requestBodyParametersBody.SmtpStartTlsPolicy ?? null; set => _requestBodyParametersBody.SmtpStartTlsPolicy = value; }

        /// <summary>User of SMTP auth</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "User of SMTP auth")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"User of SMTP auth",
        SerializedName = @"user",
        PossibleTypes = new [] { typeof(string) })]
        public string SmtpUser { get => _requestBodyParametersBody.SmtpUser ?? null; set => _requestBodyParametersBody.SmtpUser = value; }

        /// <summary>Set to false to disable external snapshot publish endpoint</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Set to false to disable external snapshot publish endpoint")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Set to false to disable external snapshot publish endpoint",
        SerializedName = @"externalEnabled",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter SnapshotExternalEnabled { get => _requestBodyParametersBody.SnapshotExternalEnabled ?? default(global::System.Management.Automation.SwitchParameter); set => _requestBodyParametersBody.SnapshotExternalEnabled = value; }

        /// <summary>Backing field for <see cref="SubscriptionId" /> property.</summary>
        private string _subscriptionId;

        /// <summary>The ID of the target subscription. The value must be an UUID.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The ID of the target subscription. The value must be an UUID.")]
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The ID of the target subscription. The value must be an UUID.",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.DefaultInfo(
        Name = @"",
        Description =@"",
        Script = @"(Get-AzContext).Subscription.Id",
        SetCondition = @"")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.ParameterCategory.Path)]
        public string SubscriptionId { get => this._subscriptionId; set => this._subscriptionId = value; }

        /// <summary>Resource tags.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.ExportAs(typeof(global::System.Collections.Hashtable))]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Resource tags.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource tags.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaTags) })]
        public Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaTags Tag { get => _requestBodyParametersBody.Tag ?? null /* object */; set => _requestBodyParametersBody.Tag = value; }

        /// <summary>
        /// Set to false to disable capture screenshot in Unified Alert due to performance issue.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Set to false to disable capture screenshot in Unified Alert due to performance issue.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Set to false to disable capture screenshot in Unified Alert due to performance issue.",
        SerializedName = @"captureEnabled",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter UnifiedAlertingScreenshotCaptureEnabled { get => _requestBodyParametersBody.UnifiedAlertingScreenshotCaptureEnabled ?? default(global::System.Management.Automation.SwitchParameter); set => _requestBodyParametersBody.UnifiedAlertingScreenshotCaptureEnabled = value; }

        /// <summary>
        /// The array of user assigned identities associated with the resource. The elements in array will be ARM resource ids in
        /// the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}.'
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The array of user assigned identities associated with the resource. The elements in array will be ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}.'")]
        [global::System.Management.Automation.AllowEmptyCollection]
        public string[] UserAssignedIdentity { get; set; }

        /// <summary>
        /// Set to true so editors can administrate dashboards, folders and teams they create.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Set to true so editors can administrate dashboards, folders and teams they create.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Set to true so editors can administrate dashboards, folders and teams they create.",
        SerializedName = @"editorsCanAdmin",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter UserEditorsCanAdmin { get => _requestBodyParametersBody.UserEditorsCanAdmin ?? default(global::System.Management.Automation.SwitchParameter); set => _requestBodyParametersBody.UserEditorsCanAdmin = value; }

        /// <summary>
        /// Set to true so viewers can access and use explore and perform temporary edits on panels in dashboards they have access
        /// to. They cannot save their changes.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Set to true so viewers can access and use explore and perform temporary edits on panels in dashboards they have access to. They cannot save their changes.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Set to true so viewers can access and use explore and perform temporary edits on panels in dashboards they have access to. They cannot save their changes.",
        SerializedName = @"viewersCanEdit",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter UserViewersCanEdit { get => _requestBodyParametersBody.UserViewersCanEdit ?? default(global::System.Management.Automation.SwitchParameter); set => _requestBodyParametersBody.UserViewersCanEdit = value; }

        /// <summary>Backing field for <see cref="WorkspaceName" /> property.</summary>
        private string _workspaceName;

        /// <summary>The workspace name of Azure Managed Grafana.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The workspace name of Azure Managed Grafana.")]
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The workspace name of Azure Managed Grafana.",
        SerializedName = @"workspaceName",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.ParameterCategory.Path)]
        public string WorkspaceName { get => this._workspaceName; set => this._workspaceName = value; }

        /// <summary>The zone redundancy setting of the Grafana instance.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The zone redundancy setting of the Grafana instance.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The zone redundancy setting of the Grafana instance.",
        SerializedName = @"zoneRedundancy",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PSArgumentCompleterAttribute("Disabled", "Enabled")]
        public string ZoneRedundancy { get => _requestBodyParametersBody.ZoneRedundancy ?? null; set => _requestBodyParametersBody.ZoneRedundancy = value; }

        /// <summary>
        /// <c>overrideOnDefault</c> will be called before the regular onDefault has been processed, allowing customization of what
        /// happens on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IErrorResponse">Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IErrorResponse</see>
        /// from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onDefault method should be processed, or if the method should
        /// return immediately (set to true to skip further processing )</param>

        partial void overrideOnDefault(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IErrorResponse> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// <c>overrideOnOk</c> will be called before the regular onOk has been processed, allowing customization of what happens
        /// on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafana">Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafana</see>
        /// from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onOk method should be processed, or if the method should return
        /// immediately (set to true to skip further processing )</param>

        partial void overrideOnOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafana> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// (overrides the default BeginProcessing method in global::System.Management.Automation.PSCmdlet)
        /// </summary>
        protected override void BeginProcessing()
        {
            var telemetryId = Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Module.Instance.GetTelemetryId.Invoke();
            if (telemetryId != "" && telemetryId != "internal")
            {
                __correlationId = telemetryId;
            }
            Module.Instance.SetProxyConfiguration(Proxy, ProxyCredential, ProxyUseDefaultCredentials);
            if (Break)
            {
                Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.AttachDebugger.Break();
            }
            ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Events.CmdletBeginProcessing).Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
        }

        /// <summary>Creates a duplicate instance of this cmdlet (via JSON serialization).</summary>
        /// <returns>a duplicate instance of UpdateAzDashboardGrafana_UpdateExpanded</returns>
        public Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Cmdlets.UpdateAzDashboardGrafana_UpdateExpanded Clone()
        {
            var clone = new UpdateAzDashboardGrafana_UpdateExpanded();
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
            clone._requestBodyParametersBody = this._requestBodyParametersBody;
            clone.SubscriptionId = this.SubscriptionId;
            clone.ResourceGroupName = this.ResourceGroupName;
            clone.WorkspaceName = this.WorkspaceName;
            return clone;
        }

        /// <summary>Performs clean-up after the command execution</summary>
        protected override void EndProcessing()
        {
            var telemetryInfo = Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Module.Instance.GetTelemetryInfo?.Invoke(__correlationId);
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
         async global::System.Threading.Tasks.Task Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.IEventListener.Signal(string id, global::System.Threading.CancellationToken token, global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.EventData> messageData)
        {
            using( NoSynchronizationContext )
            {
                if (token.IsCancellationRequested)
                {
                    return ;
                }

                switch ( id )
                {
                    case Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Events.Verbose:
                    {
                        WriteVerbose($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Events.Warning:
                    {
                        WriteWarning($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Events.Information:
                    {
                        // When an operation supports asjob, Information messages must go thru verbose.
                        WriteVerbose($"INFORMATION: {(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Events.Debug:
                    {
                        WriteDebug($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Events.Error:
                    {
                        WriteError(new global::System.Management.Automation.ErrorRecord( new global::System.Exception(messageData().Message), string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null ) );
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Events.Progress:
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
                    case Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Events.DelayBeforePolling:
                    {
                        var data = messageData();
                        if (true == MyInvocation?.BoundParameters?.ContainsKey("NoWait"))
                        {
                            if (data.ResponseMessage is System.Net.Http.HttpResponseMessage response)
                            {
                                var asyncOperation = response.GetFirstHeader(@"Azure-AsyncOperation");
                                var location = response.GetFirstHeader(@"Location");
                                var uri = global::System.String.IsNullOrEmpty(asyncOperation) ? global::System.String.IsNullOrEmpty(location) ? response.RequestMessage.RequestUri.AbsoluteUri : location : asyncOperation;
                                WriteObject(new Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.PowerShell.AsyncOperationResponse { Target = uri });
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
                await Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Module.Instance.Signal(id, token, messageData, (i, t, m) => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.IEventListener)this).Signal(i, t, () => Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.EventDataConverter.ConvertFrom(m()) as Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.EventData), InvocationInformation, this.ParameterSetName, __correlationId, __processRecordId, null );
                if (token.IsCancellationRequested)
                {
                    return ;
                }
                WriteDebug($"{id}: {(messageData().Message ?? global::System.String.Empty)}");
            }
        }

        private void PreProcessManagedIdentityParametersWithGetResult()
        {
            bool supportsSystemAssignedIdentity = (true == this.EnableSystemAssignedIdentity || null == this.EnableSystemAssignedIdentity && true == _requestBodyParametersBody?.IdentityType?.Contains("SystemAssigned"));
            bool supportsUserAssignedIdentity = false;
            if (this.UserAssignedIdentity?.Length > 0)
            {
                // calculate UserAssignedIdentity
                _requestBodyParametersBody.IdentityUserAssignedIdentity.Clear();
                foreach( var id in this.UserAssignedIdentity )
                {
                    _requestBodyParametersBody.IdentityUserAssignedIdentity.Add(id, new Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.UserAssignedIdentity());
                }
            }
            supportsUserAssignedIdentity = true == this.MyInvocation?.BoundParameters?.ContainsKey("UserAssignedIdentity") && this.UserAssignedIdentity?.Length > 0 ||
                    true != this.MyInvocation?.BoundParameters?.ContainsKey("UserAssignedIdentity") && true == _requestBodyParametersBody.IdentityType?.Contains("UserAssigned");
            if (!supportsUserAssignedIdentity)
            {
                _requestBodyParametersBody.IdentityUserAssignedIdentity = null;
            }
            // calculate IdentityType
            if ((supportsUserAssignedIdentity && supportsSystemAssignedIdentity))
            {
                _requestBodyParametersBody.IdentityType = "SystemAssigned,UserAssigned";
            }
            else if ((supportsUserAssignedIdentity && !supportsSystemAssignedIdentity))
            {
                _requestBodyParametersBody.IdentityType = "UserAssigned";
            }
            else if ((!supportsUserAssignedIdentity && supportsSystemAssignedIdentity))
            {
                _requestBodyParametersBody.IdentityType = "SystemAssigned";
            }
            else
            {
                _requestBodyParametersBody.IdentityType = "None";
            }
        }

        /// <summary>Performs execution of the command.</summary>
        protected override void ProcessRecord()
        {
            ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Events.CmdletProcessRecordStart).Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
            __processRecordId = System.Guid.NewGuid().ToString();
            try
            {
                // work
                if (ShouldProcess($"Call remote 'GrafanaCreate' operation"))
                {
                    if (true == MyInvocation?.BoundParameters?.ContainsKey("AsJob"))
                    {
                        var instance = this.Clone();
                        var job = new Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.PowerShell.AsyncJob(instance, this.MyInvocation.Line, this.MyInvocation.MyCommand.Name, this._cancellationTokenSource.Token, this._cancellationTokenSource.Cancel);
                        JobRepository.Add(job);
                        var task = instance.ProcessRecordAsync();
                        job.Monitor(task);
                        WriteObject(job);
                    }
                    else
                    {
                        using( var asyncCommandRuntime = new Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.PowerShell.AsyncCommandRuntime(this, ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.IEventListener)this).Token) )
                        {
                            asyncCommandRuntime.Wait( ProcessRecordAsync(),((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.IEventListener)this).Token);
                        }
                    }
                }
            }
            catch (global::System.AggregateException aggregateException)
            {
                // unroll the inner exceptions to get the root cause
                foreach( var innerException in aggregateException.Flatten().InnerExceptions )
                {
                    ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Events.CmdletException, $"{innerException.GetType().Name} - {innerException.Message} : {innerException.StackTrace}").Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    // Write exception out to error channel.
                    WriteError( new global::System.Management.Automation.ErrorRecord(innerException,string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null) );
                }
            }
            catch (global::System.Exception exception) when ((exception as System.Management.Automation.PipelineStoppedException)== null || (exception as System.Management.Automation.PipelineStoppedException).InnerException != null)
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Events.CmdletException, $"{exception.GetType().Name} - {exception.Message} : {exception.StackTrace}").Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                // Write exception out to error channel.
                WriteError( new global::System.Management.Automation.ErrorRecord(exception,string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null) );
            }
            finally
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Events.CmdletProcessRecordEnd).Wait();
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
                await ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Events.CmdletGetPipeline); if( ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                Pipeline = Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Module.Instance.CreatePipeline(InvocationInformation, __correlationId, __processRecordId, this.ParameterSetName, this.ExtensibleParameters);
                if (null != HttpPipelinePrepend)
                {
                    Pipeline.Prepend((this.CommandRuntime as Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelinePrepend) ?? HttpPipelinePrepend);
                }
                if (null != HttpPipelineAppend)
                {
                    Pipeline.Append((this.CommandRuntime as Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelineAppend) ?? HttpPipelineAppend);
                }
                // get the client instance
                try
                {
                    await ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Events.CmdletBeforeAPICall); if( ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    _requestBodyParametersBody = await this.Client.GrafanaGetWithResult(SubscriptionId, ResourceGroupName, WorkspaceName, this, Pipeline);
                    this.PreProcessManagedIdentityParametersWithGetResult();
                    this.Update_requestBodyParametersBody();
                    await this.Client.GrafanaCreate(SubscriptionId, ResourceGroupName, WorkspaceName, _requestBodyParametersBody, onOk, onDefault, this, Pipeline, Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.SerializationMode.IncludeUpdate);
                    await ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Events.CmdletAfterAPICall); if( ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                }
                catch (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.UndeclaredResponseException urexception)
                {
                    WriteError(new global::System.Management.Automation.ErrorRecord(urexception, urexception.StatusCode.ToString(), global::System.Management.Automation.ErrorCategory.InvalidOperation, new { SubscriptionId=SubscriptionId,ResourceGroupName=ResourceGroupName,WorkspaceName=WorkspaceName})
                    {
                      ErrorDetails = new global::System.Management.Automation.ErrorDetails(urexception.Message) { RecommendedAction = urexception.Action }
                    });
                }
                finally
                {
                    await ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Events.CmdletProcessRecordAsyncEnd);
                }
            }
        }

        /// <summary>Interrupts currently running code within the command.</summary>
        protected override void StopProcessing()
        {
            ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.IEventListener)this).Cancel();
            base.StopProcessing();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAzDashboardGrafana_UpdateExpanded" /> cmdlet class.
        /// </summary>
        public UpdateAzDashboardGrafana_UpdateExpanded()
        {

        }

        private void Update_requestBodyParametersBody()
        {
            if ((bool)(true == this.MyInvocation?.BoundParameters.ContainsKey("Tag")))
            {
                this.Tag = (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaTags)(this.MyInvocation?.BoundParameters["Tag"]);
            }
            if ((bool)(true == this.MyInvocation?.BoundParameters.ContainsKey("ZoneRedundancy")))
            {
                this.ZoneRedundancy = (string)(this.MyInvocation?.BoundParameters["ZoneRedundancy"]);
            }
            if ((bool)(true == this.MyInvocation?.BoundParameters.ContainsKey("ApiKey")))
            {
                this.ApiKey = (string)(this.MyInvocation?.BoundParameters["ApiKey"]);
            }
            if ((bool)(true == this.MyInvocation?.BoundParameters.ContainsKey("PublicNetworkAccess")))
            {
                this.PublicNetworkAccess = (string)(this.MyInvocation?.BoundParameters["PublicNetworkAccess"]);
            }
            if ((bool)(true == this.MyInvocation?.BoundParameters.ContainsKey("DeterministicOutboundIP")))
            {
                this.DeterministicOutboundIP = (string)(this.MyInvocation?.BoundParameters["DeterministicOutboundIP"]);
            }
            if ((bool)(true == this.MyInvocation?.BoundParameters.ContainsKey("GrafanaPlugin")))
            {
                this.GrafanaPlugin = (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesGrafanaPlugins)(this.MyInvocation?.BoundParameters["GrafanaPlugin"]);
            }
            if ((bool)(true == this.MyInvocation?.BoundParameters.ContainsKey("GrafanaMajorVersion")))
            {
                this.GrafanaMajorVersion = (string)(this.MyInvocation?.BoundParameters["GrafanaMajorVersion"]);
            }
            if ((bool)(true == this.MyInvocation?.BoundParameters.ContainsKey("SkuName")))
            {
                this.SkuName = (string)(this.MyInvocation?.BoundParameters["SkuName"]);
            }
            if ((bool)(true == this.MyInvocation?.BoundParameters.ContainsKey("GrafanaIntegrationAzureMonitorWorkspaceIntegration")))
            {
                this.GrafanaIntegrationAzureMonitorWorkspaceIntegration = (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IAzureMonitorWorkspaceIntegration[])(this.MyInvocation?.BoundParameters["GrafanaIntegrationAzureMonitorWorkspaceIntegration"]);
            }
            if ((bool)(true == this.MyInvocation?.BoundParameters.ContainsKey("EnterpriseConfigurationMarketplacePlanId")))
            {
                this.EnterpriseConfigurationMarketplacePlanId = (string)(this.MyInvocation?.BoundParameters["EnterpriseConfigurationMarketplacePlanId"]);
            }
            if ((bool)(true == this.MyInvocation?.BoundParameters.ContainsKey("EnterpriseConfigurationMarketplaceAutoRenew")))
            {
                this.EnterpriseConfigurationMarketplaceAutoRenew = (string)(this.MyInvocation?.BoundParameters["EnterpriseConfigurationMarketplaceAutoRenew"]);
            }
            if ((bool)(true == this.MyInvocation?.BoundParameters.ContainsKey("SmtpEnabled")))
            {
                this.SmtpEnabled = (global::System.Management.Automation.SwitchParameter)(this.MyInvocation?.BoundParameters["SmtpEnabled"]);
            }
            if ((bool)(true == this.MyInvocation?.BoundParameters.ContainsKey("SmtpHost")))
            {
                this.SmtpHost = (string)(this.MyInvocation?.BoundParameters["SmtpHost"]);
            }
            if ((bool)(true == this.MyInvocation?.BoundParameters.ContainsKey("SmtpUser")))
            {
                this.SmtpUser = (string)(this.MyInvocation?.BoundParameters["SmtpUser"]);
            }
            if ((bool)(true == this.MyInvocation?.BoundParameters.ContainsKey("SmtpPassword")))
            {
                this.SmtpPassword = (System.Security.SecureString)(this.MyInvocation?.BoundParameters["SmtpPassword"]);
            }
            if ((bool)(true == this.MyInvocation?.BoundParameters.ContainsKey("SmtpFromAddress")))
            {
                this.SmtpFromAddress = (string)(this.MyInvocation?.BoundParameters["SmtpFromAddress"]);
            }
            if ((bool)(true == this.MyInvocation?.BoundParameters.ContainsKey("SmtpFromName")))
            {
                this.SmtpFromName = (string)(this.MyInvocation?.BoundParameters["SmtpFromName"]);
            }
            if ((bool)(true == this.MyInvocation?.BoundParameters.ContainsKey("SmtpStartTlsPolicy")))
            {
                this.SmtpStartTlsPolicy = (string)(this.MyInvocation?.BoundParameters["SmtpStartTlsPolicy"]);
            }
            if ((bool)(true == this.MyInvocation?.BoundParameters.ContainsKey("SmtpSkipVerify")))
            {
                this.SmtpSkipVerify = (global::System.Management.Automation.SwitchParameter)(this.MyInvocation?.BoundParameters["SmtpSkipVerify"]);
            }
            if ((bool)(true == this.MyInvocation?.BoundParameters.ContainsKey("SnapshotExternalEnabled")))
            {
                this.SnapshotExternalEnabled = (global::System.Management.Automation.SwitchParameter)(this.MyInvocation?.BoundParameters["SnapshotExternalEnabled"]);
            }
            if ((bool)(true == this.MyInvocation?.BoundParameters.ContainsKey("UserViewersCanEdit")))
            {
                this.UserViewersCanEdit = (global::System.Management.Automation.SwitchParameter)(this.MyInvocation?.BoundParameters["UserViewersCanEdit"]);
            }
            if ((bool)(true == this.MyInvocation?.BoundParameters.ContainsKey("UserEditorsCanAdmin")))
            {
                this.UserEditorsCanAdmin = (global::System.Management.Automation.SwitchParameter)(this.MyInvocation?.BoundParameters["UserEditorsCanAdmin"]);
            }
            if ((bool)(true == this.MyInvocation?.BoundParameters.ContainsKey("SecurityCsrfAlwaysCheck")))
            {
                this.SecurityCsrfAlwaysCheck = (global::System.Management.Automation.SwitchParameter)(this.MyInvocation?.BoundParameters["SecurityCsrfAlwaysCheck"]);
            }
            if ((bool)(true == this.MyInvocation?.BoundParameters.ContainsKey("UnifiedAlertingScreenshotCaptureEnabled")))
            {
                this.UnifiedAlertingScreenshotCaptureEnabled = (global::System.Management.Automation.SwitchParameter)(this.MyInvocation?.BoundParameters["UnifiedAlertingScreenshotCaptureEnabled"]);
            }
        }

        /// <param name="sendToPipeline"></param>
        new protected void WriteObject(object sendToPipeline)
        {
            Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Module.Instance.SanitizeOutput?.Invoke(sendToPipeline, __correlationId);
            base.WriteObject(sendToPipeline);
        }

        /// <param name="sendToPipeline"></param>
        /// <param name="enumerateCollection"></param>
        new protected void WriteObject(object sendToPipeline, bool enumerateCollection)
        {
            Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Module.Instance.SanitizeOutput?.Invoke(sendToPipeline, __correlationId);
            base.WriteObject(sendToPipeline, enumerateCollection);
        }

        /// <summary>
        /// a delegate that is called when the remote service returns default (any response code not handled elsewhere).
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IErrorResponse">Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IErrorResponse</see>
        /// from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onDefault(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IErrorResponse> response)
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
                    var ex = new Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IErrorResponse>(responseMessage, await response);
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
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafana">Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafana</see>
        /// from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafana> response)
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
                // (await response) // should be Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafana
                var result = (await response);
                WriteObject(result, false);
            }
        }
    }
}