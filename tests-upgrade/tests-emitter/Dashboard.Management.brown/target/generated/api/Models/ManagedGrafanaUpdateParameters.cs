// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Extensions;

    /// <summary>The parameters for a PATCH request to a grafana resource.</summary>
    public partial class ManagedGrafanaUpdateParameters :
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaUpdateParameters,
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaUpdateParametersInternal
    {

        /// <summary>The api key setting of the Grafana instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inlined)]
        public string ApiKey { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)Property).ApiKey; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)Property).ApiKey = value ?? null; }

        /// <summary>Whether a Grafana instance uses deterministic outbound IPs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inlined)]
        public string DeterministicOutboundIP { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)Property).DeterministicOutboundIP; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)Property).DeterministicOutboundIP = value ?? null; }

        /// <summary>The AutoRenew setting of the Enterprise subscription</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inlined)]
        public string EnterpriseConfigurationMarketplaceAutoRenew { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)Property).EnterpriseConfigurationMarketplaceAutoRenew; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)Property).EnterpriseConfigurationMarketplaceAutoRenew = value ?? null; }

        /// <summary>The Plan Id of the Azure Marketplace subscription for the Enterprise plugins</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inlined)]
        public string EnterpriseConfigurationMarketplacePlanId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)Property).EnterpriseConfigurationMarketplacePlanId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)Property).EnterpriseConfigurationMarketplacePlanId = value ?? null; }

        /// <summary>Array of AzureMonitorWorkspaceIntegration</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IAzureMonitorWorkspaceIntegration> GrafanaIntegrationAzureMonitorWorkspaceIntegration { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)Property).GrafanaIntegrationAzureMonitorWorkspaceIntegration; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)Property).GrafanaIntegrationAzureMonitorWorkspaceIntegration = value ?? null /* arrayOf */; }

        /// <summary>The major Grafana software version to target.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inlined)]
        public string GrafanaMajorVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)Property).GrafanaMajorVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)Property).GrafanaMajorVersion = value ?? null; }

        /// <summary>
        /// Update of Grafana plugin. Key is plugin id, value is plugin definition. If plugin definition is null, plugin with given
        /// plugin id will be removed. Otherwise, given plugin will be installed.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersGrafanaPlugins GrafanaPlugin { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)Property).GrafanaPlugin; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)Property).GrafanaPlugin = value ?? null /* model class */; }

        /// <summary>Backing field for <see cref="Identity" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedServiceIdentity _identity;

        /// <summary>The managed identity of the grafana resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedServiceIdentity Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ManagedServiceIdentity()); set => this._identity = value; }

        /// <summary>
        /// The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inlined)]
        public string IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedServiceIdentityInternal)Identity).PrincipalId; }

        /// <summary>
        /// The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inlined)]
        public string IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedServiceIdentityInternal)Identity).TenantId; }

        /// <summary>The type of managed identity assigned to this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inlined)]
        public string IdentityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedServiceIdentityInternal)Identity).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedServiceIdentityInternal)Identity).Type = value ?? null; }

        /// <summary>The identities assigned to this resource by the user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedServiceIdentityUserAssignedIdentities IdentityUserAssignedIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedServiceIdentityInternal)Identity).UserAssignedIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedServiceIdentityInternal)Identity).UserAssignedIdentity = value ?? null /* model class */; }

        /// <summary>Internal Acessors for EnterpriseConfiguration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IEnterpriseConfigurations Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaUpdateParametersInternal.EnterpriseConfiguration { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)Property).EnterpriseConfiguration; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)Property).EnterpriseConfiguration = value ?? null /* model class */; }

        /// <summary>Internal Acessors for GrafanaConfiguration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurations Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaUpdateParametersInternal.GrafanaConfiguration { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)Property).GrafanaConfiguration; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)Property).GrafanaConfiguration = value ?? null /* model class */; }

        /// <summary>Internal Acessors for GrafanaConfigurationSecurity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISecurity Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaUpdateParametersInternal.GrafanaConfigurationSecurity { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)Property).GrafanaConfigurationSecurity; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)Property).GrafanaConfigurationSecurity = value ?? null /* model class */; }

        /// <summary>Internal Acessors for GrafanaConfigurationSmtp</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISmtp Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaUpdateParametersInternal.GrafanaConfigurationSmtp { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)Property).GrafanaConfigurationSmtp; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)Property).GrafanaConfigurationSmtp = value ?? null /* model class */; }

        /// <summary>Internal Acessors for GrafanaConfigurationSnapshot</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISnapshots Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaUpdateParametersInternal.GrafanaConfigurationSnapshot { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)Property).GrafanaConfigurationSnapshot; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)Property).GrafanaConfigurationSnapshot = value ?? null /* model class */; }

        /// <summary>Internal Acessors for GrafanaConfigurationUnifiedAlertingScreenshot</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IUnifiedAlertingScreenshots Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaUpdateParametersInternal.GrafanaConfigurationUnifiedAlertingScreenshot { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)Property).GrafanaConfigurationUnifiedAlertingScreenshot; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)Property).GrafanaConfigurationUnifiedAlertingScreenshot = value ?? null /* model class */; }

        /// <summary>Internal Acessors for GrafanaConfigurationUser</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IUsers Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaUpdateParametersInternal.GrafanaConfigurationUser { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)Property).GrafanaConfigurationUser; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)Property).GrafanaConfigurationUser = value ?? null /* model class */; }

        /// <summary>Internal Acessors for GrafanaIntegration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaIntegrations Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaUpdateParametersInternal.GrafanaIntegration { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)Property).GrafanaIntegration; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)Property).GrafanaIntegration = value ?? null /* model class */; }

        /// <summary>Internal Acessors for Identity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedServiceIdentity Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaUpdateParametersInternal.Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ManagedServiceIdentity()); set { {_identity = value;} } }

        /// <summary>Internal Acessors for IdentityPrincipalId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaUpdateParametersInternal.IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedServiceIdentityInternal)Identity).PrincipalId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedServiceIdentityInternal)Identity).PrincipalId = value ?? null; }

        /// <summary>Internal Acessors for IdentityTenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaUpdateParametersInternal.IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedServiceIdentityInternal)Identity).TenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedServiceIdentityInternal)Identity).TenantId = value ?? null; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParameters Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaUpdateParametersInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ManagedGrafanaPropertiesUpdateParameters()); set { {_property = value;} } }

        /// <summary>Internal Acessors for Sku</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceSku Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaUpdateParametersInternal.Sku { get => (this._sku = this._sku ?? new Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ResourceSku()); set { {_sku = value;} } }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParameters _property;

        /// <summary>Properties specific to the managed grafana resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParameters Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ManagedGrafanaPropertiesUpdateParameters()); set => this._property = value; }

        /// <summary>Indicate the state for enable or disable traffic over the public interface.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inlined)]
        public string PublicNetworkAccess { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)Property).PublicNetworkAccess; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)Property).PublicNetworkAccess = value ?? null; }

        /// <summary>
        /// Set to true to execute the CSRF check even if the login cookie is not in a request (default false).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inlined)]
        public bool? SecurityCsrfAlwaysCheck { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)Property).SecurityCsrfAlwaysCheck; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)Property).SecurityCsrfAlwaysCheck = value ?? default(bool); }

        /// <summary>Backing field for <see cref="Sku" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceSku _sku;

        /// <summary>Represents the SKU of a resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceSku Sku { get => (this._sku = this._sku ?? new Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ResourceSku()); set => this._sku = value; }

        /// <summary>The name of the SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inlined)]
        public string SkuName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceSkuInternal)Sku).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceSkuInternal)Sku).Name = value ?? null; }

        /// <summary>Enable this to allow Grafana to send email. Default is false</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inlined)]
        public bool? SmtpEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)Property).SmtpEnabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)Property).SmtpEnabled = value ?? default(bool); }

        /// <summary>
        /// Address used when sending out emails
        /// https://pkg.go.dev/net/mail#Address
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inlined)]
        public string SmtpFromAddress { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)Property).SmtpFromAddress; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)Property).SmtpFromAddress = value ?? null; }

        /// <summary>
        /// Name to be used when sending out emails. Default is "Azure Managed Grafana Notification"
        /// https://pkg.go.dev/net/mail#Address
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inlined)]
        public string SmtpFromName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)Property).SmtpFromName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)Property).SmtpFromName = value ?? null; }

        /// <summary>SMTP server hostname with port, e.g. test.email.net:587</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inlined)]
        public string SmtpHost { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)Property).SmtpHost; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)Property).SmtpHost = value ?? null; }

        /// <summary>
        /// Password of SMTP auth. If the password contains # or ;, then you have to wrap it with triple quotes
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inlined)]
        public System.Security.SecureString SmtpPassword { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)Property).SmtpPassword; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)Property).SmtpPassword = value ?? null; }

        /// <summary>
        /// Verify SSL for SMTP server. Default is false
        /// https://pkg.go.dev/crypto/tls#Config
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inlined)]
        public bool? SmtpSkipVerify { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)Property).SmtpSkipVerify; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)Property).SmtpSkipVerify = value ?? default(bool); }

        /// <summary>
        /// The StartTLSPolicy setting of the SMTP configuration
        /// https://pkg.go.dev/github.com/go-mail/mail#StartTLSPolicy
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inlined)]
        public string SmtpStartTlsPolicy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)Property).SmtpStartTlsPolicy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)Property).SmtpStartTlsPolicy = value ?? null; }

        /// <summary>User of SMTP auth</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inlined)]
        public string SmtpUser { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)Property).SmtpUser; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)Property).SmtpUser = value ?? null; }

        /// <summary>Set to false to disable external snapshot publish endpoint</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inlined)]
        public bool? SnapshotExternalEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)Property).SnapshotExternalEnabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)Property).SnapshotExternalEnabled = value ?? default(bool); }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaUpdateParametersTags _tag;

        /// <summary>The new tags of the grafana resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaUpdateParametersTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ManagedGrafanaUpdateParametersTags()); set => this._tag = value; }

        /// <summary>
        /// Set to false to disable capture screenshot in Unified Alert due to performance issue.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inlined)]
        public bool? UnifiedAlertingScreenshotCaptureEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)Property).UnifiedAlertingScreenshotCaptureEnabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)Property).UnifiedAlertingScreenshotCaptureEnabled = value ?? default(bool); }

        /// <summary>
        /// Set to true so editors can administrate dashboards, folders and teams they create.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inlined)]
        public bool? UserEditorsCanAdmin { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)Property).UserEditorsCanAdmin; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)Property).UserEditorsCanAdmin = value ?? default(bool); }

        /// <summary>
        /// Set to true so viewers can access and use explore and perform temporary edits on panels in dashboards they have access
        /// to. They cannot save their changes.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inlined)]
        public bool? UserViewersCanEdit { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)Property).UserViewersCanEdit; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)Property).UserViewersCanEdit = value ?? default(bool); }

        /// <summary>The zone redundancy setting of the Grafana instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inlined)]
        public string ZoneRedundancy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)Property).ZoneRedundancy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)Property).ZoneRedundancy = value ?? null; }

        /// <summary>Creates an new <see cref="ManagedGrafanaUpdateParameters" /> instance.</summary>
        public ManagedGrafanaUpdateParameters()
        {

        }
    }
    /// The parameters for a PATCH request to a grafana resource.
    public partial interface IManagedGrafanaUpdateParameters :
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.IJsonSerializable
    {
        /// <summary>The api key setting of the Grafana instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The api key setting of the Grafana instance.",
        SerializedName = @"apiKey",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PSArgumentCompleterAttribute("Disabled", "Enabled")]
        string ApiKey { get; set; }
        /// <summary>Whether a Grafana instance uses deterministic outbound IPs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Whether a Grafana instance uses deterministic outbound IPs.",
        SerializedName = @"deterministicOutboundIP",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PSArgumentCompleterAttribute("Disabled", "Enabled")]
        string DeterministicOutboundIP { get; set; }
        /// <summary>The AutoRenew setting of the Enterprise subscription</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The AutoRenew setting of the Enterprise subscription",
        SerializedName = @"marketplaceAutoRenew",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PSArgumentCompleterAttribute("Disabled", "Enabled")]
        string EnterpriseConfigurationMarketplaceAutoRenew { get; set; }
        /// <summary>The Plan Id of the Azure Marketplace subscription for the Enterprise plugins</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The Plan Id of the Azure Marketplace subscription for the Enterprise plugins",
        SerializedName = @"marketplacePlanId",
        PossibleTypes = new [] { typeof(string) })]
        string EnterpriseConfigurationMarketplacePlanId { get; set; }
        /// <summary>Array of AzureMonitorWorkspaceIntegration</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Array of AzureMonitorWorkspaceIntegration",
        SerializedName = @"azureMonitorWorkspaceIntegrations",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IAzureMonitorWorkspaceIntegration) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IAzureMonitorWorkspaceIntegration> GrafanaIntegrationAzureMonitorWorkspaceIntegration { get; set; }
        /// <summary>The major Grafana software version to target.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The major Grafana software version to target.",
        SerializedName = @"grafanaMajorVersion",
        PossibleTypes = new [] { typeof(string) })]
        string GrafanaMajorVersion { get; set; }
        /// <summary>
        /// Update of Grafana plugin. Key is plugin id, value is plugin definition. If plugin definition is null, plugin with given
        /// plugin id will be removed. Otherwise, given plugin will be installed.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Update of Grafana plugin. Key is plugin id, value is plugin definition. If plugin definition is null, plugin with given plugin id will be removed. Otherwise, given plugin will be installed.",
        SerializedName = @"grafanaPlugins",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersGrafanaPlugins) })]
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersGrafanaPlugins GrafanaPlugin { get; set; }
        /// <summary>
        /// The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.",
        SerializedName = @"principalId",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityPrincipalId { get;  }
        /// <summary>
        /// The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity.",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityTenantId { get;  }
        /// <summary>The type of managed identity assigned to this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The type of managed identity assigned to this resource.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PSArgumentCompleterAttribute("None", "SystemAssigned", "UserAssigned", "SystemAssigned,UserAssigned")]
        string IdentityType { get; set; }
        /// <summary>The identities assigned to this resource by the user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The identities assigned to this resource by the user.",
        SerializedName = @"userAssignedIdentities",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedServiceIdentityUserAssignedIdentities) })]
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedServiceIdentityUserAssignedIdentities IdentityUserAssignedIdentity { get; set; }
        /// <summary>Indicate the state for enable or disable traffic over the public interface.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Indicate the state for enable or disable traffic over the public interface.",
        SerializedName = @"publicNetworkAccess",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string PublicNetworkAccess { get; set; }
        /// <summary>
        /// Set to true to execute the CSRF check even if the login cookie is not in a request (default false).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Set to true to execute the CSRF check even if the login cookie is not in a request (default false).",
        SerializedName = @"csrfAlwaysCheck",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SecurityCsrfAlwaysCheck { get; set; }
        /// <summary>The name of the SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the SKU.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string SkuName { get; set; }
        /// <summary>Enable this to allow Grafana to send email. Default is false</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Enable this to allow Grafana to send email. Default is false",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SmtpEnabled { get; set; }
        /// <summary>
        /// Address used when sending out emails
        /// https://pkg.go.dev/net/mail#Address
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Address used when sending out emails
        https://pkg.go.dev/net/mail#Address",
        SerializedName = @"fromAddress",
        PossibleTypes = new [] { typeof(string) })]
        string SmtpFromAddress { get; set; }
        /// <summary>
        /// Name to be used when sending out emails. Default is "Azure Managed Grafana Notification"
        /// https://pkg.go.dev/net/mail#Address
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Name to be used when sending out emails. Default is ""Azure Managed Grafana Notification""
        https://pkg.go.dev/net/mail#Address",
        SerializedName = @"fromName",
        PossibleTypes = new [] { typeof(string) })]
        string SmtpFromName { get; set; }
        /// <summary>SMTP server hostname with port, e.g. test.email.net:587</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"SMTP server hostname with port, e.g. test.email.net:587",
        SerializedName = @"host",
        PossibleTypes = new [] { typeof(string) })]
        string SmtpHost { get; set; }
        /// <summary>
        /// Password of SMTP auth. If the password contains # or ;, then you have to wrap it with triple quotes
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Password of SMTP auth. If the password contains # or ;, then you have to wrap it with triple quotes",
        SerializedName = @"password",
        PossibleTypes = new [] { typeof(System.Security.SecureString) })]
        System.Security.SecureString SmtpPassword { get; set; }
        /// <summary>
        /// Verify SSL for SMTP server. Default is false
        /// https://pkg.go.dev/crypto/tls#Config
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Verify SSL for SMTP server. Default is false
        https://pkg.go.dev/crypto/tls#Config",
        SerializedName = @"skipVerify",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SmtpSkipVerify { get; set; }
        /// <summary>
        /// The StartTLSPolicy setting of the SMTP configuration
        /// https://pkg.go.dev/github.com/go-mail/mail#StartTLSPolicy
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The StartTLSPolicy setting of the SMTP configuration
        https://pkg.go.dev/github.com/go-mail/mail#StartTLSPolicy",
        SerializedName = @"startTLSPolicy",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PSArgumentCompleterAttribute("OpportunisticStartTLS", "MandatoryStartTLS", "NoStartTLS")]
        string SmtpStartTlsPolicy { get; set; }
        /// <summary>User of SMTP auth</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"User of SMTP auth",
        SerializedName = @"user",
        PossibleTypes = new [] { typeof(string) })]
        string SmtpUser { get; set; }
        /// <summary>Set to false to disable external snapshot publish endpoint</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Set to false to disable external snapshot publish endpoint",
        SerializedName = @"externalEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SnapshotExternalEnabled { get; set; }
        /// <summary>The new tags of the grafana resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The new tags of the grafana resource.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaUpdateParametersTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaUpdateParametersTags Tag { get; set; }
        /// <summary>
        /// Set to false to disable capture screenshot in Unified Alert due to performance issue.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Set to false to disable capture screenshot in Unified Alert due to performance issue.",
        SerializedName = @"captureEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? UnifiedAlertingScreenshotCaptureEnabled { get; set; }
        /// <summary>
        /// Set to true so editors can administrate dashboards, folders and teams they create.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Set to true so editors can administrate dashboards, folders and teams they create.",
        SerializedName = @"editorsCanAdmin",
        PossibleTypes = new [] { typeof(bool) })]
        bool? UserEditorsCanAdmin { get; set; }
        /// <summary>
        /// Set to true so viewers can access and use explore and perform temporary edits on panels in dashboards they have access
        /// to. They cannot save their changes.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Set to true so viewers can access and use explore and perform temporary edits on panels in dashboards they have access to. They cannot save their changes.",
        SerializedName = @"viewersCanEdit",
        PossibleTypes = new [] { typeof(bool) })]
        bool? UserViewersCanEdit { get; set; }
        /// <summary>The zone redundancy setting of the Grafana instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The zone redundancy setting of the Grafana instance.",
        SerializedName = @"zoneRedundancy",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PSArgumentCompleterAttribute("Disabled", "Enabled")]
        string ZoneRedundancy { get; set; }

    }
    /// The parameters for a PATCH request to a grafana resource.
    internal partial interface IManagedGrafanaUpdateParametersInternal

    {
        /// <summary>The api key setting of the Grafana instance.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PSArgumentCompleterAttribute("Disabled", "Enabled")]
        string ApiKey { get; set; }
        /// <summary>Whether a Grafana instance uses deterministic outbound IPs.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PSArgumentCompleterAttribute("Disabled", "Enabled")]
        string DeterministicOutboundIP { get; set; }
        /// <summary>Enterprise settings of a Grafana instance</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IEnterpriseConfigurations EnterpriseConfiguration { get; set; }
        /// <summary>The AutoRenew setting of the Enterprise subscription</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PSArgumentCompleterAttribute("Disabled", "Enabled")]
        string EnterpriseConfigurationMarketplaceAutoRenew { get; set; }
        /// <summary>The Plan Id of the Azure Marketplace subscription for the Enterprise plugins</summary>
        string EnterpriseConfigurationMarketplacePlanId { get; set; }
        /// <summary>Server configurations of a Grafana instance</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurations GrafanaConfiguration { get; set; }
        /// <summary>Grafana security settings</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISecurity GrafanaConfigurationSecurity { get; set; }
        /// <summary>
        /// Email server settings.
        /// https://grafana.com/docs/grafana/v9.0/setup-grafana/configure-grafana/#smtp
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISmtp GrafanaConfigurationSmtp { get; set; }
        /// <summary>Grafana Snapshots settings</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISnapshots GrafanaConfigurationSnapshot { get; set; }
        /// <summary>Grafana Unified Alerting Screenshots settings</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IUnifiedAlertingScreenshots GrafanaConfigurationUnifiedAlertingScreenshot { get; set; }
        /// <summary>Grafana users settings</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IUsers GrafanaConfigurationUser { get; set; }
        /// <summary>
        /// GrafanaIntegrations is a bundled observability experience (e.g. pre-configured data source, tailored Grafana dashboards,
        /// alerting defaults) for common monitoring scenarios.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaIntegrations GrafanaIntegration { get; set; }
        /// <summary>Array of AzureMonitorWorkspaceIntegration</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IAzureMonitorWorkspaceIntegration> GrafanaIntegrationAzureMonitorWorkspaceIntegration { get; set; }
        /// <summary>The major Grafana software version to target.</summary>
        string GrafanaMajorVersion { get; set; }
        /// <summary>
        /// Update of Grafana plugin. Key is plugin id, value is plugin definition. If plugin definition is null, plugin with given
        /// plugin id will be removed. Otherwise, given plugin will be installed.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersGrafanaPlugins GrafanaPlugin { get; set; }
        /// <summary>The managed identity of the grafana resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedServiceIdentity Identity { get; set; }
        /// <summary>
        /// The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        string IdentityPrincipalId { get; set; }
        /// <summary>
        /// The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        string IdentityTenantId { get; set; }
        /// <summary>The type of managed identity assigned to this resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PSArgumentCompleterAttribute("None", "SystemAssigned", "UserAssigned", "SystemAssigned,UserAssigned")]
        string IdentityType { get; set; }
        /// <summary>The identities assigned to this resource by the user.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedServiceIdentityUserAssignedIdentities IdentityUserAssignedIdentity { get; set; }
        /// <summary>Properties specific to the managed grafana resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParameters Property { get; set; }
        /// <summary>Indicate the state for enable or disable traffic over the public interface.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string PublicNetworkAccess { get; set; }
        /// <summary>
        /// Set to true to execute the CSRF check even if the login cookie is not in a request (default false).
        /// </summary>
        bool? SecurityCsrfAlwaysCheck { get; set; }
        /// <summary>Represents the SKU of a resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceSku Sku { get; set; }
        /// <summary>The name of the SKU.</summary>
        string SkuName { get; set; }
        /// <summary>Enable this to allow Grafana to send email. Default is false</summary>
        bool? SmtpEnabled { get; set; }
        /// <summary>
        /// Address used when sending out emails
        /// https://pkg.go.dev/net/mail#Address
        /// </summary>
        string SmtpFromAddress { get; set; }
        /// <summary>
        /// Name to be used when sending out emails. Default is "Azure Managed Grafana Notification"
        /// https://pkg.go.dev/net/mail#Address
        /// </summary>
        string SmtpFromName { get; set; }
        /// <summary>SMTP server hostname with port, e.g. test.email.net:587</summary>
        string SmtpHost { get; set; }
        /// <summary>
        /// Password of SMTP auth. If the password contains # or ;, then you have to wrap it with triple quotes
        /// </summary>
        System.Security.SecureString SmtpPassword { get; set; }
        /// <summary>
        /// Verify SSL for SMTP server. Default is false
        /// https://pkg.go.dev/crypto/tls#Config
        /// </summary>
        bool? SmtpSkipVerify { get; set; }
        /// <summary>
        /// The StartTLSPolicy setting of the SMTP configuration
        /// https://pkg.go.dev/github.com/go-mail/mail#StartTLSPolicy
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PSArgumentCompleterAttribute("OpportunisticStartTLS", "MandatoryStartTLS", "NoStartTLS")]
        string SmtpStartTlsPolicy { get; set; }
        /// <summary>User of SMTP auth</summary>
        string SmtpUser { get; set; }
        /// <summary>Set to false to disable external snapshot publish endpoint</summary>
        bool? SnapshotExternalEnabled { get; set; }
        /// <summary>The new tags of the grafana resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaUpdateParametersTags Tag { get; set; }
        /// <summary>
        /// Set to false to disable capture screenshot in Unified Alert due to performance issue.
        /// </summary>
        bool? UnifiedAlertingScreenshotCaptureEnabled { get; set; }
        /// <summary>
        /// Set to true so editors can administrate dashboards, folders and teams they create.
        /// </summary>
        bool? UserEditorsCanAdmin { get; set; }
        /// <summary>
        /// Set to true so viewers can access and use explore and perform temporary edits on panels in dashboards they have access
        /// to. They cannot save their changes.
        /// </summary>
        bool? UserViewersCanEdit { get; set; }
        /// <summary>The zone redundancy setting of the Grafana instance.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PSArgumentCompleterAttribute("Disabled", "Enabled")]
        string ZoneRedundancy { get; set; }

    }
}