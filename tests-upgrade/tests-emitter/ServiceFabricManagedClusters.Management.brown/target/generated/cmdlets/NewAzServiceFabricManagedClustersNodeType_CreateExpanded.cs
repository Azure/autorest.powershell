// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Cmdlets
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;
    using Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.PowerShell;
    using Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Cmdlets;
    using System;

    /// <summary>create a Service Fabric node type of a given managed cluster.</summary>
    /// <remarks>
    /// [OpenAPI] CreateOrUpdate=>PUT:"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/managedClusters/{clusterName}/nodeTypes/{nodeTypeName}"
    /// </remarks>
    [global::System.Management.Automation.Cmdlet(global::System.Management.Automation.VerbsCommon.New, @"AzServiceFabricManagedClustersNodeType_CreateExpanded", SupportsShouldProcess = true)]
    [global::System.Management.Automation.OutputType(typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeType))]
    [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Description(@"create a Service Fabric node type of a given managed cluster.")]
    [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Generated]
    [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.HttpPath(Path = "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/managedClusters/{clusterName}/nodeTypes/{nodeTypeName}", ApiVersion = "2025-06-01-preview")]
    public partial class NewAzServiceFabricManagedClustersNodeType_CreateExpanded : global::System.Management.Automation.PSCmdlet,
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

        /// <summary>
        /// Describes a node type in the cluster, each node type represents sub set of nodes in the cluster.
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeType _parametersBody = new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.NodeType();

        /// <summary>Additional managed data disks.</summary>
        [global::System.Management.Automation.AllowEmptyCollection]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Additional managed data disks.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Additional managed data disks.",
        SerializedName = @"additionalDataDisks",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVmssDataDisk) })]
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVmssDataDisk[] AdditionalDataDisk { get => _parametersBody.AdditionalDataDisk?.ToArray() ?? null /* fixedArrayOf */; set => _parametersBody.AdditionalDataDisk = (value != null ? new System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVmssDataDisk>(value) : null); }

        /// <summary>
        /// Specifies the settings for any additional secondary network interfaces to attach to the node type.
        /// </summary>
        [global::System.Management.Automation.AllowEmptyCollection]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Specifies the settings for any additional secondary network interfaces to attach to the node type.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies the settings for any additional secondary network interfaces to attach to the node type.",
        SerializedName = @"additionalNetworkInterfaceConfigurations",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IAdditionalNetworkInterfaceConfiguration) })]
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IAdditionalNetworkInterfaceConfiguration[] AdditionalNetworkInterfaceConfiguration { get => _parametersBody.AdditionalNetworkInterfaceConfiguration?.ToArray() ?? null /* fixedArrayOf */; set => _parametersBody.AdditionalNetworkInterfaceConfiguration = (value != null ? new System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IAdditionalNetworkInterfaceConfiguration>(value) : null); }

        /// <summary>End port of a range of ports</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "End port of a range of ports")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"End port of a range of ports",
        SerializedName = @"endPort",
        PossibleTypes = new [] { typeof(int) })]
        public int ApplicationPortEndPort { get => _parametersBody.ApplicationPortEndPort ?? default(int); set => _parametersBody.ApplicationPortEndPort = value; }

        /// <summary>Starting port of a range of ports</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Starting port of a range of ports")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Starting port of a range of ports",
        SerializedName = @"startPort",
        PossibleTypes = new [] { typeof(int) })]
        public int ApplicationPortStartPort { get => _parametersBody.ApplicationPortStartPort ?? default(int); set => _parametersBody.ApplicationPortStartPort = value; }

        /// <summary>when specified, runs this cmdlet as a PowerShell job</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Run the command as a job")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter AsJob { get; set; }

        /// <summary>Wait for .NET debugger to attach</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Wait for .NET debugger to attach")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter Break { get; set; }

        /// <summary>Accessor for cancellationTokenSource.</summary>
        public global::System.Threading.CancellationTokenSource CancellationTokenSource { get => _cancellationTokenSource ; set { _cancellationTokenSource = value; } }

        /// <summary>
        /// The capacity tags applied to the nodes in the node type, the cluster resource manager uses these tags to understand how
        /// much resource a node has.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ExportAs(typeof(global::System.Collections.Hashtable))]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The capacity tags applied to the nodes in the node type, the cluster resource manager uses these tags to understand how much resource a node has.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The capacity tags applied to the nodes in the node type, the cluster resource manager uses these tags to understand how much resource a node has.",
        SerializedName = @"capacities",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesCapacities) })]
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesCapacities Capacity { get => _parametersBody.Capacity ?? null /* object */; set => _parametersBody.Capacity = value; }

        /// <summary>The reference to the client API class.</summary>
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ServiceFabricManagedClustersManagementClient Client => Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Module.Instance.ClientAPI;

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
        /// Specifies the computer name prefix. Limited to 9 characters. If specified, allows for a longer name to be specified for
        /// the node type name.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Specifies the computer name prefix. Limited to 9 characters. If specified, allows for a longer name to be specified for the node type name.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies the computer name prefix. Limited to 9 characters. If specified, allows for a longer name to be specified for the node type name.",
        SerializedName = @"computerNamePrefix",
        PossibleTypes = new [] { typeof(string) })]
        public string ComputerNamePrefix { get => _parametersBody.ComputerNamePrefix ?? null; set => _parametersBody.ComputerNamePrefix = value; }

        /// <summary>
        /// Managed data disk letter. It can not use the reserved letter C or D and it can not change after created.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Managed data disk letter. It can not use the reserved letter C or D and it can not change after created.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Managed data disk letter. It can not use the reserved letter C or D and it can not change after created.",
        SerializedName = @"dataDiskLetter",
        PossibleTypes = new [] { typeof(string) })]
        public string DataDiskLetter { get => _parametersBody.DataDiskLetter ?? null; set => _parametersBody.DataDiskLetter = value; }

        /// <summary>Disk size for the managed disk attached to the vms on the node type in GBs.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Disk size for the managed disk attached to the vms on the node type in GBs.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Disk size for the managed disk attached to the vms on the node type in GBs.",
        SerializedName = @"dataDiskSizeGB",
        PossibleTypes = new [] { typeof(int) })]
        public int DataDiskSizeGb { get => _parametersBody.DataDiskSizeGb ?? default(int); set => _parametersBody.DataDiskSizeGb = value; }

        /// <summary>Managed data disk type. Specifies the storage account type for the managed disk</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Managed data disk type. Specifies the storage account type for the managed disk")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Managed data disk type. Specifies the storage account type for the managed disk",
        SerializedName = @"dataDiskType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("Standard_LRS", "StandardSSD_LRS", "Premium_LRS", "PremiumV2_LRS", "StandardSSD_ZRS", "Premium_ZRS")]
        public string DataDiskType { get => _parametersBody.DataDiskType ?? null; set => _parametersBody.DataDiskType = value; }

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
        /// Specifies the resource id of the DSCP configuration to apply to the node type network interface.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Specifies the resource id of the DSCP configuration to apply to the node type network interface.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies the resource id of the DSCP configuration to apply to the node type network interface.",
        SerializedName = @"dscpConfigurationId",
        PossibleTypes = new [] { typeof(string) })]
        public string DscpConfigurationId { get => _parametersBody.DscpConfigurationId ?? null; set => _parametersBody.DscpConfigurationId = value; }

        /// <summary>Specifies whether the network interface is accelerated networking-enabled.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Specifies whether the network interface is accelerated networking-enabled.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies whether the network interface is accelerated networking-enabled.",
        SerializedName = @"enableAcceleratedNetworking",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter EnableAcceleratedNetworking { get => _parametersBody.EnableAcceleratedNetworking ?? default(global::System.Management.Automation.SwitchParameter); set => _parametersBody.EnableAcceleratedNetworking = value; }

        /// <summary>
        /// Enable or disable the Host Encryption for the virtual machines on the node type. This will enable the encryption for all
        /// the disks including Resource/Temp disk at host itself. Default: The Encryption at host will be disabled unless this property
        /// is set to true for the resource.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Enable or disable the Host Encryption for the virtual machines on the node type. This will enable the encryption for all the disks including Resource/Temp disk at host itself. Default: The Encryption at host will be disabled unless this property is set to true for the resource.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Enable or disable the Host Encryption for the virtual machines on the node type. This will enable the encryption for all the disks including Resource/Temp disk at host itself. Default: The Encryption at host will be disabled unless this property is set to true for the resource.",
        SerializedName = @"enableEncryptionAtHost",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter EnableEncryptionAtHost { get => _parametersBody.EnableEncryptionAtHost ?? default(global::System.Management.Automation.SwitchParameter); set => _parametersBody.EnableEncryptionAtHost = value; }

        /// <summary>
        /// Specifies whether each node is allocated its own public IPv4 address. This is only supported on secondary node types with
        /// custom Load Balancers.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Specifies whether each node is allocated its own public IPv4 address. This is only supported on secondary node types with custom Load Balancers.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies whether each node is allocated its own public IPv4 address. This is only supported on secondary node types with custom Load Balancers.",
        SerializedName = @"enableNodePublicIP",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter EnableNodePublicIP { get => _parametersBody.EnableNodePublicIP ?? default(global::System.Management.Automation.SwitchParameter); set => _parametersBody.EnableNodePublicIP = value; }

        /// <summary>
        /// Specifies whether each node is allocated its own public IPv6 address. This is only supported on secondary node types with
        /// custom Load Balancers.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Specifies whether each node is allocated its own public IPv6 address. This is only supported on secondary node types with custom Load Balancers.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies whether each node is allocated its own public IPv6 address. This is only supported on secondary node types with custom Load Balancers.",
        SerializedName = @"enableNodePublicIPv6",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter EnableNodePublicIPv6 { get => _parametersBody.EnableNodePublicIPv6 ?? default(global::System.Management.Automation.SwitchParameter); set => _parametersBody.EnableNodePublicIPv6 = value; }

        /// <summary>
        /// Specifies whether the node type should be overprovisioned. It is only allowed for stateless node types.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Specifies whether the node type should be overprovisioned. It is only allowed for stateless node types.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies whether the node type should be overprovisioned. It is only allowed for stateless node types.",
        SerializedName = @"enableOverProvisioning",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter EnableOverProvisioning { get => _parametersBody.EnableOverProvisioning ?? default(global::System.Management.Automation.SwitchParameter); set => _parametersBody.EnableOverProvisioning = value; }

        /// <summary>End port of a range of ports</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "End port of a range of ports")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"End port of a range of ports",
        SerializedName = @"endPort",
        PossibleTypes = new [] { typeof(int) })]
        public int EphemeralPortEndPort { get => _parametersBody.EphemeralPortEndPort ?? default(int); set => _parametersBody.EphemeralPortEndPort = value; }

        /// <summary>Starting port of a range of ports</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Starting port of a range of ports")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Starting port of a range of ports",
        SerializedName = @"startPort",
        PossibleTypes = new [] { typeof(int) })]
        public int EphemeralPortStartPort { get => _parametersBody.EphemeralPortStartPort ?? default(int); set => _parametersBody.EphemeralPortStartPort = value; }

        /// <summary>
        /// Specifies the eviction policy for virtual machines in a SPOT node type. Default is Delete.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Specifies the eviction policy for virtual machines in a SPOT node type. Default is Delete.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies the eviction policy for virtual machines in a SPOT node type. Default is Delete.",
        SerializedName = @"evictionPolicy",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("Delete", "Deallocate")]
        public string EvictionPolicy { get => _parametersBody.EvictionPolicy ?? null; set => _parametersBody.EvictionPolicy = value; }

        /// <summary>Accessor for extensibleParameters.</summary>
        public global::System.Collections.Generic.IDictionary<global::System.String,global::System.Object> ExtensibleParameters { get => _extensibleParameters ; }

        /// <summary>
        /// Indicates the node type uses its own frontend configurations instead of the default one for the cluster. This setting
        /// can only be specified for non-primary node types and can not be added or removed after the node type is created.
        /// </summary>
        [global::System.Management.Automation.AllowEmptyCollection]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Indicates the node type uses its own frontend configurations instead of the default one for the cluster. This setting can only be specified for non-primary node types and can not be added or removed after the node type is created.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicates the node type uses its own frontend configurations instead of the default one for the cluster. This setting can only be specified for non-primary node types and can not be added or removed after the node type is created.",
        SerializedName = @"frontendConfigurations",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFrontendConfiguration) })]
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFrontendConfiguration[] FrontendConfiguration { get => _parametersBody.FrontendConfiguration?.ToArray() ?? null /* fixedArrayOf */; set => _parametersBody.FrontendConfiguration = (value != null ? new System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFrontendConfiguration>(value) : null); }

        /// <summary>
        /// Specifies the full host group resource Id. This property is used for deploying on azure dedicated hosts.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Specifies the full host group resource Id. This property is used for deploying on azure dedicated hosts.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies the full host group resource Id. This property is used for deploying on azure dedicated hosts.",
        SerializedName = @"hostGroupId",
        PossibleTypes = new [] { typeof(string) })]
        public string HostGroupId { get => _parametersBody.HostGroupId ?? null; set => _parametersBody.HostGroupId = value; }

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

        /// <summary>Accessor for our copy of the InvocationInfo.</summary>
        public global::System.Management.Automation.InvocationInfo InvocationInformation { get => __invocationInfo = __invocationInfo ?? this.MyInvocation ; set { __invocationInfo = value; } }

        /// <summary>
        /// Specifies the node type should be configured for only outbound traffic and not inbound traffic.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Specifies the node type should be configured for only outbound traffic and not inbound traffic.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies the node type should be configured for only outbound traffic and not inbound traffic.",
        SerializedName = @"isOutboundOnly",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter IsOutboundOnly { get => _parametersBody.IsOutboundOnly ?? default(global::System.Management.Automation.SwitchParameter); set => _parametersBody.IsOutboundOnly = value; }

        /// <summary>
        /// Indicates the Service Fabric system services for the cluster will run on this node type. This setting cannot be changed
        /// once the node type is created.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Indicates the Service Fabric system services for the cluster will run on this node type. This setting cannot be changed once the node type is created.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicates the Service Fabric system services for the cluster will run on this node type. This setting cannot be changed once the node type is created.",
        SerializedName = @"isPrimary",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter IsPrimary { get => _parametersBody.IsPrimary ?? default(global::System.Management.Automation.SwitchParameter); set => _parametersBody.IsPrimary = value; }

        /// <summary>
        /// Indicates whether the node type will be Spot Virtual Machines. Azure will allocate the VMs if there is capacity available
        /// and the VMs can be evicted at any time.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Indicates whether the node type will be Spot Virtual Machines. Azure will allocate the VMs if there is capacity available and the VMs can be evicted at any time.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicates whether the node type will be Spot Virtual Machines. Azure will allocate the VMs if there is capacity available and the VMs can be evicted at any time.",
        SerializedName = @"isSpotVM",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter IsSpotVM { get => _parametersBody.IsSpotVM ?? default(global::System.Management.Automation.SwitchParameter); set => _parametersBody.IsSpotVM = value; }

        /// <summary>Indicates if the node type can only host Stateless workloads.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Indicates if the node type can only host Stateless workloads.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicates if the node type can only host Stateless workloads.",
        SerializedName = @"isStateless",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter IsStateless { get => _parametersBody.IsStateless ?? default(global::System.Management.Automation.SwitchParameter); set => _parametersBody.IsStateless = value; }

        /// <summary>
        /// <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener" /> cancellation delegate. Stops the cmdlet when called.
        /// </summary>
        global::System.Action Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener.Cancel => _cancellationTokenSource.Cancel;

        /// <summary><see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener" /> cancellation token.</summary>
        global::System.Threading.CancellationToken Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener.Token => _cancellationTokenSource.Token;

        /// <summary>
        /// Indicates if scale set associated with the node type can be composed of multiple placement groups.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Indicates if scale set associated with the node type can be composed of multiple placement groups.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicates if scale set associated with the node type can be composed of multiple placement groups.",
        SerializedName = @"multiplePlacementGroups",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter MultiplePlacementGroup { get => _parametersBody.MultiplePlacementGroup ?? default(global::System.Management.Automation.SwitchParameter); set => _parametersBody.MultiplePlacementGroup = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The name of the node type.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The name of the node type.")]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The name of the node type.",
        SerializedName = @"nodeTypeName",
        PossibleTypes = new [] { typeof(string) })]
        [global::System.Management.Automation.Alias("NodeTypeName")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Path)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>
        /// Specifies the NAT configuration on default public Load Balancer for the node type. This is only supported for node types
        /// use the default public Load Balancer.
        /// </summary>
        [global::System.Management.Automation.AllowEmptyCollection]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Specifies the NAT configuration on default public Load Balancer for the node type. This is only supported for node types use the default public Load Balancer.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies the NAT configuration on default public Load Balancer for the node type. This is only supported for node types use the default public Load Balancer.",
        SerializedName = @"natConfigurations",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeNatConfig) })]
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeNatConfig[] NatConfiguration { get => _parametersBody.NatConfiguration?.ToArray() ?? null /* fixedArrayOf */; set => _parametersBody.NatConfiguration = (value != null ? new System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeNatConfig>(value) : null); }

        /// <summary>
        /// Specifies the resource id of a NAT Gateway to attach to the subnet of this node type. Node type must use custom load balancer.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Specifies the resource id of a NAT Gateway to attach to the subnet of this node type. Node type must use custom load balancer.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies the resource id of a NAT Gateway to attach to the subnet of this node type. Node type must use custom load balancer.",
        SerializedName = @"natGatewayId",
        PossibleTypes = new [] { typeof(string) })]
        public string NatGatewayId { get => _parametersBody.NatGatewayId ?? null; set => _parametersBody.NatGatewayId = value; }

        /// <summary>
        /// The Network Security Rules for this node type. This setting can only be specified for node types that are configured with
        /// frontend configurations.
        /// </summary>
        [global::System.Management.Automation.AllowEmptyCollection]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The Network Security Rules for this node type. This setting can only be specified for node types that are configured with frontend configurations.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Network Security Rules for this node type. This setting can only be specified for node types that are configured with frontend configurations.",
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

        /// <summary>
        /// The placement tags applied to nodes in the node type, which can be used to indicate where certain services (workload)
        /// should run.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ExportAs(typeof(global::System.Collections.Hashtable))]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The placement tags applied to nodes in the node type, which can be used to indicate where certain services (workload) should run.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The placement tags applied to nodes in the node type, which can be used to indicate where certain services (workload) should run.",
        SerializedName = @"placementProperties",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesPlacementProperties) })]
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesPlacementProperties PlacementProperty { get => _parametersBody.PlacementProperty ?? null /* object */; set => _parametersBody.PlacementProperty = value; }

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

        /// <summary>
        /// Specifies whether secure boot should be enabled on the nodeType. Can only be used with TrustedLaunch and ConfidentialVM
        /// SecurityType.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Specifies whether secure boot should be enabled on the nodeType. Can only be used with TrustedLaunch and ConfidentialVM SecurityType.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies whether secure boot should be enabled on the nodeType. Can only be used with TrustedLaunch and ConfidentialVM SecurityType.",
        SerializedName = @"secureBootEnabled",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter SecureBootEnabled { get => _parametersBody.SecureBootEnabled ?? default(global::System.Management.Automation.SwitchParameter); set => _parametersBody.SecureBootEnabled = value; }

        /// <summary>
        /// Specifies the EncryptionType of the managed disk. It is set to DiskWithVMGuestState for encryption of the managed disk
        /// along with VMGuestState blob and VMGuestStateOnly for encryption of just the VMGuestState blob. Note: It can be set for
        /// only Confidential VMs.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Specifies the EncryptionType of the managed disk. It is set to DiskWithVMGuestState for encryption of the managed disk along with VMGuestState blob and VMGuestStateOnly for encryption of just the VMGuestState blob. Note: It can be set for only Confidential VMs.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies the EncryptionType of the managed disk. It is set to DiskWithVMGuestState for encryption of the managed disk along with VMGuestState blob and VMGuestStateOnly for encryption of just the VMGuestState blob. Note: It can be set for only Confidential VMs.",
        SerializedName = @"securityEncryptionType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("DiskWithVMGuestState", "VMGuestStateOnly")]
        public string SecurityEncryptionType { get => _parametersBody.SecurityEncryptionType ?? null; set => _parametersBody.SecurityEncryptionType = value; }

        /// <summary>
        /// Specifies the security type of the nodeType. Supported values include Standard, TrustedLaunch and ConfidentialVM.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Specifies the security type of the nodeType. Supported values include Standard, TrustedLaunch and ConfidentialVM.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies the security type of the nodeType. Supported values include Standard, TrustedLaunch and ConfidentialVM.",
        SerializedName = @"securityType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("TrustedLaunch", "Standard", "ConfidentialVM")]
        public string SecurityType { get => _parametersBody.SecurityType ?? null; set => _parametersBody.SecurityType = value; }

        /// <summary>
        /// Specifies the service artifact reference id used to set same image version for all virtual machines in the scale set when
        /// using 'latest' image version.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Specifies the service artifact reference id used to set same image version for all virtual machines in the scale set when using 'latest' image version.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies the service artifact reference id used to set same image version for all virtual machines in the scale set when using 'latest' image version.",
        SerializedName = @"serviceArtifactReferenceId",
        PossibleTypes = new [] { typeof(string) })]
        public string ServiceArtifactReferenceId { get => _parametersBody.ServiceArtifactReferenceId ?? null; set => _parametersBody.ServiceArtifactReferenceId = value; }

        /// <summary>
        /// The number of nodes in the node type. If present in request it will override properties.vmInstanceCount.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The number of nodes in the node type. If present in request it will override properties.vmInstanceCount.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of nodes in the node type. If present in request it will override properties.vmInstanceCount.",
        SerializedName = @"capacity",
        PossibleTypes = new [] { typeof(int) })]
        public int SkuCapacity { get => _parametersBody.SkuCapacity ?? default(int); set => _parametersBody.SkuCapacity = value; }

        /// <summary>
        /// The sku name. Name is internally generated and is used in auto-scale scenarios. Property does not allow to be changed
        /// to other values than generated. To avoid deployment errors please omit the property.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The sku name. Name is internally generated and is used in auto-scale scenarios. Property does not allow to be changed to other values than generated. To avoid deployment errors please omit the property.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The sku name. Name is internally generated and is used in auto-scale scenarios. Property does not allow to be changed to other values than generated. To avoid deployment errors please omit the property.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        public string SkuName { get => _parametersBody.SkuName ?? null; set => _parametersBody.SkuName = value; }

        /// <summary>Specifies the tier of the node type. Possible Values: **Standard**</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Specifies the tier of the node type. Possible Values: **Standard**")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies the tier of the node type. Possible Values: **Standard**",
        SerializedName = @"tier",
        PossibleTypes = new [] { typeof(string) })]
        public string SkuTier { get => _parametersBody.SkuTier ?? null; set => _parametersBody.SkuTier = value; }

        /// <summary>
        /// Indicates the time duration after which the platform will not try to restore the VMSS SPOT instances specified as ISO
        /// 8601.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Indicates the time duration after which the platform will not try to restore the VMSS SPOT instances specified as ISO 8601.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicates the time duration after which the platform will not try to restore the VMSS SPOT instances specified as ISO 8601.",
        SerializedName = @"spotRestoreTimeout",
        PossibleTypes = new [] { typeof(string) })]
        public string SpotRestoreTimeout { get => _parametersBody.SpotRestoreTimeout ?? null; set => _parametersBody.SpotRestoreTimeout = value; }

        /// <summary>Indicates the resource id of the subnet for the node type.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Indicates the resource id of the subnet for the node type.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicates the resource id of the subnet for the node type.",
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
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeTags) })]
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeTags Tag { get => _parametersBody.Tag ?? null /* object */; set => _parametersBody.Tag = value; }

        /// <summary>
        /// Specifies whether the use public load balancer. If not specified and the node type doesn't have its own frontend configuration,
        /// it will be attached to the default load balancer. If the node type uses its own Load balancer and useDefaultPublicLoadBalancer
        /// is true, then the frontend has to be an Internal Load Balancer. If the node type uses its own Load balancer and useDefaultPublicLoadBalancer
        /// is false or not set, then the custom load balancer must include a public load balancer to provide outbound connectivity.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Specifies whether the use public load balancer. If not specified and the node type doesn't have its own frontend configuration, it will be attached to the default load balancer. If the node type uses its own Load balancer and useDefaultPublicLoadBalancer is true, then the frontend has to be an Internal Load Balancer. If the node type uses its own Load balancer and useDefaultPublicLoadBalancer is false or not set, then the custom load balancer must include a public load balancer to provide outbound connectivity.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies whether the use public load balancer. If not specified and the node type doesn't have its own frontend configuration, it will be attached to the default load balancer. If the node type uses its own Load balancer and useDefaultPublicLoadBalancer is true, then the frontend has to be an Internal Load Balancer. If the node type uses its own Load balancer and useDefaultPublicLoadBalancer is false or not set, then the custom load balancer must include a public load balancer to provide outbound connectivity.",
        SerializedName = @"useDefaultPublicLoadBalancer",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter UseDefaultPublicLoadBalancer { get => _parametersBody.UseDefaultPublicLoadBalancer ?? default(global::System.Management.Automation.SwitchParameter); set => _parametersBody.UseDefaultPublicLoadBalancer = value; }

        /// <summary>
        /// Indicates whether to use ephemeral os disk. The sku selected on the vmSize property needs to support this feature.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Indicates whether to use ephemeral os disk. The sku selected on the vmSize property needs to support this feature.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicates whether to use ephemeral os disk. The sku selected on the vmSize property needs to support this feature.",
        SerializedName = @"useEphemeralOSDisk",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter UseEphemeralOSDisk { get => _parametersBody.UseEphemeralOSDisk ?? default(global::System.Management.Automation.SwitchParameter); set => _parametersBody.UseEphemeralOSDisk = value; }

        /// <summary>
        /// Specifies whether to use the temporary disk for the service fabric data root, in which case no managed data disk will
        /// be attached and the temporary disk will be used. It is only allowed for stateless node types.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Specifies whether to use the temporary disk for the service fabric data root, in which case no managed data disk will be attached and the temporary disk will be used. It is only allowed for stateless node types.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies whether to use the temporary disk for the service fabric data root, in which case no managed data disk will be attached and the temporary disk will be used. It is only allowed for stateless node types.",
        SerializedName = @"useTempDataDisk",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter UseTempDataDisk { get => _parametersBody.UseTempDataDisk ?? default(global::System.Management.Automation.SwitchParameter); set => _parametersBody.UseTempDataDisk = value; }

        /// <summary>
        /// Specifies the gallery applications that should be made available to the underlying VMSS.
        /// </summary>
        [global::System.Management.Automation.AllowEmptyCollection]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Specifies the gallery applications that should be made available to the underlying VMSS.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies the gallery applications that should be made available to the underlying VMSS.",
        SerializedName = @"vmApplications",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVMApplication) })]
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVMApplication[] VMApplication { get => _parametersBody.VMApplication?.ToArray() ?? null /* fixedArrayOf */; set => _parametersBody.VMApplication = (value != null ? new System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVMApplication>(value) : null); }

        /// <summary>Set of extensions that should be installed onto the virtual machines.</summary>
        [global::System.Management.Automation.AllowEmptyCollection]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Set of extensions that should be installed onto the virtual machines.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Set of extensions that should be installed onto the virtual machines.",
        SerializedName = @"vmExtensions",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVmssExtension) })]
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVmssExtension[] VMExtension { get => _parametersBody.VMExtension?.ToArray() ?? null /* fixedArrayOf */; set => _parametersBody.VMExtension = (value != null ? new System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVmssExtension>(value) : null); }

        /// <summary>
        /// The offer type of the Azure Virtual Machines Marketplace image. For example, UbuntuServer or WindowsServer.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The offer type of the Azure Virtual Machines Marketplace image. For example, UbuntuServer or WindowsServer.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The offer type of the Azure Virtual Machines Marketplace image. For example, UbuntuServer or WindowsServer.",
        SerializedName = @"vmImageOffer",
        PossibleTypes = new [] { typeof(string) })]
        public string VMImageOffer { get => _parametersBody.VMImageOffer ?? null; set => _parametersBody.VMImageOffer = value; }

        /// <summary>The plan ID.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The plan ID.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The plan ID.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        public string VMImagePlanName { get => _parametersBody.VMImagePlanName ?? null; set => _parametersBody.VMImagePlanName = value; }

        /// <summary>
        /// Specifies the product of the image from the marketplace. This is the same value as Offer under the imageReference element.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Specifies the product of the image from the marketplace. This is the same value as Offer under the imageReference element.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies the product of the image from the marketplace. This is the same value as Offer under the imageReference element.",
        SerializedName = @"product",
        PossibleTypes = new [] { typeof(string) })]
        public string VMImagePlanProduct { get => _parametersBody.VMImagePlanProduct ?? null; set => _parametersBody.VMImagePlanProduct = value; }

        /// <summary>The promotion code.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The promotion code.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The promotion code.",
        SerializedName = @"promotionCode",
        PossibleTypes = new [] { typeof(string) })]
        public string VMImagePlanPromotionCode { get => _parametersBody.VMImagePlanPromotionCode ?? null; set => _parametersBody.VMImagePlanPromotionCode = value; }

        /// <summary>The publisher ID.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The publisher ID.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The publisher ID.",
        SerializedName = @"publisher",
        PossibleTypes = new [] { typeof(string) })]
        public string VMImagePlanPublisher { get => _parametersBody.VMImagePlanPublisher ?? null; set => _parametersBody.VMImagePlanPublisher = value; }

        /// <summary>
        /// The publisher of the Azure Virtual Machines Marketplace image. For example, Canonical or MicrosoftWindowsServer.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The publisher of the Azure Virtual Machines Marketplace image. For example, Canonical or MicrosoftWindowsServer.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The publisher of the Azure Virtual Machines Marketplace image. For example, Canonical or MicrosoftWindowsServer.",
        SerializedName = @"vmImagePublisher",
        PossibleTypes = new [] { typeof(string) })]
        public string VMImagePublisher { get => _parametersBody.VMImagePublisher ?? null; set => _parametersBody.VMImagePublisher = value; }

        /// <summary>
        /// Indicates the resource id of the vm image. This parameter is used for custom vm image.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Indicates the resource id of the vm image. This parameter is used for custom vm image.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicates the resource id of the vm image. This parameter is used for custom vm image.",
        SerializedName = @"vmImageResourceId",
        PossibleTypes = new [] { typeof(string) })]
        public string VMImageResourceId { get => _parametersBody.VMImageResourceId ?? null; set => _parametersBody.VMImageResourceId = value; }

        /// <summary>
        /// The SKU of the Azure Virtual Machines Marketplace image. For example, 14.04.0-LTS or 2012-R2-Datacenter.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The SKU of the Azure Virtual Machines Marketplace image. For example, 14.04.0-LTS or 2012-R2-Datacenter.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The SKU of the Azure Virtual Machines Marketplace image. For example, 14.04.0-LTS or 2012-R2-Datacenter.",
        SerializedName = @"vmImageSku",
        PossibleTypes = new [] { typeof(string) })]
        public string VMImageSku { get => _parametersBody.VMImageSku ?? null; set => _parametersBody.VMImageSku = value; }

        /// <summary>
        /// The version of the Azure Virtual Machines Marketplace image. A value of 'latest' can be specified to select the latest
        /// version of an image. If omitted, the default is 'latest'.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The version of the Azure Virtual Machines Marketplace image. A value of 'latest' can be specified to select the latest version of an image. If omitted, the default is 'latest'.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The version of the Azure Virtual Machines Marketplace image. A value of 'latest' can be specified to select the latest version of an image. If omitted, the default is 'latest'.",
        SerializedName = @"vmImageVersion",
        PossibleTypes = new [] { typeof(string) })]
        public string VMImageVersion { get => _parametersBody.VMImageVersion ?? null; set => _parametersBody.VMImageVersion = value; }

        /// <summary>
        /// The number of nodes in the node type. **Values:** -1 - Use when auto scale rules are configured or sku.capacity is defined
        /// 0 - Not supported >0 - Use for manual scale.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The number of nodes in the node type. **Values:** -1 - Use when auto scale rules are configured or sku.capacity is defined 0 - Not supported >0 - Use for manual scale.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of nodes in the node type. **Values:** -1 - Use when auto scale rules are configured or sku.capacity is defined 0 - Not supported >0 - Use for manual scale.",
        SerializedName = @"vmInstanceCount",
        PossibleTypes = new [] { typeof(int) })]
        public int VMInstanceCount { get => _parametersBody.VMInstanceCount ?? default(int); set => _parametersBody.VMInstanceCount = value; }

        /// <summary>
        /// The list of user identities associated with the virtual machine scale set under the node type. Each entry will be an ARM
        /// resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
        /// </summary>
        [global::System.Management.Automation.AllowEmptyCollection]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The list of user identities associated with the virtual machine scale set under the node type. Each entry will be an ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of user identities associated with the virtual machine scale set under the node type. Each entry will be an ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.",
        SerializedName = @"userAssignedIdentities",
        PossibleTypes = new [] { typeof(string) })]
        public string[] VMManagedIdentityUserAssignedIdentity { get => _parametersBody.VMManagedIdentityUserAssignedIdentity?.ToArray() ?? null /* fixedArrayOf */; set => _parametersBody.VMManagedIdentityUserAssignedIdentity = (value != null ? new System.Collections.Generic.List<string>(value) : null); }

        /// <summary>The secrets to install in the virtual machines.</summary>
        [global::System.Management.Automation.AllowEmptyCollection]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The secrets to install in the virtual machines.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The secrets to install in the virtual machines.",
        SerializedName = @"vmSecrets",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVaultSecretGroup) })]
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVaultSecretGroup[] VMSecret { get => _parametersBody.VMSecret?.ToArray() ?? null /* fixedArrayOf */; set => _parametersBody.VMSecret = (value != null ? new System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVaultSecretGroup>(value) : null); }

        /// <summary>
        /// Specifies the actions to be performed on the vms before bootstrapping the service fabric runtime.
        /// </summary>
        [global::System.Management.Automation.AllowEmptyCollection]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Specifies the actions to be performed on the vms before bootstrapping the service fabric runtime.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies the actions to be performed on the vms before bootstrapping the service fabric runtime.",
        SerializedName = @"vmSetupActions",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("EnableContainers", "EnableHyperV")]
        public string[] VMSetupAction { get => _parametersBody.VMSetupAction?.ToArray() ?? null /* fixedArrayOf */; set => _parametersBody.VMSetupAction = (value != null ? new System.Collections.Generic.List<string>(value) : null); }

        /// <summary>
        /// Indicates the resource id of the vm shared galleries image. This parameter is used for custom vm image.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Indicates the resource id of the vm shared galleries image. This parameter is used for custom vm image.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicates the resource id of the vm shared galleries image. This parameter is used for custom vm image.",
        SerializedName = @"vmSharedGalleryImageId",
        PossibleTypes = new [] { typeof(string) })]
        public string VMSharedGalleryImageId { get => _parametersBody.VMSharedGalleryImageId ?? null; set => _parametersBody.VMSharedGalleryImageId = value; }

        /// <summary>
        /// The size of virtual machines in the pool. All virtual machines in a pool are the same size. For example, Standard_D3.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The size of virtual machines in the pool. All virtual machines in a pool are the same size. For example, Standard_D3.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The size of virtual machines in the pool. All virtual machines in a pool are the same size. For example, Standard_D3.",
        SerializedName = @"vmSize",
        PossibleTypes = new [] { typeof(string) })]
        public string VMSize { get => _parametersBody.VMSize ?? null; set => _parametersBody.VMSize = value; }

        /// <summary>
        /// Specifies the availability zones where the node type would span across. If the cluster is not spanning across availability
        /// zones, initiates az migration for the cluster.
        /// </summary>
        [global::System.Management.Automation.AllowEmptyCollection]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Specifies the availability zones where the node type would span across. If the cluster is not spanning across availability zones, initiates az migration for the cluster.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies the availability zones where the node type would span across. If the cluster is not spanning across availability zones, initiates az migration for the cluster.",
        SerializedName = @"zones",
        PossibleTypes = new [] { typeof(string) })]
        public string[] Zone { get => _parametersBody.Zone?.ToArray() ?? null /* fixedArrayOf */; set => _parametersBody.Zone = (value != null ? new System.Collections.Generic.List<string>(value) : null); }

        /// <summary>
        /// Setting this to true allows stateless node types to scale out without equal distribution across zones.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Setting this to true allows stateless node types to scale out without equal distribution across zones.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Setting this to true allows stateless node types to scale out without equal distribution across zones.",
        SerializedName = @"zoneBalance",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter ZoneBalance { get => _parametersBody.ZoneBalance ?? default(global::System.Management.Automation.SwitchParameter); set => _parametersBody.ZoneBalance = value; }

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
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeType">Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeType</see>
        /// from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onOk method should be processed, or if the method should return
        /// immediately (set to true to skip further processing )</param>

        partial void overrideOnOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeType> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

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
        /// a duplicate instance of NewAzServiceFabricManagedClustersNodeType_CreateExpanded
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Cmdlets.NewAzServiceFabricManagedClustersNodeType_CreateExpanded Clone()
        {
            var clone = new NewAzServiceFabricManagedClustersNodeType_CreateExpanded();
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
            clone.Name = this.Name;
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

        /// <summary>
        /// Initializes a new instance of the <see cref="NewAzServiceFabricManagedClustersNodeType_CreateExpanded" /> cmdlet class.
        /// </summary>
        public NewAzServiceFabricManagedClustersNodeType_CreateExpanded()
        {

        }

        /// <summary>Performs execution of the command.</summary>
        protected override void ProcessRecord()
        {
            ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Events.CmdletProcessRecordStart).Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
            __processRecordId = System.Guid.NewGuid().ToString();
            try
            {
                // work
                if (ShouldProcess($"Call remote 'NodeTypesCreateOrUpdate' operation"))
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
                    await this.Client.NodeTypesCreateOrUpdate(SubscriptionId, ResourceGroupName, ClusterName, Name, _parametersBody, onOk, onDefault, this, Pipeline, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.SerializationMode.IncludeCreate);
                    await ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Events.CmdletAfterAPICall); if( ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                }
                catch (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.UndeclaredResponseException urexception)
                {
                    WriteError(new global::System.Management.Automation.ErrorRecord(urexception, urexception.StatusCode.ToString(), global::System.Management.Automation.ErrorCategory.InvalidOperation, new { SubscriptionId=SubscriptionId,ResourceGroupName=ResourceGroupName,ClusterName=ClusterName,Name=Name})
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
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeType">Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeType</see>
        /// from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeType> response)
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
                // (await response) // should be Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeType
                var result = (await response);
                WriteObject(result, false);
            }
        }
    }
}