// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>The managed cluster resource</summary>
    public partial class ManagedCluster :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedCluster,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterInternal,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ITrackedResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ITrackedResource __trackedResource = new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.TrackedResource();

        /// <summary>List of add-on features to enable on the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> AddonFeature { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).AddonFeature; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).AddonFeature = value ?? null /* arrayOf */; }

        /// <summary>VM admin user password.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public System.Security.SecureString AdminPassword { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).AdminPassword; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).AdminPassword = value ?? null; }

        /// <summary>VM admin user name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string AdminUserName { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).AdminUserName; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).AdminUserName = value ?? null; }

        /// <summary>
        /// The number of outbound ports allocated for SNAT for each node in the backend pool of the default load balancer. The default
        /// value is 0 which provides dynamic port allocation based on pool size.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public int? AllocatedOutboundPort { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).AllocatedOutboundPort; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).AllocatedOutboundPort = value ?? default(int); }

        /// <summary>
        /// Setting this to true enables RDP access to the VM. The default NSG rule opens RDP port to Internet which can be overridden
        /// with custom Network Security Rules. The default value for this setting is false.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public bool? AllowRdpAccess { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).AllowRdpAccess; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).AllowRdpAccess = value ?? default(bool); }

        /// <summary>Number of unused versions per application type to keep.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public int? ApplicationTypeVersionCleanupPolicyMaxUnusedVersionsToKeep { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).ApplicationTypeVersionCleanupPolicyMaxUnusedVersionsToKeep; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).ApplicationTypeVersionCleanupPolicyMaxUnusedVersionsToKeep = value ?? default(int); }

        /// <summary>
        /// This property is the entry point to using a public CA cert for your cluster cert. It specifies the level of reuse allowed
        /// for the custom FQDN created, matching the subject of the public CA cert.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string AutoGeneratedDomainNameLabelScope { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).AutoGeneratedDomainNameLabelScope; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).AutoGeneratedDomainNameLabelScope = value ?? null; }

        /// <summary>Auxiliary subnets for the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISubnet> AuxiliarySubnet { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).AuxiliarySubnet; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).AuxiliarySubnet = value ?? null /* arrayOf */; }

        /// <summary>Azure active directory client application id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string AzureActiveDirectoryClientApplication { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).AzureActiveDirectoryClientApplication; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).AzureActiveDirectoryClientApplication = value ?? null; }

        /// <summary>Azure active directory cluster application id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string AzureActiveDirectoryClusterApplication { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).AzureActiveDirectoryClusterApplication; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).AzureActiveDirectoryClusterApplication = value ?? null; }

        /// <summary>Azure active directory tenant id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string AzureActiveDirectoryTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).AzureActiveDirectoryTenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).AzureActiveDirectoryTenantId = value ?? null; }

        /// <summary>Client certificates that are allowed to manage the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClientCertificate> Client { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).Client; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).Client = value ?? null /* arrayOf */; }

        /// <summary>The port used for client connections to the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public int? ClientConnectionPort { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).ClientConnectionPort; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).ClientConnectionPort = value ?? default(int); }

        /// <summary>List of thumbprints of the cluster certificates.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> ClusterCertificateThumbprint { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).ClusterCertificateThumbprint; }

        /// <summary>
        /// The Service Fabric runtime version of the cluster. This property is required when **clusterUpgradeMode** is set to 'Manual'.
        /// To get list of available Service Fabric versions for new clusters use [ClusterVersion API](./ClusterVersion.md). To get
        /// the list of available version for existing clusters use **availableClusterVersions**.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string ClusterCodeVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).ClusterCodeVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).ClusterCodeVersion = value ?? null; }

        /// <summary>A service generated unique identifier for the cluster resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string ClusterId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).ClusterId; }

        /// <summary>The current state of the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string ClusterState { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).ClusterState; }

        /// <summary>
        /// Indicates when new cluster runtime version upgrades will be applied after they are released. By default is Wave0. Only
        /// applies when **clusterUpgradeMode** is set to 'Automatic'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string ClusterUpgradeCadence { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).ClusterUpgradeCadence; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).ClusterUpgradeCadence = value ?? null; }

        /// <summary>
        /// The upgrade mode of the cluster when new Service Fabric runtime version is available.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string ClusterUpgradeMode { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).ClusterUpgradeMode; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).ClusterUpgradeMode = value ?? null; }

        /// <summary>
        /// Specify the resource id of a DDoS network protection plan that will be associated with the virtual network of the cluster.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string DdosProtectionPlanId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).DdosProtectionPlanId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).DdosProtectionPlanId = value ?? null; }

        /// <summary>
        /// The maximum allowed percentage of applications health degradation allowed during cluster upgrades.
        /// The delta is measured between the state of the applications at the beginning of upgrade and the state of the applications
        /// at the time of the health evaluation.
        /// The check is performed after every upgrade domain upgrade completion to make sure the global state of the cluster is within
        /// tolerated limits. System services are not included in this.
        /// NOTE: This value will overwrite the value specified in properties.UpgradeDescription.HealthPolicy.MaxPercentUnhealthyApplications
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public int? DeltaHealthPolicyMaxPercentDeltaUnhealthyApplication { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).DeltaHealthPolicyMaxPercentDeltaUnhealthyApplication; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).DeltaHealthPolicyMaxPercentDeltaUnhealthyApplication = value ?? default(int); }

        /// <summary>
        /// The maximum allowed percentage of nodes health degradation allowed during cluster upgrades.
        /// The delta is measured between the state of the nodes at the beginning of upgrade and the state of the nodes at the time
        /// of the health evaluation.
        /// The check is performed after every upgrade domain upgrade completion to make sure the global state of the cluster is within
        /// tolerated limits.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public int? DeltaHealthPolicyMaxPercentDeltaUnhealthyNode { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).DeltaHealthPolicyMaxPercentDeltaUnhealthyNode; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).DeltaHealthPolicyMaxPercentDeltaUnhealthyNode = value ?? default(int); }

        /// <summary>
        /// The maximum allowed percentage of upgrade domain nodes health degradation allowed during cluster upgrades.
        /// The delta is measured between the state of the upgrade domain nodes at the beginning of upgrade and the state of the upgrade
        /// domain nodes at the time of the health evaluation.
        /// The check is performed after every upgrade domain upgrade completion for all completed upgrade domains to make sure the
        /// state of the upgrade domains is within tolerated limits.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public int? DeltaHealthPolicyMaxPercentUpgradeDomainDeltaUnhealthyNode { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).DeltaHealthPolicyMaxPercentUpgradeDomainDeltaUnhealthyNode; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).DeltaHealthPolicyMaxPercentUpgradeDomainDeltaUnhealthyNode = value ?? default(int); }

        /// <summary>The cluster dns name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string DnsName { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).DnsName; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).DnsName = value ?? null; }

        /// <summary>
        /// Enables automatic OS upgrade for node types created using OS images with version 'latest'. The default value for this
        /// setting is false.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public bool? EnableAutoOSUpgrade { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).EnableAutoOSUpgrade; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).EnableAutoOSUpgrade = value ?? default(bool); }

        /// <summary>
        /// If true, token-based authentication is not allowed on the HttpGatewayEndpoint. This is required to support TLS versions
        /// 1.3 and above. If token-based authentication is used, HttpGatewayTokenAuthConnectionPort must be defined.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public bool? EnableHttpGatewayExclusiveAuthMode { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).EnableHttpGatewayExclusiveAuthMode; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).EnableHttpGatewayExclusiveAuthMode = value ?? default(bool); }

        /// <summary>
        /// Setting this to true creates IPv6 address space for the default VNet used by the cluster. This setting cannot be changed
        /// once the cluster is created. The default value for this setting is false.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public bool? EnableIpv6 { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).EnableIpv6; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).EnableIpv6 = value ?? default(bool); }

        /// <summary>
        /// Enable the creation of node types with only outbound traffic enabled. If set, a separate load balancer backend pool will
        /// be created for node types with inbound traffic enabled. Can only be set at the time of cluster creation.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public bool? EnableOutboundOnlyNodeType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).EnableOutboundOnlyNodeType; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).EnableOutboundOnlyNodeType = value ?? default(bool); }

        /// <summary>
        /// Setting this to true will link the IPv4 address as the ServicePublicIP of the IPv6 address. It can only be set to True
        /// if IPv6 is enabled on the cluster.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public bool? EnableServicePublicIP { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).EnableServicePublicIP; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).EnableServicePublicIP = value ?? default(bool); }

        /// <summary>Backing field for <see cref="Etag" /> property.</summary>
        private string _etag;

        /// <summary>
        /// If eTag is provided in the response body, it may also be provided as a header per the normal etag convention. Entity tags
        /// are used for comparing two or more entities from the same requested resource. HTTP/1.1 uses entity tags in the etag (section
        /// 14.19), If-Match (section 14.24), If-None-Match (section 14.26), and If-Range (section 14.27) header fields.",
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string Etag { get => this._etag; }

        /// <summary>The list of custom fabric settings to configure the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISettingsSectionDescription> FabricSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).FabricSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).FabricSetting = value ?? null /* arrayOf */; }

        /// <summary>
        /// The fully qualified domain name associated with the public load balancer of the cluster.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string Fqdn { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).Fqdn; }

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
        public int? HealthPolicyMaxPercentUnhealthyApplication { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).HealthPolicyMaxPercentUnhealthyApplication; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).HealthPolicyMaxPercentUnhealthyApplication = value ?? default(int); }

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
        public int? HealthPolicyMaxPercentUnhealthyNode { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).HealthPolicyMaxPercentUnhealthyNode; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).HealthPolicyMaxPercentUnhealthyNode = value ?? default(int); }

        /// <summary>The port used for HTTP connections to the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public int? HttpGatewayConnectionPort { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).HttpGatewayConnectionPort; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).HttpGatewayConnectionPort = value ?? default(int); }

        /// <summary>
        /// The port used for token-auth based HTTPS connections to the cluster. Cannot be set to the same port as HttpGatewayEndpoint.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public int? HttpGatewayTokenAuthConnectionPort { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).HttpGatewayTokenAuthConnectionPort; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).HttpGatewayTokenAuthConnectionPort = value ?? default(int); }

        /// <summary>
        /// The list of IP tags associated with the default public IP address of the cluster.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPTag> IPTag { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).IPTag; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).IPTag = value ?? null /* arrayOf */; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)__trackedResource).Id; }

        /// <summary>The IPv4 address associated with the public load balancer of the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string Ipv4Address { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).Ipv4Address; }

        /// <summary>IPv6 address for the cluster if IPv6 is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string Ipv6Address { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).Ipv6Address; }

        /// <summary>
        /// Load balancing rules that are applied to the public load balancer of the cluster.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ILoadBalancingRule> LoadBalancingRule { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).LoadBalancingRule; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).LoadBalancingRule = value ?? null /* arrayOf */; }

        /// <summary>The geo-location where the resource lives</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ITrackedResourceInternal)__trackedResource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ITrackedResourceInternal)__trackedResource).Location = value ?? null; }

        /// <summary>Internal Acessors for ApplicationTypeVersionsCleanupPolicy</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationTypeVersionsCleanupPolicy Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterInternal.ApplicationTypeVersionsCleanupPolicy { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).ApplicationTypeVersionsCleanupPolicy; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).ApplicationTypeVersionsCleanupPolicy = value ?? null /* model class */; }

        /// <summary>Internal Acessors for AzureActiveDirectory</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IAzureActiveDirectory Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterInternal.AzureActiveDirectory { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).AzureActiveDirectory; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).AzureActiveDirectory = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ClusterCertificateThumbprint</summary>
        System.Collections.Generic.List<string> Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterInternal.ClusterCertificateThumbprint { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).ClusterCertificateThumbprint; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).ClusterCertificateThumbprint = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for ClusterId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterInternal.ClusterId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).ClusterId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).ClusterId = value ?? null; }

        /// <summary>Internal Acessors for ClusterState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterInternal.ClusterState { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).ClusterState; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).ClusterState = value ?? null; }

        /// <summary>Internal Acessors for Etag</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterInternal.Etag { get => this._etag; set { {_etag = value;} } }

        /// <summary>Internal Acessors for Fqdn</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterInternal.Fqdn { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).Fqdn; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).Fqdn = value ?? null; }

        /// <summary>Internal Acessors for Ipv4Address</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterInternal.Ipv4Address { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).Ipv4Address; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).Ipv4Address = value ?? null; }

        /// <summary>Internal Acessors for Ipv6Address</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterInternal.Ipv6Address { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).Ipv6Address; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).Ipv6Address = value ?? null; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterProperties Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ManagedClusterProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).ProvisioningState = value ?? null; }

        /// <summary>Internal Acessors for Sku</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISku Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterInternal.Sku { get => (this._sku = this._sku ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.Sku()); set { {_sku = value;} } }

        /// <summary>Internal Acessors for UpgradeDescription</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicy Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterInternal.UpgradeDescription { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).UpgradeDescription; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).UpgradeDescription = value ?? null /* model class */; }

        /// <summary>Internal Acessors for UpgradeDescriptionDeltaHealthPolicy</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradeDeltaHealthPolicy Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterInternal.UpgradeDescriptionDeltaHealthPolicy { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).UpgradeDescriptionDeltaHealthPolicy; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).UpgradeDescriptionDeltaHealthPolicy = value ?? null /* model class */; }

        /// <summary>Internal Acessors for UpgradeDescriptionHealthPolicy</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterHealthPolicy Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterInternal.UpgradeDescriptionHealthPolicy { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).UpgradeDescriptionHealthPolicy; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).UpgradeDescriptionHealthPolicy = value ?? null /* model class */; }

        /// <summary>Internal Acessors for UpgradeDescriptionMonitoringPolicy</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterMonitoringPolicy Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterInternal.UpgradeDescriptionMonitoringPolicy { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).UpgradeDescriptionMonitoringPolicy; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).UpgradeDescriptionMonitoringPolicy = value ?? null /* model class */; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)__trackedResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)__trackedResource).Id = value ?? null; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)__trackedResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)__trackedResource).Name = value ?? null; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISystemData Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)__trackedResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)__trackedResource).SystemData = value ?? null /* model class */; }

        /// <summary>Internal Acessors for SystemDataCreatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal.SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)__trackedResource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)__trackedResource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataCreatedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal.SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)__trackedResource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)__trackedResource).SystemDataCreatedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataCreatedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal.SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)__trackedResource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)__trackedResource).SystemDataCreatedByType = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal.SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataLastModifiedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal.SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal.SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedByType = value ?? null; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)__trackedResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)__trackedResource).Type = value ?? null; }

        /// <summary>
        /// The amount of time to retry health evaluation when the application or cluster is unhealthy before the upgrade rolls back.
        /// The timeout can be in either hh:mm:ss or in d.hh:mm:ss.ms format.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string MonitoringPolicyHealthCheckRetryTimeout { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).MonitoringPolicyHealthCheckRetryTimeout; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).MonitoringPolicyHealthCheckRetryTimeout = value ?? null; }

        /// <summary>
        /// The amount of time that the application or cluster must remain healthy before the upgrade proceeds to the next upgrade
        /// domain. The duration can be in either hh:mm:ss or in d.hh:mm:ss.ms format.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string MonitoringPolicyHealthCheckStableDuration { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).MonitoringPolicyHealthCheckStableDuration; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).MonitoringPolicyHealthCheckStableDuration = value ?? null; }

        /// <summary>
        /// The length of time to wait after completing an upgrade domain before performing health checks. The duration can be in
        /// either hh:mm:ss or in d.hh:mm:ss.ms format.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string MonitoringPolicyHealthCheckWaitDuration { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).MonitoringPolicyHealthCheckWaitDuration; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).MonitoringPolicyHealthCheckWaitDuration = value ?? null; }

        /// <summary>
        /// The amount of time each upgrade domain has to complete before the upgrade rolls back. The timeout can be in either hh:mm:ss
        /// or in d.hh:mm:ss.ms format.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string MonitoringPolicyUpgradeDomainTimeout { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).MonitoringPolicyUpgradeDomainTimeout; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).MonitoringPolicyUpgradeDomainTimeout = value ?? null; }

        /// <summary>
        /// The amount of time the overall upgrade has to complete before the upgrade rolls back. The timeout can be in either hh:mm:ss
        /// or in d.hh:mm:ss.ms format.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string MonitoringPolicyUpgradeTimeout { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).MonitoringPolicyUpgradeTimeout; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).MonitoringPolicyUpgradeTimeout = value ?? null; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)__trackedResource).Name; }

        /// <summary>
        /// Custom Network Security Rules that are applied to the Virtual Network of the cluster.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INetworkSecurityRule> NetworkSecurityRule { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).NetworkSecurityRule; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).NetworkSecurityRule = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterProperties _property;

        /// <summary>The managed cluster resource properties</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ManagedClusterProperties()); set => this._property = value; }

        /// <summary>The provisioning state of the managed cluster resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).ProvisioningState; }

        /// <summary>
        /// Specify the resource id of a public IPv4 prefix that the load balancer will allocate a public IPv4 address from. This
        /// setting cannot be changed once the cluster is created.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string PublicIPPrefixId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).PublicIPPrefixId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).PublicIPPrefixId = value ?? null; }

        /// <summary>
        /// Specify the resource id of a public IPv6 prefix that the load balancer will allocate a public IPv6 address from. This
        /// setting cannot be changed once the cluster is created.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string PublicIPv6PrefixId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).PublicIPv6PrefixId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).PublicIPv6PrefixId = value ?? null; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>Service endpoints for subnets in the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceEndpoint> ServiceEndpoint { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).ServiceEndpoint; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).ServiceEndpoint = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="Sku" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISku _sku;

        /// <summary>The sku of the managed cluster</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISku Sku { get => (this._sku = this._sku ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.Sku()); set => this._sku = value; }

        /// <summary>Sku Name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string SkuName { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISkuInternal)Sku).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISkuInternal)Sku).Name = value ; }

        /// <summary>
        /// If specified, the node types for the cluster are created in this subnet instead of the default VNet. The **networkSecurityRules**
        /// specified for the cluster are also applied to this subnet. This setting cannot be changed once the cluster is created.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string SubnetId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).SubnetId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).SubnetId = value ?? null; }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)__trackedResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)__trackedResource).SystemData = value ?? null /* model class */; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)__trackedResource).SystemDataCreatedAt; }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)__trackedResource).SystemDataCreatedBy; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inherited)]
        public string SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)__trackedResource).SystemDataCreatedByType; }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedAt; }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedBy; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedByType; }

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ITrackedResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ITrackedResourceInternal)__trackedResource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ITrackedResourceInternal)__trackedResource).Tag = value ?? null /* model class */; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)__trackedResource).Type; }

        /// <summary>
        /// If true, then processes are forcefully restarted during upgrade even when the code version has not changed (the upgrade
        /// only changes configuration or data).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public bool? UpgradeDescriptionForceRestart { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).UpgradeDescriptionForceRestart; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).UpgradeDescriptionForceRestart = value ?? default(bool); }

        /// <summary>
        /// The maximum amount of time to block processing of an upgrade domain and prevent loss of availability when there are unexpected
        /// issues.
        /// When this timeout expires, processing of the upgrade domain will proceed regardless of availability loss issues.
        /// The timeout is reset at the start of each upgrade domain. The timeout can be in either hh:mm:ss or in d.hh:mm:ss.ms format.
        /// This value must be between 00:00:00 and 49710.06:28:15 (unsigned 32 bit integer for seconds)
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string UpgradeDescriptionUpgradeReplicaSetCheckTimeout { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).UpgradeDescriptionUpgradeReplicaSetCheckTimeout; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).UpgradeDescriptionUpgradeReplicaSetCheckTimeout = value ?? null; }

        /// <summary>
        /// For new clusters, this parameter indicates that it uses Bring your own VNet, but the subnet is specified at node type
        /// level; and for such clusters, the subnetId property is required for node types.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public bool? UseCustomVnet { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).UseCustomVnet; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).UseCustomVnet = value ?? default(bool); }

        /// <summary>
        /// The VM image the node types are configured with. This property controls the Service Fabric component packages to be used
        /// for the cluster. Allowed values are: 'Windows'. The default value is 'Windows'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string VMImage { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).VMImage; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).VMImage = value ?? null; }

        /// <summary>Indicates if the cluster has zone resiliency.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public bool? ZonalResiliency { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).ZonalResiliency; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).ZonalResiliency = value ?? default(bool); }

        /// <summary>Indicates the update mode for Cross Az clusters.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string ZonalUpdateMode { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).ZonalUpdateMode; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)Property).ZonalUpdateMode = value ?? null; }

        /// <summary>Creates an new <see cref="ManagedCluster" /> instance.</summary>
        public ManagedCluster()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__trackedResource), __trackedResource);
            await eventListener.AssertObjectIsValid(nameof(__trackedResource), __trackedResource);
        }
    }
    /// The managed cluster resource
    public partial interface IManagedCluster :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ITrackedResource
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
        Required = false,
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
        Required = false,
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
        /// <summary>
        /// If eTag is provided in the response body, it may also be provided as a header per the normal etag convention. Entity tags
        /// are used for comparing two or more entities from the same requested resource. HTTP/1.1 uses entity tags in the etag (section
        /// 14.19), If-Match (section 14.24), If-None-Match (section 14.26), and If-Range (section 14.27) header fields.",
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"If eTag is provided in the response body, it may also be provided as a header per the normal etag convention.  Entity tags are used for comparing two or more entities from the same requested resource. HTTP/1.1 uses entity tags in the etag (section 14.19), If-Match (section 14.24), If-None-Match (section 14.26), and If-Range (section 14.27) header fields."",",
        SerializedName = @"etag",
        PossibleTypes = new [] { typeof(string) })]
        string Etag { get;  }
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
        /// <summary>Sku Name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Sku Name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("Basic", "Standard")]
        string SkuName { get; set; }
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
    /// The managed cluster resource
    internal partial interface IManagedClusterInternal :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ITrackedResourceInternal
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
        /// <summary>
        /// If eTag is provided in the response body, it may also be provided as a header per the normal etag convention. Entity tags
        /// are used for comparing two or more entities from the same requested resource. HTTP/1.1 uses entity tags in the etag (section
        /// 14.19), If-Match (section 14.24), If-None-Match (section 14.26), and If-Range (section 14.27) header fields.",
        /// </summary>
        string Etag { get; set; }
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
        /// <summary>The managed cluster resource properties</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterProperties Property { get; set; }
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
        /// <summary>The sku of the managed cluster</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISku Sku { get; set; }
        /// <summary>Sku Name.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("Basic", "Standard")]
        string SkuName { get; set; }
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