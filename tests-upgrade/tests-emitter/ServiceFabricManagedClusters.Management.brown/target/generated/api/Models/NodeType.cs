// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>
    /// Describes a node type in the cluster, each node type represents sub set of nodes in the cluster.
    /// </summary>
    public partial class NodeType :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeType,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeInternal,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IProxyResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IProxyResource __proxyResource = new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ProxyResource();

        /// <summary>Additional managed data disks.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVmssDataDisk> AdditionalDataDisk { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).AdditionalDataDisk; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).AdditionalDataDisk = value ?? null /* arrayOf */; }

        /// <summary>
        /// Specifies the settings for any additional secondary network interfaces to attach to the node type.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IAdditionalNetworkInterfaceConfiguration> AdditionalNetworkInterfaceConfiguration { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).AdditionalNetworkInterfaceConfiguration; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).AdditionalNetworkInterfaceConfiguration = value ?? null /* arrayOf */; }

        /// <summary>End port of a range of ports</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public int? ApplicationPortEndPort { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).ApplicationPortEndPort; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).ApplicationPortEndPort = value ?? default(int); }

        /// <summary>Starting port of a range of ports</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public int? ApplicationPortStartPort { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).ApplicationPortStartPort; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).ApplicationPortStartPort = value ?? default(int); }

        /// <summary>
        /// The capacity tags applied to the nodes in the node type, the cluster resource manager uses these tags to understand how
        /// much resource a node has.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesCapacities Capacity { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).Capacity; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).Capacity = value ?? null /* model class */; }

        /// <summary>
        /// Specifies the computer name prefix. Limited to 9 characters. If specified, allows for a longer name to be specified for
        /// the node type name.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string ComputerNamePrefix { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).ComputerNamePrefix; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).ComputerNamePrefix = value ?? null; }

        /// <summary>
        /// Managed data disk letter. It can not use the reserved letter C or D and it can not change after created.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string DataDiskLetter { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).DataDiskLetter; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).DataDiskLetter = value ?? null; }

        /// <summary>Disk size for the managed disk attached to the vms on the node type in GBs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public int? DataDiskSizeGb { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).DataDiskSizeGb; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).DataDiskSizeGb = value ?? default(int); }

        /// <summary>Managed data disk type. Specifies the storage account type for the managed disk</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string DataDiskType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).DataDiskType; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).DataDiskType = value ?? null; }

        /// <summary>
        /// Specifies the resource id of the DSCP configuration to apply to the node type network interface.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string DscpConfigurationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).DscpConfigurationId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).DscpConfigurationId = value ?? null; }

        /// <summary>Specifies whether the network interface is accelerated networking-enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public bool? EnableAcceleratedNetworking { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).EnableAcceleratedNetworking; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).EnableAcceleratedNetworking = value ?? default(bool); }

        /// <summary>
        /// Enable or disable the Host Encryption for the virtual machines on the node type. This will enable the encryption for all
        /// the disks including Resource/Temp disk at host itself. Default: The Encryption at host will be disabled unless this property
        /// is set to true for the resource.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public bool? EnableEncryptionAtHost { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).EnableEncryptionAtHost; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).EnableEncryptionAtHost = value ?? default(bool); }

        /// <summary>
        /// Specifies whether each node is allocated its own public IPv4 address. This is only supported on secondary node types with
        /// custom Load Balancers.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public bool? EnableNodePublicIP { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).EnableNodePublicIP; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).EnableNodePublicIP = value ?? default(bool); }

        /// <summary>
        /// Specifies whether each node is allocated its own public IPv6 address. This is only supported on secondary node types with
        /// custom Load Balancers.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public bool? EnableNodePublicIPv6 { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).EnableNodePublicIPv6; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).EnableNodePublicIPv6 = value ?? default(bool); }

        /// <summary>
        /// Specifies whether the node type should be overprovisioned. It is only allowed for stateless node types.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public bool? EnableOverProvisioning { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).EnableOverProvisioning; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).EnableOverProvisioning = value ?? default(bool); }

        /// <summary>End port of a range of ports</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public int? EphemeralPortEndPort { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).EphemeralPortEndPort; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).EphemeralPortEndPort = value ?? default(int); }

        /// <summary>Starting port of a range of ports</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public int? EphemeralPortStartPort { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).EphemeralPortStartPort; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).EphemeralPortStartPort = value ?? default(int); }

        /// <summary>
        /// Specifies the eviction policy for virtual machines in a SPOT node type. Default is Delete.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string EvictionPolicy { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).EvictionPolicy; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).EvictionPolicy = value ?? null; }

        /// <summary>
        /// Indicates the node type uses its own frontend configurations instead of the default one for the cluster. This setting
        /// can only be specified for non-primary node types and can not be added or removed after the node type is created.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFrontendConfiguration> FrontendConfiguration { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).FrontendConfiguration; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).FrontendConfiguration = value ?? null /* arrayOf */; }

        /// <summary>
        /// Specifies the full host group resource Id. This property is used for deploying on azure dedicated hosts.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string HostGroupId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).HostGroupId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).HostGroupId = value ?? null; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)__proxyResource).Id; }

        /// <summary>
        /// Specifies the node type should be configured for only outbound traffic and not inbound traffic.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public bool? IsOutboundOnly { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).IsOutboundOnly; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).IsOutboundOnly = value ?? default(bool); }

        /// <summary>
        /// Indicates the Service Fabric system services for the cluster will run on this node type. This setting cannot be changed
        /// once the node type is created.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public bool? IsPrimary { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).IsPrimary; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).IsPrimary = value ?? default(bool); }

        /// <summary>
        /// Indicates whether the node type will be Spot Virtual Machines. Azure will allocate the VMs if there is capacity available
        /// and the VMs can be evicted at any time.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public bool? IsSpotVM { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).IsSpotVM; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).IsSpotVM = value ?? default(bool); }

        /// <summary>Indicates if the node type can only host Stateless workloads.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public bool? IsStateless { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).IsStateless; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).IsStateless = value ?? default(bool); }

        /// <summary>Internal Acessors for ApplicationPort</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IEndpointRangeDescription Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeInternal.ApplicationPort { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).ApplicationPort; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).ApplicationPort = value ?? null /* model class */; }

        /// <summary>Internal Acessors for EphemeralPort</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IEndpointRangeDescription Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeInternal.EphemeralPort { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).EphemeralPort; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).EphemeralPort = value ?? null /* model class */; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeProperties Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.NodeTypeProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).ProvisioningState = value ?? null; }

        /// <summary>Internal Acessors for Sku</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeSku Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeInternal.Sku { get => (this._sku = this._sku ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.NodeTypeSku()); set { {_sku = value;} } }

        /// <summary>Internal Acessors for VMImagePlan</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVMImagePlan Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeInternal.VMImagePlan { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).VMImagePlan; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).VMImagePlan = value ?? null /* model class */; }

        /// <summary>Internal Acessors for VMManagedIdentity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVMManagedIdentity Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeInternal.VMManagedIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).VMManagedIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).VMManagedIdentity = value ?? null /* model class */; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)__proxyResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)__proxyResource).Id = value ?? null; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)__proxyResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)__proxyResource).Name = value ?? null; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISystemData Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)__proxyResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)__proxyResource).SystemData = value ?? null /* model class */; }

        /// <summary>Internal Acessors for SystemDataCreatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal.SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataCreatedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal.SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataCreatedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal.SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal.SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataLastModifiedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal.SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal.SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType = value ?? null; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)__proxyResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)__proxyResource).Type = value ?? null; }

        /// <summary>
        /// Indicates if scale set associated with the node type can be composed of multiple placement groups.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public bool? MultiplePlacementGroup { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).MultiplePlacementGroup; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).MultiplePlacementGroup = value ?? default(bool); }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)__proxyResource).Name; }

        /// <summary>
        /// Specifies the NAT configuration on default public Load Balancer for the node type. This is only supported for node types
        /// use the default public Load Balancer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeNatConfig> NatConfiguration { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).NatConfiguration; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).NatConfiguration = value ?? null /* arrayOf */; }

        /// <summary>
        /// Specifies the resource id of a NAT Gateway to attach to the subnet of this node type. Node type must use custom load balancer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string NatGatewayId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).NatGatewayId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).NatGatewayId = value ?? null; }

        /// <summary>
        /// The Network Security Rules for this node type. This setting can only be specified for node types that are configured with
        /// frontend configurations.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INetworkSecurityRule> NetworkSecurityRule { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).NetworkSecurityRule; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).NetworkSecurityRule = value ?? null /* arrayOf */; }

        /// <summary>
        /// The placement tags applied to nodes in the node type, which can be used to indicate where certain services (workload)
        /// should run.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesPlacementProperties PlacementProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).PlacementProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).PlacementProperty = value ?? null /* model class */; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeProperties _property;

        /// <summary>The node type properties</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.NodeTypeProperties()); set => this._property = value; }

        /// <summary>The provisioning state of the node type resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).ProvisioningState; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>
        /// Specifies whether secure boot should be enabled on the nodeType. Can only be used with TrustedLaunch and ConfidentialVM
        /// SecurityType.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public bool? SecureBootEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).SecureBootEnabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).SecureBootEnabled = value ?? default(bool); }

        /// <summary>
        /// Specifies the EncryptionType of the managed disk. It is set to DiskWithVMGuestState for encryption of the managed disk
        /// along with VMGuestState blob and VMGuestStateOnly for encryption of just the VMGuestState blob. Note: It can be set for
        /// only Confidential VMs.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string SecurityEncryptionType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).SecurityEncryptionType; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).SecurityEncryptionType = value ?? null; }

        /// <summary>
        /// Specifies the security type of the nodeType. Supported values include Standard, TrustedLaunch and ConfidentialVM.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string SecurityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).SecurityType; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).SecurityType = value ?? null; }

        /// <summary>
        /// Specifies the service artifact reference id used to set same image version for all virtual machines in the scale set when
        /// using 'latest' image version.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string ServiceArtifactReferenceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).ServiceArtifactReferenceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).ServiceArtifactReferenceId = value ?? null; }

        /// <summary>Backing field for <see cref="Sku" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeSku _sku;

        /// <summary>The node type sku.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeSku Sku { get => (this._sku = this._sku ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.NodeTypeSku()); set => this._sku = value; }

        /// <summary>
        /// The number of nodes in the node type. If present in request it will override properties.vmInstanceCount.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public int? SkuCapacity { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeSkuInternal)Sku).Capacity; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeSkuInternal)Sku).Capacity = value ?? default(int); }

        /// <summary>
        /// The sku name. Name is internally generated and is used in auto-scale scenarios. Property does not allow to be changed
        /// to other values than generated. To avoid deployment errors please omit the property.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string SkuName { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeSkuInternal)Sku).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeSkuInternal)Sku).Name = value ?? null; }

        /// <summary>Specifies the tier of the node type. Possible Values: **Standard**</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string SkuTier { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeSkuInternal)Sku).Tier; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeSkuInternal)Sku).Tier = value ?? null; }

        /// <summary>
        /// Indicates the time duration after which the platform will not try to restore the VMSS SPOT instances specified as ISO
        /// 8601.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string SpotRestoreTimeout { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).SpotRestoreTimeout; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).SpotRestoreTimeout = value ?? null; }

        /// <summary>Indicates the resource id of the subnet for the node type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string SubnetId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).SubnetId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).SubnetId = value ?? null; }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)__proxyResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)__proxyResource).SystemData = value ?? null /* model class */; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt; }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inherited)]
        public string SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType; }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt; }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType; }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeTags _tag;

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.NodeTypeTags()); set => this._tag = value; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)__proxyResource).Type; }

        /// <summary>
        /// Specifies whether the use public load balancer. If not specified and the node type doesn't have its own frontend configuration,
        /// it will be attached to the default load balancer. If the node type uses its own Load balancer and useDefaultPublicLoadBalancer
        /// is true, then the frontend has to be an Internal Load Balancer. If the node type uses its own Load balancer and useDefaultPublicLoadBalancer
        /// is false or not set, then the custom load balancer must include a public load balancer to provide outbound connectivity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public bool? UseDefaultPublicLoadBalancer { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).UseDefaultPublicLoadBalancer; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).UseDefaultPublicLoadBalancer = value ?? default(bool); }

        /// <summary>
        /// Indicates whether to use ephemeral os disk. The sku selected on the vmSize property needs to support this feature.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public bool? UseEphemeralOSDisk { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).UseEphemeralOSDisk; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).UseEphemeralOSDisk = value ?? default(bool); }

        /// <summary>
        /// Specifies whether to use the temporary disk for the service fabric data root, in which case no managed data disk will
        /// be attached and the temporary disk will be used. It is only allowed for stateless node types.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public bool? UseTempDataDisk { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).UseTempDataDisk; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).UseTempDataDisk = value ?? default(bool); }

        /// <summary>
        /// Specifies the gallery applications that should be made available to the underlying VMSS.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVMApplication> VMApplication { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).VMApplication; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).VMApplication = value ?? null /* arrayOf */; }

        /// <summary>Set of extensions that should be installed onto the virtual machines.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVmssExtension> VMExtension { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).VMExtension; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).VMExtension = value ?? null /* arrayOf */; }

        /// <summary>
        /// The offer type of the Azure Virtual Machines Marketplace image. For example, UbuntuServer or WindowsServer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string VMImageOffer { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).VMImageOffer; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).VMImageOffer = value ?? null; }

        /// <summary>The plan ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string VMImagePlanName { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).VMImagePlanName; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).VMImagePlanName = value ?? null; }

        /// <summary>
        /// Specifies the product of the image from the marketplace. This is the same value as Offer under the imageReference element.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string VMImagePlanProduct { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).VMImagePlanProduct; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).VMImagePlanProduct = value ?? null; }

        /// <summary>The promotion code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string VMImagePlanPromotionCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).VMImagePlanPromotionCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).VMImagePlanPromotionCode = value ?? null; }

        /// <summary>The publisher ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string VMImagePlanPublisher { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).VMImagePlanPublisher; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).VMImagePlanPublisher = value ?? null; }

        /// <summary>
        /// The publisher of the Azure Virtual Machines Marketplace image. For example, Canonical or MicrosoftWindowsServer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string VMImagePublisher { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).VMImagePublisher; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).VMImagePublisher = value ?? null; }

        /// <summary>
        /// Indicates the resource id of the vm image. This parameter is used for custom vm image.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string VMImageResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).VMImageResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).VMImageResourceId = value ?? null; }

        /// <summary>
        /// The SKU of the Azure Virtual Machines Marketplace image. For example, 14.04.0-LTS or 2012-R2-Datacenter.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string VMImageSku { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).VMImageSku; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).VMImageSku = value ?? null; }

        /// <summary>
        /// The version of the Azure Virtual Machines Marketplace image. A value of 'latest' can be specified to select the latest
        /// version of an image. If omitted, the default is 'latest'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string VMImageVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).VMImageVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).VMImageVersion = value ?? null; }

        /// <summary>
        /// The number of nodes in the node type. **Values:** -1 - Use when auto scale rules are configured or sku.capacity is defined
        /// 0 - Not supported >0 - Use for manual scale.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public int? VMInstanceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).VMInstanceCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).VMInstanceCount = value ?? default(int); }

        /// <summary>
        /// The list of user identities associated with the virtual machine scale set under the node type. Each entry will be an ARM
        /// resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> VMManagedIdentityUserAssignedIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).VMManagedIdentityUserAssignedIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).VMManagedIdentityUserAssignedIdentity = value ?? null /* arrayOf */; }

        /// <summary>The secrets to install in the virtual machines.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVaultSecretGroup> VMSecret { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).VMSecret; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).VMSecret = value ?? null /* arrayOf */; }

        /// <summary>
        /// Specifies the actions to be performed on the vms before bootstrapping the service fabric runtime.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> VMSetupAction { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).VMSetupAction; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).VMSetupAction = value ?? null /* arrayOf */; }

        /// <summary>
        /// Indicates the resource id of the vm shared galleries image. This parameter is used for custom vm image.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string VMSharedGalleryImageId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).VMSharedGalleryImageId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).VMSharedGalleryImageId = value ?? null; }

        /// <summary>
        /// The size of virtual machines in the pool. All virtual machines in a pool are the same size. For example, Standard_D3.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string VMSize { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).VMSize; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).VMSize = value ?? null; }

        /// <summary>
        /// Specifies the availability zones where the node type would span across. If the cluster is not spanning across availability
        /// zones, initiates az migration for the cluster.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> Zone { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).Zone; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).Zone = value ?? null /* arrayOf */; }

        /// <summary>
        /// Setting this to true allows stateless node types to scale out without equal distribution across zones.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public bool? ZoneBalance { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).ZoneBalance; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)Property).ZoneBalance = value ?? default(bool); }

        /// <summary>Creates an new <see cref="NodeType" /> instance.</summary>
        public NodeType()
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
            await eventListener.AssertNotNull(nameof(__proxyResource), __proxyResource);
            await eventListener.AssertObjectIsValid(nameof(__proxyResource), __proxyResource);
        }
    }
    /// Describes a node type in the cluster, each node type represents sub set of nodes in the cluster.
    public partial interface INodeType :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IProxyResource
    {
        /// <summary>Additional managed data disks.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Additional managed data disks.",
        SerializedName = @"additionalDataDisks",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVmssDataDisk) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVmssDataDisk> AdditionalDataDisk { get; set; }
        /// <summary>
        /// Specifies the settings for any additional secondary network interfaces to attach to the node type.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the settings for any additional secondary network interfaces to attach to the node type.",
        SerializedName = @"additionalNetworkInterfaceConfigurations",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IAdditionalNetworkInterfaceConfiguration) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IAdditionalNetworkInterfaceConfiguration> AdditionalNetworkInterfaceConfiguration { get; set; }
        /// <summary>End port of a range of ports</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"End port of a range of ports",
        SerializedName = @"endPort",
        PossibleTypes = new [] { typeof(int) })]
        int? ApplicationPortEndPort { get; set; }
        /// <summary>Starting port of a range of ports</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Starting port of a range of ports",
        SerializedName = @"startPort",
        PossibleTypes = new [] { typeof(int) })]
        int? ApplicationPortStartPort { get; set; }
        /// <summary>
        /// The capacity tags applied to the nodes in the node type, the cluster resource manager uses these tags to understand how
        /// much resource a node has.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The capacity tags applied to the nodes in the node type, the cluster resource manager uses these tags to understand how much resource a node has.",
        SerializedName = @"capacities",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesCapacities) })]
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesCapacities Capacity { get; set; }
        /// <summary>
        /// Specifies the computer name prefix. Limited to 9 characters. If specified, allows for a longer name to be specified for
        /// the node type name.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the computer name prefix. Limited to 9 characters. If specified, allows for a longer name to be specified for the node type name.",
        SerializedName = @"computerNamePrefix",
        PossibleTypes = new [] { typeof(string) })]
        string ComputerNamePrefix { get; set; }
        /// <summary>
        /// Managed data disk letter. It can not use the reserved letter C or D and it can not change after created.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Managed data disk letter. It can not use the reserved letter C or D and it can not change after created.",
        SerializedName = @"dataDiskLetter",
        PossibleTypes = new [] { typeof(string) })]
        string DataDiskLetter { get; set; }
        /// <summary>Disk size for the managed disk attached to the vms on the node type in GBs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Disk size for the managed disk attached to the vms on the node type in GBs.",
        SerializedName = @"dataDiskSizeGB",
        PossibleTypes = new [] { typeof(int) })]
        int? DataDiskSizeGb { get; set; }
        /// <summary>Managed data disk type. Specifies the storage account type for the managed disk</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Managed data disk type. Specifies the storage account type for the managed disk",
        SerializedName = @"dataDiskType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("Standard_LRS", "StandardSSD_LRS", "Premium_LRS", "PremiumV2_LRS", "StandardSSD_ZRS", "Premium_ZRS")]
        string DataDiskType { get; set; }
        /// <summary>
        /// Specifies the resource id of the DSCP configuration to apply to the node type network interface.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the resource id of the DSCP configuration to apply to the node type network interface.",
        SerializedName = @"dscpConfigurationId",
        PossibleTypes = new [] { typeof(string) })]
        string DscpConfigurationId { get; set; }
        /// <summary>Specifies whether the network interface is accelerated networking-enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies whether the network interface is accelerated networking-enabled.",
        SerializedName = @"enableAcceleratedNetworking",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnableAcceleratedNetworking { get; set; }
        /// <summary>
        /// Enable or disable the Host Encryption for the virtual machines on the node type. This will enable the encryption for all
        /// the disks including Resource/Temp disk at host itself. Default: The Encryption at host will be disabled unless this property
        /// is set to true for the resource.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Enable or disable the Host Encryption for the virtual machines on the node type. This will enable the encryption for all the disks including Resource/Temp disk at host itself. Default: The Encryption at host will be disabled unless this property is set to true for the resource.",
        SerializedName = @"enableEncryptionAtHost",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnableEncryptionAtHost { get; set; }
        /// <summary>
        /// Specifies whether each node is allocated its own public IPv4 address. This is only supported on secondary node types with
        /// custom Load Balancers.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies whether each node is allocated its own public IPv4 address. This is only supported on secondary node types with custom Load Balancers.",
        SerializedName = @"enableNodePublicIP",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnableNodePublicIP { get; set; }
        /// <summary>
        /// Specifies whether each node is allocated its own public IPv6 address. This is only supported on secondary node types with
        /// custom Load Balancers.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies whether each node is allocated its own public IPv6 address. This is only supported on secondary node types with custom Load Balancers.",
        SerializedName = @"enableNodePublicIPv6",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnableNodePublicIPv6 { get; set; }
        /// <summary>
        /// Specifies whether the node type should be overprovisioned. It is only allowed for stateless node types.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies whether the node type should be overprovisioned. It is only allowed for stateless node types.",
        SerializedName = @"enableOverProvisioning",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnableOverProvisioning { get; set; }
        /// <summary>End port of a range of ports</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"End port of a range of ports",
        SerializedName = @"endPort",
        PossibleTypes = new [] { typeof(int) })]
        int? EphemeralPortEndPort { get; set; }
        /// <summary>Starting port of a range of ports</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Starting port of a range of ports",
        SerializedName = @"startPort",
        PossibleTypes = new [] { typeof(int) })]
        int? EphemeralPortStartPort { get; set; }
        /// <summary>
        /// Specifies the eviction policy for virtual machines in a SPOT node type. Default is Delete.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the eviction policy for virtual machines in a SPOT node type. Default is Delete.",
        SerializedName = @"evictionPolicy",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("Delete", "Deallocate")]
        string EvictionPolicy { get; set; }
        /// <summary>
        /// Indicates the node type uses its own frontend configurations instead of the default one for the cluster. This setting
        /// can only be specified for non-primary node types and can not be added or removed after the node type is created.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Indicates the node type uses its own frontend configurations instead of the default one for the cluster. This setting can only be specified for non-primary node types and can not be added or removed after the node type is created.",
        SerializedName = @"frontendConfigurations",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFrontendConfiguration) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFrontendConfiguration> FrontendConfiguration { get; set; }
        /// <summary>
        /// Specifies the full host group resource Id. This property is used for deploying on azure dedicated hosts.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the full host group resource Id. This property is used for deploying on azure dedicated hosts.",
        SerializedName = @"hostGroupId",
        PossibleTypes = new [] { typeof(string) })]
        string HostGroupId { get; set; }
        /// <summary>
        /// Specifies the node type should be configured for only outbound traffic and not inbound traffic.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the node type should be configured for only outbound traffic and not inbound traffic.",
        SerializedName = @"isOutboundOnly",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsOutboundOnly { get; set; }
        /// <summary>
        /// Indicates the Service Fabric system services for the cluster will run on this node type. This setting cannot be changed
        /// once the node type is created.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Indicates the Service Fabric system services for the cluster will run on this node type. This setting cannot be changed once the node type is created.",
        SerializedName = @"isPrimary",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsPrimary { get; set; }
        /// <summary>
        /// Indicates whether the node type will be Spot Virtual Machines. Azure will allocate the VMs if there is capacity available
        /// and the VMs can be evicted at any time.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Indicates whether the node type will be Spot Virtual Machines. Azure will allocate the VMs if there is capacity available and the VMs can be evicted at any time.",
        SerializedName = @"isSpotVM",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsSpotVM { get; set; }
        /// <summary>Indicates if the node type can only host Stateless workloads.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Indicates if the node type can only host Stateless workloads.",
        SerializedName = @"isStateless",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsStateless { get; set; }
        /// <summary>
        /// Indicates if scale set associated with the node type can be composed of multiple placement groups.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Indicates if scale set associated with the node type can be composed of multiple placement groups.",
        SerializedName = @"multiplePlacementGroups",
        PossibleTypes = new [] { typeof(bool) })]
        bool? MultiplePlacementGroup { get; set; }
        /// <summary>
        /// Specifies the NAT configuration on default public Load Balancer for the node type. This is only supported for node types
        /// use the default public Load Balancer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the NAT configuration on default public Load Balancer for the node type. This is only supported for node types use the default public Load Balancer.",
        SerializedName = @"natConfigurations",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeNatConfig) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeNatConfig> NatConfiguration { get; set; }
        /// <summary>
        /// Specifies the resource id of a NAT Gateway to attach to the subnet of this node type. Node type must use custom load balancer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the resource id of a NAT Gateway to attach to the subnet of this node type. Node type must use custom load balancer.",
        SerializedName = @"natGatewayId",
        PossibleTypes = new [] { typeof(string) })]
        string NatGatewayId { get; set; }
        /// <summary>
        /// The Network Security Rules for this node type. This setting can only be specified for node types that are configured with
        /// frontend configurations.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The Network Security Rules for this node type. This setting can only be specified for node types that are configured with frontend configurations.",
        SerializedName = @"networkSecurityRules",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INetworkSecurityRule) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INetworkSecurityRule> NetworkSecurityRule { get; set; }
        /// <summary>
        /// The placement tags applied to nodes in the node type, which can be used to indicate where certain services (workload)
        /// should run.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The placement tags applied to nodes in the node type, which can be used to indicate where certain services (workload) should run.",
        SerializedName = @"placementProperties",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesPlacementProperties) })]
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesPlacementProperties PlacementProperty { get; set; }
        /// <summary>The provisioning state of the node type resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The provisioning state of the node type resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("None", "Creating", "Created", "Updating", "Succeeded", "Failed", "Canceled", "Deleting", "Deleted", "Other")]
        string ProvisioningState { get;  }
        /// <summary>
        /// Specifies whether secure boot should be enabled on the nodeType. Can only be used with TrustedLaunch and ConfidentialVM
        /// SecurityType.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies whether secure boot should be enabled on the nodeType. Can only be used with TrustedLaunch and ConfidentialVM SecurityType.",
        SerializedName = @"secureBootEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SecureBootEnabled { get; set; }
        /// <summary>
        /// Specifies the EncryptionType of the managed disk. It is set to DiskWithVMGuestState for encryption of the managed disk
        /// along with VMGuestState blob and VMGuestStateOnly for encryption of just the VMGuestState blob. Note: It can be set for
        /// only Confidential VMs.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the EncryptionType of the managed disk. It is set to DiskWithVMGuestState for encryption of the managed disk along with VMGuestState blob and VMGuestStateOnly for encryption of just the VMGuestState blob. Note: It can be set for only Confidential VMs.",
        SerializedName = @"securityEncryptionType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("DiskWithVMGuestState", "VMGuestStateOnly")]
        string SecurityEncryptionType { get; set; }
        /// <summary>
        /// Specifies the security type of the nodeType. Supported values include Standard, TrustedLaunch and ConfidentialVM.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the security type of the nodeType. Supported values include Standard, TrustedLaunch and ConfidentialVM.",
        SerializedName = @"securityType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("TrustedLaunch", "Standard", "ConfidentialVM")]
        string SecurityType { get; set; }
        /// <summary>
        /// Specifies the service artifact reference id used to set same image version for all virtual machines in the scale set when
        /// using 'latest' image version.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the service artifact reference id used to set same image version for all virtual machines in the scale set when using 'latest' image version.",
        SerializedName = @"serviceArtifactReferenceId",
        PossibleTypes = new [] { typeof(string) })]
        string ServiceArtifactReferenceId { get; set; }
        /// <summary>
        /// The number of nodes in the node type. If present in request it will override properties.vmInstanceCount.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The number of nodes in the node type. If present in request it will override properties.vmInstanceCount.",
        SerializedName = @"capacity",
        PossibleTypes = new [] { typeof(int) })]
        int? SkuCapacity { get; set; }
        /// <summary>
        /// The sku name. Name is internally generated and is used in auto-scale scenarios. Property does not allow to be changed
        /// to other values than generated. To avoid deployment errors please omit the property.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The sku name. Name is internally generated and is used in auto-scale scenarios. Property does not allow to be changed to other values than generated. To avoid deployment errors please omit the property.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string SkuName { get; set; }
        /// <summary>Specifies the tier of the node type. Possible Values: **Standard**</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the tier of the node type. Possible Values: **Standard**",
        SerializedName = @"tier",
        PossibleTypes = new [] { typeof(string) })]
        string SkuTier { get; set; }
        /// <summary>
        /// Indicates the time duration after which the platform will not try to restore the VMSS SPOT instances specified as ISO
        /// 8601.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Indicates the time duration after which the platform will not try to restore the VMSS SPOT instances specified as ISO 8601.",
        SerializedName = @"spotRestoreTimeout",
        PossibleTypes = new [] { typeof(string) })]
        string SpotRestoreTimeout { get; set; }
        /// <summary>Indicates the resource id of the subnet for the node type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Indicates the resource id of the subnet for the node type.",
        SerializedName = @"subnetId",
        PossibleTypes = new [] { typeof(string) })]
        string SubnetId { get; set; }
        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource tags.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeTags Tag { get; set; }
        /// <summary>
        /// Specifies whether the use public load balancer. If not specified and the node type doesn't have its own frontend configuration,
        /// it will be attached to the default load balancer. If the node type uses its own Load balancer and useDefaultPublicLoadBalancer
        /// is true, then the frontend has to be an Internal Load Balancer. If the node type uses its own Load balancer and useDefaultPublicLoadBalancer
        /// is false or not set, then the custom load balancer must include a public load balancer to provide outbound connectivity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies whether the use public load balancer. If not specified and the node type doesn't have its own frontend configuration, it will be attached to the default load balancer. If the node type uses its own Load balancer and useDefaultPublicLoadBalancer is true, then the frontend has to be an Internal Load Balancer. If the node type uses its own Load balancer and useDefaultPublicLoadBalancer is false or not set, then the custom load balancer must include a public load balancer to provide outbound connectivity.",
        SerializedName = @"useDefaultPublicLoadBalancer",
        PossibleTypes = new [] { typeof(bool) })]
        bool? UseDefaultPublicLoadBalancer { get; set; }
        /// <summary>
        /// Indicates whether to use ephemeral os disk. The sku selected on the vmSize property needs to support this feature.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Indicates whether to use ephemeral os disk. The sku selected on the vmSize property needs to support this feature.",
        SerializedName = @"useEphemeralOSDisk",
        PossibleTypes = new [] { typeof(bool) })]
        bool? UseEphemeralOSDisk { get; set; }
        /// <summary>
        /// Specifies whether to use the temporary disk for the service fabric data root, in which case no managed data disk will
        /// be attached and the temporary disk will be used. It is only allowed for stateless node types.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies whether to use the temporary disk for the service fabric data root, in which case no managed data disk will be attached and the temporary disk will be used. It is only allowed for stateless node types.",
        SerializedName = @"useTempDataDisk",
        PossibleTypes = new [] { typeof(bool) })]
        bool? UseTempDataDisk { get; set; }
        /// <summary>
        /// Specifies the gallery applications that should be made available to the underlying VMSS.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the gallery applications that should be made available to the underlying VMSS.",
        SerializedName = @"vmApplications",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVMApplication) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVMApplication> VMApplication { get; set; }
        /// <summary>Set of extensions that should be installed onto the virtual machines.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Set of extensions that should be installed onto the virtual machines.",
        SerializedName = @"vmExtensions",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVmssExtension) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVmssExtension> VMExtension { get; set; }
        /// <summary>
        /// The offer type of the Azure Virtual Machines Marketplace image. For example, UbuntuServer or WindowsServer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The offer type of the Azure Virtual Machines Marketplace image. For example, UbuntuServer or WindowsServer.",
        SerializedName = @"vmImageOffer",
        PossibleTypes = new [] { typeof(string) })]
        string VMImageOffer { get; set; }
        /// <summary>The plan ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The plan ID.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string VMImagePlanName { get; set; }
        /// <summary>
        /// Specifies the product of the image from the marketplace. This is the same value as Offer under the imageReference element.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the product of the image from the marketplace. This is the same value as Offer under the imageReference element.",
        SerializedName = @"product",
        PossibleTypes = new [] { typeof(string) })]
        string VMImagePlanProduct { get; set; }
        /// <summary>The promotion code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The promotion code.",
        SerializedName = @"promotionCode",
        PossibleTypes = new [] { typeof(string) })]
        string VMImagePlanPromotionCode { get; set; }
        /// <summary>The publisher ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The publisher ID.",
        SerializedName = @"publisher",
        PossibleTypes = new [] { typeof(string) })]
        string VMImagePlanPublisher { get; set; }
        /// <summary>
        /// The publisher of the Azure Virtual Machines Marketplace image. For example, Canonical or MicrosoftWindowsServer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The publisher of the Azure Virtual Machines Marketplace image. For example, Canonical or MicrosoftWindowsServer.",
        SerializedName = @"vmImagePublisher",
        PossibleTypes = new [] { typeof(string) })]
        string VMImagePublisher { get; set; }
        /// <summary>
        /// Indicates the resource id of the vm image. This parameter is used for custom vm image.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Indicates the resource id of the vm image. This parameter is used for custom vm image.",
        SerializedName = @"vmImageResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string VMImageResourceId { get; set; }
        /// <summary>
        /// The SKU of the Azure Virtual Machines Marketplace image. For example, 14.04.0-LTS or 2012-R2-Datacenter.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The SKU of the Azure Virtual Machines Marketplace image. For example, 14.04.0-LTS or 2012-R2-Datacenter.",
        SerializedName = @"vmImageSku",
        PossibleTypes = new [] { typeof(string) })]
        string VMImageSku { get; set; }
        /// <summary>
        /// The version of the Azure Virtual Machines Marketplace image. A value of 'latest' can be specified to select the latest
        /// version of an image. If omitted, the default is 'latest'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The version of the Azure Virtual Machines Marketplace image. A value of 'latest' can be specified to select the latest version of an image. If omitted, the default is 'latest'.",
        SerializedName = @"vmImageVersion",
        PossibleTypes = new [] { typeof(string) })]
        string VMImageVersion { get; set; }
        /// <summary>
        /// The number of nodes in the node type. **Values:** -1 - Use when auto scale rules are configured or sku.capacity is defined
        /// 0 - Not supported >0 - Use for manual scale.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The number of nodes in the node type. **Values:** -1 - Use when auto scale rules are configured or sku.capacity is defined 0 - Not supported >0 - Use for manual scale.",
        SerializedName = @"vmInstanceCount",
        PossibleTypes = new [] { typeof(int) })]
        int? VMInstanceCount { get; set; }
        /// <summary>
        /// The list of user identities associated with the virtual machine scale set under the node type. Each entry will be an ARM
        /// resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The list of user identities associated with the virtual machine scale set under the node type. Each entry will be an ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.",
        SerializedName = @"userAssignedIdentities",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> VMManagedIdentityUserAssignedIdentity { get; set; }
        /// <summary>The secrets to install in the virtual machines.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The secrets to install in the virtual machines.",
        SerializedName = @"vmSecrets",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVaultSecretGroup) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVaultSecretGroup> VMSecret { get; set; }
        /// <summary>
        /// Specifies the actions to be performed on the vms before bootstrapping the service fabric runtime.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the actions to be performed on the vms before bootstrapping the service fabric runtime.",
        SerializedName = @"vmSetupActions",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("EnableContainers", "EnableHyperV")]
        System.Collections.Generic.List<string> VMSetupAction { get; set; }
        /// <summary>
        /// Indicates the resource id of the vm shared galleries image. This parameter is used for custom vm image.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Indicates the resource id of the vm shared galleries image. This parameter is used for custom vm image.",
        SerializedName = @"vmSharedGalleryImageId",
        PossibleTypes = new [] { typeof(string) })]
        string VMSharedGalleryImageId { get; set; }
        /// <summary>
        /// The size of virtual machines in the pool. All virtual machines in a pool are the same size. For example, Standard_D3.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The size of virtual machines in the pool. All virtual machines in a pool are the same size. For example, Standard_D3.",
        SerializedName = @"vmSize",
        PossibleTypes = new [] { typeof(string) })]
        string VMSize { get; set; }
        /// <summary>
        /// Specifies the availability zones where the node type would span across. If the cluster is not spanning across availability
        /// zones, initiates az migration for the cluster.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the availability zones where the node type would span across. If the cluster is not spanning across availability zones, initiates az migration for the cluster.",
        SerializedName = @"zones",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> Zone { get; set; }
        /// <summary>
        /// Setting this to true allows stateless node types to scale out without equal distribution across zones.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Setting this to true allows stateless node types to scale out without equal distribution across zones.",
        SerializedName = @"zoneBalance",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ZoneBalance { get; set; }

    }
    /// Describes a node type in the cluster, each node type represents sub set of nodes in the cluster.
    internal partial interface INodeTypeInternal :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IProxyResourceInternal
    {
        /// <summary>Additional managed data disks.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVmssDataDisk> AdditionalDataDisk { get; set; }
        /// <summary>
        /// Specifies the settings for any additional secondary network interfaces to attach to the node type.
        /// </summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IAdditionalNetworkInterfaceConfiguration> AdditionalNetworkInterfaceConfiguration { get; set; }
        /// <summary>
        /// The range of ports from which cluster assigned port to Service Fabric applications.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IEndpointRangeDescription ApplicationPort { get; set; }
        /// <summary>End port of a range of ports</summary>
        int? ApplicationPortEndPort { get; set; }
        /// <summary>Starting port of a range of ports</summary>
        int? ApplicationPortStartPort { get; set; }
        /// <summary>
        /// The capacity tags applied to the nodes in the node type, the cluster resource manager uses these tags to understand how
        /// much resource a node has.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesCapacities Capacity { get; set; }
        /// <summary>
        /// Specifies the computer name prefix. Limited to 9 characters. If specified, allows for a longer name to be specified for
        /// the node type name.
        /// </summary>
        string ComputerNamePrefix { get; set; }
        /// <summary>
        /// Managed data disk letter. It can not use the reserved letter C or D and it can not change after created.
        /// </summary>
        string DataDiskLetter { get; set; }
        /// <summary>Disk size for the managed disk attached to the vms on the node type in GBs.</summary>
        int? DataDiskSizeGb { get; set; }
        /// <summary>Managed data disk type. Specifies the storage account type for the managed disk</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("Standard_LRS", "StandardSSD_LRS", "Premium_LRS", "PremiumV2_LRS", "StandardSSD_ZRS", "Premium_ZRS")]
        string DataDiskType { get; set; }
        /// <summary>
        /// Specifies the resource id of the DSCP configuration to apply to the node type network interface.
        /// </summary>
        string DscpConfigurationId { get; set; }
        /// <summary>Specifies whether the network interface is accelerated networking-enabled.</summary>
        bool? EnableAcceleratedNetworking { get; set; }
        /// <summary>
        /// Enable or disable the Host Encryption for the virtual machines on the node type. This will enable the encryption for all
        /// the disks including Resource/Temp disk at host itself. Default: The Encryption at host will be disabled unless this property
        /// is set to true for the resource.
        /// </summary>
        bool? EnableEncryptionAtHost { get; set; }
        /// <summary>
        /// Specifies whether each node is allocated its own public IPv4 address. This is only supported on secondary node types with
        /// custom Load Balancers.
        /// </summary>
        bool? EnableNodePublicIP { get; set; }
        /// <summary>
        /// Specifies whether each node is allocated its own public IPv6 address. This is only supported on secondary node types with
        /// custom Load Balancers.
        /// </summary>
        bool? EnableNodePublicIPv6 { get; set; }
        /// <summary>
        /// Specifies whether the node type should be overprovisioned. It is only allowed for stateless node types.
        /// </summary>
        bool? EnableOverProvisioning { get; set; }
        /// <summary>
        /// The range of ephemeral ports that nodes in this node type should be configured with.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IEndpointRangeDescription EphemeralPort { get; set; }
        /// <summary>End port of a range of ports</summary>
        int? EphemeralPortEndPort { get; set; }
        /// <summary>Starting port of a range of ports</summary>
        int? EphemeralPortStartPort { get; set; }
        /// <summary>
        /// Specifies the eviction policy for virtual machines in a SPOT node type. Default is Delete.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("Delete", "Deallocate")]
        string EvictionPolicy { get; set; }
        /// <summary>
        /// Indicates the node type uses its own frontend configurations instead of the default one for the cluster. This setting
        /// can only be specified for non-primary node types and can not be added or removed after the node type is created.
        /// </summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFrontendConfiguration> FrontendConfiguration { get; set; }
        /// <summary>
        /// Specifies the full host group resource Id. This property is used for deploying on azure dedicated hosts.
        /// </summary>
        string HostGroupId { get; set; }
        /// <summary>
        /// Specifies the node type should be configured for only outbound traffic and not inbound traffic.
        /// </summary>
        bool? IsOutboundOnly { get; set; }
        /// <summary>
        /// Indicates the Service Fabric system services for the cluster will run on this node type. This setting cannot be changed
        /// once the node type is created.
        /// </summary>
        bool? IsPrimary { get; set; }
        /// <summary>
        /// Indicates whether the node type will be Spot Virtual Machines. Azure will allocate the VMs if there is capacity available
        /// and the VMs can be evicted at any time.
        /// </summary>
        bool? IsSpotVM { get; set; }
        /// <summary>Indicates if the node type can only host Stateless workloads.</summary>
        bool? IsStateless { get; set; }
        /// <summary>
        /// Indicates if scale set associated with the node type can be composed of multiple placement groups.
        /// </summary>
        bool? MultiplePlacementGroup { get; set; }
        /// <summary>
        /// Specifies the NAT configuration on default public Load Balancer for the node type. This is only supported for node types
        /// use the default public Load Balancer.
        /// </summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeNatConfig> NatConfiguration { get; set; }
        /// <summary>
        /// Specifies the resource id of a NAT Gateway to attach to the subnet of this node type. Node type must use custom load balancer.
        /// </summary>
        string NatGatewayId { get; set; }
        /// <summary>
        /// The Network Security Rules for this node type. This setting can only be specified for node types that are configured with
        /// frontend configurations.
        /// </summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INetworkSecurityRule> NetworkSecurityRule { get; set; }
        /// <summary>
        /// The placement tags applied to nodes in the node type, which can be used to indicate where certain services (workload)
        /// should run.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesPlacementProperties PlacementProperty { get; set; }
        /// <summary>The node type properties</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeProperties Property { get; set; }
        /// <summary>The provisioning state of the node type resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("None", "Creating", "Created", "Updating", "Succeeded", "Failed", "Canceled", "Deleting", "Deleted", "Other")]
        string ProvisioningState { get; set; }
        /// <summary>
        /// Specifies whether secure boot should be enabled on the nodeType. Can only be used with TrustedLaunch and ConfidentialVM
        /// SecurityType.
        /// </summary>
        bool? SecureBootEnabled { get; set; }
        /// <summary>
        /// Specifies the EncryptionType of the managed disk. It is set to DiskWithVMGuestState for encryption of the managed disk
        /// along with VMGuestState blob and VMGuestStateOnly for encryption of just the VMGuestState blob. Note: It can be set for
        /// only Confidential VMs.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("DiskWithVMGuestState", "VMGuestStateOnly")]
        string SecurityEncryptionType { get; set; }
        /// <summary>
        /// Specifies the security type of the nodeType. Supported values include Standard, TrustedLaunch and ConfidentialVM.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("TrustedLaunch", "Standard", "ConfidentialVM")]
        string SecurityType { get; set; }
        /// <summary>
        /// Specifies the service artifact reference id used to set same image version for all virtual machines in the scale set when
        /// using 'latest' image version.
        /// </summary>
        string ServiceArtifactReferenceId { get; set; }
        /// <summary>The node type sku.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeSku Sku { get; set; }
        /// <summary>
        /// The number of nodes in the node type. If present in request it will override properties.vmInstanceCount.
        /// </summary>
        int? SkuCapacity { get; set; }
        /// <summary>
        /// The sku name. Name is internally generated and is used in auto-scale scenarios. Property does not allow to be changed
        /// to other values than generated. To avoid deployment errors please omit the property.
        /// </summary>
        string SkuName { get; set; }
        /// <summary>Specifies the tier of the node type. Possible Values: **Standard**</summary>
        string SkuTier { get; set; }
        /// <summary>
        /// Indicates the time duration after which the platform will not try to restore the VMSS SPOT instances specified as ISO
        /// 8601.
        /// </summary>
        string SpotRestoreTimeout { get; set; }
        /// <summary>Indicates the resource id of the subnet for the node type.</summary>
        string SubnetId { get; set; }
        /// <summary>Resource tags.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeTags Tag { get; set; }
        /// <summary>
        /// Specifies whether the use public load balancer. If not specified and the node type doesn't have its own frontend configuration,
        /// it will be attached to the default load balancer. If the node type uses its own Load balancer and useDefaultPublicLoadBalancer
        /// is true, then the frontend has to be an Internal Load Balancer. If the node type uses its own Load balancer and useDefaultPublicLoadBalancer
        /// is false or not set, then the custom load balancer must include a public load balancer to provide outbound connectivity.
        /// </summary>
        bool? UseDefaultPublicLoadBalancer { get; set; }
        /// <summary>
        /// Indicates whether to use ephemeral os disk. The sku selected on the vmSize property needs to support this feature.
        /// </summary>
        bool? UseEphemeralOSDisk { get; set; }
        /// <summary>
        /// Specifies whether to use the temporary disk for the service fabric data root, in which case no managed data disk will
        /// be attached and the temporary disk will be used. It is only allowed for stateless node types.
        /// </summary>
        bool? UseTempDataDisk { get; set; }
        /// <summary>
        /// Specifies the gallery applications that should be made available to the underlying VMSS.
        /// </summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVMApplication> VMApplication { get; set; }
        /// <summary>Set of extensions that should be installed onto the virtual machines.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVmssExtension> VMExtension { get; set; }
        /// <summary>
        /// The offer type of the Azure Virtual Machines Marketplace image. For example, UbuntuServer or WindowsServer.
        /// </summary>
        string VMImageOffer { get; set; }
        /// <summary>
        /// Specifies information about the marketplace image used to create the virtual machine. This element is only used for marketplace
        /// images. Before you can use a marketplace image from an API, you must enable the image for programmatic use. In the Azure
        /// portal, find the marketplace image that you want to use and then click Want to deploy programmatically, Get Started ->.
        /// Enter any required information and then click Save.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVMImagePlan VMImagePlan { get; set; }
        /// <summary>The plan ID.</summary>
        string VMImagePlanName { get; set; }
        /// <summary>
        /// Specifies the product of the image from the marketplace. This is the same value as Offer under the imageReference element.
        /// </summary>
        string VMImagePlanProduct { get; set; }
        /// <summary>The promotion code.</summary>
        string VMImagePlanPromotionCode { get; set; }
        /// <summary>The publisher ID.</summary>
        string VMImagePlanPublisher { get; set; }
        /// <summary>
        /// The publisher of the Azure Virtual Machines Marketplace image. For example, Canonical or MicrosoftWindowsServer.
        /// </summary>
        string VMImagePublisher { get; set; }
        /// <summary>
        /// Indicates the resource id of the vm image. This parameter is used for custom vm image.
        /// </summary>
        string VMImageResourceId { get; set; }
        /// <summary>
        /// The SKU of the Azure Virtual Machines Marketplace image. For example, 14.04.0-LTS or 2012-R2-Datacenter.
        /// </summary>
        string VMImageSku { get; set; }
        /// <summary>
        /// The version of the Azure Virtual Machines Marketplace image. A value of 'latest' can be specified to select the latest
        /// version of an image. If omitted, the default is 'latest'.
        /// </summary>
        string VMImageVersion { get; set; }
        /// <summary>
        /// The number of nodes in the node type. **Values:** -1 - Use when auto scale rules are configured or sku.capacity is defined
        /// 0 - Not supported >0 - Use for manual scale.
        /// </summary>
        int? VMInstanceCount { get; set; }
        /// <summary>Identities to assign to the virtual machine scale set under the node type.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVMManagedIdentity VMManagedIdentity { get; set; }
        /// <summary>
        /// The list of user identities associated with the virtual machine scale set under the node type. Each entry will be an ARM
        /// resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
        /// </summary>
        System.Collections.Generic.List<string> VMManagedIdentityUserAssignedIdentity { get; set; }
        /// <summary>The secrets to install in the virtual machines.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVaultSecretGroup> VMSecret { get; set; }
        /// <summary>
        /// Specifies the actions to be performed on the vms before bootstrapping the service fabric runtime.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("EnableContainers", "EnableHyperV")]
        System.Collections.Generic.List<string> VMSetupAction { get; set; }
        /// <summary>
        /// Indicates the resource id of the vm shared galleries image. This parameter is used for custom vm image.
        /// </summary>
        string VMSharedGalleryImageId { get; set; }
        /// <summary>
        /// The size of virtual machines in the pool. All virtual machines in a pool are the same size. For example, Standard_D3.
        /// </summary>
        string VMSize { get; set; }
        /// <summary>
        /// Specifies the availability zones where the node type would span across. If the cluster is not spanning across availability
        /// zones, initiates az migration for the cluster.
        /// </summary>
        System.Collections.Generic.List<string> Zone { get; set; }
        /// <summary>
        /// Setting this to true allows stateless node types to scale out without equal distribution across zones.
        /// </summary>
        bool? ZoneBalance { get; set; }

    }
}