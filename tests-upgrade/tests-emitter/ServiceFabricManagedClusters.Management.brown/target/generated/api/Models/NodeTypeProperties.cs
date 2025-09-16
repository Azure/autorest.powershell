// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>
    /// Describes a node type in the cluster, each node type represents sub set of nodes in the cluster.
    /// </summary>
    public partial class NodeTypeProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeProperties,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal
    {

        /// <summary>Backing field for <see cref="AdditionalDataDisk" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVmssDataDisk> _additionalDataDisk;

        /// <summary>Additional managed data disks.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVmssDataDisk> AdditionalDataDisk { get => this._additionalDataDisk; set => this._additionalDataDisk = value; }

        /// <summary>
        /// Backing field for <see cref="AdditionalNetworkInterfaceConfiguration" /> property.
        /// </summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IAdditionalNetworkInterfaceConfiguration> _additionalNetworkInterfaceConfiguration;

        /// <summary>
        /// Specifies the settings for any additional secondary network interfaces to attach to the node type.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IAdditionalNetworkInterfaceConfiguration> AdditionalNetworkInterfaceConfiguration { get => this._additionalNetworkInterfaceConfiguration; set => this._additionalNetworkInterfaceConfiguration = value; }

        /// <summary>Backing field for <see cref="ApplicationPort" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IEndpointRangeDescription _applicationPort;

        /// <summary>
        /// The range of ports from which cluster assigned port to Service Fabric applications.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IEndpointRangeDescription ApplicationPort { get => (this._applicationPort = this._applicationPort ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.EndpointRangeDescription()); set => this._applicationPort = value; }

        /// <summary>End port of a range of ports</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public int? ApplicationPortEndPort { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IEndpointRangeDescriptionInternal)ApplicationPort).EndPort; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IEndpointRangeDescriptionInternal)ApplicationPort).EndPort = value ?? default(int); }

        /// <summary>Starting port of a range of ports</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public int? ApplicationPortStartPort { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IEndpointRangeDescriptionInternal)ApplicationPort).StartPort; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IEndpointRangeDescriptionInternal)ApplicationPort).StartPort = value ?? default(int); }

        /// <summary>Backing field for <see cref="Capacity" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesCapacities _capacity;

        /// <summary>
        /// The capacity tags applied to the nodes in the node type, the cluster resource manager uses these tags to understand how
        /// much resource a node has.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesCapacities Capacity { get => (this._capacity = this._capacity ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.NodeTypePropertiesCapacities()); set => this._capacity = value; }

        /// <summary>Backing field for <see cref="ComputerNamePrefix" /> property.</summary>
        private string _computerNamePrefix;

        /// <summary>
        /// Specifies the computer name prefix. Limited to 9 characters. If specified, allows for a longer name to be specified for
        /// the node type name.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string ComputerNamePrefix { get => this._computerNamePrefix; set => this._computerNamePrefix = value; }

        /// <summary>Backing field for <see cref="DataDiskLetter" /> property.</summary>
        private string _dataDiskLetter;

        /// <summary>
        /// Managed data disk letter. It can not use the reserved letter C or D and it can not change after created.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string DataDiskLetter { get => this._dataDiskLetter; set => this._dataDiskLetter = value; }

        /// <summary>Backing field for <see cref="DataDiskSizeGb" /> property.</summary>
        private int? _dataDiskSizeGb;

        /// <summary>Disk size for the managed disk attached to the vms on the node type in GBs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public int? DataDiskSizeGb { get => this._dataDiskSizeGb; set => this._dataDiskSizeGb = value; }

        /// <summary>Backing field for <see cref="DataDiskType" /> property.</summary>
        private string _dataDiskType;

        /// <summary>Managed data disk type. Specifies the storage account type for the managed disk</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string DataDiskType { get => this._dataDiskType; set => this._dataDiskType = value; }

        /// <summary>Backing field for <see cref="DscpConfigurationId" /> property.</summary>
        private string _dscpConfigurationId;

        /// <summary>
        /// Specifies the resource id of the DSCP configuration to apply to the node type network interface.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string DscpConfigurationId { get => this._dscpConfigurationId; set => this._dscpConfigurationId = value; }

        /// <summary>Backing field for <see cref="EnableAcceleratedNetworking" /> property.</summary>
        private bool? _enableAcceleratedNetworking;

        /// <summary>Specifies whether the network interface is accelerated networking-enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public bool? EnableAcceleratedNetworking { get => this._enableAcceleratedNetworking; set => this._enableAcceleratedNetworking = value; }

        /// <summary>Backing field for <see cref="EnableEncryptionAtHost" /> property.</summary>
        private bool? _enableEncryptionAtHost;

        /// <summary>
        /// Enable or disable the Host Encryption for the virtual machines on the node type. This will enable the encryption for all
        /// the disks including Resource/Temp disk at host itself. Default: The Encryption at host will be disabled unless this property
        /// is set to true for the resource.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public bool? EnableEncryptionAtHost { get => this._enableEncryptionAtHost; set => this._enableEncryptionAtHost = value; }

        /// <summary>Backing field for <see cref="EnableNodePublicIP" /> property.</summary>
        private bool? _enableNodePublicIP;

        /// <summary>
        /// Specifies whether each node is allocated its own public IPv4 address. This is only supported on secondary node types with
        /// custom Load Balancers.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public bool? EnableNodePublicIP { get => this._enableNodePublicIP; set => this._enableNodePublicIP = value; }

        /// <summary>Backing field for <see cref="EnableNodePublicIPv6" /> property.</summary>
        private bool? _enableNodePublicIPv6;

        /// <summary>
        /// Specifies whether each node is allocated its own public IPv6 address. This is only supported on secondary node types with
        /// custom Load Balancers.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public bool? EnableNodePublicIPv6 { get => this._enableNodePublicIPv6; set => this._enableNodePublicIPv6 = value; }

        /// <summary>Backing field for <see cref="EnableOverProvisioning" /> property.</summary>
        private bool? _enableOverProvisioning;

        /// <summary>
        /// Specifies whether the node type should be overprovisioned. It is only allowed for stateless node types.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public bool? EnableOverProvisioning { get => this._enableOverProvisioning; set => this._enableOverProvisioning = value; }

        /// <summary>Backing field for <see cref="EphemeralPort" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IEndpointRangeDescription _ephemeralPort;

        /// <summary>
        /// The range of ephemeral ports that nodes in this node type should be configured with.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IEndpointRangeDescription EphemeralPort { get => (this._ephemeralPort = this._ephemeralPort ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.EndpointRangeDescription()); set => this._ephemeralPort = value; }

        /// <summary>End port of a range of ports</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public int? EphemeralPortEndPort { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IEndpointRangeDescriptionInternal)EphemeralPort).EndPort; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IEndpointRangeDescriptionInternal)EphemeralPort).EndPort = value ?? default(int); }

        /// <summary>Starting port of a range of ports</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public int? EphemeralPortStartPort { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IEndpointRangeDescriptionInternal)EphemeralPort).StartPort; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IEndpointRangeDescriptionInternal)EphemeralPort).StartPort = value ?? default(int); }

        /// <summary>Backing field for <see cref="EvictionPolicy" /> property.</summary>
        private string _evictionPolicy;

        /// <summary>
        /// Specifies the eviction policy for virtual machines in a SPOT node type. Default is Delete.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string EvictionPolicy { get => this._evictionPolicy; set => this._evictionPolicy = value; }

        /// <summary>Backing field for <see cref="FrontendConfiguration" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFrontendConfiguration> _frontendConfiguration;

        /// <summary>
        /// Indicates the node type uses its own frontend configurations instead of the default one for the cluster. This setting
        /// can only be specified for non-primary node types and can not be added or removed after the node type is created.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFrontendConfiguration> FrontendConfiguration { get => this._frontendConfiguration; set => this._frontendConfiguration = value; }

        /// <summary>Backing field for <see cref="HostGroupId" /> property.</summary>
        private string _hostGroupId;

        /// <summary>
        /// Specifies the full host group resource Id. This property is used for deploying on azure dedicated hosts.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string HostGroupId { get => this._hostGroupId; set => this._hostGroupId = value; }

        /// <summary>Backing field for <see cref="IsOutboundOnly" /> property.</summary>
        private bool? _isOutboundOnly;

        /// <summary>
        /// Specifies the node type should be configured for only outbound traffic and not inbound traffic.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public bool? IsOutboundOnly { get => this._isOutboundOnly; set => this._isOutboundOnly = value; }

        /// <summary>Backing field for <see cref="IsPrimary" /> property.</summary>
        private bool _isPrimary;

        /// <summary>
        /// Indicates the Service Fabric system services for the cluster will run on this node type. This setting cannot be changed
        /// once the node type is created.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public bool IsPrimary { get => this._isPrimary; set => this._isPrimary = value; }

        /// <summary>Backing field for <see cref="IsSpotVM" /> property.</summary>
        private bool? _isSpotVM;

        /// <summary>
        /// Indicates whether the node type will be Spot Virtual Machines. Azure will allocate the VMs if there is capacity available
        /// and the VMs can be evicted at any time.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public bool? IsSpotVM { get => this._isSpotVM; set => this._isSpotVM = value; }

        /// <summary>Backing field for <see cref="IsStateless" /> property.</summary>
        private bool? _isStateless;

        /// <summary>Indicates if the node type can only host Stateless workloads.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public bool? IsStateless { get => this._isStateless; set => this._isStateless = value; }

        /// <summary>Internal Acessors for ApplicationPort</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IEndpointRangeDescription Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal.ApplicationPort { get => (this._applicationPort = this._applicationPort ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.EndpointRangeDescription()); set { {_applicationPort = value;} } }

        /// <summary>Internal Acessors for EphemeralPort</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IEndpointRangeDescription Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal.EphemeralPort { get => (this._ephemeralPort = this._ephemeralPort ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.EndpointRangeDescription()); set { {_ephemeralPort = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for VMImagePlan</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVMImagePlan Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal.VMImagePlan { get => (this._vMImagePlan = this._vMImagePlan ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.VMImagePlan()); set { {_vMImagePlan = value;} } }

        /// <summary>Internal Acessors for VMManagedIdentity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVMManagedIdentity Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal.VMManagedIdentity { get => (this._vMManagedIdentity = this._vMManagedIdentity ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.VMManagedIdentity()); set { {_vMManagedIdentity = value;} } }

        /// <summary>Backing field for <see cref="MultiplePlacementGroup" /> property.</summary>
        private bool? _multiplePlacementGroup;

        /// <summary>
        /// Indicates if scale set associated with the node type can be composed of multiple placement groups.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public bool? MultiplePlacementGroup { get => this._multiplePlacementGroup; set => this._multiplePlacementGroup = value; }

        /// <summary>Backing field for <see cref="NatConfiguration" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeNatConfig> _natConfiguration;

        /// <summary>
        /// Specifies the NAT configuration on default public Load Balancer for the node type. This is only supported for node types
        /// use the default public Load Balancer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeNatConfig> NatConfiguration { get => this._natConfiguration; set => this._natConfiguration = value; }

        /// <summary>Backing field for <see cref="NatGatewayId" /> property.</summary>
        private string _natGatewayId;

        /// <summary>
        /// Specifies the resource id of a NAT Gateway to attach to the subnet of this node type. Node type must use custom load balancer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string NatGatewayId { get => this._natGatewayId; set => this._natGatewayId = value; }

        /// <summary>Backing field for <see cref="NetworkSecurityRule" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INetworkSecurityRule> _networkSecurityRule;

        /// <summary>
        /// The Network Security Rules for this node type. This setting can only be specified for node types that are configured with
        /// frontend configurations.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INetworkSecurityRule> NetworkSecurityRule { get => this._networkSecurityRule; set => this._networkSecurityRule = value; }

        /// <summary>Backing field for <see cref="PlacementProperty" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesPlacementProperties _placementProperty;

        /// <summary>
        /// The placement tags applied to nodes in the node type, which can be used to indicate where certain services (workload)
        /// should run.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesPlacementProperties PlacementProperty { get => (this._placementProperty = this._placementProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.NodeTypePropertiesPlacementProperties()); set => this._placementProperty = value; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>The provisioning state of the node type resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="SecureBootEnabled" /> property.</summary>
        private bool? _secureBootEnabled;

        /// <summary>
        /// Specifies whether secure boot should be enabled on the nodeType. Can only be used with TrustedLaunch and ConfidentialVM
        /// SecurityType.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public bool? SecureBootEnabled { get => this._secureBootEnabled; set => this._secureBootEnabled = value; }

        /// <summary>Backing field for <see cref="SecurityEncryptionType" /> property.</summary>
        private string _securityEncryptionType;

        /// <summary>
        /// Specifies the EncryptionType of the managed disk. It is set to DiskWithVMGuestState for encryption of the managed disk
        /// along with VMGuestState blob and VMGuestStateOnly for encryption of just the VMGuestState blob. Note: It can be set for
        /// only Confidential VMs.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string SecurityEncryptionType { get => this._securityEncryptionType; set => this._securityEncryptionType = value; }

        /// <summary>Backing field for <see cref="SecurityType" /> property.</summary>
        private string _securityType;

        /// <summary>
        /// Specifies the security type of the nodeType. Supported values include Standard, TrustedLaunch and ConfidentialVM.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string SecurityType { get => this._securityType; set => this._securityType = value; }

        /// <summary>Backing field for <see cref="ServiceArtifactReferenceId" /> property.</summary>
        private string _serviceArtifactReferenceId;

        /// <summary>
        /// Specifies the service artifact reference id used to set same image version for all virtual machines in the scale set when
        /// using 'latest' image version.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string ServiceArtifactReferenceId { get => this._serviceArtifactReferenceId; set => this._serviceArtifactReferenceId = value; }

        /// <summary>Backing field for <see cref="SpotRestoreTimeout" /> property.</summary>
        private string _spotRestoreTimeout;

        /// <summary>
        /// Indicates the time duration after which the platform will not try to restore the VMSS SPOT instances specified as ISO
        /// 8601.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string SpotRestoreTimeout { get => this._spotRestoreTimeout; set => this._spotRestoreTimeout = value; }

        /// <summary>Backing field for <see cref="SubnetId" /> property.</summary>
        private string _subnetId;

        /// <summary>Indicates the resource id of the subnet for the node type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string SubnetId { get => this._subnetId; set => this._subnetId = value; }

        /// <summary>Backing field for <see cref="UseDefaultPublicLoadBalancer" /> property.</summary>
        private bool? _useDefaultPublicLoadBalancer;

        /// <summary>
        /// Specifies whether the use public load balancer. If not specified and the node type doesn't have its own frontend configuration,
        /// it will be attached to the default load balancer. If the node type uses its own Load balancer and useDefaultPublicLoadBalancer
        /// is true, then the frontend has to be an Internal Load Balancer. If the node type uses its own Load balancer and useDefaultPublicLoadBalancer
        /// is false or not set, then the custom load balancer must include a public load balancer to provide outbound connectivity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public bool? UseDefaultPublicLoadBalancer { get => this._useDefaultPublicLoadBalancer; set => this._useDefaultPublicLoadBalancer = value; }

        /// <summary>Backing field for <see cref="UseEphemeralOSDisk" /> property.</summary>
        private bool? _useEphemeralOSDisk;

        /// <summary>
        /// Indicates whether to use ephemeral os disk. The sku selected on the vmSize property needs to support this feature.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public bool? UseEphemeralOSDisk { get => this._useEphemeralOSDisk; set => this._useEphemeralOSDisk = value; }

        /// <summary>Backing field for <see cref="UseTempDataDisk" /> property.</summary>
        private bool? _useTempDataDisk;

        /// <summary>
        /// Specifies whether to use the temporary disk for the service fabric data root, in which case no managed data disk will
        /// be attached and the temporary disk will be used. It is only allowed for stateless node types.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public bool? UseTempDataDisk { get => this._useTempDataDisk; set => this._useTempDataDisk = value; }

        /// <summary>Backing field for <see cref="VMApplication" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVMApplication> _vMApplication;

        /// <summary>
        /// Specifies the gallery applications that should be made available to the underlying VMSS.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVMApplication> VMApplication { get => this._vMApplication; set => this._vMApplication = value; }

        /// <summary>Backing field for <see cref="VMExtension" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVmssExtension> _vMExtension;

        /// <summary>Set of extensions that should be installed onto the virtual machines.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVmssExtension> VMExtension { get => this._vMExtension; set => this._vMExtension = value; }

        /// <summary>Backing field for <see cref="VMImageOffer" /> property.</summary>
        private string _vMImageOffer;

        /// <summary>
        /// The offer type of the Azure Virtual Machines Marketplace image. For example, UbuntuServer or WindowsServer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string VMImageOffer { get => this._vMImageOffer; set => this._vMImageOffer = value; }

        /// <summary>Backing field for <see cref="VMImagePlan" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVMImagePlan _vMImagePlan;

        /// <summary>
        /// Specifies information about the marketplace image used to create the virtual machine. This element is only used for marketplace
        /// images. Before you can use a marketplace image from an API, you must enable the image for programmatic use. In the Azure
        /// portal, find the marketplace image that you want to use and then click Want to deploy programmatically, Get Started ->.
        /// Enter any required information and then click Save.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVMImagePlan VMImagePlan { get => (this._vMImagePlan = this._vMImagePlan ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.VMImagePlan()); set => this._vMImagePlan = value; }

        /// <summary>The plan ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string VMImagePlanName { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVMImagePlanInternal)VMImagePlan).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVMImagePlanInternal)VMImagePlan).Name = value ?? null; }

        /// <summary>
        /// Specifies the product of the image from the marketplace. This is the same value as Offer under the imageReference element.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string VMImagePlanProduct { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVMImagePlanInternal)VMImagePlan).Product; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVMImagePlanInternal)VMImagePlan).Product = value ?? null; }

        /// <summary>The promotion code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string VMImagePlanPromotionCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVMImagePlanInternal)VMImagePlan).PromotionCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVMImagePlanInternal)VMImagePlan).PromotionCode = value ?? null; }

        /// <summary>The publisher ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string VMImagePlanPublisher { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVMImagePlanInternal)VMImagePlan).Publisher; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVMImagePlanInternal)VMImagePlan).Publisher = value ?? null; }

        /// <summary>Backing field for <see cref="VMImagePublisher" /> property.</summary>
        private string _vMImagePublisher;

        /// <summary>
        /// The publisher of the Azure Virtual Machines Marketplace image. For example, Canonical or MicrosoftWindowsServer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string VMImagePublisher { get => this._vMImagePublisher; set => this._vMImagePublisher = value; }

        /// <summary>Backing field for <see cref="VMImageResourceId" /> property.</summary>
        private string _vMImageResourceId;

        /// <summary>
        /// Indicates the resource id of the vm image. This parameter is used for custom vm image.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string VMImageResourceId { get => this._vMImageResourceId; set => this._vMImageResourceId = value; }

        /// <summary>Backing field for <see cref="VMImageSku" /> property.</summary>
        private string _vMImageSku;

        /// <summary>
        /// The SKU of the Azure Virtual Machines Marketplace image. For example, 14.04.0-LTS or 2012-R2-Datacenter.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string VMImageSku { get => this._vMImageSku; set => this._vMImageSku = value; }

        /// <summary>Backing field for <see cref="VMImageVersion" /> property.</summary>
        private string _vMImageVersion;

        /// <summary>
        /// The version of the Azure Virtual Machines Marketplace image. A value of 'latest' can be specified to select the latest
        /// version of an image. If omitted, the default is 'latest'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string VMImageVersion { get => this._vMImageVersion; set => this._vMImageVersion = value; }

        /// <summary>Backing field for <see cref="VMInstanceCount" /> property.</summary>
        private int _vMInstanceCount;

        /// <summary>
        /// The number of nodes in the node type. **Values:** -1 - Use when auto scale rules are configured or sku.capacity is defined
        /// 0 - Not supported >0 - Use for manual scale.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public int VMInstanceCount { get => this._vMInstanceCount; set => this._vMInstanceCount = value; }

        /// <summary>Backing field for <see cref="VMManagedIdentity" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVMManagedIdentity _vMManagedIdentity;

        /// <summary>Identities to assign to the virtual machine scale set under the node type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVMManagedIdentity VMManagedIdentity { get => (this._vMManagedIdentity = this._vMManagedIdentity ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.VMManagedIdentity()); set => this._vMManagedIdentity = value; }

        /// <summary>
        /// The list of user identities associated with the virtual machine scale set under the node type. Each entry will be an ARM
        /// resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> VMManagedIdentityUserAssignedIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVMManagedIdentityInternal)VMManagedIdentity).UserAssignedIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVMManagedIdentityInternal)VMManagedIdentity).UserAssignedIdentity = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="VMSecret" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVaultSecretGroup> _vMSecret;

        /// <summary>The secrets to install in the virtual machines.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVaultSecretGroup> VMSecret { get => this._vMSecret; set => this._vMSecret = value; }

        /// <summary>Backing field for <see cref="VMSetupAction" /> property.</summary>
        private System.Collections.Generic.List<string> _vMSetupAction;

        /// <summary>
        /// Specifies the actions to be performed on the vms before bootstrapping the service fabric runtime.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> VMSetupAction { get => this._vMSetupAction; set => this._vMSetupAction = value; }

        /// <summary>Backing field for <see cref="VMSharedGalleryImageId" /> property.</summary>
        private string _vMSharedGalleryImageId;

        /// <summary>
        /// Indicates the resource id of the vm shared galleries image. This parameter is used for custom vm image.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string VMSharedGalleryImageId { get => this._vMSharedGalleryImageId; set => this._vMSharedGalleryImageId = value; }

        /// <summary>Backing field for <see cref="VMSize" /> property.</summary>
        private string _vMSize;

        /// <summary>
        /// The size of virtual machines in the pool. All virtual machines in a pool are the same size. For example, Standard_D3.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string VMSize { get => this._vMSize; set => this._vMSize = value; }

        /// <summary>Backing field for <see cref="Zone" /> property.</summary>
        private System.Collections.Generic.List<string> _zone;

        /// <summary>
        /// Specifies the availability zones where the node type would span across. If the cluster is not spanning across availability
        /// zones, initiates az migration for the cluster.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> Zone { get => this._zone; set => this._zone = value; }

        /// <summary>Backing field for <see cref="ZoneBalance" /> property.</summary>
        private bool? _zoneBalance;

        /// <summary>
        /// Setting this to true allows stateless node types to scale out without equal distribution across zones.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public bool? ZoneBalance { get => this._zoneBalance; set => this._zoneBalance = value; }

        /// <summary>Creates an new <see cref="NodeTypeProperties" /> instance.</summary>
        public NodeTypeProperties()
        {

        }
    }
    /// Describes a node type in the cluster, each node type represents sub set of nodes in the cluster.
    public partial interface INodeTypeProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable
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
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Indicates the Service Fabric system services for the cluster will run on this node type. This setting cannot be changed once the node type is created.",
        SerializedName = @"isPrimary",
        PossibleTypes = new [] { typeof(bool) })]
        bool IsPrimary { get; set; }
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
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The number of nodes in the node type. **Values:** -1 - Use when auto scale rules are configured or sku.capacity is defined 0 - Not supported >0 - Use for manual scale.",
        SerializedName = @"vmInstanceCount",
        PossibleTypes = new [] { typeof(int) })]
        int VMInstanceCount { get; set; }
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
    internal partial interface INodeTypePropertiesInternal

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
        bool IsPrimary { get; set; }
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
        /// <summary>
        /// Indicates the time duration after which the platform will not try to restore the VMSS SPOT instances specified as ISO
        /// 8601.
        /// </summary>
        string SpotRestoreTimeout { get; set; }
        /// <summary>Indicates the resource id of the subnet for the node type.</summary>
        string SubnetId { get; set; }
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
        int VMInstanceCount { get; set; }
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