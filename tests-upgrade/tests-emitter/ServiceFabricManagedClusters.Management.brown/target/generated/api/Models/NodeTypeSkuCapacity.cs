// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>Provides information about how node type can be scaled.</summary>
    public partial class NodeTypeSkuCapacity :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeSkuCapacity,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeSkuCapacityInternal
    {

        /// <summary>Backing field for <see cref="Default" /> property.</summary>
        private int? _default;

        /// <summary>Default node count in a node type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public int? Default { get => this._default; }

        /// <summary>Backing field for <see cref="Maximum" /> property.</summary>
        private int? _maximum;

        /// <summary>Highest permitted node count in a node type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public int? Maximum { get => this._maximum; }

        /// <summary>Internal Acessors for Default</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeSkuCapacityInternal.Default { get => this._default; set { {_default = value;} } }

        /// <summary>Internal Acessors for Maximum</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeSkuCapacityInternal.Maximum { get => this._maximum; set { {_maximum = value;} } }

        /// <summary>Internal Acessors for Minimum</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeSkuCapacityInternal.Minimum { get => this._minimum; set { {_minimum = value;} } }

        /// <summary>Internal Acessors for ScaleType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeSkuCapacityInternal.ScaleType { get => this._scaleType; set { {_scaleType = value;} } }

        /// <summary>Backing field for <see cref="Minimum" /> property.</summary>
        private int? _minimum;

        /// <summary>Lowest permitted node count in a node type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public int? Minimum { get => this._minimum; }

        /// <summary>Backing field for <see cref="ScaleType" /> property.</summary>
        private string _scaleType;

        /// <summary>Node type capacity scale type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string ScaleType { get => this._scaleType; }

        /// <summary>Creates an new <see cref="NodeTypeSkuCapacity" /> instance.</summary>
        public NodeTypeSkuCapacity()
        {

        }
    }
    /// Provides information about how node type can be scaled.
    public partial interface INodeTypeSkuCapacity :
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
        int? Default { get;  }
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
        int? Maximum { get;  }
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
        int? Minimum { get;  }
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
        string ScaleType { get;  }

    }
    /// Provides information about how node type can be scaled.
    internal partial interface INodeTypeSkuCapacityInternal

    {
        /// <summary>Default node count in a node type.</summary>
        int? Default { get; set; }
        /// <summary>Highest permitted node count in a node type.</summary>
        int? Maximum { get; set; }
        /// <summary>Lowest permitted node count in a node type.</summary>
        int? Minimum { get; set; }
        /// <summary>Node type capacity scale type.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("None", "Manual", "Automatic")]
        string ScaleType { get; set; }

    }
}