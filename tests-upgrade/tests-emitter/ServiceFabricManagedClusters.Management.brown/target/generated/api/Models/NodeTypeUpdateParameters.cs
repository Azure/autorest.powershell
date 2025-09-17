// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>Node type update request</summary>
    public partial class NodeTypeUpdateParameters :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeUpdateParameters,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeUpdateParametersInternal
    {

        /// <summary>Internal Acessors for Sku</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeSku Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeUpdateParametersInternal.Sku { get => (this._sku = this._sku ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.NodeTypeSku()); set { {_sku = value;} } }

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

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeUpdateParametersTags _tag;

        /// <summary>Node type update parameters</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeUpdateParametersTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.NodeTypeUpdateParametersTags()); set => this._tag = value; }

        /// <summary>Creates an new <see cref="NodeTypeUpdateParameters" /> instance.</summary>
        public NodeTypeUpdateParameters()
        {

        }
    }
    /// Node type update request
    public partial interface INodeTypeUpdateParameters :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable
    {
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
        /// <summary>Node type update parameters</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Node type update parameters",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeUpdateParametersTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeUpdateParametersTags Tag { get; set; }

    }
    /// Node type update request
    internal partial interface INodeTypeUpdateParametersInternal

    {
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
        /// <summary>Node type update parameters</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeUpdateParametersTags Tag { get; set; }

    }
}