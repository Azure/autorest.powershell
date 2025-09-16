// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Cmdlets
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;
    using Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.PowerShell;
    using Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Cmdlets;
    using System;

    /// <summary>update a Service Fabric managed cluster resource with the specified name.</summary>
    /// <remarks>
    /// [OpenAPI] CreateOrUpdate=>PUT:"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/managedClusters/{clusterName}"
    /// </remarks>
    [global::System.Management.Automation.Cmdlet(global::System.Management.Automation.VerbsCommon.Set, @"AzServiceFabricManagedClustersManagedCluster_UpdateExpanded", SupportsShouldProcess = true)]
    [global::System.Management.Automation.OutputType(typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedCluster))]
    [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Description(@"update a Service Fabric managed cluster resource with the specified name.")]
    [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Generated]
    [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.HttpPath(Path = "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/managedClusters/{clusterName}", ApiVersion = "2025-06-01-preview")]
    public partial class SetAzServiceFabricManagedClustersManagedCluster_UpdateExpanded : global::System.Management.Automation.PSCmdlet,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IContext
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

        /// <summary>The managed cluster resource</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedCluster _parametersBody = new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ManagedCluster();

        /// <summary>List of add-on features to enable on the cluster.</summary>
        [global::System.Management.Automation.AllowEmptyCollection]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "List of add-on features to enable on the cluster.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of add-on features to enable on the cluster.",
        SerializedName = @"addonFeatures",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("DnsService", "BackupRestoreService", "ResourceMonitorService")]
        public string[] AddonFeature { get => _parametersBody.AddonFeature?.ToArray() ?? null /* fixedArrayOf */; set => _parametersBody.AddonFeature = (value != null ? new System.Collections.Generic.List<string>(value) : null); }

        /// <summary>VM admin user password.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "VM admin user password.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"VM admin user password.",
        SerializedName = @"adminPassword",
        PossibleTypes = new [] { typeof(System.Security.SecureString) })]
        public System.Security.SecureString AdminPassword { get => _parametersBody.AdminPassword ?? null; set => _parametersBody.AdminPassword = value; }

        /// <summary>VM admin user name.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "VM admin user name.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"VM admin user name.",
        SerializedName = @"adminUserName",
        PossibleTypes = new [] { typeof(string) })]
        public string AdminUserName { get => _parametersBody.AdminUserName ?? null; set => _parametersBody.AdminUserName = value; }

        /// <summary>
        /// The number of outbound ports allocated for SNAT for each node in the backend pool of the default load balancer. The default
        /// value is 0 which provides dynamic port allocation based on pool size.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The number of outbound ports allocated for SNAT for each node in the backend pool of the default load balancer. The default value is 0 which provides dynamic port allocation based on pool size.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of outbound ports allocated for SNAT for each node in the backend pool of the default load balancer. The default value is 0 which provides dynamic port allocation based on pool size.",
        SerializedName = @"allocatedOutboundPorts",
        PossibleTypes = new [] { typeof(int) })]
        public int AllocatedOutboundPort { get => _parametersBody.AllocatedOutboundPort ?? default(int); set => _parametersBody.AllocatedOutboundPort = value; }

        /// <summary>
        /// Setting this to true enables RDP access to the VM. The default NSG rule opens RDP port to Internet which can be overridden
        /// with custom Network Security Rules. The default value for this setting is false.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Setting this to true enables RDP access to the VM. The default NSG rule opens RDP port to Internet which can be overridden with custom Network Security Rules. The default value for this setting is false.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Setting this to true enables RDP access to the VM. The default NSG rule opens RDP port to Internet which can be overridden with custom Network Security Rules. The default value for this setting is false.",
        SerializedName = @"allowRdpAccess",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter AllowRdpAccess { get => _parametersBody.AllowRdpAccess ?? default(global::System.Management.Automation.SwitchParameter); set => _parametersBody.AllowRdpAccess = value; }

        /// <summary>Number of unused versions per application type to keep.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Number of unused versions per application type to keep.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Number of unused versions per application type to keep.",
        SerializedName = @"maxUnusedVersionsToKeep",
        PossibleTypes = new [] { typeof(int) })]
        public int ApplicationTypeVersionCleanupPolicyMaxUnusedVersionsToKeep { get => _parametersBody.ApplicationTypeVersionCleanupPolicyMaxUnusedVersionsToKeep ?? default(int); set => _parametersBody.ApplicationTypeVersionCleanupPolicyMaxUnusedVersionsToKeep = value; }

        /// <summary>when specified, runs this cmdlet as a PowerShell job</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Run the command as a job")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter AsJob { get; set; }

        /// <summary>
        /// This property is the entry point to using a public CA cert for your cluster cert. It specifies the level of reuse allowed
        /// for the custom FQDN created, matching the subject of the public CA cert.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "This property is the entry point to using a public CA cert for your cluster cert. It specifies the level of reuse allowed for the custom FQDN created, matching the subject of the public CA cert.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"This property is the entry point to using a public CA cert for your cluster cert. It specifies the level of reuse allowed for the custom FQDN created, matching the subject of the public CA cert.",
        SerializedName = @"autoGeneratedDomainNameLabelScope",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("TenantReuse", "SubscriptionReuse", "ResourceGroupReuse", "NoReuse")]
        public string AutoGeneratedDomainNameLabelScope { get => _parametersBody.AutoGeneratedDomainNameLabelScope ?? null; set => _parametersBody.AutoGeneratedDomainNameLabelScope = value; }

        /// <summary>Auxiliary subnets for the cluster.</summary>
        [global::System.Management.Automation.AllowEmptyCollection]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Auxiliary subnets for the cluster.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Auxiliary subnets for the cluster.",
        SerializedName = @"auxiliarySubnets",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISubnet) })]
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISubnet[] AuxiliarySubnet { get => _parametersBody.AuxiliarySubnet?.ToArray() ?? null /* fixedArrayOf */; set => _parametersBody.AuxiliarySubnet = (value != null ? new System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISubnet>(value) : null); }

        /// <summary>Azure active directory client application id.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Azure active directory client application id.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Azure active directory client application id.",
        SerializedName = @"clientApplication",
        PossibleTypes = new [] { typeof(string) })]
        public string AzureActiveDirectoryClientApplication { get => _parametersBody.AzureActiveDirectoryClientApplication ?? null; set => _parametersBody.AzureActiveDirectoryClientApplication = value; }

        /// <summary>Azure active directory cluster application id.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Azure active directory cluster application id.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Azure active directory cluster application id.",
        SerializedName = @"clusterApplication",
        PossibleTypes = new [] { typeof(string) })]
        public string AzureActiveDirectoryClusterApplication { get => _parametersBody.AzureActiveDirectoryClusterApplication ?? null; set => _parametersBody.AzureActiveDirectoryClusterApplication = value; }

        /// <summary>Azure active directory tenant id.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Azure active directory tenant id.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Azure active directory tenant id.",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        public string AzureActiveDirectoryTenantId { get => _parametersBody.AzureActiveDirectoryTenantId ?? null; set => _parametersBody.AzureActiveDirectoryTenantId = value; }

        /// <summary>Wait for .NET debugger to attach</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Wait for .NET debugger to attach")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter Break { get; set; }

        /// <summary>Accessor for cancellationTokenSource.</summary>
        public global::System.Threading.CancellationTokenSource CancellationTokenSource { get => _cancellationTokenSource ; set { _cancellationTokenSource = value; } }

        /// <summary>The reference to the client API class.</summary>
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ServiceFabricManagedClustersManagementClient Client => Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Module.Instance.ClientAPI;

        /// <summary>Client certificates that are allowed to manage the cluster.</summary>
        [global::System.Management.Automation.AllowEmptyCollection]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Client certificates that are allowed to manage the cluster.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Client certificates that are allowed to manage the cluster.",
        SerializedName = @"clients",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClientCertificate) })]
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClientCertificate[] Client { get => _parametersBody.Client?.ToArray() ?? null /* fixedArrayOf */; set => _parametersBody.Client = (value != null ? new System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClientCertificate>(value) : null); }

        /// <summary>The port used for client connections to the cluster.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The port used for client connections to the cluster.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The port used for client connections to the cluster.",
        SerializedName = @"clientConnectionPort",
        PossibleTypes = new [] { typeof(int) })]
        public int ClientConnectionPort { get => _parametersBody.ClientConnectionPort ?? default(int); set => _parametersBody.ClientConnectionPort = value; }

        /// <summary>
        /// The Service Fabric runtime version of the cluster. This property is required when **clusterUpgradeMode** is set to 'Manual'.
        /// To get list of available Service Fabric versions for new clusters use [ClusterVersion API](./ClusterVersion.md). To get
        /// the list of available version for existing clusters use **availableClusterVersions**.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The Service Fabric runtime version of the cluster. This property is required when **clusterUpgradeMode** is set to 'Manual'. To get list of available Service Fabric versions for new clusters use [ClusterVersion API](./ClusterVersion.md). To get the list of available version for existing clusters use **availableClusterVersions**.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Service Fabric runtime version of the cluster. This property is required when **clusterUpgradeMode** is set to 'Manual'. To get list of available Service Fabric versions for new clusters use [ClusterVersion API](./ClusterVersion.md). To get the list of available version for existing clusters use **availableClusterVersions**.",
        SerializedName = @"clusterCodeVersion",
        PossibleTypes = new [] { typeof(string) })]
        public string ClusterCodeVersion { get => _parametersBody.ClusterCodeVersion ?? null; set => _parametersBody.ClusterCodeVersion = value; }

        /// <summary>Backing field for <see cref="ClusterName" /> property.</summary>
        private string _clusterName;

        /// <summary>The name of the cluster resource.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The name of the cluster resource.")]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The name of the cluster resource.",
        SerializedName = @"clusterName",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Path)]
        public string ClusterName { get => this._clusterName; set => this._clusterName = value; }

        /// <summary>
        /// Indicates when new cluster runtime version upgrades will be applied after they are released. By default is Wave0. Only
        /// applies when **clusterUpgradeMode** is set to 'Automatic'.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Indicates when new cluster runtime version upgrades will be applied after they are released. By default is Wave0. Only applies when **clusterUpgradeMode** is set to 'Automatic'.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicates when new cluster runtime version upgrades will be applied after they are released. By default is Wave0. Only applies when **clusterUpgradeMode** is set to 'Automatic'.",
        SerializedName = @"clusterUpgradeCadence",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("Wave0", "Wave1", "Wave2")]
        public string ClusterUpgradeCadence { get => _parametersBody.ClusterUpgradeCadence ?? null; set => _parametersBody.ClusterUpgradeCadence = value; }

        /// <summary>
        /// The upgrade mode of the cluster when new Service Fabric runtime version is available.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The upgrade mode of the cluster when new Service Fabric runtime version is available.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The upgrade mode of the cluster when new Service Fabric runtime version is available.",
        SerializedName = @"clusterUpgradeMode",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("Automatic", "Manual")]
        public string ClusterUpgradeMode { get => _parametersBody.ClusterUpgradeMode ?? null; set => _parametersBody.ClusterUpgradeMode = value; }

        /// <summary>
        /// Specify the resource id of a DDoS network protection plan that will be associated with the virtual network of the cluster.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Specify the resource id of a DDoS network protection plan that will be associated with the virtual network of the cluster.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specify the resource id of a DDoS network protection plan that will be associated with the virtual network of the cluster.",
        SerializedName = @"ddosProtectionPlanId",
        PossibleTypes = new [] { typeof(string) })]
        public string DdosProtectionPlanId { get => _parametersBody.DdosProtectionPlanId ?? null; set => _parametersBody.DdosProtectionPlanId = value; }

        /// <summary>
        /// The DefaultProfile parameter is not functional. Use the SubscriptionId parameter when available if executing the cmdlet
        /// against a different subscription
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The DefaultProfile parameter is not functional. Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::System.Management.Automation.Alias("AzureRMContext", "AzureCredential")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Azure)]
        public global::System.Management.Automation.PSObject DefaultProfile { get; set; }

        /// <summary>
        /// The maximum allowed percentage of applications health degradation allowed during cluster upgrades.The delta is measured
        /// between the state of the applications at the beginning of upgrade and the state of the applications at the time of the
        /// health evaluation.The check is performed after every upgrade domain upgrade completion to make sure the global state of
        /// the cluster is within tolerated limits. System services are not included in this.NOTE: This value will overwrite the value
        /// specified in properties.UpgradeDescription.HealthPolicy.MaxPercentUnhealthyApplications
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The maximum allowed percentage of applications health degradation allowed during cluster upgrades.The delta is measured between the state of the applications at the beginning of upgrade and the state of the applications at the time of the health evaluation.The check is performed after every upgrade domain upgrade completion to make sure the global state of the cluster is within tolerated limits. System services are not included in this.NOTE: This value will overwrite the value specified in properties.UpgradeDescription.HealthPolicy.MaxPercentUnhealthyApplications")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The maximum allowed percentage of applications health degradation allowed during cluster upgrades.The delta is measured between the state of the applications at the beginning of upgrade and the state of the applications at the time of the health evaluation.The check is performed after every upgrade domain upgrade completion to make sure the global state of the cluster is within tolerated limits. System services are not included in this.NOTE: This value will overwrite the value specified in properties.UpgradeDescription.HealthPolicy.MaxPercentUnhealthyApplications",
        SerializedName = @"maxPercentDeltaUnhealthyApplications",
        PossibleTypes = new [] { typeof(int) })]
        public int DeltaHealthPolicyMaxPercentDeltaUnhealthyApplication { get => _parametersBody.DeltaHealthPolicyMaxPercentDeltaUnhealthyApplication ?? default(int); set => _parametersBody.DeltaHealthPolicyMaxPercentDeltaUnhealthyApplication = value; }

        /// <summary>
        /// The maximum allowed percentage of nodes health degradation allowed during cluster upgrades.The delta is measured between
        /// the state of the nodes at the beginning of upgrade and the state of the nodes at the time of the health evaluation.The
        /// check is performed after every upgrade domain upgrade completion to make sure the global state of the cluster is within
        /// tolerated limits.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The maximum allowed percentage of nodes health degradation allowed during cluster upgrades.The delta is measured between the state of the nodes at the beginning of upgrade and the state of the nodes at the time of the health evaluation.The check is performed after every upgrade domain upgrade completion to make sure the global state of the cluster is within tolerated limits.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The maximum allowed percentage of nodes health degradation allowed during cluster upgrades.The delta is measured between the state of the nodes at the beginning of upgrade and the state of the nodes at the time of the health evaluation.The check is performed after every upgrade domain upgrade completion to make sure the global state of the cluster is within tolerated limits.",
        SerializedName = @"maxPercentDeltaUnhealthyNodes",
        PossibleTypes = new [] { typeof(int) })]
        public int DeltaHealthPolicyMaxPercentDeltaUnhealthyNode { get => _parametersBody.DeltaHealthPolicyMaxPercentDeltaUnhealthyNode ?? default(int); set => _parametersBody.DeltaHealthPolicyMaxPercentDeltaUnhealthyNode = value; }

        /// <summary>
        /// The maximum allowed percentage of upgrade domain nodes health degradation allowed during cluster upgrades.The delta is
        /// measured between the state of the upgrade domain nodes at the beginning of upgrade and the state of the upgrade domain
        /// nodes at the time of the health evaluation.The check is performed after every upgrade domain upgrade completion for all
        /// completed upgrade domains to make sure the state of the upgrade domains is within tolerated limits.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The maximum allowed percentage of upgrade domain nodes health degradation allowed during cluster upgrades.The delta is measured between the state of the upgrade domain nodes at the beginning of upgrade and the state of the upgrade domain nodes at the time of the health evaluation.The check is performed after every upgrade domain upgrade completion for all completed upgrade domains to make sure the state of the upgrade domains is within tolerated limits.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The maximum allowed percentage of upgrade domain nodes health degradation allowed during cluster upgrades.The delta is measured between the state of the upgrade domain nodes at the beginning of upgrade and the state of the upgrade domain nodes at the time of the health evaluation.The check is performed after every upgrade domain upgrade completion for all completed upgrade domains to make sure the state of the upgrade domains is within tolerated limits.",
        SerializedName = @"maxPercentUpgradeDomainDeltaUnhealthyNodes",
        PossibleTypes = new [] { typeof(int) })]
        public int DeltaHealthPolicyMaxPercentUpgradeDomainDeltaUnhealthyNode { get => _parametersBody.DeltaHealthPolicyMaxPercentUpgradeDomainDeltaUnhealthyNode ?? default(int); set => _parametersBody.DeltaHealthPolicyMaxPercentUpgradeDomainDeltaUnhealthyNode = value; }

        /// <summary>The cluster dns name.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The cluster dns name.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The cluster dns name.",
        SerializedName = @"dnsName",
        PossibleTypes = new [] { typeof(string) })]
        public string DnsName { get => _parametersBody.DnsName ?? null; set => _parametersBody.DnsName = value; }

        /// <summary>
        /// Enables automatic OS upgrade for node types created using OS images with version 'latest'. The default value for this
        /// setting is false.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Enables automatic OS upgrade for node types created using OS images with version 'latest'. The default value for this setting is false.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Enables automatic OS upgrade for node types created using OS images with version 'latest'. The default value for this setting is false.",
        SerializedName = @"enableAutoOSUpgrade",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter EnableAutoOSUpgrade { get => _parametersBody.EnableAutoOSUpgrade ?? default(global::System.Management.Automation.SwitchParameter); set => _parametersBody.EnableAutoOSUpgrade = value; }

        /// <summary>
        /// If true, token-based authentication is not allowed on the HttpGatewayEndpoint. This is required to support TLS versions
        /// 1.3 and above. If token-based authentication is used, HttpGatewayTokenAuthConnectionPort must be defined.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "If true, token-based authentication is not allowed on the HttpGatewayEndpoint. This is required to support TLS versions 1.3 and above. If token-based authentication is used, HttpGatewayTokenAuthConnectionPort must be defined.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"If true, token-based authentication is not allowed on the HttpGatewayEndpoint. This is required to support TLS versions 1.3 and above. If token-based authentication is used, HttpGatewayTokenAuthConnectionPort must be defined.",
        SerializedName = @"enableHttpGatewayExclusiveAuthMode",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter EnableHttpGatewayExclusiveAuthMode { get => _parametersBody.EnableHttpGatewayExclusiveAuthMode ?? default(global::System.Management.Automation.SwitchParameter); set => _parametersBody.EnableHttpGatewayExclusiveAuthMode = value; }

        /// <summary>
        /// Setting this to true creates IPv6 address space for the default VNet used by the cluster. This setting cannot be changed
        /// once the cluster is created. The default value for this setting is false.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Setting this to true creates IPv6 address space for the default VNet used by the cluster. This setting cannot be changed once the cluster is created. The default value for this setting is false.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Setting this to true creates IPv6 address space for the default VNet used by the cluster. This setting cannot be changed once the cluster is created. The default value for this setting is false.",
        SerializedName = @"enableIpv6",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter EnableIpv6 { get => _parametersBody.EnableIpv6 ?? default(global::System.Management.Automation.SwitchParameter); set => _parametersBody.EnableIpv6 = value; }

        /// <summary>
        /// Enable the creation of node types with only outbound traffic enabled. If set, a separate load balancer backend pool will
        /// be created for node types with inbound traffic enabled. Can only be set at the time of cluster creation.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Enable the creation of node types with only outbound traffic enabled. If set, a separate load balancer backend pool will be created for node types with inbound traffic enabled. Can only be set at the time of cluster creation.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Enable the creation of node types with only outbound traffic enabled. If set, a separate load balancer backend pool will be created for node types with inbound traffic enabled. Can only be set at the time of cluster creation.",
        SerializedName = @"enableOutboundOnlyNodeTypes",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter EnableOutboundOnlyNodeType { get => _parametersBody.EnableOutboundOnlyNodeType ?? default(global::System.Management.Automation.SwitchParameter); set => _parametersBody.EnableOutboundOnlyNodeType = value; }

        /// <summary>
        /// Setting this to true will link the IPv4 address as the ServicePublicIP of the IPv6 address. It can only be set to True
        /// if IPv6 is enabled on the cluster.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Setting this to true will link the IPv4 address as the ServicePublicIP of the IPv6 address. It can only be set to True if IPv6 is enabled on the cluster.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Setting this to true will link the IPv4 address as the ServicePublicIP of the IPv6 address. It can only be set to True if IPv6 is enabled on the cluster.",
        SerializedName = @"enableServicePublicIP",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter EnableServicePublicIP { get => _parametersBody.EnableServicePublicIP ?? default(global::System.Management.Automation.SwitchParameter); set => _parametersBody.EnableServicePublicIP = value; }

        /// <summary>Accessor for extensibleParameters.</summary>
        public global::System.Collections.Generic.IDictionary<global::System.String,global::System.Object> ExtensibleParameters { get => _extensibleParameters ; }

        /// <summary>The list of custom fabric settings to configure the cluster.</summary>
        [global::System.Management.Automation.AllowEmptyCollection]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The list of custom fabric settings to configure the cluster.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of custom fabric settings to configure the cluster.",
        SerializedName = @"fabricSettings",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISettingsSectionDescription) })]
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISettingsSectionDescription[] FabricSetting { get => _parametersBody.FabricSetting?.ToArray() ?? null /* fixedArrayOf */; set => _parametersBody.FabricSetting = (value != null ? new System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISettingsSectionDescription>(value) : null); }

        /// <summary>
        /// The maximum allowed percentage of unhealthy applications before reporting an error. For example, to allow 10% of applications
        /// to be unhealthy, this value would be 10.The percentage represents the maximum tolerated percentage of applications that
        /// can be unhealthy before the cluster is considered in error.If the percentage is respected but there is at least one unhealthy
        /// application, the health is evaluated as Warning.This is calculated by dividing the number of unhealthy applications over
        /// the total number of application instances in the cluster, excluding applications of application types that are included
        /// in the ApplicationTypeHealthPolicyMap.The computation rounds up to tolerate one failure on small numbers of applications.
        /// Default percentage is zero.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The maximum allowed percentage of unhealthy applications before reporting an error. For example, to allow 10% of applications to be unhealthy, this value would be 10.The percentage represents the maximum tolerated percentage of applications that can be unhealthy before the cluster is considered in error.If the percentage is respected but there is at least one unhealthy application, the health is evaluated as Warning.This is calculated by dividing the number of unhealthy applications over the total number of application instances in the cluster, excluding applications of application types that are included in the ApplicationTypeHealthPolicyMap.The computation rounds up to tolerate one failure on small numbers of applications. Default percentage is zero.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The maximum allowed percentage of unhealthy applications before reporting an error. For example, to allow 10% of applications to be unhealthy, this value would be 10.The percentage represents the maximum tolerated percentage of applications that can be unhealthy before the cluster is considered in error.If the percentage is respected but there is at least one unhealthy application, the health is evaluated as Warning.This is calculated by dividing the number of unhealthy applications over the total number of application instances in the cluster, excluding applications of application types that are included in the ApplicationTypeHealthPolicyMap.The computation rounds up to tolerate one failure on small numbers of applications. Default percentage is zero.",
        SerializedName = @"maxPercentUnhealthyApplications",
        PossibleTypes = new [] { typeof(int) })]
        public int HealthPolicyMaxPercentUnhealthyApplication { get => _parametersBody.HealthPolicyMaxPercentUnhealthyApplication ?? default(int); set => _parametersBody.HealthPolicyMaxPercentUnhealthyApplication = value; }

        /// <summary>
        /// The maximum allowed percentage of unhealthy nodes before reporting an error. For example, to allow 10% of nodes to be
        /// unhealthy, this value would be 10.The percentage represents the maximum tolerated percentage of nodes that can be unhealthy
        /// before the cluster is considered in error.If the percentage is respected but there is at least one unhealthy node, the
        /// health is evaluated as Warning.The percentage is calculated by dividing the number of unhealthy nodes over the total number
        /// of nodes in the cluster.The computation rounds up to tolerate one failure on small numbers of nodes. Default percentage
        /// is zero.In large clusters, some nodes will always be down or out for repairs, so this percentage should be configured
        /// to tolerate that.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The maximum allowed percentage of unhealthy nodes before reporting an error. For example, to allow 10% of nodes to be unhealthy, this value would be 10.The percentage represents the maximum tolerated percentage of nodes that can be unhealthy before the cluster is considered in error.If the percentage is respected but there is at least one unhealthy node, the health is evaluated as Warning.The percentage is calculated by dividing the number of unhealthy nodes over the total number of nodes in the cluster.The computation rounds up to tolerate one failure on small numbers of nodes. Default percentage is zero.In large clusters, some nodes will always be down or out for repairs, so this percentage should be configured to tolerate that.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The maximum allowed percentage of unhealthy nodes before reporting an error. For example, to allow 10% of nodes to be unhealthy, this value would be 10.The percentage represents the maximum tolerated percentage of nodes that can be unhealthy before the cluster is considered in error.If the percentage is respected but there is at least one unhealthy node, the health is evaluated as Warning.The percentage is calculated by dividing the number of unhealthy nodes over the total number of nodes in the cluster.The computation rounds up to tolerate one failure on small numbers of nodes. Default percentage is zero.In large clusters, some nodes will always be down or out for repairs, so this percentage should be configured to tolerate that.",
        SerializedName = @"maxPercentUnhealthyNodes",
        PossibleTypes = new [] { typeof(int) })]
        public int HealthPolicyMaxPercentUnhealthyNode { get => _parametersBody.HealthPolicyMaxPercentUnhealthyNode ?? default(int); set => _parametersBody.HealthPolicyMaxPercentUnhealthyNode = value; }

        /// <summary>The port used for HTTP connections to the cluster.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The port used for HTTP connections to the cluster.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The port used for HTTP connections to the cluster.",
        SerializedName = @"httpGatewayConnectionPort",
        PossibleTypes = new [] { typeof(int) })]
        public int HttpGatewayConnectionPort { get => _parametersBody.HttpGatewayConnectionPort ?? default(int); set => _parametersBody.HttpGatewayConnectionPort = value; }

        /// <summary>
        /// The port used for token-auth based HTTPS connections to the cluster. Cannot be set to the same port as HttpGatewayEndpoint.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The port used for token-auth based HTTPS connections to the cluster. Cannot be set to the same port as HttpGatewayEndpoint.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The port used for token-auth based HTTPS connections to the cluster. Cannot be set to the same port as HttpGatewayEndpoint.",
        SerializedName = @"httpGatewayTokenAuthConnectionPort",
        PossibleTypes = new [] { typeof(int) })]
        public int HttpGatewayTokenAuthConnectionPort { get => _parametersBody.HttpGatewayTokenAuthConnectionPort ?? default(int); set => _parametersBody.HttpGatewayTokenAuthConnectionPort = value; }

        /// <summary>SendAsync Pipeline Steps to be appended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be appended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Runtime)]
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.SendAsyncStep[] HttpPipelineAppend { get; set; }

        /// <summary>SendAsync Pipeline Steps to be prepended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be prepended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Runtime)]
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.SendAsyncStep[] HttpPipelinePrepend { get; set; }

        /// <summary>
        /// The list of IP tags associated with the default public IP address of the cluster.
        /// </summary>
        [global::System.Management.Automation.AllowEmptyCollection]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The list of IP tags associated with the default public IP address of the cluster.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of IP tags associated with the default public IP address of the cluster.",
        SerializedName = @"ipTags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPTag) })]
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPTag[] IPTag { get => _parametersBody.IPTag?.ToArray() ?? null /* fixedArrayOf */; set => _parametersBody.IPTag = (value != null ? new System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPTag>(value) : null); }

        /// <summary>Accessor for our copy of the InvocationInfo.</summary>
        public global::System.Management.Automation.InvocationInfo InvocationInformation { get => __invocationInfo = __invocationInfo ?? this.MyInvocation ; set { __invocationInfo = value; } }

        /// <summary>
        /// Load balancing rules that are applied to the public load balancer of the cluster.
        /// </summary>
        [global::System.Management.Automation.AllowEmptyCollection]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Load balancing rules that are applied to the public load balancer of the cluster.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Load balancing rules that are applied to the public load balancer of the cluster.",
        SerializedName = @"loadBalancingRules",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ILoadBalancingRule) })]
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ILoadBalancingRule[] LoadBalancingRule { get => _parametersBody.LoadBalancingRule?.ToArray() ?? null /* fixedArrayOf */; set => _parametersBody.LoadBalancingRule = (value != null ? new System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ILoadBalancingRule>(value) : null); }

        /// <summary>The geo-location where the resource lives</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The geo-location where the resource lives")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The geo-location where the resource lives",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        public string Location { get => _parametersBody.Location ?? null; set => _parametersBody.Location = value; }

        /// <summary>
        /// <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener" /> cancellation delegate. Stops the cmdlet when called.
        /// </summary>
        global::System.Action Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener.Cancel => _cancellationTokenSource.Cancel;

        /// <summary><see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener" /> cancellation token.</summary>
        global::System.Threading.CancellationToken Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener.Token => _cancellationTokenSource.Token;

        /// <summary>
        /// The amount of time to retry health evaluation when the application or cluster is unhealthy before the upgrade rolls back.
        /// The timeout can be in either hh:mm:ss or in d.hh:mm:ss.ms format.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The amount of time to retry health evaluation when the application or cluster is unhealthy before the upgrade rolls back. The timeout can be in either hh:mm:ss or in d.hh:mm:ss.ms format.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The amount of time to retry health evaluation when the application or cluster is unhealthy before the upgrade rolls back. The timeout can be in either hh:mm:ss or in d.hh:mm:ss.ms format.",
        SerializedName = @"healthCheckRetryTimeout",
        PossibleTypes = new [] { typeof(string) })]
        public string MonitoringPolicyHealthCheckRetryTimeout { get => _parametersBody.MonitoringPolicyHealthCheckRetryTimeout ?? null; set => _parametersBody.MonitoringPolicyHealthCheckRetryTimeout = value; }

        /// <summary>
        /// The amount of time that the application or cluster must remain healthy before the upgrade proceeds to the next upgrade
        /// domain. The duration can be in either hh:mm:ss or in d.hh:mm:ss.ms format.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The amount of time that the application or cluster must remain healthy before the upgrade proceeds to the next upgrade domain. The duration can be in either hh:mm:ss or in d.hh:mm:ss.ms format.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The amount of time that the application or cluster must remain healthy before the upgrade proceeds to the next upgrade domain. The duration can be in either hh:mm:ss or in d.hh:mm:ss.ms format.",
        SerializedName = @"healthCheckStableDuration",
        PossibleTypes = new [] { typeof(string) })]
        public string MonitoringPolicyHealthCheckStableDuration { get => _parametersBody.MonitoringPolicyHealthCheckStableDuration ?? null; set => _parametersBody.MonitoringPolicyHealthCheckStableDuration = value; }

        /// <summary>
        /// The length of time to wait after completing an upgrade domain before performing health checks. The duration can be in
        /// either hh:mm:ss or in d.hh:mm:ss.ms format.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The length of time to wait after completing an upgrade domain before performing health checks. The duration can be in either hh:mm:ss or in d.hh:mm:ss.ms format.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The length of time to wait after completing an upgrade domain before performing health checks. The duration can be in either hh:mm:ss or in d.hh:mm:ss.ms format.",
        SerializedName = @"healthCheckWaitDuration",
        PossibleTypes = new [] { typeof(string) })]
        public string MonitoringPolicyHealthCheckWaitDuration { get => _parametersBody.MonitoringPolicyHealthCheckWaitDuration ?? null; set => _parametersBody.MonitoringPolicyHealthCheckWaitDuration = value; }

        /// <summary>
        /// The amount of time each upgrade domain has to complete before the upgrade rolls back. The timeout can be in either hh:mm:ss
        /// or in d.hh:mm:ss.ms format.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The amount of time each upgrade domain has to complete before the upgrade rolls back. The timeout can be in either hh:mm:ss or in d.hh:mm:ss.ms format.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The amount of time each upgrade domain has to complete before the upgrade rolls back. The timeout can be in either hh:mm:ss or in d.hh:mm:ss.ms format.",
        SerializedName = @"upgradeDomainTimeout",
        PossibleTypes = new [] { typeof(string) })]
        public string MonitoringPolicyUpgradeDomainTimeout { get => _parametersBody.MonitoringPolicyUpgradeDomainTimeout ?? null; set => _parametersBody.MonitoringPolicyUpgradeDomainTimeout = value; }

        /// <summary>
        /// The amount of time the overall upgrade has to complete before the upgrade rolls back. The timeout can be in either hh:mm:ss
        /// or in d.hh:mm:ss.ms format.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The amount of time the overall upgrade has to complete before the upgrade rolls back. The timeout can be in either hh:mm:ss or in d.hh:mm:ss.ms format.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The amount of time the overall upgrade has to complete before the upgrade rolls back. The timeout can be in either hh:mm:ss or in d.hh:mm:ss.ms format.",
        SerializedName = @"upgradeTimeout",
        PossibleTypes = new [] { typeof(string) })]
        public string MonitoringPolicyUpgradeTimeout { get => _parametersBody.MonitoringPolicyUpgradeTimeout ?? null; set => _parametersBody.MonitoringPolicyUpgradeTimeout = value; }

        /// <summary>
        /// Custom Network Security Rules that are applied to the Virtual Network of the cluster.
        /// </summary>
        [global::System.Management.Automation.AllowEmptyCollection]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Custom Network Security Rules that are applied to the Virtual Network of the cluster.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Custom Network Security Rules that are applied to the Virtual Network of the cluster.",
        SerializedName = @"networkSecurityRules",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INetworkSecurityRule) })]
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INetworkSecurityRule[] NetworkSecurityRule { get => _parametersBody.NetworkSecurityRule?.ToArray() ?? null /* fixedArrayOf */; set => _parametersBody.NetworkSecurityRule = (value != null ? new System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INetworkSecurityRule>(value) : null); }

        /// <summary>
        /// when specified, will make the remote call, and return an AsyncOperationResponse, letting the remote operation continue
        /// asynchronously.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Run the command asynchronously")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter NoWait { get; set; }

        /// <summary>
        /// The instance of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.HttpPipeline" /> that the remote call will use.
        /// </summary>
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.HttpPipeline Pipeline { get; set; }

        /// <summary>The URI for the proxy server to use</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "The URI for the proxy server to use")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Runtime)]
        public global::System.Uri Proxy { get; set; }

        /// <summary>Credentials for a proxy server to use for the remote call</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Credentials for a proxy server to use for the remote call")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Runtime)]
        public global::System.Management.Automation.PSCredential ProxyCredential { get; set; }

        /// <summary>Use the default credentials for the proxy</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Use the default credentials for the proxy")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter ProxyUseDefaultCredentials { get; set; }

        /// <summary>
        /// Specify the resource id of a public IPv4 prefix that the load balancer will allocate a public IPv4 address from. This
        /// setting cannot be changed once the cluster is created.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Specify the resource id of a public IPv4 prefix that the load balancer will allocate a public IPv4 address from. This setting cannot be changed once the cluster is created.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specify the resource id of a public IPv4 prefix that the load balancer will allocate a public IPv4 address from. This setting cannot be changed once the cluster is created.",
        SerializedName = @"publicIPPrefixId",
        PossibleTypes = new [] { typeof(string) })]
        public string PublicIPPrefixId { get => _parametersBody.PublicIPPrefixId ?? null; set => _parametersBody.PublicIPPrefixId = value; }

        /// <summary>
        /// Specify the resource id of a public IPv6 prefix that the load balancer will allocate a public IPv6 address from. This
        /// setting cannot be changed once the cluster is created.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Specify the resource id of a public IPv6 prefix that the load balancer will allocate a public IPv6 address from. This setting cannot be changed once the cluster is created.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specify the resource id of a public IPv6 prefix that the load balancer will allocate a public IPv6 address from. This setting cannot be changed once the cluster is created.",
        SerializedName = @"publicIPv6PrefixId",
        PossibleTypes = new [] { typeof(string) })]
        public string PublicIPv6PrefixId { get => _parametersBody.PublicIPv6PrefixId ?? null; set => _parametersBody.PublicIPv6PrefixId = value; }

        /// <summary>Backing field for <see cref="ResourceGroupName" /> property.</summary>
        private string _resourceGroupName;

        /// <summary>The name of the resource group. The name is case insensitive.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The name of the resource group. The name is case insensitive.")]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The name of the resource group. The name is case insensitive.",
        SerializedName = @"resourceGroupName",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Path)]
        public string ResourceGroupName { get => this._resourceGroupName; set => this._resourceGroupName = value; }

        /// <summary>Service endpoints for subnets in the cluster.</summary>
        [global::System.Management.Automation.AllowEmptyCollection]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Service endpoints for subnets in the cluster.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Service endpoints for subnets in the cluster.",
        SerializedName = @"serviceEndpoints",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceEndpoint) })]
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceEndpoint[] ServiceEndpoint { get => _parametersBody.ServiceEndpoint?.ToArray() ?? null /* fixedArrayOf */; set => _parametersBody.ServiceEndpoint = (value != null ? new System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceEndpoint>(value) : null); }

        /// <summary>Sku Name.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "Sku Name.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Sku Name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("Basic", "Standard")]
        public string SkuName { get => _parametersBody.SkuName ?? null; set => _parametersBody.SkuName = value; }

        /// <summary>
        /// If specified, the node types for the cluster are created in this subnet instead of the default VNet. The **networkSecurityRules**
        /// specified for the cluster are also applied to this subnet. This setting cannot be changed once the cluster is created.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "If specified, the node types for the cluster are created in this subnet instead of the default VNet. The **networkSecurityRules** specified for the cluster are also applied to this subnet. This setting cannot be changed once the cluster is created.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"If specified, the node types for the cluster are created in this subnet instead of the default VNet. The **networkSecurityRules** specified for the cluster are also applied to this subnet. This setting cannot be changed once the cluster is created.",
        SerializedName = @"subnetId",
        PossibleTypes = new [] { typeof(string) })]
        public string SubnetId { get => _parametersBody.SubnetId ?? null; set => _parametersBody.SubnetId = value; }

        /// <summary>Backing field for <see cref="SubscriptionId" /> property.</summary>
        private string _subscriptionId;

        /// <summary>The ID of the target subscription. The value must be an UUID.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The ID of the target subscription. The value must be an UUID.")]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The ID of the target subscription. The value must be an UUID.",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.DefaultInfo(
        Name = @"",
        Description =@"",
        Script = @"(Get-AzContext).Subscription.Id",
        SetCondition = @"")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Path)]
        public string SubscriptionId { get => this._subscriptionId; set => this._subscriptionId = value; }

        /// <summary>Resource tags.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ExportAs(typeof(global::System.Collections.Hashtable))]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Resource tags.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource tags.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ITrackedResourceTags) })]
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ITrackedResourceTags Tag { get => _parametersBody.Tag ?? null /* object */; set => _parametersBody.Tag = value; }

        /// <summary>
        /// If true, then processes are forcefully restarted during upgrade even when the code version has not changed (the upgrade
        /// only changes configuration or data).
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "If true, then processes are forcefully restarted during upgrade even when the code version has not changed (the upgrade only changes configuration or data).")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"If true, then processes are forcefully restarted during upgrade even when the code version has not changed (the upgrade only changes configuration or data).",
        SerializedName = @"forceRestart",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter UpgradeDescriptionForceRestart { get => _parametersBody.UpgradeDescriptionForceRestart ?? default(global::System.Management.Automation.SwitchParameter); set => _parametersBody.UpgradeDescriptionForceRestart = value; }

        /// <summary>
        /// The maximum amount of time to block processing of an upgrade domain and prevent loss of availability when there are unexpected
        /// issues.When this timeout expires, processing of the upgrade domain will proceed regardless of availability loss issues.The
        /// timeout is reset at the start of each upgrade domain. The timeout can be in either hh:mm:ss or in d.hh:mm:ss.ms format.This
        /// value must be between 00:00:00 and 49710.06:28:15 (unsigned 32 bit integer for seconds)
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The maximum amount of time to block processing of an upgrade domain and prevent loss of availability when there are unexpected issues.When this timeout expires, processing of the upgrade domain will proceed regardless of availability loss issues.The timeout is reset at the start of each upgrade domain. The timeout can be in either hh:mm:ss or in d.hh:mm:ss.ms format.This value must be between 00:00:00 and 49710.06:28:15 (unsigned 32 bit integer for seconds)")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The maximum amount of time to block processing of an upgrade domain and prevent loss of availability when there are unexpected issues.When this timeout expires, processing of the upgrade domain will proceed regardless of availability loss issues.The timeout is reset at the start of each upgrade domain. The timeout can be in either hh:mm:ss or in d.hh:mm:ss.ms format.This value must be between 00:00:00 and 49710.06:28:15 (unsigned 32 bit integer for seconds)",
        SerializedName = @"upgradeReplicaSetCheckTimeout",
        PossibleTypes = new [] { typeof(string) })]
        public string UpgradeDescriptionUpgradeReplicaSetCheckTimeout { get => _parametersBody.UpgradeDescriptionUpgradeReplicaSetCheckTimeout ?? null; set => _parametersBody.UpgradeDescriptionUpgradeReplicaSetCheckTimeout = value; }

        /// <summary>
        /// For new clusters, this parameter indicates that it uses Bring your own VNet, but the subnet is specified at node type
        /// level; and for such clusters, the subnetId property is required for node types.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "For new clusters, this parameter indicates that it uses Bring your own VNet, but the subnet is specified at node type level; and for such clusters, the subnetId property is required for node types.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"For new clusters, this parameter indicates that it uses Bring your own VNet, but the subnet is specified at node type level; and for such clusters, the subnetId property is required for node types.",
        SerializedName = @"useCustomVnet",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter UseCustomVnet { get => _parametersBody.UseCustomVnet ?? default(global::System.Management.Automation.SwitchParameter); set => _parametersBody.UseCustomVnet = value; }

        /// <summary>
        /// The VM image the node types are configured with. This property controls the Service Fabric component packages to be used
        /// for the cluster. Allowed values are: 'Windows'. The default value is 'Windows'.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The VM image the node types are configured with. This property controls the Service Fabric component packages to be used for the cluster. Allowed values are: 'Windows'. The default value is 'Windows'.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The VM image the node types are configured with. This property controls the Service Fabric component packages to be used for the cluster. Allowed values are: 'Windows'. The default value is 'Windows'.",
        SerializedName = @"VMImage",
        PossibleTypes = new [] { typeof(string) })]
        public string VMImage { get => _parametersBody.VMImage ?? null; set => _parametersBody.VMImage = value; }

        /// <summary>Indicates if the cluster has zone resiliency.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Indicates if the cluster has zone resiliency.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicates if the cluster has zone resiliency.",
        SerializedName = @"zonalResiliency",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter ZonalResiliency { get => _parametersBody.ZonalResiliency ?? default(global::System.Management.Automation.SwitchParameter); set => _parametersBody.ZonalResiliency = value; }

        /// <summary>Indicates the update mode for Cross Az clusters.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Indicates the update mode for Cross Az clusters.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicates the update mode for Cross Az clusters.",
        SerializedName = @"zonalUpdateMode",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("Standard", "Fast")]
        public string ZonalUpdateMode { get => _parametersBody.ZonalUpdateMode ?? null; set => _parametersBody.ZonalUpdateMode = value; }

        /// <summary>
        /// <c>overrideOnDefault</c> will be called before the regular onDefault has been processed, allowing customization of what
        /// happens on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IErrorResponse">Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IErrorResponse</see>
        /// from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onDefault method should be processed, or if the method should
        /// return immediately (set to true to skip further processing )</param>

        partial void overrideOnDefault(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IErrorResponse> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// <c>overrideOnOk</c> will be called before the regular onOk has been processed, allowing customization of what happens
        /// on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedCluster">Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedCluster</see>
        /// from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onOk method should be processed, or if the method should return
        /// immediately (set to true to skip further processing )</param>

        partial void overrideOnOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedCluster> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// (overrides the default BeginProcessing method in global::System.Management.Automation.PSCmdlet)
        /// </summary>
        protected override void BeginProcessing()
        {
            var telemetryId = Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Module.Instance.GetTelemetryId.Invoke();
            if (telemetryId != "" && telemetryId != "internal")
            {
                __correlationId = telemetryId;
            }
            Module.Instance.SetProxyConfiguration(Proxy, ProxyCredential, ProxyUseDefaultCredentials);
            if (Break)
            {
                Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.AttachDebugger.Break();
            }
            ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Events.CmdletBeginProcessing).Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
        }

        /// <summary>Creates a duplicate instance of this cmdlet (via JSON serialization).</summary>
        /// <returns>
        /// a duplicate instance of SetAzServiceFabricManagedClustersManagedCluster_UpdateExpanded
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Cmdlets.SetAzServiceFabricManagedClustersManagedCluster_UpdateExpanded Clone()
        {
            var clone = new SetAzServiceFabricManagedClustersManagedCluster_UpdateExpanded();
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
            clone._parametersBody = this._parametersBody;
            clone.SubscriptionId = this.SubscriptionId;
            clone.ResourceGroupName = this.ResourceGroupName;
            clone.ClusterName = this.ClusterName;
            return clone;
        }

        /// <summary>Performs clean-up after the command execution</summary>
        protected override void EndProcessing()
        {
            var telemetryInfo = Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Module.Instance.GetTelemetryInfo?.Invoke(__correlationId);
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
         async global::System.Threading.Tasks.Task Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener.Signal(string id, global::System.Threading.CancellationToken token, global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.EventData> messageData)
        {
            using( NoSynchronizationContext )
            {
                if (token.IsCancellationRequested)
                {
                    return ;
                }

                switch ( id )
                {
                    case Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Events.Verbose:
                    {
                        WriteVerbose($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Events.Warning:
                    {
                        WriteWarning($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Events.Information:
                    {
                        // When an operation supports asjob, Information messages must go thru verbose.
                        WriteVerbose($"INFORMATION: {(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Events.Debug:
                    {
                        WriteDebug($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Events.Error:
                    {
                        WriteError(new global::System.Management.Automation.ErrorRecord( new global::System.Exception(messageData().Message), string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null ) );
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Events.Progress:
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
                    case Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Events.DelayBeforePolling:
                    {
                        var data = messageData();
                        if (true == MyInvocation?.BoundParameters?.ContainsKey("NoWait"))
                        {
                            if (data.ResponseMessage is System.Net.Http.HttpResponseMessage response)
                            {
                                var asyncOperation = response.GetFirstHeader(@"Azure-AsyncOperation");
                                var location = response.GetFirstHeader(@"Location");
                                var uri = global::System.String.IsNullOrEmpty(asyncOperation) ? global::System.String.IsNullOrEmpty(location) ? response.RequestMessage.RequestUri.AbsoluteUri : location : asyncOperation;
                                WriteObject(new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.PowerShell.AsyncOperationResponse { Target = uri });
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
                await Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Module.Instance.Signal(id, token, messageData, (i, t, m) => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener)this).Signal(i, t, () => Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.EventDataConverter.ConvertFrom(m()) as Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.EventData), InvocationInformation, this.ParameterSetName, __correlationId, __processRecordId, null );
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
            ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Events.CmdletProcessRecordStart).Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
            __processRecordId = System.Guid.NewGuid().ToString();
            try
            {
                // work
                if (ShouldProcess($"Call remote 'ManagedClustersCreateOrUpdate' operation"))
                {
                    if (true == MyInvocation?.BoundParameters?.ContainsKey("AsJob"))
                    {
                        var instance = this.Clone();
                        var job = new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.PowerShell.AsyncJob(instance, this.MyInvocation.Line, this.MyInvocation.MyCommand.Name, this._cancellationTokenSource.Token, this._cancellationTokenSource.Cancel);
                        JobRepository.Add(job);
                        var task = instance.ProcessRecordAsync();
                        job.Monitor(task);
                        WriteObject(job);
                    }
                    else
                    {
                        using( var asyncCommandRuntime = new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.PowerShell.AsyncCommandRuntime(this, ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener)this).Token) )
                        {
                            asyncCommandRuntime.Wait( ProcessRecordAsync(),((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener)this).Token);
                        }
                    }
                }
            }
            catch (global::System.AggregateException aggregateException)
            {
                // unroll the inner exceptions to get the root cause
                foreach( var innerException in aggregateException.Flatten().InnerExceptions )
                {
                    ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Events.CmdletException, $"{innerException.GetType().Name} - {innerException.Message} : {innerException.StackTrace}").Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    // Write exception out to error channel.
                    WriteError( new global::System.Management.Automation.ErrorRecord(innerException,string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null) );
                }
            }
            catch (global::System.Exception exception) when ((exception as System.Management.Automation.PipelineStoppedException)== null || (exception as System.Management.Automation.PipelineStoppedException).InnerException != null)
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Events.CmdletException, $"{exception.GetType().Name} - {exception.Message} : {exception.StackTrace}").Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                // Write exception out to error channel.
                WriteError( new global::System.Management.Automation.ErrorRecord(exception,string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null) );
            }
            finally
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Events.CmdletProcessRecordEnd).Wait();
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
                await ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Events.CmdletGetPipeline); if( ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                Pipeline = Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Module.Instance.CreatePipeline(InvocationInformation, __correlationId, __processRecordId, this.ParameterSetName, this.ExtensibleParameters);
                if (null != HttpPipelinePrepend)
                {
                    Pipeline.Prepend((this.CommandRuntime as Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelinePrepend) ?? HttpPipelinePrepend);
                }
                if (null != HttpPipelineAppend)
                {
                    Pipeline.Append((this.CommandRuntime as Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelineAppend) ?? HttpPipelineAppend);
                }
                // get the client instance
                try
                {
                    await ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Events.CmdletBeforeAPICall); if( ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    await this.Client.ManagedClustersCreateOrUpdate(SubscriptionId, ResourceGroupName, ClusterName, _parametersBody, onOk, onDefault, this, Pipeline, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.SerializationMode.IncludeCreate);
                    await ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Events.CmdletAfterAPICall); if( ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                }
                catch (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.UndeclaredResponseException urexception)
                {
                    WriteError(new global::System.Management.Automation.ErrorRecord(urexception, urexception.StatusCode.ToString(), global::System.Management.Automation.ErrorCategory.InvalidOperation, new { SubscriptionId=SubscriptionId,ResourceGroupName=ResourceGroupName,ClusterName=ClusterName})
                    {
                      ErrorDetails = new global::System.Management.Automation.ErrorDetails(urexception.Message) { RecommendedAction = urexception.Action }
                    });
                }
                finally
                {
                    await ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Events.CmdletProcessRecordAsyncEnd);
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetAzServiceFabricManagedClustersManagedCluster_UpdateExpanded" /> cmdlet
        /// class.
        /// </summary>
        public SetAzServiceFabricManagedClustersManagedCluster_UpdateExpanded()
        {

        }

        /// <summary>Interrupts currently running code within the command.</summary>
        protected override void StopProcessing()
        {
            ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener)this).Cancel();
            base.StopProcessing();
        }

        /// <param name="sendToPipeline"></param>
        new protected void WriteObject(object sendToPipeline)
        {
            Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Module.Instance.SanitizeOutput?.Invoke(sendToPipeline, __correlationId);
            base.WriteObject(sendToPipeline);
        }

        /// <param name="sendToPipeline"></param>
        /// <param name="enumerateCollection"></param>
        new protected void WriteObject(object sendToPipeline, bool enumerateCollection)
        {
            Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Module.Instance.SanitizeOutput?.Invoke(sendToPipeline, __correlationId);
            base.WriteObject(sendToPipeline, enumerateCollection);
        }

        /// <summary>
        /// a delegate that is called when the remote service returns default (any response code not handled elsewhere).
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IErrorResponse">Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IErrorResponse</see>
        /// from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onDefault(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IErrorResponse> response)
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
                    var ex = new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IErrorResponse>(responseMessage, await response);
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
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedCluster">Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedCluster</see>
        /// from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedCluster> response)
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
                // (await response) // should be Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedCluster
                var result = (await response);
                WriteObject(result, false);
            }
        }
    }
}