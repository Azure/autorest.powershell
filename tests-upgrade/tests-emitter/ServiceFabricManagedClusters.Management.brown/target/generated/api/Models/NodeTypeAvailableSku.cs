// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>Defines the type of sku available for a node type</summary>
    public partial class NodeTypeAvailableSku :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeAvailableSku,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeAvailableSkuInternal
    {

        /// <summary>Backing field for <see cref="Capacity" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeSkuCapacity _capacity;

        /// <summary>Provides information about how the node count can be scaled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeSkuCapacity Capacity { get => (this._capacity = this._capacity ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.NodeTypeSkuCapacity()); }

        /// <summary>Default node count in a node type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public int? CapacityDefault { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeSkuCapacityInternal)Capacity).Default; }

        /// <summary>Highest permitted node count in a node type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public int? CapacityMaximum { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeSkuCapacityInternal)Capacity).Maximum; }

        /// <summary>Lowest permitted node count in a node type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public int? CapacityMinimum { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeSkuCapacityInternal)Capacity).Minimum; }

        /// <summary>Node type capacity scale type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string CapacityScaleType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeSkuCapacityInternal)Capacity).ScaleType; }

        /// <summary>Internal Acessors for Capacity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeSkuCapacity Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeAvailableSkuInternal.Capacity { get => (this._capacity = this._capacity ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.NodeTypeSkuCapacity()); set { {_capacity = value;} } }

        /// <summary>Internal Acessors for CapacityDefault</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeAvailableSkuInternal.CapacityDefault { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeSkuCapacityInternal)Capacity).Default; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeSkuCapacityInternal)Capacity).Default = value ?? default(int); }

        /// <summary>Internal Acessors for CapacityMaximum</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeAvailableSkuInternal.CapacityMaximum { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeSkuCapacityInternal)Capacity).Maximum; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeSkuCapacityInternal)Capacity).Maximum = value ?? default(int); }

        /// <summary>Internal Acessors for CapacityMinimum</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeAvailableSkuInternal.CapacityMinimum { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeSkuCapacityInternal)Capacity).Minimum; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeSkuCapacityInternal)Capacity).Minimum = value ?? default(int); }

        /// <summary>Internal Acessors for CapacityScaleType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeAvailableSkuInternal.CapacityScaleType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeSkuCapacityInternal)Capacity).ScaleType; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeSkuCapacityInternal)Capacity).ScaleType = value ?? null; }

        /// <summary>Internal Acessors for ResourceType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeAvailableSkuInternal.ResourceType { get => this._resourceType; set { {_resourceType = value;} } }

        /// <summary>Internal Acessors for Sku</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeSupportedSku Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeAvailableSkuInternal.Sku { get => (this._sku = this._sku ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.NodeTypeSupportedSku()); set { {_sku = value;} } }

        /// <summary>Internal Acessors for SkuName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeAvailableSkuInternal.SkuName { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeSupportedSkuInternal)Sku).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeSupportedSkuInternal)Sku).Name = value ?? null; }

        /// <summary>Internal Acessors for SkuTier</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeAvailableSkuInternal.SkuTier { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeSupportedSkuInternal)Sku).Tier; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeSupportedSkuInternal)Sku).Tier = value ?? null; }

        /// <summary>Backing field for <see cref="ResourceType" /> property.</summary>
        private string _resourceType;

        /// <summary>
        /// The type of resource the sku applies to. Value: Microsoft.ServiceFabric/managedClusters/nodeTypes.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string ResourceType { get => this._resourceType; }

        /// <summary>Backing field for <see cref="Sku" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeSupportedSku _sku;

        /// <summary>The supported SKU for a for node type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeSupportedSku Sku { get => (this._sku = this._sku ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.NodeTypeSupportedSku()); }

        /// <summary>The sku name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string SkuName { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeSupportedSkuInternal)Sku).Name; }

        /// <summary>Specifies the tier of the node type. Possible Values: **Standard**</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string SkuTier { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeSupportedSkuInternal)Sku).Tier; }

        /// <summary>Creates an new <see cref="NodeTypeAvailableSku" /> instance.</summary>
        public NodeTypeAvailableSku()
        {

        }
    }
    /// Defines the type of sku available for a node type
    public partial interface INodeTypeAvailableSku :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable
    {
        /// <summary>Default node count in a node type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Default node count in a node type.",
        SerializedName = @"default",
        PossibleTypes = new [] { typeof(int) })]
        int? CapacityDefault { get;  }
        /// <summary>Highest permitted node count in a node type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Highest permitted node count in a node type.",
        SerializedName = @"maximum",
        PossibleTypes = new [] { typeof(int) })]
        int? CapacityMaximum { get;  }
        /// <summary>Lowest permitted node count in a node type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Lowest permitted node count in a node type.",
        SerializedName = @"minimum",
        PossibleTypes = new [] { typeof(int) })]
        int? CapacityMinimum { get;  }
        /// <summary>Node type capacity scale type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Node type capacity scale type.",
        SerializedName = @"scaleType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("None", "Manual", "Automatic")]
        string CapacityScaleType { get;  }
        /// <summary>
        /// The type of resource the sku applies to. Value: Microsoft.ServiceFabric/managedClusters/nodeTypes.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The type of resource the sku applies to. Value: Microsoft.ServiceFabric/managedClusters/nodeTypes.",
        SerializedName = @"resourceType",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceType { get;  }
        /// <summary>The sku name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The sku name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string SkuName { get;  }
        /// <summary>Specifies the tier of the node type. Possible Values: **Standard**</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Specifies the tier of the node type. Possible Values: **Standard**",
        SerializedName = @"tier",
        PossibleTypes = new [] { typeof(string) })]
        string SkuTier { get;  }

    }
    /// Defines the type of sku available for a node type
    internal partial interface INodeTypeAvailableSkuInternal

    {
        /// <summary>Provides information about how the node count can be scaled.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeSkuCapacity Capacity { get; set; }
        /// <summary>Default node count in a node type.</summary>
        int? CapacityDefault { get; set; }
        /// <summary>Highest permitted node count in a node type.</summary>
        int? CapacityMaximum { get; set; }
        /// <summary>Lowest permitted node count in a node type.</summary>
        int? CapacityMinimum { get; set; }
        /// <summary>Node type capacity scale type.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("None", "Manual", "Automatic")]
        string CapacityScaleType { get; set; }
        /// <summary>
        /// The type of resource the sku applies to. Value: Microsoft.ServiceFabric/managedClusters/nodeTypes.
        /// </summary>
        string ResourceType { get; set; }
        /// <summary>The supported SKU for a for node type.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeSupportedSku Sku { get; set; }
        /// <summary>The sku name.</summary>
        string SkuName { get; set; }
        /// <summary>Specifies the tier of the node type. Possible Values: **Standard**</summary>
        string SkuTier { get; set; }

    }
}