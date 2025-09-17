// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>Describes a node type sku.</summary>
    public partial class NodeTypeSku :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeSku,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeSkuInternal
    {

        /// <summary>Backing field for <see cref="Capacity" /> property.</summary>
        private int _capacity;

        /// <summary>
        /// The number of nodes in the node type. If present in request it will override properties.vmInstanceCount.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public int Capacity { get => this._capacity; set => this._capacity = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>
        /// The sku name. Name is internally generated and is used in auto-scale scenarios. Property does not allow to be changed
        /// to other values than generated. To avoid deployment errors please omit the property.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Tier" /> property.</summary>
        private string _tier;

        /// <summary>Specifies the tier of the node type. Possible Values: **Standard**</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string Tier { get => this._tier; set => this._tier = value; }

        /// <summary>Creates an new <see cref="NodeTypeSku" /> instance.</summary>
        public NodeTypeSku()
        {

        }
    }
    /// Describes a node type sku.
    public partial interface INodeTypeSku :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The number of nodes in the node type. If present in request it will override properties.vmInstanceCount.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The number of nodes in the node type. If present in request it will override properties.vmInstanceCount.",
        SerializedName = @"capacity",
        PossibleTypes = new [] { typeof(int) })]
        int Capacity { get; set; }
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
        string Name { get; set; }
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
        string Tier { get; set; }

    }
    /// Describes a node type sku.
    internal partial interface INodeTypeSkuInternal

    {
        /// <summary>
        /// The number of nodes in the node type. If present in request it will override properties.vmInstanceCount.
        /// </summary>
        int Capacity { get; set; }
        /// <summary>
        /// The sku name. Name is internally generated and is used in auto-scale scenarios. Property does not allow to be changed
        /// to other values than generated. To avoid deployment errors please omit the property.
        /// </summary>
        string Name { get; set; }
        /// <summary>Specifies the tier of the node type. Possible Values: **Standard**</summary>
        string Tier { get; set; }

    }
}