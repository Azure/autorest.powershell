// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>Describes the managed cluster resource properties.</summary>
    public partial class ManagedClusterProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterProperties,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal
    {

        /// <summary>Backing field for <see cref="AddonFeature" /> property.</summary>
        private System.Collections.Generic.List<string> _addonFeature;

        /// <summary>List of add-on features to enable on the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> AddonFeature { get => this._addonFeature; set => this._addonFeature = value; }

        /// <summary>Backing field for <see cref="AdminPassword" /> property.</summary>
        private System.Security.SecureString _adminPassword;

        /// <summary>VM admin user password.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public System.Security.SecureString AdminPassword { get => this._adminPassword; set => this._adminPassword = value; }

        /// <summary>Backing field for <see cref="AdminUserName" /> property.</summary>
        private string _adminUserName;

        /// <summary>VM admin user name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string AdminUserName { get => this._adminUserName; set => this._adminUserName = value; }

        /// <summary>Backing field for <see cref="AllocatedOutboundPort" /> property.</summary>
        private int? _allocatedOutboundPort;

        /// <summary>
        /// The number of outbound ports allocated for SNAT for each node in the backend pool of the default load balancer. The default
        /// value is 0 which provides dynamic port allocation based on pool size.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public int? AllocatedOutboundPort { get => this._allocatedOutboundPort; set => this._allocatedOutboundPort = value; }

        /// <summary>Backing field for <see cref="AllowRdpAccess" /> property.</summary>
        private bool? _allowRdpAccess;

        /// <summary>
        /// Setting this to true enables RDP access to the VM. The default NSG rule opens RDP port to Internet which can be overridden
        /// with custom Network Security Rules. The default value for this setting is false.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public bool? AllowRdpAccess { get => this._allowRdpAccess; set => this._allowRdpAccess = value; }

        /// <summary>Number of unused versions per application type to keep.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public int? ApplicationTypeVersionCleanupPolicyMaxUnusedVersionsToKeep { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationTypeVersionsCleanupPolicyInternal)ApplicationTypeVersionsCleanupPolicy).MaxUnusedVersionsToKeep; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationTypeVersionsCleanupPolicyInternal)ApplicationTypeVersionsCleanupPolicy).MaxUnusedVersionsToKeep = value ?? default(int); }

        /// <summary>Backing field for <see cref="ApplicationTypeVersionsCleanupPolicy" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationTypeVersionsCleanupPolicy _applicationTypeVersionsCleanupPolicy;

        /// <summary>The policy used to clean up unused versions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationTypeVersionsCleanupPolicy ApplicationTypeVersionsCleanupPolicy { get => (this._applicationTypeVersionsCleanupPolicy = this._applicationTypeVersionsCleanupPolicy ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ApplicationTypeVersionsCleanupPolicy()); set => this._applicationTypeVersionsCleanupPolicy = value; }

        /// <summary>Backing field for <see cref="AutoGeneratedDomainNameLabelScope" /> property.</summary>
        private string _autoGeneratedDomainNameLabelScope;

        /// <summary>
        /// This property is the entry point to using a public CA cert for your cluster cert. It specifies the level of reuse allowed
        /// for the custom FQDN created, matching the subject of the public CA cert.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string AutoGeneratedDomainNameLabelScope { get => this._autoGeneratedDomainNameLabelScope; set => this._autoGeneratedDomainNameLabelScope = value; }

        /// <summary>Backing field for <see cref="AuxiliarySubnet" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISubnet> _auxiliarySubnet;

        /// <summary>Auxiliary subnets for the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISubnet> AuxiliarySubnet { get => this._auxiliarySubnet; set => this._auxiliarySubnet = value; }

        /// <summary>Backing field for <see cref="AzureActiveDirectory" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IAzureActiveDirectory _azureActiveDirectory;

        /// <summary>The AAD authentication settings of the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IAzureActiveDirectory AzureActiveDirectory { get => (this._azureActiveDirectory = this._azureActiveDirectory ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.AzureActiveDirectory()); set => this._azureActiveDirectory = value; }

        /// <summary>Azure active directory client application id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string AzureActiveDirectoryClientApplication { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IAzureActiveDirectoryInternal)AzureActiveDirectory).ClientApplication; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IAzureActiveDirectoryInternal)AzureActiveDirectory).ClientApplication = value ?? null; }

        /// <summary>Azure active directory cluster application id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string AzureActiveDirectoryClusterApplication { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IAzureActiveDirectoryInternal)AzureActiveDirectory).ClusterApplication; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IAzureActiveDirectoryInternal)AzureActiveDirectory).ClusterApplication = value ?? null; }

        /// <summary>Azure active directory tenant id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string AzureActiveDirectoryTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IAzureActiveDirectoryInternal)AzureActiveDirectory).TenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IAzureActiveDirectoryInternal)AzureActiveDirectory).TenantId = value ?? null; }

        /// <summary>Backing field for <see cref="Client" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClientCertificate> _client;

        /// <summary>Client certificates that are allowed to manage the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClientCertificate> Client { get => this._client; set => this._client = value; }

        /// <summary>Backing field for <see cref="ClientConnectionPort" /> property.</summary>
        private int? _clientConnectionPort;

        /// <summary>The port used for client connections to the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public int? ClientConnectionPort { get => this._clientConnectionPort; set => this._clientConnectionPort = value; }

        /// <summary>Backing field for <see cref="ClusterCertificateThumbprint" /> property.</summary>
        private System.Collections.Generic.List<string> _clusterCertificateThumbprint;

        /// <summary>List of thumbprints of the cluster certificates.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> ClusterCertificateThumbprint { get => this._clusterCertificateThumbprint; }

        /// <summary>Backing field for <see cref="ClusterCodeVersion" /> property.</summary>
        private string _clusterCodeVersion;

        /// <summary>
        /// The Service Fabric runtime version of the cluster. This property is required when **clusterUpgradeMode** is set to 'Manual'.
        /// To get list of available Service Fabric versions for new clusters use [ClusterVersion API](./ClusterVersion.md). To get
        /// the list of available version for existing clusters use **availableClusterVersions**.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string ClusterCodeVersion { get => this._clusterCodeVersion; set => this._clusterCodeVersion = value; }

        /// <summary>Backing field for <see cref="ClusterId" /> property.</summary>
        private string _clusterId;

        /// <summary>A service generated unique identifier for the cluster resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string ClusterId { get => this._clusterId; }

        /// <summary>Backing field for <see cref="ClusterState" /> property.</summary>
        private string _clusterState;

        /// <summary>The current state of the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string ClusterState { get => this._clusterState; }

        /// <summary>Backing field for <see cref="ClusterUpgradeCadence" /> property.</summary>
        private string _clusterUpgradeCadence;

        /// <summary>
        /// Indicates when new cluster runtime version upgrades will be applied after they are released. By default is Wave0. Only
        /// applies when **clusterUpgradeMode** is set to 'Automatic'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string ClusterUpgradeCadence { get => this._clusterUpgradeCadence; set => this._clusterUpgradeCadence = value; }

        /// <summary>Backing field for <see cref="ClusterUpgradeMode" /> property.</summary>
        private string _clusterUpgradeMode;

        /// <summary>
        /// The upgrade mode of the cluster when new Service Fabric runtime version is available.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string ClusterUpgradeMode { get => this._clusterUpgradeMode; set => this._clusterUpgradeMode = value; }

        /// <summary>Backing field for <see cref="DdosProtectionPlanId" /> property.</summary>
        private string _ddosProtectionPlanId;

        /// <summary>
        /// Specify the resource id of a DDoS network protection plan that will be associated with the virtual network of the cluster.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string DdosProtectionPlanId { get => this._ddosProtectionPlanId; set => this._ddosProtectionPlanId = value; }

        /// <summary>
        /// The maximum allowed percentage of applications health degradation allowed during cluster upgrades.
        /// The delta is measured between the state of the applications at the beginning of upgrade and the state of the applications
        /// at the time of the health evaluation.
        /// The check is performed after every upgrade domain upgrade completion to make sure the global state of the cluster is within
        /// tolerated limits. System services are not included in this.
        /// NOTE: This value will overwrite the value specified in properties.UpgradeDescription.HealthPolicy.MaxPercentUnhealthyApplications
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public int? DeltaHealthPolicyMaxPercentDeltaUnhealthyApplication { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)UpgradeDescription).DeltaHealthPolicyMaxPercentDeltaUnhealthyApplication; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)UpgradeDescription).DeltaHealthPolicyMaxPercentDeltaUnhealthyApplication = value ?? default(int); }

        /// <summary>
        /// The maximum allowed percentage of nodes health degradation allowed during cluster upgrades.
        /// The delta is measured between the state of the nodes at the beginning of upgrade and the state of the nodes at the time
        /// of the health evaluation.
        /// The check is performed after every upgrade domain upgrade completion to make sure the global state of the cluster is within
        /// tolerated limits.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public int? DeltaHealthPolicyMaxPercentDeltaUnhealthyNode { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)UpgradeDescription).DeltaHealthPolicyMaxPercentDeltaUnhealthyNode; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)UpgradeDescription).DeltaHealthPolicyMaxPercentDeltaUnhealthyNode = value ?? default(int); }

        /// <summary>
        /// The maximum allowed percentage of upgrade domain nodes health degradation allowed during cluster upgrades.
        /// The delta is measured between the state of the upgrade domain nodes at the beginning of upgrade and the state of the upgrade
        /// domain nodes at the time of the health evaluation.
        /// The check is performed after every upgrade domain upgrade completion for all completed upgrade domains to make sure the
        /// state of the upgrade domains is within tolerated limits.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public int? DeltaHealthPolicyMaxPercentUpgradeDomainDeltaUnhealthyNode { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)UpgradeDescription).DeltaHealthPolicyMaxPercentUpgradeDomainDeltaUnhealthyNode; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)UpgradeDescription).DeltaHealthPolicyMaxPercentUpgradeDomainDeltaUnhealthyNode = value ?? default(int); }

        /// <summary>Backing field for <see cref="DnsName" /> property.</summary>
        private string _dnsName;

        /// <summary>The cluster dns name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string DnsName { get => this._dnsName; set => this._dnsName = value; }

        /// <summary>Backing field for <see cref="EnableAutoOSUpgrade" /> property.</summary>
        private bool? _enableAutoOSUpgrade;

        /// <summary>
        /// Enables automatic OS upgrade for node types created using OS images with version 'latest'. The default value for this
        /// setting is false.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public bool? EnableAutoOSUpgrade { get => this._enableAutoOSUpgrade; set => this._enableAutoOSUpgrade = value; }

        /// <summary>Backing field for <see cref="EnableHttpGatewayExclusiveAuthMode" /> property.</summary>
        private bool? _enableHttpGatewayExclusiveAuthMode;

        /// <summary>
        /// If true, token-based authentication is not allowed on the HttpGatewayEndpoint. This is required to support TLS versions
        /// 1.3 and above. If token-based authentication is used, HttpGatewayTokenAuthConnectionPort must be defined.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public bool? EnableHttpGatewayExclusiveAuthMode { get => this._enableHttpGatewayExclusiveAuthMode; set => this._enableHttpGatewayExclusiveAuthMode = value; }

        /// <summary>Backing field for <see cref="EnableIpv6" /> property.</summary>
        private bool? _enableIpv6;

        /// <summary>
        /// Setting this to true creates IPv6 address space for the default VNet used by the cluster. This setting cannot be changed
        /// once the cluster is created. The default value for this setting is false.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public bool? EnableIpv6 { get => this._enableIpv6; set => this._enableIpv6 = value; }

        /// <summary>Backing field for <see cref="EnableOutboundOnlyNodeType" /> property.</summary>
        private bool? _enableOutboundOnlyNodeType;

        /// <summary>
        /// Enable the creation of node types with only outbound traffic enabled. If set, a separate load balancer backend pool will
        /// be created for node types with inbound traffic enabled. Can only be set at the time of cluster creation.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public bool? EnableOutboundOnlyNodeType { get => this._enableOutboundOnlyNodeType; set => this._enableOutboundOnlyNodeType = value; }

        /// <summary>Backing field for <see cref="EnableServicePublicIP" /> property.</summary>
        private bool? _enableServicePublicIP;

        /// <summary>
        /// Setting this to true will link the IPv4 address as the ServicePublicIP of the IPv6 address. It can only be set to True
        /// if IPv6 is enabled on the cluster.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public bool? EnableServicePublicIP { get => this._enableServicePublicIP; set => this._enableServicePublicIP = value; }

        /// <summary>Backing field for <see cref="FabricSetting" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISettingsSectionDescription> _fabricSetting;

        /// <summary>The list of custom fabric settings to configure the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISettingsSectionDescription> FabricSetting { get => this._fabricSetting; set => this._fabricSetting = value; }

        /// <summary>Backing field for <see cref="Fqdn" /> property.</summary>
        private string _fqdn;

        /// <summary>
        /// The fully qualified domain name associated with the public load balancer of the cluster.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string Fqdn { get => this._fqdn; }

        /// <summary>
        /// The maximum allowed percentage of unhealthy applications before reporting an error. For example, to allow 10% of applications
        /// to be unhealthy, this value would be 10.
        /// The percentage represents the maximum tolerated percentage of applications that can be unhealthy before the cluster is
        /// considered in error.
        /// If the percentage is respected but there is at least one unhealthy application, the health is evaluated as Warning.
        /// This is calculated by dividing the number of unhealthy applications over the total number of application instances in
        /// the cluster, excluding applications of application types that are included in the ApplicationTypeHealthPolicyMap.
        /// The computation rounds up to tolerate one failure on small numbers of applications. Default percentage is zero.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public int? HealthPolicyMaxPercentUnhealthyApplication { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)UpgradeDescription).HealthPolicyMaxPercentUnhealthyApplication; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)UpgradeDescription).HealthPolicyMaxPercentUnhealthyApplication = value ?? default(int); }

        /// <summary>
        /// The maximum allowed percentage of unhealthy nodes before reporting an error. For example, to allow 10% of nodes to be
        /// unhealthy, this value would be 10.
        /// The percentage represents the maximum tolerated percentage of nodes that can be unhealthy before the cluster is considered
        /// in error.
        /// If the percentage is respected but there is at least one unhealthy node, the health is evaluated as Warning.
        /// The percentage is calculated by dividing the number of unhealthy nodes over the total number of nodes in the cluster.
        /// The computation rounds up to tolerate one failure on small numbers of nodes. Default percentage is zero.
        /// In large clusters, some nodes will always be down or out for repairs, so this percentage should be configured to tolerate
        /// that.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public int? HealthPolicyMaxPercentUnhealthyNode { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)UpgradeDescription).HealthPolicyMaxPercentUnhealthyNode; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)UpgradeDescription).HealthPolicyMaxPercentUnhealthyNode = value ?? default(int); }

        /// <summary>Backing field for <see cref="HttpGatewayConnectionPort" /> property.</summary>
        private int? _httpGatewayConnectionPort;

        /// <summary>The port used for HTTP connections to the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public int? HttpGatewayConnectionPort { get => this._httpGatewayConnectionPort; set => this._httpGatewayConnectionPort = value; }

        /// <summary>Backing field for <see cref="HttpGatewayTokenAuthConnectionPort" /> property.</summary>
        private int? _httpGatewayTokenAuthConnectionPort;

        /// <summary>
        /// The port used for token-auth based HTTPS connections to the cluster. Cannot be set to the same port as HttpGatewayEndpoint.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public int? HttpGatewayTokenAuthConnectionPort { get => this._httpGatewayTokenAuthConnectionPort; set => this._httpGatewayTokenAuthConnectionPort = value; }

        /// <summary>Backing field for <see cref="IPTag" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPTag> _iPTag;

        /// <summary>
        /// The list of IP tags associated with the default public IP address of the cluster.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPTag> IPTag { get => this._iPTag; set => this._iPTag = value; }

        /// <summary>Backing field for <see cref="Ipv4Address" /> property.</summary>
        private string _ipv4Address;

        /// <summary>The IPv4 address associated with the public load balancer of the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string Ipv4Address { get => this._ipv4Address; }

        /// <summary>Backing field for <see cref="Ipv6Address" /> property.</summary>
        private string _ipv6Address;

        /// <summary>IPv6 address for the cluster if IPv6 is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string Ipv6Address { get => this._ipv6Address; }

        /// <summary>Backing field for <see cref="LoadBalancingRule" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ILoadBalancingRule> _loadBalancingRule;

        /// <summary>
        /// Load balancing rules that are applied to the public load balancer of the cluster.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ILoadBalancingRule> LoadBalancingRule { get => this._loadBalancingRule; set => this._loadBalancingRule = value; }

        /// <summary>Internal Acessors for ApplicationTypeVersionsCleanupPolicy</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationTypeVersionsCleanupPolicy Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal.ApplicationTypeVersionsCleanupPolicy { get => (this._applicationTypeVersionsCleanupPolicy = this._applicationTypeVersionsCleanupPolicy ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ApplicationTypeVersionsCleanupPolicy()); set { {_applicationTypeVersionsCleanupPolicy = value;} } }

        /// <summary>Internal Acessors for AzureActiveDirectory</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IAzureActiveDirectory Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal.AzureActiveDirectory { get => (this._azureActiveDirectory = this._azureActiveDirectory ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.AzureActiveDirectory()); set { {_azureActiveDirectory = value;} } }

        /// <summary>Internal Acessors for ClusterCertificateThumbprint</summary>
        System.Collections.Generic.List<string> Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal.ClusterCertificateThumbprint { get => this._clusterCertificateThumbprint; set { {_clusterCertificateThumbprint = value;} } }

        /// <summary>Internal Acessors for ClusterId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal.ClusterId { get => this._clusterId; set { {_clusterId = value;} } }

        /// <summary>Internal Acessors for ClusterState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal.ClusterState { get => this._clusterState; set { {_clusterState = value;} } }

        /// <summary>Internal Acessors for Fqdn</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal.Fqdn { get => this._fqdn; set { {_fqdn = value;} } }

        /// <summary>Internal Acessors for Ipv4Address</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal.Ipv4Address { get => this._ipv4Address; set { {_ipv4Address = value;} } }

        /// <summary>Internal Acessors for Ipv6Address</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal.Ipv6Address { get => this._ipv6Address; set { {_ipv6Address = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for UpgradeDescription</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicy Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal.UpgradeDescription { get => (this._upgradeDescription = this._upgradeDescription ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ClusterUpgradePolicy()); set { {_upgradeDescription = value;} } }

        /// <summary>Internal Acessors for UpgradeDescriptionDeltaHealthPolicy</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradeDeltaHealthPolicy Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal.UpgradeDescriptionDeltaHealthPolicy { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)UpgradeDescription).DeltaHealthPolicy; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)UpgradeDescription).DeltaHealthPolicy = value ?? null /* model class */; }

        /// <summary>Internal Acessors for UpgradeDescriptionHealthPolicy</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterHealthPolicy Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal.UpgradeDescriptionHealthPolicy { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)UpgradeDescription).HealthPolicy; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)UpgradeDescription).HealthPolicy = value ?? null /* model class */; }

        /// <summary>Internal Acessors for UpgradeDescriptionMonitoringPolicy</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterMonitoringPolicy Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal.UpgradeDescriptionMonitoringPolicy { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)UpgradeDescription).MonitoringPolicy; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)UpgradeDescription).MonitoringPolicy = value ?? null /* model class */; }

        /// <summary>
        /// The amount of time to retry health evaluation when the application or cluster is unhealthy before the upgrade rolls back.
        /// The timeout can be in either hh:mm:ss or in d.hh:mm:ss.ms format.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string MonitoringPolicyHealthCheckRetryTimeout { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)UpgradeDescription).MonitoringPolicyHealthCheckRetryTimeout; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)UpgradeDescription).MonitoringPolicyHealthCheckRetryTimeout = value ?? null; }

        /// <summary>
        /// The amount of time that the application or cluster must remain healthy before the upgrade proceeds to the next upgrade
        /// domain. The duration can be in either hh:mm:ss or in d.hh:mm:ss.ms format.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string MonitoringPolicyHealthCheckStableDuration { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)UpgradeDescription).MonitoringPolicyHealthCheckStableDuration; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)UpgradeDescription).MonitoringPolicyHealthCheckStableDuration = value ?? null; }

        /// <summary>
        /// The length of time to wait after completing an upgrade domain before performing health checks. The duration can be in
        /// either hh:mm:ss or in d.hh:mm:ss.ms format.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string MonitoringPolicyHealthCheckWaitDuration { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)UpgradeDescription).MonitoringPolicyHealthCheckWaitDuration; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)UpgradeDescription).MonitoringPolicyHealthCheckWaitDuration = value ?? null; }

        /// <summary>
        /// The amount of time each upgrade domain has to complete before the upgrade rolls back. The timeout can be in either hh:mm:ss
        /// or in d.hh:mm:ss.ms format.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string MonitoringPolicyUpgradeDomainTimeout { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)UpgradeDescription).MonitoringPolicyUpgradeDomainTimeout; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)UpgradeDescription).MonitoringPolicyUpgradeDomainTimeout = value ?? null; }

        /// <summary>
        /// The amount of time the overall upgrade has to complete before the upgrade rolls back. The timeout can be in either hh:mm:ss
        /// or in d.hh:mm:ss.ms format.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string MonitoringPolicyUpgradeTimeout { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)UpgradeDescription).MonitoringPolicyUpgradeTimeout; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)UpgradeDescription).MonitoringPolicyUpgradeTimeout = value ?? null; }

        /// <summary>Backing field for <see cref="NetworkSecurityRule" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INetworkSecurityRule> _networkSecurityRule;

        /// <summary>
        /// Custom Network Security Rules that are applied to the Virtual Network of the cluster.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INetworkSecurityRule> NetworkSecurityRule { get => this._networkSecurityRule; set => this._networkSecurityRule = value; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>The provisioning state of the managed cluster resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="PublicIPPrefixId" /> property.</summary>
        private string _publicIPPrefixId;

        /// <summary>
        /// Specify the resource id of a public IPv4 prefix that the load balancer will allocate a public IPv4 address from. This
        /// setting cannot be changed once the cluster is created.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string PublicIPPrefixId { get => this._publicIPPrefixId; set => this._publicIPPrefixId = value; }

        /// <summary>Backing field for <see cref="PublicIPv6PrefixId" /> property.</summary>
        private string _publicIPv6PrefixId;

        /// <summary>
        /// Specify the resource id of a public IPv6 prefix that the load balancer will allocate a public IPv6 address from. This
        /// setting cannot be changed once the cluster is created.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string PublicIPv6PrefixId { get => this._publicIPv6PrefixId; set => this._publicIPv6PrefixId = value; }

        /// <summary>Backing field for <see cref="ServiceEndpoint" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceEndpoint> _serviceEndpoint;

        /// <summary>Service endpoints for subnets in the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceEndpoint> ServiceEndpoint { get => this._serviceEndpoint; set => this._serviceEndpoint = value; }

        /// <summary>Backing field for <see cref="SubnetId" /> property.</summary>
        private string _subnetId;

        /// <summary>
        /// If specified, the node types for the cluster are created in this subnet instead of the default VNet. The **networkSecurityRules**
        /// specified for the cluster are also applied to this subnet. This setting cannot be changed once the cluster is created.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string SubnetId { get => this._subnetId; set => this._subnetId = value; }

        /// <summary>Backing field for <see cref="UpgradeDescription" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicy _upgradeDescription;

        /// <summary>The policy to use when upgrading the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicy UpgradeDescription { get => (this._upgradeDescription = this._upgradeDescription ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ClusterUpgradePolicy()); set => this._upgradeDescription = value; }

        /// <summary>
        /// If true, then processes are forcefully restarted during upgrade even when the code version has not changed (the upgrade
        /// only changes configuration or data).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public bool? UpgradeDescriptionForceRestart { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)UpgradeDescription).ForceRestart; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)UpgradeDescription).ForceRestart = value ?? default(bool); }

        /// <summary>
        /// The maximum amount of time to block processing of an upgrade domain and prevent loss of availability when there are unexpected
        /// issues.
        /// When this timeout expires, processing of the upgrade domain will proceed regardless of availability loss issues.
        /// The timeout is reset at the start of each upgrade domain. The timeout can be in either hh:mm:ss or in d.hh:mm:ss.ms format.
        /// This value must be between 00:00:00 and 49710.06:28:15 (unsigned 32 bit integer for seconds)
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string UpgradeDescriptionUpgradeReplicaSetCheckTimeout { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)UpgradeDescription).UpgradeReplicaSetCheckTimeout; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)UpgradeDescription).UpgradeReplicaSetCheckTimeout = value ?? null; }

        /// <summary>Backing field for <see cref="UseCustomVnet" /> property.</summary>
        private bool? _useCustomVnet;

        /// <summary>
        /// For new clusters, this parameter indicates that it uses Bring your own VNet, but the subnet is specified at node type
        /// level; and for such clusters, the subnetId property is required for node types.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public bool? UseCustomVnet { get => this._useCustomVnet; set => this._useCustomVnet = value; }

        /// <summary>Backing field for <see cref="VMImage" /> property.</summary>
        private string _vMImage;

        /// <summary>
        /// The VM image the node types are configured with. This property controls the Service Fabric component packages to be used
        /// for the cluster. Allowed values are: 'Windows'. The default value is 'Windows'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string VMImage { get => this._vMImage; set => this._vMImage = value; }

        /// <summary>Backing field for <see cref="ZonalResiliency" /> property.</summary>
        private bool? _zonalResiliency;

        /// <summary>Indicates if the cluster has zone resiliency.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public bool? ZonalResiliency { get => this._zonalResiliency; set => this._zonalResiliency = value; }

        /// <summary>Backing field for <see cref="ZonalUpdateMode" /> property.</summary>
        private string _zonalUpdateMode;

        /// <summary>Indicates the update mode for Cross Az clusters.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string ZonalUpdateMode { get => this._zonalUpdateMode; set => this._zonalUpdateMode = value; }

        /// <summary>Creates an new <see cref="ManagedClusterProperties" /> instance.</summary>
        public ManagedClusterProperties()
        {

        }
    }
    /// Describes the managed cluster resource properties.
    public partial interface IManagedClusterProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable
    {
        /// <summary>List of add-on features to enable on the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of add-on features to enable on the cluster.",
        SerializedName = @"addonFeatures",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("DnsService", "BackupRestoreService", "ResourceMonitorService")]
        System.Collections.Generic.List<string> AddonFeature { get; set; }
        /// <summary>VM admin user password.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"VM admin user password.",
        SerializedName = @"adminPassword",
        PossibleTypes = new [] { typeof(System.Security.SecureString) })]
        System.Security.SecureString AdminPassword { get; set; }
        /// <summary>VM admin user name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"VM admin user name.",
        SerializedName = @"adminUserName",
        PossibleTypes = new [] { typeof(string) })]
        string AdminUserName { get; set; }
        /// <summary>
        /// The number of outbound ports allocated for SNAT for each node in the backend pool of the default load balancer. The default
        /// value is 0 which provides dynamic port allocation based on pool size.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The number of outbound ports allocated for SNAT for each node in the backend pool of the default load balancer. The default value is 0 which provides dynamic port allocation based on pool size.",
        SerializedName = @"allocatedOutboundPorts",
        PossibleTypes = new [] { typeof(int) })]
        int? AllocatedOutboundPort { get; set; }
        /// <summary>
        /// Setting this to true enables RDP access to the VM. The default NSG rule opens RDP port to Internet which can be overridden
        /// with custom Network Security Rules. The default value for this setting is false.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Setting this to true enables RDP access to the VM. The default NSG rule opens RDP port to Internet which can be overridden with custom Network Security Rules. The default value for this setting is false.",
        SerializedName = @"allowRdpAccess",
        PossibleTypes = new [] { typeof(bool) })]
        bool? AllowRdpAccess { get; set; }
        /// <summary>Number of unused versions per application type to keep.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Number of unused versions per application type to keep.",
        SerializedName = @"maxUnusedVersionsToKeep",
        PossibleTypes = new [] { typeof(int) })]
        int? ApplicationTypeVersionCleanupPolicyMaxUnusedVersionsToKeep { get; set; }
        /// <summary>
        /// This property is the entry point to using a public CA cert for your cluster cert. It specifies the level of reuse allowed
        /// for the custom FQDN created, matching the subject of the public CA cert.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"This property is the entry point to using a public CA cert for your cluster cert. It specifies the level of reuse allowed for the custom FQDN created, matching the subject of the public CA cert.",
        SerializedName = @"autoGeneratedDomainNameLabelScope",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("TenantReuse", "SubscriptionReuse", "ResourceGroupReuse", "NoReuse")]
        string AutoGeneratedDomainNameLabelScope { get; set; }
        /// <summary>Auxiliary subnets for the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Auxiliary subnets for the cluster.",
        SerializedName = @"auxiliarySubnets",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISubnet) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISubnet> AuxiliarySubnet { get; set; }
        /// <summary>Azure active directory client application id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Azure active directory client application id.",
        SerializedName = @"clientApplication",
        PossibleTypes = new [] { typeof(string) })]
        string AzureActiveDirectoryClientApplication { get; set; }
        /// <summary>Azure active directory cluster application id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Azure active directory cluster application id.",
        SerializedName = @"clusterApplication",
        PossibleTypes = new [] { typeof(string) })]
        string AzureActiveDirectoryClusterApplication { get; set; }
        /// <summary>Azure active directory tenant id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Azure active directory tenant id.",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string AzureActiveDirectoryTenantId { get; set; }
        /// <summary>Client certificates that are allowed to manage the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Client certificates that are allowed to manage the cluster.",
        SerializedName = @"clients",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClientCertificate) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClientCertificate> Client { get; set; }
        /// <summary>The port used for client connections to the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The port used for client connections to the cluster.",
        SerializedName = @"clientConnectionPort",
        PossibleTypes = new [] { typeof(int) })]
        int? ClientConnectionPort { get; set; }
        /// <summary>List of thumbprints of the cluster certificates.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"List of thumbprints of the cluster certificates.",
        SerializedName = @"clusterCertificateThumbprints",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> ClusterCertificateThumbprint { get;  }
        /// <summary>
        /// The Service Fabric runtime version of the cluster. This property is required when **clusterUpgradeMode** is set to 'Manual'.
        /// To get list of available Service Fabric versions for new clusters use [ClusterVersion API](./ClusterVersion.md). To get
        /// the list of available version for existing clusters use **availableClusterVersions**.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The Service Fabric runtime version of the cluster. This property is required when **clusterUpgradeMode** is set to 'Manual'. To get list of available Service Fabric versions for new clusters use [ClusterVersion API](./ClusterVersion.md). To get the list of available version for existing clusters use **availableClusterVersions**.",
        SerializedName = @"clusterCodeVersion",
        PossibleTypes = new [] { typeof(string) })]
        string ClusterCodeVersion { get; set; }
        /// <summary>A service generated unique identifier for the cluster resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"A service generated unique identifier for the cluster resource.",
        SerializedName = @"clusterId",
        PossibleTypes = new [] { typeof(string) })]
        string ClusterId { get;  }
        /// <summary>The current state of the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The current state of the cluster.",
        SerializedName = @"clusterState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("WaitingForNodes", "Deploying", "BaselineUpgrade", "Upgrading", "UpgradeFailed", "Ready")]
        string ClusterState { get;  }
        /// <summary>
        /// Indicates when new cluster runtime version upgrades will be applied after they are released. By default is Wave0. Only
        /// applies when **clusterUpgradeMode** is set to 'Automatic'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Indicates when new cluster runtime version upgrades will be applied after they are released. By default is Wave0. Only applies when **clusterUpgradeMode** is set to 'Automatic'.",
        SerializedName = @"clusterUpgradeCadence",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("Wave0", "Wave1", "Wave2")]
        string ClusterUpgradeCadence { get; set; }
        /// <summary>
        /// The upgrade mode of the cluster when new Service Fabric runtime version is available.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The upgrade mode of the cluster when new Service Fabric runtime version is available.",
        SerializedName = @"clusterUpgradeMode",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("Automatic", "Manual")]
        string ClusterUpgradeMode { get; set; }
        /// <summary>
        /// Specify the resource id of a DDoS network protection plan that will be associated with the virtual network of the cluster.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specify the resource id of a DDoS network protection plan that will be associated with the virtual network of the cluster.",
        SerializedName = @"ddosProtectionPlanId",
        PossibleTypes = new [] { typeof(string) })]
        string DdosProtectionPlanId { get; set; }
        /// <summary>
        /// The maximum allowed percentage of applications health degradation allowed during cluster upgrades.
        /// The delta is measured between the state of the applications at the beginning of upgrade and the state of the applications
        /// at the time of the health evaluation.
        /// The check is performed after every upgrade domain upgrade completion to make sure the global state of the cluster is within
        /// tolerated limits. System services are not included in this.
        /// NOTE: This value will overwrite the value specified in properties.UpgradeDescription.HealthPolicy.MaxPercentUnhealthyApplications
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The maximum allowed percentage of applications health degradation allowed during cluster upgrades.
        The delta is measured between the state of the applications at the beginning of upgrade and the state of the applications at the time of the health evaluation.
        The check is performed after every upgrade domain upgrade completion to make sure the global state of the cluster is within tolerated limits. System services are not included in this.
        NOTE: This value will overwrite the value specified in properties.UpgradeDescription.HealthPolicy.MaxPercentUnhealthyApplications",
        SerializedName = @"maxPercentDeltaUnhealthyApplications",
        PossibleTypes = new [] { typeof(int) })]
        int? DeltaHealthPolicyMaxPercentDeltaUnhealthyApplication { get; set; }
        /// <summary>
        /// The maximum allowed percentage of nodes health degradation allowed during cluster upgrades.
        /// The delta is measured between the state of the nodes at the beginning of upgrade and the state of the nodes at the time
        /// of the health evaluation.
        /// The check is performed after every upgrade domain upgrade completion to make sure the global state of the cluster is within
        /// tolerated limits.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The maximum allowed percentage of nodes health degradation allowed during cluster upgrades.
        The delta is measured between the state of the nodes at the beginning of upgrade and the state of the nodes at the time of the health evaluation.
        The check is performed after every upgrade domain upgrade completion to make sure the global state of the cluster is within tolerated limits.",
        SerializedName = @"maxPercentDeltaUnhealthyNodes",
        PossibleTypes = new [] { typeof(int) })]
        int? DeltaHealthPolicyMaxPercentDeltaUnhealthyNode { get; set; }
        /// <summary>
        /// The maximum allowed percentage of upgrade domain nodes health degradation allowed during cluster upgrades.
        /// The delta is measured between the state of the upgrade domain nodes at the beginning of upgrade and the state of the upgrade
        /// domain nodes at the time of the health evaluation.
        /// The check is performed after every upgrade domain upgrade completion for all completed upgrade domains to make sure the
        /// state of the upgrade domains is within tolerated limits.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The maximum allowed percentage of upgrade domain nodes health degradation allowed during cluster upgrades.
        The delta is measured between the state of the upgrade domain nodes at the beginning of upgrade and the state of the upgrade domain nodes at the time of the health evaluation.
        The check is performed after every upgrade domain upgrade completion for all completed upgrade domains to make sure the state of the upgrade domains is within tolerated limits.",
        SerializedName = @"maxPercentUpgradeDomainDeltaUnhealthyNodes",
        PossibleTypes = new [] { typeof(int) })]
        int? DeltaHealthPolicyMaxPercentUpgradeDomainDeltaUnhealthyNode { get; set; }
        /// <summary>The cluster dns name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The cluster dns name.",
        SerializedName = @"dnsName",
        PossibleTypes = new [] { typeof(string) })]
        string DnsName { get; set; }
        /// <summary>
        /// Enables automatic OS upgrade for node types created using OS images with version 'latest'. The default value for this
        /// setting is false.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Enables automatic OS upgrade for node types created using OS images with version 'latest'. The default value for this setting is false.",
        SerializedName = @"enableAutoOSUpgrade",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnableAutoOSUpgrade { get; set; }
        /// <summary>
        /// If true, token-based authentication is not allowed on the HttpGatewayEndpoint. This is required to support TLS versions
        /// 1.3 and above. If token-based authentication is used, HttpGatewayTokenAuthConnectionPort must be defined.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"If true, token-based authentication is not allowed on the HttpGatewayEndpoint. This is required to support TLS versions 1.3 and above. If token-based authentication is used, HttpGatewayTokenAuthConnectionPort must be defined.",
        SerializedName = @"enableHttpGatewayExclusiveAuthMode",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnableHttpGatewayExclusiveAuthMode { get; set; }
        /// <summary>
        /// Setting this to true creates IPv6 address space for the default VNet used by the cluster. This setting cannot be changed
        /// once the cluster is created. The default value for this setting is false.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Setting this to true creates IPv6 address space for the default VNet used by the cluster. This setting cannot be changed once the cluster is created. The default value for this setting is false.",
        SerializedName = @"enableIpv6",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnableIpv6 { get; set; }
        /// <summary>
        /// Enable the creation of node types with only outbound traffic enabled. If set, a separate load balancer backend pool will
        /// be created for node types with inbound traffic enabled. Can only be set at the time of cluster creation.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Enable the creation of node types with only outbound traffic enabled. If set, a separate load balancer backend pool will be created for node types with inbound traffic enabled. Can only be set at the time of cluster creation.",
        SerializedName = @"enableOutboundOnlyNodeTypes",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnableOutboundOnlyNodeType { get; set; }
        /// <summary>
        /// Setting this to true will link the IPv4 address as the ServicePublicIP of the IPv6 address. It can only be set to True
        /// if IPv6 is enabled on the cluster.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Setting this to true will link the IPv4 address as the ServicePublicIP of the IPv6 address. It can only be set to True if IPv6 is enabled on the cluster.",
        SerializedName = @"enableServicePublicIP",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnableServicePublicIP { get; set; }
        /// <summary>The list of custom fabric settings to configure the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The list of custom fabric settings to configure the cluster.",
        SerializedName = @"fabricSettings",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISettingsSectionDescription) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISettingsSectionDescription> FabricSetting { get; set; }
        /// <summary>
        /// The fully qualified domain name associated with the public load balancer of the cluster.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The fully qualified domain name associated with the public load balancer of the cluster.",
        SerializedName = @"fqdn",
        PossibleTypes = new [] { typeof(string) })]
        string Fqdn { get;  }
        /// <summary>
        /// The maximum allowed percentage of unhealthy applications before reporting an error. For example, to allow 10% of applications
        /// to be unhealthy, this value would be 10.
        /// The percentage represents the maximum tolerated percentage of applications that can be unhealthy before the cluster is
        /// considered in error.
        /// If the percentage is respected but there is at least one unhealthy application, the health is evaluated as Warning.
        /// This is calculated by dividing the number of unhealthy applications over the total number of application instances in
        /// the cluster, excluding applications of application types that are included in the ApplicationTypeHealthPolicyMap.
        /// The computation rounds up to tolerate one failure on small numbers of applications. Default percentage is zero.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The maximum allowed percentage of unhealthy applications before reporting an error. For example, to allow 10% of applications to be unhealthy, this value would be 10.

        The percentage represents the maximum tolerated percentage of applications that can be unhealthy before the cluster is considered in error.
        If the percentage is respected but there is at least one unhealthy application, the health is evaluated as Warning.
        This is calculated by dividing the number of unhealthy applications over the total number of application instances in the cluster, excluding applications of application types that are included in the ApplicationTypeHealthPolicyMap.
        The computation rounds up to tolerate one failure on small numbers of applications. Default percentage is zero.",
        SerializedName = @"maxPercentUnhealthyApplications",
        PossibleTypes = new [] { typeof(int) })]
        int? HealthPolicyMaxPercentUnhealthyApplication { get; set; }
        /// <summary>
        /// The maximum allowed percentage of unhealthy nodes before reporting an error. For example, to allow 10% of nodes to be
        /// unhealthy, this value would be 10.
        /// The percentage represents the maximum tolerated percentage of nodes that can be unhealthy before the cluster is considered
        /// in error.
        /// If the percentage is respected but there is at least one unhealthy node, the health is evaluated as Warning.
        /// The percentage is calculated by dividing the number of unhealthy nodes over the total number of nodes in the cluster.
        /// The computation rounds up to tolerate one failure on small numbers of nodes. Default percentage is zero.
        /// In large clusters, some nodes will always be down or out for repairs, so this percentage should be configured to tolerate
        /// that.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The maximum allowed percentage of unhealthy nodes before reporting an error. For example, to allow 10% of nodes to be unhealthy, this value would be 10.

        The percentage represents the maximum tolerated percentage of nodes that can be unhealthy before the cluster is considered in error.
        If the percentage is respected but there is at least one unhealthy node, the health is evaluated as Warning.
        The percentage is calculated by dividing the number of unhealthy nodes over the total number of nodes in the cluster.
        The computation rounds up to tolerate one failure on small numbers of nodes. Default percentage is zero.

        In large clusters, some nodes will always be down or out for repairs, so this percentage should be configured to tolerate that.",
        SerializedName = @"maxPercentUnhealthyNodes",
        PossibleTypes = new [] { typeof(int) })]
        int? HealthPolicyMaxPercentUnhealthyNode { get; set; }
        /// <summary>The port used for HTTP connections to the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The port used for HTTP connections to the cluster.",
        SerializedName = @"httpGatewayConnectionPort",
        PossibleTypes = new [] { typeof(int) })]
        int? HttpGatewayConnectionPort { get; set; }
        /// <summary>
        /// The port used for token-auth based HTTPS connections to the cluster. Cannot be set to the same port as HttpGatewayEndpoint.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The port used for token-auth based HTTPS connections to the cluster. Cannot be set to the same port as HttpGatewayEndpoint.",
        SerializedName = @"httpGatewayTokenAuthConnectionPort",
        PossibleTypes = new [] { typeof(int) })]
        int? HttpGatewayTokenAuthConnectionPort { get; set; }
        /// <summary>
        /// The list of IP tags associated with the default public IP address of the cluster.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The list of IP tags associated with the default public IP address of the cluster.",
        SerializedName = @"ipTags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPTag) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPTag> IPTag { get; set; }
        /// <summary>The IPv4 address associated with the public load balancer of the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The IPv4 address associated with the public load balancer of the cluster.",
        SerializedName = @"ipv4Address",
        PossibleTypes = new [] { typeof(string) })]
        string Ipv4Address { get;  }
        /// <summary>IPv6 address for the cluster if IPv6 is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"IPv6 address for the cluster if IPv6 is enabled.",
        SerializedName = @"ipv6Address",
        PossibleTypes = new [] { typeof(string) })]
        string Ipv6Address { get;  }
        /// <summary>
        /// Load balancing rules that are applied to the public load balancer of the cluster.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Load balancing rules that are applied to the public load balancer of the cluster.",
        SerializedName = @"loadBalancingRules",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ILoadBalancingRule) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ILoadBalancingRule> LoadBalancingRule { get; set; }
        /// <summary>
        /// The amount of time to retry health evaluation when the application or cluster is unhealthy before the upgrade rolls back.
        /// The timeout can be in either hh:mm:ss or in d.hh:mm:ss.ms format.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The amount of time to retry health evaluation when the application or cluster is unhealthy before the upgrade rolls back. The timeout can be in either hh:mm:ss or in d.hh:mm:ss.ms format.",
        SerializedName = @"healthCheckRetryTimeout",
        PossibleTypes = new [] { typeof(string) })]
        string MonitoringPolicyHealthCheckRetryTimeout { get; set; }
        /// <summary>
        /// The amount of time that the application or cluster must remain healthy before the upgrade proceeds to the next upgrade
        /// domain. The duration can be in either hh:mm:ss or in d.hh:mm:ss.ms format.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The amount of time that the application or cluster must remain healthy before the upgrade proceeds to the next upgrade domain. The duration can be in either hh:mm:ss or in d.hh:mm:ss.ms format.",
        SerializedName = @"healthCheckStableDuration",
        PossibleTypes = new [] { typeof(string) })]
        string MonitoringPolicyHealthCheckStableDuration { get; set; }
        /// <summary>
        /// The length of time to wait after completing an upgrade domain before performing health checks. The duration can be in
        /// either hh:mm:ss or in d.hh:mm:ss.ms format.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The length of time to wait after completing an upgrade domain before performing health checks. The duration can be in either hh:mm:ss or in d.hh:mm:ss.ms format.",
        SerializedName = @"healthCheckWaitDuration",
        PossibleTypes = new [] { typeof(string) })]
        string MonitoringPolicyHealthCheckWaitDuration { get; set; }
        /// <summary>
        /// The amount of time each upgrade domain has to complete before the upgrade rolls back. The timeout can be in either hh:mm:ss
        /// or in d.hh:mm:ss.ms format.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The amount of time each upgrade domain has to complete before the upgrade rolls back. The timeout can be in either hh:mm:ss or in d.hh:mm:ss.ms format.",
        SerializedName = @"upgradeDomainTimeout",
        PossibleTypes = new [] { typeof(string) })]
        string MonitoringPolicyUpgradeDomainTimeout { get; set; }
        /// <summary>
        /// The amount of time the overall upgrade has to complete before the upgrade rolls back. The timeout can be in either hh:mm:ss
        /// or in d.hh:mm:ss.ms format.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The amount of time the overall upgrade has to complete before the upgrade rolls back. The timeout can be in either hh:mm:ss or in d.hh:mm:ss.ms format.",
        SerializedName = @"upgradeTimeout",
        PossibleTypes = new [] { typeof(string) })]
        string MonitoringPolicyUpgradeTimeout { get; set; }
        /// <summary>
        /// Custom Network Security Rules that are applied to the Virtual Network of the cluster.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Custom Network Security Rules that are applied to the Virtual Network of the cluster.",
        SerializedName = @"networkSecurityRules",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INetworkSecurityRule) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INetworkSecurityRule> NetworkSecurityRule { get; set; }
        /// <summary>The provisioning state of the managed cluster resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The provisioning state of the managed cluster resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("None", "Creating", "Created", "Updating", "Succeeded", "Failed", "Canceled", "Deleting", "Deleted", "Other")]
        string ProvisioningState { get;  }
        /// <summary>
        /// Specify the resource id of a public IPv4 prefix that the load balancer will allocate a public IPv4 address from. This
        /// setting cannot be changed once the cluster is created.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specify the resource id of a public IPv4 prefix that the load balancer will allocate a public IPv4 address from. This setting cannot be changed once the cluster is created.",
        SerializedName = @"publicIPPrefixId",
        PossibleTypes = new [] { typeof(string) })]
        string PublicIPPrefixId { get; set; }
        /// <summary>
        /// Specify the resource id of a public IPv6 prefix that the load balancer will allocate a public IPv6 address from. This
        /// setting cannot be changed once the cluster is created.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specify the resource id of a public IPv6 prefix that the load balancer will allocate a public IPv6 address from. This setting cannot be changed once the cluster is created.",
        SerializedName = @"publicIPv6PrefixId",
        PossibleTypes = new [] { typeof(string) })]
        string PublicIPv6PrefixId { get; set; }
        /// <summary>Service endpoints for subnets in the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Service endpoints for subnets in the cluster.",
        SerializedName = @"serviceEndpoints",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceEndpoint) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceEndpoint> ServiceEndpoint { get; set; }
        /// <summary>
        /// If specified, the node types for the cluster are created in this subnet instead of the default VNet. The **networkSecurityRules**
        /// specified for the cluster are also applied to this subnet. This setting cannot be changed once the cluster is created.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"If specified, the node types for the cluster are created in this subnet instead of the default VNet. The **networkSecurityRules** specified for the cluster are also applied to this subnet. This setting cannot be changed once the cluster is created.",
        SerializedName = @"subnetId",
        PossibleTypes = new [] { typeof(string) })]
        string SubnetId { get; set; }
        /// <summary>
        /// If true, then processes are forcefully restarted during upgrade even when the code version has not changed (the upgrade
        /// only changes configuration or data).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"If true, then processes are forcefully restarted during upgrade even when the code version has not changed (the upgrade only changes configuration or data).",
        SerializedName = @"forceRestart",
        PossibleTypes = new [] { typeof(bool) })]
        bool? UpgradeDescriptionForceRestart { get; set; }
        /// <summary>
        /// The maximum amount of time to block processing of an upgrade domain and prevent loss of availability when there are unexpected
        /// issues.
        /// When this timeout expires, processing of the upgrade domain will proceed regardless of availability loss issues.
        /// The timeout is reset at the start of each upgrade domain. The timeout can be in either hh:mm:ss or in d.hh:mm:ss.ms format.
        /// This value must be between 00:00:00 and 49710.06:28:15 (unsigned 32 bit integer for seconds)
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The maximum amount of time to block processing of an upgrade domain and prevent loss of availability when there are unexpected issues.
        When this timeout expires, processing of the upgrade domain will proceed regardless of availability loss issues.
        The timeout is reset at the start of each upgrade domain. The timeout can be in either hh:mm:ss or in d.hh:mm:ss.ms format.
        This value must be between 00:00:00 and 49710.06:28:15 (unsigned 32 bit integer for seconds)",
        SerializedName = @"upgradeReplicaSetCheckTimeout",
        PossibleTypes = new [] { typeof(string) })]
        string UpgradeDescriptionUpgradeReplicaSetCheckTimeout { get; set; }
        /// <summary>
        /// For new clusters, this parameter indicates that it uses Bring your own VNet, but the subnet is specified at node type
        /// level; and for such clusters, the subnetId property is required for node types.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"For new clusters, this parameter indicates that it uses Bring your own VNet, but the subnet is specified at node type level; and for such clusters, the subnetId property is required for node types.",
        SerializedName = @"useCustomVnet",
        PossibleTypes = new [] { typeof(bool) })]
        bool? UseCustomVnet { get; set; }
        /// <summary>
        /// The VM image the node types are configured with. This property controls the Service Fabric component packages to be used
        /// for the cluster. Allowed values are: 'Windows'. The default value is 'Windows'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The VM image the node types are configured with. This property controls the Service Fabric component packages to be used for the cluster. Allowed values are: 'Windows'. The default value is 'Windows'.",
        SerializedName = @"VMImage",
        PossibleTypes = new [] { typeof(string) })]
        string VMImage { get; set; }
        /// <summary>Indicates if the cluster has zone resiliency.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Indicates if the cluster has zone resiliency.",
        SerializedName = @"zonalResiliency",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ZonalResiliency { get; set; }
        /// <summary>Indicates the update mode for Cross Az clusters.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Indicates the update mode for Cross Az clusters.",
        SerializedName = @"zonalUpdateMode",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("Standard", "Fast")]
        string ZonalUpdateMode { get; set; }

    }
    /// Describes the managed cluster resource properties.
    internal partial interface IManagedClusterPropertiesInternal

    {
        /// <summary>List of add-on features to enable on the cluster.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("DnsService", "BackupRestoreService", "ResourceMonitorService")]
        System.Collections.Generic.List<string> AddonFeature { get; set; }
        /// <summary>VM admin user password.</summary>
        System.Security.SecureString AdminPassword { get; set; }
        /// <summary>VM admin user name.</summary>
        string AdminUserName { get; set; }
        /// <summary>
        /// The number of outbound ports allocated for SNAT for each node in the backend pool of the default load balancer. The default
        /// value is 0 which provides dynamic port allocation based on pool size.
        /// </summary>
        int? AllocatedOutboundPort { get; set; }
        /// <summary>
        /// Setting this to true enables RDP access to the VM. The default NSG rule opens RDP port to Internet which can be overridden
        /// with custom Network Security Rules. The default value for this setting is false.
        /// </summary>
        bool? AllowRdpAccess { get; set; }
        /// <summary>Number of unused versions per application type to keep.</summary>
        int? ApplicationTypeVersionCleanupPolicyMaxUnusedVersionsToKeep { get; set; }
        /// <summary>The policy used to clean up unused versions.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationTypeVersionsCleanupPolicy ApplicationTypeVersionsCleanupPolicy { get; set; }
        /// <summary>
        /// This property is the entry point to using a public CA cert for your cluster cert. It specifies the level of reuse allowed
        /// for the custom FQDN created, matching the subject of the public CA cert.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("TenantReuse", "SubscriptionReuse", "ResourceGroupReuse", "NoReuse")]
        string AutoGeneratedDomainNameLabelScope { get; set; }
        /// <summary>Auxiliary subnets for the cluster.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISubnet> AuxiliarySubnet { get; set; }
        /// <summary>The AAD authentication settings of the cluster.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IAzureActiveDirectory AzureActiveDirectory { get; set; }
        /// <summary>Azure active directory client application id.</summary>
        string AzureActiveDirectoryClientApplication { get; set; }
        /// <summary>Azure active directory cluster application id.</summary>
        string AzureActiveDirectoryClusterApplication { get; set; }
        /// <summary>Azure active directory tenant id.</summary>
        string AzureActiveDirectoryTenantId { get; set; }
        /// <summary>Client certificates that are allowed to manage the cluster.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClientCertificate> Client { get; set; }
        /// <summary>The port used for client connections to the cluster.</summary>
        int? ClientConnectionPort { get; set; }
        /// <summary>List of thumbprints of the cluster certificates.</summary>
        System.Collections.Generic.List<string> ClusterCertificateThumbprint { get; set; }
        /// <summary>
        /// The Service Fabric runtime version of the cluster. This property is required when **clusterUpgradeMode** is set to 'Manual'.
        /// To get list of available Service Fabric versions for new clusters use [ClusterVersion API](./ClusterVersion.md). To get
        /// the list of available version for existing clusters use **availableClusterVersions**.
        /// </summary>
        string ClusterCodeVersion { get; set; }
        /// <summary>A service generated unique identifier for the cluster resource.</summary>
        string ClusterId { get; set; }
        /// <summary>The current state of the cluster.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("WaitingForNodes", "Deploying", "BaselineUpgrade", "Upgrading", "UpgradeFailed", "Ready")]
        string ClusterState { get; set; }
        /// <summary>
        /// Indicates when new cluster runtime version upgrades will be applied after they are released. By default is Wave0. Only
        /// applies when **clusterUpgradeMode** is set to 'Automatic'.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("Wave0", "Wave1", "Wave2")]
        string ClusterUpgradeCadence { get; set; }
        /// <summary>
        /// The upgrade mode of the cluster when new Service Fabric runtime version is available.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("Automatic", "Manual")]
        string ClusterUpgradeMode { get; set; }
        /// <summary>
        /// Specify the resource id of a DDoS network protection plan that will be associated with the virtual network of the cluster.
        /// </summary>
        string DdosProtectionPlanId { get; set; }
        /// <summary>
        /// The maximum allowed percentage of applications health degradation allowed during cluster upgrades.
        /// The delta is measured between the state of the applications at the beginning of upgrade and the state of the applications
        /// at the time of the health evaluation.
        /// The check is performed after every upgrade domain upgrade completion to make sure the global state of the cluster is within
        /// tolerated limits. System services are not included in this.
        /// NOTE: This value will overwrite the value specified in properties.UpgradeDescription.HealthPolicy.MaxPercentUnhealthyApplications
        /// </summary>
        int? DeltaHealthPolicyMaxPercentDeltaUnhealthyApplication { get; set; }
        /// <summary>
        /// The maximum allowed percentage of nodes health degradation allowed during cluster upgrades.
        /// The delta is measured between the state of the nodes at the beginning of upgrade and the state of the nodes at the time
        /// of the health evaluation.
        /// The check is performed after every upgrade domain upgrade completion to make sure the global state of the cluster is within
        /// tolerated limits.
        /// </summary>
        int? DeltaHealthPolicyMaxPercentDeltaUnhealthyNode { get; set; }
        /// <summary>
        /// The maximum allowed percentage of upgrade domain nodes health degradation allowed during cluster upgrades.
        /// The delta is measured between the state of the upgrade domain nodes at the beginning of upgrade and the state of the upgrade
        /// domain nodes at the time of the health evaluation.
        /// The check is performed after every upgrade domain upgrade completion for all completed upgrade domains to make sure the
        /// state of the upgrade domains is within tolerated limits.
        /// </summary>
        int? DeltaHealthPolicyMaxPercentUpgradeDomainDeltaUnhealthyNode { get; set; }
        /// <summary>The cluster dns name.</summary>
        string DnsName { get; set; }
        /// <summary>
        /// Enables automatic OS upgrade for node types created using OS images with version 'latest'. The default value for this
        /// setting is false.
        /// </summary>
        bool? EnableAutoOSUpgrade { get; set; }
        /// <summary>
        /// If true, token-based authentication is not allowed on the HttpGatewayEndpoint. This is required to support TLS versions
        /// 1.3 and above. If token-based authentication is used, HttpGatewayTokenAuthConnectionPort must be defined.
        /// </summary>
        bool? EnableHttpGatewayExclusiveAuthMode { get; set; }
        /// <summary>
        /// Setting this to true creates IPv6 address space for the default VNet used by the cluster. This setting cannot be changed
        /// once the cluster is created. The default value for this setting is false.
        /// </summary>
        bool? EnableIpv6 { get; set; }
        /// <summary>
        /// Enable the creation of node types with only outbound traffic enabled. If set, a separate load balancer backend pool will
        /// be created for node types with inbound traffic enabled. Can only be set at the time of cluster creation.
        /// </summary>
        bool? EnableOutboundOnlyNodeType { get; set; }
        /// <summary>
        /// Setting this to true will link the IPv4 address as the ServicePublicIP of the IPv6 address. It can only be set to True
        /// if IPv6 is enabled on the cluster.
        /// </summary>
        bool? EnableServicePublicIP { get; set; }
        /// <summary>The list of custom fabric settings to configure the cluster.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISettingsSectionDescription> FabricSetting { get; set; }
        /// <summary>
        /// The fully qualified domain name associated with the public load balancer of the cluster.
        /// </summary>
        string Fqdn { get; set; }
        /// <summary>
        /// The maximum allowed percentage of unhealthy applications before reporting an error. For example, to allow 10% of applications
        /// to be unhealthy, this value would be 10.
        /// The percentage represents the maximum tolerated percentage of applications that can be unhealthy before the cluster is
        /// considered in error.
        /// If the percentage is respected but there is at least one unhealthy application, the health is evaluated as Warning.
        /// This is calculated by dividing the number of unhealthy applications over the total number of application instances in
        /// the cluster, excluding applications of application types that are included in the ApplicationTypeHealthPolicyMap.
        /// The computation rounds up to tolerate one failure on small numbers of applications. Default percentage is zero.
        /// </summary>
        int? HealthPolicyMaxPercentUnhealthyApplication { get; set; }
        /// <summary>
        /// The maximum allowed percentage of unhealthy nodes before reporting an error. For example, to allow 10% of nodes to be
        /// unhealthy, this value would be 10.
        /// The percentage represents the maximum tolerated percentage of nodes that can be unhealthy before the cluster is considered
        /// in error.
        /// If the percentage is respected but there is at least one unhealthy node, the health is evaluated as Warning.
        /// The percentage is calculated by dividing the number of unhealthy nodes over the total number of nodes in the cluster.
        /// The computation rounds up to tolerate one failure on small numbers of nodes. Default percentage is zero.
        /// In large clusters, some nodes will always be down or out for repairs, so this percentage should be configured to tolerate
        /// that.
        /// </summary>
        int? HealthPolicyMaxPercentUnhealthyNode { get; set; }
        /// <summary>The port used for HTTP connections to the cluster.</summary>
        int? HttpGatewayConnectionPort { get; set; }
        /// <summary>
        /// The port used for token-auth based HTTPS connections to the cluster. Cannot be set to the same port as HttpGatewayEndpoint.
        /// </summary>
        int? HttpGatewayTokenAuthConnectionPort { get; set; }
        /// <summary>
        /// The list of IP tags associated with the default public IP address of the cluster.
        /// </summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPTag> IPTag { get; set; }
        /// <summary>The IPv4 address associated with the public load balancer of the cluster.</summary>
        string Ipv4Address { get; set; }
        /// <summary>IPv6 address for the cluster if IPv6 is enabled.</summary>
        string Ipv6Address { get; set; }
        /// <summary>
        /// Load balancing rules that are applied to the public load balancer of the cluster.
        /// </summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ILoadBalancingRule> LoadBalancingRule { get; set; }
        /// <summary>
        /// The amount of time to retry health evaluation when the application or cluster is unhealthy before the upgrade rolls back.
        /// The timeout can be in either hh:mm:ss or in d.hh:mm:ss.ms format.
        /// </summary>
        string MonitoringPolicyHealthCheckRetryTimeout { get; set; }
        /// <summary>
        /// The amount of time that the application or cluster must remain healthy before the upgrade proceeds to the next upgrade
        /// domain. The duration can be in either hh:mm:ss or in d.hh:mm:ss.ms format.
        /// </summary>
        string MonitoringPolicyHealthCheckStableDuration { get; set; }
        /// <summary>
        /// The length of time to wait after completing an upgrade domain before performing health checks. The duration can be in
        /// either hh:mm:ss or in d.hh:mm:ss.ms format.
        /// </summary>
        string MonitoringPolicyHealthCheckWaitDuration { get; set; }
        /// <summary>
        /// The amount of time each upgrade domain has to complete before the upgrade rolls back. The timeout can be in either hh:mm:ss
        /// or in d.hh:mm:ss.ms format.
        /// </summary>
        string MonitoringPolicyUpgradeDomainTimeout { get; set; }
        /// <summary>
        /// The amount of time the overall upgrade has to complete before the upgrade rolls back. The timeout can be in either hh:mm:ss
        /// or in d.hh:mm:ss.ms format.
        /// </summary>
        string MonitoringPolicyUpgradeTimeout { get; set; }
        /// <summary>
        /// Custom Network Security Rules that are applied to the Virtual Network of the cluster.
        /// </summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INetworkSecurityRule> NetworkSecurityRule { get; set; }
        /// <summary>The provisioning state of the managed cluster resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("None", "Creating", "Created", "Updating", "Succeeded", "Failed", "Canceled", "Deleting", "Deleted", "Other")]
        string ProvisioningState { get; set; }
        /// <summary>
        /// Specify the resource id of a public IPv4 prefix that the load balancer will allocate a public IPv4 address from. This
        /// setting cannot be changed once the cluster is created.
        /// </summary>
        string PublicIPPrefixId { get; set; }
        /// <summary>
        /// Specify the resource id of a public IPv6 prefix that the load balancer will allocate a public IPv6 address from. This
        /// setting cannot be changed once the cluster is created.
        /// </summary>
        string PublicIPv6PrefixId { get; set; }
        /// <summary>Service endpoints for subnets in the cluster.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceEndpoint> ServiceEndpoint { get; set; }
        /// <summary>
        /// If specified, the node types for the cluster are created in this subnet instead of the default VNet. The **networkSecurityRules**
        /// specified for the cluster are also applied to this subnet. This setting cannot be changed once the cluster is created.
        /// </summary>
        string SubnetId { get; set; }
        /// <summary>The policy to use when upgrading the cluster.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicy UpgradeDescription { get; set; }
        /// <summary>
        /// The cluster delta health policy defines a health policy used to evaluate the health of the cluster during a cluster upgrade.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradeDeltaHealthPolicy UpgradeDescriptionDeltaHealthPolicy { get; set; }
        /// <summary>
        /// If true, then processes are forcefully restarted during upgrade even when the code version has not changed (the upgrade
        /// only changes configuration or data).
        /// </summary>
        bool? UpgradeDescriptionForceRestart { get; set; }
        /// <summary>
        /// The cluster health policy defines a health policy used to evaluate the health of the cluster during a cluster upgrade.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterHealthPolicy UpgradeDescriptionHealthPolicy { get; set; }
        /// <summary>
        /// The cluster monitoring policy describes the parameters for monitoring an upgrade in Monitored mode.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterMonitoringPolicy UpgradeDescriptionMonitoringPolicy { get; set; }
        /// <summary>
        /// The maximum amount of time to block processing of an upgrade domain and prevent loss of availability when there are unexpected
        /// issues.
        /// When this timeout expires, processing of the upgrade domain will proceed regardless of availability loss issues.
        /// The timeout is reset at the start of each upgrade domain. The timeout can be in either hh:mm:ss or in d.hh:mm:ss.ms format.
        /// This value must be between 00:00:00 and 49710.06:28:15 (unsigned 32 bit integer for seconds)
        /// </summary>
        string UpgradeDescriptionUpgradeReplicaSetCheckTimeout { get; set; }
        /// <summary>
        /// For new clusters, this parameter indicates that it uses Bring your own VNet, but the subnet is specified at node type
        /// level; and for such clusters, the subnetId property is required for node types.
        /// </summary>
        bool? UseCustomVnet { get; set; }
        /// <summary>
        /// The VM image the node types are configured with. This property controls the Service Fabric component packages to be used
        /// for the cluster. Allowed values are: 'Windows'. The default value is 'Windows'.
        /// </summary>
        string VMImage { get; set; }
        /// <summary>Indicates if the cluster has zone resiliency.</summary>
        bool? ZonalResiliency { get; set; }
        /// <summary>Indicates the update mode for Cross Az clusters.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("Standard", "Fast")]
        string ZonalUpdateMode { get; set; }

    }
}