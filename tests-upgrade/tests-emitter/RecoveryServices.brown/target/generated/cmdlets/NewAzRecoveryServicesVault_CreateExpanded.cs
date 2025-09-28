// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Cmdlets
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Extensions;
    using Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.PowerShell;
    using Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Cmdlets;
    using System;

    /// <summary>create a Recovery Services vault.</summary>
    /// <remarks>
    /// [OpenAPI] CreateOrUpdate=>PUT:"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}"
    /// </remarks>
    [global::System.Management.Automation.Cmdlet(global::System.Management.Automation.VerbsCommon.New, @"AzRecoveryServicesVault_CreateExpanded", SupportsShouldProcess = true)]
    [global::System.Management.Automation.OutputType(typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVault))]
    [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Description(@"create a Recovery Services vault.")]
    [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Generated]
    [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.HttpPath(Path = "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}", ApiVersion = "2025-02-01")]
    public partial class NewAzRecoveryServicesVault_CreateExpanded : global::System.Management.Automation.PSCmdlet,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IEventListener,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IContext
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

        /// <summary>Resource information, as returned by the resource provider.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVault _vaultBody = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Vault();

        /// <summary>when specified, runs this cmdlet as a PowerShell job</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Run the command as a job")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter AsJob { get; set; }

        /// <summary>.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = ".")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @".",
        SerializedName = @"alertsForAllFailoverIssues",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        public string AzureMonitorAlertSettingAlertsForAllFailoverIssue { get => _vaultBody.AzureMonitorAlertSettingAlertsForAllFailoverIssue ?? null; set => _vaultBody.AzureMonitorAlertSettingAlertsForAllFailoverIssue = value; }

        /// <summary>.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = ".")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @".",
        SerializedName = @"alertsForAllJobFailures",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        public string AzureMonitorAlertSettingAlertsForAllJobFailure { get => _vaultBody.AzureMonitorAlertSettingAlertsForAllJobFailure ?? null; set => _vaultBody.AzureMonitorAlertSettingAlertsForAllJobFailure = value; }

        /// <summary>.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = ".")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @".",
        SerializedName = @"alertsForAllReplicationIssues",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        public string AzureMonitorAlertSettingAlertsForAllReplicationIssue { get => _vaultBody.AzureMonitorAlertSettingAlertsForAllReplicationIssue ?? null; set => _vaultBody.AzureMonitorAlertSettingAlertsForAllReplicationIssue = value; }

        /// <summary>Wait for .NET debugger to attach</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Wait for .NET debugger to attach")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter Break { get; set; }

        /// <summary>Accessor for cancellationTokenSource.</summary>
        public global::System.Threading.CancellationTokenSource CancellationTokenSource { get => _cancellationTokenSource ; set { _cancellationTokenSource = value; } }

        /// <summary>.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = ".")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @".",
        SerializedName = @"alertsForCriticalOperations",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        public string ClassicAlertSettingAlertsForCriticalOperation { get => _vaultBody.ClassicAlertSettingAlertsForCriticalOperation ?? null; set => _vaultBody.ClassicAlertSettingAlertsForCriticalOperation = value; }

        /// <summary>.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = ".")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @".",
        SerializedName = @"emailNotificationsForSiteRecovery",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        public string ClassicAlertSettingEmailNotificationsForSiteRecovery { get => _vaultBody.ClassicAlertSettingEmailNotificationsForSiteRecovery ?? null; set => _vaultBody.ClassicAlertSettingEmailNotificationsForSiteRecovery = value; }

        /// <summary>The reference to the client API class.</summary>
        public Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.RecoveryServicesClient Client => Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Module.Instance.ClientAPI;

        /// <summary>.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = ".")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @".",
        SerializedName = @"crossSubscriptionRestoreState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Enabled", "Disabled", "PermanentlyDisabled")]
        public string CrossSubscriptionRestoreSettingCrossSubscriptionRestoreState { get => _vaultBody.CrossSubscriptionRestoreSettingCrossSubscriptionRestoreState ?? null; set => _vaultBody.CrossSubscriptionRestoreSettingCrossSubscriptionRestoreState = value; }

        /// <summary>
        /// The DefaultProfile parameter is not functional. Use the SubscriptionId parameter when available if executing the cmdlet
        /// against a different subscription
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The DefaultProfile parameter is not functional. Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::System.Management.Automation.Alias("AzureRMContext", "AzureCredential")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.ParameterCategory.Azure)]
        public global::System.Management.Automation.PSObject DefaultProfile { get; set; }

        /// <summary>Determines whether to enable a system-assigned identity for the resource.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Determines whether to enable a system-assigned identity for the resource.")]
        public global::System.Management.Automation.SwitchParameter EnableSystemAssignedIdentity { set => _vaultBody.IdentityType = value.IsPresent ? "SystemAssigned": null ; }

        /// <summary>Enabling/Disabling the Double Encryption state</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Enabling/Disabling the Double Encryption state")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Enabling/Disabling the Double Encryption state",
        SerializedName = @"infrastructureEncryption",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        public string EncryptionInfrastructureEncryption { get => _vaultBody.EncryptionInfrastructureEncryption ?? null; set => _vaultBody.EncryptionInfrastructureEncryption = value; }

        /// <summary>etag for the resource.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "etag for the resource.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"etag for the resource.",
        SerializedName = @"etag",
        PossibleTypes = new [] { typeof(string) })]
        public string Etag { get => _vaultBody.Etag ?? null; set => _vaultBody.Etag = value; }

        /// <summary>Accessor for extensibleParameters.</summary>
        public global::System.Collections.Generic.IDictionary<global::System.String,global::System.Object> ExtensibleParameters { get => _extensibleParameters ; }

        /// <summary>SendAsync Pipeline Steps to be appended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be appended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.ParameterCategory.Runtime)]
        public Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.SendAsyncStep[] HttpPipelineAppend { get; set; }

        /// <summary>SendAsync Pipeline Steps to be prepended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be prepended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.ParameterCategory.Runtime)]
        public Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.SendAsyncStep[] HttpPipelinePrepend { get; set; }

        /// <summary>.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = ".")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @".",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Disabled", "Unlocked", "Locked")]
        public string ImmutabilitySettingState { get => _vaultBody.ImmutabilitySettingState ?? null; set => _vaultBody.ImmutabilitySettingState = value; }

        /// <summary>Accessor for our copy of the InvocationInfo.</summary>
        public global::System.Management.Automation.InvocationInfo InvocationInformation { get => __invocationInfo = __invocationInfo ?? this.MyInvocation ; set { __invocationInfo = value; } }

        /// <summary>
        /// Indicate that system assigned identity should be used. Mutually exclusive with 'userAssignedIdentity' field
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Indicate that system assigned identity should be used. Mutually exclusive with 'userAssignedIdentity' field")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicate that system assigned identity should be used. Mutually exclusive with 'userAssignedIdentity' field",
        SerializedName = @"useSystemAssignedIdentity",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter KekIdentityUseSystemAssignedIdentity { get => _vaultBody.KekIdentityUseSystemAssignedIdentity ?? default(global::System.Management.Automation.SwitchParameter); set => _vaultBody.KekIdentityUseSystemAssignedIdentity = value; }

        /// <summary>
        /// The user assigned identity to be used to grant permissions in case the type of identity used is UserAssigned
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The user assigned identity to be used to grant permissions in case the type of identity used is UserAssigned")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The user assigned identity to be used to grant permissions in case the type of identity used is UserAssigned",
        SerializedName = @"userAssignedIdentity",
        PossibleTypes = new [] { typeof(string) })]
        public string KekIdentityUserAssignedIdentity { get => _vaultBody.KekIdentityUserAssignedIdentity ?? null; set => _vaultBody.KekIdentityUserAssignedIdentity = value; }

        /// <summary>The key uri of the Customer Managed Key</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The key uri of the Customer Managed Key")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The key uri of the Customer Managed Key",
        SerializedName = @"keyUri",
        PossibleTypes = new [] { typeof(string) })]
        public string KeyVaultPropertyKeyUri { get => _vaultBody.KeyVaultPropertyKeyUri ?? null; set => _vaultBody.KeyVaultPropertyKeyUri = value; }

        /// <summary>The geo-location where the resource lives</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The geo-location where the resource lives")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The geo-location where the resource lives",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        public string Location { get => _vaultBody.Location ?? null; set => _vaultBody.Location = value; }

        /// <summary>
        /// <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IEventListener" /> cancellation delegate. Stops the cmdlet when called.
        /// </summary>
        global::System.Action Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IEventListener.Cancel => _cancellationTokenSource.Cancel;

        /// <summary><see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IEventListener" /> cancellation token.</summary>
        global::System.Threading.CancellationToken Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IEventListener.Token => _cancellationTokenSource.Token;

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The name of the Vault</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The name of the Vault")]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The name of the Vault",
        SerializedName = @"vaultName",
        PossibleTypes = new [] { typeof(string) })]
        [global::System.Management.Automation.Alias("VaultName")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.ParameterCategory.Path)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>
        /// when specified, will make the remote call, and return an AsyncOperationResponse, letting the remote operation continue
        /// asynchronously.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Run the command asynchronously")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter NoWait { get; set; }

        /// <summary>
        /// The instance of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.HttpPipeline" /> that the remote call will use.
        /// </summary>
        public Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.HttpPipeline Pipeline { get; set; }

        /// <summary>The URI for the proxy server to use</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "The URI for the proxy server to use")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.ParameterCategory.Runtime)]
        public global::System.Uri Proxy { get; set; }

        /// <summary>Credentials for a proxy server to use for the remote call</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Credentials for a proxy server to use for the remote call")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.ParameterCategory.Runtime)]
        public global::System.Management.Automation.PSCredential ProxyCredential { get; set; }

        /// <summary>Use the default credentials for the proxy</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Use the default credentials for the proxy")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter ProxyUseDefaultCredentials { get; set; }

        /// <summary>
        /// property to enable or disable resource provider inbound network traffic from public clients
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "property to enable or disable resource provider inbound network traffic from public clients")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"property to enable or disable resource provider inbound network traffic from public clients",
        SerializedName = @"publicNetworkAccess",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        public string PublicNetworkAccess { get => _vaultBody.PublicNetworkAccess ?? null; set => _vaultBody.PublicNetworkAccess = value; }

        /// <summary>Flag to show if Cross Region Restore is enabled on the Vault or not</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Flag to show if Cross Region Restore is enabled on the Vault or not")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Flag to show if Cross Region Restore is enabled on the Vault or not",
        SerializedName = @"crossRegionRestore",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        public string RedundancySettingCrossRegionRestore { get => _vaultBody.RedundancySettingCrossRegionRestore ?? null; set => _vaultBody.RedundancySettingCrossRegionRestore = value; }

        /// <summary>The storage redundancy setting of a vault</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The storage redundancy setting of a vault")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The storage redundancy setting of a vault",
        SerializedName = @"standardTierStorageRedundancy",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Invalid", "LocallyRedundant", "GeoRedundant", "ZoneRedundant")]
        public string RedundancySettingStandardTierStorageRedundancy { get => _vaultBody.RedundancySettingStandardTierStorageRedundancy ?? null; set => _vaultBody.RedundancySettingStandardTierStorageRedundancy = value; }

        /// <summary>Backing field for <see cref="ResourceGroupName" /> property.</summary>
        private string _resourceGroupName;

        /// <summary>The name of the resource group. The name is case insensitive.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The name of the resource group. The name is case insensitive.")]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The name of the resource group. The name is case insensitive.",
        SerializedName = @"resourceGroupName",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.ParameterCategory.Path)]
        public string ResourceGroupName { get => this._resourceGroupName; set => this._resourceGroupName = value; }

        /// <summary>ResourceGuardOperationRequests on which LAC check will be performed</summary>
        [global::System.Management.Automation.AllowEmptyCollection]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "ResourceGuardOperationRequests on which LAC check will be performed")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"ResourceGuardOperationRequests on which LAC check will be performed",
        SerializedName = @"resourceGuardOperationRequests",
        PossibleTypes = new [] { typeof(string) })]
        public string[] ResourceGuardOperationRequest { get => _vaultBody.ResourceGuardOperationRequest?.ToArray() ?? null /* fixedArrayOf */; set => _vaultBody.ResourceGuardOperationRequest = (value != null ? new System.Collections.Generic.List<string>(value) : null); }

        /// <summary>The sku capacity</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The sku capacity")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The sku capacity",
        SerializedName = @"capacity",
        PossibleTypes = new [] { typeof(string) })]
        public string SkuCapacity { get => _vaultBody.SkuCapacity ?? null; set => _vaultBody.SkuCapacity = value; }

        /// <summary>The sku family</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The sku family")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The sku family",
        SerializedName = @"family",
        PossibleTypes = new [] { typeof(string) })]
        public string SkuFamily { get => _vaultBody.SkuFamily ?? null; set => _vaultBody.SkuFamily = value; }

        /// <summary>
        /// Name of SKU is RS0 (Recovery Services 0th version) and the tier is standard tier. They do not have affect on backend storage
        /// redundancy or any other vault settings. To manage storage redundancy, use the backupstorageconfig
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Name of SKU is RS0 (Recovery Services 0th version) and the tier is standard tier. They do not have affect on backend storage redundancy or any other vault settings. To manage storage redundancy, use the backupstorageconfig")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of SKU is RS0 (Recovery Services 0th version) and the tier is standard tier. They do not have affect on backend storage redundancy or any other vault settings. To manage storage redundancy, use the backupstorageconfig",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Standard", "RS0")]
        public string SkuName { get => _vaultBody.SkuName ?? null; set => _vaultBody.SkuName = value; }

        /// <summary>The sku size</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The sku size")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The sku size",
        SerializedName = @"size",
        PossibleTypes = new [] { typeof(string) })]
        public string SkuSize { get => _vaultBody.SkuSize ?? null; set => _vaultBody.SkuSize = value; }

        /// <summary>The Sku tier.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The Sku tier.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Sku tier.",
        SerializedName = @"tier",
        PossibleTypes = new [] { typeof(string) })]
        public string SkuTier { get => _vaultBody.SkuTier ?? null; set => _vaultBody.SkuTier = value; }

        /// <summary>.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = ".")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @".",
        SerializedName = @"enhancedSecurityState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Invalid", "Enabled", "Disabled", "AlwaysON")]
        public string SoftDeleteSettingEnhancedSecurityState { get => _vaultBody.SoftDeleteSettingEnhancedSecurityState ?? null; set => _vaultBody.SoftDeleteSettingEnhancedSecurityState = value; }

        /// <summary>Soft delete retention period in days</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Soft delete retention period in days")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Soft delete retention period in days",
        SerializedName = @"softDeleteRetentionPeriodInDays",
        PossibleTypes = new [] { typeof(int) })]
        public int SoftDeleteSettingSoftDeleteRetentionPeriodInDay { get => _vaultBody.SoftDeleteSettingSoftDeleteRetentionPeriodInDay ?? default(int); set => _vaultBody.SoftDeleteSettingSoftDeleteRetentionPeriodInDay = value; }

        /// <summary>.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = ".")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @".",
        SerializedName = @"softDeleteState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Invalid", "Enabled", "Disabled", "AlwaysON")]
        public string SoftDeleteSettingSoftDeleteState { get => _vaultBody.SoftDeleteSettingSoftDeleteState ?? null; set => _vaultBody.SoftDeleteSettingSoftDeleteState = value; }

        /// <summary>.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = ".")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @".",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Invalid", "Enabled", "Disabled")]
        public string SourceScanConfigurationState { get => _vaultBody.SourceScanConfigurationState ?? null; set => _vaultBody.SourceScanConfigurationState = value; }

        /// <summary>Identity type that should be used for an operation.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Identity type that should be used for an operation.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Identity type that should be used for an operation.",
        SerializedName = @"operationIdentityType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("SystemAssigned", "UserAssigned")]
        public string SourceScanIdentityOperationIdentityType { get => _vaultBody.SourceScanIdentityOperationIdentityType ?? null; set => _vaultBody.SourceScanIdentityOperationIdentityType = value; }

        /// <summary>
        /// User assigned identity to be used for an operation if operationIdentityType is UserAssigned.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "User assigned identity to be used for an operation if operationIdentityType is UserAssigned.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"User assigned identity to be used for an operation if operationIdentityType is UserAssigned.",
        SerializedName = @"userAssignedIdentity",
        PossibleTypes = new [] { typeof(string) })]
        public string SourceScanIdentityUserAssignedIdentity { get => _vaultBody.SourceScanIdentityUserAssignedIdentity ?? null; set => _vaultBody.SourceScanIdentityUserAssignedIdentity = value; }

        /// <summary>Backing field for <see cref="SubscriptionId" /> property.</summary>
        private string _subscriptionId;

        /// <summary>The ID of the target subscription. The value must be an UUID.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The ID of the target subscription. The value must be an UUID.")]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The ID of the target subscription. The value must be an UUID.",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.DefaultInfo(
        Name = @"",
        Description =@"",
        Script = @"(Get-AzContext).Subscription.Id",
        SetCondition = @"")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.ParameterCategory.Path)]
        public string SubscriptionId { get => this._subscriptionId; set => this._subscriptionId = value; }

        /// <summary>Resource tags.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.ExportAs(typeof(global::System.Collections.Hashtable))]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Resource tags.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource tags.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ITrackedResourceTags) })]
        public Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ITrackedResourceTags Tag { get => _vaultBody.Tag ?? null /* object */; set => _vaultBody.Tag = value; }

        /// <summary>
        /// The array of user assigned identities associated with the resource. The elements in array will be ARM resource ids in
        /// the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}.'
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The array of user assigned identities associated with the resource. The elements in array will be ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}.'")]
        [global::System.Management.Automation.AllowEmptyCollection]
        public string[] UserAssignedIdentity { get; set; }

        /// <summary>Backing field for <see cref="XmsAuthorizationAuxiliary" /> property.</summary>
        private string _xmsAuthorizationAuxiliary;

        /// <summary>A sequence of textual characters.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "A sequence of textual characters.")]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A sequence of textual characters.",
        SerializedName = @"x-ms-authorization-auxiliary",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.ParameterCategory.Header)]
        public string XmsAuthorizationAuxiliary { get => this._xmsAuthorizationAuxiliary; set => this._xmsAuthorizationAuxiliary = value; }

        /// <summary>
        /// <c>overrideOnDefault</c> will be called before the regular onDefault has been processed, allowing customization of what
        /// happens on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ICloudError">Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ICloudError</see>
        /// from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onDefault method should be processed, or if the method should
        /// return immediately (set to true to skip further processing )</param>

        partial void overrideOnDefault(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ICloudError> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// <c>overrideOnOk</c> will be called before the regular onOk has been processed, allowing customization of what happens
        /// on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVault">Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVault</see>
        /// from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onOk method should be processed, or if the method should return
        /// immediately (set to true to skip further processing )</param>

        partial void overrideOnOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVault> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// (overrides the default BeginProcessing method in global::System.Management.Automation.PSCmdlet)
        /// </summary>
        protected override void BeginProcessing()
        {
            var telemetryId = Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Module.Instance.GetTelemetryId.Invoke();
            if (telemetryId != "" && telemetryId != "internal")
            {
                __correlationId = telemetryId;
            }
            Module.Instance.SetProxyConfiguration(Proxy, ProxyCredential, ProxyUseDefaultCredentials);
            if (Break)
            {
                Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.AttachDebugger.Break();
            }
            ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Events.CmdletBeginProcessing).Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
        }

        /// <summary>Creates a duplicate instance of this cmdlet (via JSON serialization).</summary>
        /// <returns>a duplicate instance of NewAzRecoveryServicesVault_CreateExpanded</returns>
        public Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Cmdlets.NewAzRecoveryServicesVault_CreateExpanded Clone()
        {
            var clone = new NewAzRecoveryServicesVault_CreateExpanded();
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
            clone._vaultBody = this._vaultBody;
            clone.SubscriptionId = this.SubscriptionId;
            clone.ResourceGroupName = this.ResourceGroupName;
            clone.Name = this.Name;
            clone.XmsAuthorizationAuxiliary = this.XmsAuthorizationAuxiliary;
            return clone;
        }

        /// <summary>Performs clean-up after the command execution</summary>
        protected override void EndProcessing()
        {
            var telemetryInfo = Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Module.Instance.GetTelemetryInfo?.Invoke(__correlationId);
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
         async global::System.Threading.Tasks.Task Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IEventListener.Signal(string id, global::System.Threading.CancellationToken token, global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.EventData> messageData)
        {
            using( NoSynchronizationContext )
            {
                if (token.IsCancellationRequested)
                {
                    return ;
                }

                switch ( id )
                {
                    case Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Events.Verbose:
                    {
                        WriteVerbose($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Events.Warning:
                    {
                        WriteWarning($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Events.Information:
                    {
                        // When an operation supports asjob, Information messages must go thru verbose.
                        WriteVerbose($"INFORMATION: {(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Events.Debug:
                    {
                        WriteDebug($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Events.Error:
                    {
                        WriteError(new global::System.Management.Automation.ErrorRecord( new global::System.Exception(messageData().Message), string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null ) );
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Events.Progress:
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
                    case Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Events.DelayBeforePolling:
                    {
                        var data = messageData();
                        if (true == MyInvocation?.BoundParameters?.ContainsKey("NoWait"))
                        {
                            if (data.ResponseMessage is System.Net.Http.HttpResponseMessage response)
                            {
                                var asyncOperation = response.GetFirstHeader(@"Azure-AsyncOperation");
                                var location = response.GetFirstHeader(@"Location");
                                var uri = global::System.String.IsNullOrEmpty(asyncOperation) ? global::System.String.IsNullOrEmpty(location) ? response.RequestMessage.RequestUri.AbsoluteUri : location : asyncOperation;
                                WriteObject(new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.PowerShell.AsyncOperationResponse { Target = uri });
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
                await Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Module.Instance.Signal(id, token, messageData, (i, t, m) => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IEventListener)this).Signal(i, t, () => Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.EventDataConverter.ConvertFrom(m()) as Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.EventData), InvocationInformation, this.ParameterSetName, __correlationId, __processRecordId, null );
                if (token.IsCancellationRequested)
                {
                    return ;
                }
                WriteDebug($"{id}: {(messageData().Message ?? global::System.String.Empty)}");
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewAzRecoveryServicesVault_CreateExpanded" /> cmdlet class.
        /// </summary>
        public NewAzRecoveryServicesVault_CreateExpanded()
        {

        }

        private void PreProcessManagedIdentityParameters()
        {
            if (this.UserAssignedIdentity?.Length > 0)
            {
                // calculate UserAssignedIdentity
                _vaultBody.IdentityUserAssignedIdentity.Clear();
                foreach( var id in this.UserAssignedIdentity )
                {
                    _vaultBody.IdentityUserAssignedIdentity.Add(id, new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.UserIdentity());
                }
            }
            // calculate IdentityType
            if (this.UserAssignedIdentity?.Length > 0)
            {
                if ("SystemAssigned".Equals(_vaultBody.IdentityType, StringComparison.InvariantCultureIgnoreCase))
                {
                    _vaultBody.IdentityType = "SystemAssigned,UserAssigned";
                }
                else
                {
                    _vaultBody.IdentityType = "UserAssigned";
                }
            }
        }

        /// <summary>Performs execution of the command.</summary>
        protected override void ProcessRecord()
        {
            ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Events.CmdletProcessRecordStart).Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
            __processRecordId = System.Guid.NewGuid().ToString();
            try
            {
                // work
                if (ShouldProcess($"Call remote 'VaultsCreateOrUpdate' operation"))
                {
                    if (true == MyInvocation?.BoundParameters?.ContainsKey("AsJob"))
                    {
                        var instance = this.Clone();
                        var job = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.PowerShell.AsyncJob(instance, this.MyInvocation.Line, this.MyInvocation.MyCommand.Name, this._cancellationTokenSource.Token, this._cancellationTokenSource.Cancel);
                        JobRepository.Add(job);
                        var task = instance.ProcessRecordAsync();
                        job.Monitor(task);
                        WriteObject(job);
                    }
                    else
                    {
                        using( var asyncCommandRuntime = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.PowerShell.AsyncCommandRuntime(this, ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IEventListener)this).Token) )
                        {
                            asyncCommandRuntime.Wait( ProcessRecordAsync(),((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IEventListener)this).Token);
                        }
                    }
                }
            }
            catch (global::System.AggregateException aggregateException)
            {
                // unroll the inner exceptions to get the root cause
                foreach( var innerException in aggregateException.Flatten().InnerExceptions )
                {
                    ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Events.CmdletException, $"{innerException.GetType().Name} - {innerException.Message} : {innerException.StackTrace}").Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    // Write exception out to error channel.
                    WriteError( new global::System.Management.Automation.ErrorRecord(innerException,string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null) );
                }
            }
            catch (global::System.Exception exception) when ((exception as System.Management.Automation.PipelineStoppedException)== null || (exception as System.Management.Automation.PipelineStoppedException).InnerException != null)
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Events.CmdletException, $"{exception.GetType().Name} - {exception.Message} : {exception.StackTrace}").Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                // Write exception out to error channel.
                WriteError( new global::System.Management.Automation.ErrorRecord(exception,string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null) );
            }
            finally
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Events.CmdletProcessRecordEnd).Wait();
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
                await ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Events.CmdletGetPipeline); if( ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                Pipeline = Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Module.Instance.CreatePipeline(InvocationInformation, __correlationId, __processRecordId, this.ParameterSetName, this.ExtensibleParameters);
                if (null != HttpPipelinePrepend)
                {
                    Pipeline.Prepend((this.CommandRuntime as Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelinePrepend) ?? HttpPipelinePrepend);
                }
                if (null != HttpPipelineAppend)
                {
                    Pipeline.Append((this.CommandRuntime as Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelineAppend) ?? HttpPipelineAppend);
                }
                // get the client instance
                try
                {
                    await ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Events.CmdletBeforeAPICall); if( ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    this.PreProcessManagedIdentityParameters();
                    await this.Client.VaultsCreateOrUpdate(SubscriptionId, ResourceGroupName, Name, this.InvocationInformation.BoundParameters.ContainsKey("XmsAuthorizationAuxiliary") ? XmsAuthorizationAuxiliary : null, _vaultBody, onOk, onDefault, this, Pipeline, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.SerializationMode.IncludeCreate);
                    await ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Events.CmdletAfterAPICall); if( ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                }
                catch (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.UndeclaredResponseException urexception)
                {
                    WriteError(new global::System.Management.Automation.ErrorRecord(urexception, urexception.StatusCode.ToString(), global::System.Management.Automation.ErrorCategory.InvalidOperation, new { SubscriptionId=SubscriptionId,ResourceGroupName=ResourceGroupName,Name=Name,XmsAuthorizationAuxiliary=this.InvocationInformation.BoundParameters.ContainsKey("XmsAuthorizationAuxiliary") ? XmsAuthorizationAuxiliary : null})
                    {
                      ErrorDetails = new global::System.Management.Automation.ErrorDetails(urexception.Message) { RecommendedAction = urexception.Action }
                    });
                }
                finally
                {
                    await ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Events.CmdletProcessRecordAsyncEnd);
                }
            }
        }

        /// <summary>Interrupts currently running code within the command.</summary>
        protected override void StopProcessing()
        {
            ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IEventListener)this).Cancel();
            base.StopProcessing();
        }

        /// <param name="sendToPipeline"></param>
        new protected void WriteObject(object sendToPipeline)
        {
            Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Module.Instance.SanitizeOutput?.Invoke(sendToPipeline, __correlationId);
            base.WriteObject(sendToPipeline);
        }

        /// <param name="sendToPipeline"></param>
        /// <param name="enumerateCollection"></param>
        new protected void WriteObject(object sendToPipeline, bool enumerateCollection)
        {
            Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Module.Instance.SanitizeOutput?.Invoke(sendToPipeline, __correlationId);
            base.WriteObject(sendToPipeline, enumerateCollection);
        }

        /// <summary>
        /// a delegate that is called when the remote service returns default (any response code not handled elsewhere).
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ICloudError">Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ICloudError</see>
        /// from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onDefault(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ICloudError> response)
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
                    var ex = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ICloudError>(responseMessage, await response);
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
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVault">Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVault</see>
        /// from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVault> response)
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
                // (await response) // should be Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVault
                var result = (await response);
                WriteObject(result, false);
            }
        }
    }
}